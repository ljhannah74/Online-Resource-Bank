using System.Diagnostics;
using System.Globalization;
using Orb.Data;

namespace WindowsApplication1;

public partial class Form1 : Form
{
    private readonly Label lbl_NotFound = new() { Dock = DockStyle.Bottom, Height = 24, ForeColor = Color.Firebrick };
    private ResourceStore store;
    private string databasePath;
    private bool loading = true;
    private readonly ToolTip databaseTip = new();
    private readonly Dictionary<string, Control> controls = new();
    private readonly Dictionary<string, string> countyValues = new();
    private readonly Dictionary<string, string> stateValues = new();
    private IReadOnlyList<TaxOffice> taxOffices = Array.Empty<TaxOffice>();
    private Jurisdiction? SelectedCounty => ComboBoxCounty.SelectedItem as Jurisdiction;

    public Form1(string path, bool createIfMissing)
    {
        databasePath = path;
        store = new ResourceStore(path);
        InitializeComponent();
        Controls.Add(lbl_NotFound);
        CollectControls(this);
        LinkLabelAssessor.LinkClicked += OriginalLinkClicked;
        LinkLabelPlats.LinkClicked += OriginalLinkClicked;
        LinkLabel_OtherURL.LinkClicked += OriginalLinkClicked;
        LinkLabel_UCC.LinkClicked += OriginalLinkClicked;
        LinkLabel_DeptIns.LinkClicked += OriginalLinkClicked;
        LinkLabel_SecState.LinkClicked += OriginalLinkClicked;
        LinkLabel_State_Code.LinkClicked += OriginalLinkClicked;
        foreach (var pair in controls)
        {
            if (pair.Key.StartsWith("txt_login") || pair.Key is "txt_myfl_U" or "txt_myfl_P")
            {
                pair.Value.Text = "";
                pair.Value.Enabled = false;
            }
        }
        Label_user.Text = "Username";
        Label_pwd.Text = "Password";
        Label56.Text = "Online Resource Bank — SQLite";
        Label32.Text = DateTime.Today.ToLongDateString();
        lblDefault_UW_Name.Text = "";
        Panel2.Visible = false;
        Text = "ORB - Online Resource Bank (SQLite)";
        DataGridView2.DataSource = new[] { new { Information = "Account records have not been imported." } };
        DataGridView2.ReadOnly = true;
        Load += (_, _) => Guard(() => LoadDatabase(path, createIfMissing));
        FormClosed += (_, _) => databaseTip.Dispose();
        loading = false;
    }

