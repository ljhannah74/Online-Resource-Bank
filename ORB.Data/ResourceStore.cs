using Microsoft.Data.Sqlite;

namespace Orb.Data;

public sealed record Jurisdiction(long Id, string State, string County);
public sealed record ResourceLink(long Id, long JurisdictionId, string Category,
    string Name, string Url, string Notes, string FeeNotes);

/// <summary>File-backed SQLite lookups. Call Initialize before using a new database.</summary>
public sealed class ResourceStore
{
    private readonly string connectionString;

    public ResourceStore(string databasePath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(databasePath);
        var fullPath = Path.GetFullPath(databasePath);
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);
        connectionString = new SqliteConnectionStringBuilder
        {
            DataSource = fullPath,
            ForeignKeys = true,
            Pooling = false
        }.ToString();
    }

    private SqliteConnection Open()
    {
        var connection = new SqliteConnection(connectionString);
        try { connection.Open(); return connection; }
        catch { connection.Dispose(); throw; }
    }

    public void Initialize()
    {
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = """
            CREATE TABLE IF NOT EXISTS Jurisdictions (
                Id INTEGER PRIMARY KEY,
                State TEXT NOT NULL COLLATE NOCASE,
                County TEXT NOT NULL COLLATE NOCASE,
                UNIQUE (State, County)
            );
            CREATE TABLE IF NOT EXISTS ResourceLinks (
                Id INTEGER PRIMARY KEY,
                JurisdictionId INTEGER NOT NULL REFERENCES Jurisdictions(Id),
                Category TEXT NOT NULL,
                Name TEXT NOT NULL,
                Url TEXT NOT NULL,
                Notes TEXT NOT NULL DEFAULT '',
                FeeNotes TEXT NOT NULL DEFAULT ''
            );
            CREATE INDEX IF NOT EXISTS IX_ResourceLinks_Jurisdiction
                ON ResourceLinks(JurisdictionId);
            """;
        command.ExecuteNonQuery();
    }

    public long GetOrAddJurisdiction(string state, string county)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(state);
        ArgumentException.ThrowIfNullOrWhiteSpace(county);
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO Jurisdictions(State, County) VALUES ($state, $county)
            ON CONFLICT(State, County) DO NOTHING;
            SELECT Id FROM Jurisdictions WHERE State = $state AND County = $county;
            """;
        command.Parameters.AddWithValue("$state", state.Trim());
        command.Parameters.AddWithValue("$county", county.Trim());
        return Convert.ToInt64(command.ExecuteScalar());
    }

    public IReadOnlyList<string> GetStates()
    {
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT DISTINCT UPPER(State) AS State FROM Jurisdictions ORDER BY State;";
        using var reader = command.ExecuteReader();
        var results = new List<string>();
        while (reader.Read()) results.Add(reader.GetString(0));
        return results;
    }

    public IReadOnlyList<Jurisdiction> GetJurisdictions(string state)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(state);
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT Id, State, County FROM Jurisdictions WHERE State = $state ORDER BY County;";
        command.Parameters.AddWithValue("$state", state.Trim());
        using var reader = command.ExecuteReader();
        var results = new List<Jurisdiction>();
        while (reader.Read())
            results.Add(new(reader.GetInt64(0), reader.GetString(1), reader.GetString(2)));
        return results;
    }

    public long AddResource(long jurisdictionId, string category, string name, string url,
        string notes = "", string feeNotes = "")
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(category);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) ||
            (uri.Scheme != Uri.UriSchemeHttps && uri.Scheme != Uri.UriSchemeHttp))
            throw new ArgumentException("Resource links must be absolute HTTP or HTTPS URLs.", nameof(url));
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO ResourceLinks(JurisdictionId, Category, Name, Url, Notes, FeeNotes)
            VALUES ($jurisdiction, $category, $name, $url, $notes, $fees);
            SELECT last_insert_rowid();
            """;
        command.Parameters.AddWithValue("$jurisdiction", jurisdictionId);
        command.Parameters.AddWithValue("$category", category.Trim());
        command.Parameters.AddWithValue("$name", name.Trim());
        command.Parameters.AddWithValue("$url", url);
        command.Parameters.AddWithValue("$notes", notes ?? "");
        command.Parameters.AddWithValue("$fees", feeNotes ?? "");
        return Convert.ToInt64(command.ExecuteScalar());
    }

    public IReadOnlyList<ResourceLink> GetResources(long jurisdictionId)
    {
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT Id, JurisdictionId, Category, Name, Url, Notes, FeeNotes
            FROM ResourceLinks WHERE JurisdictionId = $jurisdiction ORDER BY Category, Name, Id;
            """;
        command.Parameters.AddWithValue("$jurisdiction", jurisdictionId);
        using var reader = command.ExecuteReader();
        var results = new List<ResourceLink>();
        while (reader.Read())
            results.Add(new(reader.GetInt64(0), reader.GetInt64(1), reader.GetString(2),
                reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
        return results;
    }
}
