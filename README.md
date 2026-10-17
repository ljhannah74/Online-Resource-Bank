# Online Resource Bank

A C# Windows Forms application for organizing the online resources used in title research. It brings county recorders, assessors, tax authorities, court records, and related research references into a state/county lookup workflow.

This project connects my title-research background with desktop application development. My newer web portfolio projects are [ClientDesk](https://github.com/ljhannah74/ClientDesk) and [Employee Management System](https://github.com/ljhannah74/EmployeeManagementSystem).

## Project status

**Legacy application undergoing cleanup and modernization.** The current source has .NET 8 project targets, but still contains older framework dependencies and workstation-specific paths. A fresh-clone build and Windows runtime have not been verified. This is not currently a turnkey download.

The original data workbook is intentionally excluded from the cleaned source because it contains populated credential-related fields. A fictional SQLite demo is now available for the standalone data layer; the desktop screens are not yet connected to it.

### SQLite migration in progress

`ORB.Data` provides SQLite county/resource lookups with parameterized queries and foreign keys. `ORB.Data.Demo` generates a new database with fictional example.com links. `ORB.Data.Tests` and the dedicated SQLite workflow exercise persistence and validation on Windows and Linux. See [SQLite setup and migration scope](docs/sqlite-migration.md) for runnable commands. These checks cover the new data layer only; the legacy desktop application still uses Excel.

## Business purpose and features

Title researchers need to locate recording, tax, assessment, and court resources across many jurisdictions. Online Resource Bank organizes these references in one desktop interface.

The source includes:
- State and county selection with resource lookup.
- Land-record, court, assessor, tax, and related website references.
- Research notes, document availability, subscription, and fee metadata.
- Additional tax, statute, and state-reference lookups.
- Legacy forms for editing and maintaining resource information.

The legacy data model also includes username/password fields. These are not a secure credential-storage design and should not be used for live credentials.

## Historical screenshots

These show an earlier application version; they are not evidence of a verified build of the current .NET 8 source.

### Resource lookup
![Historical Online Resource Bank main screen](https://user-images.githubusercontent.com/70963125/202032139-24e2c40d-181e-4298-90ed-796bc73fe0c0.jpg)

### Search results
![Historical Online Resource Bank search results](https://user-images.githubusercontent.com/70963125/202032143-39688c70-9309-4377-abd5-3c2dba7125e0.jpg)

## Technology and structure

| Area | Implementation |
| --- | --- |
| Desktop UI | C#, Windows Forms |
| Application project | `web_links_ORB.csproj`, targeting `net8.0-windows` |
| Lookup library | `ORB_DLL/ORB_DLL.csproj`, targeting `net8.0` |
| Data access | ADO.NET/OleDb with Excel workbooks |
| Legacy integration | Excel COM interop and ClickOnce-related code |
| Dependency versions | Central package management in `Directory.Packages.props` |

- `Form1.cs` and its designer/resources: main application interface.
- `ORB_DLL/Orb/`: resource models, lookup classes, and editing forms.
- `Program.cs`: Windows Forms entry point.
- `web_links_ORB.sln`: root solution.
- `.github/workflows/dotnet-desktop.yml`: existing desktop workflow template; see limitations below.

Designer `.cs` and `.resx` files are application source assets and remain tracked. Build output, caches, and restored package binaries are not source assets.

## Development prerequisites

Use Windows and Visual Studio with the **.NET desktop development** workload and .NET 8 SDK. OleDb workbook access additionally needs the appropriate Microsoft Access Database Engine/ACE provider, with architecture matching the application process. Legacy Jet, Excel interop, and .NET Framework deployment code need review before the application can be considered modernized.

Start by inspecting the solution:

```powershell
git clone https://github.com/ljhannah74/Online-Resource-Bank.git
cd Online-Resource-Bank
dotnet restore .\web_links_ORB.sln
dotnet build .\web_links_ORB.sln --configuration Release
```

These are diagnostic development commands, not a claim that a fresh clone builds successfully today.

### Known setup blockers

1. **Missing local references:** the main project points to `web_links_ORBReferences/UniversalRateCalc.exe` and `Interop.Excel.dll`, which are not included. Determine which references are still needed and replace or remove them through a separate build repair.
2. **Framework migration:** `System.Deployment.Application` and older generated Visual Basic application code need compatibility review against the current targets. OleDb package references also need resolution.
3. **Data paths and formats:** lookup classes use `Data/ORB_DATABASE.xlsx`, while other code uses older `.xls` files and hard-coded `T:` drive paths. These need a configurable, consistent data location.
4. **Sample data:** the legacy workbook is not distributed with the cleaned project. Supply only an approved sanitized dataset; the app expects worksheets such as `orb`, `taxes`, `statutes`, `misc`, and `other_logins`. Individual lookup classes define the required columns. A safe generated example is planned.
5. **Workflow template:** the existing desktop workflow contains placeholder test/packaging paths and certificate configuration. It does not yet provide a verified build, test, or installer pipeline.

Do not work around missing references by committing workstation binaries or real account data.

## Repository cleanup

This cleanup removes tracked `bin/`, `obj/`, restored package binaries, and copies of the legacy workbook from the proposed branch. The existing Visual Studio ignore rules are retained, with an explicit exclusion for the local ORB workbook.

Deleting a workbook from the current tree does not delete earlier Git versions. Previously published credentials must be reviewed and rotated where valid; repository-history cleanup is separate from this PR.

## Next improvements

1. Replace the legacy workbook with a small synthetic dataset and document its schema.
2. Repair the Windows build and remove obsolete or missing references.
3. Replace hard-coded paths and consolidate workbook access.
4. Parameterize lookup queries and improve error handling/resource disposal.
5. Add focused lookup tests and replace the placeholder workflow with a verified Windows build.
6. Capture new screenshots using fictional data.
