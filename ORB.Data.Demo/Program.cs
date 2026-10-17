using Orb.Data;

// Create a new database only: never seed or overwrite an existing user's database.
if (args.Length != 1)
{
    Console.Error.WriteLine("Usage: dotnet run --project ORB.Data.Demo -- <new-database-path>");
    return 1;
}
var path = Path.GetFullPath(args[0]);
Directory.CreateDirectory(Path.GetDirectoryName(path)!);
try
{
    using var reservation = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
}
catch (IOException exception)
{
    Console.Error.WriteLine($"Cannot create a new demo database: {exception.Message}");
    return 1;
}
try
{
    var store = new ResourceStore(path);
    store.Initialize();
    var id = store.GetOrAddJurisdiction("DEMO", "Example County (fictional)");
    store.AddResource(id, "Land records", "Example Recorder",
        "https://example.com/land-records", "Fictional demonstration resource.", "Example fee: $1 per page.");
    store.AddResource(id, "Tax", "Example Tax Office",
        "https://example.com/tax", "Fictional demonstration resource.");
    foreach (var resource in store.GetResources(id))
        Console.WriteLine($"{resource.Category}: {resource.Name} — {resource.Url}");
    Console.WriteLine($"Created demo database: {path}");
    return 0;
}
catch (Exception exception)
{
    Console.Error.WriteLine($"Demo creation failed: {exception.Message}");
    Console.Error.WriteLine("The new file may be incomplete. Remove it before retrying.");
    return 1;
}
