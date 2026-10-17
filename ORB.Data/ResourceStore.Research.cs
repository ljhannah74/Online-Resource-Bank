using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace Orb.Data;

public sealed record TaxOffice(long Id, long JurisdictionId, string Authority, string AuthorityType,
    string Payee, string Address, string Phone, string Url, string Notes, string VerifiedDate);

public sealed partial class ResourceStore
{
    public void InitializeResearchSchema()
    {
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = """
            CREATE TABLE IF NOT EXISTS CountyResearch (
                JurisdictionId INTEGER PRIMARY KEY REFERENCES Jurisdictions(Id),
                Details TEXT NOT NULL
            );
            CREATE TABLE IF NOT EXISTS StateResearch (
                State TEXT NOT NULL COLLATE NOCASE, Section TEXT NOT NULL,
                Details TEXT NOT NULL, PRIMARY KEY(State, Section)
            );
            CREATE TABLE IF NOT EXISTS TaxOffices (
                Id INTEGER PRIMARY KEY, JurisdictionId INTEGER NOT NULL REFERENCES Jurisdictions(Id),
                Authority TEXT NOT NULL, AuthorityType TEXT NOT NULL DEFAULT '',
                Payee TEXT NOT NULL DEFAULT '', Address TEXT NOT NULL DEFAULT '',
                Phone TEXT NOT NULL DEFAULT '', Url TEXT NOT NULL DEFAULT '',
                Notes TEXT NOT NULL DEFAULT '', VerifiedDate TEXT NOT NULL DEFAULT ''
            );
            """;
        command.ExecuteNonQuery();
    }

    public Dictionary<string, string> GetResearchDetails(string section, string owner)
    {
        ResearchFieldCatalog.Fields(section); // Reject unknown sections before selecting SQL.
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = section == "County"
            ? "SELECT Details FROM CountyResearch WHERE JurisdictionId = $owner;"
            : "SELECT Details FROM StateResearch WHERE State = $owner AND Section = $section;";
        command.Parameters.AddWithValue("$owner", owner);
        if (section != "County") command.Parameters.AddWithValue("$section", section);
        return command.ExecuteScalar() is string json
            ? JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new()
            : new();
    }

    public void SaveResearchDetails(string section, string owner, IReadOnlyDictionary<string, string> values)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(owner);
        var allowed = ResearchFieldCatalog.Fields(section);
        if (values.Keys.Any(key => !allowed.Contains(key)))
            throw new ArgumentException("Unknown research field. Use the section's published field catalog.", nameof(values));
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = section == "County"
            ? "INSERT INTO CountyResearch(JurisdictionId, Details) VALUES ($owner, $details) ON CONFLICT(JurisdictionId) DO UPDATE SET Details=excluded.Details;"
            : "INSERT INTO StateResearch(State, Section, Details) VALUES ($owner, $section, $details) ON CONFLICT(State, Section) DO UPDATE SET Details=excluded.Details;";
        command.Parameters.AddWithValue("$owner", owner);
        command.Parameters.AddWithValue("$details", JsonSerializer.Serialize(values));
        if (section != "County") command.Parameters.AddWithValue("$section", section);
        command.ExecuteNonQuery();
    }

    public IReadOnlyList<TaxOffice> GetTaxOffices(long jurisdictionId)
    {
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT Id, JurisdictionId, Authority, AuthorityType, Payee, Address, Phone, Url, Notes, VerifiedDate FROM TaxOffices WHERE JurisdictionId=$id ORDER BY Authority, Id;";
        command.Parameters.AddWithValue("$id", jurisdictionId);
        using var reader = command.ExecuteReader();
        var rows = new List<TaxOffice>();
        while (reader.Read()) rows.Add(new(reader.GetInt64(0), reader.GetInt64(1), reader.GetString(2),
            reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
            reader.GetString(7), reader.GetString(8), reader.GetString(9)));
        return rows;
    }

    public long AddTaxOffice(TaxOffice office)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(office.Authority);
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO TaxOffices(JurisdictionId, Authority, AuthorityType, Payee, Address, Phone, Url, Notes, VerifiedDate)
            VALUES ($id, $authority, $type, $payee, $address, $phone, $url, $notes, $date);
            SELECT last_insert_rowid();
            """;
        command.Parameters.AddWithValue("$id", office.JurisdictionId);
        command.Parameters.AddWithValue("$authority", office.Authority);
        command.Parameters.AddWithValue("$type", office.AuthorityType);
        command.Parameters.AddWithValue("$payee", office.Payee);
        command.Parameters.AddWithValue("$address", office.Address);
        command.Parameters.AddWithValue("$phone", office.Phone);
        command.Parameters.AddWithValue("$url", office.Url);
        command.Parameters.AddWithValue("$notes", office.Notes);
        command.Parameters.AddWithValue("$date", office.VerifiedDate);
        return Convert.ToInt64(command.ExecuteScalar());
    }
}
