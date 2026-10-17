# SQLite migration: first milestone

The new SQLite library is a foundation for replacing Excel. **The existing WinForms application still uses Excel/OleDb.** This milestone does not fix the legacy desktop build or change its screens.

## Run the standalone data layer

Install the .NET 8 SDK. From the repository root:

```powershell
dotnet test ORB.Data.Tests/ORB.Data.Tests.csproj --configuration Release
dotnet run --project ORB.Data.Demo/ORB.Data.Demo.csproj -- "$env:LOCALAPPDATA/OnlineResourceBank/orb-demo.db"
```

The demo command creates a new database containing a fictional county and two example.com resource links. It refuses to overwrite any existing file. Choose a different path to run it again. On Linux, use a writable path such as /tmp/orb-demo.db instead.

## Schema and behavior

- Jurisdictions: state and county, unique together without case sensitivity.
- ResourceLinks: jurisdiction, category, name, URL, notes and fee notes.
- Parameterized commands handle user-supplied values. Foreign keys reject orphan resources.
- Every operation opens and disposes its own connection. Database errors propagate to callers; the future UI must show actionable errors rather than return empty results on failure.
- Only HTTP/HTTPS links are accepted. Database files stay outside source control.
- No username/password fields, production workbook import or automatic data seeding.

These tables are an initial model, not a complete mapping of all historical workbook fields. Before importing anything, map subscription, index/image dates, state notes and other metadata explicitly so nothing is silently discarded. Credentials need separate storage decisions.

## Remaining work

1. Adapt county/resource lookups in ORB_DLL and Form1 to this library.
2. Replace remaining tax, statutes, miscellaneous and edit-screen OleDb calls.
3. Remove Excel/ACE dependencies after all callers are migrated.
4. Verify desktop startup and lookup/edit workflows on Windows.

Run the standalone projects directly for now; they are deliberately independent of the legacy solution. The dedicated SQLite workflow checks these projects on Windows and Linux. It does not certify the desktop application.

This branch builds on the portfolio cleanup PR; review and merge that cleanup first. No original workbook data is included here.
