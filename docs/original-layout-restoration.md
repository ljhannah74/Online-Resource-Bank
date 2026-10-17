# Original screen restoration

Form1 is the application entry point again. Its original InitializeComponent was extracted into Form1.Layout.cs with only event wiring changes; Form1.Designer.cs retains the original declarations. The original artwork bytes are decoded directly, avoiding obsolete resource serialization dependencies.

## SQLite mapping

- Existing ResourceLinks supply category-based defaults for the original website controls.
- CountyResearch contains the original county metadata fields (subscription, fee, source, dates and notes) in a JSON profile keyed by a foreign-key jurisdiction ID.
- StateResearch stores separate Statutes and Misc JSON profiles, keyed by state and section.
- ResearchFieldCatalog explicitly limits accepted fields. Password/user fields are not copied into these profiles.
- TaxOffices stores authority/type, payee, address, phone, website, notes and verification date.
- The original five tax panels display up to five matching offices.
- Existing database schema/data is preserved; research tables are added on startup.
- County profile URL fields override the original screen's defaults from normalized links. This bridge is explicit; the simplified screen does not read the rich profiles.

## Editor scope

EDIT ORB opens county, clearing and miscellaneous sections. Save current tab persists only that section. State sections apply across counties in the same state. The editor is new; this first milestone restores the original main screen rather than the old incomplete editing forms.

## Remaining work

Tax-office management, customer specifications, account records, policy warehouse/rate calculation, external company document tools and full historical statistics are not yet restored. Unconfigured integrations display a message. No original workbook import is included. Exact recording-office requirements and state notes must come from reviewed data rather than fabricated examples.

## Manual review

1. Generate a new demo database, or open an existing one.
2. Confirm the original panels and five tabs appear; select DEMO and SEARCH.
3. Confirm Land Index and Taxes links are enabled and fictional notes appear.
4. Use EDIT ORB to save a copy source/fee, a clearing note and a state miscellaneous note, saving each tab.
5. Search again; switch counties/states and confirm no old details remain.
6. Reopen the same database and confirm saved notes remain.
7. Use HELP to select another database or add the national geography seed.

CI covers original form initialization, its artwork/tabs, normalized demo resource mapping, county/state detail round trips, clearing/reselecting state, additive database migrations and existing resource preservation. Browser launch and visual layout require manual Windows review.
