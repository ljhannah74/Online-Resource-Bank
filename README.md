# Online Resource Bank

A C# WinForms title-research application using SQLite in the **original Online Resource Bank screen layout**.

## Restored screen

The original panels, colors, fonts, artwork and five tabs remain in place. The application starts Form1 again; the earlier simplified grid is no longer the default screen.

- State/county selection and SEARCH load SQLite resource links and detailed research fields.
- RESET clears previous county and state results.
- Original resource-link controls open configured HTTP/HTTPS websites.
- County fee, subscription, index/image and research notes are stored in SQLite.
- Clearing/statute notes and miscellaneous notes are scoped to the state.
- Tax-authority/type filters display saved tax offices in the original five office panels.
- EDIT ORB opens a section editor for county details, state clearing notes and miscellaneous notes. Use **Save current tab** before closing or moving to another section; each section is saved separately.
- HELP opens database selection and **Add U.S. counties** commands.

This is a restoration milestone, not complete historical feature parity. Tax-office entry/editing, live account records, policy warehouse/rate calculator, company network-file tools and some legacy statistics remain to be migrated or configured. Those external integrations do not silently attempt to use old workstation paths. Existing legal/state notes are user-maintained reference data; no substantive legal guidance is seeded.

## Run on Windows

Install the .NET 8 SDK (or Visual Studio with .NET desktop development). Open `web_links_ORB.sln` and set `web_links_ORB` as the startup project.

To create a fictional demo and open it in the restored screen:

```powershell
dotnet run --project ORB.Data.Demo/ORB.Data.Demo.csproj -- "$env:LOCALAPPDATA/OnlineResourceBank/orb-demo.db"
dotnet run --project web_links_ORB.csproj -- --database "$env:LOCALAPPDATA/OnlineResourceBank/orb-demo.db"
```

The generator refuses to overwrite files; choose a different filename if it already exists. Select DEMO and its fictional county, then click SEARCH. Existing demo databases work with the restored screen; the additional research tables are created without replacing their jurisdictions or resource links.

Without arguments, the application uses `%LOCALAPPDATA%/OnlineResourceBank/resources.db`. New databases receive the bundled 3,222 Census counties/county equivalents for all 50 states, D.C. and Puerto Rico. In existing databases, use **HELP → Add U.S. counties**. [Geography coverage and provenance](docs/geography-data.md).

## Build and test

```powershell
dotnet build web_links_ORB.sln --configuration Release
dotnet test ORB.Data.Tests/ORB.Data.Tests.csproj --configuration Release
```

The data tests run on Windows and Linux. CI also builds Debug/Release and runs the restored original form against the demo, checking its tabs/artwork, resource controls, research-field persistence and stale-result clearing. Visual appearance and launching the local browser still require a manual Windows check.

## Structure

| Path | Purpose |
| --- | --- |
| Form1.cs | SQLite-backed handlers and original-screen behavior |
| Form1.Layout.cs | Original InitializeComponent, extracted with updated event wiring |
| Form1.Designer.cs | Original control declarations and disposal |
| Form1.Bindings.cs | Research field and resource category/control mappings |
| OriginalResources.cs | Original artwork, decoded directly from its existing image data |
| ResearchDetailsEditor.cs | County/state research section editor |
| ORB.Data | Geography, resource links, research profiles and tax office persistence |
| ORB.Data.Demo / ORB.Data.Tests | Fictional data generator and integration tests |
| SqliteResourceForm.cs | Prior simplified screen retained as reference source |
| ORB_DLL and other legacy forms | Historical source excluded from the active solution |

## Data compatibility

New tables are additive: CountyResearch stores county profiles; StateResearch stores clearing/miscellaneous state profiles; TaxOffices stores tax office details. Existing Jurisdictions and ResourceLinks are retained. Detailed county link fields override the displayed defaults from ResourceLinks; saving a detailed profile does not delete or rewrite those source links.

The original workbook is not imported, and original credentials are not republished. The original account controls are retained in the layout but not populated from the old data. Previously published workbook history remains a separate cleanup concern.

See [restoration scope](docs/original-layout-restoration.md) for remaining work.
