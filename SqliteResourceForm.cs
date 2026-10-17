using System.ComponentModel;
using System.Diagnostics;
using Orb.Data;

namespace WindowsApplication1;

/// <summary>The first migrated screen; legacy forms remain in source for later migration.</summary>
internal sealed class SqliteResourceForm : Form
{
    private readonly ComboBox states = new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 130 };
    private readonly ComboBox counties = new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 260 };
    private readonly DataGridView resources = new()
    {
        Dock = DockStyle.Fill, ReadOnly = true, AutoGenerateColumns = false,
        AllowUserToAddRows = false, AllowUserToDeleteRows = false,
        MultiSelect = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    };
    private readonly TextBox details = new() { Dock = DockStyle.Fill, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };
    private readonly Label status = new() { Dock = DockStyle.Fill, AutoSize = true, Padding = new Padding(6) };
    private readonly TextBox database = new() { Dock = DockStyle.Fill, ReadOnly = true };
    private readonly Button openLink = new() { Text = "Open selected link", AutoSize = true, Enabled = false };
    private readonly Button seedCounties = new() { Text = "Add U.S. counties", AutoSize = true, Enabled = false };
    private ResourceStore? store;
    private string databasePath;
    private bool loading;

    public SqliteResourceForm(string path, bool createIfMissing)
    {
        databasePath = path;
        Text = "Online Resource Bank — SQLite";
        MinimumSize = new Size(850, 550);
        Size = new Size(1100, 700);
        StartPosition = FormStartPosition.CenterScreen;
        AutoScaleMode = AutoScaleMode.Dpi;

        var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 5, Padding = new Padding(12) };
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        var fileRow = new TableLayoutPanel { Dock = DockStyle.Top, AutoSize = true, ColumnCount = 5 };
        fileRow.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        fileRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        fileRow.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        fileRow.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        fileRow.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        var browse = new Button { Text = "Open database…", AutoSize = true };
        var reload = new Button { Text = "Reload", AutoSize = true };
        fileRow.Controls.Add(new Label { Text = "Database", AutoSize = true, Margin = new Padding(3, 8, 8, 3) }, 0, 0);
        fileRow.Controls.Add(database, 1, 0);
        fileRow.Controls.Add(browse, 2, 0);
        fileRow.Controls.Add(reload, 3, 0);
        fileRow.Controls.Add(seedCounties, 4, 0);
        var filters = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(0, 8, 0, 8) };
        filters.Controls.AddRange([new Label { Text = "State", AutoSize = true, Padding = new Padding(0, 6, 0, 0) }, states,
            new Label { Text = "County", AutoSize = true, Padding = new Padding(8, 6, 0, 0) }, counties, openLink]);
        foreach (var (name, property) in new[] { ("Category", "Category"), ("Resource", "Name"), ("Website", "Url") })
            resources.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = name, DataPropertyName = property, Name = property });
        var detailsGroup = new GroupBox { Text = "Research notes and fees", Dock = DockStyle.Fill };
        detailsGroup.Controls.Add(details);
        layout.Controls.Add(fileRow, 0, 0);
        layout.Controls.Add(filters, 0, 1);
        layout.Controls.Add(resources, 0, 2);
        layout.Controls.Add(detailsGroup, 0, 3);
        layout.Controls.Add(status, 0, 4);
        Controls.Add(layout);

        states.SelectedIndexChanged += (_, _) => Guard(LoadCounties);
        counties.SelectedIndexChanged += (_, _) => Guard(LoadResources);
        resources.SelectionChanged += (_, _) => ShowDetails();
        openLink.Click += (_, _) => OpenSelectedLink();
        resources.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) OpenSelectedLink(); };
        seedCounties.Click += (_, _) => Guard(() =>
        {
            if (store is null) throw new InvalidOperationException("Open a valid ORB database first.");
            int added = store.SeedUsJurisdictions();
            LoadDatabase(databasePath, false);
            status.Text = $"Added {added:N0} counties/county equivalents. Existing resources were preserved. Select a state and county.";
        });
        reload.Click += (_, _) => Guard(() => LoadDatabase(databasePath, false));
        browse.Click += (_, _) =>
        {
            using var dialog = new OpenFileDialog { Filter = "SQLite databases|*.db;*.sqlite|All files|*.*", CheckFileExists = true };
            if (dialog.ShowDialog(this) == DialogResult.OK)
                Guard(() => LoadDatabase(dialog.FileName, false));
        };
        Shown += (_, _) => Guard(() => LoadDatabase(databasePath, createIfMissing));
    }

    private void Guard(Action action)
    {
        if (loading) return;
        try { action(); }
        catch (Exception exception)
        {
            ClearResources();
            status.Text = "Unable to load resources: " + exception.Message + " Check the database path and use Reload or Open database.";
        }
    }

    private void LoadDatabase(string path, bool createIfMissing)
    {
        loading = true;
        try
        {
            store = null;
            seedCounties.Enabled = false;
            databasePath = path;
            database.Text = path;
            states.DataSource = null;
            counties.DataSource = null;
            ClearResources();
            if (!File.Exists(path) && !createIfMissing)
                throw new FileNotFoundException("Database file not found.", path);
            var candidate = new ResourceStore(path);
            if (!File.Exists(path))
            {
                candidate.Initialize();
                candidate.SeedUsJurisdictions();
            }
            var availableStates = candidate.GetStates();
            store = candidate;
            seedCounties.Enabled = true;
            states.DataSource = availableStates.ToList();
        }
        finally { loading = false; }
        LoadCounties();
    }

    private void LoadCounties()
    {
        loading = true;
        try
        {
            counties.DataSource = null;
            ClearResources();
            counties.DisplayMember = nameof(Jurisdiction.County);
            counties.ValueMember = nameof(Jurisdiction.Id);
            counties.DataSource = store is not null && states.SelectedItem is string state
                ? store.GetJurisdictions(state).ToList() : new List<Jurisdiction>();
        }
        finally { loading = false; }
        LoadResources();
    }

    private void LoadResources()
    {
        ClearResources();
        if (store is null || counties.SelectedItem is not Jurisdiction county)
        {
            status.Text = "No counties available. Use Add U.S. counties or open another ORB SQLite database.";
            return;
        }
        var links = store.GetResources(county.Id);
        resources.DataSource = new BindingList<ResourceLink>(links.ToList());
        status.Text = links.Count == 0 ? "No resources for this county." :
            $"{county.State} / {county.County} — {links.Count} resource(s). Read-only SQLite lookup.";
        ShowDetails();
    }

    private void ClearResources()
    {
        resources.DataSource = null;
        details.Clear();
        openLink.Enabled = false;
    }

    private ResourceLink? SelectedLink => resources.CurrentRow?.DataBoundItem as ResourceLink;

    private void ShowDetails()
    {
        var link = SelectedLink;
        openLink.Enabled = link is not null;
        details.Text = link is null ? "" : $"{link.Name}{Environment.NewLine}{link.Notes}{Environment.NewLine}{Environment.NewLine}Fees: {link.FeeNotes}";
    }

    private void OpenSelectedLink()
    {
        if (SelectedLink is not { } link) return;
        if (!Uri.TryCreate(link.Url, UriKind.Absolute, out var uri) ||
            (uri.Scheme != Uri.UriSchemeHttps && uri.Scheme != Uri.UriSchemeHttp))
        {
            status.Text = "This resource does not contain a valid HTTP or HTTPS website.";
            return;
        }
        try { Process.Start(new ProcessStartInfo(uri.AbsoluteUri) { UseShellExecute = true }); }
        catch (Exception exception) { status.Text = "Could not open the website: " + exception.Message; }
    }

    // CI exercises actual WinForms controls and selection events against the generated demo.
    internal void VerifyDemoWorkflow()
    {
        Show();
        LoadDatabase(databasePath, false);
        if (states.Items.Count != 1 || counties.Items.Count != 1 || resources.Rows.Count != 2)
            throw new InvalidOperationException("Demo state/county/resource binding failed.");
        resources.CurrentCell = resources.Rows[0].Cells[0];
        ShowDetails();
        if (!openLink.Enabled || !details.Text.Contains("Fictional demonstration"))
            throw new InvalidOperationException("Resource selection did not populate details.");
        states.SelectedIndex = -1;
        if (counties.Items.Count != 0 || resources.Rows.Count != 0 || openLink.Enabled || details.Text.Length != 0)
            throw new InvalidOperationException("Clearing the state left stale resource details.");
        states.SelectedIndex = 0;
        if (resources.Rows.Count != 2) throw new InvalidOperationException("Reselecting the state failed.");
        seedCounties.PerformClick();
        if (states.Items.Count != 53) throw new InvalidOperationException("National seed did not populate all states plus the demo.");
        states.SelectedItem = "PA";
        if (counties.Items.Count != 67 || resources.Rows.Count != 0 || openLink.Enabled)
            throw new InvalidOperationException("Pennsylvania county binding or empty resource state failed.");
        seedCounties.PerformClick();
        if (!status.Text.StartsWith("Added 0 ")) throw new InvalidOperationException("Repeated seed inserted duplicates.");
        states.SelectedItem = "DEMO";
        if (resources.Rows.Count != 2) throw new InvalidOperationException("Seeding lost existing demo resources.");
        Close();
    }
}
