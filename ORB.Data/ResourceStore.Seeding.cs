using Microsoft.Data.Sqlite;

namespace Orb.Data;

public sealed partial class ResourceStore
{
    /// <summary>
    /// Adds the bundled 2026 Census counties and county equivalents.
    /// Existing IDs, resource links and custom jurisdictions are preserved.
    /// Returns the number inserted; repeating the operation inserts zero.
    /// </summary>
    public int SeedUsJurisdictions()
    {
        using var stream = typeof(ResourceStore).Assembly.GetManifestResourceStream("Orb.Data.UsCounties2026")
            ?? throw new InvalidOperationException("The bundled U.S. county list is missing.");
        using var reader = new StreamReader(stream);
        if (reader.ReadLine() != "State\tCounty\tFips")
            throw new InvalidDataException("Unexpected county seed format.");

        using var connection = Open();
        using var transaction = connection.BeginTransaction();
        using var command = connection.CreateCommand();
        command.Transaction = transaction;
        command.CommandText = """
            INSERT INTO Jurisdictions(State, County) VALUES ($state, $county)
            ON CONFLICT(State, County) DO NOTHING;
            """;
        var state = command.Parameters.Add("$state", SqliteType.Text);
        var county = command.Parameters.Add("$county", SqliteType.Text);
        command.Prepare();
        int inserted = 0;
        while (reader.ReadLine() is { } line)
        {
            var fields = line.Split('\t');
            if (fields.Length != 3 || fields[0].Length != 2 ||
                string.IsNullOrWhiteSpace(fields[1]) || fields[2].Length != 5 ||
                !fields[2].All(char.IsAsciiDigit))
                throw new InvalidDataException("Invalid row in the bundled U.S. county list.");
            state.Value = fields[0];
            county.Value = fields[1];
            inserted += command.ExecuteNonQuery();
        }
        transaction.Commit();
        return inserted;
    }
}
