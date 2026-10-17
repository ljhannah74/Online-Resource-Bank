using Microsoft.Data.Sqlite;
using Orb.Data;
using Xunit;

namespace Orb.Data.Tests;

public sealed class ResourceStoreTests : IDisposable
{
    private readonly string directory = Path.Combine(Path.GetTempPath(), "orb-tests-" + Guid.NewGuid());
    private string DatabasePath => Path.Combine(directory, "resources.db");
    private ResourceStore NewStore()
    {
        var store = new ResourceStore(DatabasePath);
        store.Initialize();
        return store;
    }

    [Fact]
    public void RecordsPersistAcrossInstances()
    {
        var first = NewStore();
        var id = first.GetOrAddJurisdiction("DEMO", "Example");
        first.AddResource(id, "Tax", "Tax office", "https://example.com/tax", "A note", "$1");
        var second = NewStore();
        Assert.Equal(id, Assert.Single(second.GetJurisdictions("demo")).Id);
        var link = Assert.Single(second.GetResources(id));
        Assert.Equal("https://example.com/tax", link.Url);
        Assert.Equal("A note", link.Notes);
        Assert.Equal("$1", link.FeeNotes);
    }

    [Fact]
    public void JurisdictionsAreUniqueIgnoringCaseAndOuterWhitespace()
    {
        var store = NewStore();
        var first = store.GetOrAddJurisdiction(" DEMO ", " Example ");
        Assert.Equal(first, store.GetOrAddJurisdiction("demo", "example"));
        Assert.Single(store.GetJurisdictions("DEMO"));
    }

    [Fact]
    public void QueriesTreatApostrophesAndSqlAsData()
    {
        var store = NewStore();
        const string state = "D'; DROP TABLE Jurisdictions; --";
        var id = store.GetOrAddJurisdiction(state, "O'Brien");
        Assert.Equal("O'Brien", Assert.Single(store.GetJurisdictions(state)).County);
        Assert.Empty(store.GetJurisdictions("DEMO"));
        store.AddResource(id, "Land", "Recorder's office", "https://example.com");
        Assert.Single(store.GetResources(id));
    }

    [Fact]
    public void ResourcesStayWithinTheirJurisdiction()
    {
        var store = NewStore();
        var first = store.GetOrAddJurisdiction("DEMO", "One");
        var second = store.GetOrAddJurisdiction("DEMO", "Two");
        store.AddResource(first, "Tax", "One tax", "https://example.com/one");
        Assert.Empty(store.GetResources(second));
        Assert.Single(store.GetResources(first));
    }

    [Fact]
    public void MissingJurisdictionIsRejectedByForeignKey()
    {
        var store = NewStore();
        var error = Assert.Throws<SqliteException>(() =>
            store.AddResource(999, "Tax", "Missing", "https://example.com"));
        Assert.Equal(19, error.SqliteErrorCode);
    }

    [Theory]
    [InlineData("file:///etc/passwd")]
    [InlineData("javascript:alert(1)")]
    [InlineData("relative/link")]
    public void NonWebLinksAreRejected(string url)
    {
        var store = NewStore();
        var id = store.GetOrAddJurisdiction("DEMO", "Example");
        Assert.Throws<ArgumentException>(() => store.AddResource(id, "Tax", "Example", url));
        Assert.Empty(store.GetResources(id));
    }

    [Fact]
    public void StatesAreDistinctSortedAndEmptyDatabaseHasNoResults()
    {
        var store = NewStore();
        Assert.Empty(store.GetStates());
        store.GetOrAddJurisdiction("ZZ", "One");
        store.GetOrAddJurisdiction("AA", "Two");
        store.GetOrAddJurisdiction("aa", "Three");
        Assert.Equal(new[] { "AA", "ZZ" }, store.GetStates());
    }

    [Fact]
    public void NationalSeedCoversAllStatesAndCountyEquivalents()
    {
        var store = NewStore();
        Assert.Equal(3222, store.SeedUsJurisdictions());
        var states = store.GetStates();
        Assert.Equal(52, states.Count); // 50 states, D.C. and Puerto Rico.
        Assert.Equal(3222, states.Sum(state => store.GetJurisdictions(state).Count));
        Assert.Equal(67, store.GetJurisdictions("PA").Count);
        Assert.Contains(store.GetJurisdictions("PA"), c => c.County == "Washington County");
        Assert.Equal(254, store.GetJurisdictions("TX").Count);
        Assert.Equal(9, store.GetJurisdictions("CT").Count);
        Assert.All(store.GetJurisdictions("CT"), c => Assert.EndsWith("Planning Region", c.County));
        Assert.Contains(store.GetJurisdictions("LA"), c => c.County == "Orleans Parish");
        Assert.Contains(store.GetJurisdictions("AK"), c => c.County.Contains("Borough"));
        Assert.Contains(store.GetJurisdictions("VA"), c => c.County == "Richmond city");
        Assert.Single(store.GetJurisdictions("DC"));
        Assert.Equal(78, store.GetJurisdictions("PR").Count);
        Assert.All(store.GetJurisdictions("PA"), c => Assert.Empty(store.GetResources(c.Id)));
    }

    [Fact]
    public void RepeatedSeedPreservesIdsCustomCountiesAndResourceLinks()
    {
        var store = NewStore();
        long id = store.GetOrAddJurisdiction("PA", "Washington County");
        long custom = store.GetOrAddJurisdiction("DEMO", "My custom county");
        long resourceId = store.AddResource(id, "Land", "Existing resource", "https://example.com");
        Assert.Equal(3221, store.SeedUsJurisdictions());
        Assert.Equal(0, store.SeedUsJurisdictions());
        Assert.Equal(id, store.GetOrAddJurisdiction("PA", "Washington County"));
        Assert.Equal(custom, Assert.Single(store.GetJurisdictions("DEMO")).Id);
        Assert.Equal(resourceId, Assert.Single(store.GetResources(id)).Id);
    }

    [Fact]
    public void FailedSeedRollsBackAllInsertedRows()
    {
        var store = NewStore();
        using (var connection = new SqliteConnection(new SqliteConnectionStringBuilder { DataSource = DatabasePath, Pooling = false }.ToString()))
        {
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = """
                CREATE TRIGGER InterruptSeed BEFORE INSERT ON Jurisdictions
                WHEN NEW.State = 'PA'
                BEGIN SELECT RAISE(ABORT, 'Simulated seed failure'); END;
                """;
            command.ExecuteNonQuery();
        }
        Assert.Throws<SqliteException>(() => store.SeedUsJurisdictions());
        Assert.Empty(store.GetStates());
    }

    public void Dispose()
    {
        if (Directory.Exists(directory)) Directory.Delete(directory, recursive: true);
    }
}
