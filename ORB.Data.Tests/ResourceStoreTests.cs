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

    public void Dispose()
    {
        if (Directory.Exists(directory)) Directory.Delete(directory, recursive: true);
    }
}
