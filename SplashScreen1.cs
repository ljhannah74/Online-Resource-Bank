using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsApplication1.My;

namespace WindowsApplication1
{
	[DesignerGenerated]
	public sealed class SplashScreen1 : Form
	{
		[AccessedThroughProperty("ApplicationTitle")]
		private Label _ApplicationTitle;

		[AccessedThroughProperty("Version")]
		private Label _Version;

		[AccessedThroughProperty("Copyright")]
		private Label _Copyright;

		[AccessedThroughProperty("MainLayoutPanel")]
		private TableLayoutPanel _MainLayoutPanel;

		[AccessedThroughProperty("DetailsLayoutPanel")]
		private TableLayoutPanel _DetailsLayoutPanel;

		private IContainer components;

		internal Label ApplicationTitle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ApplicationTitle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ApplicationTitle = value;
			}
		}

		internal Label Copyright
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Copyright;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Copyright = value;
			}
		}

		internal TableLayoutPanel DetailsLayoutPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DetailsLayoutPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DetailsLayoutPanel = value;
			}
		}

		internal TableLayoutPanel MainLayoutPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MainLayoutPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MainLayoutPanel = value;
			}
		}

		internal Label Version
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Version;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Version = value;
			}
		}

		[DebuggerNonUserCode]
		public SplashScreen1()
		{
			SplashScreen1 splashScreen1 = this;
			base.Load += new EventHandler(splashScreen1.SplashScreen1_Load);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SplashScreen1));
			this.MainLayoutPanel = new TableLayoutPanel();
			this.DetailsLayoutPanel = new TableLayoutPanel();
			this.Version = new Label();
			this.Copyright = new Label();
			this.ApplicationTitle = new Label();
			this.MainLayoutPanel.SuspendLayout();
			this.DetailsLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			this.MainLayoutPanel.BackgroundImage = (Image)componentResourceManager.GetObject("MainLayoutPanel.BackgroundImage");
			this.MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
			this.MainLayoutPanel.ColumnCount = 2;
			this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243f));
			this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
			this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
			this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 0, 1);
			this.MainLayoutPanel.Dock = DockStyle.Fill;
			TableLayoutPanel mainLayoutPanel = this.MainLayoutPanel;
			Point point = new Point(0, 0);
			mainLayoutPanel.Location = point;
			this.MainLayoutPanel.Name = "MainLayoutPanel";
			this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 198f));
			this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 58f));
			TableLayoutPanel tableLayoutPanel = this.MainLayoutPanel;
			System.Drawing.Size size = new System.Drawing.Size(463, 303);
			tableLayoutPanel.Size = size;
			this.MainLayoutPanel.TabIndex = 0;
			this.DetailsLayoutPanel.Anchor = AnchorStyles.Bottom;
			this.DetailsLayoutPanel.BackColor = Color.Transparent;
			this.DetailsLayoutPanel.ColumnCount = 1;
			this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247f));
			this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142f));
			this.DetailsLayoutPanel.Controls.Add(this.Copyright, 0, 1);
			this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 0);
			TableLayoutPanel detailsLayoutPanel = this.DetailsLayoutPanel;
			point = new Point(246, 237);
			detailsLayoutPanel.Location = point;
			this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
			this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
			this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
			TableLayoutPanel detailsLayoutPanel1 = this.DetailsLayoutPanel;
			size = new System.Drawing.Size(214, 63);
			detailsLayoutPanel1.Size = size;
			this.DetailsLayoutPanel.TabIndex = 1;
			this.Version.Anchor = AnchorStyles.None;
			this.Version.BackColor = Color.Transparent;
			this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label version = this.Version;
			point = new Point(41, 3);
			version.Location = point;
			this.Version.Name = "Version";
			Label label = this.Version;
			size = new System.Drawing.Size(164, 24);
			label.Size = size;
			this.Version.TabIndex = 1;
			this.Version.Text = "Version {0}.{1:00}";
			this.Version.TextAlign = ContentAlignment.BottomRight;
			this.Copyright.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.Copyright.BackColor = Color.Transparent;
			this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label copyright = this.Copyright;
			point = new Point(3, 38);
			copyright.Location = point;
			this.Copyright.Name = "Copyright";
			Label copyright1 = this.Copyright;
			size = new System.Drawing.Size(202, 25);
			copyright1.Size = size;
			this.Copyright.TabIndex = 2;
			this.Copyright.Text = "Copyright";
			this.Copyright.TextAlign = ContentAlignment.MiddleRight;
			this.ApplicationTitle.Anchor = AnchorStyles.None;
			this.ApplicationTitle.BackColor = Color.Transparent;
			this.ApplicationTitle.Font = new System.Drawing.Font("Leelawadee", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label applicationTitle = this.ApplicationTitle;
			point = new Point(3, 204);
			applicationTitle.Location = point;
			this.ApplicationTitle.Name = "ApplicationTitle";
			Label applicationTitle1 = this.ApplicationTitle;
			size = new System.Drawing.Size(237, 93);
			applicationTitle1.Size = size;
			this.ApplicationTitle.TabIndex = 0;
			this.ApplicationTitle.Text = "Application Title";
			this.ApplicationTitle.TextAlign = ContentAlignment.BottomLeft;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(463, 303);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.MainLayoutPanel);
			this.ForeColor = SystemColors.ButtonHighlight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashScreen1";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.SendToBack();
			this.MainLayoutPanel.ResumeLayout(false);
			this.DetailsLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void SplashScreen1_Load(object sender, EventArgs e)
		{
			if (Operators.CompareString(MyProject.Application.Info.Title, "", false) == 0)
			{
				this.ApplicationTitle.Text = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName);
			}
			else
			{
				this.ApplicationTitle.Text = MyProject.Application.Info.Title;
			}
			this.Version.Text = string.Format(this.Version.Text, MyProject.Application.Info.Version.Major, MyProject.Application.Info.Version.Minor);
			this.Copyright.Text = MyProject.Application.Info.Copyright;
			this.SendToBack();
		}
	}
}