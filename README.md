# Online Resource Bank

A C# WinForms application for finding title-research resources by state and county. The migrated lookup screen uses SQLite and runs without Excel, ACE, network-drive paths or private account data.

## Current functionality

- Select a state and county from the SQLite database.
- Browse resource names, categories and website links.
- Read research notes and fee information.
- Open a selected HTTP/HTTPS link in the default browser.
- Open another ORB SQLite database or reload changes made outside the app.
- Populate all 50 states, D.C. and Puerto Rico with 3,222 Census counties/county equivalents using the bundled offline seed.
- Clear previous results when selections change and display database errors.

**This migration milestone is read-only.** The original forms and lookup classes remain in the repository, but are excluded from the active application build. Editing, tax-office detail, statutes, workbook statistics and other historical features are not yet migrated. Their presence in source does not mean they are available in the new screen. No legacy workbook import is included.

## Run on Windows

Install the .NET 8 SDK (or Visual Studio with .NET desktop development). From the repository root, create a fictional demo database:

```powershell
dotnet run --project ORB.Data.Demo/ORB.Data.Demo.csproj -- "$env:LOCALAPPDATA/OnlineResourceBank/orb-demo.db"
dotnet run --project web_links_ORB.csproj -- --database "$env:LOCALAPPDATA/OnlineResourceBank/orb-demo.db"
```

The generator refuses to overwrite an existing file. Use a new filename if the demo already exists. It contains only a fictional county and two example.com links; no real research data or credentials.

Running without arguments creates and seeds a database at `%LOCALAPPDATA%/OnlineResourceBank/resources.db`. Use **Open database** to select the generated demo. New default databases receive the bundled Census geography list. Existing databases (including the demo) are changed only when you click **Add U.S. counties**; this preserves their existing resource links. No workbook or account data is imported. See [geographic data coverage and provenance](docs/geography-data.md).

```powershell
dotnet build web_links_ORB.csproj --configuration Release
dotnet test ORB.Data.Tests/ORB.Data.Tests.csproj --configuration Release
```

The data library and its tests run on Linux too; the desktop application requires Windows. Open `web_links_ORB.sln` in Visual Studio and set `web_links_ORB` as the startup project. The solution contains the desktop application, SQLite library, demo generator and tests. The legacy ORB_DLL project remains in source but is excluded from this solution. Both Debug and Release solution builds are checked in CI.

## Structure

| Path | Purpose |
| --- | --- |
| Program.cs, SqliteResourceForm.cs | Active WinForms entry point and lookup screen |
| ORB.Data | SQLite schema, parameterized queries and typed records |
| ORB.Data.Demo | Fictional database generator with overwrite protection |
| ORB.Data.Tests | SQLite integration tests using temporary files |
| Form1.*, ORB_DLL, other historical forms | Preserved legacy source, excluded from the active application |
| .github/workflows/dotnet-desktop.yml | Windows build and actual WinForms binding smoke check |
| .github/workflows/sqlite-data.yml | Data-layer checks on Windows and Linux |

See [migration notes](docs/sqlite-migration.md) for limitations and next steps.

## Manual check

1. Run the app with the generated demo.
2. Confirm DEMO and Example County (fictional) are selected and two resource rows appear.
3. Select each resource; check its notes and fee text.
4. Open a link; it should use the default browser and example.com.
5. Reload or open another database; confirm old resource details are cleared.
6. Run without arguments to create a seeded default database, or click **Add U.S. counties** in an existing database. Select PA and confirm 67 counties, including Washington County. Counties without resource links display an empty-state message.
7. Click **Add U.S. counties** again; it should report zero new rows and keep existing links.

CI exercises the WinForms controls and selection events on Windows. Visual appearance and opening the user's browser still require a manual Windows check.

## Data handling

Local database files, build output and original ORB workbooks are ignored. The new schema has no username/password fields. Previously published workbook data remains a separate repository-history concern; deleting files from the current tree does not remove earlier Git versions.

My web portfolio projects are [ClientDesk](https://github.com/ljhannah74/ClientDesk) and [Employee Management System](https://github.com/ljhannah74/EmployeeManagementSystem).