    private void CollectControls(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            if (control.Name.Length > 0) controls[control.Name] = control;
            CollectControls(control);
        }
    }

    private void Guard(Action action)
    {
        if (loading) return;
        try { action(); }
        catch (Exception exception)
        {
            ClearResults();
            lbl_NotFound.Text = "Unable to load SQLite data: " + exception.Message;
            lbl_NotFound.Visible = true;
        }
    }

    private void LoadDatabase(string path, bool createIfMissing)
    {
        loading = true;
        try
        {
            ClearResults();
            ComboBoxCounty.DataSource = null;
            ComboBoxState.Items.Clear();
            if (!File.Exists(path) && !createIfMissing) throw new FileNotFoundException("Database not found.", path);
            bool isNew = !File.Exists(path);
            var candidate = new ResourceStore(path);
            if (isNew) candidate.Initialize();
            candidate.InitializeResearchSchema();
            if (isNew) candidate.SeedUsJurisdictions();
            var states = candidate.GetStates();
            store = candidate;
            databasePath = path;
            ComboBoxState.Items.AddRange(states.Cast<object>().ToArray());
            cbox_StatsStates.Items.Clear();
            cbox_StatsStates.Items.AddRange(states.Cast<object>().ToArray());
            databaseTip.SetToolTip(ButtonHelp, "Database: " + path);
        }
        finally { loading = false; }
        if (ComboBoxState.Items.Count > 0) ComboBoxState.SelectedIndex = 0;
    }

    private void StateChanged(object? sender, EventArgs e) => Guard(() =>
    {
        ClearResults();
        loading = true;
        try
        {
            ComboBoxCounty.DataSource = null;
            ComboBoxCounty.DisplayMember = nameof(Jurisdiction.County);
            ComboBoxCounty.ValueMember = nameof(Jurisdiction.Id);
            ComboBoxCounty.DataSource = ComboBoxState.Text.Length == 0 ? new List<Jurisdiction>() :
                store.GetJurisdictions(ComboBoxState.Text).ToList();
        }
        finally { loading = false; }
        LoadTaxFilters();
    });

    private void CountyChanged(object? sender, EventArgs e) => Guard(() => { ClearResults(); LoadTaxFilters(); });
    private void TaxAuthorityChanged(object? sender, EventArgs e) => Guard(() =>
    {
        ComboBoxTaxType.Items.Clear();
        ComboBoxTaxType.Items.AddRange(taxOffices.Where(t => t.Authority == ComboBoxTaxAuth.Text)
            .Select(t => t.AuthorityType).Distinct().Cast<object>().ToArray());
        if (ComboBoxTaxType.Items.Count > 0) ComboBoxTaxType.SelectedIndex = 0;
    });

    private void LoadTaxFilters()
    {
        taxOffices = SelectedCounty is { } county ? store.GetTaxOffices(county.Id) : Array.Empty<TaxOffice>();
        ComboBoxTaxAuth.Items.Clear();
        ComboBoxTaxAuth.Text = "";
        ComboBoxTaxType.Items.Clear();
        ComboBoxTaxType.Text = "";
        ComboBoxTaxAuth.Items.AddRange(taxOffices.Select(t => t.Authority).Distinct().Cast<object>().ToArray());
        if (ComboBoxTaxAuth.Items.Count > 0) ComboBoxTaxAuth.SelectedIndex = 0;
    }

    private void ClearResults()
    {
        countyValues.Clear();
        stateValues.Clear();
        foreach (var map in FieldBindings.Values)
            foreach (string name in map.Keys)
                if (controls.TryGetValue(name, out var control)) control.Text = "";
        foreach (string name in CountyLinks.Keys.Concat(StateLinks.Keys))
            if (controls.TryGetValue(name, out var control)) { control.Tag = null; control.Enabled = false; }
        lbl_NotFound.Visible = false;
        lbl_Free.Text = "";
        for (int i = 1; i <= 5; i++)
        {
            SetText("txtTaxOffice" + i, "");
            SetText("lblTxAuth" + i, "");
            SetText("lbl_verifDate" + i, "");
            if (controls.TryGetValue("linkLocTax" + i, out var link)) { link.Tag = null; link.Enabled = false; }
        }
    }

    private void Search()
    {
        ClearResults();
        if (SelectedCounty is not { } county) { lbl_NotFound.Text = "Choose a state and county."; lbl_NotFound.Visible = true; return; }
        foreach (var link in store.GetResources(county.Id))
        {
            string key = LinkField(link.Category);
            if (!countyValues.ContainsKey(key)) countyValues[key] = link.Url;
            countyValues["comments"] = countyValues.GetValueOrDefault("comments", "") +
                link.Name + ": " + link.Notes + Environment.NewLine;
            if (link.FeeNotes.Length > 0) countyValues["copyFeeAmt"] = link.FeeNotes;
        }
        foreach (var pair in store.GetResearchDetails("County", county.Id.ToString(CultureInfo.InvariantCulture))) countyValues[pair.Key] = pair.Value;
        foreach (string section in new[] { "Statutes", "Misc" })
        {
            var values = store.GetResearchDetails(section, county.State);
            foreach (var pair in values) stateValues[pair.Key] = pair.Value;
            ApplyFields(section, values);
        }
        ApplyFields("County", countyValues);
        ApplyLinks(CountyLinks, countyValues);
        ApplyLinks(StateLinks, stateValues);
        LoadTaxes();
        if (countyValues.Count == 0)
        {
            lbl_NotFound.Text = "No research details recorded for this county. Use EDIT ORB to add details.";
            lbl_NotFound.Visible = true;
        }
    }

    internal static string LinkField(string category) => category.Trim().ToLowerInvariant() switch
    {
        "land" or "land records" => "land_url", "tax" or "taxes" => "tax_url",
        "court" or "courts" => "court_url", "assessor" => "assessor_url", "probate" => "probate_url",
        "maps" or "gis" => "map_url", "county home" or "county homepage" => "county_homepage",
        "foreclosure" => "foreclosure_url", "sheriff" => "sheriff_url", "plats" => "plat_url",
        "municipal court" => "muniCourt_url", "prothonotary" => "prothon_url", "ucc" => "ucc_url", _ => "other_url"
    };

    private void ApplyFields(string section, IReadOnlyDictionary<string, string> values)
    {
        foreach (var pair in FieldBindings[section]) SetText(pair.Key, values.GetValueOrDefault(pair.Value, ""));
        if (section == "Statutes")
        {
            foreach (string kind in new[] { "Mtg", "Heloc" })
            {
                string key = "SOL_" + kind;
                if (!values.ContainsKey(key))
                    SetText("lblSOL_" + kind, string.Join("; ", new[] {
                        values.TryGetValue(key + "AM", out var maturity) && maturity.Length > 0 ? maturity + " years after maturity" : "",
                        values.TryGetValue(key + "RD", out var recorded) && recorded.Length > 0 ? recorded + " years after recording" : ""
                    }.Where(v => v.Length > 0)));
            }
        }
    }

    private void SetText(string name, string value)
    {
        if (controls.TryGetValue(name, out var control)) control.Text = value;
    }

    private void ApplyLinks(IReadOnlyDictionary<string, string> mapping, IReadOnlyDictionary<string, string> values)
    {
        foreach (var pair in mapping)
            if (controls.TryGetValue(pair.Key, out var control))
            {
                string value = values.GetValueOrDefault(pair.Value, "");
                control.Tag = value;
                control.Enabled = IsWebLink(value);
            }
    }

    private void LoadTaxes()
    {
        var selected = taxOffices.Where(t => ComboBoxTaxAuth.Text.Length == 0 || t.Authority == ComboBoxTaxAuth.Text)
            .Where(t => ComboBoxTaxType.Text.Length == 0 || t.AuthorityType == ComboBoxTaxType.Text).Take(5).ToArray();
        for (int i = 0; i < selected.Length; i++)
        {
            var office = selected[i]; int number = i + 1;
            SetText("lblTxAuth" + number, office.Authority + " " + office.AuthorityType);
            SetText("txtTaxOffice" + number, string.Join(Environment.NewLine, new[] { office.Payee, office.Address, office.Phone, office.Notes }));
            SetText("lbl_verifDate" + number, office.VerifiedDate);
            if (controls.TryGetValue("linkLocTax" + number, out var link)) { link.Tag = office.Url; link.Enabled = IsWebLink(office.Url); }
        }
    }

    private static bool IsWebLink(string value) => Uri.TryCreate(value, UriKind.Absolute, out var uri) &&
        (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);

    private void OpenWebsite(string value)
    {
        if (!IsWebLink(value)) return;
        try { Process.Start(new ProcessStartInfo(value) { UseShellExecute = true }); }
        catch (Exception exception) { MessageBox.Show(this, exception.Message, "Unable to open website"); }
    }

    private void OriginalLinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        if (sender is Control control && control.Tag is string url) OpenWebsite(url);
    }

    private void OriginalClick(object? sender, EventArgs e)
    {
        if (sender is not Control control) return;
        switch (control.Name)
        {
            case "ButtonExit": Close(); break;
            case "Button_Search": Guard(Search); break;
            case "ButtonReset": Guard(() => { ComboBoxState.SelectedIndex = -1; ComboBoxState.Text = ""; ComboBoxCounty.DataSource = null; ClearResults(); }); break;
            case "Button_EditORB": Guard(EditDetails); break;
            case "ButtonHelp": ShowDatabaseMenu(); break;
            default: MessageBox.Show(this, "This original business integration has not been configured for the SQLite version.", control.Text); break;
        }
    }

    private void EditDetails()
    {
        if (SelectedCounty is not { } county) return;
        using var dialog = new ResearchDetailsEditor(store, county);
        dialog.ShowDialog(this);
        Search();
    }

    private void ShowDatabaseMenu()
    {
        var menu = new ContextMenuStrip();
        menu.Items.Add("Open SQLite database…", null, (_, _) =>
        {
            using var dialog = new OpenFileDialog { Filter = "SQLite databases|*.db;*.sqlite|All files|*.*", CheckFileExists = true };
            if (dialog.ShowDialog(this) == DialogResult.OK) Guard(() => LoadDatabase(dialog.FileName, false));
        });
        menu.Items.Add("Add U.S. counties", null, (_, _) => Guard(() => { int added = store.SeedUsJurisdictions(); LoadDatabase(databasePath, false); MessageBox.Show(this, $"Added {added} counties/county equivalents."); }));
        menu.Items.Add("Database: " + databasePath).Enabled = false;
        menu.Closed += (_, _) => menu.Dispose();
        menu.Show(ButtonHelp, new Point(0, ButtonHelp.Height));
    }

    private void OriginalMouseClick(object? sender, MouseEventArgs e)
    {
        if (sender is TabControl) { Guard(RefreshStatistics); return; }
        if (sender is Control control)
        {
            string digits = new(control.Name.Where(char.IsDigit).ToArray());
            if (digits.Length > 0 && controls.TryGetValue("txtTaxOffice" + digits, out var text) && text.Text.Length > 0)
                Clipboard.SetText(text.Text);
            else if (control.Name == "pbxExport")
                Clipboard.SetText(string.Join(Environment.NewLine + Environment.NewLine, Enumerable.Range(1, 5)
                    .Select(i => controls.GetValueOrDefault("txtTaxOffice" + i)?.Text ?? "")));
        }
    }

    private void OriginalHover(object? sender, EventArgs e) { if (sender is Control c) c.Cursor = Cursors.Hand; }
    private void OriginalLeave(object? sender, EventArgs e) { if (sender is Control c) c.Cursor = Cursors.Default; }
    private void StatisticsFilterChanged(object? sender, EventArgs e) => Guard(RefreshStatistics);
    private void AdditionalLinkChanged(object? sender, EventArgs e)
    {
        if (AdditionalWebsites.TryGetValue(cbxAddtlLinks.Text, out var url)) OpenWebsite(url);
    }

    private void RefreshStatistics()
    {
        var states = store.GetStates();
        int total = states.Sum(stateCode => store.GetJurisdictions(stateCode).Count);
        SetText("lbl_OrbStats", total.ToString());
        var state = cbox_StatsStates.Text.Length > 0 ? cbox_StatsStates.Text : ComboBoxState.Text;
        if (state.Length == 0) return;
        var counties = store.GetJurisdictions(state);
        var withLinks = counties.Where(c => store.GetResources(c.Id).Count > 0).ToArray();
        txt_StatsCounties.Text = string.Join(Environment.NewLine, withLinks.Select(c => c.State + " - " + c.County));
        lbl_CoOnlineStats.Text = "Counties with resource links: " + withLinks.Length;
        txt_StatsTaxOffices.Text = string.Join(Environment.NewLine, counties.SelectMany(c => store.GetTaxOffices(c.Id))
            .Select(t => t.Authority + " - " + t.AuthorityType));
        lbl_TaxOnlineStats.Text = "Tax offices: " + counties.Sum(c => store.GetTaxOffices(c.Id).Count);
    }

    internal void VerifyOriginalWorkflow()
    {
        Show();
        if (TabControl1.TabPages.Count != 5 || PictureBox1.Image is null) throw new InvalidOperationException("Original tabs/artwork missing.");
        ComboBoxState.Text = "DEMO";
        Search();
        if (!LinkLabelCounty.Enabled || !LinkLabelTax.Enabled || !txtComments.Text.Contains("Fictional"))
            throw new InvalidOperationException("Original resource controls were not populated from SQLite.");
        using (var screenshot = new Bitmap(Width, Height))
        {
            DrawToBitmap(screenshot, new Rectangle(0, 0, Width, Height));
            screenshot.Save(Path.Combine(Environment.GetEnvironmentVariable("RUNNER_TEMP") ?? Path.GetTempPath(), "orb-original-smoke.png"), System.Drawing.Imaging.ImageFormat.Png);
        }
        var county = SelectedCounty ?? throw new InvalidOperationException("No demo county selected.");
        store.AddTaxOffice(new(0, county.Id, "Demo tax authority", "County", "Fictional payee", "", "", "https://example.com/tax", "Fictional tax office notes", ""));
        LoadTaxFilters();
        Search();
        if (!txtTaxOffice1.Text.Contains("Fictional tax office notes"))
            throw new InvalidOperationException("Original tax office panel was not populated.");
        store.SaveResearchDetails("County", county.Id.ToString(), new Dictionary<string, string> { ["copy_source"] = "Original-layout smoke check" });
        store.SaveResearchDetails("Statutes", "DEMO", new Dictionary<string, string> { ["SOL_notes"] = "Fictional test notes" });
        Search();
        if (LabelCopy_source.Text != "Original-layout smoke check" || txtSOL_notes.Text != "Fictional test notes")
            throw new InvalidOperationException("Detailed research fields did not round-trip.");
        using (var editor = new ResearchDetailsEditor(store, county)) editor.VerifyCountyEdit();
        Search();
        if (LabelCopy_source.Text != "Edited through original editor" || !LinkLabelCounty.Enabled)
            throw new InvalidOperationException("Editing county metadata lost default resource links.");
        ComboBoxState.Text = "PA";
        if (ComboBoxCounty.Items.Count != 0) throw new InvalidOperationException("Previous counties survived an empty state.");
        if (LinkLabelCounty.Enabled || txtComments.Text.Length != 0) throw new InvalidOperationException("Stale results after changing state.");
        ComboBoxState.Text = "DEMO";
        Search();
        if (!LinkLabelCounty.Enabled) throw new InvalidOperationException("Original lookup did not recover.");
        Close();
    }
}
