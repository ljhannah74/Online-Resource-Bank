# SQLite migration

## Completed in this milestone

The active WinForms application now uses ORB.Data for state/county/resource lookups. Its project explicitly compiles Program.cs and SqliteResourceForm.cs and references ORB.Data; no Excel, ACE or legacy ORB_DLL dependency is required for this screen. Historical sources are preserved but excluded from this build.

The database contains Jurisdictions (state/county) and ResourceLinks (category, name, URL, notes, fee notes). State/county comparisons are case insensitive. Queries are parameterized and foreign keys reject orphan resources. The application reads existing databases and initializes an empty database only when its default app-data file does not exist. New default databases are seeded from the bundled Census geography snapshot. Existing databases are seeded only through the Add U.S. counties button; no workbook import occurs. See [geography data](geography-data.md) for coverage and preservation behavior.

Use the README commands to generate the optional fictional demo and launch the desktop. The generator refuses to overwrite files. Database failures are displayed with reload/open-database recovery options; they are not converted to successful empty results.

## Verification

The dedicated Windows workflow builds the application, tests SQLite and runs `--smoke-test <demo-path>` against actual WinForms controls. The smoke check covers initial binding, resource details, clearing the state and reselecting it. It does not open external websites. The data workflow checks persistence and validation on Windows and Linux.

## Remaining migration

- Editing and maintaining jurisdictions/resources.
- Tax-office details, statutes and state-reference lookups.
- Map all historical subscription, date, availability and other metadata explicitly before any optional workbook import.
- Review any credential storage separately; there are no credential columns in the new schema.
- Port other historical features only after their requirements are reviewed.
- Capture current screenshots after a manual Windows visual check.

The root `web_links_ORB.sln` contains only the active SQLite application, data library, demo and tests. Open it in Visual Studio and set `web_links_ORB` as the startup project. The standalone ORB_DLL project is retained as historical source; it is excluded from the active solution because its old Visual Basic/framework dependencies have not been migrated. CI builds the root solution in Debug and Release.
