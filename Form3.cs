using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsApplication1
{
	[DesignerGenerated]
	public class Form3 : Form
	{
		private IContainer components;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("lbl_customer_type")]
		private Label _lbl_customer_type;

		[AccessedThroughProperty("lbl_customer_name")]
		private Label _lbl_customer_name;

		[AccessedThroughProperty("cbox_CustomerID")]
		private ComboBox _cbox_CustomerID;

		[AccessedThroughProperty("TabPage5")]
		private TabPage _TabPage5;

		private string dsn;

		private string dsn2;

		private int c;

		private int c2;

		private OleDbDataAdapter da;

		private OleDbDataAdapter da2;

		private OleDbCommandBuilder cmdBuilder;

		private OleDbCommandBuilder cmdBuilder2;

		private OleDbCommand cmd;

		private OleDbCommand cmd2;

		private string Import_File;

		private string sheetNm1;

		private string sheetNm2;

		private string sheetNm3;

		private DataTable dt;

		internal virtual ComboBox cbox_CustomerID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbox_CustomerID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbox_CustomerID = value;
			}
		}

		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		internal virtual Label Label18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label18 = value;
			}
		}

		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		internal virtual Label lbl_customer_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_customer_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_customer_name = value;
			}
		}

		internal virtual Label lbl_customer_type
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_customer_type;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_customer_type = value;
			}
		}

		internal virtual TabControl TabControl1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabControl1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabControl1 = value;
			}
		}

		internal virtual TabPage TabPage1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage1 = value;
			}
		}

		internal virtual TabPage TabPage2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage2 = value;
			}
		}

		internal virtual TabPage TabPage3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage3 = value;
			}
		}

		internal virtual TabPage TabPage4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage4 = value;
			}
		}

		internal virtual TabPage TabPage5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage5 = value;
			}
		}

		public Form3()
		{
			Form3 form3 = this;
			base.Load += new EventHandler(form3.Form3_Load);
			this.c = 0;
			this.c2 = 0;
			this.da = new OleDbDataAdapter();
			this.da2 = new OleDbDataAdapter();
			this.cmdBuilder = new OleDbCommandBuilder();
			this.cmdBuilder2 = new OleDbCommandBuilder();
			this.cmd = new OleDbCommand();
			this.cmd2 = new OleDbCommand();
			this.Import_File = "T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\title_customer_specs.xls";
			this.sheetNm1 = "Sheet1_title_production";
			this.sheetNm2 = "Sheet2_clearance";
			this.sheetNm3 = "Sheet3_vendors";
			this.dt = new DataTable();
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

		private void Form3_Load(object sender, EventArgs e)
		{
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm1, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.dt);
			this.da.Dispose();
			if (this.dt != null)
			{
				this.cbox_CustomerID.DataSource = this.dt;
				this.cbox_CustomerID.DisplayMember = "cust_code";
				this.cbox_CustomerID.ValueMember = "cust_code";
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new Label();
			this.TabControl1 = new TabControl();
			this.TabPage1 = new TabPage();
			this.GroupBox3 = new GroupBox();
			this.TabPage2 = new TabPage();
			this.GroupBox2 = new GroupBox();
			this.TabPage3 = new TabPage();
			this.GroupBox1 = new GroupBox();
			this.TabPage4 = new TabPage();
			this.Label22 = new Label();
			this.Label21 = new Label();
			this.Label20 = new Label();
			this.Label19 = new Label();
			this.Label18 = new Label();
			this.Label17 = new Label();
			this.Label16 = new Label();
			this.Label15 = new Label();
			this.Label14 = new Label();
			this.Label13 = new Label();
			this.Label12 = new Label();
			this.Label11 = new Label();
			this.Label10 = new Label();
			this.Label9 = new Label();
			this.Label8 = new Label();
			this.Label7 = new Label();
			this.Label6 = new Label();
			this.Label5 = new Label();
			this.Label4 = new Label();
			this.Label3 = new Label();
			this.lbl_customer_name = new Label();
			this.lbl_customer_type = new Label();
			this.cbox_CustomerID = new ComboBox();
			this.TabPage5 = new TabPage();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			Point point = new Point(12, 9);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			System.Drawing.Size size = new System.Drawing.Size(85, 13);
			label.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Title Department";
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Controls.Add(this.TabPage5);
			TabControl tabControl1 = this.TabControl1;
			point = new Point(12, 36);
			tabControl1.Location = point;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			TabControl tabControl = this.TabControl1;
			size = new System.Drawing.Size(649, 349);
			tabControl.Size = size;
			this.TabControl1.TabIndex = 1;
			this.TabPage1.BackColor = Color.Honeydew;
			this.TabPage1.Controls.Add(this.GroupBox3);
			TabPage tabPage1 = this.TabPage1;
			point = new Point(4, 22);
			tabPage1.Location = point;
			this.TabPage1.Name = "TabPage1";
			TabPage tabPage = this.TabPage1;
			System.Windows.Forms.Padding padding = new System.Windows.Forms.Padding(3);
			tabPage.Padding = padding;
			TabPage tabPage11 = this.TabPage1;
			size = new System.Drawing.Size(641, 323);
			tabPage11.Size = size;
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Title WIP";
			GroupBox groupBox3 = this.GroupBox3;
			point = new Point(18, 15);
			groupBox3.Location = point;
			this.GroupBox3.Name = "GroupBox3";
			GroupBox groupBox = this.GroupBox3;
			size = new System.Drawing.Size(190, 255);
			groupBox.Size = size;
			this.GroupBox3.TabIndex = 1;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Education and SOPs";
			this.TabPage2.BackColor = Color.Honeydew;
			this.TabPage2.Controls.Add(this.GroupBox2);
			TabPage tabPage2 = this.TabPage2;
			point = new Point(4, 22);
			tabPage2.Location = point;
			this.TabPage2.Name = "TabPage2";
			TabPage tabPage21 = this.TabPage2;
			padding = new System.Windows.Forms.Padding(3);
			tabPage21.Padding = padding;
			TabPage tabPage22 = this.TabPage2;
			size = new System.Drawing.Size(641, 323);
			tabPage22.Size = size;
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Title Production";
			GroupBox groupBox2 = this.GroupBox2;
			point = new Point(18, 15);
			groupBox2.Location = point;
			this.GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = this.GroupBox2;
			size = new System.Drawing.Size(138, 255);
			groupBox21.Size = size;
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Education and SOPs";
			this.TabPage3.BackColor = Color.Honeydew;
			this.TabPage3.Controls.Add(this.GroupBox1);
			TabPage tabPage3 = this.TabPage3;
			point = new Point(4, 22);
			tabPage3.Location = point;
			this.TabPage3.Name = "TabPage3";
			TabPage tabPage31 = this.TabPage3;
			padding = new System.Windows.Forms.Padding(3);
			tabPage31.Padding = padding;
			TabPage tabPage32 = this.TabPage3;
			size = new System.Drawing.Size(641, 323);
			tabPage32.Size = size;
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Title Clearance";
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(18, 15);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox11 = this.GroupBox1;
			size = new System.Drawing.Size(138, 255);
			groupBox11.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Education and SOPs";
			this.TabPage4.BackColor = Color.Honeydew;
			this.TabPage4.Controls.Add(this.Label22);
			this.TabPage4.Controls.Add(this.Label21);
			this.TabPage4.Controls.Add(this.Label20);
			this.TabPage4.Controls.Add(this.Label19);
			this.TabPage4.Controls.Add(this.Label18);
			this.TabPage4.Controls.Add(this.Label17);
			this.TabPage4.Controls.Add(this.Label16);
			this.TabPage4.Controls.Add(this.Label15);
			this.TabPage4.Controls.Add(this.Label14);
			this.TabPage4.Controls.Add(this.Label13);
			this.TabPage4.Controls.Add(this.Label12);
			this.TabPage4.Controls.Add(this.Label11);
			this.TabPage4.Controls.Add(this.Label10);
			this.TabPage4.Controls.Add(this.Label9);
			this.TabPage4.Controls.Add(this.Label8);
			this.TabPage4.Controls.Add(this.Label7);
			this.TabPage4.Controls.Add(this.Label6);
			this.TabPage4.Controls.Add(this.Label5);
			this.TabPage4.Controls.Add(this.Label4);
			this.TabPage4.Controls.Add(this.Label3);
			TabPage tabPage4 = this.TabPage4;
			point = new Point(4, 22);
			tabPage4.Location = point;
			this.TabPage4.Name = "TabPage4";
			TabPage tabPage41 = this.TabPage4;
			padding = new System.Windows.Forms.Padding(3);
			tabPage41.Padding = padding;
			TabPage tabPage42 = this.TabPage4;
			size = new System.Drawing.Size(641, 323);
			tabPage42.Size = size;
			this.TabPage4.TabIndex = 3;
			this.TabPage4.Text = "Customer Specifics";
			this.Label22.AutoSize = true;
			Label label22 = this.Label22;
			point = new Point(128, 286);
			label22.Location = point;
			this.Label22.Name = "Label22";
			Label label221 = this.Label22;
			size = new System.Drawing.Size(45, 13);
			label221.Size = size;
			this.Label22.TabIndex = 20;
			this.Label22.Text = "Label22";
			this.Label21.AutoSize = true;
			Label label21 = this.Label21;
			point = new Point(30, 286);
			label21.Location = point;
			this.Label21.Name = "Label21";
			Label label211 = this.Label21;
			size = new System.Drawing.Size(45, 13);
			label211.Size = size;
			this.Label21.TabIndex = 19;
			this.Label21.Text = "Label21";
			this.Label20.AutoSize = true;
			Label label20 = this.Label20;
			point = new Point(128, 259);
			label20.Location = point;
			this.Label20.Name = "Label20";
			Label label201 = this.Label20;
			size = new System.Drawing.Size(45, 13);
			label201.Size = size;
			this.Label20.TabIndex = 18;
			this.Label20.Text = "Label20";
			this.Label19.AutoSize = true;
			Label label19 = this.Label19;
			point = new Point(30, 259);
			label19.Location = point;
			this.Label19.Name = "Label19";
			Label label191 = this.Label19;
			size = new System.Drawing.Size(45, 13);
			label191.Size = size;
			this.Label19.TabIndex = 17;
			this.Label19.Text = "Label19";
			this.Label18.AutoSize = true;
			Label label18 = this.Label18;
			point = new Point(128, 232);
			label18.Location = point;
			this.Label18.Name = "Label18";
			Label label181 = this.Label18;
			size = new System.Drawing.Size(45, 13);
			label181.Size = size;
			this.Label18.TabIndex = 16;
			this.Label18.Text = "Label18";
			this.Label17.AutoSize = true;
			Label label17 = this.Label17;
			point = new Point(30, 232);
			label17.Location = point;
			this.Label17.Name = "Label17";
			Label label171 = this.Label17;
			size = new System.Drawing.Size(45, 13);
			label171.Size = size;
			this.Label17.TabIndex = 15;
			this.Label17.Text = "Label17";
			this.Label16.AutoSize = true;
			Label label16 = this.Label16;
			point = new Point(128, 205);
			label16.Location = point;
			this.Label16.Name = "Label16";
			Label label161 = this.Label16;
			size = new System.Drawing.Size(45, 13);
			label161.Size = size;
			this.Label16.TabIndex = 14;
			this.Label16.Text = "Label16";
			this.Label15.AutoSize = true;
			Label label15 = this.Label15;
			point = new Point(30, 205);
			label15.Location = point;
			this.Label15.Name = "Label15";
			Label label151 = this.Label15;
			size = new System.Drawing.Size(45, 13);
			label151.Size = size;
			this.Label15.TabIndex = 13;
			this.Label15.Text = "Label15";
			this.Label14.AutoSize = true;
			Label label14 = this.Label14;
			point = new Point(128, 178);
			label14.Location = point;
			this.Label14.Name = "Label14";
			Label label141 = this.Label14;
			size = new System.Drawing.Size(45, 13);
			label141.Size = size;
			this.Label14.TabIndex = 12;
			this.Label14.Text = "Label14";
			this.Label13.AutoSize = true;
			Label label13 = this.Label13;
			point = new Point(30, 178);
			label13.Location = point;
			this.Label13.Name = "Label13";
			Label label131 = this.Label13;
			size = new System.Drawing.Size(45, 13);
			label131.Size = size;
			this.Label13.TabIndex = 11;
			this.Label13.Text = "Label13";
			this.Label12.AutoSize = true;
			Label label12 = this.Label12;
			point = new Point(128, 151);
			label12.Location = point;
			this.Label12.Name = "Label12";
			Label label121 = this.Label12;
			size = new System.Drawing.Size(45, 13);
			label121.Size = size;
			this.Label12.TabIndex = 10;
			this.Label12.Text = "Label12";
			this.Label11.AutoSize = true;
			Label label11 = this.Label11;
			point = new Point(30, 151);
			label11.Location = point;
			this.Label11.Name = "Label11";
			Label label111 = this.Label11;
			size = new System.Drawing.Size(45, 13);
			label111.Size = size;
			this.Label11.TabIndex = 9;
			this.Label11.Text = "Label11";
			this.Label10.AutoSize = true;
			Label label10 = this.Label10;
			point = new Point(128, 124);
			label10.Location = point;
			this.Label10.Name = "Label10";
			Label label101 = this.Label10;
			size = new System.Drawing.Size(45, 13);
			label101.Size = size;
			this.Label10.TabIndex = 8;
			this.Label10.Text = "Label10";
			this.Label9.AutoSize = true;
			Label label9 = this.Label9;
			point = new Point(30, 124);
			label9.Location = point;
			this.Label9.Name = "Label9";
			Label label91 = this.Label9;
			size = new System.Drawing.Size(39, 13);
			label91.Size = size;
			this.Label9.TabIndex = 7;
			this.Label9.Text = "Label9";
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(128, 97);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label81 = this.Label8;
			size = new System.Drawing.Size(39, 13);
			label81.Size = size;
			this.Label8.TabIndex = 6;
			this.Label8.Text = "Label8";
			this.Label7.AutoSize = true;
			Label label7 = this.Label7;
			point = new Point(30, 97);
			label7.Location = point;
			this.Label7.Name = "Label7";
			Label label71 = this.Label7;
			size = new System.Drawing.Size(39, 13);
			label71.Size = size;
			this.Label7.TabIndex = 5;
			this.Label7.Text = "Label7";
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(128, 70);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(39, 13);
			label61.Size = size;
			this.Label6.TabIndex = 4;
			this.Label6.Text = "Label6";
			this.Label5.AutoSize = true;
			Label label5 = this.Label5;
			point = new Point(30, 70);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(39, 13);
			label51.Size = size;
			this.Label5.TabIndex = 3;
			this.Label5.Text = "Label5";
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(128, 43);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(39, 13);
			label41.Size = size;
			this.Label4.TabIndex = 2;
			this.Label4.Text = "Label4";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(30, 43);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(39, 13);
			label31.Size = size;
			this.Label3.TabIndex = 1;
			this.Label3.Text = "Label3";
			this.lbl_customer_name.AutoSize = true;
			Label lblCustomerName = this.lbl_customer_name;
			point = new Point(279, 9);
			lblCustomerName.Location = point;
			this.lbl_customer_name.Name = "lbl_customer_name";
			Label lblCustomerName1 = this.lbl_customer_name;
			size = new System.Drawing.Size(55, 13);
			lblCustomerName1.Size = size;
			this.lbl_customer_name.TabIndex = 21;
			this.lbl_customer_name.Text = "custName";
			this.lbl_customer_type.AutoSize = true;
			Label lblCustomerType = this.lbl_customer_type;
			point = new Point(507, 9);
			lblCustomerType.Location = point;
			this.lbl_customer_type.Name = "lbl_customer_type";
			Label lblCustomerType1 = this.lbl_customer_type;
			size = new System.Drawing.Size(51, 13);
			lblCustomerType1.Size = size;
			this.lbl_customer_type.TabIndex = 22;
			this.lbl_customer_type.Text = "custType";
			this.cbox_CustomerID.FormattingEnabled = true;
			ComboBox cboxCustomerID = this.cbox_CustomerID;
			point = new Point(147, 6);
			cboxCustomerID.Location = point;
			this.cbox_CustomerID.Name = "cbox_CustomerID";
			ComboBox comboBox = this.cbox_CustomerID;
			size = new System.Drawing.Size(121, 21);
			comboBox.Size = size;
			this.cbox_CustomerID.TabIndex = 21;
			TabPage tabPage5 = this.TabPage5;
			point = new Point(4, 22);
			tabPage5.Location = point;
			this.TabPage5.Name = "TabPage5";
			TabPage tabPage51 = this.TabPage5;
			padding = new System.Windows.Forms.Padding(3);
			tabPage51.Padding = padding;
			TabPage tabPage52 = this.TabPage5;
			size = new System.Drawing.Size(641, 323);
			tabPage52.Size = size;
			this.TabPage5.TabIndex = 4;
			this.TabPage5.Text = "TabPage5";
			this.TabPage5.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.AliceBlue;
			size = new System.Drawing.Size(673, 397);
			this.ClientSize = size;
			this.Controls.Add(this.cbox_CustomerID);
			this.Controls.Add(this.lbl_customer_type);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.lbl_customer_name);
			this.Controls.Add(this.Label1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.TabPage4.ResumeLayout(false);
			this.TabPage4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}