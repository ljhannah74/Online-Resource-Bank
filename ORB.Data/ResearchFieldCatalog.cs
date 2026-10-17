using System.Text.RegularExpressions;
namespace Orb.Data;
public static class ResearchFieldCatalog
{
    public static IReadOnlyList<string> Fields(string section) => section switch
    {
        "County" => new string[] { "assessor_url", "comments", "copyFeeAmt", "copy_pmt_method", "copy_source", "county_homepage", "courtImageDate", "courtIndexDate", "court_url", "doc_retrieval", "dtree_desk", "foreclosure_url", "img_date", "index_date", "index_pmt_method", "index_source", "ins", "land_url", "login_required", "map_url", "muniCourt_url", "other_url", "plat_url", "probate_url", "props", "prothon_url", "rv", "sheriff_url", "sub_need", "subscrFeeAmt", "subscr_term", "subscribed", "tap", "tax2_url", "tax_url", "ucc_url" },
        "Statutes" => new string[] { "SOL_AftAcq", "SOL_ClaimLien", "SOL_Creditor_Claims", "SOL_Foreclosure_RedemPer", "SOL_HOA", "SOL_HelocAM", "SOL_HelocRD", "SOL_Hosp", "SOL_Jgmt", "SOL_Mech", "SOL_MtgAM", "SOL_MtgRD", "SOL_Notice", "SOL_PersTax", "SOL_Spousal", "SOL_StateJgmt", "SOL_Support", "SOL_TERule", "SOL_Tax_RedemPer", "SOL_lispen", "SOL_notes", "SOL_Mtg", "SOL_Heloc" },
        "Misc" => new string[] { "Attorney_Close", "Attorney_Notes", "Attorney_Search", "Being_Clause", "DOI_url", "Deed_Notes", "Deed_Prep", "Foreclosure_Notes", "Homestead", "Homestead_Notes", "Policy_Notes", "Probate_Notes", "SecretaryState_url", "State_Code_url" },
        _ => throw new ArgumentException("Unknown research section.", nameof(section))
    };
    public static string Label(string field) => field switch
    {
        "SOL_Mtg" => "Mortgage limitation notes",
        "SOL_Heloc" => "HELOC limitation notes",
        "copyFeeAmt" => "Copy fee",
        "subscrFeeAmt" => "Subscription fee",
        "ins" => "Insurance products online",
        "props" => "Property reports online",
        "tap" => "Tapestry notes",
        "rv" => "RedVision notes",
        _ => Regex.Replace(field.Replace("SOL_", "Limitation: ").Replace("_", " "), "([a-z])([A-Z])", "$1 $2")
    };
}