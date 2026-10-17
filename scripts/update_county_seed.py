"""Reproduce the bundled 2026 Census snapshot (Python standard library only)."""
import csv
import hashlib
import io
from pathlib import Path
import urllib.request
import zipfile

URL = "https://www2.census.gov/geo/docs/maps-data/data/gazetteer/2026_Gazetteer/2026_Gaz_counties_national.zip"
EXPECTED_SHA256 = "6a99ca00efbc0be5112e225d4102704c51d5ce3b16e3afd6e4159460595fd12a"
TARGET = Path(__file__).resolve().parents[1] / "ORB.Data" / "Data" / "us-counties-2026.tsv"


def main():
    request = urllib.request.Request(URL, headers={"User-Agent": "OnlineResourceBank-geography-refresh"})
    with urllib.request.urlopen(request, timeout=60) as response:
        archive = response.read()
    if hashlib.sha256(archive).hexdigest() != EXPECTED_SHA256:
        raise ValueError("The upstream archive changed. Review its vintage/content before updating the pinned hash.")
    with zipfile.ZipFile(io.BytesIO(archive)) as zipped:
        text = zipped.read("2026_Gaz_counties_national.txt").decode("utf-8-sig")
    rows = list(csv.DictReader(io.StringIO(text), delimiter="|"))
    if len(rows) != 3222 or len({r["USPS"] for r in rows}) != 52 or len({r["GEOID"] for r in rows}) != 3222:
        raise ValueError("Unexpected geographic coverage.")
    rows.sort(key=lambda row: (row["USPS"], row["NAME"]))
    lines = ["State\tCounty\tFips\n"]
    for row in rows:
        fields = (row["USPS"], row["NAME"], row["GEOID"])
        if any("\t" in value or "\n" in value or "\r" in value for value in fields):
            raise ValueError("Unexpected separator in geographic name.")
        lines.append("\t".join(fields) + "\n")
    TARGET.parent.mkdir(parents=True, exist_ok=True)
    TARGET.write_text("".join(lines), encoding="utf-8", newline="")
    print(f"Wrote {len(rows)} counties/county equivalents to {TARGET}")


if __name__ == "__main__":
    main()
