# U.S. jurisdiction seed data

## Source and coverage

The bundled snapshot derives from the U.S. Census Bureau **2026 National Counties Gazetteer File**, downloaded October 17, 2026:

- [Gazetteer files and coverage notes](https://www.census.gov/geographies/reference-files/time-series/geo/gazetteer-files.html)
- [Original ZIP](https://www2.census.gov/geo/docs/maps-data/data/gazetteer/2026_Gazetteer/2026_Gaz_counties_national.zip)
- ZIP SHA-256: `6a99ca00efbc0be5112e225d4102704c51d5ce3b16e3afd6e4159460595fd12a`

The extracted subset contains **3,222 counties/county equivalents** across **all 50 states, D.C. and Puerto Rico** (52 state/territory codes). It includes parishes, boroughs, census areas, independent cities, Connecticut's nine planning regions and Puerto Rico's 78 municipios. The Gazetteer does not include American Samoa, Guam, the Northern Mariana Islands or the U.S. Virgin Islands.

This is Census geographic coverage, not a directory of recording offices. Connecticut land research may still use historical county names or town recording offices; planning regions are not a replacement for determining the correct recording jurisdiction.

## Transformation

`ORB.Data/Data/us-counties-2026.tsv` retains USPS state abbreviation, official NAME and five-digit GEOID (FIPS), sorted by state/name. It omits coordinates and area measurements. Official suffixes such as County, Parish, city and Planning Region are preserved. The current database stores state/county names; FIPS codes are retained in the source snapshot for traceability and potential future schema work.

To reproduce the exact snapshot:

```powershell
python scripts/update_county_seed.py
```

This maintenance script downloads data; ordinary application use does not. The archive hash is pinned so an upstream change requires deliberate review. A future vintage should be reviewed for renamed/retired entities before updating; the app does not automatically reconcile renamed counties.

## Application behavior

- A newly created default database is initialized and seeded locally on first run.
- Existing databases are unchanged until **Add U.S. counties** is clicked.
- The button adds missing exact state/name pairs in a single transaction.
- Existing IDs, custom jurisdictions, resource links, notes and fees are preserved.
- Repeating the seed inserts zero additional rows.
- A seed failure rolls back all inserts.
- The fictional demo remains separate until its seed button is clicked.
- No resource websites are created. Most counties therefore show **No resources for this county** until links are added.

Name matching is case insensitive but otherwise exact. A custom entry named Washington and the official Washington County are different records; the seed does not guess which custom records should be merged.
