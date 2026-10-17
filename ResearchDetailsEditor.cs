using System.Globalization;
using Orb.Data;

namespace WindowsApplication1;

internal sealed class ResearchDetailsEditor : Form
{
    public ResearchDetailsEditor(ResourceStore store, Jurisdiction county)
    {
        Text = $"Research details — {county.State} / {county.County}";
        Size = new Size(820, 650);
        StartPosition = FormStartPosition.CenterParent;
        var tabs = new TabControl { Dock = DockStyle.Fill };
        var layout = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2, ColumnCount = 1 };
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        var footer = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true };
        var save = new Button { Text = "Save current tab", AutoSize = true };
        var close = new Button { Text = "Close", AutoSize = true, DialogResult = DialogResult.Cancel };
        footer.Controls.AddRange([save, close, new Label { Text = "County details apply here; clearing and miscellaneous notes apply to the whole state.", AutoSize = true }]);
        var grids = new Dictionary<string, DataGridView>();
        foreach (string section in new[] { "County", "Statutes", "Misc" })
        {
            string owner = section == "County" ? county.Id.ToString(CultureInfo.InvariantCulture) : county.State;
            var values = store.GetResearchDetails(section, owner);
            var grid = new DataGridView { Dock = DockStyle.Fill, AllowUserToAddRows = false, AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, RowHeadersVisible = false };
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Field", HeaderText = "Research field", ReadOnly = true });
            grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Value", HeaderText = "Value" });
            foreach (string field in ResearchFieldCatalog.Fields(section))
            {
                int index = grid.Rows.Add(ResearchFieldCatalog.Label(field), values.GetValueOrDefault(field, ""));
                grid.Rows[index].Tag = field;
            }
            var tab = new TabPage(section == "Statutes" ? "Clearing / statute notes" : section == "Misc" ? "State miscellaneous" : "County resources and fees") { Name = section };
            tab.Controls.Add(grid);
            tabs.TabPages.Add(tab);
            grids[section] = grid;
        }
        save.Click += (_, _) =>
        {
            string section = tabs.SelectedTab!.Name;
            var grid = grids[section];
            grid.EndEdit();
            var values = grid.Rows.Cast<DataGridViewRow>().ToDictionary(row => (string)row.Tag!, row => row.Cells[1].Value?.ToString() ?? "");
            try
            {
                store.SaveResearchDetails(section, section == "County" ? county.Id.ToString(CultureInfo.InvariantCulture) : county.State, values);
                save.Text = "Saved — save current tab";
            }
            catch (Exception exception) { MessageBox.Show(this, exception.Message, "Unable to save research details"); }
        };
        layout.Controls.Add(tabs, 0, 0);
        layout.Controls.Add(footer, 0, 1);
        Controls.Add(layout);
        CancelButton = close;
    }
}
