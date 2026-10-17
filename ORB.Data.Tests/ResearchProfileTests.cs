using Orb.Data;
using Xunit;

namespace Orb.Data.Tests;

public sealed class ResearchProfileTests : IDisposable
{
    private readonly string path = Path.Combine(Path.GetTempPath(), "orb-research-" + Guid.NewGuid(), "research.db");
    private ResourceStore Store()
    {
        var store = new ResourceStore(path);
        store.Initialize();
        store.InitializeResearchSchema();
        return store;
    }

    [Fact]
    public void DetailedFieldsPersistWithoutChangingExistingResources()
    {
        var store = Store();
        long id = store.GetOrAddJurisdiction("DEMO", "O'Brien County");
        long link = store.AddResource(id, "Land records", "Existing", "https://example.com");
        var values = new Dictionary<string, string> { ["comments"] = "O'Brien's notes; DROP TABLE Jurisdictions;", ["copyFeeAmt"] = "$1 per page", ["index_date"] = "2000-01-01" };
        store.SaveResearchDetails("County", id.ToString(), values);
        var reopened = Store();
        Assert.Equal(values["comments"], reopened.GetResearchDetails("County", id.ToString())["comments"]);
        Assert.Equal(values["copyFeeAmt"], reopened.GetResearchDetails("County", id.ToString())["copyFeeAmt"]);
        Assert.Equal(link, Assert.Single(reopened.GetResources(id)).Id);
        Assert.Single(reopened.GetJurisdictions("DEMO"));
    }

    [Fact]
    public void StateSectionsAndCountiesRemainSeparate()
    {
        var store = Store();
        long id = store.GetOrAddJurisdiction("DEMO", "One");
        long other = store.GetOrAddJurisdiction("DEMO", "Two");
        store.SaveResearchDetails("Statutes", "DEMO", new Dictionary<string, string> { ["SOL_notes"] = "Fictional clearing notes" });
        store.SaveResearchDetails("Misc", "DEMO", new Dictionary<string, string> { ["Policy_Notes"] = "Fictional policy notes" });
        store.SaveResearchDetails("County", id.ToString(), new Dictionary<string, string> { ["comments"] = "County one" });
        Assert.Empty(store.GetResearchDetails("County", other.ToString()));
        Assert.Empty(store.GetResearchDetails("Statutes", "PA"));
        Assert.Equal("Fictional policy notes", store.GetResearchDetails("Misc", "demo")["Policy_Notes"]);
        Assert.Equal("Fictional clearing notes", store.GetResearchDetails("Statutes", "DEMO")["SOL_notes"]);
    }

    [Fact]
    public void UnknownSectionsAndFieldsAreRejected()
    {
        var store = Store();
        Assert.Throws<ArgumentException>(() => store.GetResearchDetails("Wrong", "DEMO"));
        Assert.Throws<ArgumentException>(() => store.SaveResearchDetails("Misc", "DEMO", new Dictionary<string, string> { ["county_pwd"] = "not stored" }));
    }

    [Fact]
    public void TaxOfficeDetailsAreScopedAndPersist()
    {
        var store = Store();
        long id = store.GetOrAddJurisdiction("DEMO", "One");
        long other = store.GetOrAddJurisdiction("DEMO", "Two");
        long office = store.AddTaxOffice(new(0, id, "Fictional authority", "County", "Example payee", "Example address", "", "https://example.com/tax", "Fictional notes", ""));
        Assert.Empty(store.GetTaxOffices(other));
        Assert.Equal(office, Assert.Single(Store().GetTaxOffices(id)).Id);
        Assert.Equal("Fictional notes", Assert.Single(Store().GetTaxOffices(id)).Notes);
    }

    public void Dispose() { if (Directory.Exists(Path.GetDirectoryName(path))) Directory.Delete(Path.GetDirectoryName(path)!, true); }
}
