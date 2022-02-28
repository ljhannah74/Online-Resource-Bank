using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ORB_DLL.Orb;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
//using UniversalRateCalc;

namespace WindowsApplication1
{
	public partial class Form1 : Form
	{

		private DataTable st_cty;

		private string[] mywebs;

		private DataGridViewLinkColumn links;

		private Resource_Lookup orb_obj;

		private Statutes_Lookup orbStats;

		private Tax_Lookup1 orbTax;

		private ORB_DLL.Orb.orb_misc orb_misc;

		private int taxoffc_count;

		private string[] TxOffcOutput;

		private object[] picbox;

		private string target;

		private int i;

		private string dsn;

		private string dsn2;

		private StringBuilder sb;

		private StringBuilder sb2;

		private int c;

		private int c2;

		private DataTable dt;

		private DataTable dt2;

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

		private string sheetNm4;

		private string sheetNm5;

		private string sheetNm7;

		internal virtual Button Button_ClosingDept
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_ClosingDept;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button_ClosingDept = value;
			}
		}

		internal virtual Button Button_EditORB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_EditORB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button_EditORB_Click);
				if (this._Button_EditORB != null)
				{
					this._Button_EditORB.Click -= eventHandler;
				}
				this._Button_EditORB = value;
				if (this._Button_EditORB != null)
				{
					this._Button_EditORB.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button_PolicyWarehouse
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_PolicyWarehouse;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button_PolicyWarehouse_Click);
				if (this._Button_PolicyWarehouse != null)
				{
					this._Button_PolicyWarehouse.Click -= eventHandler;
				}
				this._Button_PolicyWarehouse = value;
				if (this._Button_PolicyWarehouse != null)
				{
					this._Button_PolicyWarehouse.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button_RateCalc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_RateCalc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button_RateCalc_Click);
				if (this._Button_RateCalc != null)
				{
					this._Button_RateCalc.Click -= eventHandler;
				}
				this._Button_RateCalc = value;
				if (this._Button_RateCalc != null)
				{
					this._Button_RateCalc.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button_Search
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_Search;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ButtonGetLinks_Click);
				if (this._Button_Search != null)
				{
					this._Button_Search.Click -= eventHandler;
				}
				this._Button_Search = value;
				if (this._Button_Search != null)
				{
					this._Button_Search.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button_TitleDept
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_TitleDept;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button2_Click);
				if (this._Button_TitleDept != null)
				{
					this._Button_TitleDept.Click -= eventHandler;
				}
				this._Button_TitleDept = value;
				if (this._Button_TitleDept != null)
				{
					this._Button_TitleDept.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		internal virtual Button ButtonExit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonExit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ButtonExit_Click);
				if (this._ButtonExit != null)
				{
					this._ButtonExit.Click -= eventHandler;
				}
				this._ButtonExit = value;
				if (this._ButtonExit != null)
				{
					this._ButtonExit.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonGetDoc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonGetDoc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ButtonGetDoc_Click);
				if (this._ButtonGetDoc != null)
				{
					this._ButtonGetDoc.Click -= eventHandler;
				}
				this._ButtonGetDoc = value;
				if (this._ButtonGetDoc != null)
				{
					this._ButtonGetDoc.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonHelp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonHelp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ButtonHelp_Click);
				if (this._ButtonHelp != null)
				{
					this._ButtonHelp.Click -= eventHandler;
				}
				this._ButtonHelp = value;
				if (this._ButtonHelp != null)
				{
					this._ButtonHelp.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonReset
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonReset;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ButtonReset_Click);
				if (this._ButtonReset != null)
				{
					this._ButtonReset.Click -= eventHandler;
				}
				this._ButtonReset = value;
				if (this._ButtonReset != null)
				{
					this._ButtonReset.Click += eventHandler;
				}
			}
		}

		internal virtual Button ButtonResetDocs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonResetDocs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ButtonResetDocs_Click);
				if (this._ButtonResetDocs != null)
				{
					this._ButtonResetDocs.Click -= eventHandler;
				}
				this._ButtonResetDocs = value;
				if (this._ButtonResetDocs != null)
				{
					this._ButtonResetDocs.Click += eventHandler;
				}
			}
		}

		internal virtual ComboBox cbox_StatsStates
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbox_StatsStates;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.cbox_StatsStates_SelectedIndexChanged);
				if (this._cbox_StatsStates != null)
				{
					this._cbox_StatsStates.TextChanged -= eventHandler;
				}
				this._cbox_StatsStates = value;
				if (this._cbox_StatsStates != null)
				{
					this._cbox_StatsStates.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cbox_StatsTaxCounties
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbox_StatsTaxCounties;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.cbox_StatsTaxCounties_SelectedIndexChanged);
				if (this._cbox_StatsTaxCounties != null)
				{
					this._cbox_StatsTaxCounties.SelectedIndexChanged -= eventHandler;
				}
				this._cbox_StatsTaxCounties = value;
				if (this._cbox_StatsTaxCounties != null)
				{
					this._cbox_StatsTaxCounties.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboxDocState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cboxDocState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboxDocState = value;
			}
		}

		internal virtual ComboBox cboxDocType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cboxDocType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboxDocType = value;
			}
		}

		internal virtual ComboBox cbxAddtlLinks
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbxAddtlLinks;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.cbxAddtlLinks_SelectedIndexChanged);
				if (this._cbxAddtlLinks != null)
				{
					this._cbxAddtlLinks.SelectedIndexChanged -= eventHandler;
				}
				this._cbxAddtlLinks = value;
				if (this._cbxAddtlLinks != null)
				{
					this._cbxAddtlLinks.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		internal virtual ComboBox ComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox1 = value;
			}
		}

		internal virtual ComboBox ComboBoxCounty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBoxCounty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ComboBoxCounty_SelectedIndexChanged);
				if (this._ComboBoxCounty != null)
				{
					this._ComboBoxCounty.TextChanged -= eventHandler;
				}
				this._ComboBoxCounty = value;
				if (this._ComboBoxCounty != null)
				{
					this._ComboBoxCounty.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox ComboBoxState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBoxState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.comboboxState_TextChanged);
				if (this._ComboBoxState != null)
				{
					this._ComboBoxState.TextChanged -= eventHandler;
				}
				this._ComboBoxState = value;
				if (this._ComboBoxState != null)
				{
					this._ComboBoxState.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox ComboBoxTaxAuth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBoxTaxAuth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ComboBoxTaxAuth_SelectedIndexChanged);
				if (this._ComboBoxTaxAuth != null)
				{
					this._ComboBoxTaxAuth.TextChanged -= eventHandler;
				}
				this._ComboBoxTaxAuth = value;
				if (this._ComboBoxTaxAuth != null)
				{
					this._ComboBoxTaxAuth.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox ComboBoxTaxType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBoxTaxType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBoxTaxType = value;
			}
		}

		internal virtual DataGridView DataGridView1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataGridView1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(form1.DataGridView1_CellContentDoubleClick);
				if (this._DataGridView1 != null)
				{
					this._DataGridView1.CellContentDoubleClick -= dataGridViewCellEventHandler;
				}
				this._DataGridView1 = value;
				if (this._DataGridView1 != null)
				{
					this._DataGridView1.CellContentDoubleClick += dataGridViewCellEventHandler;
				}
			}
		}

		internal virtual DataGridView DataGridView2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataGridView2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataGridView2 = value;
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

		internal virtual GroupBox GroupBox10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox10 = value;
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

		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		internal virtual GroupBox GroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		internal virtual GroupBox GroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		internal virtual GroupBox GroupBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		internal virtual GroupBox GroupBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox8 = value;
			}
		}

		internal virtual Label Label_aftacq
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_aftacq;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_aftacq = value;
			}
		}

		internal virtual Label Label_claimLien
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_claimLien;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_claimLien = value;
			}
		}

		internal virtual Label Label_credclaim
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_credclaim;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_credclaim = value;
			}
		}

		internal virtual Label Label_DOI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_DOI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_DOI = value;
			}
		}

		internal virtual Label Label_fc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_fc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_fc = value;
			}
		}

		internal virtual Label Label_forclRedem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_forclRedem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_forclRedem = value;
			}
		}

		internal virtual Label Label_heloc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_heloc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_heloc = value;
			}
		}

		internal virtual Label Label_HOA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_HOA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_HOA = value;
			}
		}

		internal virtual Label Label_hospLien
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_hospLien;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_hospLien = value;
			}
		}

		internal virtual Label Label_jgmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_jgmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_jgmt = value;
			}
		}

		internal virtual Label Label_lisPendens
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_lisPendens;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_lisPendens = value;
			}
		}

		internal virtual Label Label_mechLien
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_mechLien;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_mechLien = value;
			}
		}

		internal virtual Label Label_mtg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_mtg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_mtg = value;
			}
		}

		internal virtual Label Label_NOC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_NOC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_NOC = value;
			}
		}

		internal virtual Label Label_persTax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_persTax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_persTax = value;
			}
		}

		internal virtual Label Label_probate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_probate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_probate = value;
			}
		}

		internal virtual Label Label_pwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_pwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_pwd = value;
			}
		}

		internal virtual Label Label_secState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_secState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_secState = value;
			}
		}

		internal virtual Label Label_spousal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_spousal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_spousal = value;
			}
		}

		internal virtual Label Label_stateJgmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_stateJgmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_stateJgmt = value;
			}
		}

		internal virtual Label Label_statutecomments
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_statutecomments;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_statutecomments = value;
			}
		}

		internal virtual Label Label_stCode
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_stCode;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_stCode = value;
			}
		}

		internal virtual Label Label_support
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_support;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_support = value;
			}
		}

		internal virtual Label Label_taxTakRedem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_taxTakRedem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_taxTakRedem = value;
			}
		}

		internal virtual Label Label_teRule
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_teRule;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_teRule = value;
			}
		}

		internal virtual Label Label_user
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_user;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_user = value;
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

		internal virtual Label Label100
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label100;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label100 = value;
			}
		}

		internal virtual Label Label101
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label101;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label101 = value;
			}
		}

		internal virtual Label Label102
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label102;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label102 = value;
			}
		}

		internal virtual Label Label103
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label103;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label103 = value;
			}
		}

		internal virtual Label Label104
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label104;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label104 = value;
			}
		}

		internal virtual Label Label105
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label105;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label105 = value;
			}
		}

		internal virtual Label Label106
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label106;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label106 = value;
			}
		}

		internal virtual Label Label107
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label107;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label107 = value;
			}
		}

		internal virtual Label Label108
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label108;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label108 = value;
			}
		}

		internal virtual Label Label109
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label109;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label109 = value;
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

		internal virtual Label Label110
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label110;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label110 = value;
			}
		}

		internal virtual Label Label111
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label111;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label111 = value;
			}
		}

		internal virtual Label Label112
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label112;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label112 = value;
			}
		}

		internal virtual Label Label113
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label113;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label113 = value;
			}
		}

		internal virtual Label Label114
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label114;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label114 = value;
			}
		}

		internal virtual Label Label115
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label115;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label115 = value;
			}
		}

		internal virtual Label Label116
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label116;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label116 = value;
			}
		}

		internal virtual Label Label118
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label118;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label118 = value;
			}
		}

		internal virtual Label Label119
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label119;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label119 = value;
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

		internal virtual Label Label120
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label120;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label120 = value;
			}
		}

		internal virtual Label Label121
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label121;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label121 = value;
			}
		}

		internal virtual Label Label123
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label123;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label123 = value;
			}
		}

		internal virtual Label Label128
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label128;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label128 = value;
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

		internal virtual Label Label135
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label135;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label135 = value;
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

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
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

		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		internal virtual Label Label25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label25 = value;
			}
		}

		internal virtual Label Label26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label26 = value;
			}
		}

		internal virtual Label Label27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label27 = value;
			}
		}

		internal virtual Label Label28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label28 = value;
			}
		}

		internal virtual Label Label29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label29 = value;
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

		internal virtual Label Label30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label30 = value;
			}
		}

		internal virtual Label Label32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label32 = value;
			}
		}

		internal virtual Label Label34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label34 = value;
			}
		}

		internal virtual Label Label35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label35 = value;
			}
		}

		internal virtual Label Label36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label36 = value;
			}
		}

		internal virtual Label Label37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label37 = value;
			}
		}

		internal virtual Label Label39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label39 = value;
			}
		}

		internal virtual Label Label40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label40 = value;
			}
		}

		internal virtual Label Label41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label41 = value;
			}
		}

		internal virtual Label Label46
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label46;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label46 = value;
			}
		}

		internal virtual Label Label48
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label48;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label48 = value;
			}
		}

		internal virtual Label Label49
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label49;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label49 = value;
			}
		}

		internal virtual Label Label4Tap
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4Tap;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Label4Tap_Leave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.Label4Tap_Hover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.Label4Tap_Click);
				if (this._Label4Tap != null)
				{
					this._Label4Tap.MouseLeave -= eventHandler;
					this._Label4Tap.MouseHover -= eventHandler1;
					this._Label4Tap.Click -= eventHandler2;
				}
				this._Label4Tap = value;
				if (this._Label4Tap != null)
				{
					this._Label4Tap.MouseLeave += eventHandler;
					this._Label4Tap.MouseHover += eventHandler1;
					this._Label4Tap.Click += eventHandler2;
				}
			}
		}

		internal virtual Label Label50
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label50;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label50 = value;
			}
		}

		internal virtual Label Label51
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label51;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label51 = value;
			}
		}

		internal virtual Label Label52
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label52;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label52 = value;
			}
		}

		internal virtual Label Label54
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label54;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label54 = value;
			}
		}

		internal virtual Label Label55
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label55;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label55 = value;
			}
		}

		internal virtual Label Label56
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label56;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label56 = value;
			}
		}

		internal virtual Label Label58
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label58;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label58 = value;
			}
		}

		internal virtual Label Label5dtree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5dtree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Label5dtree_Leave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.Label5dtree_Hover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.Label5dtree_Click);
				if (this._Label5dtree != null)
				{
					this._Label5dtree.MouseLeave -= eventHandler;
					this._Label5dtree.MouseHover -= eventHandler1;
					this._Label5dtree.Click -= eventHandler2;
				}
				this._Label5dtree = value;
				if (this._Label5dtree != null)
				{
					this._Label5dtree.MouseLeave += eventHandler;
					this._Label5dtree.MouseHover += eventHandler1;
					this._Label5dtree.Click += eventHandler2;
				}
			}
		}

		internal virtual Label Label62
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label62;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label62 = value;
			}
		}

		internal virtual Label Label64
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label64;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label64 = value;
			}
		}

		internal virtual Label Label66
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label66;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label66 = value;
			}
		}

		internal virtual Label Label6RV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6RV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Label6RV_Click);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.Label6RV_Leave);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.Label6RV_Hover);
				if (this._Label6RV != null)
				{
					this._Label6RV.Click -= eventHandler;
					this._Label6RV.MouseLeave -= eventHandler1;
					this._Label6RV.MouseHover -= eventHandler2;
				}
				this._Label6RV = value;
				if (this._Label6RV != null)
				{
					this._Label6RV.Click += eventHandler;
					this._Label6RV.MouseLeave += eventHandler1;
					this._Label6RV.MouseHover += eventHandler2;
				}
			}
		}

		internal virtual Label Label70
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label70;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label70 = value;
			}
		}

		internal virtual Label Label73
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label73;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label73 = value;
			}
		}

		internal virtual Label Label74
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label74;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label74 = value;
			}
		}

		internal virtual Label Label75
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label75;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label75 = value;
			}
		}

		internal virtual Label Label76
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label76;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label76 = value;
			}
		}

		internal virtual Label Label77
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label77;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label77 = value;
			}
		}

		internal virtual Label Label78
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label78;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label78 = value;
			}
		}

		internal virtual Label Label80
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label80;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label80 = value;
			}
		}

		internal virtual Label Label82
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label82;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label82 = value;
			}
		}

		internal virtual Label Label84
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label84;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label84 = value;
			}
		}

		internal virtual Label Label85
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label85;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label85 = value;
			}
		}

		internal virtual Label Label86
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label86;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label86 = value;
			}
		}

		internal virtual Label Label87
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label87;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label87 = value;
			}
		}

		internal virtual Label Label88
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label88;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label88 = value;
			}
		}

		internal virtual Label Label89
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label89;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label89 = value;
			}
		}

		internal virtual Label Label90
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label90;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label90 = value;
			}
		}

		internal virtual Label Label91
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label91;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label91 = value;
			}
		}

		internal virtual Label Label92
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label92;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label92 = value;
			}
		}

		internal virtual Label Label93
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label93;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label93 = value;
			}
		}

		internal virtual Label Label94
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label94;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label94 = value;
			}
		}

		internal virtual Label Label95
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label95;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label95 = value;
			}
		}

		internal virtual Label Label96
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label96;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label96 = value;
			}
		}

		internal virtual Label Label97
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label97;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label97 = value;
			}
		}

		internal virtual Label Label98
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label98;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label98 = value;
			}
		}

		internal virtual Label Label99
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label99;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label99 = value;
			}
		}

		internal virtual Label LabelAssessor
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelAssessor;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelAssessor = value;
			}
		}

		internal virtual Label LabelCopy_source
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCopy_source;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCopy_source = value;
			}
		}

		internal virtual Label LabelCopyPmtType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCopyPmtType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCopyPmtType = value;
			}
		}

		internal virtual Label LabelCountyHome
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCountyHome;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCountyHome = value;
			}
		}

		internal virtual Label LabelCountyTax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCountyTax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCountyTax = value;
			}
		}

		internal virtual Label LabelCountyURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCountyURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCountyURL = value;
			}
		}

		internal virtual Label LabelCourt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCourt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCourt = value;
			}
		}

		internal virtual Label LabelForeclosures
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelForeclosures;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelForeclosures = value;
			}
		}

		internal virtual Label LabelImage_date
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelImage_date;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelImage_date = value;
			}
		}

		internal virtual Label LabelIndex_date
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelIndex_date;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelIndex_date = value;
			}
		}

		internal virtual Label LabelIndex_source
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelIndex_source;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelIndex_source = value;
			}
		}

		internal virtual Label LabelMapsGIS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelMapsGIS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelMapsGIS = value;
			}
		}

		internal virtual Label LabelMuniCourt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelMuniCourt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelMuniCourt = value;
			}
		}

		internal virtual Label LabelOtherTax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelOtherTax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelOtherTax = value;
			}
		}

		internal virtual Label LabelOtherURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelOtherURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelOtherURL = value;
			}
		}

		internal virtual Label LabelProbate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelProbate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelProbate = value;
			}
		}

		internal virtual Label LabelProthon
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelProthon;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelProthon = value;
			}
		}

		internal virtual Label LabelSheriff
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelSheriff;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelSheriff = value;
			}
		}

		internal virtual Label LabelSubNeeded
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelSubNeeded;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelSubNeeded = value;
			}
		}

		internal virtual Label LabelUCC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelUCC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelUCC = value;
			}
		}

		internal virtual Label LabelUseCopy
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelUseCopy;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelUseCopy = value;
			}
		}

		internal virtual Label LabelUseDtree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelUseDtree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelUseDtree = value;
			}
		}

		internal virtual Label LabelUseIns
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelUseIns;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelUseIns = value;
			}
		}

		internal virtual Label LabelUseProps
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelUseProps;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelUseProps = value;
			}
		}

		internal virtual Label LabelUseRV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelUseRV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelUseRV = value;
			}
		}

		internal virtual Label LabelUseTap
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelUseTap;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelUseTap = value;
			}
		}

		internal virtual Label lbl_attyClose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_attyClose;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_attyClose = value;
			}
		}

		internal virtual Label lbl_attyState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_attyState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_attyState = value;
			}
		}

		internal virtual Label lbl_BusnPhones
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_BusnPhones;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lbl_BusnPhones_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lbl_BusnPhones_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lbl_BusnPhones_Click);
				if (this._lbl_BusnPhones != null)
				{
					this._lbl_BusnPhones.MouseLeave -= eventHandler;
					this._lbl_BusnPhones.MouseHover -= eventHandler1;
					this._lbl_BusnPhones.Click -= eventHandler2;
				}
				this._lbl_BusnPhones = value;
				if (this._lbl_BusnPhones != null)
				{
					this._lbl_BusnPhones.MouseLeave += eventHandler;
					this._lbl_BusnPhones.MouseHover += eventHandler1;
					this._lbl_BusnPhones.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_CoOnlineStats
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_CoOnlineStats;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_CoOnlineStats = value;
			}
		}

		internal virtual Label lbl_copyFeeAmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_copyFeeAmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_copyFeeAmt = value;
			}
		}

		internal virtual Label lbl_courtImgDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_courtImgDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_courtImgDate = value;
			}
		}

		internal virtual Label lbl_courtIndexDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_courtIndexDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_courtIndexDate = value;
			}
		}

		internal virtual Label lbl_creditCard
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_creditCard;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lbl_creditCard_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lbl_creditCard_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lbl_creditCard_Click);
				if (this._lbl_creditCard != null)
				{
					this._lbl_creditCard.MouseLeave -= eventHandler;
					this._lbl_creditCard.MouseHover -= eventHandler1;
					this._lbl_creditCard.Click -= eventHandler2;
				}
				this._lbl_creditCard = value;
				if (this._lbl_creditCard != null)
				{
					this._lbl_creditCard.MouseLeave += eventHandler;
					this._lbl_creditCard.MouseHover += eventHandler1;
					this._lbl_creditCard.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_deed_prep
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_deed_prep;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblDeedPrep_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblDeedPrep_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblDeedPrep_Click);
				if (this._lbl_deed_prep != null)
				{
					this._lbl_deed_prep.MouseLeave -= eventHandler;
					this._lbl_deed_prep.MouseHover -= eventHandler1;
					this._lbl_deed_prep.Click -= eventHandler2;
				}
				this._lbl_deed_prep = value;
				if (this._lbl_deed_prep != null)
				{
					this._lbl_deed_prep.MouseLeave += eventHandler;
					this._lbl_deed_prep.MouseHover += eventHandler1;
					this._lbl_deed_prep.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_aboutDeeds
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_aboutDeeds;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblDocDeeds_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblDocDeeds_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblDocDeeds_Click);
				if (this._lbl_doc_aboutDeeds != null)
				{
					this._lbl_doc_aboutDeeds.MouseLeave -= eventHandler;
					this._lbl_doc_aboutDeeds.MouseHover -= eventHandler1;
					this._lbl_doc_aboutDeeds.Click -= eventHandler2;
				}
				this._lbl_doc_aboutDeeds = value;
				if (this._lbl_doc_aboutDeeds != null)
				{
					this._lbl_doc_aboutDeeds.MouseLeave += eventHandler;
					this._lbl_doc_aboutDeeds.MouseHover += eventHandler1;
					this._lbl_doc_aboutDeeds.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_aboutVesting
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_aboutVesting;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblVesting_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblVesting_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblVesting_Click);
				if (this._lbl_doc_aboutVesting != null)
				{
					this._lbl_doc_aboutVesting.MouseLeave -= eventHandler;
					this._lbl_doc_aboutVesting.MouseHover -= eventHandler1;
					this._lbl_doc_aboutVesting.Click -= eventHandler2;
				}
				this._lbl_doc_aboutVesting = value;
				if (this._lbl_doc_aboutVesting != null)
				{
					this._lbl_doc_aboutVesting.MouseLeave += eventHandler;
					this._lbl_doc_aboutVesting.MouseHover += eventHandler1;
					this._lbl_doc_aboutVesting.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_AbstractingSOPs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_AbstractingSOPs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lbl_AbstrSOP_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lbl_AbstrSOP_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lbl_AbstrSOP_Click);
				if (this._lbl_doc_AbstractingSOPs != null)
				{
					this._lbl_doc_AbstractingSOPs.MouseLeave -= eventHandler;
					this._lbl_doc_AbstractingSOPs.MouseHover -= eventHandler1;
					this._lbl_doc_AbstractingSOPs.Click -= eventHandler2;
				}
				this._lbl_doc_AbstractingSOPs = value;
				if (this._lbl_doc_AbstractingSOPs != null)
				{
					this._lbl_doc_AbstractingSOPs.MouseLeave += eventHandler;
					this._lbl_doc_AbstractingSOPs.MouseHover += eventHandler1;
					this._lbl_doc_AbstractingSOPs.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_Alta_Clta
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_Alta_Clta;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblAltaClta_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblAltaClta_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblAltaClta_Click);
				if (this._lbl_doc_Alta_Clta != null)
				{
					this._lbl_doc_Alta_Clta.MouseLeave -= eventHandler;
					this._lbl_doc_Alta_Clta.MouseHover -= eventHandler1;
					this._lbl_doc_Alta_Clta.Click -= eventHandler2;
				}
				this._lbl_doc_Alta_Clta = value;
				if (this._lbl_doc_Alta_Clta != null)
				{
					this._lbl_doc_Alta_Clta.MouseLeave += eventHandler;
					this._lbl_doc_Alta_Clta.MouseHover += eventHandler1;
					this._lbl_doc_Alta_Clta.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_approvePOA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_approvePOA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblPOA_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblPOA_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblPOA_Click);
				if (this._lbl_doc_approvePOA != null)
				{
					this._lbl_doc_approvePOA.MouseLeave -= eventHandler;
					this._lbl_doc_approvePOA.MouseHover -= eventHandler1;
					this._lbl_doc_approvePOA.Click -= eventHandler2;
				}
				this._lbl_doc_approvePOA = value;
				if (this._lbl_doc_approvePOA != null)
				{
					this._lbl_doc_approvePOA.MouseLeave += eventHandler;
					this._lbl_doc_approvePOA.MouseHover += eventHandler1;
					this._lbl_doc_approvePOA.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_endorsInfo
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_endorsInfo;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lbl_endorsInfo_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lbl_endorsInfo_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lbl_endorsInfo_Click);
				if (this._lbl_doc_endorsInfo != null)
				{
					this._lbl_doc_endorsInfo.MouseLeave -= eventHandler;
					this._lbl_doc_endorsInfo.MouseHover -= eventHandler1;
					this._lbl_doc_endorsInfo.Click -= eventHandler2;
				}
				this._lbl_doc_endorsInfo = value;
				if (this._lbl_doc_endorsInfo != null)
				{
					this._lbl_doc_endorsInfo.MouseLeave += eventHandler;
					this._lbl_doc_endorsInfo.MouseHover += eventHandler1;
					this._lbl_doc_endorsInfo.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_Lease_Fee_LandContract
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_Lease_Fee_LandContract;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblLeaseFee_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblLeaseFee_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblLeaseFee_Click);
				if (this._lbl_doc_Lease_Fee_LandContract != null)
				{
					this._lbl_doc_Lease_Fee_LandContract.MouseLeave -= eventHandler;
					this._lbl_doc_Lease_Fee_LandContract.MouseHover -= eventHandler1;
					this._lbl_doc_Lease_Fee_LandContract.Click -= eventHandler2;
				}
				this._lbl_doc_Lease_Fee_LandContract = value;
				if (this._lbl_doc_Lease_Fee_LandContract != null)
				{
					this._lbl_doc_Lease_Fee_LandContract.MouseLeave += eventHandler;
					this._lbl_doc_Lease_Fee_LandContract.MouseHover += eventHandler1;
					this._lbl_doc_Lease_Fee_LandContract.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_doc_SOP_deedprep
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_doc_SOP_deedprep;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblDeedPrepSOP_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblDeedPrepSOP_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblDeedPrepSOP_Click);
				if (this._lbl_doc_SOP_deedprep != null)
				{
					this._lbl_doc_SOP_deedprep.MouseLeave -= eventHandler;
					this._lbl_doc_SOP_deedprep.MouseHover -= eventHandler1;
					this._lbl_doc_SOP_deedprep.Click -= eventHandler2;
				}
				this._lbl_doc_SOP_deedprep = value;
				if (this._lbl_doc_SOP_deedprep != null)
				{
					this._lbl_doc_SOP_deedprep.MouseLeave += eventHandler;
					this._lbl_doc_SOP_deedprep.MouseHover += eventHandler1;
					this._lbl_doc_SOP_deedprep.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lbl_Free
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_Free;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_Free = value;
			}
		}

		internal virtual Label lbl_homestead
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_homestead;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_homestead = value;
			}
		}

		internal virtual Label lbl_IndexFeeAmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_IndexFeeAmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_IndexFeeAmt = value;
			}
		}

		internal virtual Label lbl_IndexPmtMethod
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_IndexPmtMethod;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_IndexPmtMethod = value;
			}
		}

		internal virtual Label lbl_MyFlaCounties
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_MyFlaCounties;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_MyFlaCounties = value;
			}
		}

		internal virtual Label lbl_NotFound
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_NotFound;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_NotFound = value;
			}
		}

		internal virtual Label lbl_OrbStat1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_OrbStat1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_OrbStat1 = value;
			}
		}

		internal virtual Label lbl_OrbStat2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_OrbStat2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_OrbStat2 = value;
			}
		}

		internal virtual Label lbl_OrbStat3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_OrbStat3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_OrbStat3 = value;
			}
		}

		internal virtual Label lbl_OrbStat4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_OrbStat4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_OrbStat4 = value;
			}
		}

		internal virtual Label lbl_OrbStat5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_OrbStat5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_OrbStat5 = value;
			}
		}

		internal virtual Label lbl_OrbStat6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_OrbStat6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_OrbStat6 = value;
			}
		}

		internal virtual Label lbl_OrbStats
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_OrbStats;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_OrbStats = value;
			}
		}

		internal virtual Label lbl_SubTerm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_SubTerm;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_SubTerm = value;
			}
		}

		internal virtual Label lbl_TaxOnlineStats
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_TaxOnlineStats;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_TaxOnlineStats = value;
			}
		}

		internal virtual Label lbl_verifDate1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verifDate1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verifDate1 = value;
			}
		}

		internal virtual Label lbl_verifDate2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verifDate2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verifDate2 = value;
			}
		}

		internal virtual Label lbl_verifDate3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verifDate3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verifDate3 = value;
			}
		}

		internal virtual Label lbl_verifDate4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verifDate4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verifDate4 = value;
			}
		}

		internal virtual Label lbl_verifDate5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verifDate5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verifDate5 = value;
			}
		}

		internal virtual Label lbl_verified_taxoff1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verified_taxoff1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verified_taxoff1 = value;
			}
		}

		internal virtual Label lbl_verified_taxoff2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verified_taxoff2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verified_taxoff2 = value;
			}
		}

		internal virtual Label lbl_verified_taxoff3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verified_taxoff3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verified_taxoff3 = value;
			}
		}

		internal virtual Label lbl_verified_taxoff4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verified_taxoff4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verified_taxoff4 = value;
			}
		}

		internal virtual Label lbl_verified_taxoff5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_verified_taxoff5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_verified_taxoff5 = value;
			}
		}

		internal virtual Label lbl_vstats_Apr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Apr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Apr = value;
			}
		}

		internal virtual Label lbl_vstats_Aug
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Aug;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Aug = value;
			}
		}

		internal virtual Label lbl_vstats_Dec
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Dec;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Dec = value;
			}
		}

		internal virtual Label lbl_vstats_Feb
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Feb;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Feb = value;
			}
		}

		internal virtual Label lbl_vstats_Jan
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Jan;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Jan = value;
			}
		}

		internal virtual Label lbl_vstats_Jul
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Jul;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Jul = value;
			}
		}

		internal virtual Label lbl_vstats_Jun
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Jun;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Jun = value;
			}
		}

		internal virtual Label lbl_vstats_Mar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Mar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Mar = value;
			}
		}

		internal virtual Label lbl_vstats_May
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_May;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_May = value;
			}
		}

		internal virtual Label lbl_vstats_Nov
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Nov;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Nov = value;
			}
		}

		internal virtual Label lbl_vstats_Oct
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Oct;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Oct = value;
			}
		}

		internal virtual Label lbl_vstats_Sep
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_Sep;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_Sep = value;
			}
		}

		internal virtual Label lbl_vstats_YTD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_vstats_YTD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_vstats_YTD = value;
			}
		}

		internal virtual Label lbl_WeSubscribe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_WeSubscribe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_WeSubscribe = value;
			}
		}

		internal virtual Label lblDefault_UW_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDefault_UW_Name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDefault_UW_Name = value;
			}
		}

		internal virtual Label lblOpenClearanceCustSpecs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblOpenClearanceCustSpecs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblOpenClearance_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblOpenClearance_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblOpenClearance_Click);
				if (this._lblOpenClearanceCustSpecs != null)
				{
					this._lblOpenClearanceCustSpecs.MouseLeave -= eventHandler;
					this._lblOpenClearanceCustSpecs.MouseHover -= eventHandler1;
					this._lblOpenClearanceCustSpecs.Click -= eventHandler2;
				}
				this._lblOpenClearanceCustSpecs = value;
				if (this._lblOpenClearanceCustSpecs != null)
				{
					this._lblOpenClearanceCustSpecs.MouseLeave += eventHandler;
					this._lblOpenClearanceCustSpecs.MouseHover += eventHandler1;
					this._lblOpenClearanceCustSpecs.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lblOpenEtitleWkshare
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblOpenEtitleWkshare;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblOpenEtitleWkshare_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblOpenEtitleWkshare_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblOpenEtitleWkshare_Click);
				if (this._lblOpenEtitleWkshare != null)
				{
					this._lblOpenEtitleWkshare.MouseLeave -= eventHandler;
					this._lblOpenEtitleWkshare.MouseHover -= eventHandler1;
					this._lblOpenEtitleWkshare.Click -= eventHandler2;
				}
				this._lblOpenEtitleWkshare = value;
				if (this._lblOpenEtitleWkshare != null)
				{
					this._lblOpenEtitleWkshare.MouseLeave += eventHandler;
					this._lblOpenEtitleWkshare.MouseHover += eventHandler1;
					this._lblOpenEtitleWkshare.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lblOpenORT_Wkshare
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblOpenORT_Wkshare;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblOpenORT_Wkshare_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblOpenORT_Wkshare_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblOpenORT_Wkshare_Click);
				if (this._lblOpenORT_Wkshare != null)
				{
					this._lblOpenORT_Wkshare.MouseLeave -= eventHandler;
					this._lblOpenORT_Wkshare.MouseHover -= eventHandler1;
					this._lblOpenORT_Wkshare.Click -= eventHandler2;
				}
				this._lblOpenORT_Wkshare = value;
				if (this._lblOpenORT_Wkshare != null)
				{
					this._lblOpenORT_Wkshare.MouseLeave += eventHandler;
					this._lblOpenORT_Wkshare.MouseHover += eventHandler1;
					this._lblOpenORT_Wkshare.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lblOpenRunSheet
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblOpenRunSheet;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblOpenRunSheet_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblOpenRunSheet_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblOpenRunSheet_Click);
				if (this._lblOpenRunSheet != null)
				{
					this._lblOpenRunSheet.MouseLeave -= eventHandler;
					this._lblOpenRunSheet.MouseHover -= eventHandler1;
					this._lblOpenRunSheet.Click -= eventHandler2;
				}
				this._lblOpenRunSheet = value;
				if (this._lblOpenRunSheet != null)
				{
					this._lblOpenRunSheet.MouseLeave += eventHandler;
					this._lblOpenRunSheet.MouseHover += eventHandler1;
					this._lblOpenRunSheet.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lblOpenTitleCustSpec
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblOpenTitleCustSpec;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblOpenTitleCustSpec_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblOpenTitleCustSpec_mouseHover);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.lblOpenTitleProdCustSpecs_Click);
				if (this._lblOpenTitleCustSpec != null)
				{
					this._lblOpenTitleCustSpec.MouseLeave -= eventHandler;
					this._lblOpenTitleCustSpec.MouseHover -= eventHandler1;
					this._lblOpenTitleCustSpec.Click -= eventHandler2;
				}
				this._lblOpenTitleCustSpec = value;
				if (this._lblOpenTitleCustSpec != null)
				{
					this._lblOpenTitleCustSpec.MouseLeave += eventHandler;
					this._lblOpenTitleCustSpec.MouseHover += eventHandler1;
					this._lblOpenTitleCustSpec.Click += eventHandler2;
				}
			}
		}

		internal virtual Label lblSOL_AftAcq
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_AftAcq;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_AftAcq = value;
			}
		}

		internal virtual Label lblSOL_being_Clause
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_being_Clause;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_being_Clause = value;
			}
		}

		internal virtual Label lblSOL_ClaimLien
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_ClaimLien;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_ClaimLien = value;
			}
		}

		internal virtual Label lblSOL_Creditor_Claims
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Creditor_Claims;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Creditor_Claims = value;
			}
		}

		internal virtual Label lblSOL_forecl_redem_per
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_forecl_redem_per;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_forecl_redem_per = value;
			}
		}

		internal virtual Label lblSOL_Heloc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Heloc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblSOL_heloc_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblSOL_heloc_mouseHover);
				if (this._lblSOL_Heloc != null)
				{
					this._lblSOL_Heloc.MouseLeave -= eventHandler;
					this._lblSOL_Heloc.MouseHover -= eventHandler1;
				}
				this._lblSOL_Heloc = value;
				if (this._lblSOL_Heloc != null)
				{
					this._lblSOL_Heloc.MouseLeave += eventHandler;
					this._lblSOL_Heloc.MouseHover += eventHandler1;
				}
			}
		}

		internal virtual Label lblSOL_HOA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_HOA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_HOA = value;
			}
		}

		internal virtual Label lblSOL_Hosp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Hosp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Hosp = value;
			}
		}

		internal virtual Label lblSOL_Jgmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Jgmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Jgmt = value;
			}
		}

		internal virtual Label lblSOL_lispen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_lispen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_lispen = value;
			}
		}

		internal virtual Label lblSOL_Mech
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Mech;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Mech = value;
			}
		}

		internal virtual Label lblSOL_Mtg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Mtg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.lblSOL_Mtg_mouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.lblSOL_Mtg_mouseHover);
				if (this._lblSOL_Mtg != null)
				{
					this._lblSOL_Mtg.MouseLeave -= eventHandler;
					this._lblSOL_Mtg.MouseHover -= eventHandler1;
				}
				this._lblSOL_Mtg = value;
				if (this._lblSOL_Mtg != null)
				{
					this._lblSOL_Mtg.MouseLeave += eventHandler;
					this._lblSOL_Mtg.MouseHover += eventHandler1;
				}
			}
		}

		internal virtual Label lblSOL_Notice
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Notice;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Notice = value;
			}
		}

		internal virtual Label lblSOL_PersTax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_PersTax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_PersTax = value;
			}
		}

		internal virtual Label lblSOL_Spousal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Spousal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Spousal = value;
			}
		}

		internal virtual Label lblSOL_StateJgmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_StateJgmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_StateJgmt = value;
			}
		}

		internal virtual Label lblSOL_Support
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Support;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Support = value;
			}
		}

		internal virtual Label lblSOL_Tax_RedemPer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_Tax_RedemPer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_Tax_RedemPer = value;
			}
		}

		internal virtual Label lblSOL_TERule
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSOL_TERule;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSOL_TERule = value;
			}
		}

		internal virtual Label lblTxAuth1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTxAuth1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTxAuth1 = value;
			}
		}

		internal virtual Label lblTxAuth2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTxAuth2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTxAuth2 = value;
			}
		}

		internal virtual Label lblTxAuth3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTxAuth3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTxAuth3 = value;
			}
		}

		internal virtual Label lblTxAuth4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTxAuth4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTxAuth4 = value;
			}
		}

		internal virtual Label lblTxAuth5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTxAuth5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTxAuth5 = value;
			}
		}

		internal virtual LinkLabel LinkLabel_DeptIns
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel_DeptIns;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LinkLabel_DeptIns = value;
			}
		}

		internal virtual LinkLabel LinkLabel_MyFlCountiesURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel_MyFlCountiesURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabel_MyFla_LinkClicked);
				if (this._LinkLabel_MyFlCountiesURL != null)
				{
					this._LinkLabel_MyFlCountiesURL.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel_MyFlCountiesURL = value;
				if (this._LinkLabel_MyFlCountiesURL != null)
				{
					this._LinkLabel_MyFlCountiesURL.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabel_OtherURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel_OtherURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LinkLabel_OtherURL = value;
			}
		}

		internal virtual LinkLabel LinkLabel_SecState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel_SecState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LinkLabel_SecState = value;
			}
		}

		internal virtual LinkLabel LinkLabel_State_Code
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel_State_Code;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LinkLabel_State_Code = value;
			}
		}

		internal virtual LinkLabel LinkLabel_UCC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel_UCC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LinkLabel_UCC = value;
			}
		}

		internal virtual LinkLabel LinkLabel10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabel10_LinkClicked);
				if (this._LinkLabel10 != null)
				{
					this._LinkLabel10.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel10 = value;
				if (this._LinkLabel10 != null)
				{
					this._LinkLabel10.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabel16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabel16_LinkClicked);
				if (this._LinkLabel16 != null)
				{
					this._LinkLabel16.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel16 = value;
				if (this._LinkLabel16 != null)
				{
					this._LinkLabel16.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabel4_LinkClicked);
				if (this._LinkLabel4 != null)
				{
					this._LinkLabel4.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel4 = value;
				if (this._LinkLabel4 != null)
				{
					this._LinkLabel4.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabel9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabel9_LinkClicked);
				if (this._LinkLabel9 != null)
				{
					this._LinkLabel9.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel9 = value;
				if (this._LinkLabel9 != null)
				{
					this._LinkLabel9.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelAssessor
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelAssessor;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelAssessor_LinkClicked);
				if (this._LinkLabelAssessor != null)
				{
					this._LinkLabelAssessor.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelAssessor = value;
				if (this._LinkLabelAssessor != null)
				{
					this._LinkLabelAssessor.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelCoHome
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelCoHome;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelCoHome_LinkClicked);
				if (this._LinkLabelCoHome != null)
				{
					this._LinkLabelCoHome.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelCoHome = value;
				if (this._LinkLabelCoHome != null)
				{
					this._LinkLabelCoHome.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelCounty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelCounty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelCounty_LinkClicked);
				if (this._LinkLabelCounty != null)
				{
					this._LinkLabelCounty.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelCounty = value;
				if (this._LinkLabelCounty != null)
				{
					this._LinkLabelCounty.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelCourt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelCourt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelCourt_LinkClicked);
				if (this._LinkLabelCourt != null)
				{
					this._LinkLabelCourt.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelCourt = value;
				if (this._LinkLabelCourt != null)
				{
					this._LinkLabelCourt.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelForeclosure
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelForeclosure;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelForeclosure_LinkClicked);
				if (this._LinkLabelForeclosure != null)
				{
					this._LinkLabelForeclosure.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelForeclosure = value;
				if (this._LinkLabelForeclosure != null)
				{
					this._LinkLabelForeclosure.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelMaps
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelMaps;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelMaps_LinkClicked);
				if (this._LinkLabelMaps != null)
				{
					this._LinkLabelMaps.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelMaps = value;
				if (this._LinkLabelMaps != null)
				{
					this._LinkLabelMaps.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelMuniCourt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelMuniCourt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelTax2_LinkClicked);
				if (this._LinkLabelMuniCourt != null)
				{
					this._LinkLabelMuniCourt.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelMuniCourt = value;
				if (this._LinkLabelMuniCourt != null)
				{
					this._LinkLabelMuniCourt.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelOtherTax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelOtherTax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelOtherTax_LinkClicked);
				if (this._LinkLabelOtherTax != null)
				{
					this._LinkLabelOtherTax.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelOtherTax = value;
				if (this._LinkLabelOtherTax != null)
				{
					this._LinkLabelOtherTax.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelPlats
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelPlats;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LinkLabelPlats = value;
			}
		}

		internal virtual LinkLabel LinkLabelProbate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelProbate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelProbate_LinkClicked);
				if (this._LinkLabelProbate != null)
				{
					this._LinkLabelProbate.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelProbate = value;
				if (this._LinkLabelProbate != null)
				{
					this._LinkLabelProbate.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelProthon
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelProthon;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelPro_LinkClicked);
				if (this._LinkLabelProthon != null)
				{
					this._LinkLabelProthon.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelProthon = value;
				if (this._LinkLabelProthon != null)
				{
					this._LinkLabelProthon.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelSheriff
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelSheriff;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelSheriff_LinkClicked);
				if (this._LinkLabelSheriff != null)
				{
					this._LinkLabelSheriff.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelSheriff = value;
				if (this._LinkLabelSheriff != null)
				{
					this._LinkLabelSheriff.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel LinkLabelTax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabelTax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelTax_LinkClicked);
				if (this._LinkLabelTax != null)
				{
					this._LinkLabelTax.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabelTax = value;
				if (this._LinkLabelTax != null)
				{
					this._LinkLabelTax.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel linkLocTax1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._linkLocTax1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelLocTx1_LinkClicked);
				if (this._linkLocTax1 != null)
				{
					this._linkLocTax1.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._linkLocTax1 = value;
				if (this._linkLocTax1 != null)
				{
					this._linkLocTax1.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel linkLocTax2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._linkLocTax2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelLocTx2_LinkClicked);
				if (this._linkLocTax2 != null)
				{
					this._linkLocTax2.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._linkLocTax2 = value;
				if (this._linkLocTax2 != null)
				{
					this._linkLocTax2.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel linkLocTax3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._linkLocTax3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelLocTx3_LinkClicked);
				if (this._linkLocTax3 != null)
				{
					this._linkLocTax3.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._linkLocTax3 = value;
				if (this._linkLocTax3 != null)
				{
					this._linkLocTax3.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel linkLocTax4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._linkLocTax4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelLocTx4_LinkClicked);
				if (this._linkLocTax4 != null)
				{
					this._linkLocTax4.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._linkLocTax4 = value;
				if (this._linkLocTax4 != null)
				{
					this._linkLocTax4.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel linkLocTax5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._linkLocTax5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.LinkLabelLocTx5_LinkClicked);
				if (this._linkLocTax5 != null)
				{
					this._linkLocTax5.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._linkLocTax5 = value;
				if (this._linkLocTax5 != null)
				{
					this._linkLocTax5.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual LinkLabel linkUS_Legal_Forms
		{
			[DebuggerNonUserCode]
			get
			{
				return this._linkUS_Legal_Forms;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(form1.linkUS_Legal_Forms_LinkClicked);
				if (this._linkUS_Legal_Forms != null)
				{
					this._linkUS_Legal_Forms.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._linkUS_Legal_Forms = value;
				if (this._linkUS_Legal_Forms != null)
				{
					this._linkUS_Legal_Forms.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
			}
		}

		internal virtual PictureBox pbox_Abstr_SOP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbox_Abstr_SOP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pboxAbstr_SOP_MouseLeave);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.pboxAbstr_SOP_MouseHover);
				if (this._pbox_Abstr_SOP != null)
				{
					this._pbox_Abstr_SOP.MouseLeave -= eventHandler;
					this._pbox_Abstr_SOP.MouseHover -= eventHandler1;
				}
				this._pbox_Abstr_SOP = value;
				if (this._pbox_Abstr_SOP != null)
				{
					this._pbox_Abstr_SOP.MouseLeave += eventHandler;
					this._pbox_Abstr_SOP.MouseHover += eventHandler1;
				}
			}
		}

		internal virtual PictureBox pboxOpenClearanceCustSpecs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pboxOpenClearanceCustSpecs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pboxOpenClearance_Click);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.pboxOpenClearanceCustSpecs_MouseLeave);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.pboxOpenClearanceCustSpecs_MouseHover);
				if (this._pboxOpenClearanceCustSpecs != null)
				{
					this._pboxOpenClearanceCustSpecs.Click -= eventHandler;
					this._pboxOpenClearanceCustSpecs.MouseLeave -= eventHandler1;
					this._pboxOpenClearanceCustSpecs.MouseHover -= eventHandler2;
				}
				this._pboxOpenClearanceCustSpecs = value;
				if (this._pboxOpenClearanceCustSpecs != null)
				{
					this._pboxOpenClearanceCustSpecs.Click += eventHandler;
					this._pboxOpenClearanceCustSpecs.MouseLeave += eventHandler1;
					this._pboxOpenClearanceCustSpecs.MouseHover += eventHandler2;
				}
			}
		}

		internal virtual PictureBox pboxOpenCredCard
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pboxOpenCredCard;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pboxOpenCreditCard_MouseHover);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.pboxOpenCredCard_Click);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.pboxOpenCredCard_MouseLeave);
				if (this._pboxOpenCredCard != null)
				{
					this._pboxOpenCredCard.MouseHover -= eventHandler;
					this._pboxOpenCredCard.Click -= eventHandler1;
					this._pboxOpenCredCard.MouseLeave -= eventHandler2;
				}
				this._pboxOpenCredCard = value;
				if (this._pboxOpenCredCard != null)
				{
					this._pboxOpenCredCard.MouseHover += eventHandler;
					this._pboxOpenCredCard.Click += eventHandler1;
					this._pboxOpenCredCard.MouseLeave += eventHandler2;
				}
			}
		}

		internal virtual PictureBox pboxOpenEtitleWkshare
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pboxOpenEtitleWkshare;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pboxOpenEtitleWkshare_Click);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.pboxOpenEtitleWkshare_MouseLeave);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.pboxOpenEtitleWkshare_MouseHover);
				if (this._pboxOpenEtitleWkshare != null)
				{
					this._pboxOpenEtitleWkshare.Click -= eventHandler;
					this._pboxOpenEtitleWkshare.MouseLeave -= eventHandler1;
					this._pboxOpenEtitleWkshare.MouseHover -= eventHandler2;
				}
				this._pboxOpenEtitleWkshare = value;
				if (this._pboxOpenEtitleWkshare != null)
				{
					this._pboxOpenEtitleWkshare.Click += eventHandler;
					this._pboxOpenEtitleWkshare.MouseLeave += eventHandler1;
					this._pboxOpenEtitleWkshare.MouseHover += eventHandler2;
				}
			}
		}

		internal virtual PictureBox pboxOpenORT_Wkshare
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pboxOpenORT_Wkshare;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pboxOpenORT_Wkshare_Click);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.pboxOpenORT_Wkshare_MouseLeave);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.pboxOpenORT_Wkshare_MouseHover);
				if (this._pboxOpenORT_Wkshare != null)
				{
					this._pboxOpenORT_Wkshare.Click -= eventHandler;
					this._pboxOpenORT_Wkshare.MouseLeave -= eventHandler1;
					this._pboxOpenORT_Wkshare.MouseHover -= eventHandler2;
				}
				this._pboxOpenORT_Wkshare = value;
				if (this._pboxOpenORT_Wkshare != null)
				{
					this._pboxOpenORT_Wkshare.Click += eventHandler;
					this._pboxOpenORT_Wkshare.MouseLeave += eventHandler1;
					this._pboxOpenORT_Wkshare.MouseHover += eventHandler2;
				}
			}
		}

		internal virtual PictureBox pboxOpenRunSheet
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pboxOpenRunSheet;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pboxOpenRunSheet_Click);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.pboxOpenRunSheet_MouseLeave);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.pboxOpenRunSheet_MouseHover);
				WindowsApplication1.Form1 form13 = this;
				EventHandler eventHandler3 = new EventHandler(form13.pboxAbstr_SOP_Click);
				if (this._pboxOpenRunSheet != null)
				{
					this._pboxOpenRunSheet.Click -= eventHandler;
					this._pboxOpenRunSheet.MouseLeave -= eventHandler1;
					this._pboxOpenRunSheet.MouseHover -= eventHandler2;
					this._pboxOpenRunSheet.Click -= eventHandler3;
				}
				this._pboxOpenRunSheet = value;
				if (this._pboxOpenRunSheet != null)
				{
					this._pboxOpenRunSheet.Click += eventHandler;
					this._pboxOpenRunSheet.MouseLeave += eventHandler1;
					this._pboxOpenRunSheet.MouseHover += eventHandler2;
					this._pboxOpenRunSheet.Click += eventHandler3;
				}
			}
		}

		internal virtual PictureBox pboxOpenTitleCustSpecs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pboxOpenTitleCustSpecs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pboxOpenTitleProdSpecs_Click);
				WindowsApplication1.Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.pboxOpenTitleCustSpecs_MouseLeave);
				WindowsApplication1.Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.pboxOpenTitleCustSpecs_MouseHover);
				if (this._pboxOpenTitleCustSpecs != null)
				{
					this._pboxOpenTitleCustSpecs.Click -= eventHandler;
					this._pboxOpenTitleCustSpecs.MouseLeave -= eventHandler1;
					this._pboxOpenTitleCustSpecs.MouseHover -= eventHandler2;
				}
				this._pboxOpenTitleCustSpecs = value;
				if (this._pboxOpenTitleCustSpecs != null)
				{
					this._pboxOpenTitleCustSpecs.Click += eventHandler;
					this._pboxOpenTitleCustSpecs.MouseLeave += eventHandler1;
					this._pboxOpenTitleCustSpecs.MouseHover += eventHandler2;
				}
			}
		}

		internal virtual PictureBox pbxCopy1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbxCopy1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(form1.pboxCopy1_MouseClick);
				if (this._pbxCopy1 != null)
				{
					this._pbxCopy1.MouseClick -= mouseEventHandler;
				}
				this._pbxCopy1 = value;
				if (this._pbxCopy1 != null)
				{
					this._pbxCopy1.MouseClick += mouseEventHandler;
				}
			}
		}

		internal virtual PictureBox pbxCopy2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbxCopy2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(form1.pbxCopy2_Mouseclick);
				if (this._pbxCopy2 != null)
				{
					this._pbxCopy2.MouseClick -= mouseEventHandler;
				}
				this._pbxCopy2 = value;
				if (this._pbxCopy2 != null)
				{
					this._pbxCopy2.MouseClick += mouseEventHandler;
				}
			}
		}

		internal virtual PictureBox pbxCopy3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbxCopy3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(form1.pboxCopy3_MouseClick);
				if (this._pbxCopy3 != null)
				{
					this._pbxCopy3.MouseClick -= mouseEventHandler;
				}
				this._pbxCopy3 = value;
				if (this._pbxCopy3 != null)
				{
					this._pbxCopy3.MouseClick += mouseEventHandler;
				}
			}
		}

		internal virtual PictureBox pbxCopy4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbxCopy4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(form1.pboxCopy4_MouseClick);
				if (this._pbxCopy4 != null)
				{
					this._pbxCopy4.MouseClick -= mouseEventHandler;
				}
				this._pbxCopy4 = value;
				if (this._pbxCopy4 != null)
				{
					this._pbxCopy4.MouseClick += mouseEventHandler;
				}
			}
		}

		internal virtual PictureBox pbxCopy5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbxCopy5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(form1.pboxCopy5_MouseClick);
				if (this._pbxCopy5 != null)
				{
					this._pbxCopy5.MouseClick -= mouseEventHandler;
				}
				this._pbxCopy5 = value;
				if (this._pbxCopy5 != null)
				{
					this._pbxCopy5.MouseClick += mouseEventHandler;
				}
			}
		}

		internal virtual PictureBox pbxExport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pbxExport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				WindowsApplication1.Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.pbxExport_Click);
				if (this._pbxExport != null)
				{
					this._pbxExport.Click -= eventHandler;
				}
				this._pbxExport = value;
				if (this._pbxExport != null)
				{
					this._pbxExport.Click += eventHandler;
				}
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		internal virtual PictureBox PictureBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox3 = value;
			}
		}

		internal virtual PictureBox PictureBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox4 = value;
			}
		}

		internal virtual PictureBox PictureBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox5 = value;
			}
		}

		internal virtual PictureBox PictureBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox6 = value;
			}
		}

		internal virtual PictureBox PictureBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox7 = value;
			}
		}

		internal virtual PictureBox PictureBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox8 = value;
			}
		}

		internal virtual PictureBox PictureBox9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox9 = value;
			}
		}

		internal virtual SplitContainer SplitContainer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SplitContainer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SplitContainer1 = value;
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
				WindowsApplication1.Form1 form1 = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(form1.TabPage1_Click);
				if (this._TabControl1 != null)
				{
					this._TabControl1.MouseClick -= mouseEventHandler;
				}
				this._TabControl1 = value;
				if (this._TabControl1 != null)
				{
					this._TabControl1.MouseClick += mouseEventHandler;
				}
			}
		}

		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel2 = value;
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

		internal virtual TabPage TabPg1Docs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg1Docs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg1Docs = value;
			}
		}

		internal virtual TabPage TabPg2PhBk
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg2PhBk;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg2PhBk = value;
			}
		}

		internal virtual TabPage TabPg3Cal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg3Cal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg3Cal = value;
			}
		}

		internal virtual TabPage TabPg4Clearing
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg4Clearing;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg4Clearing = value;
			}
		}

		internal virtual TabPage TabPg5Req
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg5Req;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg5Req = value;
			}
		}

		internal virtual TabPage TabPg6OtherLogins
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg6OtherLogins;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg6OtherLogins = value;
			}
		}

		internal virtual TabPage TabPg7Taxes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg7Taxes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg7Taxes = value;
			}
		}

		internal virtual TabPage TabPg8UWMan
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPg8UWMan;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPg8UWMan = value;
			}
		}

		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		internal virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		internal virtual TextBox TextBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox4 = value;
			}
		}

		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		internal virtual ToolTip ToolTip2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip2 = value;
			}
		}

		internal virtual TextBox txt_AttyNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_AttyNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_AttyNotes = value;
			}
		}

		internal virtual TextBox txt_DeedNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_DeedNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_DeedNotes = value;
			}
		}

		internal virtual TextBox txt_foreclosure_notes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_foreclosure_notes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_foreclosure_notes = value;
			}
		}

		internal virtual TextBox txt_homestead_notes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_homestead_notes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_homestead_notes = value;
			}
		}

		internal virtual TextBox txt_login_asrP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_asrP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_asrP = value;
			}
		}

		internal virtual TextBox txt_login_asrU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_asrU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_asrU = value;
			}
		}

		internal virtual TextBox txt_login_courtP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_courtP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_courtP = value;
			}
		}

		internal virtual TextBox txt_login_courtU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_courtU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_courtU = value;
			}
		}

		internal virtual TextBox txt_login_landP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_landP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_landP = value;
			}
		}

		internal virtual TextBox txt_login_landU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_landU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_landU = value;
			}
		}

		internal virtual TextBox txt_login_muniP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_muniP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_muniP = value;
			}
		}

		internal virtual TextBox txt_login_muniU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_muniU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_muniU = value;
			}
		}

		internal virtual TextBox txt_login_otherP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_otherP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_otherP = value;
			}
		}

		internal virtual TextBox txt_login_otherU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_otherU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_otherU = value;
			}
		}

		internal virtual TextBox txt_login_probateP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_probateP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_probateP = value;
			}
		}

		internal virtual TextBox txt_login_probateU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_probateU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_probateU = value;
			}
		}

		internal virtual TextBox txt_login_prothonP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_prothonP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_prothonP = value;
			}
		}

		internal virtual TextBox txt_login_prothonU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_prothonU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_prothonU = value;
			}
		}

		internal virtual TextBox txt_login_tax1P
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_tax1P;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_tax1P = value;
			}
		}

		internal virtual TextBox txt_login_tax1U
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_tax1U;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_tax1U = value;
			}
		}

		internal virtual TextBox txt_login_tax2P
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_tax2P;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_tax2P = value;
			}
		}

		internal virtual TextBox txt_login_tax2U
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_login_tax2U;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_login_tax2U = value;
			}
		}

		internal virtual TextBox txt_myfl_P
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_myfl_P;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_myfl_P = value;
			}
		}

		internal virtual TextBox txt_myfl_U
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_myfl_U;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_myfl_U = value;
			}
		}

		internal virtual TextBox txt_PolicyNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_PolicyNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_PolicyNotes = value;
			}
		}

		internal virtual TextBox txt_ProbateInfo
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ProbateInfo;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_ProbateInfo = value;
			}
		}

		internal virtual TextBox txt_StatsCounties
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_StatsCounties;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_StatsCounties = value;
			}
		}

		internal virtual TextBox txt_StatsTaxOffices
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_StatsTaxOffices;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_StatsTaxOffices = value;
			}
		}

		internal virtual TextBox txtComments
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtComments;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtComments = value;
			}
		}

		internal virtual TextBox txtSOL_notes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtSOL_notes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtSOL_notes = value;
			}
		}

		internal virtual TextBox txtTaxOffice1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTaxOffice1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTaxOffice1 = value;
			}
		}

		internal virtual TextBox txtTaxOffice2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTaxOffice2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTaxOffice2 = value;
			}
		}

		internal virtual TextBox txtTaxOffice3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTaxOffice3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTaxOffice3 = value;
			}
		}

		internal virtual TextBox txtTaxOffice4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTaxOffice4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTaxOffice4 = value;
			}
		}

		internal virtual TextBox txtTaxOffice5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTaxOffice5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTaxOffice5 = value;
			}
		}

		internal virtual WebBrowser WebBrowser1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WebBrowser1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WebBrowser1 = value;
			}
		}

		internal virtual WebBrowser WebBrowser2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WebBrowser2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WebBrowser2 = value;
			}
		}

		internal virtual WebBrowser WebBrowser3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WebBrowser3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WebBrowser3 = value;
			}
		}

		private frm_Edit EditForm;
		public Form1()
		{
			WindowsApplication1.Form1 form1 = this;
			base.Load += new EventHandler(form1.Form1_Load);
			this.st_cty = new DataTable();
			this.mywebs = new string[31];
			this.taxoffc_count = 1;
			this.TxOffcOutput = new string[6];
			this.picbox = new object[6];
			this.i = 0;
			this.sb = new StringBuilder();
			this.sb2 = new StringBuilder();
			this.c = 0;
			this.c2 = 0;
			this.dt = new DataTable();
			this.dt2 = new DataTable();
			this.da = new OleDbDataAdapter();
			this.da2 = new OleDbDataAdapter();
			this.cmdBuilder = new OleDbCommandBuilder();
			this.cmdBuilder2 = new OleDbCommandBuilder();
			this.cmd = new OleDbCommand();
			this.cmd2 = new OleDbCommand();
			this.Import_File = "T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ORB_DATABASE.xls";
			this.sheetNm1 = "orb";
			this.sheetNm2 = "taxes";
			this.sheetNm3 = "state_counsels";
			this.sheetNm4 = "statutes";
			this.sheetNm5 = "other_logins";
			this.sheetNm7 = "misc";
			this.InitializeComponent();
		}

		private void Button_EditORB_Click(object sender, EventArgs e)
		{
			this.SplitContainer1.SendToBack();
			this.SplitContainer1.Panel1Collapsed = true;
			this.SplitContainer1.Height = 480;
			this.Panel2.Visible = true;
			this.Panel2.BringToFront();
			this.TabControl1.Visible = false;
			EditForm.cboxState_EditORB.Text = this.ComboBoxState.Text;
			EditForm.cboxCounty_EditORB.Text = this.ComboBoxCounty.Text;
			EditForm.cboxTaxAuth_EditORB.Text = this.ComboBoxTaxAuth.Text;
			EditForm.cboxTaxAuthType_EditORB.Text = this.ComboBoxTaxType.Text;
			EditForm.Button_SEARCH.PerformClick();
		}

		private void Button_PolicyWarehouse_Click(object sender, EventArgs e)
		{
			(new Form4_pw()).Show();
		}

		private void Button_RateCalc_Click(object sender, EventArgs e)
		{
			//(new UniversalRateCalc.Form1()).Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			(new WindowsApplication1.Form3()).Show();
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ButtonGetDoc_Click(object sender, EventArgs e)
		{
			string[] str = new string[] { "T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\docs\\", this.cboxDocState.Text.ToString(), "-", this.cboxDocType.Text.ToString(), ".doc" };
			string str1 = string.Concat(str);
			if (!File.Exists(str1))
			{
				this.lbl_NotFound.Visible = true;
				this.linkUS_Legal_Forms.Visible = true;
			}
			else
			{
				Process.Start(str1);
				this.lbl_NotFound.Visible = false;
				this.linkUS_Legal_Forms.Visible = false;
			}
		}

		private void ButtonGetLinks_Click(object sender, EventArgs e)
		{
			string text = this.ComboBoxState.Text;
			string str = this.ComboBoxCounty.Text;
			string text1 = this.ComboBoxTaxAuth.Text;
			string str1 = this.ComboBoxTaxType.Text;
			this.orb_obj = new Resource_Lookup(text, str, text1);
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "\"", false) != 0)
			{
				while (this.c <= checked(this.dt.Rows.Count - 1))
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["st"].ToString(), text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["county"].ToString(), this.ComboBoxCounty.Text, false) == 0)
					{
						this.txt_login_landU.Text = this.orb_obj.county_user;
						this.txt_login_landP.Text = this.orb_obj.county_pwd;
						this.txt_login_courtU.Text = this.orb_obj.court_user;
						this.txt_login_courtP.Text = this.orb_obj.court_pwd;
						this.txt_login_tax1U.Text = this.orb_obj.tax_user;
						this.txt_login_tax1P.Text = this.orb_obj.tax_pwd;
						this.txt_login_prothonU.Text = this.orb_obj.pro_user;
						this.txt_login_prothonP.Text = this.orb_obj.pro_pwd;
						this.txt_login_tax2U.Text = this.orb_obj.tax2_user;
						this.txt_login_tax2P.Text = this.orb_obj.tax2_pwd;
						this.txt_login_muniU.Text = this.orb_obj.muniCourt_user;
						this.txt_login_muniP.Text = this.orb_obj.muniCourt_pwd;
						this.txt_login_probateU.Text = this.orb_obj.probate_user;
						this.txt_login_probateP.Text = this.orb_obj.probate_pwd;
						this.txt_login_asrU.Text = this.orb_obj.assessor_user;
						this.txt_login_asrP.Text = this.orb_obj.assessor_pwd;
						this.txt_login_otherU.Text = this.orb_obj.other_user;
						this.txt_login_otherP.Text = this.orb_obj.other_pwd;
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.county_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.county_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.court_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.court_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.tax_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.tax_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.pro_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.pro_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.tax2_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.tax2_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.probate_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.probate_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.muniCourt_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.muniCourt_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.assessor_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.assessor_pwd, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.other_user, "", false) != 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.other_pwd, "", false) != 0)
						{
							this.Label_user.Visible = true;
							this.Label_pwd.Visible = true;
						}
						this.LabelCopy_source.Text = this.orb_obj.copy_source;
						this.LabelIndex_source.Text = this.orb_obj.index_source;
						this.LabelImage_date.Text = this.orb_obj.img_date;
						this.LabelIndex_date.Text = this.orb_obj.index_date;
						this.LabelCopyPmtType.Text = this.orb_obj.copy_pmt_method;
						this.lbl_copyFeeAmt.Text = this.orb_obj.copyFeeAmt;
						this.lbl_courtIndexDate.Text = this.orb_obj.courtIndexDate;
						this.lbl_courtImgDate.Text = this.orb_obj.courtImageDate;
						this.LabelSubNeeded.Text = this.orb_obj.sub_need;
						this.lbl_WeSubscribe.Text = this.orb_obj.subscribed;
						this.lbl_SubTerm.Text = this.orb_obj.subscr_term;
						this.lbl_IndexPmtMethod.Text = this.orb_obj.index_pmt_method;
						this.lbl_IndexFeeAmt.Text = this.orb_obj.subscrFeeAmt;
						this.LabelUseTap.Text = this.orb_obj.tap;
						this.LabelUseRV.Text = this.orb_obj.rv;
						this.LabelUseDtree.Text = this.orb_obj.dtree_desk;
						this.LabelUseIns.Text = this.orb_obj.ins;
						this.LabelUseProps.Text = this.orb_obj.props;
						this.LabelUseCopy.Text = this.orb_obj.doc_retrieval;
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.land_url, "", false) == 0)
						{
							this.LinkLabelCounty.Text = "search internet";
							this.LinkLabelCounty.Enabled = false;
							this.LinkLabelCounty.Visible = true;
							this.LabelCountyURL.Visible = true;
							this.txt_login_landU.Visible = false;
							this.txt_login_landP.Visible = false;
						}
						else if (!(this.orb_obj.land_url.StartsWith("http") | this.orb_obj.land_url.StartsWith("www")))
						{
							this.LinkLabelCounty.Text = this.orb_obj.land_url;
							this.LinkLabelCounty.Visible = true;
							this.LabelCountyURL.Visible = true;
							this.txt_login_landU.Visible = false;
							this.txt_login_landP.Visible = false;
						}
						else
						{
							this.LinkLabelCounty.Text = "Goto Land Index";
							this.LinkLabelCounty.Enabled = true;
							this.LinkLabelCounty.Visible = true;
							this.LabelCountyURL.Visible = true;
							this.txt_login_landU.Visible = true;
							this.txt_login_landP.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxState.Text, "FL", false) != 0)
						{
							this.LinkLabel_MyFlCountiesURL.Visible = false;
							this.lbl_MyFlaCounties.Visible = false;
							this.txt_myfl_U.Visible = false;
							this.txt_myfl_P.Visible = false;
						}
						else
						{
							this.Label_user.Visible = true;
							this.Label_pwd.Visible = true;
							this.LinkLabel_MyFlCountiesURL.Text = "Visit Web";
							this.LinkLabel_MyFlCountiesURL.Enabled = true;
							this.LinkLabel_MyFlCountiesURL.Visible = true;
							this.lbl_MyFlaCounties.Visible = true;
							this.txt_myfl_U.Visible = true;
							this.txt_myfl_P.Visible = true;
							this.txt_myfl_U.Text = "cporto";
							this.txt_myfl_P.Text = "TFOadAAb";
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.court_url, "", false) == 0)
						{
							this.LinkLabelCourt.Text = "search internet";
							this.LinkLabelCourt.Enabled = false;
							this.LinkLabelCourt.Visible = true;
							this.LabelCourt.Visible = true;
							this.txt_login_courtU.Visible = false;
							this.txt_login_courtP.Visible = false;
						}
						else if (!(this.orb_obj.court_url.StartsWith("http") | this.orb_obj.court_url.StartsWith("www")))
						{
							this.LinkLabelCourt.Text = this.orb_obj.court_url;
							this.LinkLabelCourt.Visible = true;
							this.LabelCourt.Visible = true;
							this.txt_login_courtU.Visible = false;
							this.txt_login_courtP.Visible = false;
						}
						else
						{
							this.LinkLabelCourt.Text = "Goto Court Index";
							this.LinkLabelCourt.Enabled = true;
							this.LinkLabelCourt.Visible = true;
							this.LabelCourt.Visible = true;
							this.txt_login_courtU.Visible = true;
							this.txt_login_courtP.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.tax_url, "", false) == 0)
						{
							this.LinkLabelTax.Text = "search internet";
							this.LinkLabelTax.Enabled = false;
							this.LinkLabelTax.Visible = true;
							this.LabelCountyTax.Visible = true;
							this.txt_login_tax1U.Visible = false;
							this.txt_login_tax1P.Visible = false;
						}
						else if (!(this.orb_obj.tax_url.StartsWith("http") | this.orb_obj.tax_url.StartsWith("www")))
						{
							this.LinkLabelTax.Text = this.orb_obj.tax_url;
							this.LinkLabelTax.Visible = true;
							this.LabelCountyTax.Visible = true;
							this.txt_login_tax1U.Visible = false;
							this.txt_login_tax1P.Visible = false;
						}
						else
						{
							this.LinkLabelTax.Text = "Goto Tax Web";
							this.LinkLabelTax.Enabled = true;
							this.LinkLabelTax.Visible = true;
							this.LabelCountyTax.Visible = true;
							this.txt_login_tax1U.Visible = true;
							this.txt_login_tax1P.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.prothon_url, "", false) == 0)
						{
							this.txt_login_prothonU.Visible = false;
							this.txt_login_prothonP.Visible = false;
						}
						else if (this.orb_obj.prothon_url.StartsWith("http") | this.orb_obj.prothon_url.StartsWith("www"))
						{
							this.LinkLabelProthon.Text = "Goto Prothon";
							this.LinkLabelProthon.Visible = true;
							this.LabelProthon.Visible = true;
							this.LinkLabelProthon.Enabled = true;
							this.txt_login_prothonU.Visible = true;
							this.txt_login_prothonP.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.assessor_url, "", false) == 0)
						{
							this.LinkLabelAssessor.Text = "search internet";
							this.LinkLabelAssessor.Enabled = false;
							this.LinkLabelAssessor.Visible = true;
							this.LabelAssessor.Visible = true;
							this.txt_login_asrU.Visible = false;
							this.txt_login_asrP.Visible = false;
						}
						else if (!(this.orb_obj.assessor_url.StartsWith("http") | this.orb_obj.assessor_url.StartsWith("www")))
						{
							this.LinkLabelAssessor.Text = this.orb_obj.assessor_url;
							this.LinkLabelAssessor.Visible = true;
							this.LabelAssessor.Visible = true;
							this.txt_login_asrU.Visible = false;
							this.txt_login_asrP.Visible = false;
						}
						else
						{
							this.LinkLabelAssessor.Text = "Goto Assessor";
							this.LinkLabelAssessor.Enabled = true;
							this.LinkLabelAssessor.Visible = true;
							this.LabelAssessor.Visible = true;
							this.txt_login_asrU.Visible = true;
							this.txt_login_asrP.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.map_url, "", false) != 0)
						{
							if (this.orb_obj.map_url.StartsWith("http") | this.orb_obj.map_url.StartsWith("www"))
							{
								this.LinkLabelMaps.Text = "Goto Maps";
								this.LinkLabelMaps.Enabled = true;
								this.LinkLabelMaps.Visible = true;
								this.LabelMapsGIS.Visible = true;
							}
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.probate_url, "", false) == 0)
						{
							this.txt_login_probateU.Visible = false;
							this.txt_login_probateP.Visible = false;
						}
						else if (this.orb_obj.probate_url.StartsWith("http") | this.orb_obj.probate_url.StartsWith("www"))
						{
							this.LinkLabelProbate.Text = "Probate Web";
							this.LinkLabelProbate.Enabled = true;
							this.LinkLabelProbate.Visible = true;
							this.LabelProbate.Visible = true;
							this.txt_login_probateU.Visible = true;
							this.txt_login_probateP.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.ucc_url, "", false) != 0)
						{
							if (this.orb_obj.ucc_url.StartsWith("http") | this.orb_obj.ucc_url.StartsWith("www"))
							{
								this.LinkLabel_UCC.Text = "UCC Search";
								this.LinkLabel_UCC.Enabled = true;
								this.LinkLabel_UCC.Visible = true;
								this.LabelUCC.Visible = true;
							}
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.county_homepage, "", false) == 0)
						{
							this.LinkLabelCoHome.Text = "search internet";
							this.LinkLabelCoHome.Enabled = false;
							this.LinkLabelCoHome.Visible = true;
							this.LabelCountyHome.Visible = true;
						}
						else if (!(this.orb_obj.county_homepage.StartsWith("http") | this.orb_obj.county_homepage.StartsWith("www")))
						{
							this.LinkLabelCoHome.Text = this.orb_obj.county_homepage;
							this.LinkLabelCoHome.Visible = true;
							this.LabelCountyHome.Visible = true;
						}
						else
						{
							this.LinkLabelCoHome.Text = "Homepage";
							this.LinkLabelCoHome.Enabled = true;
							this.LinkLabelCoHome.Visible = true;
							this.LabelCountyHome.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.foreclosure_url, "", false) != 0)
						{
							if (this.orb_obj.foreclosure_url.StartsWith("http") | this.orb_obj.foreclosure_url.StartsWith("www"))
							{
								this.LinkLabelForeclosure.Text = "Foreclosures";
								this.LinkLabelForeclosure.Enabled = true;
								this.LinkLabelForeclosure.Visible = true;
								this.LabelForeclosures.Visible = true;
							}
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.plat_url, "", false) != 0)
						{
							if (this.orb_obj.plat_url.StartsWith("http") | this.orb_obj.plat_url.StartsWith("www"))
							{
								this.LinkLabelPlats.Text = "Search Plats";
								this.LinkLabelPlats.Enabled = true;
								this.LinkLabelPlats.Visible = true;
								this.LabelMapsGIS.Visible = true;
							}
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.muniCourt_url, "", false) == 0)
						{
							this.LinkLabelMuniCourt.Text = "search internet";
							this.LinkLabelMuniCourt.Enabled = false;
							this.LinkLabelMuniCourt.Visible = true;
							this.LabelMuniCourt.Visible = true;
							this.txt_login_muniU.Visible = false;
							this.txt_login_muniP.Visible = false;
						}
						else if (!(this.orb_obj.muniCourt_url.StartsWith("http") | this.orb_obj.muniCourt_url.StartsWith("www")))
						{
							this.LinkLabelMuniCourt.Text = this.orb_obj.muniCourt_url;
							this.LinkLabelMuniCourt.Visible = true;
							this.LabelMuniCourt.Visible = true;
							this.txt_login_muniU.Visible = false;
							this.txt_login_muniP.Visible = false;
						}
						else
						{
							this.LinkLabelMuniCourt.Text = "Goto Court";
							this.LinkLabelMuniCourt.Enabled = true;
							this.LinkLabelMuniCourt.Visible = true;
							this.LabelMuniCourt.Visible = true;
							this.txt_login_muniU.Visible = true;
							this.txt_login_muniP.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.other_url, "", false) == 0)
						{
							this.txt_login_otherU.Visible = false;
							this.txt_login_otherP.Visible = false;
						}
						else if (this.orb_obj.other_url.StartsWith("http") | this.orb_obj.other_url.StartsWith("www"))
						{
							this.LinkLabel_OtherURL.Text = "Goto Web";
							this.LinkLabel_OtherURL.Enabled = true;
							this.LinkLabel_OtherURL.Visible = true;
							this.LabelOtherURL.Visible = true;
							this.txt_login_otherU.Visible = true;
							this.txt_login_otherP.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.tax2_url, "", false) == 0)
						{
							this.txt_login_tax2U.Visible = false;
							this.txt_login_tax2P.Visible = false;
						}
						else if (this.orb_obj.tax2_url.StartsWith("http") | this.orb_obj.tax2_url.StartsWith("www"))
						{
							this.LinkLabelOtherTax.Text = "Goto Taxes";
							this.LinkLabelOtherTax.Enabled = true;
							this.LinkLabelOtherTax.Visible = true;
							this.LabelOtherTax.Visible = true;
							this.txt_login_tax2U.Visible = true;
							this.txt_login_tax2P.Visible = true;
						}
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.sheriff_url, "", false) != 0)
						{
							if (this.orb_obj.sheriff_url.StartsWith("http") | this.orb_obj.sheriff_url.StartsWith("www"))
							{
								this.LinkLabelSheriff.Text = "SHERIFF";
								this.LinkLabelSheriff.Enabled = true;
								this.LinkLabelSheriff.Visible = true;
								this.LabelSheriff.Visible = true;
							}
						}
						this.txtComments.Text = this.orb_obj.comments;
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.comments, "", false) != 0)
						{
							this.txtComments.Visible = true;
						}
						this.c = checked(this.dt.Rows.Count + this.c);
					}
					this.c = checked(this.c + 1);
				}
			}
			this.dt2.Clear();
			this.cmd2.CommandType = CommandType.TableDirect;
			this.dsn2 = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd2.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
			this.cmd2.Connection = new OleDbConnection(this.dsn2);
			this.da2.SelectCommand = this.cmd2;
			this.cmdBuilder2.DataAdapter = this.da2;
			this.da2.Fill(this.dt2);
			this.da2.Dispose();
			string[] strArrays = new string[6];
			string[] strArrays1 = new string[6];
			bool[] flagArray = new bool[6];
			this.c2 = 0;
			while (this.c2 < 6)
			{
				strArrays[this.c2] = "";
				strArrays1[this.c2] = "";
				flagArray[this.c2] = false;
				this.TxOffcOutput[this.c2] = "";
				this.c2 = checked(this.c2 + 1);
			}
			this.taxoffc_count = 1;
			this.c2 = 0;
			while (this.c2 <= checked(this.dt2.Rows.Count - 1))
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["st"].ToString(), this.ComboBoxState.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["county"].ToString(), this.ComboBoxCounty.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tax_auth"].ToString(), "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["st"].ToString(), this.ComboBoxState.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["county"].ToString(), this.ComboBoxCounty.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tax_auth"].ToString(), null, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["st"].ToString(), this.ComboBoxState.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["county"].ToString(), this.ComboBoxCounty.Text, false) == 0 & (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tax_auth"].ToString(), this.ComboBoxTaxAuth.Text, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTaxAuth.Text, "choose", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTaxAuth.Text, "RESEARCH NEEDED", false) == 0) | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["st"].ToString(), this.ComboBoxState.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["county"].ToString(), this.ComboBoxCounty.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tax_auth"].ToString(), this.ComboBoxTaxAuth.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tax_auth_type"].ToString(), this.ComboBoxTaxType.Text, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["st"].ToString(), this.ComboBoxState.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["county"].ToString(), this.ComboBoxCounty.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tax_auth"].ToString(), this.ComboBoxTaxAuth.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tax_auth_type"].ToString(), this.ComboBoxTaxType.Text, false) == 0)
				{
					strArrays[this.taxoffc_count] = this.dt2.Rows[this.c2]["locTx_url"].ToString();
					strArrays1[this.taxoffc_count] = string.Concat("TaxType: ", this.dt2.Rows[this.c2]["tax_auth_type"].ToString(), " TaxingAuth: ", this.dt2.Rows[this.c2]["tax_auth"].ToString());
					string[] txOffcOutput = this.TxOffcOutput;
					int taxoffcCount = this.taxoffc_count;
					string[] str2 = new string[] { "Phone: ", this.dt2.Rows[this.c2]["phone"].ToString(), "  Fax: ", this.dt2.Rows[this.c2]["fax"].ToString(), "\r\nPayee: ", this.dt2.Rows[this.c2]["payee"].ToString(), "\r\n", this.dt2.Rows[this.c2]["street1"].ToString(), ", ", this.dt2.Rows[this.c2]["street2"].ToString(), "\r\n", this.dt2.Rows[this.c2]["city"].ToString(), ", ", this.dt2.Rows[this.c2]["tx_st"].ToString(), "  ", this.dt2.Rows[this.c2]["zip"].ToString(), "\r\nHours: ", this.dt2.Rows[this.c2]["hours"].ToString(), "\r\nCert Needed? ", this.dt2.Rows[this.c2]["cert_req"].ToString(), "    Fee: ", this.dt2.Rows[this.c2]["cert_fee"].ToString(), "\r\nBill Cycle: ", this.dt2.Rows[this.c2]["cycle"].ToString(), "   DueDates: ", this.dt2.Rows[this.c2]["due_dates"].ToString(), "\r\nNOTES: ", this.dt2.Rows[this.c2]["notes"].ToString() };
					txOffcOutput[taxoffcCount] = string.Concat(str2);
					if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["street1"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["locTx_url"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["street2"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["city"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["tx_st"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["zip"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["phone"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["fax"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["hours"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["cert_req"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["cert_fee"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["cycle"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["due_dates"].ToString(), "", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt2.Rows[this.c2]["notes"].ToString(), "", false) == 0))
					{
						flagArray[this.taxoffc_count] = true;
					}
					else
					{
						flagArray[this.taxoffc_count] = false;
					}
					if (this.taxoffc_count != 5)
					{
						this.taxoffc_count = checked(this.taxoffc_count + 1);
					}
				}
				this.c2 = checked(this.c2 + 1);
			}
			this.ComboBoxTaxAuth.Visible = true;
			this.txtTaxOffice1.Text = this.TxOffcOutput[1];
			this.txtTaxOffice2.Text = this.TxOffcOutput[2];
			this.txtTaxOffice3.Text = this.TxOffcOutput[3];
			this.txtTaxOffice4.Text = this.TxOffcOutput[4];
			this.txtTaxOffice5.Text = this.TxOffcOutput[5];
			this.lblTxAuth1.Text = strArrays1[1];
			this.lblTxAuth2.Text = strArrays1[2];
			this.lblTxAuth3.Text = strArrays1[3];
			this.lblTxAuth4.Text = strArrays1[4];
			this.lblTxAuth5.Text = strArrays1[5];
			if (flagArray[1])
			{
				this.txtTaxOffice1.Visible = true;
				this.lblTxAuth1.Visible = true;
				this.linkLocTax1.Visible = true;
				this.pbxCopy1.Visible = true;
			}
			if (flagArray[2])
			{
				this.txtTaxOffice2.Visible = true;
				this.lblTxAuth2.Visible = true;
				this.linkLocTax2.Visible = true;
				this.pbxCopy2.Visible = true;
			}
			if (flagArray[3])
			{
				this.txtTaxOffice3.Visible = true;
				this.lblTxAuth3.Visible = true;
				this.linkLocTax3.Visible = true;
				this.pbxCopy3.Visible = true;
			}
			if (flagArray[4])
			{
				this.txtTaxOffice4.Visible = true;
				this.lblTxAuth4.Visible = true;
				this.linkLocTax4.Visible = true;
				this.pbxCopy4.Visible = true;
			}
			if (flagArray[5])
			{
				this.txtTaxOffice5.Visible = true;
				this.lblTxAuth5.Visible = true;
				this.linkLocTax5.Visible = true;
				this.pbxCopy5.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArrays[1], "", false) == 0)
			{
				this.linkLocTax1.Text = "none";
				this.linkLocTax1.Enabled = false;
			}
			else if (!(strArrays[1].StartsWith("http") | strArrays[1].StartsWith("www")))
			{
				this.linkLocTax1.Text = strArrays[1];
			}
			else
			{
				this.linkLocTax1.Text = "Visit Web";
				this.mywebs[11] = strArrays[1];
				this.linkLocTax1.Enabled = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArrays[2], "", false) == 0)
			{
				this.linkLocTax2.Text = "";
				this.linkLocTax2.Enabled = false;
			}
			else if (!(strArrays[2].StartsWith("http") | strArrays[2].StartsWith("www")))
			{
				this.linkLocTax2.Text = strArrays[2];
			}
			else
			{
				this.linkLocTax2.Text = "Visit Web";
				this.mywebs[12] = strArrays[2];
				this.linkLocTax2.Enabled = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArrays[3], "", false) == 0)
			{
				this.linkLocTax3.Text = "";
				this.linkLocTax3.Enabled = false;
			}
			else if (!(strArrays[3].StartsWith("http") | strArrays[3].StartsWith("www")))
			{
				this.linkLocTax3.Text = strArrays[3];
			}
			else
			{
				this.linkLocTax3.Text = "Visit Web";
				this.mywebs[13] = strArrays[3];
				this.linkLocTax3.Enabled = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArrays[4], "", false) == 0)
			{
				this.linkLocTax4.Text = "";
				this.linkLocTax4.Enabled = false;
			}
			else if (!(strArrays[4].StartsWith("http") | strArrays[4].StartsWith("www")))
			{
				this.linkLocTax4.Text = strArrays[4];
			}
			else
			{
				this.linkLocTax4.Text = "Visit Web";
				this.mywebs[14] = strArrays[4];
				this.linkLocTax4.Enabled = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArrays[5], "", false) == 0)
			{
				this.linkLocTax5.Text = "";
				this.linkLocTax5.Enabled = false;
			}
			else if (!(strArrays[5].StartsWith("http") | strArrays[5].StartsWith("www")))
			{
				this.linkLocTax5.Text = strArrays[5];
			}
			else
			{
				this.linkLocTax5.Text = "Visit Web";
				this.mywebs[15] = strArrays[5];
				this.linkLocTax5.Enabled = true;
			}
			this.LabelCopy_source.Visible = true;
			this.LabelIndex_source.Visible = true;
			this.LabelImage_date.Visible = true;
			this.LabelIndex_date.Visible = true;
			this.LabelCopyPmtType.Visible = true;
			this.LabelSubNeeded.Visible = true;
			this.lbl_copyFeeAmt.Visible = true;
			this.lbl_IndexFeeAmt.Visible = true;
			this.LabelUseTap.Visible = true;
			this.LabelUseRV.Visible = true;
			this.LabelUseDtree.Visible = true;
			this.orbStats = new Statutes_Lookup(text);
			this.c = 0;
			if (this.orbStats.SOL_MtgRD != null & this.orbStats.SOL_MtgAM != null)
			{
				this.lblSOL_Mtg.Text = string.Concat(this.orbStats.SOL_MtgAM, " Yrs After Maturity, ", this.orbStats.SOL_MtgRD, " Yrs After Record Date");
			}
			else if (this.orbStats.SOL_MtgRD == null & this.orbStats.SOL_MtgAM == null)
			{
				this.lblSOL_Mtg.Text = "limits not known";
			}
			else if (this.orbStats.SOL_MtgAM != null)
			{
				this.lblSOL_Mtg.Text = string.Concat(this.orbStats.SOL_MtgAM, " Yrs After Maturity");
			}
			else if (this.orbStats.SOL_MtgRD != null)
			{
				this.lblSOL_Mtg.Text = string.Concat(this.orbStats.SOL_MtgRD, " Yrs After Record Date");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orbStats.SOL_MtgAM, "no limit", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orbStats.SOL_MtgRD, "no limit", false) == 0)
			{
				this.lblSOL_Mtg.Text = "no statutory limit";
			}
			if (this.orbStats.SOL_HelocRD != null & this.orbStats.SOL_HelocAM != null)
			{
				this.lblSOL_Heloc.Text = string.Concat(this.orbStats.SOL_HelocAM, " Yrs After Maturity, ", this.orbStats.SOL_HelocRD, " Yrs After Record Date");
			}
			else if (this.orbStats.SOL_HelocRD == null & this.orbStats.SOL_HelocAM == null)
			{
				this.lblSOL_Heloc.Text = "limits not known";
			}
			else if (this.orbStats.SOL_HelocAM != null)
			{
				this.lblSOL_Heloc.Text = string.Concat(this.orbStats.SOL_HelocAM, " Yrs After Maturity");
			}
			else if (this.orbStats.SOL_HelocRD != null)
			{
				this.lblSOL_Heloc.Text = string.Concat(this.orbStats.SOL_HelocRD, " Yrs After Record Date");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orbStats.SOL_HelocAM, "no limit", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orbStats.SOL_HelocRD, "no limit", false) == 0)
			{
				this.lblSOL_Heloc.Text = "no statutory limit";
			}
			this.lblSOL_Mech.Text = this.orbStats.SOL_Mech;
			this.lblSOL_Notice.Text = this.orbStats.SOL_Notice;
			this.lblSOL_lispen.Text = this.orbStats.SOL_lispen;
			this.lblSOL_HOA.Text = this.orbStats.SOL_HOA;
			this.lblSOL_Hosp.Text = this.orbStats.SOL_Hosp;
			this.lblSOL_ClaimLien.Text = this.orbStats.SOL_ClaimLien;
			this.lblSOL_Jgmt.Text = this.orbStats.SOL_Jgmt;
			this.lblSOL_Support.Text = this.orbStats.SOL_Support;
			this.lblSOL_StateJgmt.Text = this.orbStats.SOL_StateJgmt;
			this.lblSOL_AftAcq.Text = this.orbStats.SOL_AftAcq;
			this.lblSOL_TERule.Text = this.orbStats.SOL_TERule;
			this.lblSOL_Creditor_Claims.Text = this.orbStats.SOL_Creditor_Claims;
			this.lblSOL_PersTax.Text = this.orbStats.SOL_PersTax;
			this.lblSOL_Tax_RedemPer.Text = this.orbStats.SOL_Tax_RedemPer;
			this.lblSOL_forecl_redem_per.Text = this.orbStats.SOL_Foreclosure_RedemPer;
			this.lblSOL_Spousal.Text = this.orbStats.SOL_Spousal;
			this.txtSOL_notes.Text = this.orbStats.SOL_notes;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Mtg.Text.ToString(), "", false) != 0)
			{
				this.lblSOL_Mtg.Visible = true;
				this.Label_mtg.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Heloc.Text, "", false) != 0)
			{
				this.lblSOL_Heloc.Visible = true;
				this.Label_heloc.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_TERule.Text, "", false) != 0)
			{
				this.lblSOL_TERule.Visible = true;
				this.Label_teRule.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Mech.Text, "", false) != 0)
			{
				this.lblSOL_Mech.Visible = true;
				this.Label_mechLien.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Notice.Text, "", false) != 0)
			{
				this.lblSOL_Notice.Visible = true;
				this.Label_NOC.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_lispen.Text, "", false) != 0)
			{
				this.lblSOL_lispen.Visible = true;
				this.Label_lisPendens.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_HOA.Text, "", false) != 0)
			{
				this.lblSOL_HOA.Visible = true;
				this.Label_HOA.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Hosp.Text, "", false) != 0)
			{
				this.lblSOL_Hosp.Visible = true;
				this.Label_hospLien.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_ClaimLien.Text, "", false) != 0)
			{
				this.lblSOL_ClaimLien.Visible = true;
				this.Label_claimLien.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Jgmt.Text, "", false) != 0)
			{
				this.lblSOL_Jgmt.Visible = true;
				this.Label_jgmt.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Support.Text, "", false) != 0)
			{
				this.lblSOL_Support.Visible = true;
				this.Label_support.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_StateJgmt.Text, "", false) != 0)
			{
				this.lblSOL_StateJgmt.Visible = true;
				this.Label_stateJgmt.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_AftAcq.Text, "", false) != 0)
			{
				this.lblSOL_AftAcq.Visible = true;
				this.Label_aftacq.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Creditor_Claims.Text, "", false) != 0)
			{
				this.lblSOL_Creditor_Claims.Visible = true;
				this.Label_credclaim.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_PersTax.Text, "", false) != 0)
			{
				this.lblSOL_PersTax.Visible = true;
				this.Label_persTax.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Tax_RedemPer.Text, "", false) != 0)
			{
				this.lblSOL_Tax_RedemPer.Visible = true;
				this.Label_taxTakRedem.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_forecl_redem_per.Text, "", false) != 0)
			{
				this.lblSOL_forecl_redem_per.Visible = true;
				this.Label_forclRedem.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSOL_Spousal.Text, "", false) != 0)
			{
				this.lblSOL_Spousal.Visible = true;
				this.Label_spousal.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSOL_notes.Text, "", false) != 0)
			{
				this.txtSOL_notes.Visible = true;
				this.Label_statutecomments.Visible = true;
			}
			this.TableLayoutPanel2.AutoSize = true;
			this.c = checked(this.dt.Rows.Count + this.c);
			this.c = checked(this.c + 1);
			this.orb_misc = new ORB_DLL.Orb.orb_misc(text);
			this.c = 0;
			this.txt_foreclosure_notes.Text = this.orb_misc.Foreclosure_Notes;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txt_foreclosure_notes.Text, "", false) != 0)
			{
				this.txt_foreclosure_notes.Visible = true;
				this.Label_fc.Visible = true;
			}
			this.txt_ProbateInfo.Text = this.orb_misc.Probate_Notes;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txt_ProbateInfo.Text, "", false) != 0)
			{
				this.txt_ProbateInfo.Visible = true;
				this.Label_probate.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_misc.Being_Clause, "Yes", false) != 0)
			{
				this.lblSOL_being_Clause.Visible = false;
			}
			else
			{
				this.lblSOL_being_Clause.Visible = true;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_misc.SecretaryState_url, "", false) != 0)
			{
				if (this.orb_misc.SecretaryState_url.StartsWith("http") | this.orb_misc.SecretaryState_url.StartsWith("www"))
				{
					this.LinkLabel_SecState.Text = "Secretary of State";
					this.LinkLabel_SecState.Enabled = true;
					this.LinkLabel_SecState.Visible = true;
					this.Label_secState.Visible = true;
				}
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_misc.DOI_url, "", false) != 0)
			{
				if (this.orb_misc.DOI_url.StartsWith("http") | this.orb_misc.DOI_url.StartsWith("www"))
				{
					this.LinkLabel_DeptIns.Text = "Dept of Insurance";
					this.LinkLabel_DeptIns.Enabled = true;
					this.LinkLabel_DeptIns.Visible = true;
					this.Label_DOI.Visible = true;
				}
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_misc.State_Code_url, "", false) != 0)
			{
				if (this.orb_misc.State_Code_url.StartsWith("http") | this.orb_misc.State_Code_url.StartsWith("www"))
				{
					this.LinkLabel_State_Code.Text = "State Admin Code";
					this.LinkLabel_State_Code.Enabled = true;
					this.LinkLabel_State_Code.Visible = true;
					this.Label_stCode.Visible = true;
				}
			}
			this.lbl_attyState.Text = this.orb_misc.Attorney_Search;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lbl_attyState.Text, "NO", false) != 0)
			{
				this.lbl_attyState.Text = "Attorney Opinion of Title Required";
				this.lbl_attyState.Visible = true;
			}
			else
			{
				this.lbl_attyState.Visible = false;
			}
			this.lbl_attyClose.Text = string.Concat("Attorney Closer Needed? ", this.orb_misc.Attorney_Close);
			this.txt_AttyNotes.Text = this.orb_misc.Attorney_Notes;
			this.lbl_homestead.Text = string.Concat("Homestead State? ", this.orb_misc.Homestead);
			this.txt_homestead_notes.Text = this.orb_misc.Homestead_Notes;
			this.lbl_deed_prep.Text = string.Concat("Deed Prep: ", this.orb_misc.Deed_Prep);
			this.txt_DeedNotes.Text = this.orb_misc.Deed_Notes;
			this.txt_PolicyNotes.Text = this.orb_misc.Policy_Notes;
			int num = 0;
			StringBuilder stringBuilder = new StringBuilder();
			DataTable dataTable = new DataTable();
			DataTable dataTable1 = new DataTable();
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
			OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder();
			OleDbCommand oleDbCommand = new OleDbCommand();
			OleDbCommand oleDbConnection = new OleDbCommand();
			num = 0;
			oleDbCommand.CommandType = CommandType.TableDirect;
			string str3 = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			oleDbCommand.CommandText = string.Concat("Select * From [", this.sheetNm3, "$]");
			oleDbCommand.Connection = new OleDbConnection(str3);
			oleDbDataAdapter.SelectCommand = oleDbCommand;
			oleDbCommandBuilder.DataAdapter = oleDbDataAdapter;
			oleDbDataAdapter.Fill(dataTable);
			this.DataGridView1.DataSource = dataTable;
			while (num < checked(this.DataGridView1.RowCount - 1))
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[num].Cells[0].Value.ToString(), "", false) == 0)
				{
					this.DataGridView1.Rows.RemoveAt(num);
				}
				else if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[num].Cells[0].Value.ToString(), this.ComboBoxState.SelectedItem, false))
				{
					this.DataGridView1.Rows.RemoveAt(num);
				}
				else
				{
					num = checked(num + 1);
				}
			}
			oleDbDataAdapter.Dispose();
			oleDbConnection.CommandType = CommandType.TableDirect;
			str3 = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			oleDbConnection.CommandText = string.Concat("Select * From [", this.sheetNm5, "$]");
			oleDbConnection.Connection = new OleDbConnection(str3);
			oleDbDataAdapter.SelectCommand = oleDbConnection;
			oleDbCommandBuilder.DataAdapter = oleDbDataAdapter;
			oleDbDataAdapter.Fill(dataTable1);
			oleDbDataAdapter.Dispose();
			this.DataGridView2.DataSource = dataTable1;
		}

		private void ButtonHelp_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\HELP.doc");
		}

		private void ButtonReset_Click(object sender, EventArgs e)
		{
			this.ComboBoxState.ResetText();
			this.ComboBoxCounty.ResetText();
			this.ComboBoxTaxAuth.ResetText();
			this.ComboBoxTaxType.ResetText();
			this.resetVis();
			this.lblDefault_UW_Name.ResetText();
		}

		private void ButtonResetDocs_Click(object sender, EventArgs e)
		{
			this.lbl_NotFound.Visible = false;
			this.linkUS_Legal_Forms.Visible = false;
			this.cboxDocState.ResetText();
			this.cboxDocType.ResetText();
		}

		private void cbox_StatsStates_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.madStat(this.cbox_StatsStates.Text);
			this.cbox_StatsTaxCounties.ResetText();
			this.txt_StatsTaxOffices.ResetText();
			this.lbl_TaxOnlineStats.ResetText();
			this.cbox_StatsTaxCounties.Items.Clear();
			this.i = 0;
			while (this.i < this.st_cty.Rows.Count)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.st_cty.Rows[this.i]["st"].ToString(), this.cbox_StatsStates.Text, false) == 0)
				{
					this.cbox_StatsTaxCounties.Items.Add(this.st_cty.Rows[this.i]["county"].ToString());
				}
				this.i = checked(this.i + 1);
			}
		}

		private void cbox_StatsTaxCounties_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(dataTable);
			this.da.Dispose();
			this.txt_StatsTaxOffices.ResetText();
			long num = (long)0;
			this.i = 0;
			while (this.i < dataTable.Rows.Count)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[this.i]["st"].ToString(), this.cbox_StatsStates.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[this.i]["county"].ToString(), this.cbox_StatsTaxCounties.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[this.i]["payee"].ToString(), "", false) != 0)
				{
					num = checked(num + (long)1);
					TextBox txtStatsTaxOffices = this.txt_StatsTaxOffices;
					string[] text = new string[] { this.txt_StatsTaxOffices.Text, dataTable.Rows[this.i]["st"].ToString(), " - ", dataTable.Rows[this.i]["county"].ToString(), " - ", dataTable.Rows[this.i]["tax_auth"].ToString(), "\r\n" };
					txtStatsTaxOffices.Text = string.Concat(text);
				}
				this.i = checked(this.i + 1);
			}
			this.lbl_TaxOnlineStats.Text = string.Concat("#Tax Offices: ", Conversions.ToString(num));
		}

		private void cbxAddtlLinks_SelectedIndexChanged(object sender, EventArgs e)
		{
			string str = Conversions.ToString(this.cbxAddtlLinks.SelectedItem);
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "PACER", false) == 0)
			{
				Process.Start("https://pacer.login.uscourts.gov/cgi-bin/login.pl?court_id=00idx");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Justia (Courts)", false) == 0)
			{
				Process.Start("http://dockets.justia.com/");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Ernst Publishing", false) == 0)
			{
				Process.Start("www.ernstpublishing.com/subscribers/login.asp");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "USPS.com", false) == 0)
			{
				Process.Start("www.usps.com");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "US Courts Map", false) == 0)
			{
				Process.Start("http://www.uscourts.gov/courtlinks/#other");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Real Quest", false) == 0)
			{
				Process.Start("www.realquest.com");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "NetrOnline", false) == 0)
			{
				Process.Start("http://publicrecords.netronline.com");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "ZipCode Lookup", false) == 0)
			{
				Process.Start("http://www.zipinfo.com/cgi-local/zipsrch.exe?cnty=cnty&zip=48383");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Stewart Title Guaranty", false) == 0)
			{
				Process.Start("http://www.stewart.com");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Stewart VirtUW", false) == 0)
			{
				Process.Start("http://www.vuwriter.com/");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "MERS-Releases", false) == 0)
			{
				Process.Start("https://www.mers-servicerid.org/sis/");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Stewart New York", false) == 0)
			{
				Process.Start("http://www.stewartnewyork.com/");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Ticor NTI Web", false) == 0)
			{
				Process.Start("http://www.ticorntiweb.com/login.aspx");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CPL-Stewart", false) == 0)
			{
				Process.Start("https://www.stewarticl.com/ICL.asp?/default_stg.asp");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CPL-Ticor", false) == 0)
			{
				Process.Start("http://www.ticorntiweb.com/login.aspx");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CPL-Old Republic", false) == 0)
			{
				Process.Start("http://www.oldrepublictitle.com/asp3/icl/xmlicl10.asp");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "FDIC.gov", false) == 0)
			{
				Process.Start("http://www.fdic.gov/");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "IRS.gov", false) == 0)
			{
				Process.Start("www.irs.gov");
			}
		}

		private void ComboBoxCounty_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.dt);
			this.da.Dispose();
			this.ComboBoxTaxAuth.Items.Clear();
			this.ComboBoxTaxAuth.Text = "choose";
			this.ComboBoxTaxType.Items.Clear();
			this.ComboBoxTaxType.Text = "choose";
			short num = 0;
			bool flag = false;
			while (this.i < this.dt.Rows.Count)
			{
				if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxState.SelectedItem, this.dt.Rows[this.i]["st"].ToString(), false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxCounty.SelectedItem, this.dt.Rows[this.i]["county"].ToString(), false))))
				{
					num = 0;
					flag = false;
					while (num < this.ComboBoxTaxAuth.Items.Count)
					{
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxTaxAuth.Items[num].ToString(), this.dt.Rows[this.i]["tax_auth"].ToString(), false) == 0)
						{
							flag = true;
						}
						num = checked((short)(checked(num + 1)));
					}
					if (!flag)
					{
						this.ComboBoxTaxAuth.Items.Add(this.dt.Rows[this.i]["tax_auth"].ToString());
					}
				}
				this.i = checked(this.i + 1);
			}
			this.resetVis();
			this.lbl_NotFound.Visible = false;
			this.linkUS_Legal_Forms.Visible = false;
		}

		private void comboboxState_TextChanged(object sender, EventArgs e)
		{
			this.TopMost = false;
			string text = this.ComboBoxState.Text;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "AK", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "AR", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "CT", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "AZ", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "CA", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "HI", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "ID", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "NM", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "NV", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "OR", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "OK", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "SD", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "TX", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "UT", false) == 0)
			{
				goto Label0;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "WA", false) != 0)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "WY", false) == 0)
				{
					goto Label0;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "AL", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "CO", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "DC", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "DE", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "FL", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "GA", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "IA", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "IL", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "IN", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "KS", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "KY", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "LA", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "MA", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "MD", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "ME", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "MI", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "MN", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "MO", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "MS", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "MT", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "NC", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "ND", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "NE", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "NH", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "NJ", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "NY", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "OH", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "PA", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "RI", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "SC", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "TN", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "VA", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "VT", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "WI", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Stewart";
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "WV", false) == 0)
				{
					this.lblDefault_UW_Name.Text = "Licensed - Old Republic";
				}
			}
			else
			{
				goto Label0;
			}
		Label1:
			if (text.Length >= 2)
			{
				this.ComboBoxCounty.Items.Clear();
				this.ComboBoxCounty.Text = "choose";
				this.ComboBoxTaxAuth.Items.Clear();
				this.ComboBoxTaxAuth.Text = "choose";
				this.ComboBoxTaxType.Items.Clear();
				this.ComboBoxTaxType.Text = "choose";
				this.resetVis();
				this.lbl_NotFound.Visible = false;
				this.linkUS_Legal_Forms.Visible = false;
				for (int i = 0; i < this.st_cty.Rows.Count; i = checked(i + 1))
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.st_cty.Rows[i]["st"].ToString(), text, false) == 0)
					{
						this.ComboBoxCounty.Items.Add(this.st_cty.Rows[i]["county"].ToString());
					}
				}
			}
			return;
		Label0:
			this.lblDefault_UW_Name.Text = "Not Licensed";
			goto Label1;
		}

		private void ComboBoxTaxAuth_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.dt);
			this.da.Dispose();
			this.ComboBoxTaxType.Items.Clear();
			this.ComboBoxTaxType.Text = "choose";
			while (this.i < this.dt.Rows.Count)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.i]["st"].ToString().ToUpper(), this.ComboBoxState.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.i]["county"].ToString().ToUpper(), this.ComboBoxCounty.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.i]["tax_auth"].ToString().ToUpper(), this.ComboBoxTaxAuth.Text, false) == 0)
				{
					this.ComboBoxTaxType.Items.Add(this.dt.Rows[this.i]["tax_auth_type"].ToString().ToUpper());
				}
				this.i = checked(this.i + 1);
			}
			this.resetVis();
		}

		private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 5)
			{
				string str = string.Concat("mailto:", this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
				Process.Start(str);
			}
			else if (e.ColumnIndex == 4)
			{
				string[] strArrays = new string[] { "mailto:[fax:", this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "@", this.DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), "]" };
				Process.Start(string.Concat(strArrays));
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.Label32.Text = string.Concat("Today is ", Strings.FormatDateTime(DateAndTime.Now, DateFormat.LongDate));
			this.EditForm = new frm_Edit();
			this.ButtonReset.PerformClick();
			this.Refresh();
			this.xlLoad1();
			UpdateCheckInfo updateCheckInfo = null;
			if (ApplicationDeployment.IsNetworkDeployed)
			{
				ApplicationDeployment currentDeployment = ApplicationDeployment.CurrentDeployment;
				try
				{
					updateCheckInfo = currentDeployment.CheckForDetailedUpdate();
				}
				catch (DeploymentDownloadException deploymentDownloadException1)
				{
					ProjectData.SetProjectError(deploymentDownloadException1);
					DeploymentDownloadException deploymentDownloadException = deploymentDownloadException1;
					MessageBox.Show(string.Concat("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: ", deploymentDownloadException.Message));
					ProjectData.ClearProjectError();
					return;
				}
				catch (InvalidOperationException invalidOperationException1)
				{
					ProjectData.SetProjectError(invalidOperationException1);
					InvalidOperationException invalidOperationException = invalidOperationException1;
					MessageBox.Show(string.Concat("This application cannot be updated. It is likely not a ClickOnce application. Error: ", invalidOperationException.Message));
					ProjectData.ClearProjectError();
					return;
				}
				if (!updateCheckInfo.UpdateAvailable)
				{
					MessageBox.Show("This is the most current update.");
					return;
				}
				bool flag = true;
				if (updateCheckInfo.IsUpdateRequired)
				{
					MessageBox.Show(string.Concat("This application has detected a mandatory update from your current version to version ", updateCheckInfo.MinimumRequiredVersion.ToString(), ". The application will now install the update and restart."), "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("An update is available.", "Update Available", MessageBoxButtons.OK);
					this.TopMost = false;
				}
				if (flag)
				{
					try
					{
						currentDeployment.Update();
						MessageBox.Show("Update complete. The application will restart.");
						Application.Restart();
					}
					catch (DeploymentDownloadException deploymentDownloadException2)
					{
						ProjectData.SetProjectError(deploymentDownloadException2);
						MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later.");
						ProjectData.ClearProjectError();
						return;
					}
				}
			}
			this.resetVis();
			this.TopMost = false;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WindowsApplication1.Form1));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle whiteSmoke = new DataGridViewCellStyle();
			DataGridViewCellStyle window = new DataGridViewCellStyle();
			DataGridViewCellStyle lavenderBlush = new DataGridViewCellStyle();
			DataGridViewCellStyle thistle = new DataGridViewCellStyle();
			DataGridViewCellStyle font = new DataGridViewCellStyle();
			DataGridViewCellStyle controlText = new DataGridViewCellStyle();
			DataGridViewCellStyle indigo = new DataGridViewCellStyle();

			this.Label32 = new Label();
			this.SplitContainer1 = new SplitContainer();
			this.lbl_attyState = new Label();
			this.PictureBox1 = new PictureBox();
			this.lblDefault_UW_Name = new Label();
			this.Panel1 = new Panel();
			this.ButtonExit = new Button();
			this.Label36 = new Label();
			this.ComboBoxTaxType = new ComboBox();
			this.GroupBox6 = new GroupBox();
			this.cbxAddtlLinks = new ComboBox();
			this.Button_EditORB = new Button();
			this.Button_Search = new Button();
			this.ComboBoxState = new ComboBox();
			this.ComboBoxCounty = new ComboBox();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.Label3 = new Label();
			this.ComboBoxTaxAuth = new ComboBox();
			this.ButtonReset = new Button();
			this.GroupBox10 = new GroupBox();
			this.lbl_SubTerm = new Label();
			this.Label135 = new Label();
			this.lbl_IndexFeeAmt = new Label();
			this.Label19 = new Label();
			this.Label13 = new Label();
			this.lbl_WeSubscribe = new Label();
			this.lbl_IndexPmtMethod = new Label();
			this.Label11 = new Label();
			this.Label128 = new Label();
			this.lbl_Free = new Label();
			this.Label30 = new Label();
			this.LabelSubNeeded = new Label();
			this.GroupBox8 = new GroupBox();
			this.TextBox4 = new TextBox();
			this.ComboBox1 = new ComboBox();
			this.Label40 = new Label();
			this.Button1 = new Button();
			this.TextBox3 = new TextBox();
			this.TextBox2 = new TextBox();
			this.Label41 = new Label();
			this.Label50 = new Label();
			this.Label51 = new Label();
			this.GroupBox7 = new GroupBox();
			this.TableLayoutPanel2 = new TableLayoutPanel();
			this.txt_myfl_P = new TextBox();
			this.LinkLabel_MyFlCountiesURL = new LinkLabel();
			this.txt_myfl_U = new TextBox();
			this.txt_login_tax2P = new TextBox();
			this.lbl_MyFlaCounties = new Label();
			this.Label_DOI = new Label();
			this.txt_login_tax2U = new TextBox();
			this.Label_stCode = new Label();
			this.txt_login_otherP = new TextBox();
			this.txt_login_courtP = new TextBox();
			this.txt_login_otherU = new TextBox();
			this.Label_secState = new Label();
			this.txt_login_asrP = new TextBox();
			this.txt_login_probateP = new TextBox();
			this.txt_login_asrU = new TextBox();
			this.txt_login_courtU = new TextBox();
			this.txt_login_tax1P = new TextBox();
			this.txt_login_muniP = new TextBox();
			this.txt_login_tax1U = new TextBox();
			this.txt_login_probateU = new TextBox();
			this.txt_login_muniU = new TextBox();
			this.txt_login_prothonP = new TextBox();
			this.txt_login_landP = new TextBox();
			this.txt_login_prothonU = new TextBox();
			this.LabelOtherURL = new Label();
			this.txt_login_landU = new TextBox();
			this.LabelCountyURL = new Label();
			this.LinkLabelOtherTax = new LinkLabel();
			this.LinkLabelSheriff = new LinkLabel();
			this.LabelUCC = new Label();
			this.txtComments = new TextBox();
			this.LinkLabelCounty = new LinkLabel();
			this.LabelOtherTax = new Label();
			this.LinkLabelForeclosure = new LinkLabel();
			this.LabelCourt = new Label();
			this.LinkLabelMuniCourt = new LinkLabel();
			this.LabelForeclosures = new Label();
			this.LinkLabelMaps = new LinkLabel();
			this.LabelSheriff = new Label();
			this.LinkLabelAssessor = new LinkLabel();
			this.LinkLabelTax = new LinkLabel();
			this.LabelMapsGIS = new Label();
			this.LinkLabelCoHome = new LinkLabel();
			this.LinkLabelCourt = new LinkLabel();
			this.LabelProthon = new Label();
			this.LabelAssessor = new Label();
			this.LinkLabelProthon = new LinkLabel();
			this.LabelCountyTax = new Label();
			this.LinkLabelProbate = new LinkLabel();
			this.LabelCountyHome = new Label();
			this.LabelMuniCourt = new Label();
			this.LabelProbate = new Label();
			this.Label_user = new Label();
			this.Label_pwd = new Label();
			this.LinkLabelPlats = new LinkLabel();
			this.LinkLabel_OtherURL = new LinkLabel();
			this.LinkLabel_UCC = new LinkLabel();
			this.LinkLabel_SecState = new LinkLabel();
			this.LinkLabel_State_Code = new LinkLabel();
			this.LinkLabel_DeptIns = new LinkLabel();
			this.GroupBox4 = new GroupBox();
			this.LabelUseIns = new Label();
			this.LabelUseProps = new Label();
			this.LabelUseCopy = new Label();
			this.Label20 = new Label();
			this.Label15 = new Label();
			this.Label28 = new Label();
			this.GroupBox3 = new GroupBox();
			this.Label4Tap = new Label();
			this.Label5dtree = new Label();
			this.Label6RV = new Label();
			this.LinkLabel10 = new LinkLabel();
			this.LinkLabel9 = new LinkLabel();
			this.LinkLabel16 = new LinkLabel();
			this.LabelUseTap = new Label();
			this.LabelUseDtree = new Label();
			this.LabelUseRV = new Label();
			this.GroupBox2 = new GroupBox();
			this.lbl_courtImgDate = new Label();
			this.lbl_courtIndexDate = new Label();
			this.Label34 = new Label();
			this.Label35 = new Label();
			this.lbl_copyFeeAmt = new Label();
			this.Label16 = new Label();
			this.Label27 = new Label();
			this.LabelIndex_source = new Label();
			this.LabelCopyPmtType = new Label();
			this.Label26 = new Label();
			this.LabelImage_date = new Label();
			this.LabelIndex_date = new Label();
			this.Label12 = new Label();
			this.Label10 = new Label();
			this.Label29 = new Label();
			this.LabelCopy_source = new Label();
			this.lblOpenRunSheet = new Label();
			this.TabControl1 = new TabControl();
			this.TabPg1Docs = new TabPage();
			this.pbox_Abstr_SOP = new PictureBox();
			this.lbl_doc_AbstractingSOPs = new Label();
			this.Button_PolicyWarehouse = new Button();
			this.pboxOpenEtitleWkshare = new PictureBox();
			this.lblOpenEtitleWkshare = new Label();
			this.pboxOpenORT_Wkshare = new PictureBox();
			this.lblOpenORT_Wkshare = new Label();
			this.Button_ClosingDept = new Button();
			this.Button_TitleDept = new Button();
			this.ButtonHelp = new Button();
			this.Button_RateCalc = new Button();
			this.GroupBox5 = new GroupBox();
			this.Label114 = new Label();
			this.Label113 = new Label();
			this.ButtonResetDocs = new Button();
			this.ButtonGetDoc = new Button();
			this.cboxDocType = new ComboBox();
			this.cboxDocState = new ComboBox();
			this.linkUS_Legal_Forms = new LinkLabel();
			this.lbl_NotFound = new Label();
			this.pboxOpenClearanceCustSpecs = new PictureBox();
			this.lblOpenClearanceCustSpecs = new Label();
			this.pboxOpenTitleCustSpecs = new PictureBox();
			this.lblOpenTitleCustSpec = new Label();
			this.pboxOpenRunSheet = new PictureBox();
			this.TabPg2PhBk = new TabPage();
			this.PictureBox9 = new PictureBox();
			this.lbl_BusnPhones = new Label();
			this.Label48 = new Label();
			this.Label49 = new Label();
			this.DataGridView1 = new DataGridView();
			this.TabPg3Cal = new TabPage();
			this.TabPg4Clearing = new TabPage();
			this.PictureBox8 = new PictureBox();
			this.lbl_doc_Lease_Fee_LandContract = new Label();
			this.PictureBox6 = new PictureBox();
			this.lbl_doc_SOP_deedprep = new Label();
			this.PictureBox7 = new PictureBox();
			this.lbl_doc_approvePOA = new Label();
			this.PictureBox5 = new PictureBox();
			this.lbl_doc_aboutVesting = new Label();
			this.PictureBox4 = new PictureBox();
			this.lbl_doc_aboutDeeds = new Label();
			this.TableLayoutPanel1 = new TableLayoutPanel();
			this.txtSOL_notes = new TextBox();
			this.Label_statutecomments = new Label();
			this.lblSOL_Tax_RedemPer = new Label();
			this.Label_forclRedem = new Label();
			this.Label_taxTakRedem = new Label();
			this.Label_mtg = new Label();
			this.lblSOL_forecl_redem_per = new Label();
			this.Label73 = new Label();
			this.Label46 = new Label();
			this.Label74 = new Label();
			this.Label54 = new Label();
			this.Label52 = new Label();
			this.lblSOL_Mtg = new Label();
			this.Label58 = new Label();
			this.Label_heloc = new Label();
			this.lblSOL_Heloc = new Label();
			this.Label_teRule = new Label();
			this.lblSOL_TERule = new Label();
			this.Label_spousal = new Label();
			this.lblSOL_PersTax = new Label();
			this.Label_persTax = new Label();
			this.lblSOL_ClaimLien = new Label();
			this.lblSOL_HOA = new Label();
			this.lblSOL_Support = new Label();
			this.Label_support = new Label();
			this.Label_claimLien = new Label();
			this.lblSOL_Notice = new Label();
			this.lblSOL_Hosp = new Label();
			this.Label_HOA = new Label();
			this.Label_hospLien = new Label();
			this.lblSOL_Mech = new Label();
			this.Label_NOC = new Label();
			this.lblSOL_lispen = new Label();
			this.Label_mechLien = new Label();
			this.Label_lisPendens = new Label();
			this.lblSOL_Jgmt = new Label();
			this.Label_jgmt = new Label();
			this.lblSOL_Spousal = new Label();
			this.Label_stateJgmt = new Label();
			this.lblSOL_StateJgmt = new Label();
			this.Label_fc = new Label();
			this.txt_foreclosure_notes = new TextBox();
			this.Label_credclaim = new Label();
			this.Label_aftacq = new Label();
			this.lblSOL_Creditor_Claims = new Label();
			this.lblSOL_AftAcq = new Label();
			this.txt_ProbateInfo = new TextBox();
			this.Label_probate = new Label();
			this.TabPg5Req = new TabPage();
			this.WebBrowser3 = new WebBrowser();
			this.TabPg6OtherLogins = new TabPage();
			this.DataGridView2 = new DataGridView();
			this.TabPg7Taxes = new TabPage();
			this.lbl_verifDate5 = new Label();
			this.lbl_verified_taxoff5 = new Label();
			this.lbl_verifDate4 = new Label();
			this.lbl_verified_taxoff4 = new Label();
			this.lbl_verifDate3 = new Label();
			this.lbl_verified_taxoff3 = new Label();
			this.lbl_verifDate2 = new Label();
			this.lbl_verified_taxoff2 = new Label();
			this.lbl_verifDate1 = new Label();
			this.lbl_verified_taxoff1 = new Label();
			this.Label39 = new Label();
			this.txtTaxOffice1 = new TextBox();
			this.txtTaxOffice2 = new TextBox();
			this.txtTaxOffice3 = new TextBox();
			this.txtTaxOffice4 = new TextBox();
			this.txtTaxOffice5 = new TextBox();
			this.lblTxAuth1 = new Label();
			this.linkLocTax1 = new LinkLabel();
			this.linkLocTax5 = new LinkLabel();
			this.lblTxAuth5 = new Label();
			this.lblTxAuth2 = new Label();
			this.linkLocTax2 = new LinkLabel();
			this.linkLocTax4 = new LinkLabel();
			this.lblTxAuth4 = new Label();
			this.lblTxAuth3 = new Label();
			this.linkLocTax3 = new LinkLabel();
			this.pbxExport = new PictureBox();
			this.pbxCopy5 = new PictureBox();
			this.pbxCopy4 = new PictureBox();
			this.pbxCopy3 = new PictureBox();
			this.pbxCopy2 = new PictureBox();
			this.pbxCopy1 = new PictureBox();
			this.TabPg8UWMan = new TabPage();
			this.WebBrowser1 = new WebBrowser();
			this.TabPage1 = new TabPage();
			this.GroupBox1 = new GroupBox();
			this.lbl_vstats_YTD = new Label();
			this.lbl_vstats_Jan = new Label();
			this.lbl_vstats_Dec = new Label();
			this.lbl_vstats_Feb = new Label();
			this.lbl_vstats_Nov = new Label();
			this.lbl_vstats_Mar = new Label();
			this.lbl_vstats_Oct = new Label();
			this.lbl_vstats_Apr = new Label();
			this.lbl_vstats_Sep = new Label();
			this.lbl_vstats_May = new Label();
			this.lbl_vstats_Aug = new Label();
			this.lbl_vstats_Jun = new Label();
			this.lbl_vstats_Jul = new Label();
			this.Label121 = new Label();
			this.Label118 = new Label();
			this.Label21 = new Label();
			this.cbox_StatsTaxCounties = new ComboBox();
			this.txt_StatsTaxOffices = new TextBox();
			this.lbl_TaxOnlineStats = new Label();
			this.Label14 = new Label();
			this.lbl_OrbStat6 = new Label();
			this.Label37 = new Label();
			this.cbox_StatsStates = new ComboBox();
			this.Label25 = new Label();
			this.Label23 = new Label();
			this.lbl_OrbStats = new Label();
			this.lbl_OrbStat5 = new Label();
			this.txt_StatsCounties = new TextBox();
			this.lbl_OrbStat4 = new Label();
			this.lbl_OrbStat3 = new Label();
			this.lbl_OrbStat2 = new Label();
			this.lbl_OrbStat1 = new Label();
			this.lbl_CoOnlineStats = new Label();
			this.Label120 = new Label();
			this.Label119 = new Label();
			this.Label116 = new Label();
			this.Label115 = new Label();
			this.TabPage2 = new TabPage();
			this.lblSOL_being_Clause = new Label();
			this.lbl_homestead = new Label();
			this.txt_homestead_notes = new TextBox();
			this.lbl_deed_prep = new Label();
			this.lbl_attyClose = new Label();
			this.txt_AttyNotes = new TextBox();
			this.txt_DeedNotes = new TextBox();
			this.CheckBox1 = new CheckBox();
			this.Label123 = new Label();
			this.txt_PolicyNotes = new TextBox();
			this.TabPage3 = new TabPage();
			this.PictureBox3 = new PictureBox();
			this.lbl_doc_endorsInfo = new Label();
			this.PictureBox2 = new PictureBox();
			this.lbl_doc_Alta_Clta = new Label();
			this.WebBrowser2 = new WebBrowser();
			this.LinkLabel4 = new LinkLabel();
			this.Label56 = new Label();
			this.ToolTip2 = new ToolTip(this.components);
			this.Label55 = new Label();
			this.Label62 = new Label();
			this.Label64 = new Label();
			this.Label66 = new Label();
			this.Label70 = new Label();
			this.Label75 = new Label();
			this.Label76 = new Label();
			this.Label77 = new Label();
			this.Label78 = new Label();
			this.Label80 = new Label();
			this.Label82 = new Label();
			this.Label84 = new Label();
			this.Label85 = new Label();
			this.Label86 = new Label();
			this.Label87 = new Label();
			this.Label88 = new Label();
			this.TextBox1 = new TextBox();
			this.Label89 = new Label();
			this.Label90 = new Label();
			this.Label91 = new Label();
			this.Label92 = new Label();
			this.Label93 = new Label();
			this.Label94 = new Label();
			this.Label95 = new Label();
			this.Label96 = new Label();
			this.Label97 = new Label();
			this.Label98 = new Label();
			this.Label99 = new Label();
			this.Label100 = new Label();
			this.Label101 = new Label();
			this.Label102 = new Label();
			this.Label103 = new Label();
			this.Label104 = new Label();
			this.Label105 = new Label();
			this.Label106 = new Label();
			this.Label107 = new Label();
			this.Label108 = new Label();
			this.Label109 = new Label();
			this.Label110 = new Label();
			this.Label111 = new Label();
			this.Label112 = new Label();
			this.Panel2 = new Panel();
			this.pboxOpenCredCard = new PictureBox();
			this.lbl_creditCard = new Label();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox10.SuspendLayout();
			this.GroupBox8.SuspendLayout();
			this.GroupBox7.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPg1Docs.SuspendLayout();
			((ISupportInitialize)this.pbox_Abstr_SOP).BeginInit();
			((ISupportInitialize)this.pboxOpenEtitleWkshare).BeginInit();
			((ISupportInitialize)this.pboxOpenORT_Wkshare).BeginInit();
			this.GroupBox5.SuspendLayout();
			((ISupportInitialize)this.pboxOpenClearanceCustSpecs).BeginInit();
			((ISupportInitialize)this.pboxOpenTitleCustSpecs).BeginInit();
			((ISupportInitialize)this.pboxOpenRunSheet).BeginInit();
			this.TabPg2PhBk.SuspendLayout();
			((ISupportInitialize)this.PictureBox9).BeginInit();
			((ISupportInitialize)this.DataGridView1).BeginInit();
			this.TabPg3Cal.SuspendLayout();
			this.TabPg4Clearing.SuspendLayout();
			((ISupportInitialize)this.PictureBox8).BeginInit();
			((ISupportInitialize)this.PictureBox6).BeginInit();
			((ISupportInitialize)this.PictureBox7).BeginInit();
			((ISupportInitialize)this.PictureBox5).BeginInit();
			((ISupportInitialize)this.PictureBox4).BeginInit();
			this.TableLayoutPanel1.SuspendLayout();
			this.TabPg5Req.SuspendLayout();
			this.TabPg6OtherLogins.SuspendLayout();
			((ISupportInitialize)this.DataGridView2).BeginInit();
			this.TabPg7Taxes.SuspendLayout();
			((ISupportInitialize)this.pbxExport).BeginInit();
			((ISupportInitialize)this.pbxCopy5).BeginInit();
			((ISupportInitialize)this.pbxCopy4).BeginInit();
			((ISupportInitialize)this.pbxCopy3).BeginInit();
			((ISupportInitialize)this.pbxCopy2).BeginInit();
			((ISupportInitialize)this.pbxCopy1).BeginInit();
			this.TabPg8UWMan.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TabPage3.SuspendLayout();
			((ISupportInitialize)this.PictureBox3).BeginInit();
			((ISupportInitialize)this.PictureBox2).BeginInit();
			((ISupportInitialize)this.pboxOpenCredCard).BeginInit();
			this.SuspendLayout();

			this.Label32.AutoSize = true;
			this.Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label32.ForeColor = Color.Black;
			this.Label32.ImageAlign = ContentAlignment.TopRight;
			this.Label32.Location = new Point(514, 26);
			this.Label32.Name = "Label32";
			this.Label32.Size = new System.Drawing.Size(80, 15);
			this.Label32.TabIndex = 54;
			this.Label32.Text = "todays date";
			this.Label32.TextAlign = ContentAlignment.TopRight;
			this.SplitContainer1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			this.SplitContainer1.Location = new Point(0, 6);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = Orientation.Horizontal;
			this.SplitContainer1.Panel1.BackColor = Color.Honeydew;
			this.SplitContainer1.Panel1.Controls.Add(this.lbl_attyState);
			this.SplitContainer1.Panel1.Controls.Add(this.PictureBox1);
			this.SplitContainer1.Panel1.Controls.Add(this.lblDefault_UW_Name);
			this.SplitContainer1.Panel1.Controls.Add(this.Label32);
			this.SplitContainer1.Panel1.Controls.Add(this.Panel1);
			this.SplitContainer1.Panel2.AutoScroll = true;
			this.SplitContainer1.Panel2.BackColor = Color.Honeydew;
			this.SplitContainer1.Panel2.Controls.Add(this.GroupBox10);
			this.SplitContainer1.Panel2.Controls.Add(this.GroupBox8);
			this.SplitContainer1.Panel2.Controls.Add(this.GroupBox7);
			this.SplitContainer1.Panel2.Controls.Add(this.GroupBox4);
			this.SplitContainer1.Panel2.Controls.Add(this.GroupBox3);
			this.SplitContainer1.Panel2.Controls.Add(this.GroupBox2);
			this.SplitContainer1.Size = new System.Drawing.Size(874, 385);
			this.SplitContainer1.SplitterDistance = 109;
			this.SplitContainer1.TabIndex = 179;
			this.lbl_attyState.AutoSize = true;
			this.lbl_attyState.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_attyState.ForeColor = Color.Red;
			this.lbl_attyState.Location = new Point(262, 4);
			this.lbl_attyState.Name = "lbl_attyState";
			this.lbl_attyState.Size = new System.Drawing.Size(10, 15);
			this.lbl_attyState.TabIndex = 84;
			this.lbl_attyState.Text = ".";
			this.PictureBox1.BackgroundImageLayout = ImageLayout.None;
			this.PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new Point(3, 4);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(238, 35);
			this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 48;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Tag = "ORB";
			this.lblDefault_UW_Name.AutoSize = true;
			this.lblDefault_UW_Name.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblDefault_UW_Name.ForeColor = Color.Red;
			this.lblDefault_UW_Name.Location = new Point(262, 26);
			this.lblDefault_UW_Name.Name = "lblDefault_UW_Name";
			this.lblDefault_UW_Name.Size = new System.Drawing.Size(10, 15);
			this.lblDefault_UW_Name.TabIndex = 66;
			this.lblDefault_UW_Name.Text = ".";
			this.Panel1.BackColor = Color.LightSteelBlue;
			this.Panel1.Controls.Add(this.ButtonExit);
			this.Panel1.Controls.Add(this.Label36);
			this.Panel1.Controls.Add(this.Button_PolicyWarehouse);
			this.Panel1.Controls.Add(this.ComboBoxTaxType);
			this.Panel1.Controls.Add(this.GroupBox6);
			this.Panel1.Controls.Add(this.Button_EditORB);
			this.Panel1.Controls.Add(this.Button_Search);
			this.Panel1.Controls.Add(this.ButtonHelp);
			this.Panel1.Controls.Add(this.Button_RateCalc);
			this.Panel1.Controls.Add(this.ComboBoxState);
			this.Panel1.Controls.Add(this.ComboBoxCounty);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.ComboBoxTaxAuth);
			this.Panel1.Controls.Add(this.ButtonReset);
			this.Panel1.Dock = DockStyle.Bottom;
			this.Panel1.Location = new Point(0, 44);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(874, 65);
			this.Panel1.TabIndex = 83;
			this.ButtonExit.BackColor = Color.FromArgb(220, 185, 255);
			this.ButtonExit.Cursor = Cursors.Hand;
			this.ButtonExit.FlatAppearance.BorderColor = Color.Purple;
			this.ButtonExit.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.ButtonExit.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.ButtonExit.FlatStyle = FlatStyle.Flat;
			this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Pixel, 0);
			this.ButtonExit.ForeColor = Color.Indigo;
			this.ButtonExit.Location = new Point(811, 25);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(59, 35);
			this.ButtonExit.TabIndex = 84;
			this.ButtonExit.Text = "EXIT";
			this.ButtonExit.UseVisualStyleBackColor = false;
			this.Label36.AutoSize = true;
			this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label36 = this.Label36;
			point = new Point(305, 18);
			label36.Location = point;
			this.Label36.Name = "Label36";
			Label label361 = this.Label36;
			size = new System.Drawing.Size(54, 16);
			label361.Size = size;
			this.Label36.TabIndex = 93;
			this.Label36.Text = "tax type";
			this.ComboBoxTaxType.DropDownHeight = 50;
			this.ComboBoxTaxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ComboBoxTaxType.ForeColor = Color.Indigo;
			this.ComboBoxTaxType.FormattingEnabled = true;
			this.ComboBoxTaxType.IntegralHeight = false;
			this.ComboBoxTaxType.ItemHeight = 12;
			ComboBox comboBoxTaxType = this.ComboBoxTaxType;
			point = new Point(305, 37);
			comboBoxTaxType.Location = point;
			this.ComboBoxTaxType.MaxDropDownItems = 10;
			this.ComboBoxTaxType.Name = "ComboBoxTaxType";
			ComboBox comboBox = this.ComboBoxTaxType;
			size = new System.Drawing.Size(120, 20);
			comboBox.Size = size;
			this.ComboBoxTaxType.TabIndex = 92;
			this.GroupBox6.BackColor = Color.FromArgb(220, 185, 255);
			this.GroupBox6.Controls.Add(this.cbxAddtlLinks);
			this.GroupBox6.FlatStyle = FlatStyle.Flat;
			this.GroupBox6.Font = new System.Drawing.Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			GroupBox groupBox6 = this.GroupBox6;
			point = new Point(660, 25);
			groupBox6.Location = point;
			this.GroupBox6.Name = "GroupBox6";
			GroupBox groupBox = this.GroupBox6;
			size = new System.Drawing.Size(145, 38);
			groupBox.Size = size;
			this.GroupBox6.TabIndex = 90;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "Additional Links";
			this.cbxAddtlLinks.DropDownHeight = 150;
			this.cbxAddtlLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbxAddtlLinks.ForeColor = Color.Indigo;
			this.cbxAddtlLinks.FormattingEnabled = true;
			this.cbxAddtlLinks.IntegralHeight = false;
			this.cbxAddtlLinks.ItemHeight = 12;
			ComboBox.ObjectCollection items = this.cbxAddtlLinks.Items;
			object[] objArray = new object[] { "CPL-Ticor", "CPL-Stewart", "Ernst Publishing", "FDIC.gov", "IRS.gov", "Justia (Courts)", "MERS-Releases", "NetrOnline", "Old Republic", "PACER", "Real Quest", "Stewart New York", "Stewart Title Guaranty", "Stewart VirtUW", "Ticor NTI Web", "US Courts Map", "USPS.com", "ZipCode Lookup" };
			items.AddRange(objArray);
			ComboBox comboBox1 = this.cbxAddtlLinks;
			point = new Point(6, 13);
			comboBox1.Location = point;
			this.cbxAddtlLinks.Name = "cbxAddtlLinks";
			ComboBox comboBox2 = this.cbxAddtlLinks;
			size = new System.Drawing.Size(133, 20);
			comboBox2.Size = size;
			this.cbxAddtlLinks.TabIndex = 69;
			this.Button_EditORB.BackColor = Color.FromArgb(220, 185, 255);
			this.Button_EditORB.Cursor = Cursors.Hand;
			this.Button_EditORB.FlatAppearance.BorderColor = Color.Purple;
			this.Button_EditORB.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_EditORB.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_EditORB.FlatStyle = FlatStyle.Flat;
			this.Button_EditORB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Pixel, 0);
			this.Button_EditORB.ForeColor = Color.Indigo;
			Button buttonEditORB = this.Button_EditORB;
			point = new Point(585, 25);
			buttonEditORB.Location = point;
			this.Button_EditORB.Name = "Button_EditORB";
			Button buttonEditORB1 = this.Button_EditORB;
			size = new System.Drawing.Size(72, 35);
			buttonEditORB1.Size = size;
			this.Button_EditORB.TabIndex = 91;
			this.Button_EditORB.Text = "EDIT";
			this.Button_EditORB.UseVisualStyleBackColor = false;
			this.Button_Search.BackColor = Color.FromArgb(220, 185, 255);
			this.Button_Search.Cursor = Cursors.Hand;
			this.Button_Search.FlatAppearance.BorderColor = Color.Purple;
			this.Button_Search.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_Search.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_Search.FlatStyle = FlatStyle.Flat;
			this.Button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Pixel, 0);
			this.Button_Search.ForeColor = Color.Indigo;
			Button buttonSearch = this.Button_Search;
			point = new Point(433, 25);
			buttonSearch.Location = point;
			this.Button_Search.Name = "Button_Search";
			Button buttonSearch1 = this.Button_Search;
			size = new System.Drawing.Size(72, 35);
			buttonSearch1.Size = size;
			this.Button_Search.TabIndex = 87;
			this.Button_Search.Text = "SEARCH";
			this.Button_Search.UseVisualStyleBackColor = false;
			this.ComboBoxState.DropDownHeight = 100;
			this.ComboBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ComboBoxState.ForeColor = Color.Indigo;
			this.ComboBoxState.FormattingEnabled = true;
			this.ComboBoxState.IntegralHeight = false;
			this.ComboBoxState.ItemHeight = 12;
			ComboBox.ObjectCollection objectCollections = this.ComboBoxState.Items;
			objArray = new object[] { "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" };
			objectCollections.AddRange(objArray);
			ComboBox comboBoxState = this.ComboBoxState;
			point = new Point(3, 37);
			comboBoxState.Location = point;
			this.ComboBoxState.MaxDropDownItems = 10;
			this.ComboBoxState.Name = "ComboBoxState";
			ComboBox comboBoxState1 = this.ComboBoxState;
			size = new System.Drawing.Size(44, 20);
			comboBoxState1.Size = size;
			this.ComboBoxState.Sorted = true;
			this.ComboBoxState.TabIndex = 82;
			this.ComboBoxCounty.DropDownHeight = 50;
			this.ComboBoxCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ComboBoxCounty.ForeColor = Color.Indigo;
			this.ComboBoxCounty.FormattingEnabled = true;
			this.ComboBoxCounty.IntegralHeight = false;
			this.ComboBoxCounty.ItemHeight = 12;
			ComboBox comboBoxCounty = this.ComboBoxCounty;
			point = new Point(53, 37);
			comboBoxCounty.Location = point;
			this.ComboBoxCounty.MaxDropDownItems = 10;
			this.ComboBoxCounty.Name = "ComboBoxCounty";
			ComboBox comboBoxCounty1 = this.ComboBoxCounty;
			size = new System.Drawing.Size(120, 20);
			comboBoxCounty1.Size = size;
			this.ComboBoxCounty.TabIndex = 83;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label2 = this.Label2;
			point = new Point(53, 18);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(47, 16);
			label21.Size = size;
			this.Label2.TabIndex = 86;
			this.Label2.Text = "county";
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1 = this.Label1;
			point = new Point(3, 18);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(37, 16);
			label11.Size = size;
			this.Label1.TabIndex = 84;
			this.Label1.Text = "state";
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label3 = this.Label3;
			point = new Point(179, 18);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(78, 16);
			label31.Size = size;
			this.Label3.TabIndex = 89;
			this.Label3.Text = "tax authority";
			this.ComboBoxTaxAuth.DropDownHeight = 50;
			this.ComboBoxTaxAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ComboBoxTaxAuth.ForeColor = Color.Indigo;
			this.ComboBoxTaxAuth.FormattingEnabled = true;
			this.ComboBoxTaxAuth.IntegralHeight = false;
			this.ComboBoxTaxAuth.ItemHeight = 12;
			ComboBox comboBoxTaxAuth = this.ComboBoxTaxAuth;
			point = new Point(179, 37);
			comboBoxTaxAuth.Location = point;
			this.ComboBoxTaxAuth.MaxDropDownItems = 10;
			this.ComboBoxTaxAuth.Name = "ComboBoxTaxAuth";
			ComboBox comboBoxTaxAuth1 = this.ComboBoxTaxAuth;
			size = new System.Drawing.Size(120, 20);
			comboBoxTaxAuth1.Size = size;
			this.ComboBoxTaxAuth.TabIndex = 85;
			this.ButtonReset.BackColor = Color.FromArgb(220, 185, 255);
			this.ButtonReset.Cursor = Cursors.Hand;
			this.ButtonReset.FlatAppearance.BorderColor = Color.Purple;
			this.ButtonReset.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.ButtonReset.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.ButtonReset.FlatStyle = FlatStyle.Flat;
			this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Pixel, 0);
			this.ButtonReset.ForeColor = Color.Indigo;
			Button buttonReset = this.ButtonReset;
			point = new Point(509, 25);
			buttonReset.Location = point;
			this.ButtonReset.Name = "ButtonReset";
			Button buttonReset1 = this.ButtonReset;
			size = new System.Drawing.Size(72, 35);
			buttonReset1.Size = size;
			this.ButtonReset.TabIndex = 88;
			this.ButtonReset.Text = "RESET";
			this.ButtonReset.UseVisualStyleBackColor = false;
			this.GroupBox10.BackColor = Color.GhostWhite;
			this.GroupBox10.Controls.Add(this.lbl_SubTerm);
			this.GroupBox10.Controls.Add(this.Label135);
			this.GroupBox10.Controls.Add(this.lbl_IndexFeeAmt);
			this.GroupBox10.Controls.Add(this.Label19);
			this.GroupBox10.Controls.Add(this.Label13);
			this.GroupBox10.Controls.Add(this.lbl_WeSubscribe);
			this.GroupBox10.Controls.Add(this.lbl_IndexPmtMethod);
			this.GroupBox10.Controls.Add(this.Label11);
			this.GroupBox10.Controls.Add(this.Label128);
			this.GroupBox10.Controls.Add(this.lbl_Free);
			this.GroupBox10.Controls.Add(this.Label30);
			this.GroupBox10.Controls.Add(this.LabelSubNeeded);
			this.GroupBox10.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.GroupBox10.ForeColor = Color.FromArgb(64, 64, 64);
			GroupBox groupBox10 = this.GroupBox10;
			point = new Point(666, 88);
			groupBox10.Location = point;
			this.GroupBox10.Name = "GroupBox10";
			GroupBox groupBox101 = this.GroupBox10;
			size = new System.Drawing.Size(152, 149);
			groupBox101.Size = size;
			this.GroupBox10.TabIndex = 189;
			this.GroupBox10.TabStop = false;
			this.GroupBox10.Text = "INDEX SUBSCRIP'S";
			this.lbl_SubTerm.AutoSize = true;
			this.lbl_SubTerm.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_SubTerm.ForeColor = Color.Black;
			Label lblSubTerm = this.lbl_SubTerm;
			point = new Point(86, 72);
			lblSubTerm.Location = point;
			this.lbl_SubTerm.Name = "lbl_SubTerm";
			Label lblSubTerm1 = this.lbl_SubTerm;
			size = new System.Drawing.Size(9, 12);
			lblSubTerm1.Size = size;
			this.lbl_SubTerm.TabIndex = 74;
			this.lbl_SubTerm.Text = "*";
			this.Label135.AutoSize = true;
			this.Label135.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label135.ForeColor = Color.DarkSlateBlue;
			Label label135 = this.Label135;
			point = new Point(6, 72);
			label135.Location = point;
			this.Label135.Name = "Label135";
			Label label1351 = this.Label135;
			size = new System.Drawing.Size(74, 12);
			label1351.Size = size;
			this.Label135.TabIndex = 72;
			this.Label135.Text = "Subscrip. Term: ";
			this.lbl_IndexFeeAmt.AutoSize = true;
			this.lbl_IndexFeeAmt.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_IndexFeeAmt.ForeColor = Color.Black;
			Label lblIndexFeeAmt = this.lbl_IndexFeeAmt;
			point = new Point(73, 89);
			lblIndexFeeAmt.Location = point;
			this.lbl_IndexFeeAmt.Name = "lbl_IndexFeeAmt";
			Label lblIndexFeeAmt1 = this.lbl_IndexFeeAmt;
			size = new System.Drawing.Size(9, 12);
			lblIndexFeeAmt1.Size = size;
			this.lbl_IndexFeeAmt.TabIndex = 71;
			this.lbl_IndexFeeAmt.Text = "*";
			this.Label19.AutoSize = true;
			this.Label19.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label19.ForeColor = Color.DarkSlateBlue;
			Label label19 = this.Label19;
			point = new Point(6, 54);
			label19.Location = point;
			this.Label19.Name = "Label19";
			Label label191 = this.Label19;
			size = new System.Drawing.Size(81, 12);
			label191.Size = size;
			this.Label19.TabIndex = 68;
			this.Label19.Text = "Do we subscribe?";
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label13.ForeColor = Color.DarkSlateBlue;
			Label label13 = this.Label13;
			point = new Point(6, 89);
			label13.Location = point;
			this.Label13.Name = "Label13";
			Label label131 = this.Label13;
			size = new System.Drawing.Size(67, 12);
			label131.Size = size;
			this.Label13.TabIndex = 70;
			this.Label13.Text = "Subscrip. Fee: ";
			this.lbl_WeSubscribe.AutoSize = true;
			this.lbl_WeSubscribe.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_WeSubscribe.ForeColor = Color.Black;
			Label lblWeSubscribe = this.lbl_WeSubscribe;
			point = new Point(93, 54);
			lblWeSubscribe.Location = point;
			this.lbl_WeSubscribe.Name = "lbl_WeSubscribe";
			Label lblWeSubscribe1 = this.lbl_WeSubscribe;
			size = new System.Drawing.Size(9, 12);
			lblWeSubscribe1.Size = size;
			this.lbl_WeSubscribe.TabIndex = 69;
			this.lbl_WeSubscribe.Text = "*";
			this.lbl_IndexPmtMethod.AutoSize = true;
			this.lbl_IndexPmtMethod.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_IndexPmtMethod.ForeColor = Color.Black;
			Label lblIndexPmtMethod = this.lbl_IndexPmtMethod;
			point = new Point(74, 107);
			lblIndexPmtMethod.Location = point;
			this.lbl_IndexPmtMethod.Name = "lbl_IndexPmtMethod";
			Label lblIndexPmtMethod1 = this.lbl_IndexPmtMethod;
			size = new System.Drawing.Size(9, 12);
			lblIndexPmtMethod1.Size = size;
			this.lbl_IndexPmtMethod.TabIndex = 67;
			this.lbl_IndexPmtMethod.Text = "*";
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label11.ForeColor = Color.DarkSlateBlue;
			Label label111 = this.Label11;
			point = new Point(6, 36);
			label111.Location = point;
			this.Label11.Name = "Label11";
			Label label112 = this.Label11;
			size = new System.Drawing.Size(67, 12);
			label112.Size = size;
			this.Label11.TabIndex = 66;
			this.Label11.Text = "Free Subscrip?";
			this.Label128.AutoSize = true;
			this.Label128.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label128.ForeColor = Color.DarkSlateBlue;
			Label label128 = this.Label128;
			point = new Point(6, 107);
			label128.Location = point;
			this.Label128.Name = "Label128";
			Label label1281 = this.Label128;
			size = new System.Drawing.Size(66, 12);
			label1281.Size = size;
			this.Label128.TabIndex = 66;
			this.Label128.Text = "Pmt Method: ";
			this.lbl_Free.AutoSize = true;
			this.lbl_Free.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_Free.ForeColor = Color.Black;
			Label lblFree = this.lbl_Free;
			point = new Point(86, 36);
			lblFree.Location = point;
			this.lbl_Free.Name = "lbl_Free";
			Label lblFree1 = this.lbl_Free;
			size = new System.Drawing.Size(9, 12);
			lblFree1.Size = size;
			this.lbl_Free.TabIndex = 67;
			this.lbl_Free.Text = "*";
			this.Label30.AutoSize = true;
			this.Label30.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label30.ForeColor = Color.DarkSlateBlue;
			Label label30 = this.Label30;
			point = new Point(6, 20);
			label30.Location = point;
			this.Label30.Name = "Label30";
			Label label301 = this.Label30;
			size = new System.Drawing.Size(78, 12);
			label301.Size = size;
			this.Label30.TabIndex = 64;
			this.Label30.Text = "Subscr. Needed: ";
			this.LabelSubNeeded.AutoSize = true;
			this.LabelSubNeeded.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.LabelSubNeeded.ForeColor = Color.Black;
			Label labelSubNeeded = this.LabelSubNeeded;
			point = new Point(86, 20);
			labelSubNeeded.Location = point;
			this.LabelSubNeeded.Name = "LabelSubNeeded";
			Label labelSubNeeded1 = this.LabelSubNeeded;
			size = new System.Drawing.Size(9, 12);
			labelSubNeeded1.Size = size;
			this.LabelSubNeeded.TabIndex = 65;
			this.LabelSubNeeded.Text = "*";
			this.GroupBox8.BackColor = Color.GhostWhite;
			this.GroupBox8.Controls.Add(this.TextBox4);
			this.GroupBox8.Controls.Add(this.ComboBox1);
			this.GroupBox8.Controls.Add(this.Label40);
			this.GroupBox8.Controls.Add(this.Button1);
			this.GroupBox8.Controls.Add(this.TextBox3);
			this.GroupBox8.Controls.Add(this.TextBox2);
			this.GroupBox8.Controls.Add(this.Label41);
			this.GroupBox8.Controls.Add(this.Label50);
			this.GroupBox8.Controls.Add(this.Label51);
			this.GroupBox8.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.GroupBox8.ForeColor = Color.FromArgb(64, 64, 64);
			GroupBox groupBox8 = this.GroupBox8;
			point = new Point(675, 245);
			groupBox8.Location = point;
			this.GroupBox8.Name = "GroupBox8";
			GroupBox groupBox81 = this.GroupBox8;
			size = new System.Drawing.Size(142, 238);
			groupBox81.Size = size;
			this.GroupBox8.TabIndex = 187;
			this.GroupBox8.TabStop = false;
			this.GroupBox8.Text = "DO NOT INSURE";
			this.GroupBox8.Visible = false;
			this.TextBox4.BackColor = Color.Snow;
			this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TextBox4.ForeColor = Color.Purple;
			TextBox textBox4 = this.TextBox4;
			point = new Point(6, 155);
			textBox4.Location = point;
			this.TextBox4.MaxLength = 100000;
			this.TextBox4.Multiline = true;
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.ReadOnly = true;
			this.TextBox4.ScrollBars = ScrollBars.Vertical;
			TextBox textBox = this.TextBox4;
			size = new System.Drawing.Size(123, 72);
			textBox.Size = size;
			this.TextBox4.TabIndex = 72;
			this.ComboBox1.DropDownHeight = 100;
			this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ComboBox1.ForeColor = Color.Indigo;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.IntegralHeight = false;
			this.ComboBox1.ItemHeight = 12;
			ComboBox.ObjectCollection items1 = this.ComboBox1.Items;
			objArray = new object[] { "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" };
			items1.AddRange(objArray);
			ComboBox comboBox11 = this.ComboBox1;
			point = new Point(39, 110);
			comboBox11.Location = point;
			this.ComboBox1.MaxDropDownItems = 10;
			this.ComboBox1.Name = "ComboBox1";
			ComboBox comboBox12 = this.ComboBox1;
			size = new System.Drawing.Size(44, 20);
			comboBox12.Size = size;
			this.ComboBox1.Sorted = true;
			this.ComboBox1.TabIndex = 71;
			this.Label40.AutoSize = true;
			this.Label40.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label40.ForeColor = Color.DarkSlateBlue;
			Label label40 = this.Label40;
			point = new Point(6, 112);
			label40.Location = point;
			this.Label40.Name = "Label40";
			Label label401 = this.Label40;
			size = new System.Drawing.Size(33, 13);
			label401.Size = size;
			this.Label40.TabIndex = 70;
			this.Label40.Text = "State";
			Button button1 = this.Button1;
			point = new Point(89, 110);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button11 = this.Button1;
			size = new System.Drawing.Size(40, 23);
			button11.Size = size;
			this.Button1.TabIndex = 69;
			this.Button1.Text = "GO";
			this.Button1.UseVisualStyleBackColor = true;
			TextBox textBox3 = this.TextBox3;
			point = new Point(6, 81);
			textBox3.Location = point;
			this.TextBox3.Name = "TextBox3";
			TextBox textBox31 = this.TextBox3;
			size = new System.Drawing.Size(124, 23);
			textBox31.Size = size;
			this.TextBox3.TabIndex = 68;
			TextBox textBox2 = this.TextBox2;
			point = new Point(6, 37);
			textBox2.Location = point;
			this.TextBox2.Name = "TextBox2";
			TextBox textBox21 = this.TextBox2;
			size = new System.Drawing.Size(124, 23);
			textBox21.Size = size;
			this.TextBox2.TabIndex = 67;
			this.Label41.AutoSize = true;
			this.Label41.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label41.ForeColor = Color.Black;
			Label label41 = this.Label41;
			point = new Point(6, 137);
			label41.Location = point;
			this.Label41.Name = "Label41";
			Label label411 = this.Label41;
			size = new System.Drawing.Size(36, 15);
			label411.Size = size;
			this.Label41.TabIndex = 66;
			this.Label41.Text = "result";
			this.Label50.AutoSize = true;
			this.Label50.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label50.ForeColor = Color.DarkSlateBlue;
			Label label50 = this.Label50;
			point = new Point(6, 63);
			label50.Location = point;
			this.Label50.Name = "Label50";
			Label label501 = this.Label50;
			size = new System.Drawing.Size(64, 13);
			label501.Size = size;
			this.Label50.TabIndex = 64;
			this.Label50.Text = "FIrst  Name";
			this.Label51.AutoSize = true;
			this.Label51.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label51.ForeColor = Color.DarkSlateBlue;
			Label label51 = this.Label51;
			point = new Point(6, 22);
			label51.Location = point;
			this.Label51.Name = "Label51";
			Label label511 = this.Label51;
			size = new System.Drawing.Size(124, 13);
			label511.Size = size;
			this.Label51.TabIndex = 63;
			this.Label51.Text = "Last Name or Company";
			this.GroupBox7.AutoSize = true;
			this.GroupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GroupBox7.BackColor = Color.GhostWhite;
			this.GroupBox7.Controls.Add(this.TableLayoutPanel2);
			this.GroupBox7.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.GroupBox7.ForeColor = Color.FromArgb(64, 64, 64);
			GroupBox groupBox7 = this.GroupBox7;
			point = new Point(7, 3);
			groupBox7.Location = point;
			GroupBox groupBox71 = this.GroupBox7;
			size = new System.Drawing.Size(418, 235);
			groupBox71.MinimumSize = size;
			this.GroupBox7.Name = "GroupBox7";
			GroupBox groupBox1 = this.GroupBox7;
			size = new System.Drawing.Size(418, 412);
			groupBox1.Size = size;
			this.GroupBox7.TabIndex = 184;
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = "SEARCHABLE INDEXES";
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.txt_myfl_P, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabel_MyFlCountiesURL, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.txt_myfl_U, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_tax2P, 3, 14);
			this.TableLayoutPanel2.Controls.Add(this.lbl_MyFlaCounties, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label_DOI, 0, 18);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_tax2U, 2, 14);
			this.TableLayoutPanel2.Controls.Add(this.Label_stCode, 0, 17);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_otherP, 3, 13);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_courtP, 3, 3);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_otherU, 2, 13);
			this.TableLayoutPanel2.Controls.Add(this.Label_secState, 0, 16);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_asrP, 3, 9);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_probateP, 3, 5);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_asrU, 2, 9);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_courtU, 2, 3);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_tax1P, 3, 8);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_muniP, 3, 6);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_tax1U, 2, 8);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_probateU, 2, 5);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_muniU, 2, 6);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_prothonP, 3, 4);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_landP, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_prothonU, 2, 4);
			this.TableLayoutPanel2.Controls.Add(this.LabelOtherURL, 0, 13);
			this.TableLayoutPanel2.Controls.Add(this.txt_login_landU, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.LabelCountyURL, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelOtherTax, 1, 14);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelSheriff, 1, 11);
			this.TableLayoutPanel2.Controls.Add(this.LabelUCC, 0, 15);
			this.TableLayoutPanel2.Controls.Add(this.txtComments, 0, 19);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelCounty, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.LabelOtherTax, 0, 14);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelForeclosure, 1, 12);
			this.TableLayoutPanel2.Controls.Add(this.LabelCourt, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelMuniCourt, 1, 6);
			this.TableLayoutPanel2.Controls.Add(this.LabelForeclosures, 0, 12);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelMaps, 1, 10);
			this.TableLayoutPanel2.Controls.Add(this.LabelSheriff, 0, 11);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelAssessor, 1, 9);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelTax, 1, 8);
			this.TableLayoutPanel2.Controls.Add(this.LabelMapsGIS, 0, 10);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelCoHome, 1, 7);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelCourt, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.LabelProthon, 0, 4);
			this.TableLayoutPanel2.Controls.Add(this.LabelAssessor, 0, 9);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelProthon, 1, 4);
			this.TableLayoutPanel2.Controls.Add(this.LabelCountyTax, 0, 8);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelProbate, 1, 5);
			this.TableLayoutPanel2.Controls.Add(this.LabelCountyHome, 0, 7);
			this.TableLayoutPanel2.Controls.Add(this.LabelMuniCourt, 0, 6);
			this.TableLayoutPanel2.Controls.Add(this.LabelProbate, 0, 5);
			this.TableLayoutPanel2.Controls.Add(this.Label_user, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label_pwd, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabelPlats, 2, 10);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabel_OtherURL, 1, 13);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabel_UCC, 1, 15);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabel_SecState, 1, 16);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabel_State_Code, 1, 17);
			this.TableLayoutPanel2.Controls.Add(this.LinkLabel_DeptIns, 1, 18);
			TableLayoutPanel tableLayoutPanel2 = this.TableLayoutPanel2;
			point = new Point(12, 22);
			tableLayoutPanel2.Location = point;
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			TableLayoutPanel tableLayoutPanel = this.TableLayoutPanel2;
			padding = new System.Windows.Forms.Padding(1);
			tableLayoutPanel.Padding = padding;
			this.TableLayoutPanel2.RowCount = 20;
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new RowStyle());
			TableLayoutPanel tableLayoutPanel21 = this.TableLayoutPanel2;
			size = new System.Drawing.Size(400, 368);
			tableLayoutPanel21.Size = size;
			this.TableLayoutPanel2.TabIndex = 57;
			this.txt_myfl_P.BackColor = Color.GhostWhite;
			this.txt_myfl_P.BorderStyle = BorderStyle.None;
			this.txt_myfl_P.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtMyflP = this.txt_myfl_P;
			point = new Point(319, 31);
			txtMyflP.Location = point;
			TextBox txtMyflP1 = this.txt_myfl_P;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtMyflP1.Margin = padding;
			this.txt_myfl_P.Name = "txt_myfl_P";
			this.txt_myfl_P.ReadOnly = true;
			TextBox textBox1 = this.txt_myfl_P;
			size = new System.Drawing.Size(77, 13);
			textBox1.Size = size;
			this.txt_myfl_P.TabIndex = 201;
			this.txt_myfl_P.WordWrap = false;
			this.LinkLabel_MyFlCountiesURL.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabel_MyFlCountiesURL.AutoSize = true;
			this.LinkLabel_MyFlCountiesURL.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel_MyFlCountiesURL.ForeColor = Color.DarkViolet;
			this.LinkLabel_MyFlCountiesURL.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabel_MyFlCountiesURL.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelMyFlCountiesURL = this.LinkLabel_MyFlCountiesURL;
			point = new Point(125, 31);
			linkLabelMyFlCountiesURL.Location = point;
			this.LinkLabel_MyFlCountiesURL.Name = "LinkLabel_MyFlCountiesURL";
			LinkLabel linkLabel = this.LinkLabel_MyFlCountiesURL;
			size = new System.Drawing.Size(103, 15);
			linkLabel.Size = size;
			this.LinkLabel_MyFlCountiesURL.TabIndex = 214;
			this.LinkLabel_MyFlCountiesURL.TabStop = true;
			this.LinkLabel_MyFlCountiesURL.Text = "MYFLORIDA.COM";
			this.LinkLabel_MyFlCountiesURL.VisitedLinkColor = Color.DarkSlateBlue;
			this.txt_myfl_U.BackColor = Color.GhostWhite;
			this.txt_myfl_U.BorderStyle = BorderStyle.None;
			this.txt_myfl_U.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtMyflU = this.txt_myfl_U;
			point = new Point(246, 31);
			txtMyflU.Location = point;
			TextBox txtMyflU1 = this.txt_myfl_U;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtMyflU1.Margin = padding;
			this.txt_myfl_U.Name = "txt_myfl_U";
			this.txt_myfl_U.ReadOnly = true;
			TextBox txtMyflU2 = this.txt_myfl_U;
			size = new System.Drawing.Size(67, 13);
			txtMyflU2.Size = size;
			this.txt_myfl_U.TabIndex = 198;
			this.txt_myfl_U.WordWrap = false;
			this.txt_login_tax2P.BackColor = Color.GhostWhite;
			this.txt_login_tax2P.BorderStyle = BorderStyle.None;
			this.txt_login_tax2P.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginTax2P = this.txt_login_tax2P;
			point = new Point(319, 211);
			txtLoginTax2P.Location = point;
			TextBox txtLoginTax2P1 = this.txt_login_tax2P;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginTax2P1.Margin = padding;
			this.txt_login_tax2P.Name = "txt_login_tax2P";
			this.txt_login_tax2P.ReadOnly = true;
			TextBox txtLoginTax2P2 = this.txt_login_tax2P;
			size = new System.Drawing.Size(77, 13);
			txtLoginTax2P2.Size = size;
			this.txt_login_tax2P.TabIndex = 212;
			this.txt_login_tax2P.WordWrap = false;
			this.lbl_MyFlaCounties.AutoSize = true;
			this.lbl_MyFlaCounties.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbl_MyFlaCounties.ForeColor = Color.DarkSlateBlue;
			Label lblMyFlaCounties = this.lbl_MyFlaCounties;
			point = new Point(4, 31);
			lblMyFlaCounties.Location = point;
			this.lbl_MyFlaCounties.Name = "lbl_MyFlaCounties";
			Label lblMyFlaCounties1 = this.lbl_MyFlaCounties;
			size = new System.Drawing.Size(87, 15);
			lblMyFlaCounties1.Size = size;
			this.lbl_MyFlaCounties.TabIndex = 213;
			this.lbl_MyFlaCounties.Text = "MyFlorida.com";
			this.Label_DOI.AutoSize = true;
			this.Label_DOI.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label_DOI.ForeColor = Color.DarkSlateBlue;
			Label labelDOI = this.Label_DOI;
			point = new Point(4, 271);
			labelDOI.Location = point;
			this.Label_DOI.Name = "Label_DOI";
			Label labelDOI1 = this.Label_DOI;
			size = new System.Drawing.Size(92, 15);
			labelDOI1.Size = size;
			this.Label_DOI.TabIndex = 190;
			this.Label_DOI.Text = "Agent Licensing";
			this.txt_login_tax2U.BackColor = Color.GhostWhite;
			this.txt_login_tax2U.BorderStyle = BorderStyle.None;
			this.txt_login_tax2U.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginTax2U = this.txt_login_tax2U;
			point = new Point(246, 211);
			txtLoginTax2U.Location = point;
			TextBox txtLoginTax2U1 = this.txt_login_tax2U;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginTax2U1.Margin = padding;
			this.txt_login_tax2U.Name = "txt_login_tax2U";
			this.txt_login_tax2U.ReadOnly = true;
			TextBox txtLoginTax2U2 = this.txt_login_tax2U;
			size = new System.Drawing.Size(67, 13);
			txtLoginTax2U2.Size = size;
			this.txt_login_tax2U.TabIndex = 211;
			this.txt_login_tax2U.WordWrap = false;
			this.Label_stCode.AutoSize = true;
			this.Label_stCode.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label_stCode.ForeColor = Color.DarkSlateBlue;
			Label labelStCode = this.Label_stCode;
			point = new Point(4, 256);
			labelStCode.Location = point;
			this.Label_stCode.Name = "Label_stCode";
			Label labelStCode1 = this.Label_stCode;
			size = new System.Drawing.Size(115, 15);
			labelStCode1.Size = size;
			this.Label_stCode.TabIndex = 190;
			this.Label_stCode.Text = "Administrative Code";
			this.txt_login_otherP.BackColor = Color.GhostWhite;
			this.txt_login_otherP.BorderStyle = BorderStyle.None;
			this.txt_login_otherP.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginOtherP = this.txt_login_otherP;
			point = new Point(319, 196);
			txtLoginOtherP.Location = point;
			TextBox txtLoginOtherP1 = this.txt_login_otherP;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginOtherP1.Margin = padding;
			this.txt_login_otherP.Name = "txt_login_otherP";
			this.txt_login_otherP.ReadOnly = true;
			TextBox txtLoginOtherP2 = this.txt_login_otherP;
			size = new System.Drawing.Size(77, 13);
			txtLoginOtherP2.Size = size;
			this.txt_login_otherP.TabIndex = 210;
			this.txt_login_otherP.WordWrap = false;
			this.txt_login_courtP.BackColor = Color.GhostWhite;
			this.txt_login_courtP.BorderStyle = BorderStyle.None;
			this.txt_login_courtP.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginCourtP = this.txt_login_courtP;
			point = new Point(319, 46);
			txtLoginCourtP.Location = point;
			TextBox txtLoginCourtP1 = this.txt_login_courtP;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginCourtP1.Margin = padding;
			this.txt_login_courtP.Name = "txt_login_courtP";
			this.txt_login_courtP.ReadOnly = true;
			TextBox txtLoginCourtP2 = this.txt_login_courtP;
			size = new System.Drawing.Size(77, 13);
			txtLoginCourtP2.Size = size;
			this.txt_login_courtP.TabIndex = 198;
			this.txt_login_courtP.WordWrap = false;
			this.txt_login_otherU.BackColor = Color.GhostWhite;
			this.txt_login_otherU.BorderStyle = BorderStyle.None;
			this.txt_login_otherU.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginOtherU = this.txt_login_otherU;
			point = new Point(246, 196);
			txtLoginOtherU.Location = point;
			TextBox txtLoginOtherU1 = this.txt_login_otherU;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginOtherU1.Margin = padding;
			this.txt_login_otherU.Name = "txt_login_otherU";
			this.txt_login_otherU.ReadOnly = true;
			TextBox txtLoginOtherU2 = this.txt_login_otherU;
			size = new System.Drawing.Size(67, 13);
			txtLoginOtherU2.Size = size;
			this.txt_login_otherU.TabIndex = 209;
			this.txt_login_otherU.WordWrap = false;
			this.Label_secState.AutoSize = true;
			this.Label_secState.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label_secState.ForeColor = Color.DarkSlateBlue;
			Label labelSecState = this.Label_secState;
			point = new Point(4, 241);
			labelSecState.Location = point;
			this.Label_secState.Name = "Label_secState";
			Label labelSecState1 = this.Label_secState;
			size = new System.Drawing.Size(96, 15);
			labelSecState1.Size = size;
			this.Label_secState.TabIndex = 190;
			this.Label_secState.Text = "LLC/Corp Search";
			this.txt_login_asrP.BackColor = Color.GhostWhite;
			this.txt_login_asrP.BorderStyle = BorderStyle.None;
			this.txt_login_asrP.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginAsrP = this.txt_login_asrP;
			point = new Point(319, 136);
			txtLoginAsrP.Location = point;
			TextBox txtLoginAsrP1 = this.txt_login_asrP;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginAsrP1.Margin = padding;
			this.txt_login_asrP.Name = "txt_login_asrP";
			this.txt_login_asrP.ReadOnly = true;
			TextBox txtLoginAsrP2 = this.txt_login_asrP;
			size = new System.Drawing.Size(77, 13);
			txtLoginAsrP2.Size = size;
			this.txt_login_asrP.TabIndex = 208;
			this.txt_login_asrP.WordWrap = false;
			this.txt_login_probateP.BackColor = Color.GhostWhite;
			this.txt_login_probateP.BorderStyle = BorderStyle.None;
			this.txt_login_probateP.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginProbateP = this.txt_login_probateP;
			point = new Point(319, 76);
			txtLoginProbateP.Location = point;
			TextBox txtLoginProbateP1 = this.txt_login_probateP;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginProbateP1.Margin = padding;
			this.txt_login_probateP.Name = "txt_login_probateP";
			this.txt_login_probateP.ReadOnly = true;
			TextBox txtLoginProbateP2 = this.txt_login_probateP;
			size = new System.Drawing.Size(77, 13);
			txtLoginProbateP2.Size = size;
			this.txt_login_probateP.TabIndex = 202;
			this.txt_login_probateP.WordWrap = false;
			this.txt_login_asrU.BackColor = Color.GhostWhite;
			this.txt_login_asrU.BorderStyle = BorderStyle.None;
			this.txt_login_asrU.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginAsrU = this.txt_login_asrU;
			point = new Point(246, 136);
			txtLoginAsrU.Location = point;
			TextBox txtLoginAsrU1 = this.txt_login_asrU;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginAsrU1.Margin = padding;
			this.txt_login_asrU.Name = "txt_login_asrU";
			this.txt_login_asrU.ReadOnly = true;
			TextBox txtLoginAsrU2 = this.txt_login_asrU;
			size = new System.Drawing.Size(67, 13);
			txtLoginAsrU2.Size = size;
			this.txt_login_asrU.TabIndex = 207;
			this.txt_login_asrU.WordWrap = false;
			this.txt_login_courtU.BackColor = Color.GhostWhite;
			this.txt_login_courtU.BorderStyle = BorderStyle.None;
			this.txt_login_courtU.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginCourtU = this.txt_login_courtU;
			point = new Point(246, 46);
			txtLoginCourtU.Location = point;
			TextBox txtLoginCourtU1 = this.txt_login_courtU;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginCourtU1.Margin = padding;
			this.txt_login_courtU.Name = "txt_login_courtU";
			this.txt_login_courtU.ReadOnly = true;
			TextBox txtLoginCourtU2 = this.txt_login_courtU;
			size = new System.Drawing.Size(67, 13);
			txtLoginCourtU2.Size = size;
			this.txt_login_courtU.TabIndex = 197;
			this.txt_login_courtU.WordWrap = false;
			this.txt_login_tax1P.BackColor = Color.GhostWhite;
			this.txt_login_tax1P.BorderStyle = BorderStyle.None;
			this.txt_login_tax1P.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginTax1P = this.txt_login_tax1P;
			point = new Point(319, 121);
			txtLoginTax1P.Location = point;
			TextBox txtLoginTax1P1 = this.txt_login_tax1P;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginTax1P1.Margin = padding;
			this.txt_login_tax1P.Name = "txt_login_tax1P";
			this.txt_login_tax1P.ReadOnly = true;
			TextBox txtLoginTax1P2 = this.txt_login_tax1P;
			size = new System.Drawing.Size(77, 13);
			txtLoginTax1P2.Size = size;
			this.txt_login_tax1P.TabIndex = 206;
			this.txt_login_tax1P.WordWrap = false;
			this.txt_login_muniP.BackColor = Color.GhostWhite;
			this.txt_login_muniP.BorderStyle = BorderStyle.None;
			this.txt_login_muniP.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginMuniP = this.txt_login_muniP;
			point = new Point(319, 91);
			txtLoginMuniP.Location = point;
			TextBox txtLoginMuniP1 = this.txt_login_muniP;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginMuniP1.Margin = padding;
			this.txt_login_muniP.Name = "txt_login_muniP";
			this.txt_login_muniP.ReadOnly = true;
			TextBox txtLoginMuniP2 = this.txt_login_muniP;
			size = new System.Drawing.Size(77, 13);
			txtLoginMuniP2.Size = size;
			this.txt_login_muniP.TabIndex = 204;
			this.txt_login_muniP.WordWrap = false;
			this.txt_login_tax1U.BackColor = Color.GhostWhite;
			this.txt_login_tax1U.BorderStyle = BorderStyle.None;
			this.txt_login_tax1U.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginTax1U = this.txt_login_tax1U;
			point = new Point(246, 121);
			txtLoginTax1U.Location = point;
			TextBox txtLoginTax1U1 = this.txt_login_tax1U;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginTax1U1.Margin = padding;
			this.txt_login_tax1U.Name = "txt_login_tax1U";
			this.txt_login_tax1U.ReadOnly = true;
			TextBox txtLoginTax1U2 = this.txt_login_tax1U;
			size = new System.Drawing.Size(67, 13);
			txtLoginTax1U2.Size = size;
			this.txt_login_tax1U.TabIndex = 205;
			this.txt_login_tax1U.WordWrap = false;
			this.txt_login_probateU.BackColor = Color.GhostWhite;
			this.txt_login_probateU.BorderStyle = BorderStyle.None;
			this.txt_login_probateU.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginProbateU = this.txt_login_probateU;
			point = new Point(246, 76);
			txtLoginProbateU.Location = point;
			TextBox txtLoginProbateU1 = this.txt_login_probateU;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginProbateU1.Margin = padding;
			this.txt_login_probateU.Name = "txt_login_probateU";
			this.txt_login_probateU.ReadOnly = true;
			TextBox txtLoginProbateU2 = this.txt_login_probateU;
			size = new System.Drawing.Size(67, 13);
			txtLoginProbateU2.Size = size;
			this.txt_login_probateU.TabIndex = 201;
			this.txt_login_probateU.WordWrap = false;
			this.txt_login_muniU.BackColor = Color.GhostWhite;
			this.txt_login_muniU.BorderStyle = BorderStyle.None;
			this.txt_login_muniU.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginMuniU = this.txt_login_muniU;
			point = new Point(246, 91);
			txtLoginMuniU.Location = point;
			TextBox txtLoginMuniU1 = this.txt_login_muniU;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginMuniU1.Margin = padding;
			this.txt_login_muniU.Name = "txt_login_muniU";
			this.txt_login_muniU.ReadOnly = true;
			TextBox txtLoginMuniU2 = this.txt_login_muniU;
			size = new System.Drawing.Size(67, 13);
			txtLoginMuniU2.Size = size;
			this.txt_login_muniU.TabIndex = 203;
			this.txt_login_muniU.WordWrap = false;
			this.txt_login_prothonP.BackColor = Color.GhostWhite;
			this.txt_login_prothonP.BorderStyle = BorderStyle.None;
			this.txt_login_prothonP.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginProthonP = this.txt_login_prothonP;
			point = new Point(319, 61);
			txtLoginProthonP.Location = point;
			TextBox txtLoginProthonP1 = this.txt_login_prothonP;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginProthonP1.Margin = padding;
			this.txt_login_prothonP.Name = "txt_login_prothonP";
			this.txt_login_prothonP.ReadOnly = true;
			TextBox txtLoginProthonP2 = this.txt_login_prothonP;
			size = new System.Drawing.Size(77, 13);
			txtLoginProthonP2.Size = size;
			this.txt_login_prothonP.TabIndex = 200;
			this.txt_login_prothonP.WordWrap = false;
			this.txt_login_landP.BackColor = Color.GhostWhite;
			this.txt_login_landP.BorderStyle = BorderStyle.None;
			this.txt_login_landP.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginLandP = this.txt_login_landP;
			point = new Point(319, 16);
			txtLoginLandP.Location = point;
			TextBox txtLoginLandP1 = this.txt_login_landP;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginLandP1.Margin = padding;
			this.txt_login_landP.Name = "txt_login_landP";
			this.txt_login_landP.ReadOnly = true;
			TextBox txtLoginLandP2 = this.txt_login_landP;
			size = new System.Drawing.Size(77, 13);
			txtLoginLandP2.Size = size;
			this.txt_login_landP.TabIndex = 196;
			this.txt_login_landP.WordWrap = false;
			this.txt_login_prothonU.BackColor = Color.GhostWhite;
			this.txt_login_prothonU.BorderStyle = BorderStyle.None;
			this.txt_login_prothonU.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginProthonU = this.txt_login_prothonU;
			point = new Point(246, 61);
			txtLoginProthonU.Location = point;
			TextBox txtLoginProthonU1 = this.txt_login_prothonU;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginProthonU1.Margin = padding;
			this.txt_login_prothonU.Name = "txt_login_prothonU";
			this.txt_login_prothonU.ReadOnly = true;
			TextBox txtLoginProthonU2 = this.txt_login_prothonU;
			size = new System.Drawing.Size(67, 13);
			txtLoginProthonU2.Size = size;
			this.txt_login_prothonU.TabIndex = 199;
			this.txt_login_prothonU.WordWrap = false;
			this.LabelOtherURL.AutoSize = true;
			this.LabelOtherURL.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelOtherURL.ForeColor = Color.DarkSlateBlue;
			Label labelOtherURL = this.LabelOtherURL;
			point = new Point(4, 196);
			labelOtherURL.Location = point;
			this.LabelOtherURL.Name = "LabelOtherURL";
			Label labelOtherURL1 = this.LabelOtherURL;
			size = new System.Drawing.Size(82, 13);
			labelOtherURL1.Size = size;
			this.LabelOtherURL.TabIndex = 61;
			this.LabelOtherURL.Text = "Other Website";
			this.txt_login_landU.BackColor = Color.GhostWhite;
			this.txt_login_landU.BorderStyle = BorderStyle.None;
			this.txt_login_landU.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextBox txtLoginLandU = this.txt_login_landU;
			point = new Point(246, 16);
			txtLoginLandU.Location = point;
			TextBox txtLoginLandU1 = this.txt_login_landU;
			padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			txtLoginLandU1.Margin = padding;
			this.txt_login_landU.Name = "txt_login_landU";
			this.txt_login_landU.ReadOnly = true;
			TextBox txtLoginLandU2 = this.txt_login_landU;
			size = new System.Drawing.Size(67, 13);
			txtLoginLandU2.Size = size;
			this.txt_login_landU.TabIndex = 195;
			this.txt_login_landU.WordWrap = false;
			this.LabelCountyURL.AutoSize = true;
			this.LabelCountyURL.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelCountyURL.ForeColor = Color.DarkSlateBlue;
			Label labelCountyURL = this.LabelCountyURL;
			point = new Point(4, 16);
			labelCountyURL.Location = point;
			this.LabelCountyURL.Name = "LabelCountyURL";
			Label labelCountyURL1 = this.LabelCountyURL;
			size = new System.Drawing.Size(64, 15);
			labelCountyURL1.Size = size;
			this.LabelCountyURL.TabIndex = 11;
			this.LabelCountyURL.Text = "Land Index";
			this.LinkLabelOtherTax.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelOtherTax.AutoSize = true;
			this.LinkLabelOtherTax.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelOtherTax.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelOtherTax.ForeColor = Color.DarkViolet;
			this.LinkLabelOtherTax.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelOtherTax.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelOtherTax = this.LinkLabelOtherTax;
			point = new Point(125, 211);
			linkLabelOtherTax.Location = point;
			this.LinkLabelOtherTax.Name = "LinkLabelOtherTax";
			LinkLabel linkLabelOtherTax1 = this.LinkLabelOtherTax;
			size = new System.Drawing.Size(41, 15);
			linkLabelOtherTax1.Size = size;
			this.LinkLabelOtherTax.TabIndex = 54;
			this.LinkLabelOtherTax.TabStop = true;
			this.LinkLabelOtherTax.Text = "TAXES";
			this.LinkLabelOtherTax.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabelSheriff.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelSheriff.AutoSize = true;
			this.LinkLabelSheriff.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelSheriff.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelSheriff.ForeColor = Color.DarkViolet;
			this.LinkLabelSheriff.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelSheriff.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelSheriff = this.LinkLabelSheriff;
			point = new Point(125, 166);
			linkLabelSheriff.Location = point;
			this.LinkLabelSheriff.Name = "LinkLabelSheriff";
			LinkLabel linkLabelSheriff1 = this.LinkLabelSheriff;
			size = new System.Drawing.Size(50, 15);
			linkLabelSheriff1.Size = size;
			this.LinkLabelSheriff.TabIndex = 56;
			this.LinkLabelSheriff.TabStop = true;
			this.LinkLabelSheriff.Text = "SHERIFF";
			this.LinkLabelSheriff.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelUCC.AutoSize = true;
			this.LabelUCC.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelUCC.ForeColor = Color.DarkSlateBlue;
			Label labelUCC = this.LabelUCC;
			point = new Point(4, 226);
			labelUCC.Location = point;
			this.LabelUCC.Name = "LabelUCC";
			Label labelUCC1 = this.LabelUCC;
			size = new System.Drawing.Size(68, 15);
			labelUCC1.Size = size;
			this.LabelUCC.TabIndex = 194;
			this.LabelUCC.Text = "UCC Filings";
			this.txtComments.BackColor = Color.GhostWhite;
			this.txtComments.BorderStyle = BorderStyle.None;
			this.TableLayoutPanel2.SetColumnSpan(this.txtComments, 4);
			this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtComments.ForeColor = Color.Purple;
			TextBox textBox5 = this.txtComments;
			point = new Point(4, 289);
			textBox5.Location = point;
			this.txtComments.MaxLength = 100000;
			this.txtComments.Multiline = true;
			this.txtComments.Name = "txtComments";
			this.txtComments.ReadOnly = true;
			this.txtComments.ScrollBars = ScrollBars.Vertical;
			TextBox textBox6 = this.txtComments;
			size = new System.Drawing.Size(392, 75);
			textBox6.Size = size;
			this.txtComments.TabIndex = 47;
			this.txtComments.Text = "Comments";
			this.LinkLabelCounty.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelCounty.AutoSize = true;
			this.LinkLabelCounty.BackColor = Color.Transparent;
			this.LinkLabelCounty.DisabledLinkColor = Color.Navy;
			this.LinkLabelCounty.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelCounty.ForeColor = Color.DarkViolet;
			this.LinkLabelCounty.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelCounty.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelCounty = this.LinkLabelCounty;
			point = new Point(125, 16);
			linkLabelCounty.Location = point;
			this.LinkLabelCounty.Name = "LinkLabelCounty";
			LinkLabel linkLabelCounty1 = this.LinkLabelCounty;
			size = new System.Drawing.Size(38, 15);
			linkLabelCounty1.Size = size;
			this.LinkLabelCounty.TabIndex = 5;
			this.LinkLabelCounty.TabStop = true;
			this.LinkLabelCounty.Text = "LAND";
			this.LinkLabelCounty.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelOtherTax.AutoSize = true;
			this.LabelOtherTax.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelOtherTax.ForeColor = Color.DarkSlateBlue;
			Label labelOtherTax = this.LabelOtherTax;
			point = new Point(4, 211);
			labelOtherTax.Location = point;
			this.LabelOtherTax.Name = "LabelOtherTax";
			Label labelOtherTax1 = this.LabelOtherTax;
			size = new System.Drawing.Size(85, 15);
			labelOtherTax1.Size = size;
			this.LabelOtherTax.TabIndex = 55;
			this.LabelOtherTax.Text = "Other Tax Web";
			this.LinkLabelForeclosure.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelForeclosure.AutoSize = true;
			this.LinkLabelForeclosure.BackColor = Color.Transparent;
			this.LinkLabelForeclosure.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelForeclosure.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelForeclosure.ForeColor = Color.DarkViolet;
			this.LinkLabelForeclosure.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelForeclosure.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelForeclosure = this.LinkLabelForeclosure;
			point = new Point(125, 181);
			linkLabelForeclosure.Location = point;
			this.LinkLabelForeclosure.Name = "LinkLabelForeclosure";
			LinkLabel linkLabelForeclosure1 = this.LinkLabelForeclosure;
			size = new System.Drawing.Size(85, 15);
			linkLabelForeclosure1.Size = size;
			this.LinkLabelForeclosure.TabIndex = 48;
			this.LinkLabelForeclosure.TabStop = true;
			this.LinkLabelForeclosure.Text = "FORECLOSURE";
			this.LinkLabelForeclosure.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelCourt.AutoSize = true;
			this.LabelCourt.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelCourt.ForeColor = Color.DarkSlateBlue;
			Label labelCourt = this.LabelCourt;
			point = new Point(4, 46);
			labelCourt.Location = point;
			this.LabelCourt.Name = "LabelCourt";
			Label labelCourt1 = this.LabelCourt;
			size = new System.Drawing.Size(68, 15);
			labelCourt1.Size = size;
			this.LabelCourt.TabIndex = 12;
			this.LabelCourt.Text = "Court Index";
			this.LinkLabelMuniCourt.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelMuniCourt.AutoSize = true;
			this.LinkLabelMuniCourt.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelMuniCourt.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelMuniCourt.ForeColor = Color.DarkViolet;
			this.LinkLabelMuniCourt.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelMuniCourt.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelMuniCourt = this.LinkLabelMuniCourt;
			point = new Point(125, 91);
			linkLabelMuniCourt.Location = point;
			this.LinkLabelMuniCourt.Name = "LinkLabelMuniCourt";
			LinkLabel linkLabelMuniCourt1 = this.LinkLabelMuniCourt;
			size = new System.Drawing.Size(112, 15);
			linkLabelMuniCourt1.Size = size;
			this.LinkLabelMuniCourt.TabIndex = 52;
			this.LinkLabelMuniCourt.TabStop = true;
			this.LinkLabelMuniCourt.Text = "MUNICIPAL COURT";
			this.LinkLabelMuniCourt.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelForeclosures.AutoSize = true;
			this.LabelForeclosures.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelForeclosures.ForeColor = Color.DarkSlateBlue;
			Label labelForeclosures = this.LabelForeclosures;
			point = new Point(4, 181);
			labelForeclosures.Location = point;
			this.LabelForeclosures.Name = "LabelForeclosures";
			Label labelForeclosures1 = this.LabelForeclosures;
			size = new System.Drawing.Size(73, 15);
			labelForeclosures1.Size = size;
			this.LabelForeclosures.TabIndex = 49;
			this.LabelForeclosures.Text = "Foreclosures";
			this.LinkLabelMaps.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelMaps.AutoSize = true;
			this.LinkLabelMaps.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelMaps.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelMaps.ForeColor = Color.DarkViolet;
			this.LinkLabelMaps.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelMaps.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelMaps = this.LinkLabelMaps;
			point = new Point(125, 151);
			linkLabelMaps.Location = point;
			this.LinkLabelMaps.Name = "LinkLabelMaps";
			LinkLabel linkLabelMaps1 = this.LinkLabelMaps;
			size = new System.Drawing.Size(39, 15);
			linkLabelMaps1.Size = size;
			this.LinkLabelMaps.TabIndex = 9;
			this.LinkLabelMaps.TabStop = true;
			this.LinkLabelMaps.Text = "MAPS";
			this.LinkLabelMaps.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelSheriff.AutoSize = true;
			this.LabelSheriff.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelSheriff.ForeColor = Color.DarkSlateBlue;
			Label labelSheriff = this.LabelSheriff;
			point = new Point(4, 166);
			labelSheriff.Location = point;
			this.LabelSheriff.Name = "LabelSheriff";
			Label labelSheriff1 = this.LabelSheriff;
			size = new System.Drawing.Size(76, 15);
			labelSheriff1.Size = size;
			this.LabelSheriff.TabIndex = 51;
			this.LabelSheriff.Text = "Sheriff's Web";
			this.LinkLabelAssessor.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelAssessor.AutoSize = true;
			this.LinkLabelAssessor.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelAssessor.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelAssessor.ForeColor = Color.DarkViolet;
			this.LinkLabelAssessor.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelAssessor.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelAssessor = this.LinkLabelAssessor;
			point = new Point(125, 136);
			linkLabelAssessor.Location = point;
			this.LinkLabelAssessor.Name = "LinkLabelAssessor";
			LinkLabel linkLabelAssessor1 = this.LinkLabelAssessor;
			size = new System.Drawing.Size(61, 15);
			linkLabelAssessor1.Size = size;
			this.LinkLabelAssessor.TabIndex = 7;
			this.LinkLabelAssessor.TabStop = true;
			this.LinkLabelAssessor.Text = "ASSESSOR";
			this.LinkLabelAssessor.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabelTax.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelTax.AutoSize = true;
			this.LinkLabelTax.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelTax.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelTax.ForeColor = Color.DarkViolet;
			this.LinkLabelTax.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelTax.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelTax = this.LinkLabelTax;
			point = new Point(125, 121);
			linkLabelTax.Location = point;
			this.LinkLabelTax.Name = "LinkLabelTax";
			LinkLabel linkLabelTax1 = this.LinkLabelTax;
			size = new System.Drawing.Size(41, 15);
			linkLabelTax1.Size = size;
			this.LinkLabelTax.TabIndex = 6;
			this.LinkLabelTax.TabStop = true;
			this.LinkLabelTax.Text = "TAXES";
			this.LinkLabelTax.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelMapsGIS.AutoSize = true;
			this.LabelMapsGIS.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelMapsGIS.ForeColor = Color.DarkSlateBlue;
			Label labelMapsGIS = this.LabelMapsGIS;
			point = new Point(4, 151);
			labelMapsGIS.Location = point;
			this.LabelMapsGIS.Name = "LabelMapsGIS";
			Label labelMapsGIS1 = this.LabelMapsGIS;
			size = new System.Drawing.Size(58, 15);
			labelMapsGIS1.Size = size;
			this.LabelMapsGIS.TabIndex = 22;
			this.LabelMapsGIS.Text = "Maps/GIS";
			this.LinkLabelCoHome.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelCoHome.AutoSize = true;
			this.LinkLabelCoHome.BackColor = Color.Transparent;
			this.LinkLabelCoHome.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelCoHome.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelCoHome.ForeColor = Color.DarkViolet;
			this.LinkLabelCoHome.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelCoHome.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelCoHome = this.LinkLabelCoHome;
			point = new Point(125, 106);
			linkLabelCoHome.Location = point;
			this.LinkLabelCoHome.Name = "LinkLabelCoHome";
			LinkLabel linkLabelCoHome1 = this.LinkLabelCoHome;
			size = new System.Drawing.Size(93, 15);
			linkLabelCoHome1.Size = size;
			this.LinkLabelCoHome.TabIndex = 25;
			this.LinkLabelCoHome.TabStop = true;
			this.LinkLabelCoHome.Text = "COUNTY HOME";
			this.LinkLabelCoHome.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabelCourt.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelCourt.AutoSize = true;
			this.LinkLabelCourt.BackColor = Color.Transparent;
			this.LinkLabelCourt.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelCourt.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelCourt.ForeColor = Color.DarkViolet;
			this.LinkLabelCourt.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelCourt.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelCourt = this.LinkLabelCourt;
			point = new Point(125, 46);
			linkLabelCourt.Location = point;
			this.LinkLabelCourt.Name = "LinkLabelCourt";
			LinkLabel linkLabelCourt1 = this.LinkLabelCourt;
			size = new System.Drawing.Size(46, 15);
			linkLabelCourt1.Size = size;
			this.LinkLabelCourt.TabIndex = 10;
			this.LinkLabelCourt.TabStop = true;
			this.LinkLabelCourt.Text = "COURT";
			this.LinkLabelCourt.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelProthon.AutoSize = true;
			this.LabelProthon.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelProthon.ForeColor = Color.DarkSlateBlue;
			Label labelProthon = this.LabelProthon;
			point = new Point(4, 61);
			labelProthon.Location = point;
			this.LabelProthon.Name = "LabelProthon";
			Label labelProthon1 = this.LabelProthon;
			size = new System.Drawing.Size(50, 15);
			labelProthon1.Size = size;
			this.LabelProthon.TabIndex = 15;
			this.LabelProthon.Text = "Prothon";
			this.LabelAssessor.AutoSize = true;
			this.LabelAssessor.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelAssessor.ForeColor = Color.DarkSlateBlue;
			Label labelAssessor = this.LabelAssessor;
			point = new Point(4, 136);
			labelAssessor.Location = point;
			this.LabelAssessor.Name = "LabelAssessor";
			Label labelAssessor1 = this.LabelAssessor;
			size = new System.Drawing.Size(52, 15);
			labelAssessor1.Size = size;
			this.LabelAssessor.TabIndex = 14;
			this.LabelAssessor.Text = "Assessor";
			this.LinkLabelProthon.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelProthon.AutoSize = true;
			this.LinkLabelProthon.BackColor = Color.Transparent;
			this.LinkLabelProthon.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelProthon.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelProthon.ForeColor = Color.DarkViolet;
			this.LinkLabelProthon.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelProthon.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelProthon = this.LinkLabelProthon;
			point = new Point(125, 61);
			linkLabelProthon.Location = point;
			this.LinkLabelProthon.Name = "LinkLabelProthon";
			LinkLabel linkLabelProthon1 = this.LinkLabelProthon;
			size = new System.Drawing.Size(102, 15);
			linkLabelProthon1.Size = size;
			this.LinkLabelProthon.TabIndex = 8;
			this.LinkLabelProthon.TabStop = true;
			this.LinkLabelProthon.Text = "PROTHONOTARY";
			this.LinkLabelProthon.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelCountyTax.AutoSize = true;
			this.LabelCountyTax.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelCountyTax.ForeColor = Color.DarkSlateBlue;
			Label labelCountyTax = this.LabelCountyTax;
			point = new Point(4, 121);
			labelCountyTax.Location = point;
			this.LabelCountyTax.Name = "LabelCountyTax";
			Label labelCountyTax1 = this.LabelCountyTax;
			size = new System.Drawing.Size(78, 15);
			labelCountyTax1.Size = size;
			this.LabelCountyTax.TabIndex = 13;
			this.LabelCountyTax.Text = "County Taxes";
			this.LinkLabelProbate.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelProbate.AutoSize = true;
			this.LinkLabelProbate.BackColor = Color.Transparent;
			this.LinkLabelProbate.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabelProbate.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelProbate.ForeColor = Color.DarkViolet;
			this.LinkLabelProbate.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelProbate.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelProbate = this.LinkLabelProbate;
			point = new Point(125, 76);
			linkLabelProbate.Location = point;
			this.LinkLabelProbate.Name = "LinkLabelProbate";
			LinkLabel linkLabelProbate1 = this.LinkLabelProbate;
			size = new System.Drawing.Size(58, 15);
			linkLabelProbate1.Size = size;
			this.LinkLabelProbate.TabIndex = 23;
			this.LinkLabelProbate.TabStop = true;
			this.LinkLabelProbate.Text = "PROBATE";
			this.LinkLabelProbate.VisitedLinkColor = Color.DarkSlateBlue;
			this.LabelCountyHome.AutoSize = true;
			this.LabelCountyHome.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelCountyHome.ForeColor = Color.DarkSlateBlue;
			Label labelCountyHome = this.LabelCountyHome;
			point = new Point(4, 106);
			labelCountyHome.Location = point;
			this.LabelCountyHome.Name = "LabelCountyHome";
			Label labelCountyHome1 = this.LabelCountyHome;
			size = new System.Drawing.Size(111, 15);
			labelCountyHome1.Size = size;
			this.LabelCountyHome.TabIndex = 26;
			this.LabelCountyHome.Text = "County Home Page";
			this.LabelMuniCourt.AutoSize = true;
			this.LabelMuniCourt.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelMuniCourt.ForeColor = Color.DarkSlateBlue;
			Label labelMuniCourt = this.LabelMuniCourt;
			point = new Point(4, 91);
			labelMuniCourt.Location = point;
			this.LabelMuniCourt.Name = "LabelMuniCourt";
			Label labelMuniCourt1 = this.LabelMuniCourt;
			size = new System.Drawing.Size(93, 15);
			labelMuniCourt1.Size = size;
			this.LabelMuniCourt.TabIndex = 53;
			this.LabelMuniCourt.Text = "Municipal Court";
			this.LabelProbate.AutoSize = true;
			this.LabelProbate.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelProbate.ForeColor = Color.DarkSlateBlue;
			Label labelProbate = this.LabelProbate;
			point = new Point(4, 76);
			labelProbate.Location = point;
			this.LabelProbate.Name = "LabelProbate";
			Label labelProbate1 = this.LabelProbate;
			size = new System.Drawing.Size(81, 15);
			labelProbate1.Size = size;
			this.LabelProbate.TabIndex = 24;
			this.LabelProbate.Text = "Probate Court";
			this.Label_user.AutoSize = true;
			Label labelUser = this.Label_user;
			point = new Point(243, 1);
			labelUser.Location = point;
			this.Label_user.Name = "Label_user";
			Label labelUser1 = this.Label_user;
			size = new System.Drawing.Size(64, 15);
			labelUser1.Size = size;
			this.Label_user.TabIndex = 58;
			this.Label_user.Text = "Username";
			this.Label_pwd.AutoSize = true;
			Label labelPwd = this.Label_pwd;
			point = new Point(316, 1);
			labelPwd.Location = point;
			this.Label_pwd.Name = "Label_pwd";
			Label labelPwd1 = this.Label_pwd;
			size = new System.Drawing.Size(59, 15);
			labelPwd1.Size = size;
			this.Label_pwd.TabIndex = 59;
			this.Label_pwd.Text = "Password";
			this.LinkLabelPlats.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabelPlats.AutoSize = true;
			this.LinkLabelPlats.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabelPlats.ForeColor = Color.DarkViolet;
			this.LinkLabelPlats.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabelPlats.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelPlats = this.LinkLabelPlats;
			point = new Point(243, 151);
			linkLabelPlats.Location = point;
			this.LinkLabelPlats.Name = "LinkLabelPlats";
			LinkLabel linkLabelPlats1 = this.LinkLabelPlats;
			size = new System.Drawing.Size(41, 15);
			linkLabelPlats1.Size = size;
			this.LinkLabelPlats.TabIndex = 60;
			this.LinkLabelPlats.TabStop = true;
			this.LinkLabelPlats.Text = "PLATS";
			this.LinkLabelPlats.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_OtherURL.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabel_OtherURL.AutoSize = true;
			this.LinkLabel_OtherURL.BackColor = Color.Transparent;
			this.LinkLabel_OtherURL.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_OtherURL.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel_OtherURL.ForeColor = Color.DarkViolet;
			this.LinkLabel_OtherURL.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabel_OtherURL.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelOtherURL = this.LinkLabel_OtherURL;
			point = new Point(125, 196);
			linkLabelOtherURL.Location = point;
			this.LinkLabel_OtherURL.Name = "LinkLabel_OtherURL";
			LinkLabel linkLabelOtherURL1 = this.LinkLabel_OtherURL;
			size = new System.Drawing.Size(69, 15);
			linkLabelOtherURL1.Size = size;
			this.LinkLabel_OtherURL.TabIndex = 62;
			this.LinkLabel_OtherURL.TabStop = true;
			this.LinkLabel_OtherURL.Text = "OTHER URL";
			this.LinkLabel_OtherURL.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_UCC.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabel_UCC.AutoSize = true;
			this.LinkLabel_UCC.BackColor = Color.Transparent;
			this.LinkLabel_UCC.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_UCC.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel_UCC.ForeColor = Color.DarkViolet;
			this.LinkLabel_UCC.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabel_UCC.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelUCC = this.LinkLabel_UCC;
			point = new Point(125, 226);
			linkLabelUCC.Location = point;
			this.LinkLabel_UCC.Name = "LinkLabel_UCC";
			LinkLabel linkLabelUCC1 = this.LinkLabel_UCC;
			size = new System.Drawing.Size(78, 15);
			linkLabelUCC1.Size = size;
			this.LinkLabel_UCC.TabIndex = 190;
			this.LinkLabel_UCC.TabStop = true;
			this.LinkLabel_UCC.Text = "UCC SEARCH";
			this.LinkLabel_UCC.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_SecState.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabel_SecState.AutoSize = true;
			this.LinkLabel_SecState.BackColor = Color.Transparent;
			this.LinkLabel_SecState.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_SecState.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel_SecState.ForeColor = Color.DarkViolet;
			this.LinkLabel_SecState.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabel_SecState.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelSecState = this.LinkLabel_SecState;
			point = new Point(125, 241);
			linkLabelSecState.Location = point;
			this.LinkLabel_SecState.Name = "LinkLabel_SecState";
			LinkLabel linkLabelSecState1 = this.LinkLabel_SecState;
			size = new System.Drawing.Size(99, 15);
			linkLabelSecState1.Size = size;
			this.LinkLabel_SecState.TabIndex = 191;
			this.LinkLabel_SecState.TabStop = true;
			this.LinkLabel_SecState.Text = "SECT'Y OF STATE";
			this.LinkLabel_SecState.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_State_Code.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabel_State_Code.AutoSize = true;
			this.LinkLabel_State_Code.BackColor = Color.Transparent;
			this.LinkLabel_State_Code.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_State_Code.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel_State_Code.ForeColor = Color.DarkViolet;
			this.LinkLabel_State_Code.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabel_State_Code.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelStateCode = this.LinkLabel_State_Code;
			point = new Point(125, 256);
			linkLabelStateCode.Location = point;
			this.LinkLabel_State_Code.Name = "LinkLabel_State_Code";
			LinkLabel linkLabelStateCode1 = this.LinkLabel_State_Code;
			size = new System.Drawing.Size(75, 15);
			linkLabelStateCode1.Size = size;
			this.LinkLabel_State_Code.TabIndex = 192;
			this.LinkLabel_State_Code.TabStop = true;
			this.LinkLabel_State_Code.Text = "STATE CODE";
			this.LinkLabel_State_Code.VisitedLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_DeptIns.ActiveLinkColor = Color.GhostWhite;
			this.LinkLabel_DeptIns.AutoSize = true;
			this.LinkLabel_DeptIns.BackColor = Color.Transparent;
			this.LinkLabel_DeptIns.DisabledLinkColor = Color.DarkSlateBlue;
			this.LinkLabel_DeptIns.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel_DeptIns.ForeColor = Color.DarkViolet;
			this.LinkLabel_DeptIns.LinkBehavior = LinkBehavior.HoverUnderline;
			this.LinkLabel_DeptIns.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabelDeptIns = this.LinkLabel_DeptIns;
			point = new Point(125, 271);
			linkLabelDeptIns.Location = point;
			this.LinkLabel_DeptIns.Name = "LinkLabel_DeptIns";
			LinkLabel linkLabelDeptIns1 = this.LinkLabel_DeptIns;
			size = new System.Drawing.Size(74, 15);
			linkLabelDeptIns1.Size = size;
			this.LinkLabel_DeptIns.TabIndex = 193;
			this.LinkLabel_DeptIns.TabStop = true;
			this.LinkLabel_DeptIns.Text = "DEPT OF INS";
			this.LinkLabel_DeptIns.VisitedLinkColor = Color.DarkSlateBlue;
			this.GroupBox4.BackColor = Color.GhostWhite;
			this.GroupBox4.Controls.Add(this.LabelUseIns);
			this.GroupBox4.Controls.Add(this.LabelUseProps);
			this.GroupBox4.Controls.Add(this.LabelUseCopy);
			this.GroupBox4.Controls.Add(this.Label20);
			this.GroupBox4.Controls.Add(this.Label15);
			this.GroupBox4.Controls.Add(this.Label28);
			this.GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.GroupBox4.ForeColor = Color.FromArgb(64, 64, 64);
			GroupBox groupBox4 = this.GroupBox4;
			point = new Point(438, 3);
			groupBox4.Location = point;
			this.GroupBox4.Name = "GroupBox4";
			GroupBox groupBox41 = this.GroupBox4;
			size = new System.Drawing.Size(143, 77);
			groupBox41.Size = size;
			this.GroupBox4.TabIndex = 182;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "PRODUCTS ONLINE";
			this.LabelUseIns.AutoSize = true;
			this.LabelUseIns.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelUseIns.ForeColor = Color.Black;
			Label labelUseIns = this.LabelUseIns;
			point = new Point(76, 22);
			labelUseIns.Location = point;
			this.LabelUseIns.Name = "LabelUseIns";
			Label labelUseIns1 = this.LabelUseIns;
			size = new System.Drawing.Size(12, 15);
			labelUseIns1.Size = size;
			this.LabelUseIns.TabIndex = 67;
			this.LabelUseIns.Text = "*";
			this.LabelUseProps.AutoSize = true;
			this.LabelUseProps.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelUseProps.ForeColor = Color.Black;
			Label labelUseProps = this.LabelUseProps;
			point = new Point(76, 37);
			labelUseProps.Location = point;
			this.LabelUseProps.Name = "LabelUseProps";
			Label labelUseProps1 = this.LabelUseProps;
			size = new System.Drawing.Size(12, 15);
			labelUseProps1.Size = size;
			this.LabelUseProps.TabIndex = 66;
			this.LabelUseProps.Text = "*";
			this.LabelUseCopy.AutoSize = true;
			this.LabelUseCopy.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelUseCopy.ForeColor = Color.Black;
			Label labelUseCopy = this.LabelUseCopy;
			point = new Point(76, 52);
			labelUseCopy.Location = point;
			this.LabelUseCopy.Name = "LabelUseCopy";
			Label labelUseCopy1 = this.LabelUseCopy;
			size = new System.Drawing.Size(12, 15);
			labelUseCopy1.Size = size;
			this.LabelUseCopy.TabIndex = 65;
			this.LabelUseCopy.Text = "*";
			this.Label20.AutoSize = true;
			this.Label20.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label20.ForeColor = Color.DarkSlateBlue;
			Label label20 = this.Label20;
			point = new Point(6, 37);
			label20.Location = point;
			this.Label20.Name = "Label20";
			Label label201 = this.Label20;
			size = new System.Drawing.Size(64, 15);
			label201.Size = size;
			this.Label20.TabIndex = 64;
			this.Label20.Text = "Prop Repts";
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label15.ForeColor = Color.DarkSlateBlue;
			Label label15 = this.Label15;
			point = new Point(6, 22);
			label15.Location = point;
			this.Label15.Name = "Label15";
			Label label151 = this.Label15;
			size = new System.Drawing.Size(58, 15);
			label151.Size = size;
			this.Label15.TabIndex = 63;
			this.Label15.Text = "Insurance";
			this.Label28.AutoSize = true;
			this.Label28.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label28.ForeColor = Color.DarkSlateBlue;
			Label label28 = this.Label28;
			point = new Point(6, 52);
			label28.Location = point;
			this.Label28.Name = "Label28";
			Label label281 = this.Label28;
			size = new System.Drawing.Size(67, 15);
			label281.Size = size;
			this.Label28.TabIndex = 62;
			this.Label28.Text = "Doc Copies";
			this.GroupBox3.BackColor = Color.GhostWhite;
			this.GroupBox3.Controls.Add(this.Label4Tap);
			this.GroupBox3.Controls.Add(this.Label5dtree);
			this.GroupBox3.Controls.Add(this.Label6RV);
			this.GroupBox3.Controls.Add(this.LinkLabel10);
			this.GroupBox3.Controls.Add(this.LinkLabel9);
			this.GroupBox3.Controls.Add(this.LinkLabel16);
			this.GroupBox3.Controls.Add(this.LabelUseTap);
			this.GroupBox3.Controls.Add(this.LabelUseDtree);
			this.GroupBox3.Controls.Add(this.LabelUseRV);
			this.GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.GroupBox3.ForeColor = Color.FromArgb(64, 64, 64);
			GroupBox groupBox3 = this.GroupBox3;
			point = new Point(592, 3);
			groupBox3.Location = point;
			this.GroupBox3.Name = "GroupBox3";
			GroupBox groupBox31 = this.GroupBox3;
			size = new System.Drawing.Size(225, 77);
			groupBox31.Size = size;
			this.GroupBox3.TabIndex = 181;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "3rd PARTY VENDORS";
			this.Label4Tap.AutoSize = true;
			this.Label4Tap.Font = new System.Drawing.Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label4Tap.ForeColor = Color.Black;
			Label label4Tap = this.Label4Tap;
			point = new Point(138, 25);
			label4Tap.Location = point;
			this.Label4Tap.Name = "Label4Tap";
			Label label4Tap1 = this.Label4Tap;
			size = new System.Drawing.Size(59, 12);
			label4Tap1.Size = size;
			this.Label4Tap.TabIndex = 65;
			this.Label4Tap.Text = "MORE INFO";
			this.Label5dtree.AutoSize = true;
			this.Label5dtree.Font = new System.Drawing.Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label5dtree.ForeColor = Color.Black;
			Label label5dtree = this.Label5dtree;
			point = new Point(138, 55);
			label5dtree.Location = point;
			this.Label5dtree.Name = "Label5dtree";
			Label label5dtree1 = this.Label5dtree;
			size = new System.Drawing.Size(59, 12);
			label5dtree1.Size = size;
			this.Label5dtree.TabIndex = 66;
			this.Label5dtree.Text = "MORE INFO";
			this.Label6RV.AutoSize = true;
			this.Label6RV.Font = new System.Drawing.Font("Segoe UI", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label6RV.ForeColor = Color.Black;
			Label label6RV = this.Label6RV;
			point = new Point(138, 40);
			label6RV.Location = point;
			this.Label6RV.Name = "Label6RV";
			Label label6RV1 = this.Label6RV;
			size = new System.Drawing.Size(59, 12);
			label6RV1.Size = size;
			this.Label6RV.TabIndex = 64;
			this.Label6RV.Text = "MORE INFO";
			this.LinkLabel10.ActiveLinkColor = Color.Plum;
			this.LinkLabel10.AutoSize = true;
			this.LinkLabel10.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel10.ForeColor = Color.DarkViolet;
			this.LinkLabel10.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabel10 = this.LinkLabel10;
			point = new Point(6, 54);
			linkLabel10.Location = point;
			this.LinkLabel10.Name = "LinkLabel10";
			LinkLabel linkLabel101 = this.LinkLabel10;
			size = new System.Drawing.Size(54, 15);
			linkLabel101.Size = size;
			this.LinkLabel10.TabIndex = 25;
			this.LinkLabel10.TabStop = true;
			this.LinkLabel10.Text = "DocEdge";
			this.LinkLabel9.ActiveLinkColor = Color.Plum;
			this.LinkLabel9.AutoSize = true;
			this.LinkLabel9.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel9.ForeColor = Color.DarkViolet;
			this.LinkLabel9.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabel9 = this.LinkLabel9;
			point = new Point(6, 38);
			linkLabel9.Location = point;
			this.LinkLabel9.Name = "LinkLabel9";
			LinkLabel linkLabel91 = this.LinkLabel9;
			size = new System.Drawing.Size(59, 15);
			linkLabel91.Size = size;
			this.LinkLabel9.TabIndex = 26;
			this.LinkLabel9.TabStop = true;
			this.LinkLabel9.Text = "RedVision";
			this.LinkLabel16.ActiveLinkColor = Color.Plum;
			this.LinkLabel16.AutoSize = true;
			this.LinkLabel16.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LinkLabel16.ForeColor = Color.DarkViolet;
			this.LinkLabel16.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkLabel16 = this.LinkLabel16;
			point = new Point(6, 22);
			linkLabel16.Location = point;
			this.LinkLabel16.Name = "LinkLabel16";
			LinkLabel linkLabel161 = this.LinkLabel16;
			size = new System.Drawing.Size(52, 15);
			linkLabel161.Size = size;
			this.LinkLabel16.TabIndex = 27;
			this.LinkLabel16.TabStop = true;
			this.LinkLabel16.Text = "Tapestry";
			this.LabelUseTap.AutoSize = true;
			this.LabelUseTap.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelUseTap.ForeColor = Color.Black;
			Label labelUseTap = this.LabelUseTap;
			point = new Point(71, 22);
			labelUseTap.Location = point;
			this.LabelUseTap.Name = "LabelUseTap";
			Label labelUseTap1 = this.LabelUseTap;
			size = new System.Drawing.Size(12, 15);
			labelUseTap1.Size = size;
			this.LabelUseTap.TabIndex = 61;
			this.LabelUseTap.Text = "*";
			this.LabelUseDtree.AutoSize = true;
			this.LabelUseDtree.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelUseDtree.ForeColor = Color.Black;
			Label labelUseDtree = this.LabelUseDtree;
			point = new Point(71, 52);
			labelUseDtree.Location = point;
			this.LabelUseDtree.Name = "LabelUseDtree";
			Label labelUseDtree1 = this.LabelUseDtree;
			size = new System.Drawing.Size(12, 15);
			labelUseDtree1.Size = size;
			this.LabelUseDtree.TabIndex = 63;
			this.LabelUseDtree.Text = "*";
			this.LabelUseRV.AutoSize = true;
			this.LabelUseRV.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LabelUseRV.ForeColor = Color.Black;
			Label labelUseRV = this.LabelUseRV;
			point = new Point(71, 37);
			labelUseRV.Location = point;
			this.LabelUseRV.Name = "LabelUseRV";
			Label labelUseRV1 = this.LabelUseRV;
			size = new System.Drawing.Size(12, 15);
			labelUseRV1.Size = size;
			this.LabelUseRV.TabIndex = 60;
			this.LabelUseRV.Text = "*";
			this.GroupBox2.BackColor = Color.GhostWhite;
			this.GroupBox2.Controls.Add(this.lbl_courtImgDate);
			this.GroupBox2.Controls.Add(this.lbl_courtIndexDate);
			this.GroupBox2.Controls.Add(this.Label34);
			this.GroupBox2.Controls.Add(this.Label35);
			this.GroupBox2.Controls.Add(this.lbl_copyFeeAmt);
			this.GroupBox2.Controls.Add(this.Label16);
			this.GroupBox2.Controls.Add(this.Label27);
			this.GroupBox2.Controls.Add(this.LabelIndex_source);
			this.GroupBox2.Controls.Add(this.LabelCopyPmtType);
			this.GroupBox2.Controls.Add(this.Label26);
			this.GroupBox2.Controls.Add(this.LabelImage_date);
			this.GroupBox2.Controls.Add(this.LabelIndex_date);
			this.GroupBox2.Controls.Add(this.Label12);
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.Label29);
			this.GroupBox2.Controls.Add(this.LabelCopy_source);
			this.GroupBox2.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.GroupBox2.ForeColor = Color.FromArgb(64, 64, 64);
			GroupBox groupBox2 = this.GroupBox2;
			point = new Point(438, 86);
			groupBox2.Location = point;
			this.GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = this.GroupBox2;
			size = new System.Drawing.Size(219, 151);
			groupBox21.Size = size;
			this.GroupBox2.TabIndex = 180;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "RESOURCE INFORMATION";
			this.lbl_courtImgDate.AutoSize = true;
			this.lbl_courtImgDate.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_courtImgDate.ForeColor = Color.Black;
			Label lblCourtImgDate = this.lbl_courtImgDate;
			point = new Point(112, 84);
			lblCourtImgDate.Location = point;
			this.lbl_courtImgDate.Name = "lbl_courtImgDate";
			Label lblCourtImgDate1 = this.lbl_courtImgDate;
			size = new System.Drawing.Size(9, 12);
			lblCourtImgDate1.Size = size;
			this.lbl_courtImgDate.TabIndex = 73;
			this.lbl_courtImgDate.Text = "*";
			this.lbl_courtIndexDate.AutoSize = true;
			this.lbl_courtIndexDate.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_courtIndexDate.ForeColor = Color.Black;
			Label lblCourtIndexDate = this.lbl_courtIndexDate;
			point = new Point(112, 68);
			lblCourtIndexDate.Location = point;
			this.lbl_courtIndexDate.Name = "lbl_courtIndexDate";
			Label lblCourtIndexDate1 = this.lbl_courtIndexDate;
			size = new System.Drawing.Size(9, 12);
			lblCourtIndexDate1.Size = size;
			this.lbl_courtIndexDate.TabIndex = 72;
			this.lbl_courtIndexDate.Text = "*";
			this.Label34.AutoSize = true;
			this.Label34.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label34.ForeColor = Color.DarkSlateBlue;
			Label label34 = this.Label34;
			point = new Point(7, 84);
			label34.Location = point;
			this.Label34.Name = "Label34";
			Label label341 = this.Label34;
			size = new System.Drawing.Size(88, 12);
			label341.Size = size;
			this.Label34.TabIndex = 71;
			this.Label34.Text = "Court Image Date: ";
			this.Label35.AutoSize = true;
			this.Label35.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label35.ForeColor = Color.DarkSlateBlue;
			Label label35 = this.Label35;
			point = new Point(7, 68);
			label35.Location = point;
			this.Label35.Name = "Label35";
			Label label351 = this.Label35;
			size = new System.Drawing.Size(85, 12);
			label351.Size = size;
			this.Label35.TabIndex = 70;
			this.Label35.Text = "Court Index Date: ";
			this.lbl_copyFeeAmt.AutoSize = true;
			this.lbl_copyFeeAmt.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.lbl_copyFeeAmt.ForeColor = Color.Black;
			Label lblCopyFeeAmt = this.lbl_copyFeeAmt;
			point = new Point(112, 132);
			lblCopyFeeAmt.Location = point;
			this.lbl_copyFeeAmt.Name = "lbl_copyFeeAmt";
			Label lblCopyFeeAmt1 = this.lbl_copyFeeAmt;
			size = new System.Drawing.Size(9, 12);
			lblCopyFeeAmt1.Size = size;
			this.lbl_copyFeeAmt.TabIndex = 69;
			this.lbl_copyFeeAmt.Text = "*";
			this.Label16.AutoSize = true;
			this.Label16.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label16.ForeColor = Color.DarkSlateBlue;
			Label label16 = this.Label16;
			point = new Point(7, 132);
			label16.Location = point;
			this.Label16.Name = "Label16";
			Label label161 = this.Label16;
			size = new System.Drawing.Size(90, 12);
			label161.Size = size;
			this.Label16.TabIndex = 68;
			this.Label16.Text = "Copy Fee Amount: ";
			this.Label27.AutoSize = true;
			this.Label27.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label27.ForeColor = Color.DarkSlateBlue;
			Label label27 = this.Label27;
			point = new Point(7, 20);
			label27.Location = point;
			this.Label27.Name = "Label27";
			Label label271 = this.Label27;
			size = new System.Drawing.Size(78, 12);
			label271.Size = size;
			this.Label27.TabIndex = 62;
			this.Label27.Text = "INDEX SOURCE: ";
			this.LabelIndex_source.AutoSize = true;
			this.LabelIndex_source.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.LabelIndex_source.ForeColor = Color.Black;
			Label labelIndexSource = this.LabelIndex_source;
			point = new Point(112, 20);
			labelIndexSource.Location = point;
			this.LabelIndex_source.Name = "LabelIndex_source";
			Label labelIndexSource1 = this.LabelIndex_source;
			size = new System.Drawing.Size(9, 12);
			labelIndexSource1.Size = size;
			this.LabelIndex_source.TabIndex = 63;
			this.LabelIndex_source.Text = "*";
			this.LabelCopyPmtType.AutoSize = true;
			this.LabelCopyPmtType.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.LabelCopyPmtType.ForeColor = Color.Black;
			Label labelCopyPmtType = this.LabelCopyPmtType;
			point = new Point(112, 116);
			labelCopyPmtType.Location = point;
			this.LabelCopyPmtType.Name = "LabelCopyPmtType";
			Label labelCopyPmtType1 = this.LabelCopyPmtType;
			size = new System.Drawing.Size(9, 12);
			labelCopyPmtType1.Size = size;
			this.LabelCopyPmtType.TabIndex = 61;
			this.LabelCopyPmtType.Text = "*";
			this.Label26.AutoSize = true;
			this.Label26.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label26.ForeColor = Color.DarkSlateBlue;
			Label label26 = this.Label26;
			point = new Point(7, 116);
			label26.Location = point;
			this.Label26.Name = "Label26";
			Label label261 = this.Label26;
			size = new System.Drawing.Size(66, 12);
			label261.Size = size;
			this.Label26.TabIndex = 60;
			this.Label26.Text = "Copy Pay By: ";
			this.LabelImage_date.AutoSize = true;
			this.LabelImage_date.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.LabelImage_date.ForeColor = Color.Black;
			Label labelImageDate = this.LabelImage_date;
			point = new Point(112, 52);
			labelImageDate.Location = point;
			this.LabelImage_date.Name = "LabelImage_date";
			Label labelImageDate1 = this.LabelImage_date;
			size = new System.Drawing.Size(9, 12);
			labelImageDate1.Size = size;
			this.LabelImage_date.TabIndex = 59;
			this.LabelImage_date.Text = "*";
			this.LabelIndex_date.AutoSize = true;
			this.LabelIndex_date.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.LabelIndex_date.ForeColor = Color.Black;
			Label labelIndexDate = this.LabelIndex_date;
			point = new Point(112, 36);
			labelIndexDate.Location = point;
			this.LabelIndex_date.Name = "LabelIndex_date";
			Label labelIndexDate1 = this.LabelIndex_date;
			size = new System.Drawing.Size(9, 12);
			labelIndexDate1.Size = size;
			this.LabelIndex_date.TabIndex = 58;
			this.LabelIndex_date.Text = "*";
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label12.ForeColor = Color.DarkSlateBlue;
			Label label12 = this.Label12;
			point = new Point(7, 52);
			label12.Location = point;
			this.Label12.Name = "Label12";
			Label label121 = this.Label12;
			size = new System.Drawing.Size(61, 12);
			label121.Size = size;
			this.Label12.TabIndex = 57;
			this.Label12.Text = "Image Date: ";
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label10.ForeColor = Color.DarkSlateBlue;
			Label label10 = this.Label10;
			point = new Point(7, 36);
			label10.Location = point;
			this.Label10.Name = "Label10";
			Label label101 = this.Label10;
			size = new System.Drawing.Size(83, 12);
			label101.Size = size;
			this.Label10.TabIndex = 56;
			this.Label10.Text = "Land Index Date: ";
			this.Label29.AutoSize = true;
			this.Label29.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.Label29.ForeColor = Color.DarkSlateBlue;
			Label label29 = this.Label29;
			point = new Point(7, 100);
			label29.Location = point;
			this.Label29.Name = "Label29";
			Label label291 = this.Label29;
			size = new System.Drawing.Size(76, 12);
			label291.Size = size;
			this.Label29.TabIndex = 54;
			this.Label29.Text = "COPY SOURCE: ";
			this.LabelCopy_source.AutoSize = true;
			this.LabelCopy_source.Font = new System.Drawing.Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			this.LabelCopy_source.ForeColor = Color.Black;
			Label labelCopySource = this.LabelCopy_source;
			point = new Point(112, 100);
			labelCopySource.Location = point;
			this.LabelCopy_source.Name = "LabelCopy_source";
			Label labelCopySource1 = this.LabelCopy_source;
			size = new System.Drawing.Size(9, 12);
			labelCopySource1.Size = size;
			this.LabelCopy_source.TabIndex = 55;
			this.LabelCopy_source.Text = "*";
			this.lblOpenRunSheet.AutoSize = true;
			this.lblOpenRunSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label4 = this.lblOpenRunSheet;
			point = new Point(38, 34);
			label4.Location = point;
			this.lblOpenRunSheet.Name = "lblOpenRunSheet";
			Label label5 = this.lblOpenRunSheet;
			size = new System.Drawing.Size(111, 15);
			label5.Size = size;
			this.lblOpenRunSheet.TabIndex = 187;
			this.lblOpenRunSheet.Text = "Abstract Run Sheet";
			this.TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.TabControl1.Controls.Add(this.TabPg1Docs);
			this.TabControl1.Controls.Add(this.TabPg2PhBk);
			this.TabControl1.Controls.Add(this.TabPg3Cal);
			this.TabControl1.Controls.Add(this.TabPg4Clearing);
			this.TabControl1.Controls.Add(this.TabPg5Req);
			this.TabControl1.Controls.Add(this.TabPg6OtherLogins);
			this.TabControl1.Controls.Add(this.TabPg7Taxes);
			this.TabControl1.Controls.Add(this.TabPg8UWMan);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			TabControl tabControl1 = this.TabControl1;
			point = new Point(0, 387);
			tabControl1.Location = point;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			TabControl tabControl = this.TabControl1;
			size = new System.Drawing.Size(874, 227);
			tabControl.Size = size;
			this.TabControl1.TabIndex = 190;
			this.TabPg1Docs.AutoScroll = true;
			this.TabPg1Docs.BackColor = Color.GhostWhite;
			this.TabPg1Docs.Controls.Add(this.pboxOpenCredCard);
			this.TabPg1Docs.Controls.Add(this.lbl_creditCard);
			this.TabPg1Docs.Controls.Add(this.pbox_Abstr_SOP);
			this.TabPg1Docs.Controls.Add(this.lbl_doc_AbstractingSOPs);
			this.TabPg1Docs.Controls.Add(this.pboxOpenEtitleWkshare);
			this.TabPg1Docs.Controls.Add(this.lblOpenEtitleWkshare);
			this.TabPg1Docs.Controls.Add(this.pboxOpenORT_Wkshare);
			this.TabPg1Docs.Controls.Add(this.lblOpenORT_Wkshare);
			this.TabPg1Docs.Controls.Add(this.Button_ClosingDept);
			this.TabPg1Docs.Controls.Add(this.Button_TitleDept);
			this.TabPg1Docs.Controls.Add(this.GroupBox5);
			this.TabPg1Docs.Controls.Add(this.pboxOpenClearanceCustSpecs);
			this.TabPg1Docs.Controls.Add(this.lblOpenClearanceCustSpecs);
			this.TabPg1Docs.Controls.Add(this.pboxOpenTitleCustSpecs);
			this.TabPg1Docs.Controls.Add(this.lblOpenTitleCustSpec);
			this.TabPg1Docs.Controls.Add(this.pboxOpenRunSheet);
			this.TabPg1Docs.Controls.Add(this.lblOpenRunSheet);
			TabPage tabPg1Docs = this.TabPg1Docs;
			point = new Point(4, 22);
			tabPg1Docs.Location = point;
			this.TabPg1Docs.Name = "TabPg1Docs";
			TabPage tabPage = this.TabPg1Docs;
			padding = new System.Windows.Forms.Padding(3);
			tabPage.Padding = padding;
			TabPage tabPg1Docs1 = this.TabPg1Docs;
			size = new System.Drawing.Size(866, 201);
			tabPg1Docs1.Size = size;
			this.TabPg1Docs.TabIndex = 0;
			this.TabPg1Docs.Text = "Doc Manager";
			this.pbox_Abstr_SOP.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pboxAbstrSOP = this.pbox_Abstr_SOP;
			point = new Point(22, 11);
			pboxAbstrSOP.Location = point;
			this.pbox_Abstr_SOP.Name = "pbox_Abstr_SOP";
			PictureBox pboxAbstrSOP1 = this.pbox_Abstr_SOP;
			size = new System.Drawing.Size(14, 14);
			pboxAbstrSOP1.Size = size;
			this.pbox_Abstr_SOP.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbox_Abstr_SOP.TabIndex = 203;
			this.pbox_Abstr_SOP.TabStop = false;
			this.pbox_Abstr_SOP.Tag = "AbstractRunSheet";
			this.lbl_doc_AbstractingSOPs.AutoSize = true;
			this.lbl_doc_AbstractingSOPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocAbstractingSOPs = this.lbl_doc_AbstractingSOPs;
			point = new Point(38, 10);
			lblDocAbstractingSOPs.Location = point;
			this.lbl_doc_AbstractingSOPs.Name = "lbl_doc_AbstractingSOPs";
			Label lblDocAbstractingSOPs1 = this.lbl_doc_AbstractingSOPs;
			size = new System.Drawing.Size(140, 15);
			lblDocAbstractingSOPs1.Size = size;
			this.lbl_doc_AbstractingSOPs.TabIndex = 204;
			this.lbl_doc_AbstractingSOPs.Text = "Online Abstracting SOPs";
			this.Button_PolicyWarehouse.BackColor = Color.Turquoise;
			this.Button_PolicyWarehouse.Cursor = Cursors.Hand;
			this.Button_PolicyWarehouse.FlatAppearance.BorderColor = Color.MediumSlateBlue;
			this.Button_PolicyWarehouse.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_PolicyWarehouse.FlatAppearance.MouseOverBackColor = Color.LightCyan;
			this.Button_PolicyWarehouse.FlatStyle = FlatStyle.Flat;
			this.Button_PolicyWarehouse.Font = new System.Drawing.Font("Arial", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Button_PolicyWarehouse.ForeColor = Color.Indigo;
			Button buttonPolicyWarehouse = this.Button_PolicyWarehouse;
			point = new Point(717, 2);
			buttonPolicyWarehouse.Location = point;
			Button buttonPolicyWarehouse1 = this.Button_PolicyWarehouse;
			padding = new System.Windows.Forms.Padding(0);
			buttonPolicyWarehouse1.Margin = padding;
			this.Button_PolicyWarehouse.Name = "Button_PolicyWarehouse";
			Button buttonPolicyWarehouse2 = this.Button_PolicyWarehouse;
			size = new System.Drawing.Size(70, 20);
			buttonPolicyWarehouse2.Size = size;
			this.Button_PolicyWarehouse.TabIndex = 202;
			this.Button_PolicyWarehouse.Text = "POLICIES";
			this.Button_PolicyWarehouse.UseVisualStyleBackColor = false;
			this.pboxOpenEtitleWkshare.Image = (Image)componentResourceManager.GetObject("pboxOpenEtitleWkshare.Image");
			PictureBox pictureBox2 = this.pboxOpenEtitleWkshare;
			point = new Point(21, 155);
			pictureBox2.Location = point;
			this.pboxOpenEtitleWkshare.Name = "pboxOpenEtitleWkshare";
			PictureBox pictureBox3 = this.pboxOpenEtitleWkshare;
			size = new System.Drawing.Size(14, 14);
			pictureBox3.Size = size;
			this.pboxOpenEtitleWkshare.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pboxOpenEtitleWkshare.TabIndex = 200;
			this.pboxOpenEtitleWkshare.TabStop = false;
			this.pboxOpenEtitleWkshare.Tag = "AbstractRunSheet";
			this.lblOpenEtitleWkshare.AutoSize = true;
			this.lblOpenEtitleWkshare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label6 = this.lblOpenEtitleWkshare;
			point = new Point(38, 154);
			label6.Location = point;
			this.lblOpenEtitleWkshare.Name = "lblOpenEtitleWkshare";
			Label label7 = this.lblOpenEtitleWkshare;
			size = new System.Drawing.Size(178, 15);
			label7.Size = size;
			this.lblOpenEtitleWkshare.TabIndex = 201;
			this.lblOpenEtitleWkshare.Text = "Stewart eTitle Workshare FAQ's";
			this.pboxOpenORT_Wkshare.Image = (Image)componentResourceManager.GetObject("pboxOpenORT_Wkshare.Image");
			PictureBox pboxOpenORTWkshare = this.pboxOpenORT_Wkshare;
			point = new Point(21, 131);
			pboxOpenORTWkshare.Location = point;
			this.pboxOpenORT_Wkshare.Name = "pboxOpenORT_Wkshare";
			PictureBox pboxOpenORTWkshare1 = this.pboxOpenORT_Wkshare;
			size = new System.Drawing.Size(14, 14);
			pboxOpenORTWkshare1.Size = size;
			this.pboxOpenORT_Wkshare.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pboxOpenORT_Wkshare.TabIndex = 198;
			this.pboxOpenORT_Wkshare.TabStop = false;
			this.pboxOpenORT_Wkshare.Tag = "AbstractRunSheet";
			this.lblOpenORT_Wkshare.AutoSize = true;
			this.lblOpenORT_Wkshare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblOpenORTWkshare = this.lblOpenORT_Wkshare;
			point = new Point(38, 130);
			lblOpenORTWkshare.Location = point;
			this.lblOpenORT_Wkshare.Name = "lblOpenORT_Wkshare";
			Label lblOpenORTWkshare1 = this.lblOpenORT_Wkshare;
			size = new System.Drawing.Size(140, 15);
			lblOpenORTWkshare1.Size = size;
			this.lblOpenORT_Wkshare.TabIndex = 199;
			this.lblOpenORT_Wkshare.Text = "ORTIC Workshare FAQ's";
			this.Button_ClosingDept.BackColor = Color.FromArgb(211, 168, 255);
			this.Button_ClosingDept.Cursor = Cursors.Hand;
			this.Button_ClosingDept.FlatAppearance.BorderColor = Color.Purple;
			this.Button_ClosingDept.FlatAppearance.BorderSize = 2;
			this.Button_ClosingDept.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_ClosingDept.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_ClosingDept.FlatStyle = FlatStyle.Flat;
			this.Button_ClosingDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Pixel, 0);
			this.Button_ClosingDept.ForeColor = Color.Indigo;
			Button buttonClosingDept = this.Button_ClosingDept;
			point = new Point(619, 153);
			buttonClosingDept.Location = point;
			Button buttonClosingDept1 = this.Button_ClosingDept;
			padding = new System.Windows.Forms.Padding(0);
			buttonClosingDept1.Margin = padding;
			this.Button_ClosingDept.Name = "Button_ClosingDept";
			Button buttonClosingDept2 = this.Button_ClosingDept;
			size = new System.Drawing.Size(82, 30);
			buttonClosingDept2.Size = size;
			this.Button_ClosingDept.TabIndex = 197;
			this.Button_ClosingDept.Text = "Clos Dept";
			this.Button_ClosingDept.UseVisualStyleBackColor = false;
			this.Button_ClosingDept.Visible = false;
			this.Button_TitleDept.BackColor = Color.FromArgb(211, 168, 255);
			this.Button_TitleDept.Cursor = Cursors.Hand;
			this.Button_TitleDept.FlatAppearance.BorderColor = Color.Purple;
			this.Button_TitleDept.FlatAppearance.BorderSize = 2;
			this.Button_TitleDept.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_TitleDept.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_TitleDept.FlatStyle = FlatStyle.Flat;
			this.Button_TitleDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Pixel, 0);
			this.Button_TitleDept.ForeColor = Color.Indigo;
			Button buttonTitleDept = this.Button_TitleDept;
			point = new Point(619, 118);
			buttonTitleDept.Location = point;
			Button buttonTitleDept1 = this.Button_TitleDept;
			padding = new System.Windows.Forms.Padding(0);
			buttonTitleDept1.Margin = padding;
			this.Button_TitleDept.Name = "Button_TitleDept";
			Button buttonTitleDept2 = this.Button_TitleDept;
			size = new System.Drawing.Size(82, 30);
			buttonTitleDept2.Size = size;
			this.Button_TitleDept.TabIndex = 196;
			this.Button_TitleDept.Text = "Title Dept";
			this.Button_TitleDept.UseVisualStyleBackColor = false;
			this.Button_TitleDept.Visible = false;
			this.ButtonHelp.BackColor = Color.Turquoise;
			this.ButtonHelp.Cursor = Cursors.Hand;
			this.ButtonHelp.FlatAppearance.BorderColor = Color.MediumSlateBlue;
			this.ButtonHelp.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.ButtonHelp.FlatAppearance.MouseOverBackColor = Color.LightCyan;
			this.ButtonHelp.FlatStyle = FlatStyle.Flat;
			this.ButtonHelp.Font = new System.Drawing.Font("Arial", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ButtonHelp.ForeColor = Color.Indigo;
			Button buttonHelp = this.ButtonHelp;
			point = new Point(647, 2);
			buttonHelp.Location = point;
			Button buttonHelp1 = this.ButtonHelp;
			padding = new System.Windows.Forms.Padding(0);
			buttonHelp1.Margin = padding;
			this.ButtonHelp.Name = "ButtonHelp";
			Button buttonHelp2 = this.ButtonHelp;
			size = new System.Drawing.Size(70, 20);
			buttonHelp2.Size = size;
			this.ButtonHelp.TabIndex = 195;
			this.ButtonHelp.Text = "ORB HELP";
			this.ButtonHelp.UseVisualStyleBackColor = false;
			this.Button_RateCalc.BackColor = Color.Turquoise;
			this.Button_RateCalc.Cursor = Cursors.Hand;
			this.Button_RateCalc.FlatAppearance.BorderColor = Color.MediumSlateBlue;
			this.Button_RateCalc.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_RateCalc.FlatAppearance.MouseOverBackColor = Color.LightCyan;
			this.Button_RateCalc.FlatStyle = FlatStyle.Flat;
			this.Button_RateCalc.Font = new System.Drawing.Font("Arial", 7.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Button_RateCalc.ForeColor = Color.Indigo;
			Button buttonRateCalc = this.Button_RateCalc;
			point = new Point(787, 2);
			buttonRateCalc.Location = point;
			Button buttonRateCalc1 = this.Button_RateCalc;
			padding = new System.Windows.Forms.Padding(0);
			buttonRateCalc1.Margin = padding;
			this.Button_RateCalc.Name = "Button_RateCalc";
			Button buttonRateCalc2 = this.Button_RateCalc;
			size = new System.Drawing.Size(83, 20);
			buttonRateCalc2.Size = size;
			this.Button_RateCalc.TabIndex = 194;
			this.Button_RateCalc.Text = "RATE CALC";
			this.Button_RateCalc.UseVisualStyleBackColor = false;
			this.GroupBox5.BackColor = Color.MintCream;
			this.GroupBox5.Controls.Add(this.Label114);
			this.GroupBox5.Controls.Add(this.Label113);
			this.GroupBox5.Controls.Add(this.ButtonResetDocs);
			this.GroupBox5.Controls.Add(this.ButtonGetDoc);
			this.GroupBox5.Controls.Add(this.cboxDocType);
			this.GroupBox5.Controls.Add(this.cboxDocState);
			this.GroupBox5.Controls.Add(this.linkUS_Legal_Forms);
			this.GroupBox5.Controls.Add(this.lbl_NotFound);
			this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			GroupBox groupBox5 = this.GroupBox5;
			point = new Point(339, 12);
			groupBox5.Location = point;
			this.GroupBox5.Name = "GroupBox5";
			GroupBox groupBox51 = this.GroupBox5;
			size = new System.Drawing.Size(260, 174);
			groupBox51.Size = size;
			this.GroupBox5.TabIndex = 193;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Legal Doc Templates";
			this.Label114.AutoSize = true;
			this.Label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label114 = this.Label114;
			point = new Point(14, 58);
			label114.Location = point;
			this.Label114.Name = "Label114";
			Label label1141 = this.Label114;
			size = new System.Drawing.Size(54, 13);
			label1141.Size = size;
			this.Label114.TabIndex = 7;
			this.Label114.Text = "Doc Type";
			this.Label113.AutoSize = true;
			this.Label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label113 = this.Label113;
			point = new Point(36, 30);
			label113.Location = point;
			this.Label113.Name = "Label113";
			Label label1131 = this.Label113;
			size = new System.Drawing.Size(32, 13);
			label1131.Size = size;
			this.Label113.TabIndex = 6;
			this.Label113.Text = "State";
			Button buttonResetDocs = this.ButtonResetDocs;
			point = new Point(152, 89);
			buttonResetDocs.Location = point;
			this.ButtonResetDocs.Name = "ButtonResetDocs";
			Button buttonResetDocs1 = this.ButtonResetDocs;
			size = new System.Drawing.Size(73, 23);
			buttonResetDocs1.Size = size;
			this.ButtonResetDocs.TabIndex = 5;
			this.ButtonResetDocs.Text = "Reset";
			this.ButtonResetDocs.UseVisualStyleBackColor = true;
			Button buttonGetDoc = this.ButtonGetDoc;
			point = new Point(74, 89);
			buttonGetDoc.Location = point;
			this.ButtonGetDoc.Name = "ButtonGetDoc";
			Button buttonGetDoc1 = this.ButtonGetDoc;
			size = new System.Drawing.Size(73, 23);
			buttonGetDoc1.Size = size;
			this.ButtonGetDoc.TabIndex = 4;
			this.ButtonGetDoc.Text = "Get Docs";
			this.ButtonGetDoc.UseVisualStyleBackColor = true;
			this.cboxDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboxDocType.ForeColor = Color.Indigo;
			this.cboxDocType.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections1 = this.cboxDocType.Items;
			objArray = new object[] { "-choose-", "Affidavit-BwrIndem", "Affidavit-ContMarriage", "Affidavit-CommonName", "Affidavit-FirstTimeBuyer", "Affidavit-MaritalStatus-3rdParty", "Affidavit-Survivorship", "Affidavit-Trust", "Agrmt-CommonDriveway", "Agrmt-Escrow", "Agrmt-PartyWall", "Agrmt-PrivRoadMaint", "CertifResolution-Corp", "CertifResolution-LLC", "Deed", "Deed-Corrective", "Deed-Family", "Deed-Gift", "Deed-Grant", "Deed-LandContractCancel", "Deed-Special", "Deed-Warranty", "HoldHarmless", "Indemnity-Indiv", "Mortgage-Corp", "Mortgage-Private", "MtgModification", "NotaryAck", "Notice-Completion", "Notice-PendingJgmt", "Notice-Termination", "POA", "POA-2ndMtgOnly", "POA-Durable", "POA-Durable-Ltd", "POA-General", "POA-Special", "QCD", "QCD-hw-hw", "QCD-hw-indiv", "QCD-indiv-hw", "QCD-indiv-indiv", "QCD-LLC-hw", "QCD-LLC-indiv", "Release-Jgmt", "Release-JgmtCorp", "Release-Mtg", "Release-MtgCorp", "Release-MtgPartial", "Release-MtgPrivate", "Release-UCC", "Release-UCCPartial", "SettlementAuth", "Waiver-HomesteadRights", "Waiver-SpousalRights" };
			objectCollections1.AddRange(objArray);
			ComboBox comboBox3 = this.cboxDocType;
			point = new Point(74, 55);
			comboBox3.Location = point;
			this.cboxDocType.Name = "cboxDocType";
			ComboBox comboBox4 = this.cboxDocType;
			size = new System.Drawing.Size(151, 21);
			comboBox4.Size = size;
			this.cboxDocType.TabIndex = 3;
			this.cboxDocState.DropDownHeight = 100;
			this.cboxDocState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboxDocState.ForeColor = Color.Indigo;
			this.cboxDocState.FormattingEnabled = true;
			this.cboxDocState.IntegralHeight = false;
			this.cboxDocState.ItemHeight = 15;
			ComboBox.ObjectCollection items2 = this.cboxDocState.Items;
			objArray = new object[] { "AK", "AL", "ANY", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" };
			items2.AddRange(objArray);
			ComboBox comboBox5 = this.cboxDocState;
			point = new Point(74, 25);
			comboBox5.Location = point;
			this.cboxDocState.MaxDropDownItems = 10;
			this.cboxDocState.Name = "cboxDocState";
			ComboBox comboBox6 = this.cboxDocState;
			size = new System.Drawing.Size(63, 23);
			comboBox6.Size = size;
			this.cboxDocState.Sorted = true;
			this.cboxDocState.TabIndex = 2;
			this.linkUS_Legal_Forms.ActiveLinkColor = Color.Green;
			this.linkUS_Legal_Forms.AutoSize = true;
			this.linkUS_Legal_Forms.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.linkUS_Legal_Forms.LinkColor = Color.FromArgb(0, 134, 77);
			LinkLabel linkUSLegalForms = this.linkUS_Legal_Forms;
			point = new Point(140, 139);
			linkUSLegalForms.Location = point;
			this.linkUS_Legal_Forms.Name = "linkUS_Legal_Forms";
			LinkLabel linkUSLegalForms1 = this.linkUS_Legal_Forms;
			size = new System.Drawing.Size(102, 15);
			linkUSLegalForms1.Size = size;
			this.linkUS_Legal_Forms.TabIndex = 1;
			this.linkUS_Legal_Forms.TabStop = true;
			this.linkUS_Legal_Forms.Text = "USLegalDocs.com";
			this.lbl_NotFound.AutoSize = true;
			this.lbl_NotFound.Font = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbl_NotFound.ForeColor = Color.Red;
			Label lblNotFound = this.lbl_NotFound;
			point = new Point(13, 139);
			lblNotFound.Location = point;
			this.lbl_NotFound.Name = "lbl_NotFound";
			Label lblNotFound1 = this.lbl_NotFound;
			size = new System.Drawing.Size(134, 15);
			lblNotFound1.Size = size;
			this.lbl_NotFound.TabIndex = 0;
			this.lbl_NotFound.Text = "DOC NOT FOUND. Visit ";
			this.pboxOpenClearanceCustSpecs.Image = WindowsApplication1.My.Resources.Resources.xls_icon;
			PictureBox pictureBox4 = this.pboxOpenClearanceCustSpecs;
			point = new Point(21, 107);
			pictureBox4.Location = point;
			this.pboxOpenClearanceCustSpecs.Name = "pboxOpenClearanceCustSpecs";
			PictureBox pictureBox5 = this.pboxOpenClearanceCustSpecs;
			size = new System.Drawing.Size(14, 14);
			pictureBox5.Size = size;
			this.pboxOpenClearanceCustSpecs.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pboxOpenClearanceCustSpecs.TabIndex = 191;
			this.pboxOpenClearanceCustSpecs.TabStop = false;
			this.pboxOpenClearanceCustSpecs.Tag = "AbstractRunSheet";
			this.lblOpenClearanceCustSpecs.AutoSize = true;
			this.lblOpenClearanceCustSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label8 = this.lblOpenClearanceCustSpecs;
			point = new Point(38, 106);
			label8.Location = point;
			this.lblOpenClearanceCustSpecs.Name = "lblOpenClearanceCustSpecs";
			Label label9 = this.lblOpenClearanceCustSpecs;
			size = new System.Drawing.Size(171, 15);
			label9.Size = size;
			this.lblOpenClearanceCustSpecs.TabIndex = 192;
			this.lblOpenClearanceCustSpecs.Text = "Title Clearance Cust. Specifics";
			this.pboxOpenTitleCustSpecs.Image = (Image)componentResourceManager.GetObject("pboxOpenTitleCustSpecs.Image");
			PictureBox pictureBox6 = this.pboxOpenTitleCustSpecs;
			point = new Point(21, 83);
			pictureBox6.Location = point;
			this.pboxOpenTitleCustSpecs.Name = "pboxOpenTitleCustSpecs";
			PictureBox pictureBox7 = this.pboxOpenTitleCustSpecs;
			size = new System.Drawing.Size(14, 14);
			pictureBox7.Size = size;
			this.pboxOpenTitleCustSpecs.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pboxOpenTitleCustSpecs.TabIndex = 189;
			this.pboxOpenTitleCustSpecs.TabStop = false;
			this.pboxOpenTitleCustSpecs.Tag = "AbstractRunSheet";
			this.lblOpenTitleCustSpec.AutoSize = true;
			this.lblOpenTitleCustSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label14 = this.lblOpenTitleCustSpec;
			point = new Point(38, 82);
			label14.Location = point;
			this.lblOpenTitleCustSpec.Name = "lblOpenTitleCustSpec";
			Label label17 = this.lblOpenTitleCustSpec;
			size = new System.Drawing.Size(174, 15);
			label17.Size = size;
			this.lblOpenTitleCustSpec.TabIndex = 190;
			this.lblOpenTitleCustSpec.Text = "Title Production Cust. Specifics";
			this.pboxOpenRunSheet.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pictureBox8 = this.pboxOpenRunSheet;
			point = new Point(22, 35);
			pictureBox8.Location = point;
			this.pboxOpenRunSheet.Name = "pboxOpenRunSheet";
			PictureBox pictureBox9 = this.pboxOpenRunSheet;
			size = new System.Drawing.Size(14, 14);
			pictureBox9.Size = size;
			this.pboxOpenRunSheet.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pboxOpenRunSheet.TabIndex = 150;
			this.pboxOpenRunSheet.TabStop = false;
			this.pboxOpenRunSheet.Tag = "AbstractRunSheet";
			this.TabPg2PhBk.AutoScroll = true;
			this.TabPg2PhBk.BackColor = Color.GhostWhite;
			this.TabPg2PhBk.Controls.Add(this.PictureBox9);
			this.TabPg2PhBk.Controls.Add(this.lbl_BusnPhones);
			this.TabPg2PhBk.Controls.Add(this.Label48);
			this.TabPg2PhBk.Controls.Add(this.Label49);
			this.TabPg2PhBk.Controls.Add(this.DataGridView1);
			TabPage tabPg2PhBk = this.TabPg2PhBk;
			point = new Point(4, 22);
			tabPg2PhBk.Location = point;
			this.TabPg2PhBk.Name = "TabPg2PhBk";
			TabPage tabPg2PhBk1 = this.TabPg2PhBk;
			padding = new System.Windows.Forms.Padding(3);
			tabPg2PhBk1.Padding = padding;
			TabPage tabPage1 = this.TabPg2PhBk;
			size = new System.Drawing.Size(866, 201);
			tabPage1.Size = size;
			this.TabPg2PhBk.TabIndex = 1;
			this.TabPg2PhBk.Text = "Phone Book";
			this.PictureBox9.Image = WindowsApplication1.My.Resources.Resources.xls_icon;
			PictureBox pictureBox91 = this.PictureBox9;
			point = new Point(13, 17);
			pictureBox91.Location = point;
			this.PictureBox9.Name = "PictureBox9";
			PictureBox pictureBox92 = this.PictureBox9;
			size = new System.Drawing.Size(14, 14);
			pictureBox92.Size = size;
			this.PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox9.TabIndex = 193;
			this.PictureBox9.TabStop = false;
			this.PictureBox9.Tag = "AbstractRunSheet";
			this.lbl_BusnPhones.AutoSize = true;
			this.lbl_BusnPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblBusnPhones = this.lbl_BusnPhones;
			point = new Point(30, 16);
			lblBusnPhones.Location = point;
			this.lbl_BusnPhones.Name = "lbl_BusnPhones";
			Label lblBusnPhones1 = this.lbl_BusnPhones;
			size = new System.Drawing.Size(158, 15);
			lblBusnPhones1.Size = size;
			this.lbl_BusnPhones.TabIndex = 194;
			this.lbl_BusnPhones.Text = "iMS Title Business Contacts";
			this.Label48.AutoSize = true;
			this.Label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label48 = this.Label48;
			point = new Point(9, 40);
			label48.Location = point;
			this.Label48.Name = "Label48";
			Label label481 = this.Label48;
			size = new System.Drawing.Size(355, 13);
			label481.Size = size;
			this.Label48.TabIndex = 77;
			this.Label48.Text = "Double click in the cell with the Fax or Email to open Outlook";
			this.Label49.AutoSize = true;
			this.Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label49 = this.Label49;
			point = new Point(416, 40);
			label49.Location = point;
			this.Label49.Name = "Label49";
			Label label491 = this.Label49;
			size = new System.Drawing.Size(257, 13);
			label491.Size = size;
			this.Label49.TabIndex = 76;
			this.Label49.Text = "eskerfax format-  [FAX:18665758825@CHRIS@IMS]";
			dataGridViewCellStyle.BackColor = Color.Thistle;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(192, 255, 255);
			dataGridViewCellStyle.SelectionForeColor = Color.Indigo;
			this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.DataGridView1.BackgroundColor = Color.Linen;
			this.DataGridView1.BorderStyle = BorderStyle.None;
			this.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
			whiteSmoke.Alignment = DataGridViewContentAlignment.MiddleLeft;
			whiteSmoke.BackColor = Color.WhiteSmoke;
			whiteSmoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			whiteSmoke.ForeColor = SystemColors.WindowText;
			whiteSmoke.SelectionBackColor = Color.Aquamarine;
			whiteSmoke.SelectionForeColor = SystemColors.ControlText;
			whiteSmoke.WrapMode = DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = whiteSmoke;
			this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Cursor = Cursors.Default;
			window.Alignment = DataGridViewContentAlignment.MiddleLeft;
			window.BackColor = SystemColors.Window;
			window.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			window.ForeColor = SystemColors.ControlText;
			window.SelectionBackColor = Color.White;
			window.SelectionForeColor = SystemColors.ControlText;
			window.WrapMode = DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = window;
			this.DataGridView1.GridColor = Color.MediumOrchid;
			DataGridView dataGridView1 = this.DataGridView1;
			point = new Point(8, 65);
			dataGridView1.Location = point;
			DataGridView dataGridView = this.DataGridView1;
			size = new System.Drawing.Size(700, 100);
			dataGridView.MaximumSize = size;
			DataGridView dataGridView11 = this.DataGridView1;
			size = new System.Drawing.Size(700, 100);
			dataGridView11.MinimumSize = size;
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowHeadersWidth = 20;
			lavenderBlush.BackColor = Color.LavenderBlush;
			lavenderBlush.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			lavenderBlush.ForeColor = Color.Indigo;
			lavenderBlush.SelectionBackColor = Color.MediumPurple;
			lavenderBlush.SelectionForeColor = Color.White;
			lavenderBlush.WrapMode = DataGridViewTriState.True;
			this.DataGridView1.RowsDefaultCellStyle = lavenderBlush;
			this.DataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
			DataGridView dataGridView12 = this.DataGridView1;
			size = new System.Drawing.Size(700, 100);
			dataGridView12.Size = size;
			this.DataGridView1.TabIndex = 72;
			this.TabPg3Cal.AutoScroll = true;
			this.TabPg3Cal.BackColor = Color.GhostWhite;

			TabPage tabPg3Cal = this.TabPg3Cal;
			point = new Point(4, 22);
			tabPg3Cal.Location = point;
			this.TabPg3Cal.Name = "TabPg3Cal";
			TabPage tabPg3Cal1 = this.TabPg3Cal;
			padding = new System.Windows.Forms.Padding(3);
			tabPg3Cal1.Padding = padding;
			TabPage tabPg3Cal2 = this.TabPg3Cal;
			size = new System.Drawing.Size(866, 201);
			tabPg3Cal2.Size = size;
			this.TabPg3Cal.TabIndex = 3;
			this.TabPg3Cal.Text = "Calander";
			this.TabPg4Clearing.AutoScroll = true;
			this.TabPg4Clearing.BackColor = Color.Linen;
			this.TabPg4Clearing.Controls.Add(this.PictureBox8);
			this.TabPg4Clearing.Controls.Add(this.lbl_doc_Lease_Fee_LandContract);
			this.TabPg4Clearing.Controls.Add(this.PictureBox6);
			this.TabPg4Clearing.Controls.Add(this.lbl_doc_SOP_deedprep);
			this.TabPg4Clearing.Controls.Add(this.PictureBox7);
			this.TabPg4Clearing.Controls.Add(this.lbl_doc_approvePOA);
			this.TabPg4Clearing.Controls.Add(this.PictureBox5);
			this.TabPg4Clearing.Controls.Add(this.lbl_doc_aboutVesting);
			this.TabPg4Clearing.Controls.Add(this.PictureBox4);
			this.TabPg4Clearing.Controls.Add(this.lbl_doc_aboutDeeds);
			this.TabPg4Clearing.Controls.Add(this.TableLayoutPanel1);
			TabPage tabPg4Clearing = this.TabPg4Clearing;
			point = new Point(4, 22);
			tabPg4Clearing.Location = point;
			this.TabPg4Clearing.Name = "TabPg4Clearing";
			TabPage tabPg4Clearing1 = this.TabPg4Clearing;
			padding = new System.Windows.Forms.Padding(3);
			tabPg4Clearing1.Padding = padding;
			TabPage tabPg4Clearing2 = this.TabPg4Clearing;
			size = new System.Drawing.Size(866, 201);
			tabPg4Clearing2.Size = size;
			this.TabPg4Clearing.TabIndex = 4;
			this.TabPg4Clearing.Text = "Clearing & Examination";
			this.PictureBox8.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pictureBox81 = this.PictureBox8;
			point = new Point(633, 98);
			pictureBox81.Location = point;
			this.PictureBox8.Name = "PictureBox8";
			PictureBox pictureBox82 = this.PictureBox8;
			size = new System.Drawing.Size(14, 14);
			pictureBox82.Size = size;
			this.PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox8.TabIndex = 200;
			this.PictureBox8.TabStop = false;
			this.PictureBox8.Tag = "AbstractRunSheet";
			this.lbl_doc_Lease_Fee_LandContract.AutoSize = true;
			this.lbl_doc_Lease_Fee_LandContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocLeaseFeeLandContract = this.lbl_doc_Lease_Fee_LandContract;
			point = new Point(651, 98);
			lblDocLeaseFeeLandContract.Location = point;
			this.lbl_doc_Lease_Fee_LandContract.Name = "lbl_doc_Lease_Fee_LandContract";
			Label lblDocLeaseFeeLandContract1 = this.lbl_doc_Lease_Fee_LandContract;
			size = new System.Drawing.Size(170, 13);
			lblDocLeaseFeeLandContract1.Size = size;
			this.lbl_doc_Lease_Fee_LandContract.TabIndex = 201;
			this.lbl_doc_Lease_Fee_LandContract.Text = "Lease vs. Fee and Land Contracts";
			this.PictureBox6.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pictureBox61 = this.PictureBox6;
			point = new Point(634, 77);
			pictureBox61.Location = point;
			this.PictureBox6.Name = "PictureBox6";
			PictureBox pictureBox62 = this.PictureBox6;
			size = new System.Drawing.Size(14, 14);
			pictureBox62.Size = size;
			this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox6.TabIndex = 198;
			this.PictureBox6.TabStop = false;
			this.PictureBox6.Tag = "AbstractRunSheet";
			this.lbl_doc_SOP_deedprep.AutoSize = true;
			this.lbl_doc_SOP_deedprep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocSOPDeedprep = this.lbl_doc_SOP_deedprep;
			point = new Point(652, 77);
			lblDocSOPDeedprep.Location = point;
			this.lbl_doc_SOP_deedprep.Name = "lbl_doc_SOP_deedprep";
			Label lblDocSOPDeedprep1 = this.lbl_doc_SOP_deedprep;
			size = new System.Drawing.Size(144, 13);
			lblDocSOPDeedprep1.Size = size;
			this.lbl_doc_SOP_deedprep.TabIndex = 199;
			this.lbl_doc_SOP_deedprep.Text = "iMS SOP-Vesting/Deed Prep";
			this.PictureBox7.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pictureBox71 = this.PictureBox7;
			point = new Point(634, 56);
			pictureBox71.Location = point;
			this.PictureBox7.Name = "PictureBox7";
			PictureBox pictureBox72 = this.PictureBox7;
			size = new System.Drawing.Size(14, 14);
			pictureBox72.Size = size;
			this.PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox7.TabIndex = 196;
			this.PictureBox7.TabStop = false;
			this.PictureBox7.Tag = "AbstractRunSheet";
			this.lbl_doc_approvePOA.AutoSize = true;
			this.lbl_doc_approvePOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocApprovePOA = this.lbl_doc_approvePOA;
			point = new Point(652, 56);
			lblDocApprovePOA.Location = point;
			this.lbl_doc_approvePOA.Name = "lbl_doc_approvePOA";
			Label lblDocApprovePOA1 = this.lbl_doc_approvePOA;
			size = new System.Drawing.Size(85, 13);
			lblDocApprovePOA1.Size = size;
			this.lbl_doc_approvePOA.TabIndex = 197;
			this.lbl_doc_approvePOA.Text = "Approving POAs";
			this.PictureBox5.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pictureBox51 = this.PictureBox5;
			point = new Point(634, 34);
			pictureBox51.Location = point;
			this.PictureBox5.Name = "PictureBox5";
			PictureBox pictureBox52 = this.PictureBox5;
			size = new System.Drawing.Size(14, 14);
			pictureBox52.Size = size;
			this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox5.TabIndex = 194;
			this.PictureBox5.TabStop = false;
			this.PictureBox5.Tag = "AbstractRunSheet";
			this.lbl_doc_aboutVesting.AutoSize = true;
			this.lbl_doc_aboutVesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocAboutVesting = this.lbl_doc_aboutVesting;
			point = new Point(652, 34);
			lblDocAboutVesting.Location = point;
			this.lbl_doc_aboutVesting.Name = "lbl_doc_aboutVesting";
			Label lblDocAboutVesting1 = this.lbl_doc_aboutVesting;
			size = new System.Drawing.Size(73, 13);
			lblDocAboutVesting1.Size = size;
			this.lbl_doc_aboutVesting.TabIndex = 195;
			this.lbl_doc_aboutVesting.Text = "About Vesting";
			this.PictureBox4.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pictureBox41 = this.PictureBox4;
			point = new Point(634, 13);
			pictureBox41.Location = point;
			this.PictureBox4.Name = "PictureBox4";
			PictureBox pictureBox42 = this.PictureBox4;
			size = new System.Drawing.Size(14, 14);
			pictureBox42.Size = size;
			this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox4.TabIndex = 192;
			this.PictureBox4.TabStop = false;
			this.PictureBox4.Tag = "AbstractRunSheet";
			this.lbl_doc_aboutDeeds.AutoSize = true;
			this.lbl_doc_aboutDeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocAboutDeeds = this.lbl_doc_aboutDeeds;
			point = new Point(652, 13);
			lblDocAboutDeeds.Location = point;
			this.lbl_doc_aboutDeeds.Name = "lbl_doc_aboutDeeds";
			Label lblDocAboutDeeds1 = this.lbl_doc_aboutDeeds;
			size = new System.Drawing.Size(69, 13);
			lblDocAboutDeeds1.Size = size;
			this.lbl_doc_aboutDeeds.TabIndex = 193;
			this.lbl_doc_aboutDeeds.Text = "About Deeds";
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.txtSOL_notes, 0, 32);
			this.TableLayoutPanel1.Controls.Add(this.Label_statutecomments, 0, 31);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Tax_RedemPer, 1, 21);
			this.TableLayoutPanel1.Controls.Add(this.Label_forclRedem, 0, 20);
			this.TableLayoutPanel1.Controls.Add(this.Label_taxTakRedem, 0, 21);
			this.TableLayoutPanel1.Controls.Add(this.Label_mtg, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_forecl_redem_per, 1, 20);
			this.TableLayoutPanel1.Controls.Add(this.Label73, 1, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label46, 1, 15);
			this.TableLayoutPanel1.Controls.Add(this.Label74, 0, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label54, 1, 14);
			this.TableLayoutPanel1.Controls.Add(this.Label52, 0, 15);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Mtg, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label58, 0, 14);
			this.TableLayoutPanel1.Controls.Add(this.Label_heloc, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Heloc, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label_teRule, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_TERule, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label_spousal, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_PersTax, 1, 13);
			this.TableLayoutPanel1.Controls.Add(this.Label_persTax, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_ClaimLien, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_HOA, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Support, 1, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label_support, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label_claimLien, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Notice, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Hosp, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label_HOA, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label_hospLien, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Mech, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label_NOC, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_lispen, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label_mechLien, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label_lisPendens, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Jgmt, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label_jgmt, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Spousal, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label_stateJgmt, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_StateJgmt, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label_fc, 0, 23);
			this.TableLayoutPanel1.Controls.Add(this.txt_foreclosure_notes, 0, 24);
			this.TableLayoutPanel1.Controls.Add(this.Label_credclaim, 0, 25);
			this.TableLayoutPanel1.Controls.Add(this.Label_aftacq, 0, 26);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_Creditor_Claims, 1, 25);
			this.TableLayoutPanel1.Controls.Add(this.lblSOL_AftAcq, 1, 26);
			this.TableLayoutPanel1.Controls.Add(this.txt_ProbateInfo, 0, 29);
			this.TableLayoutPanel1.Controls.Add(this.Label_probate, 0, 28);
			TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel1;
			point = new Point(12, 6);
			tableLayoutPanel1.Location = point;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			TableLayoutPanel tableLayoutPanel11 = this.TableLayoutPanel1;
			padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
			tableLayoutPanel11.Padding = padding;
			this.TableLayoutPanel1.RowCount = 33;
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
			TableLayoutPanel tableLayoutPanel12 = this.TableLayoutPanel1;
			size = new System.Drawing.Size(453, 568);
			tableLayoutPanel12.Size = size;
			this.TableLayoutPanel1.TabIndex = 98;
			this.txtSOL_notes.BackColor = Color.Snow;
			this.TableLayoutPanel1.SetColumnSpan(this.txtSOL_notes, 2);
			this.txtSOL_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtSOL_notes.ForeColor = Color.Purple;
			TextBox txtSOLNotes = this.txtSOL_notes;
			point = new Point(3, 505);
			txtSOLNotes.Location = point;
			this.txtSOL_notes.Multiline = true;
			this.txtSOL_notes.Name = "txtSOL_notes";
			this.txtSOL_notes.ReadOnly = true;
			this.txtSOL_notes.ScrollBars = ScrollBars.Vertical;
			TextBox txtSOLNotes1 = this.txtSOL_notes;
			size = new System.Drawing.Size(447, 59);
			txtSOLNotes1.Size = size;
			this.txtSOL_notes.TabIndex = 97;
			this.Label_statutecomments.AutoSize = true;
			this.Label_statutecomments.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_statutecomments.ForeColor = Color.Black;
			Label labelStatutecomments = this.Label_statutecomments;
			point = new Point(3, 489);
			labelStatutecomments.Location = point;
			this.Label_statutecomments.Name = "Label_statutecomments";
			Label labelStatutecomments1 = this.Label_statutecomments;
			size = new System.Drawing.Size(114, 13);
			labelStatutecomments1.Size = size;
			this.Label_statutecomments.TabIndex = 107;
			this.Label_statutecomments.Text = "Statutes Comments::";
			this.lblSOL_Tax_RedemPer.AutoSize = true;
			this.lblSOL_Tax_RedemPer.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_Tax_RedemPer.ForeColor = Color.Black;
			Label lblSOLTaxRedemPer = this.lblSOL_Tax_RedemPer;
			point = new Point(154, 235);
			lblSOLTaxRedemPer.Location = point;
			this.lblSOL_Tax_RedemPer.Name = "lblSOL_Tax_RedemPer";
			Label lblSOLTaxRedemPer1 = this.lblSOL_Tax_RedemPer;
			size = new System.Drawing.Size(46, 13);
			lblSOLTaxRedemPer1.Size = size;
			this.lblSOL_Tax_RedemPer.TabIndex = 61;
			this.lblSOL_Tax_RedemPer.Text = "Label58";
			this.Label_forclRedem.AutoSize = true;
			this.Label_forclRedem.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_forclRedem.ForeColor = Color.Black;
			Label labelForclRedem = this.Label_forclRedem;
			point = new Point(3, 222);
			labelForclRedem.Location = point;
			this.Label_forclRedem.Name = "Label_forclRedem";
			Label labelForclRedem1 = this.Label_forclRedem;
			size = new System.Drawing.Size(143, 13);
			labelForclRedem1.Size = size;
			this.Label_forclRedem.TabIndex = 68;
			this.Label_forclRedem.Text = "Forclosure Redem. Period:";
			this.Label_taxTakRedem.AutoSize = true;
			this.Label_taxTakRedem.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_taxTakRedem.ForeColor = Color.Black;
			Label labelTaxTakRedem = this.Label_taxTakRedem;
			point = new Point(3, 235);
			labelTaxTakRedem.Location = point;
			this.Label_taxTakRedem.Name = "Label_taxTakRedem";
			Label labelTaxTakRedem1 = this.Label_taxTakRedem;
			size = new System.Drawing.Size(145, 13);
			labelTaxTakRedem1.Size = size;
			this.Label_taxTakRedem.TabIndex = 62;
			this.Label_taxTakRedem.Text = "Tax Taking Redem. Period:";
			this.Label_mtg.AutoSize = true;
			this.Label_mtg.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelMtg = this.Label_mtg;
			point = new Point(3, 1);
			labelMtg.Location = point;
			this.Label_mtg.Name = "Label_mtg";
			Label labelMtg1 = this.Label_mtg;
			size = new System.Drawing.Size(59, 13);
			labelMtg1.Size = size;
			this.Label_mtg.TabIndex = 0;
			this.Label_mtg.Text = "Mtg/DOT:";
			this.lblSOL_forecl_redem_per.AutoSize = true;
			this.lblSOL_forecl_redem_per.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_forecl_redem_per.ForeColor = Color.Black;
			Label lblSOLForeclRedemPer = this.lblSOL_forecl_redem_per;
			point = new Point(154, 222);
			lblSOLForeclRedemPer.Location = point;
			this.lblSOL_forecl_redem_per.Name = "lblSOL_forecl_redem_per";
			Label lblSOLForeclRedemPer1 = this.lblSOL_forecl_redem_per;
			size = new System.Drawing.Size(20, 13);
			lblSOLForeclRedemPer1.Size = size;
			this.lblSOL_forecl_redem_per.TabIndex = 67;
			this.lblSOL_forecl_redem_per.Text = "lbl";
			this.Label73.AutoSize = true;
			this.Label73.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label73.ForeColor = Color.Black;
			Label label73 = this.Label73;
			point = new Point(154, 209);
			label73.Location = point;
			this.Label73.Name = "Label73";
			Label label731 = this.Label73;
			size = new System.Drawing.Size(36, 13);
			label731.Size = size;
			this.Label73.TabIndex = 101;
			this.Label73.Text = "20 yrs";
			this.Label46.AutoSize = true;
			this.Label46.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label46.ForeColor = Color.Black;
			Label label46 = this.Label46;
			point = new Point(154, 196);
			label46.Location = point;
			this.Label46.Name = "Label46";
			Label label461 = this.Label46;
			size = new System.Drawing.Size(30, 13);
			label461.Size = size;
			this.Label46.TabIndex = 103;
			this.Label46.Text = "5 yrs";
			this.Label74.AutoSize = true;
			this.Label74.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label74.ForeColor = Color.Black;
			Label label74 = this.Label74;
			point = new Point(3, 209);
			label74.Location = point;
			this.Label74.Name = "Label74";
			Label label741 = this.Label74;
			size = new System.Drawing.Size(66, 13);
			label741.Size = size;
			this.Label74.TabIndex = 100;
			this.Label74.Text = "USA Jgmts:";
			this.Label54.AutoSize = true;
			this.Label54.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label54.ForeColor = Color.Black;
			Label label54 = this.Label54;
			point = new Point(154, 183);
			label54.Location = point;
			this.Label54.Name = "Label54";
			Label label541 = this.Label54;
			size = new System.Drawing.Size(82, 13);
			label541.Size = size;
			this.Label54.TabIndex = 105;
			this.Label54.Text = "10 yrs+30 days";
			this.Label52.AutoSize = true;
			this.Label52.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label52.ForeColor = Color.Black;
			Label label52 = this.Label52;
			point = new Point(3, 196);
			label52.Location = point;
			this.Label52.Name = "Label52";
			Label label521 = this.Label52;
			size = new System.Drawing.Size(37, 13);
			label521.Size = size;
			this.Label52.TabIndex = 102;
			this.Label52.Text = "UCCs:";
			this.lblSOL_Mtg.AutoSize = true;
			this.lblSOL_Mtg.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblSOLMtg = this.lblSOL_Mtg;
			point = new Point(154, 1);
			lblSOLMtg.Location = point;
			this.lblSOL_Mtg.Name = "lblSOL_Mtg";
			Label lblSOLMtg1 = this.lblSOL_Mtg;
			size = new System.Drawing.Size(46, 13);
			lblSOLMtg1.Size = size;
			this.lblSOL_Mtg.TabIndex = 1;
			this.lblSOL_Mtg.Text = "Label46";
			this.Label58.AutoSize = true;
			this.Label58.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label58.ForeColor = Color.Black;
			Label label58 = this.Label58;
			point = new Point(3, 183);
			label58.Location = point;
			this.Label58.Name = "Label58";
			Label label581 = this.Label58;
			size = new System.Drawing.Size(75, 13);
			label581.Size = size;
			this.Label58.TabIndex = 104;
			this.Label58.Text = "Fed Tax Lien:";
			this.Label_heloc.AutoSize = true;
			this.Label_heloc.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelHeloc = this.Label_heloc;
			point = new Point(3, 14);
			labelHeloc.Location = point;
			this.Label_heloc.Name = "Label_heloc";
			Label labelHeloc1 = this.Label_heloc;
			size = new System.Drawing.Size(45, 13);
			labelHeloc1.Size = size;
			this.Label_heloc.TabIndex = 2;
			this.Label_heloc.Text = "HELOC:";
			this.lblSOL_Heloc.AutoSize = true;
			this.lblSOL_Heloc.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblSOLHeloc = this.lblSOL_Heloc;
			point = new Point(154, 14);
			lblSOLHeloc.Location = point;
			this.lblSOL_Heloc.Name = "lblSOL_Heloc";
			Label lblSOLHeloc1 = this.lblSOL_Heloc;
			size = new System.Drawing.Size(46, 13);
			lblSOLHeloc1.Size = size;
			this.lblSOL_Heloc.TabIndex = 3;
			this.lblSOL_Heloc.Text = "Label52";
			this.Label_teRule.AutoSize = true;
			this.Label_teRule.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelTeRule = this.Label_teRule;
			point = new Point(3, 27);
			labelTeRule.Location = point;
			this.Label_teRule.Name = "Label_teRule";
			Label labelTeRule1 = this.Label_teRule;
			size = new System.Drawing.Size(48, 13);
			labelTeRule1.Size = size;
			this.Label_teRule.TabIndex = 55;
			this.Label_teRule.Text = "TE Rule:";
			this.lblSOL_TERule.AutoSize = true;
			this.lblSOL_TERule.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblSOLTERule = this.lblSOL_TERule;
			point = new Point(154, 27);
			lblSOLTERule.Location = point;
			this.lblSOL_TERule.Name = "lblSOL_TERule";
			Label lblSOLTERule1 = this.lblSOL_TERule;
			size = new System.Drawing.Size(46, 13);
			lblSOLTERule1.Size = size;
			this.lblSOL_TERule.TabIndex = 56;
			this.lblSOL_TERule.Text = "Label52";
			this.Label_spousal.AutoSize = true;
			this.Label_spousal.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label labelSpousal = this.Label_spousal;
			point = new Point(3, 40);
			labelSpousal.Location = point;
			this.Label_spousal.Name = "Label_spousal";
			Label labelSpousal1 = this.Label_spousal;
			size = new System.Drawing.Size(80, 13);
			labelSpousal1.Size = size;
			this.Label_spousal.TabIndex = 66;
			this.Label_spousal.Text = "Spousal State:";
			this.lblSOL_PersTax.AutoSize = true;
			this.lblSOL_PersTax.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_PersTax.ForeColor = Color.Black;
			Label lblSOLPersTax = this.lblSOL_PersTax;
			point = new Point(154, 170);
			lblSOLPersTax.Location = point;
			this.lblSOL_PersTax.Name = "lblSOL_PersTax";
			Label lblSOLPersTax1 = this.lblSOL_PersTax;
			size = new System.Drawing.Size(46, 13);
			lblSOLPersTax1.Size = size;
			this.lblSOL_PersTax.TabIndex = 98;
			this.lblSOL_PersTax.Text = "Label60";
			this.Label_persTax.AutoSize = true;
			this.Label_persTax.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_persTax.ForeColor = Color.Black;
			Label labelPersTax = this.Label_persTax;
			point = new Point(3, 170);
			labelPersTax.Location = point;
			this.Label_persTax.Name = "Label_persTax";
			Label labelPersTax1 = this.Label_persTax;
			size = new System.Drawing.Size(76, 13);
			labelPersTax1.Size = size;
			this.Label_persTax.TabIndex = 99;
			this.Label_persTax.Text = "Personal Tax:";
			this.lblSOL_ClaimLien.AutoSize = true;
			this.lblSOL_ClaimLien.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_ClaimLien.ForeColor = Color.Black;
			Label lblSOLClaimLien = this.lblSOL_ClaimLien;
			point = new Point(154, 144);
			lblSOLClaimLien.Location = point;
			this.lblSOL_ClaimLien.Name = "lblSOL_ClaimLien";
			Label lblSOLClaimLien1 = this.lblSOL_ClaimLien;
			size = new System.Drawing.Size(46, 13);
			lblSOLClaimLien1.Size = size;
			this.lblSOL_ClaimLien.TabIndex = 91;
			this.lblSOL_ClaimLien.Text = "Label68";
			this.lblSOL_HOA.AutoSize = true;
			this.lblSOL_HOA.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_HOA.ForeColor = Color.Black;
			Label lblSOLHOA = this.lblSOL_HOA;
			point = new Point(154, 118);
			lblSOLHOA.Location = point;
			this.lblSOL_HOA.Name = "lblSOL_HOA";
			Label lblSOLHOA1 = this.lblSOL_HOA;
			size = new System.Drawing.Size(46, 13);
			lblSOLHOA1.Size = size;
			this.lblSOL_HOA.TabIndex = 89;
			this.lblSOL_HOA.Text = "Label66";
			this.lblSOL_Support.AutoSize = true;
			this.lblSOL_Support.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_Support.ForeColor = Color.Black;
			Label lblSOLSupport = this.lblSOL_Support;
			point = new Point(154, 157);
			lblSOLSupport.Location = point;
			this.lblSOL_Support.Name = "lblSOL_Support";
			Label lblSOLSupport1 = this.lblSOL_Support;
			size = new System.Drawing.Size(46, 13);
			lblSOLSupport1.Size = size;
			this.lblSOL_Support.TabIndex = 81;
			this.lblSOL_Support.Text = "Label64";
			this.Label_support.AutoSize = true;
			this.Label_support.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_support.ForeColor = Color.Black;
			Label labelSupport = this.Label_support;
			point = new Point(3, 157);
			labelSupport.Location = point;
			this.Label_support.Name = "Label_support";
			Label labelSupport1 = this.Label_support;
			size = new System.Drawing.Size(73, 13);
			labelSupport1.Size = size;
			this.Label_support.TabIndex = 82;
			this.Label_support.Text = "Support Obl:";
			this.Label_claimLien.AutoSize = true;
			this.Label_claimLien.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_claimLien.ForeColor = Color.Black;
			Label labelClaimLien = this.Label_claimLien;
			point = new Point(3, 144);
			labelClaimLien.Location = point;
			this.Label_claimLien.Name = "Label_claimLien";
			Label labelClaimLien1 = this.Label_claimLien;
			size = new System.Drawing.Size(78, 13);
			labelClaimLien1.Size = size;
			this.Label_claimLien.TabIndex = 92;
			this.Label_claimLien.Text = "Claim of Lien:";
			this.lblSOL_Notice.AutoSize = true;
			this.lblSOL_Notice.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_Notice.ForeColor = Color.Black;
			Label lblSOLNotice = this.lblSOL_Notice;
			point = new Point(154, 105);
			lblSOLNotice.Location = point;
			this.lblSOL_Notice.Name = "lblSOL_Notice";
			Label lblSOLNotice1 = this.lblSOL_Notice;
			size = new System.Drawing.Size(46, 13);
			lblSOLNotice1.Size = size;
			this.lblSOL_Notice.TabIndex = 87;
			this.lblSOL_Notice.Text = "Label58";
			this.lblSOL_Hosp.AutoSize = true;
			this.lblSOL_Hosp.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_Hosp.ForeColor = Color.Black;
			Label lblSOLHosp = this.lblSOL_Hosp;
			point = new Point(154, 131);
			lblSOLHosp.Location = point;
			this.lblSOL_Hosp.Name = "lblSOL_Hosp";
			Label lblSOLHosp1 = this.lblSOL_Hosp;
			size = new System.Drawing.Size(46, 13);
			lblSOLHosp1.Size = size;
			this.lblSOL_Hosp.TabIndex = 95;
			this.lblSOL_Hosp.Text = "Label72";
			this.Label_HOA.AutoSize = true;
			this.Label_HOA.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_HOA.ForeColor = Color.Black;
			Label labelHOA = this.Label_HOA;
			point = new Point(3, 118);
			labelHOA.Location = point;
			this.Label_HOA.Name = "Label_HOA";
			Label labelHOA1 = this.Label_HOA;
			size = new System.Drawing.Size(59, 13);
			labelHOA1.Size = size;
			this.Label_HOA.TabIndex = 90;
			this.Label_HOA.Text = "HOA Lien:";
			this.Label_hospLien.AutoSize = true;
			this.Label_hospLien.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_hospLien.ForeColor = Color.Black;
			Label labelHospLien = this.Label_hospLien;
			point = new Point(3, 131);
			labelHospLien.Location = point;
			this.Label_hospLien.Name = "Label_hospLien";
			Label labelHospLien1 = this.Label_hospLien;
			size = new System.Drawing.Size(65, 13);
			labelHospLien1.Size = size;
			this.Label_hospLien.TabIndex = 96;
			this.Label_hospLien.Text = "Hosp. Lien:";
			this.lblSOL_Mech.AutoSize = true;
			this.lblSOL_Mech.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_Mech.ForeColor = Color.Black;
			Label lblSOLMech = this.lblSOL_Mech;
			point = new Point(154, 92);
			lblSOLMech.Location = point;
			this.lblSOL_Mech.Name = "lblSOL_Mech";
			Label lblSOLMech1 = this.lblSOL_Mech;
			size = new System.Drawing.Size(46, 13);
			lblSOLMech1.Size = size;
			this.lblSOL_Mech.TabIndex = 85;
			this.lblSOL_Mech.Text = "Label60";
			this.Label_NOC.AutoSize = true;
			this.Label_NOC.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_NOC.ForeColor = Color.Black;
			Label labelNOC = this.Label_NOC;
			point = new Point(3, 105);
			labelNOC.Location = point;
			this.Label_NOC.Name = "Label_NOC";
			Label labelNOC1 = this.Label_NOC;
			size = new System.Drawing.Size(107, 13);
			labelNOC1.Size = size;
			this.Label_NOC.TabIndex = 88;
			this.Label_NOC.Text = "Notice/Commence:";
			this.lblSOL_lispen.AutoSize = true;
			this.lblSOL_lispen.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_lispen.ForeColor = Color.Black;
			Label lblSOLLispen = this.lblSOL_lispen;
			point = new Point(154, 79);
			lblSOLLispen.Location = point;
			this.lblSOL_lispen.Name = "lblSOL_lispen";
			Label lblSOLLispen1 = this.lblSOL_lispen;
			size = new System.Drawing.Size(46, 13);
			lblSOLLispen1.Size = size;
			this.lblSOL_lispen.TabIndex = 80;
			this.lblSOL_lispen.Text = "Label54";
			this.Label_mechLien.AutoSize = true;
			this.Label_mechLien.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_mechLien.ForeColor = Color.Black;
			Label labelMechLien = this.Label_mechLien;
			point = new Point(3, 92);
			labelMechLien.Location = point;
			this.Label_mechLien.Name = "Label_mechLien";
			Label labelMechLien1 = this.Label_mechLien;
			size = new System.Drawing.Size(64, 13);
			labelMechLien1.Size = size;
			this.Label_mechLien.TabIndex = 86;
			this.Label_mechLien.Text = "Mech.Lien:";
			this.Label_lisPendens.AutoSize = true;
			this.Label_lisPendens.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_lisPendens.ForeColor = Color.Black;
			Label labelLisPendens = this.Label_lisPendens;
			point = new Point(3, 79);
			labelLisPendens.Location = point;
			this.Label_lisPendens.Name = "Label_lisPendens";
			Label labelLisPendens1 = this.Label_lisPendens;
			size = new System.Drawing.Size(69, 13);
			labelLisPendens1.Size = size;
			this.Label_lisPendens.TabIndex = 79;
			this.Label_lisPendens.Text = "LisPendens:";
			this.lblSOL_Jgmt.AutoSize = true;
			this.lblSOL_Jgmt.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_Jgmt.ForeColor = Color.Black;
			Label lblSOLJgmt = this.lblSOL_Jgmt;
			point = new Point(154, 53);
			lblSOLJgmt.Location = point;
			this.lblSOL_Jgmt.Name = "lblSOL_Jgmt";
			Label lblSOLJgmt1 = this.lblSOL_Jgmt;
			size = new System.Drawing.Size(46, 13);
			lblSOLJgmt1.Size = size;
			this.lblSOL_Jgmt.TabIndex = 93;
			this.lblSOL_Jgmt.Text = "Label70";
			this.Label_jgmt.AutoSize = true;
			this.Label_jgmt.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_jgmt.ForeColor = Color.Black;
			Label labelJgmt = this.Label_jgmt;
			point = new Point(3, 53);
			labelJgmt.Location = point;
			this.Label_jgmt.Name = "Label_jgmt";
			Label labelJgmt1 = this.Label_jgmt;
			size = new System.Drawing.Size(63, 13);
			labelJgmt1.Size = size;
			this.Label_jgmt.TabIndex = 94;
			this.Label_jgmt.Text = "Judgment:";
			this.lblSOL_Spousal.AutoSize = true;
			this.lblSOL_Spousal.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblSOLSpousal = this.lblSOL_Spousal;
			point = new Point(154, 40);
			lblSOLSpousal.Location = point;
			this.lblSOL_Spousal.Name = "lblSOL_Spousal";
			Label lblSOLSpousal1 = this.lblSOL_Spousal;
			size = new System.Drawing.Size(46, 13);
			lblSOLSpousal1.Size = size;
			this.lblSOL_Spousal.TabIndex = 65;
			this.lblSOL_Spousal.Text = "Label72";
			this.Label_stateJgmt.AutoSize = true;
			this.Label_stateJgmt.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_stateJgmt.ForeColor = Color.Black;
			Label labelStateJgmt = this.Label_stateJgmt;
			point = new Point(3, 66);
			labelStateJgmt.Location = point;
			this.Label_stateJgmt.Name = "Label_stateJgmt";
			Label labelStateJgmt1 = this.Label_stateJgmt;
			size = new System.Drawing.Size(65, 13);
			labelStateJgmt1.Size = size;
			this.Label_stateJgmt.TabIndex = 84;
			this.Label_stateJgmt.Text = "State Jgmt:";
			this.lblSOL_StateJgmt.AutoSize = true;
			this.lblSOL_StateJgmt.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_StateJgmt.ForeColor = Color.Black;
			Label lblSOLStateJgmt = this.lblSOL_StateJgmt;
			point = new Point(154, 66);
			lblSOLStateJgmt.Location = point;
			this.lblSOL_StateJgmt.Name = "lblSOL_StateJgmt";
			Label lblSOLStateJgmt1 = this.lblSOL_StateJgmt;
			size = new System.Drawing.Size(46, 13);
			lblSOLStateJgmt1.Size = size;
			this.lblSOL_StateJgmt.TabIndex = 83;
			this.lblSOL_StateJgmt.Text = "Label62";
			this.Label_fc.AutoSize = true;
			this.Label_fc.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_fc.ForeColor = Color.Black;
			Label labelFc = this.Label_fc;
			point = new Point(3, 268);
			labelFc.Location = point;
			this.Label_fc.Name = "Label_fc";
			Label labelFc1 = this.Label_fc;
			size = new System.Drawing.Size(94, 13);
			labelFc1.Size = size;
			this.Label_fc.TabIndex = 106;
			this.Label_fc.Text = "Foreclosure Info:";
			this.txt_foreclosure_notes.BackColor = Color.Snow;
			this.TableLayoutPanel1.SetColumnSpan(this.txt_foreclosure_notes, 2);
			this.txt_foreclosure_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_foreclosure_notes.ForeColor = Color.Purple;
			TextBox txtForeclosureNotes = this.txt_foreclosure_notes;
			point = new Point(3, 284);
			txtForeclosureNotes.Location = point;
			this.txt_foreclosure_notes.Multiline = true;
			this.txt_foreclosure_notes.Name = "txt_foreclosure_notes";
			this.txt_foreclosure_notes.ReadOnly = true;
			this.txt_foreclosure_notes.ScrollBars = ScrollBars.Vertical;
			TextBox txtForeclosureNotes1 = this.txt_foreclosure_notes;
			size = new System.Drawing.Size(447, 58);
			txtForeclosureNotes1.Size = size;
			this.txt_foreclosure_notes.TabIndex = 69;
			this.Label_credclaim.AutoSize = true;
			this.Label_credclaim.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_credclaim.ForeColor = Color.Black;
			Label labelCredclaim = this.Label_credclaim;
			point = new Point(3, 345);
			labelCredclaim.Location = point;
			this.Label_credclaim.Name = "Label_credclaim";
			Label labelCredclaim1 = this.Label_credclaim;
			size = new System.Drawing.Size(89, 13);
			labelCredclaim1.Size = size;
			this.Label_credclaim.TabIndex = 57;
			this.Label_credclaim.Text = "Creditor Claims:";
			this.Label_aftacq.AutoSize = true;
			this.Label_aftacq.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_aftacq.ForeColor = Color.Black;
			Label labelAftacq = this.Label_aftacq;
			point = new Point(3, 358);
			labelAftacq.Location = point;
			this.Label_aftacq.Name = "Label_aftacq";
			Label labelAftacq1 = this.Label_aftacq;
			size = new System.Drawing.Size(111, 13);
			labelAftacq1.Size = size;
			this.Label_aftacq.TabIndex = 53;
			this.Label_aftacq.Text = "After Acquired Lien:";
			this.lblSOL_Creditor_Claims.AutoSize = true;
			this.lblSOL_Creditor_Claims.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_Creditor_Claims.ForeColor = Color.Black;
			Label lblSOLCreditorClaims = this.lblSOL_Creditor_Claims;
			point = new Point(154, 345);
			lblSOLCreditorClaims.Location = point;
			this.lblSOL_Creditor_Claims.Name = "lblSOL_Creditor_Claims";
			Label lblSOLCreditorClaims1 = this.lblSOL_Creditor_Claims;
			size = new System.Drawing.Size(46, 13);
			lblSOLCreditorClaims1.Size = size;
			this.lblSOL_Creditor_Claims.TabIndex = 58;
			this.lblSOL_Creditor_Claims.Text = "Label54";
			this.lblSOL_AftAcq.AutoSize = true;
			this.lblSOL_AftAcq.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSOL_AftAcq.ForeColor = Color.Black;
			Label lblSOLAftAcq = this.lblSOL_AftAcq;
			point = new Point(154, 358);
			lblSOLAftAcq.Location = point;
			this.lblSOL_AftAcq.Name = "lblSOL_AftAcq";
			Label lblSOLAftAcq1 = this.lblSOL_AftAcq;
			size = new System.Drawing.Size(46, 13);
			lblSOLAftAcq1.Size = size;
			this.lblSOL_AftAcq.TabIndex = 54;
			this.lblSOL_AftAcq.Text = "Label46";
			this.txt_ProbateInfo.BackColor = Color.Snow;
			this.TableLayoutPanel1.SetColumnSpan(this.txt_ProbateInfo, 2);
			this.txt_ProbateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_ProbateInfo.ForeColor = Color.Purple;
			TextBox txtProbateInfo = this.txt_ProbateInfo;
			point = new Point(3, 407);
			txtProbateInfo.Location = point;
			this.txt_ProbateInfo.Multiline = true;
			this.txt_ProbateInfo.Name = "txt_ProbateInfo";
			this.txt_ProbateInfo.ReadOnly = true;
			this.txt_ProbateInfo.ScrollBars = ScrollBars.Vertical;
			TextBox txtProbateInfo1 = this.txt_ProbateInfo;
			size = new System.Drawing.Size(447, 59);
			txtProbateInfo1.Size = size;
			this.txt_ProbateInfo.TabIndex = 74;
			this.Label_probate.AutoSize = true;
			this.Label_probate.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label_probate.ForeColor = Color.Black;
			Label labelProbate2 = this.Label_probate;
			point = new Point(3, 391);
			labelProbate2.Location = point;
			this.Label_probate.Name = "Label_probate";
			Label labelProbate3 = this.Label_probate;
			size = new System.Drawing.Size(75, 13);
			labelProbate3.Size = size;
			this.Label_probate.TabIndex = 107;
			this.Label_probate.Text = "Probate Info:";
			this.TabPg5Req.AutoScroll = true;
			this.TabPg5Req.BackColor = Color.GhostWhite;
			this.TabPg5Req.Controls.Add(this.WebBrowser3);
			TabPage tabPg5Req = this.TabPg5Req;
			point = new Point(4, 22);
			tabPg5Req.Location = point;
			this.TabPg5Req.Name = "TabPg5Req";
			TabPage tabPg5Req1 = this.TabPg5Req;
			padding = new System.Windows.Forms.Padding(3);
			tabPg5Req1.Padding = padding;
			TabPage tabPg5Req2 = this.TabPg5Req;
			size = new System.Drawing.Size(866, 201);
			tabPg5Req2.Size = size;
			this.TabPg5Req.TabIndex = 5;
			this.TabPg5Req.Text = "Search Requirements";
			this.WebBrowser3.Dock = DockStyle.Fill;
			WebBrowser webBrowser3 = this.WebBrowser3;
			point = new Point(3, 3);
			webBrowser3.Location = point;
			WebBrowser webBrowser = this.WebBrowser3;
			size = new System.Drawing.Size(20, 20);
			webBrowser.MinimumSize = size;
			this.WebBrowser3.Name = "WebBrowser3";
			WebBrowser webBrowser31 = this.WebBrowser3;
			size = new System.Drawing.Size(860, 195);
			webBrowser31.Size = size;
			this.WebBrowser3.TabIndex = 1;
			this.WebBrowser3.Url = new Uri("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\Title Insurance Search Requirements.htm", UriKind.Absolute);
			this.TabPg6OtherLogins.BackColor = Color.GhostWhite;
			this.TabPg6OtherLogins.Controls.Add(this.DataGridView2);
			TabPage tabPg6OtherLogins = this.TabPg6OtherLogins;
			point = new Point(4, 22);
			tabPg6OtherLogins.Location = point;
			this.TabPg6OtherLogins.Name = "TabPg6OtherLogins";
			TabPage tabPg6OtherLogins1 = this.TabPg6OtherLogins;
			padding = new System.Windows.Forms.Padding(3);
			tabPg6OtherLogins1.Padding = padding;
			TabPage tabPg6OtherLogins2 = this.TabPg6OtherLogins;
			size = new System.Drawing.Size(866, 201);
			tabPg6OtherLogins2.Size = size;
			this.TabPg6OtherLogins.TabIndex = 6;
			this.TabPg6OtherLogins.Text = "Other Login Info";
			thistle.BackColor = Color.Thistle;
			thistle.SelectionBackColor = Color.FromArgb(192, 255, 255);
			thistle.SelectionForeColor = Color.Indigo;
			this.DataGridView2.AlternatingRowsDefaultCellStyle = thistle;
			this.DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.DataGridView2.BackgroundColor = Color.Linen;
			this.DataGridView2.BorderStyle = BorderStyle.None;
			this.DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
			font.Alignment = DataGridViewContentAlignment.MiddleLeft;
			font.BackColor = Color.WhiteSmoke;
			font.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			font.ForeColor = SystemColors.WindowText;
			font.SelectionBackColor = Color.Aquamarine;
			font.SelectionForeColor = SystemColors.ControlText;
			font.WrapMode = DataGridViewTriState.True;
			this.DataGridView2.ColumnHeadersDefaultCellStyle = font;
			this.DataGridView2.Cursor = Cursors.Default;
			controlText.Alignment = DataGridViewContentAlignment.MiddleLeft;
			controlText.BackColor = SystemColors.Window;
			controlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			controlText.ForeColor = SystemColors.ControlText;
			controlText.SelectionBackColor = Color.White;
			controlText.SelectionForeColor = SystemColors.ControlText;
			controlText.WrapMode = DataGridViewTriState.False;
			this.DataGridView2.DefaultCellStyle = controlText;
			this.DataGridView2.Dock = DockStyle.Fill;
			this.DataGridView2.GridColor = Color.MediumOrchid;
			DataGridView dataGridView2 = this.DataGridView2;
			point = new Point(3, 3);
			dataGridView2.Location = point;
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.RowHeadersWidth = 20;
			indigo.BackColor = Color.LavenderBlush;
			indigo.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			indigo.ForeColor = Color.Indigo;
			indigo.SelectionBackColor = Color.MediumPurple;
			indigo.SelectionForeColor = Color.White;
			indigo.WrapMode = DataGridViewTriState.True;
			this.DataGridView2.RowsDefaultCellStyle = indigo;
			this.DataGridView2.RowTemplate.Resizable = DataGridViewTriState.True;
			DataGridView dataGridView21 = this.DataGridView2;
			size = new System.Drawing.Size(860, 195);
			dataGridView21.Size = size;
			this.DataGridView2.TabIndex = 74;
			this.TabPg7Taxes.AutoScroll = true;
			this.TabPg7Taxes.BackColor = Color.GhostWhite;
			this.TabPg7Taxes.Controls.Add(this.lbl_verifDate5);
			this.TabPg7Taxes.Controls.Add(this.lbl_verified_taxoff5);
			this.TabPg7Taxes.Controls.Add(this.lbl_verifDate4);
			this.TabPg7Taxes.Controls.Add(this.lbl_verified_taxoff4);
			this.TabPg7Taxes.Controls.Add(this.lbl_verifDate3);
			this.TabPg7Taxes.Controls.Add(this.lbl_verified_taxoff3);
			this.TabPg7Taxes.Controls.Add(this.lbl_verifDate2);
			this.TabPg7Taxes.Controls.Add(this.lbl_verified_taxoff2);
			this.TabPg7Taxes.Controls.Add(this.lbl_verifDate1);
			this.TabPg7Taxes.Controls.Add(this.lbl_verified_taxoff1);
			this.TabPg7Taxes.Controls.Add(this.Label39);
			this.TabPg7Taxes.Controls.Add(this.txtTaxOffice1);
			this.TabPg7Taxes.Controls.Add(this.txtTaxOffice2);
			this.TabPg7Taxes.Controls.Add(this.txtTaxOffice3);
			this.TabPg7Taxes.Controls.Add(this.txtTaxOffice4);
			this.TabPg7Taxes.Controls.Add(this.txtTaxOffice5);
			this.TabPg7Taxes.Controls.Add(this.lblTxAuth1);
			this.TabPg7Taxes.Controls.Add(this.linkLocTax1);
			this.TabPg7Taxes.Controls.Add(this.linkLocTax5);
			this.TabPg7Taxes.Controls.Add(this.lblTxAuth5);
			this.TabPg7Taxes.Controls.Add(this.lblTxAuth2);
			this.TabPg7Taxes.Controls.Add(this.linkLocTax2);
			this.TabPg7Taxes.Controls.Add(this.linkLocTax4);
			this.TabPg7Taxes.Controls.Add(this.lblTxAuth4);
			this.TabPg7Taxes.Controls.Add(this.lblTxAuth3);
			this.TabPg7Taxes.Controls.Add(this.linkLocTax3);
			this.TabPg7Taxes.Controls.Add(this.pbxExport);
			this.TabPg7Taxes.Controls.Add(this.pbxCopy5);
			this.TabPg7Taxes.Controls.Add(this.pbxCopy4);
			this.TabPg7Taxes.Controls.Add(this.pbxCopy3);
			this.TabPg7Taxes.Controls.Add(this.pbxCopy2);
			this.TabPg7Taxes.Controls.Add(this.pbxCopy1);
			TabPage tabPg7Taxes = this.TabPg7Taxes;
			point = new Point(4, 22);
			tabPg7Taxes.Location = point;
			this.TabPg7Taxes.Name = "TabPg7Taxes";
			TabPage tabPg7Taxes1 = this.TabPg7Taxes;
			padding = new System.Windows.Forms.Padding(3);
			tabPg7Taxes1.Padding = padding;
			TabPage tabPg7Taxes2 = this.TabPg7Taxes;
			size = new System.Drawing.Size(866, 201);
			tabPg7Taxes2.Size = size;
			this.TabPg7Taxes.TabIndex = 7;
			this.TabPg7Taxes.Text = "Taxes";
			this.lbl_verifDate5.AutoSize = true;
			Label lblVerifDate5 = this.lbl_verifDate5;
			point = new Point(438, 383);
			lblVerifDate5.Location = point;
			this.lbl_verifDate5.Name = "lbl_verifDate5";
			Label lblVerifDate51 = this.lbl_verifDate5;
			size = new System.Drawing.Size(30, 13);
			lblVerifDate51.Size = size;
			this.lbl_verifDate5.TabIndex = 209;
			this.lbl_verifDate5.Text = "Date";
			this.lbl_verified_taxoff5.AutoSize = true;
			Label lblVerifiedTaxoff5 = this.lbl_verified_taxoff5;
			point = new Point(438, 357);
			lblVerifiedTaxoff5.Location = point;
			this.lbl_verified_taxoff5.Name = "lbl_verified_taxoff5";
			Label lblVerifiedTaxoff51 = this.lbl_verified_taxoff5;
			size = new System.Drawing.Size(48, 13);
			lblVerifiedTaxoff51.Size = size;
			this.lbl_verified_taxoff5.TabIndex = 208;
			this.lbl_verified_taxoff5.Text = "Verified?";
			this.lbl_verifDate4.AutoSize = true;
			Label lblVerifDate4 = this.lbl_verifDate4;
			point = new Point(438, 304);
			lblVerifDate4.Location = point;
			this.lbl_verifDate4.Name = "lbl_verifDate4";
			Label lblVerifDate41 = this.lbl_verifDate4;
			size = new System.Drawing.Size(30, 13);
			lblVerifDate41.Size = size;
			this.lbl_verifDate4.TabIndex = 207;
			this.lbl_verifDate4.Text = "Date";
			this.lbl_verified_taxoff4.AutoSize = true;
			Label lblVerifiedTaxoff4 = this.lbl_verified_taxoff4;
			point = new Point(438, 278);
			lblVerifiedTaxoff4.Location = point;
			this.lbl_verified_taxoff4.Name = "lbl_verified_taxoff4";
			Label lblVerifiedTaxoff41 = this.lbl_verified_taxoff4;
			size = new System.Drawing.Size(48, 13);
			lblVerifiedTaxoff41.Size = size;
			this.lbl_verified_taxoff4.TabIndex = 206;
			this.lbl_verified_taxoff4.Text = "Verified?";
			this.lbl_verifDate3.AutoSize = true;
			Label lblVerifDate3 = this.lbl_verifDate3;
			point = new Point(438, 229);
			lblVerifDate3.Location = point;
			this.lbl_verifDate3.Name = "lbl_verifDate3";
			Label lblVerifDate31 = this.lbl_verifDate3;
			size = new System.Drawing.Size(30, 13);
			lblVerifDate31.Size = size;
			this.lbl_verifDate3.TabIndex = 205;
			this.lbl_verifDate3.Text = "Date";
			this.lbl_verified_taxoff3.AutoSize = true;
			Label lblVerifiedTaxoff3 = this.lbl_verified_taxoff3;
			point = new Point(438, 203);
			lblVerifiedTaxoff3.Location = point;
			this.lbl_verified_taxoff3.Name = "lbl_verified_taxoff3";
			Label lblVerifiedTaxoff31 = this.lbl_verified_taxoff3;
			size = new System.Drawing.Size(48, 13);
			lblVerifiedTaxoff31.Size = size;
			this.lbl_verified_taxoff3.TabIndex = 204;
			this.lbl_verified_taxoff3.Text = "Verified?";
			this.lbl_verifDate2.AutoSize = true;
			Label lblVerifDate2 = this.lbl_verifDate2;
			point = new Point(438, 146);
			lblVerifDate2.Location = point;
			this.lbl_verifDate2.Name = "lbl_verifDate2";
			Label lblVerifDate21 = this.lbl_verifDate2;
			size = new System.Drawing.Size(30, 13);
			lblVerifDate21.Size = size;
			this.lbl_verifDate2.TabIndex = 203;
			this.lbl_verifDate2.Text = "Date";
			this.lbl_verified_taxoff2.AutoSize = true;
			Label lblVerifiedTaxoff2 = this.lbl_verified_taxoff2;
			point = new Point(438, 120);
			lblVerifiedTaxoff2.Location = point;
			this.lbl_verified_taxoff2.Name = "lbl_verified_taxoff2";
			Label lblVerifiedTaxoff21 = this.lbl_verified_taxoff2;
			size = new System.Drawing.Size(48, 13);
			lblVerifiedTaxoff21.Size = size;
			this.lbl_verified_taxoff2.TabIndex = 202;
			this.lbl_verified_taxoff2.Text = "Verified?";
			this.lbl_verifDate1.AutoSize = true;
			Label lblVerifDate1 = this.lbl_verifDate1;
			point = new Point(438, 64);
			lblVerifDate1.Location = point;
			this.lbl_verifDate1.Name = "lbl_verifDate1";
			Label lblVerifDate11 = this.lbl_verifDate1;
			size = new System.Drawing.Size(30, 13);
			lblVerifDate11.Size = size;
			this.lbl_verifDate1.TabIndex = 201;
			this.lbl_verifDate1.Text = "Date";
			this.lbl_verified_taxoff1.AutoSize = true;
			Label lblVerifiedTaxoff1 = this.lbl_verified_taxoff1;
			point = new Point(438, 38);
			lblVerifiedTaxoff1.Location = point;
			this.lbl_verified_taxoff1.Name = "lbl_verified_taxoff1";
			Label lblVerifiedTaxoff11 = this.lbl_verified_taxoff1;
			size = new System.Drawing.Size(48, 13);
			lblVerifiedTaxoff11.Size = size;
			this.lbl_verified_taxoff1.TabIndex = 200;
			this.lbl_verified_taxoff1.Text = "Verified?";
			this.Label39.AutoSize = true;
			this.Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label39 = this.Label39;
			point = new Point(573, 27);
			label39.Location = point;
			this.Label39.Name = "Label39";
			Label label391 = this.Label39;
			size = new System.Drawing.Size(158, 18);
			label391.Size = size;
			this.Label39.TabIndex = 199;
			this.Label39.Text = "Export Taxes To Word";
			this.txtTaxOffice1.BackColor = Color.MintCream;
			this.txtTaxOffice1.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTaxOffice1.ForeColor = Color.Purple;
			TextBox textBox7 = this.txtTaxOffice1;
			point = new Point(49, 28);
			textBox7.Location = point;
			this.txtTaxOffice1.Multiline = true;
			this.txtTaxOffice1.Name = "txtTaxOffice1";
			this.txtTaxOffice1.ReadOnly = true;
			this.txtTaxOffice1.ScrollBars = ScrollBars.Vertical;
			TextBox textBox8 = this.txtTaxOffice1;
			size = new System.Drawing.Size(373, 60);
			textBox8.Size = size;
			this.txtTaxOffice1.TabIndex = 178;
			this.txtTaxOffice1.Text = "no data";
			this.txtTaxOffice2.BackColor = Color.MintCream;
			this.txtTaxOffice2.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTaxOffice2.ForeColor = Color.Purple;
			TextBox textBox9 = this.txtTaxOffice2;
			point = new Point(49, 107);
			textBox9.Location = point;
			this.txtTaxOffice2.Multiline = true;
			this.txtTaxOffice2.Name = "txtTaxOffice2";
			this.txtTaxOffice2.ReadOnly = true;
			this.txtTaxOffice2.ScrollBars = ScrollBars.Vertical;
			TextBox textBox10 = this.txtTaxOffice2;
			size = new System.Drawing.Size(373, 60);
			textBox10.Size = size;
			this.txtTaxOffice2.TabIndex = 179;
			this.txtTaxOffice2.Text = "no data";
			this.txtTaxOffice3.BackColor = Color.MintCream;
			this.txtTaxOffice3.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTaxOffice3.ForeColor = Color.Purple;
			TextBox textBox11 = this.txtTaxOffice3;
			point = new Point(49, 190);
			textBox11.Location = point;
			this.txtTaxOffice3.Multiline = true;
			this.txtTaxOffice3.Name = "txtTaxOffice3";
			this.txtTaxOffice3.ReadOnly = true;
			this.txtTaxOffice3.ScrollBars = ScrollBars.Vertical;
			TextBox textBox12 = this.txtTaxOffice3;
			size = new System.Drawing.Size(373, 60);
			textBox12.Size = size;
			this.txtTaxOffice3.TabIndex = 180;
			this.txtTaxOffice3.Text = "no data";
			this.txtTaxOffice4.BackColor = Color.MintCream;
			this.txtTaxOffice4.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTaxOffice4.ForeColor = Color.Purple;
			TextBox textBox13 = this.txtTaxOffice4;
			point = new Point(49, 268);
			textBox13.Location = point;
			this.txtTaxOffice4.Multiline = true;
			this.txtTaxOffice4.Name = "txtTaxOffice4";
			this.txtTaxOffice4.ReadOnly = true;
			this.txtTaxOffice4.ScrollBars = ScrollBars.Vertical;
			TextBox textBox14 = this.txtTaxOffice4;
			size = new System.Drawing.Size(373, 60);
			textBox14.Size = size;
			this.txtTaxOffice4.TabIndex = 181;
			this.txtTaxOffice4.Text = "no data";
			this.txtTaxOffice5.BackColor = Color.MintCream;
			this.txtTaxOffice5.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTaxOffice5.ForeColor = Color.Purple;
			TextBox textBox15 = this.txtTaxOffice5;
			point = new Point(48, 347);
			textBox15.Location = point;
			this.txtTaxOffice5.Multiline = true;
			this.txtTaxOffice5.Name = "txtTaxOffice5";
			this.txtTaxOffice5.ReadOnly = true;
			this.txtTaxOffice5.ScrollBars = ScrollBars.Vertical;
			TextBox textBox16 = this.txtTaxOffice5;
			size = new System.Drawing.Size(373, 60);
			textBox16.Size = size;
			this.txtTaxOffice5.TabIndex = 182;
			this.txtTaxOffice5.Text = "no data";
			this.lblTxAuth1.AutoSize = true;
			Label label18 = this.lblTxAuth1;
			point = new Point(51, 12);
			label18.Location = point;
			this.lblTxAuth1.Name = "lblTxAuth1";
			Label label22 = this.lblTxAuth1;
			size = new System.Drawing.Size(62, 13);
			label22.Size = size;
			this.lblTxAuth1.TabIndex = 183;
			this.lblTxAuth1.Text = "Tax Office1";
			this.linkLocTax1.ActiveLinkColor = Color.MediumOrchid;
			this.linkLocTax1.AutoSize = true;
			this.linkLocTax1.LinkColor = Color.Purple;
			LinkLabel linkLabel1 = this.linkLocTax1;
			point = new Point(345, 12);
			linkLabel1.Location = point;
			this.linkLocTax1.Name = "linkLocTax1";
			LinkLabel linkLabel2 = this.linkLocTax1;
			size = new System.Drawing.Size(57, 13);
			linkLabel2.Size = size;
			this.linkLocTax1.TabIndex = 188;
			this.linkLocTax1.TabStop = true;
			this.linkLocTax1.Text = "Tax Web1";
			this.linkLocTax1.VisitedLinkColor = Color.DarkSlateBlue;
			this.linkLocTax5.ActiveLinkColor = Color.MediumOrchid;
			this.linkLocTax5.AutoSize = true;
			this.linkLocTax5.LinkColor = Color.Purple;
			LinkLabel linkLabel3 = this.linkLocTax5;
			point = new Point(344, 331);
			linkLabel3.Location = point;
			this.linkLocTax5.Name = "linkLocTax5";
			LinkLabel linkLabel4 = this.linkLocTax5;
			size = new System.Drawing.Size(57, 13);
			linkLabel4.Size = size;
			this.linkLocTax5.TabIndex = 192;
			this.linkLocTax5.TabStop = true;
			this.linkLocTax5.Text = "Tax Web5";
			this.linkLocTax5.VisitedLinkColor = Color.DarkSlateBlue;
			this.lblTxAuth5.AutoSize = true;
			Label label23 = this.lblTxAuth5;
			point = new Point(50, 331);
			label23.Location = point;
			this.lblTxAuth5.Name = "lblTxAuth5";
			Label label24 = this.lblTxAuth5;
			size = new System.Drawing.Size(62, 13);
			label24.Size = size;
			this.lblTxAuth5.TabIndex = 187;
			this.lblTxAuth5.Text = "Tax Office5";
			this.lblTxAuth2.AutoSize = true;
			Label label25 = this.lblTxAuth2;
			point = new Point(51, 91);
			label25.Location = point;
			this.lblTxAuth2.Name = "lblTxAuth2";
			Label label33 = this.lblTxAuth2;
			size = new System.Drawing.Size(62, 13);
			label33.Size = size;
			this.lblTxAuth2.TabIndex = 184;
			this.lblTxAuth2.Text = "Tax Office2";
			this.linkLocTax2.ActiveLinkColor = Color.MediumOrchid;
			this.linkLocTax2.AutoSize = true;
			this.linkLocTax2.LinkColor = Color.Purple;
			LinkLabel linkLabel5 = this.linkLocTax2;
			point = new Point(345, 91);
			linkLabel5.Location = point;
			this.linkLocTax2.Name = "linkLocTax2";
			LinkLabel linkLabel6 = this.linkLocTax2;
			size = new System.Drawing.Size(57, 13);
			linkLabel6.Size = size;
			this.linkLocTax2.TabIndex = 189;
			this.linkLocTax2.TabStop = true;
			this.linkLocTax2.Text = "Tax Web2";
			this.linkLocTax2.VisitedLinkColor = Color.DarkSlateBlue;
			this.linkLocTax4.ActiveLinkColor = Color.MediumOrchid;
			this.linkLocTax4.AutoSize = true;
			this.linkLocTax4.LinkColor = Color.Purple;
			LinkLabel linkLabel7 = this.linkLocTax4;
			point = new Point(345, 252);
			linkLabel7.Location = point;
			this.linkLocTax4.Name = "linkLocTax4";
			LinkLabel linkLabel8 = this.linkLocTax4;
			size = new System.Drawing.Size(57, 13);
			linkLabel8.Size = size;
			this.linkLocTax4.TabIndex = 191;
			this.linkLocTax4.TabStop = true;
			this.linkLocTax4.Text = "Tax Web4";
			this.linkLocTax4.VisitedLinkColor = Color.DarkSlateBlue;
			this.lblTxAuth4.AutoSize = true;
			Label label37 = this.lblTxAuth4;
			point = new Point(51, 252);
			label37.Location = point;
			this.lblTxAuth4.Name = "lblTxAuth4";
			Label label38 = this.lblTxAuth4;
			size = new System.Drawing.Size(62, 13);
			label38.Size = size;
			this.lblTxAuth4.TabIndex = 186;
			this.lblTxAuth4.Text = "Tax Office4";
			this.lblTxAuth3.AutoSize = true;
			Label label42 = this.lblTxAuth3;
			point = new Point(51, 174);
			label42.Location = point;
			this.lblTxAuth3.Name = "lblTxAuth3";
			Label label43 = this.lblTxAuth3;
			size = new System.Drawing.Size(62, 13);
			label43.Size = size;
			this.lblTxAuth3.TabIndex = 185;
			this.lblTxAuth3.Text = "Tax Office3";
			this.linkLocTax3.ActiveLinkColor = Color.MediumOrchid;
			this.linkLocTax3.AutoSize = true;
			this.linkLocTax3.LinkColor = Color.Purple;
			LinkLabel linkLabel11 = this.linkLocTax3;
			point = new Point(345, 174);
			linkLabel11.Location = point;
			this.linkLocTax3.Name = "linkLocTax3";
			LinkLabel linkLabel12 = this.linkLocTax3;
			size = new System.Drawing.Size(57, 13);
			linkLabel12.Size = size;
			this.linkLocTax3.TabIndex = 190;
			this.linkLocTax3.TabStop = true;
			this.linkLocTax3.Text = "Tax Web3";
			this.linkLocTax3.VisitedLinkColor = Color.DarkSlateBlue;
			this.pbxExport.Image = WindowsApplication1.My.Resources.Resources.doc_icon;
			this.pbxExport.Click = new EventHandler(form1.pbxExport_Click);
			PictureBox pictureBox10 = this.pbxExport;
			point = new Point(542, 22);
			pictureBox10.Location = point;
			this.pbxExport.Name = "pbxExport";
			PictureBox pictureBox11 = this.pbxExport;
			size = new System.Drawing.Size(23, 25);
			pictureBox11.Size = size;
			this.pbxExport.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbxExport.TabIndex = 198;
			this.pbxExport.TabStop = false;
			this.pbxExport.Tag = "clipboard";
			this.pbxCopy5.Image = WindowsApplication1.My.Resources.Resources.clipboard;
			PictureBox pictureBox12 = this.pbxCopy5;
			point = new Point(21, 347);
			pictureBox12.Location = point;
			this.pbxCopy5.Name = "pbxCopy5";
			PictureBox pictureBox13 = this.pbxCopy5;
			size = new System.Drawing.Size(21, 23);
			pictureBox13.Size = size;
			this.pbxCopy5.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbxCopy5.TabIndex = 197;
			this.pbxCopy5.TabStop = false;
			this.pbxCopy5.Tag = "clipboard";
			this.pbxCopy4.Image = WindowsApplication1.My.Resources.Resources.clipboard;
			PictureBox pictureBox14 = this.pbxCopy4;
			point = new Point(22, 268);
			pictureBox14.Location = point;
			this.pbxCopy4.Name = "pbxCopy4";
			PictureBox pictureBox15 = this.pbxCopy4;
			size = new System.Drawing.Size(21, 23);
			pictureBox15.Size = size;
			this.pbxCopy4.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbxCopy4.TabIndex = 196;
			this.pbxCopy4.TabStop = false;
			this.pbxCopy4.Tag = "clipboard";
			this.pbxCopy3.Image = WindowsApplication1.My.Resources.Resources.clipboard;
			PictureBox pictureBox16 = this.pbxCopy3;
			point = new Point(22, 190);
			pictureBox16.Location = point;
			this.pbxCopy3.Name = "pbxCopy3";
			PictureBox pictureBox17 = this.pbxCopy3;
			size = new System.Drawing.Size(21, 23);
			pictureBox17.Size = size;
			this.pbxCopy3.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbxCopy3.TabIndex = 195;
			this.pbxCopy3.TabStop = false;
			this.pbxCopy3.Tag = "clipboard";
			this.pbxCopy2.Image = WindowsApplication1.My.Resources.Resources.clipboard;
			PictureBox pictureBox18 = this.pbxCopy2;
			point = new Point(22, 107);
			pictureBox18.Location = point;
			this.pbxCopy2.Name = "pbxCopy2";
			PictureBox pictureBox19 = this.pbxCopy2;
			size = new System.Drawing.Size(21, 23);
			pictureBox19.Size = size;
			this.pbxCopy2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbxCopy2.TabIndex = 194;
			this.pbxCopy2.TabStop = false;
			this.pbxCopy2.Tag = "clipboard";
			this.pbxCopy1.Image = WindowsApplication1.My.Resources.Resources.clipboard;
			PictureBox pictureBox20 = this.pbxCopy1;
			point = new Point(22, 28);
			pictureBox20.Location = point;
			this.pbxCopy1.Name = "pbxCopy1";
			PictureBox pictureBox21 = this.pbxCopy1;
			size = new System.Drawing.Size(21, 23);
			pictureBox21.Size = size;
			this.pbxCopy1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pbxCopy1.TabIndex = 193;
			this.pbxCopy1.TabStop = false;
			this.pbxCopy1.Tag = "clipboard";
			this.TabPg8UWMan.AutoScroll = true;
			this.TabPg8UWMan.BackColor = Color.GhostWhite;
			this.TabPg8UWMan.BorderStyle = BorderStyle.Fixed3D;
			this.TabPg8UWMan.Controls.Add(this.WebBrowser1);
			TabPage tabPg8UWMan = this.TabPg8UWMan;
			point = new Point(4, 22);
			tabPg8UWMan.Location = point;
			this.TabPg8UWMan.Name = "TabPg8UWMan";
			TabPage tabPg8UWMan1 = this.TabPg8UWMan;
			padding = new System.Windows.Forms.Padding(3);
			tabPg8UWMan1.Padding = padding;
			TabPage tabPg8UWMan2 = this.TabPg8UWMan;
			size = new System.Drawing.Size(866, 201);
			tabPg8UWMan2.Size = size;
			this.TabPg8UWMan.TabIndex = 8;
			this.TabPg8UWMan.Text = "Underwriting Manual";
			this.WebBrowser1.Dock = DockStyle.Fill;
			WebBrowser webBrowser1 = this.WebBrowser1;
			point = new Point(3, 3);
			webBrowser1.Location = point;
			WebBrowser webBrowser11 = this.WebBrowser1;
			size = new System.Drawing.Size(20, 20);
			webBrowser11.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			WebBrowser webBrowser12 = this.WebBrowser1;
			size = new System.Drawing.Size(856, 191);
			webBrowser12.Size = size;
			this.WebBrowser1.TabIndex = 77;
			this.WebBrowser1.Url = new Uri("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\IMS NATIONAL UNDERWRITING MANUAL.htm", UriKind.Absolute);
			this.TabPage1.AutoScroll = true;
			this.TabPage1.BackColor = Color.AliceBlue;
			this.TabPage1.Controls.Add(this.GroupBox1);
			this.TabPage1.Controls.Add(this.Label121);
			this.TabPage1.Controls.Add(this.Label118);
			this.TabPage1.Controls.Add(this.Label21);
			this.TabPage1.Controls.Add(this.cbox_StatsTaxCounties);
			this.TabPage1.Controls.Add(this.txt_StatsTaxOffices);
			this.TabPage1.Controls.Add(this.lbl_TaxOnlineStats);
			this.TabPage1.Controls.Add(this.Label14);
			this.TabPage1.Controls.Add(this.lbl_OrbStat6);
			this.TabPage1.Controls.Add(this.Label37);
			this.TabPage1.Controls.Add(this.cbox_StatsStates);
			this.TabPage1.Controls.Add(this.Label25);
			this.TabPage1.Controls.Add(this.Label23);
			this.TabPage1.Controls.Add(this.lbl_OrbStats);
			this.TabPage1.Controls.Add(this.lbl_OrbStat5);
			this.TabPage1.Controls.Add(this.txt_StatsCounties);
			this.TabPage1.Controls.Add(this.lbl_OrbStat4);
			this.TabPage1.Controls.Add(this.lbl_OrbStat3);
			this.TabPage1.Controls.Add(this.lbl_OrbStat2);
			this.TabPage1.Controls.Add(this.lbl_OrbStat1);
			this.TabPage1.Controls.Add(this.lbl_CoOnlineStats);
			this.TabPage1.Controls.Add(this.Label120);
			this.TabPage1.Controls.Add(this.Label119);
			this.TabPage1.Controls.Add(this.Label116);
			this.TabPage1.Controls.Add(this.Label115);
			TabPage tabPage11 = this.TabPage1;
			point = new Point(4, 22);
			tabPage11.Location = point;
			this.TabPage1.Name = "TabPage1";
			TabPage tabPage12 = this.TabPage1;
			padding = new System.Windows.Forms.Padding(3);
			tabPage12.Padding = padding;
			TabPage tabPage2 = this.TabPage1;
			size = new System.Drawing.Size(866, 201);
			tabPage2.Size = size;
			this.TabPage1.TabIndex = 9;
			this.TabPage1.Text = "Statistics";
			this.GroupBox1.Controls.Add(this.lbl_vstats_YTD);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Jan);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Dec);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Feb);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Nov);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Mar);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Oct);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Apr);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Sep);
			this.GroupBox1.Controls.Add(this.lbl_vstats_May);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Aug);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Jun);
			this.GroupBox1.Controls.Add(this.lbl_vstats_Jul);
			GroupBox groupBox11 = this.GroupBox1;
			point = new Point(15, 19);
			groupBox11.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox12 = this.GroupBox1;
			size = new System.Drawing.Size(237, 161);
			groupBox12.Size = size;
			this.GroupBox1.TabIndex = 36;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Online Searches Completed - 2008";
			this.lbl_vstats_YTD.AutoSize = true;
			Label lblVstatsYTD = this.lbl_vstats_YTD;
			point = new Point(23, 22);
			lblVstatsYTD.Location = point;
			this.lbl_vstats_YTD.Name = "lbl_vstats_YTD";
			Label lblVstatsYTD1 = this.lbl_vstats_YTD;
			size = new System.Drawing.Size(83, 13);
			lblVstatsYTD1.Size = size;
			this.lbl_vstats_YTD.TabIndex = 36;
			this.lbl_vstats_YTD.Text = "YTD #Inhouse: ";
			this.lbl_vstats_Jan.AutoSize = true;
			Label lblVstatsJan = this.lbl_vstats_Jan;
			point = new Point(24, 46);
			lblVstatsJan.Location = point;
			this.lbl_vstats_Jan.Name = "lbl_vstats_Jan";
			Label lblVstatsJan1 = this.lbl_vstats_Jan;
			size = new System.Drawing.Size(30, 13);
			lblVstatsJan1.Size = size;
			this.lbl_vstats_Jan.TabIndex = 24;
			this.lbl_vstats_Jan.Text = "Jan: ";
			this.lbl_vstats_Dec.AutoSize = true;
			Label lblVstatsDec = this.lbl_vstats_Dec;
			point = new Point(125, 136);
			lblVstatsDec.Location = point;
			this.lbl_vstats_Dec.Name = "lbl_vstats_Dec";
			Label lblVstatsDec1 = this.lbl_vstats_Dec;
			size = new System.Drawing.Size(33, 13);
			lblVstatsDec1.Size = size;
			this.lbl_vstats_Dec.TabIndex = 35;
			this.lbl_vstats_Dec.Text = "Dec: ";
			this.lbl_vstats_Feb.AutoSize = true;
			Label lblVstatsFeb = this.lbl_vstats_Feb;
			point = new Point(24, 64);
			lblVstatsFeb.Location = point;
			this.lbl_vstats_Feb.Name = "lbl_vstats_Feb";
			Label lblVstatsFeb1 = this.lbl_vstats_Feb;
			size = new System.Drawing.Size(31, 13);
			lblVstatsFeb1.Size = size;
			this.lbl_vstats_Feb.TabIndex = 25;
			this.lbl_vstats_Feb.Text = "Feb: ";
			this.lbl_vstats_Nov.AutoSize = true;
			Label lblVstatsNov = this.lbl_vstats_Nov;
			point = new Point(125, 118);
			lblVstatsNov.Location = point;
			this.lbl_vstats_Nov.Name = "lbl_vstats_Nov";
			Label lblVstatsNov1 = this.lbl_vstats_Nov;
			size = new System.Drawing.Size(33, 13);
			lblVstatsNov1.Size = size;
			this.lbl_vstats_Nov.TabIndex = 34;
			this.lbl_vstats_Nov.Text = "Nov: ";
			this.lbl_vstats_Mar.AutoSize = true;
			Label lblVstatsMar = this.lbl_vstats_Mar;
			point = new Point(24, 82);
			lblVstatsMar.Location = point;
			this.lbl_vstats_Mar.Name = "lbl_vstats_Mar";
			Label lblVstatsMar1 = this.lbl_vstats_Mar;
			size = new System.Drawing.Size(31, 13);
			lblVstatsMar1.Size = size;
			this.lbl_vstats_Mar.TabIndex = 26;
			this.lbl_vstats_Mar.Text = "Mar: ";
			this.lbl_vstats_Oct.AutoSize = true;
			Label lblVstatsOct = this.lbl_vstats_Oct;
			point = new Point(125, 100);
			lblVstatsOct.Location = point;
			this.lbl_vstats_Oct.Name = "lbl_vstats_Oct";
			Label lblVstatsOct1 = this.lbl_vstats_Oct;
			size = new System.Drawing.Size(30, 13);
			lblVstatsOct1.Size = size;
			this.lbl_vstats_Oct.TabIndex = 33;
			this.lbl_vstats_Oct.Text = "Oct: ";
			this.lbl_vstats_Apr.AutoSize = true;
			Label lblVstatsApr = this.lbl_vstats_Apr;
			point = new Point(24, 100);
			lblVstatsApr.Location = point;
			this.lbl_vstats_Apr.Name = "lbl_vstats_Apr";
			Label lblVstatsApr1 = this.lbl_vstats_Apr;
			size = new System.Drawing.Size(29, 13);
			lblVstatsApr1.Size = size;
			this.lbl_vstats_Apr.TabIndex = 27;
			this.lbl_vstats_Apr.Text = "Apr: ";
			this.lbl_vstats_Sep.AutoSize = true;
			Label lblVstatsSep = this.lbl_vstats_Sep;
			point = new Point(125, 82);
			lblVstatsSep.Location = point;
			this.lbl_vstats_Sep.Name = "lbl_vstats_Sep";
			Label lblVstatsSep1 = this.lbl_vstats_Sep;
			size = new System.Drawing.Size(32, 13);
			lblVstatsSep1.Size = size;
			this.lbl_vstats_Sep.TabIndex = 32;
			this.lbl_vstats_Sep.Text = "Sep: ";
			this.lbl_vstats_May.AutoSize = true;
			Label lblVstatsMay = this.lbl_vstats_May;
			point = new Point(24, 118);
			lblVstatsMay.Location = point;
			this.lbl_vstats_May.Name = "lbl_vstats_May";
			Label lblVstatsMay1 = this.lbl_vstats_May;
			size = new System.Drawing.Size(33, 13);
			lblVstatsMay1.Size = size;
			this.lbl_vstats_May.TabIndex = 28;
			this.lbl_vstats_May.Text = "May: ";
			this.lbl_vstats_Aug.AutoSize = true;
			Label lblVstatsAug = this.lbl_vstats_Aug;
			point = new Point(125, 64);
			lblVstatsAug.Location = point;
			this.lbl_vstats_Aug.Name = "lbl_vstats_Aug";
			Label lblVstatsAug1 = this.lbl_vstats_Aug;
			size = new System.Drawing.Size(32, 13);
			lblVstatsAug1.Size = size;
			this.lbl_vstats_Aug.TabIndex = 31;
			this.lbl_vstats_Aug.Text = "Aug: ";
			this.lbl_vstats_Jun.AutoSize = true;
			Label lblVstatsJun = this.lbl_vstats_Jun;
			point = new Point(24, 136);
			lblVstatsJun.Location = point;
			this.lbl_vstats_Jun.Name = "lbl_vstats_Jun";
			Label lblVstatsJun1 = this.lbl_vstats_Jun;
			size = new System.Drawing.Size(30, 13);
			lblVstatsJun1.Size = size;
			this.lbl_vstats_Jun.TabIndex = 29;
			this.lbl_vstats_Jun.Text = "Jun: ";
			this.lbl_vstats_Jul.AutoSize = true;
			Label lblVstatsJul = this.lbl_vstats_Jul;
			point = new Point(125, 46);
			lblVstatsJul.Location = point;
			this.lbl_vstats_Jul.Name = "lbl_vstats_Jul";
			Label lblVstatsJul1 = this.lbl_vstats_Jul;
			size = new System.Drawing.Size(26, 13);
			lblVstatsJul1.Size = size;
			this.lbl_vstats_Jul.TabIndex = 30;
			this.lbl_vstats_Jul.Text = "Jul: ";
			this.Label121.AutoSize = true;
			this.Label121.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1211 = this.Label121;
			point = new Point(578, 183);
			label1211.Location = point;
			this.Label121.Name = "Label121";
			Label label1212 = this.Label121;
			size = new System.Drawing.Size(122, 17);
			label1212.Size = size;
			this.Label121.TabIndex = 23;
			this.Label121.Text = "Tax Offices By State";
			this.Label118.AutoSize = true;
			this.Label118.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label118 = this.Label118;
			point = new Point(578, 8);
			label118.Location = point;
			this.Label118.Name = "Label118";
			Label label1181 = this.Label118;
			size = new System.Drawing.Size(198, 17);
			label1181.Size = size;
			this.Label118.TabIndex = 22;
			this.Label118.Text = "InHouse Coverage Area By State";
			this.Label21.AutoSize = true;
			Label label211 = this.Label21;
			point = new Point(576, 200);
			label211.Location = point;
			this.Label21.Name = "Label21";
			Label label212 = this.Label21;
			size = new System.Drawing.Size(43, 13);
			label212.Size = size;
			this.Label21.TabIndex = 21;
			this.Label21.Text = "County:";
			this.cbox_StatsTaxCounties.FormattingEnabled = true;
			ComboBox cboxStatsTaxCounties = this.cbox_StatsTaxCounties;
			point = new Point(579, 216);
			cboxStatsTaxCounties.Location = point;
			this.cbox_StatsTaxCounties.Name = "cbox_StatsTaxCounties";
			ComboBox cboxStatsTaxCounties1 = this.cbox_StatsTaxCounties;
			size = new System.Drawing.Size(60, 21);
			cboxStatsTaxCounties1.Size = size;
			this.cbox_StatsTaxCounties.TabIndex = 20;
			this.txt_StatsTaxOffices.BackColor = Color.GhostWhite;
			this.txt_StatsTaxOffices.BorderStyle = BorderStyle.FixedSingle;
			this.txt_StatsTaxOffices.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_StatsTaxOffices.ForeColor = Color.DarkBlue;
			TextBox txtStatsTaxOffices = this.txt_StatsTaxOffices;
			point = new Point(581, 256);
			txtStatsTaxOffices.Location = point;
			this.txt_StatsTaxOffices.Multiline = true;
			this.txt_StatsTaxOffices.Name = "txt_StatsTaxOffices";
			this.txt_StatsTaxOffices.ReadOnly = true;
			this.txt_StatsTaxOffices.ScrollBars = ScrollBars.Vertical;
			TextBox txtStatsTaxOffices1 = this.txt_StatsTaxOffices;
			size = new System.Drawing.Size(259, 92);
			txtStatsTaxOffices1.Size = size;
			this.txt_StatsTaxOffices.TabIndex = 19;
			this.lbl_TaxOnlineStats.AutoSize = true;
			Label lblTaxOnlineStats = this.lbl_TaxOnlineStats;
			point = new Point(578, 240);
			lblTaxOnlineStats.Location = point;
			this.lbl_TaxOnlineStats.Name = "lbl_TaxOnlineStats";
			Label lblTaxOnlineStats1 = this.lbl_TaxOnlineStats;
			size = new System.Drawing.Size(64, 13);
			lblTaxOnlineStats1.Size = size;
			this.lbl_TaxOnlineStats.TabIndex = 18;
			this.lbl_TaxOnlineStats.Text = "Tax Offices:";
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label141 = this.Label14;
			point = new Point(298, 113);
			label141.Location = point;
			this.Label14.Name = "Label14";
			Label label142 = this.Label14;
			size = new System.Drawing.Size(181, 14);
			label142.Size = size;
			this.Label14.TabIndex = 17;
			this.Label14.Text = "Total# Records in Tax Database:";
			this.lbl_OrbStat6.AutoSize = true;
			this.lbl_OrbStat6.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_OrbStat6.ForeColor = Color.DarkBlue;
			Label lblOrbStat6 = this.lbl_OrbStat6;
			point = new Point(505, 113);
			lblOrbStat6.Location = point;
			this.lbl_OrbStat6.Name = "lbl_OrbStat6";
			Label lblOrbStat61 = this.lbl_OrbStat6;
			size = new System.Drawing.Size(13, 14);
			lblOrbStat61.Size = size;
			this.lbl_OrbStat6.TabIndex = 16;
			this.lbl_OrbStat6.Text = "#";
			this.Label37.AutoSize = true;
			Label label371 = this.Label37;
			point = new Point(578, 25);
			label371.Location = point;
			this.Label37.Name = "Label37";
			Label label372 = this.Label37;
			size = new System.Drawing.Size(35, 13);
			label372.Size = size;
			this.Label37.TabIndex = 15;
			this.Label37.Text = "State:";
			this.cbox_StatsStates.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections2 = this.cbox_StatsStates.Items;
			objArray = new object[] { "ALL", "", "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" };
			objectCollections2.AddRange(objArray);
			ComboBox cboxStatsStates = this.cbox_StatsStates;
			point = new Point(581, 41);
			cboxStatsStates.Location = point;
			this.cbox_StatsStates.Name = "cbox_StatsStates";
			ComboBox cboxStatsStates1 = this.cbox_StatsStates;
			size = new System.Drawing.Size(60, 21);
			cboxStatsStates1.Size = size;
			this.cbox_StatsStates.TabIndex = 14;
			this.Label25.AutoSize = true;
			this.Label25.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label251 = this.Label25;
			point = new Point(298, 157);
			label251.Location = point;
			this.Label25.Name = "Label25";
			Label label252 = this.Label25;
			size = new System.Drawing.Size(173, 14);
			label252.Size = size;
			this.Label25.TabIndex = 13;
			this.Label25.Text = "Total# Tax Offices Researched:";
			this.Label23.AutoSize = true;
			this.Label23.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label231 = this.Label23;
			point = new Point(298, 25);
			label231.Location = point;
			this.Label23.Name = "Label23";
			Label label232 = this.Label23;
			size = new System.Drawing.Size(182, 14);
			label232.Size = size;
			this.Label23.TabIndex = 12;
			this.Label23.Text = "Total# Records in Orb Database:";
			this.lbl_OrbStats.AutoSize = true;
			this.lbl_OrbStats.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_OrbStats.ForeColor = Color.DarkBlue;
			Label lblOrbStats = this.lbl_OrbStats;
			point = new Point(505, 25);
			lblOrbStats.Location = point;
			this.lbl_OrbStats.Name = "lbl_OrbStats";
			Label lblOrbStats1 = this.lbl_OrbStats;
			size = new System.Drawing.Size(13, 14);
			lblOrbStats1.Size = size;
			this.lbl_OrbStats.TabIndex = 11;
			this.lbl_OrbStats.Text = "#";
			this.lbl_OrbStat5.AutoSize = true;
			this.lbl_OrbStat5.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_OrbStat5.ForeColor = Color.DarkBlue;
			Label lblOrbStat5 = this.lbl_OrbStat5;
			point = new Point(505, 157);
			lblOrbStat5.Location = point;
			this.lbl_OrbStat5.Name = "lbl_OrbStat5";
			Label lblOrbStat51 = this.lbl_OrbStat5;
			size = new System.Drawing.Size(13, 14);
			lblOrbStat51.Size = size;
			this.lbl_OrbStat5.TabIndex = 10;
			this.lbl_OrbStat5.Text = "#";
			this.txt_StatsCounties.BackColor = Color.GhostWhite;
			this.txt_StatsCounties.BorderStyle = BorderStyle.FixedSingle;
			this.txt_StatsCounties.Font = new System.Drawing.Font("Calibri", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_StatsCounties.ForeColor = Color.DarkBlue;
			TextBox txtStatsCounties = this.txt_StatsCounties;
			point = new Point(581, 81);
			txtStatsCounties.Location = point;
			this.txt_StatsCounties.Multiline = true;
			this.txt_StatsCounties.Name = "txt_StatsCounties";
			this.txt_StatsCounties.ReadOnly = true;
			this.txt_StatsCounties.ScrollBars = ScrollBars.Vertical;
			TextBox txtStatsCounties1 = this.txt_StatsCounties;
			size = new System.Drawing.Size(182, 92);
			txtStatsCounties1.Size = size;
			this.txt_StatsCounties.TabIndex = 9;
			this.lbl_OrbStat4.AutoSize = true;
			this.lbl_OrbStat4.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_OrbStat4.ForeColor = Color.DarkBlue;
			Label lblOrbStat4 = this.lbl_OrbStat4;
			point = new Point(505, 135);
			lblOrbStat4.Location = point;
			this.lbl_OrbStat4.Name = "lbl_OrbStat4";
			Label lblOrbStat41 = this.lbl_OrbStat4;
			size = new System.Drawing.Size(13, 14);
			lblOrbStat41.Size = size;
			this.lbl_OrbStat4.TabIndex = 8;
			this.lbl_OrbStat4.Text = "#";
			this.lbl_OrbStat3.AutoSize = true;
			this.lbl_OrbStat3.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_OrbStat3.ForeColor = Color.DarkBlue;
			Label lblOrbStat3 = this.lbl_OrbStat3;
			point = new Point(505, 91);
			lblOrbStat3.Location = point;
			this.lbl_OrbStat3.Name = "lbl_OrbStat3";
			Label lblOrbStat31 = this.lbl_OrbStat3;
			size = new System.Drawing.Size(13, 14);
			lblOrbStat31.Size = size;
			this.lbl_OrbStat3.TabIndex = 7;
			this.lbl_OrbStat3.Text = "#";
			this.lbl_OrbStat2.AutoSize = true;
			this.lbl_OrbStat2.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_OrbStat2.ForeColor = Color.DarkBlue;
			Label lblOrbStat2 = this.lbl_OrbStat2;
			point = new Point(505, 69);
			lblOrbStat2.Location = point;
			this.lbl_OrbStat2.Name = "lbl_OrbStat2";
			Label lblOrbStat21 = this.lbl_OrbStat2;
			size = new System.Drawing.Size(13, 14);
			lblOrbStat21.Size = size;
			this.lbl_OrbStat2.TabIndex = 6;
			this.lbl_OrbStat2.Text = "#";
			this.lbl_OrbStat1.AutoSize = true;
			this.lbl_OrbStat1.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_OrbStat1.ForeColor = Color.DarkBlue;
			Label lblOrbStat1 = this.lbl_OrbStat1;
			point = new Point(505, 47);
			lblOrbStat1.Location = point;
			this.lbl_OrbStat1.Name = "lbl_OrbStat1";
			Label lblOrbStat11 = this.lbl_OrbStat1;
			size = new System.Drawing.Size(13, 14);
			lblOrbStat11.Size = size;
			this.lbl_OrbStat1.TabIndex = 5;
			this.lbl_OrbStat1.Text = "#";
			this.lbl_CoOnlineStats.AutoSize = true;
			Label lblCoOnlineStats = this.lbl_CoOnlineStats;
			point = new Point(578, 65);
			lblCoOnlineStats.Location = point;
			this.lbl_CoOnlineStats.Name = "lbl_CoOnlineStats";
			Label lblCoOnlineStats1 = this.lbl_CoOnlineStats;
			size = new System.Drawing.Size(84, 13);
			lblCoOnlineStats1.Size = size;
			this.lbl_CoOnlineStats.TabIndex = 4;
			this.lbl_CoOnlineStats.Text = "Online Counties:";
			this.Label120.AutoSize = true;
			this.Label120.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label120 = this.Label120;
			point = new Point(298, 91);
			label120.Location = point;
			this.Label120.Name = "Label120";
			Label label1201 = this.Label120;
			size = new System.Drawing.Size(121, 14);
			label1201.Size = size;
			this.Label120.TabIndex = 3;
			this.Label120.Text = "Total# Courts Online:";
			this.Label119.AutoSize = true;
			this.Label119.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label119 = this.Label119;
			point = new Point(298, 69);
			label119.Location = point;
			this.Label119.Name = "Label119";
			Label label1191 = this.Label119;
			size = new System.Drawing.Size(196, 14);
			label1191.Size = size;
			this.Label119.TabIndex = 2;
			this.Label119.Text = "Total# InHouse Coverage Counties:";
			this.Label116.AutoSize = true;
			this.Label116.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label116 = this.Label116;
			point = new Point(298, 135);
			label116.Location = point;
			this.Label116.Name = "Label116";
			Label label1161 = this.Label116;
			size = new System.Drawing.Size(146, 14);
			label1161.Size = size;
			this.Label116.TabIndex = 1;
			this.Label116.Text = "Total# Tax Offices Online:";
			this.Label115.AutoSize = true;
			this.Label115.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label115 = this.Label115;
			point = new Point(298, 47);
			label115.Location = point;
			this.Label115.Name = "Label115";
			Label label1151 = this.Label115;
			size = new System.Drawing.Size(166, 14);
			label1151.Size = size;
			this.Label115.TabIndex = 0;
			this.Label115.Text = "Total# of Land Indexs Online:";
			this.TabPage2.AutoScroll = true;
			this.TabPage2.BackColor = Color.GhostWhite;
			this.TabPage2.Controls.Add(this.lblSOL_being_Clause);
			this.TabPage2.Controls.Add(this.lbl_homestead);
			this.TabPage2.Controls.Add(this.txt_homestead_notes);
			this.TabPage2.Controls.Add(this.lbl_deed_prep);
			this.TabPage2.Controls.Add(this.lbl_attyClose);
			this.TabPage2.Controls.Add(this.txt_AttyNotes);
			this.TabPage2.Controls.Add(this.txt_DeedNotes);
			this.TabPage2.Controls.Add(this.CheckBox1);
			this.TabPage2.Controls.Add(this.Label123);
			this.TabPage2.Controls.Add(this.txt_PolicyNotes);
			TabPage tabPage21 = this.TabPage2;
			point = new Point(4, 22);
			tabPage21.Location = point;
			this.TabPage2.Name = "TabPage2";
			TabPage tabPage22 = this.TabPage2;
			padding = new System.Windows.Forms.Padding(3);
			tabPage22.Padding = padding;
			TabPage tabPage23 = this.TabPage2;
			size = new System.Drawing.Size(866, 201);
			tabPage23.Size = size;
			this.TabPage2.TabIndex = 10;
			this.TabPage2.Text = "Misc";
			this.lblSOL_being_Clause.AutoSize = true;
			this.lblSOL_being_Clause.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label lblSOLBeingClause = this.lblSOL_being_Clause;
			point = new Point(8, 157);
			lblSOLBeingClause.Location = point;
			this.lblSOL_being_Clause.Name = "lblSOL_being_Clause";
			Label lblSOLBeingClause1 = this.lblSOL_being_Clause;
			size = new System.Drawing.Size(124, 13);
			lblSOLBeingClause1.Size = size;
			this.lblSOL_being_Clause.TabIndex = 89;
			this.lblSOL_being_Clause.Text = "Being Clause Required";
			this.lbl_homestead.AutoSize = true;
			Label lblHomestead = this.lbl_homestead;
			point = new Point(4, 12);
			lblHomestead.Location = point;
			this.lbl_homestead.Name = "lbl_homestead";
			Label lblHomestead1 = this.lbl_homestead;
			size = new System.Drawing.Size(64, 13);
			lblHomestead1.Size = size;
			this.lbl_homestead.TabIndex = 88;
			this.lbl_homestead.Text = "Homestead:";
			this.txt_homestead_notes.BackColor = Color.Snow;
			this.txt_homestead_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_homestead_notes.ForeColor = Color.Purple;
			TextBox txtHomesteadNotes = this.txt_homestead_notes;
			point = new Point(4, 28);
			txtHomesteadNotes.Location = point;
			this.txt_homestead_notes.Multiline = true;
			this.txt_homestead_notes.Name = "txt_homestead_notes";
			this.txt_homestead_notes.ReadOnly = true;
			this.txt_homestead_notes.ScrollBars = ScrollBars.Vertical;
			TextBox txtHomesteadNotes1 = this.txt_homestead_notes;
			size = new System.Drawing.Size(262, 48);
			txtHomesteadNotes1.Size = size;
			this.txt_homestead_notes.TabIndex = 87;
			this.lbl_deed_prep.AutoSize = true;
			Label lblDeedPrep = this.lbl_deed_prep;
			point = new Point(8, 90);
			lblDeedPrep.Location = point;
			this.lbl_deed_prep.Name = "lbl_deed_prep";
			Label lblDeedPrep1 = this.lbl_deed_prep;
			size = new System.Drawing.Size(64, 13);
			lblDeedPrep1.Size = size;
			this.lbl_deed_prep.TabIndex = 86;
			this.lbl_deed_prep.Text = "Deed Prep: ";
			this.lbl_attyClose.AutoSize = true;
			Label lblAttyClose = this.lbl_attyClose;
			point = new Point(287, 12);
			lblAttyClose.Location = point;
			this.lbl_attyClose.Name = "lbl_attyClose";
			Label lblAttyClose1 = this.lbl_attyClose;
			size = new System.Drawing.Size(108, 13);
			lblAttyClose1.Size = size;
			this.lbl_attyClose.TabIndex = 77;
			this.lbl_attyClose.Text = "Attorney State Notes:";
			this.txt_AttyNotes.BackColor = Color.Snow;
			this.txt_AttyNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_AttyNotes.ForeColor = Color.Purple;
			TextBox txtAttyNotes = this.txt_AttyNotes;
			point = new Point(287, 28);
			txtAttyNotes.Location = point;
			this.txt_AttyNotes.Multiline = true;
			this.txt_AttyNotes.Name = "txt_AttyNotes";
			this.txt_AttyNotes.ReadOnly = true;
			this.txt_AttyNotes.ScrollBars = ScrollBars.Vertical;
			TextBox txtAttyNotes1 = this.txt_AttyNotes;
			size = new System.Drawing.Size(262, 48);
			txtAttyNotes1.Size = size;
			this.txt_AttyNotes.TabIndex = 76;
			this.txt_DeedNotes.BackColor = Color.Snow;
			this.txt_DeedNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_DeedNotes.ForeColor = Color.Purple;
			TextBox txtDeedNotes = this.txt_DeedNotes;
			point = new Point(6, 106);
			txtDeedNotes.Location = point;
			this.txt_DeedNotes.Multiline = true;
			this.txt_DeedNotes.Name = "txt_DeedNotes";
			this.txt_DeedNotes.ReadOnly = true;
			this.txt_DeedNotes.ScrollBars = ScrollBars.Vertical;
			TextBox txtDeedNotes1 = this.txt_DeedNotes;
			size = new System.Drawing.Size(262, 48);
			txtDeedNotes1.Size = size;
			this.txt_DeedNotes.TabIndex = 74;
			this.CheckBox1.AutoSize = true;
			CheckBox checkBox1 = this.CheckBox1;
			point = new Point(207, 355);
			checkBox1.Location = point;
			this.CheckBox1.Name = "CheckBox1";
			CheckBox checkBox = this.CheckBox1;
			size = new System.Drawing.Size(141, 17);
			checkBox.Size = size;
			this.CheckBox1.TabIndex = 257;
			this.CheckBox1.Text = "Attorney must close loan";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Label123.AutoSize = true;
			Label label123 = this.Label123;
			point = new Point(577, 12);
			label123.Location = point;
			this.Label123.Name = "Label123";
			Label label1231 = this.Label123;
			size = new System.Drawing.Size(69, 13);
			label1231.Size = size;
			this.Label123.TabIndex = 73;
			this.Label123.Text = "Policy Notes:";
			this.txt_PolicyNotes.BackColor = Color.Snow;
			this.txt_PolicyNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_PolicyNotes.ForeColor = Color.Purple;
			TextBox txtPolicyNotes = this.txt_PolicyNotes;
			point = new Point(577, 28);
			txtPolicyNotes.Location = point;
			this.txt_PolicyNotes.Multiline = true;
			this.txt_PolicyNotes.Name = "txt_PolicyNotes";
			this.txt_PolicyNotes.ReadOnly = true;
			this.txt_PolicyNotes.ScrollBars = ScrollBars.Vertical;
			TextBox txtPolicyNotes1 = this.txt_PolicyNotes;
			size = new System.Drawing.Size(262, 48);
			txtPolicyNotes1.Size = size;
			this.txt_PolicyNotes.TabIndex = 72;
			this.TabPage3.BackColor = Color.GhostWhite;
			this.TabPage3.Controls.Add(this.PictureBox3);
			this.TabPage3.Controls.Add(this.lbl_doc_endorsInfo);
			this.TabPage3.Controls.Add(this.PictureBox2);
			this.TabPage3.Controls.Add(this.lbl_doc_Alta_Clta);
			this.TabPage3.Controls.Add(this.WebBrowser2);
			TabPage tabPage3 = this.TabPage3;
			point = new Point(4, 22);
			tabPage3.Location = point;
			this.TabPage3.Name = "TabPage3";
			TabPage tabPage31 = this.TabPage3;
			padding = new System.Windows.Forms.Padding(3);
			tabPage31.Padding = padding;
			TabPage tabPage32 = this.TabPage3;
			size = new System.Drawing.Size(866, 201);
			tabPage32.Size = size;
			this.TabPage3.TabIndex = 11;
			this.TabPage3.Text = "About ALTAs";
			this.PictureBox3.Image = WindowsApplication1.My.Resources.Resources.word_logo;
			PictureBox pictureBox31 = this.PictureBox3;
			point = new Point(699, 41);
			pictureBox31.Location = point;
			this.PictureBox3.Name = "PictureBox3";
			PictureBox pictureBox32 = this.PictureBox3;
			size = new System.Drawing.Size(14, 14);
			pictureBox32.Size = size;
			this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox3.TabIndex = 190;
			this.PictureBox3.TabStop = false;
			this.PictureBox3.Tag = "AbstractRunSheet";
			this.lbl_doc_endorsInfo.AutoSize = true;
			this.lbl_doc_endorsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocEndorsInfo = this.lbl_doc_endorsInfo;
			point = new Point(717, 41);
			lblDocEndorsInfo.Location = point;
			this.lbl_doc_endorsInfo.Name = "lbl_doc_endorsInfo";
			Label lblDocEndorsInfo1 = this.lbl_doc_endorsInfo;
			size = new System.Drawing.Size(89, 13);
			lblDocEndorsInfo1.Size = size;
			this.lbl_doc_endorsInfo.TabIndex = 191;
			this.lbl_doc_endorsInfo.Text = "Endorsement info";
			this.PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
			PictureBox pictureBox22 = this.PictureBox2;
			point = new Point(699, 17);
			pictureBox22.Location = point;
			this.PictureBox2.Name = "PictureBox2";
			PictureBox pictureBox23 = this.PictureBox2;
			size = new System.Drawing.Size(14, 14);
			pictureBox23.Size = size;
			this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox2.TabIndex = 188;
			this.PictureBox2.TabStop = false;
			this.PictureBox2.Tag = "AbstractRunSheet";
			this.lbl_doc_Alta_Clta.AutoSize = true;
			this.lbl_doc_Alta_Clta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblDocAltaClta = this.lbl_doc_Alta_Clta;
			point = new Point(717, 18);
			lblDocAltaClta.Location = point;
			this.lbl_doc_Alta_Clta.Name = "lbl_doc_Alta_Clta";
			Label lblDocAltaClta1 = this.lbl_doc_Alta_Clta;
			size = new System.Drawing.Size(120, 13);
			lblDocAltaClta1.Size = size;
			this.lbl_doc_Alta_Clta.TabIndex = 189;
			this.lbl_doc_Alta_Clta.Text = "ALTA-CLTA Conversion";
			this.WebBrowser2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			WebBrowser webBrowser2 = this.WebBrowser2;
			point = new Point(0, 0);
			webBrowser2.Location = point;
			WebBrowser webBrowser21 = this.WebBrowser2;
			size = new System.Drawing.Size(20, 20);
			webBrowser21.MinimumSize = size;
			this.WebBrowser2.Name = "WebBrowser2";
			WebBrowser webBrowser22 = this.WebBrowser2;
			size = new System.Drawing.Size(690, 198);
			webBrowser22.Size = size;
			this.WebBrowser2.TabIndex = 0;
			this.WebBrowser2.Url = new Uri("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\Alta_Manual_STGC2006.htm", UriKind.Absolute);
			this.LinkLabel4.AutoSize = true;
			this.LinkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			LinkLabel linkLabel41 = this.LinkLabel4;
			point = new Point(492, 617);
			linkLabel41.Location = point;
			this.LinkLabel4.Name = "LinkLabel4";
			LinkLabel linkLabel42 = this.LinkLabel4;
			size = new System.Drawing.Size(236, 15);
			linkLabel42.Size = size;
			this.LinkLabel4.TabIndex = 191;
			this.LinkLabel4.TabStop = true;
			this.LinkLabel4.Text = "Report suggestions or problems with ORB";
			this.Label56.AutoSize = true;
			this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label56.ForeColor = Color.SteelBlue;
			Label label56 = this.Label56;
			point = new Point(18, 617);
			label56.Location = point;
			this.Label56.Name = "Label56";
			Label label561 = this.Label56;
			size = new System.Drawing.Size(396, 15);
			label561.Size = size;
			this.Label56.TabIndex = 193;
			this.Label56.Text = "iMortgage Services Online Resource Bank  Updated through 9-29-2008";
			this.Label55.AutoSize = true;
			this.Label55.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label55 = this.Label55;
			point = new Point(324, 60);
			label55.Location = point;
			this.Label55.Name = "Label55";
			Label label551 = this.Label55;
			size = new System.Drawing.Size(80, 13);
			label551.Size = size;
			this.Label55.TabIndex = 66;
			this.Label55.Text = "Spousal State:";
			this.Label62.AutoSize = true;
			this.Label62.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label62 = this.Label62;
			point = new Point(408, 60);
			label62.Location = point;
			this.Label62.Name = "Label62";
			Label label621 = this.Label62;
			size = new System.Drawing.Size(46, 13);
			label621.Size = size;
			this.Label62.TabIndex = 65;
			this.Label62.Text = "Label72";
			this.Label64.AutoSize = true;
			this.Label64.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label64 = this.Label64;
			point = new Point(12, 267);
			label64.Location = point;
			this.Label64.Name = "Label64";
			Label label641 = this.Label64;
			size = new System.Drawing.Size(86, 13);
			label641.Size = size;
			this.Label64.TabIndex = 62;
			this.Label64.Text = "Redem. Period:";
			this.Label66.AutoSize = true;
			this.Label66.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label66 = this.Label66;
			point = new Point(132, 267);
			label66.Location = point;
			this.Label66.Name = "Label66";
			Label label661 = this.Label66;
			size = new System.Drawing.Size(46, 13);
			label661.Size = size;
			this.Label66.TabIndex = 61;
			this.Label66.Text = "Label58";
			this.Label70.AutoSize = true;
			this.Label70.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label70 = this.Label70;
			point = new Point(12, 233);
			label70.Location = point;
			this.Label70.Name = "Label70";
			Label label701 = this.Label70;
			size = new System.Drawing.Size(76, 13);
			label701.Size = size;
			this.Label70.TabIndex = 60;
			this.Label70.Text = "Personal Tax:";
			this.Label75.AutoSize = true;
			this.Label75.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label75 = this.Label75;
			point = new Point(132, 233);
			label75.Location = point;
			this.Label75.Name = "Label75";
			Label label751 = this.Label75;
			size = new System.Drawing.Size(46, 13);
			label751.Size = size;
			this.Label75.TabIndex = 59;
			this.Label75.Text = "Label60";
			this.Label76.AutoSize = true;
			this.Label76.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label76 = this.Label76;
			point = new Point(132, 196);
			label76.Location = point;
			this.Label76.Name = "Label76";
			Label label761 = this.Label76;
			size = new System.Drawing.Size(46, 13);
			label761.Size = size;
			this.Label76.TabIndex = 58;
			this.Label76.Text = "Label54";
			this.Label77.AutoSize = true;
			this.Label77.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label77 = this.Label77;
			point = new Point(12, 216);
			label77.Location = point;
			this.Label77.Name = "Label77";
			Label label771 = this.Label77;
			size = new System.Drawing.Size(89, 13);
			label771.Size = size;
			this.Label77.TabIndex = 57;
			this.Label77.Text = "Creditor Claims:";
			this.Label78.AutoSize = true;
			this.Label78.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label78 = this.Label78;
			point = new Point(408, 77);
			label78.Location = point;
			this.Label78.Name = "Label78";
			Label label781 = this.Label78;
			size = new System.Drawing.Size(46, 13);
			label781.Size = size;
			this.Label78.TabIndex = 56;
			this.Label78.Text = "Label52";
			this.Label80.AutoSize = true;
			this.Label80.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label80 = this.Label80;
			point = new Point(324, 77);
			label80.Location = point;
			this.Label80.Name = "Label80";
			Label label801 = this.Label80;
			size = new System.Drawing.Size(48, 13);
			label801.Size = size;
			this.Label80.TabIndex = 55;
			this.Label80.Text = "TE Rule:";
			this.Label82.AutoSize = true;
			this.Label82.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label82 = this.Label82;
			point = new Point(132, 301);
			label82.Location = point;
			this.Label82.Name = "Label82";
			Label label821 = this.Label82;
			size = new System.Drawing.Size(46, 13);
			label821.Size = size;
			this.Label82.TabIndex = 54;
			this.Label82.Text = "Label46";
			this.Label84.AutoSize = true;
			this.Label84.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label84 = this.Label84;
			point = new Point(12, 301);
			label84.Location = point;
			this.Label84.Name = "Label84";
			Label label841 = this.Label84;
			size = new System.Drawing.Size(111, 13);
			label841.Size = size;
			this.Label84.TabIndex = 53;
			this.Label84.Text = "After Acquired Lien:";
			this.Label85.AutoSize = true;
			this.Label85.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label85 = this.Label85;
			point = new Point(132, 43);
			label85.Location = point;
			this.Label85.Name = "Label85";
			Label label851 = this.Label85;
			size = new System.Drawing.Size(82, 13);
			label851.Size = size;
			this.Label85.TabIndex = 52;
			this.Label85.Text = "10 yrs+30 days";
			this.Label86.AutoSize = true;
			this.Label86.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label86 = this.Label86;
			point = new Point(12, 43);
			label86.Location = point;
			this.Label86.Name = "Label86";
			Label label861 = this.Label86;
			size = new System.Drawing.Size(75, 13);
			label861.Size = size;
			this.Label86.TabIndex = 51;
			this.Label86.Text = "Fed Tax Lien:";
			this.Label87.AutoSize = true;
			this.Label87.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label87 = this.Label87;
			point = new Point(132, 60);
			label87.Location = point;
			this.Label87.Name = "Label87";
			Label label871 = this.Label87;
			size = new System.Drawing.Size(30, 13);
			label871.Size = size;
			this.Label87.TabIndex = 50;
			this.Label87.Text = "5 yrs";
			this.Label88.AutoSize = true;
			this.Label88.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label88 = this.Label88;
			point = new Point(12, 60);
			label88.Location = point;
			this.Label88.Name = "Label88";
			Label label881 = this.Label88;
			size = new System.Drawing.Size(37, 13);
			label881.Size = size;
			this.Label88.TabIndex = 49;
			this.Label88.Text = "UCCs:";
			this.TextBox1.BackColor = Color.Snow;
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TextBox1.ForeColor = Color.Purple;
			TextBox textBox17 = this.TextBox1;
			point = new Point(327, 9);
			textBox17.Location = point;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.ScrollBars = ScrollBars.Vertical;
			TextBox textBox18 = this.TextBox1;
			size = new System.Drawing.Size(395, 47);
			textBox18.Size = size;
			this.TextBox1.TabIndex = 48;
			this.TextBox1.Text = "Comments";
			this.Label89.AutoSize = true;
			this.Label89.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label89 = this.Label89;
			point = new Point(12, 162);
			label89.Location = point;
			this.Label89.Name = "Label89";
			Label label891 = this.Label89;
			size = new System.Drawing.Size(65, 13);
			label891.Size = size;
			this.Label89.TabIndex = 23;
			this.Label89.Text = "Hosp. Lien:";
			this.Label90.AutoSize = true;
			this.Label90.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label90 = this.Label90;
			point = new Point(132, 162);
			label90.Location = point;
			this.Label90.Name = "Label90";
			Label label901 = this.Label90;
			size = new System.Drawing.Size(46, 13);
			label901.Size = size;
			this.Label90.TabIndex = 22;
			this.Label90.Text = "Label72";
			this.Label91.AutoSize = true;
			this.Label91.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label91 = this.Label91;
			point = new Point(12, 196);
			label91.Location = point;
			this.Label91.Name = "Label91";
			Label label911 = this.Label91;
			size = new System.Drawing.Size(63, 13);
			label911.Size = size;
			this.Label91.TabIndex = 21;
			this.Label91.Text = "Judgment:";
			this.Label92.AutoSize = true;
			this.Label92.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label92 = this.Label92;
			point = new Point(132, 216);
			label92.Location = point;
			this.Label92.Name = "Label92";
			Label label921 = this.Label92;
			size = new System.Drawing.Size(46, 13);
			label921.Size = size;
			this.Label92.TabIndex = 20;
			this.Label92.Text = "Label70";
			this.Label93.AutoSize = true;
			this.Label93.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label93 = this.Label93;
			point = new Point(132, 77);
			label93.Location = point;
			this.Label93.Name = "Label93";
			Label label931 = this.Label93;
			size = new System.Drawing.Size(36, 13);
			label931.Size = size;
			this.Label93.TabIndex = 25;
			this.Label93.Text = "20 yrs";
			this.Label94.AutoSize = true;
			this.Label94.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label94 = this.Label94;
			point = new Point(12, 179);
			label94.Location = point;
			this.Label94.Name = "Label94";
			Label label941 = this.Label94;
			size = new System.Drawing.Size(78, 13);
			label941.Size = size;
			this.Label94.TabIndex = 19;
			this.Label94.Text = "Claim of Lien:";
			this.Label95.AutoSize = true;
			this.Label95.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label95 = this.Label95;
			point = new Point(12, 77);
			label95.Location = point;
			this.Label95.Name = "Label95";
			Label label951 = this.Label95;
			size = new System.Drawing.Size(66, 13);
			label951.Size = size;
			this.Label95.TabIndex = 24;
			this.Label95.Text = "USA Jgmts:";
			this.Label96.AutoSize = true;
			this.Label96.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label96 = this.Label96;
			point = new Point(132, 179);
			label96.Location = point;
			this.Label96.Name = "Label96";
			Label label961 = this.Label96;
			size = new System.Drawing.Size(46, 13);
			label961.Size = size;
			this.Label96.TabIndex = 18;
			this.Label96.Text = "Label68";
			this.Label97.AutoSize = true;
			this.Label97.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label97 = this.Label97;
			point = new Point(12, 145);
			label97.Location = point;
			this.Label97.Name = "Label97";
			Label label971 = this.Label97;
			size = new System.Drawing.Size(59, 13);
			label971.Size = size;
			this.Label97.TabIndex = 17;
			this.Label97.Text = "HOA Lien:";
			this.Label98.AutoSize = true;
			this.Label98.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label98 = this.Label98;
			point = new Point(132, 145);
			label98.Location = point;
			this.Label98.Name = "Label98";
			Label label981 = this.Label98;
			size = new System.Drawing.Size(46, 13);
			label981.Size = size;
			this.Label98.TabIndex = 16;
			this.Label98.Text = "Label66";
			this.Label99.AutoSize = true;
			this.Label99.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label99 = this.Label99;
			point = new Point(12, 128);
			label99.Location = point;
			this.Label99.Name = "Label99";
			Label label991 = this.Label99;
			size = new System.Drawing.Size(107, 13);
			label991.Size = size;
			this.Label99.TabIndex = 15;
			this.Label99.Text = "Notice/Commence:";
			this.Label100.AutoSize = true;
			this.Label100.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label100 = this.Label100;
			point = new Point(132, 128);
			label100.Location = point;
			this.Label100.Name = "Label100";
			Label label1001 = this.Label100;
			size = new System.Drawing.Size(46, 13);
			label1001.Size = size;
			this.Label100.TabIndex = 14;
			this.Label100.Text = "Label58";
			this.Label101.AutoSize = true;
			this.Label101.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1011 = this.Label101;
			point = new Point(12, 111);
			label1011.Location = point;
			this.Label101.Name = "Label101";
			Label label1012 = this.Label101;
			size = new System.Drawing.Size(64, 13);
			label1012.Size = size;
			this.Label101.TabIndex = 13;
			this.Label101.Text = "Mech.Lien:";
			this.Label102.AutoSize = true;
			this.Label102.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label102 = this.Label102;
			point = new Point(132, 111);
			label102.Location = point;
			this.Label102.Name = "Label102";
			Label label1021 = this.Label102;
			size = new System.Drawing.Size(46, 13);
			label1021.Size = size;
			this.Label102.TabIndex = 12;
			this.Label102.Text = "Label60";
			this.Label103.AutoSize = true;
			this.Label103.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label103 = this.Label103;
			point = new Point(12, 284);
			label103.Location = point;
			this.Label103.Name = "Label103";
			Label label1031 = this.Label103;
			size = new System.Drawing.Size(65, 13);
			label1031.Size = size;
			this.Label103.TabIndex = 11;
			this.Label103.Text = "State Jgmt:";
			this.Label104.AutoSize = true;
			this.Label104.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label104 = this.Label104;
			point = new Point(132, 284);
			label104.Location = point;
			this.Label104.Name = "Label104";
			Label label1041 = this.Label104;
			size = new System.Drawing.Size(46, 13);
			label1041.Size = size;
			this.Label104.TabIndex = 10;
			this.Label104.Text = "Label62";
			this.Label105.AutoSize = true;
			this.Label105.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label105 = this.Label105;
			point = new Point(12, 250);
			label105.Location = point;
			this.Label105.Name = "Label105";
			Label label1051 = this.Label105;
			size = new System.Drawing.Size(73, 13);
			label1051.Size = size;
			this.Label105.TabIndex = 9;
			this.Label105.Text = "Support Obl:";
			this.Label106.AutoSize = true;
			this.Label106.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label106 = this.Label106;
			point = new Point(132, 250);
			label106.Location = point;
			this.Label106.Name = "Label106";
			Label label1061 = this.Label106;
			size = new System.Drawing.Size(46, 13);
			label1061.Size = size;
			this.Label106.TabIndex = 8;
			this.Label106.Text = "Label64";
			this.Label107.AutoSize = true;
			this.Label107.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label107 = this.Label107;
			point = new Point(132, 94);
			label107.Location = point;
			this.Label107.Name = "Label107";
			Label label1071 = this.Label107;
			size = new System.Drawing.Size(46, 13);
			label1071.Size = size;
			this.Label107.TabIndex = 5;
			this.Label107.Text = "Label54";
			this.Label108.AutoSize = true;
			this.Label108.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label108 = this.Label108;
			point = new Point(12, 94);
			label108.Location = point;
			this.Label108.Name = "Label108";
			Label label1081 = this.Label108;
			size = new System.Drawing.Size(69, 13);
			label1081.Size = size;
			this.Label108.TabIndex = 4;
			this.Label108.Text = "LisPendens:";
			this.Label109.AutoSize = true;
			this.Label109.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label109 = this.Label109;
			point = new Point(132, 26);
			label109.Location = point;
			this.Label109.Name = "Label109";
			Label label1091 = this.Label109;
			size = new System.Drawing.Size(46, 13);
			label1091.Size = size;
			this.Label109.TabIndex = 3;
			this.Label109.Text = "Label52";
			this.Label110.AutoSize = true;
			this.Label110.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label110 = this.Label110;
			point = new Point(12, 26);
			label110.Location = point;
			this.Label110.Name = "Label110";
			Label label1101 = this.Label110;
			size = new System.Drawing.Size(45, 13);
			label1101.Size = size;
			this.Label110.TabIndex = 2;
			this.Label110.Text = "HELOC:";
			this.Label111.AutoSize = true;
			this.Label111.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label1111 = this.Label111;
			point = new Point(132, 9);
			label1111.Location = point;
			this.Label111.Name = "Label111";
			Label label1112 = this.Label111;
			size = new System.Drawing.Size(46, 13);
			label1112.Size = size;
			this.Label111.TabIndex = 1;
			this.Label111.Text = "Label46";
			this.Label112.AutoSize = true;
			this.Label112.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label1121 = this.Label112;
			point = new Point(12, 9);
			label1121.Location = point;
			this.Label112.Name = "Label112";
			Label label1122 = this.Label112;
			size = new System.Drawing.Size(59, 13);
			label1122.Size = size;
			this.Label112.TabIndex = 0;
			this.Label112.Text = "Mtg/DOT:";
			this.Panel2.Anchor = AnchorStyles.Left;
			this.Panel2.BackColor = Color.Gainsboro;
			Panel panel2 = this.Panel2;
			point = new Point(0, 3);
			panel2.Location = point;
			this.Panel2.Name = "Panel2";
			Panel panel21 = this.Panel2;
			size = new System.Drawing.Size(860, 520);
			panel21.Size = size;
			this.Panel2.TabIndex = 198;
			this.pboxOpenCredCard.Image = WindowsApplication1.My.Resources.Resources.xls_icon;
			PictureBox pictureBox24 = this.pboxOpenCredCard;
			point = new Point(21, 59);
			pictureBox24.Location = point;
			this.pboxOpenCredCard.Name = "pboxOpenCredCard";
			PictureBox pictureBox25 = this.pboxOpenCredCard;
			size = new System.Drawing.Size(14, 14);
			pictureBox25.Size = size;
			this.pboxOpenCredCard.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pboxOpenCredCard.TabIndex = 205;
			this.pboxOpenCredCard.TabStop = false;
			this.pboxOpenCredCard.Tag = "AbstractRunSheet";
			this.lbl_creditCard.AutoSize = true;
			this.lbl_creditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label lblCreditCard = this.lbl_creditCard;
			point = new Point(38, 58);
			lblCreditCard.Location = point;
			this.lbl_creditCard.Name = "lbl_creditCard";
			Label lblCreditCard1 = this.lbl_creditCard;
			size = new System.Drawing.Size(131, 15);
			lblCreditCard1.Size = size;
			this.lbl_creditCard.TabIndex = 206;
			this.lbl_creditCard.Text = "Credit Card Usage Log";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Honeydew;
			size = new System.Drawing.Size(874, 639);
			this.ClientSize = size;
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.SplitContainer1);
			this.Controls.Add(this.Label56);
			this.Controls.Add(this.LinkLabel4);
			this.Controls.Add(this.Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form1";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "ORB - iMS Online Resource Bank";
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel1.PerformLayout();
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.Panel2.PerformLayout();
			this.SplitContainer1.ResumeLayout(false);
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox10.ResumeLayout(false);
			this.GroupBox10.PerformLayout();
			this.GroupBox8.ResumeLayout(false);
			this.GroupBox8.PerformLayout();
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox7.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.TabPg1Docs.ResumeLayout(false);
			this.TabPg1Docs.PerformLayout();
			((ISupportInitialize)this.pbox_Abstr_SOP).EndInit();
			((ISupportInitialize)this.pboxOpenEtitleWkshare).EndInit();
			((ISupportInitialize)this.pboxOpenORT_Wkshare).EndInit();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			((ISupportInitialize)this.pboxOpenClearanceCustSpecs).EndInit();
			((ISupportInitialize)this.pboxOpenTitleCustSpecs).EndInit();
			((ISupportInitialize)this.pboxOpenRunSheet).EndInit();
			this.TabPg2PhBk.ResumeLayout(false);
			this.TabPg2PhBk.PerformLayout();
			((ISupportInitialize)this.PictureBox9).EndInit();
			((ISupportInitialize)this.DataGridView1).EndInit();
			this.TabPg3Cal.ResumeLayout(false);
			this.TabPg4Clearing.ResumeLayout(false);
			this.TabPg4Clearing.PerformLayout();
			((ISupportInitialize)this.PictureBox8).EndInit();
			((ISupportInitialize)this.PictureBox6).EndInit();
			((ISupportInitialize)this.PictureBox7).EndInit();
			((ISupportInitialize)this.PictureBox5).EndInit();
			((ISupportInitialize)this.PictureBox4).EndInit();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TabPg5Req.ResumeLayout(false);
			this.TabPg6OtherLogins.ResumeLayout(false);
			((ISupportInitialize)this.DataGridView2).EndInit();
			this.TabPg7Taxes.ResumeLayout(false);
			this.TabPg7Taxes.PerformLayout();
			((ISupportInitialize)this.pbxExport).EndInit();
			((ISupportInitialize)this.pbxCopy5).EndInit();
			((ISupportInitialize)this.pbxCopy4).EndInit();
			((ISupportInitialize)this.pbxCopy3).EndInit();
			((ISupportInitialize)this.pbxCopy2).EndInit();
			((ISupportInitialize)this.pbxCopy1).EndInit();
			this.TabPg8UWMan.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			((ISupportInitialize)this.PictureBox3).EndInit();
			((ISupportInitialize)this.PictureBox2).EndInit();
			((ISupportInitialize)this.pboxOpenCredCard).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void Label4Tap_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Chris's credit card is stored in the online draw acct. We add $100 as needed. Searches are $5.95/name, free unlimited page views of images, 50 cents per page printed/saved. Print screen confirmation for Chris's expense report and add the credit card use to spreadsheet on T:\\Drive when renewing draw balance.");
		}

		private void Label4Tap_Hover(object sender, EventArgs e)
		{
			this.Label4Tap.ForeColor = Color.LimeGreen;
			this.Label4Tap.Cursor = Cursors.Hand;
		}

		private void Label4Tap_Leave(object sender, EventArgs e)
		{
			this.Label4Tap.ForeColor = Color.Black;
			this.Label4Tap.Cursor = Cursors.Default;
		}

		private void Label5dtree_Click(object sender, EventArgs e)
		{
			MessageBox.Show("iMS has a contract for use of this account. We pay this by monthly invoices. DocEdge and Datatree are billed on 2 seperate accounts. DocEdge property reports fees vary. Images from either source are $4.95/document.");
		}

		private void Label5dtree_Hover(object sender, EventArgs e)
		{
			this.Label5dtree.ForeColor = Color.LimeGreen;
			this.Label5dtree.Cursor = Cursors.Hand;
		}

		private void Label5dtree_Leave(object sender, EventArgs e)
		{
			this.Label5dtree.ForeColor = Color.Black;
			this.Label5dtree.Cursor = Cursors.Default;
		}

		private void Label6RV_Click(object sender, EventArgs e)
		{
			MessageBox.Show("We pay this account monthly by invoice. Searches are $10/property searched (includes all doc copies).");
		}

		private void Label6RV_Hover(object sender, EventArgs e)
		{
			this.Label6RV.ForeColor = Color.LimeGreen;
			this.Label6RV.Cursor = Cursors.Hand;
		}

		private void Label6RV_Leave(object sender, EventArgs e)
		{
			this.Label6RV.ForeColor = Color.Black;
			this.Label6RV.Cursor = Cursors.Default;
		}

		private void lbl_AbstrSOP_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Online Abstracting\\ONLINE ABSTRACTING PROCEDURES.doc");
		}

		private void lbl_AbstrSOP_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_AbstractingSOPs, "InHouse Abstracting Procedures");
			this.lbl_doc_AbstractingSOPs.ForeColor = Color.MediumPurple;
			this.lbl_doc_AbstractingSOPs.Cursor = Cursors.Hand;
		}

		private void lbl_AbstrSOP_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_AbstractingSOPs.ForeColor = Color.Black;
			this.lbl_doc_AbstractingSOPs.Cursor = Cursors.Default;
		}

		private void lbl_BusnPhones_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Business & Vendor Phone List.xls");
		}

		private void lbl_BusnPhones_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_BusnPhones, "CLICK TO OPEN");
			this.lbl_BusnPhones.ForeColor = Color.MediumPurple;
			this.lbl_BusnPhones.Cursor = Cursors.Hand;
		}

		private void lbl_BusnPhones_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_BusnPhones.ForeColor = Color.Black;
			this.lbl_BusnPhones.Cursor = Cursors.Default;
		}

		private void lbl_creditCard_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Credit Card Usage tracking.xls");
		}

		private void lbl_creditCard_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_creditCard, "Abstract Run Sheet");
			this.lbl_creditCard.ForeColor = Color.MediumPurple;
			this.lbl_creditCard.Cursor = Cursors.Hand;
		}

		private void lbl_creditCard_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_creditCard.ForeColor = Color.Black;
			this.lbl_creditCard.Cursor = Cursors.Default;
		}

		private void lbl_endorsInfo_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\ALTA Title Insurance Endorsements.doc");
		}

		private void lbl_endorsInfo_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_endorsInfo, "CLICK TO OPEN");
			this.lbl_doc_endorsInfo.ForeColor = Color.MediumPurple;
			this.lbl_doc_endorsInfo.Cursor = Cursors.Hand;
		}

		private void lbl_endorsInfo_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_endorsInfo.ForeColor = Color.Black;
			this.lbl_doc_endorsInfo.Cursor = Cursors.Default;
		}

		private void lblAltaClta_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ALTA-CLTA Conversion 2006.doc");
		}

		private void lblAltaClta_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_Alta_Clta, "CLICK TO OPEN");
			this.lbl_doc_Alta_Clta.ForeColor = Color.MediumPurple;
			this.lbl_doc_Alta_Clta.Cursor = Cursors.Hand;
		}

		private void lblAltaClta_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_Alta_Clta.ForeColor = Color.Black;
			this.lbl_doc_Alta_Clta.Cursor = Cursors.Default;
		}

		private void lblDeedPrep_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Vesting & Deeds\\Vesting Changes and New Deed Prep.doc");
		}

		private void lblDeedPrep_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_deed_prep, "CLICK TO OPEN");
			this.lbl_deed_prep.ForeColor = Color.MediumPurple;
			this.lbl_deed_prep.Cursor = Cursors.Hand;
		}

		private void lblDeedPrep_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_deed_prep.ForeColor = Color.Black;
			this.lbl_deed_prep.Cursor = Cursors.Default;
		}

		private void lblDeedPrepSOP_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Vesting & Deeds\\Vesting Changes and New Deed Prep.doc");
		}

		private void lblDeedPrepSOP_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_SOP_deedprep, "CLICK TO OPEN");
			this.lbl_doc_SOP_deedprep.ForeColor = Color.MediumPurple;
			this.lbl_doc_SOP_deedprep.Cursor = Cursors.Hand;
		}

		private void lblDeedPrepSOP_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_SOP_deedprep.ForeColor = Color.Black;
			this.lbl_doc_SOP_deedprep.Cursor = Cursors.Default;
		}

		private void lblDocDeeds_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Vesting & Deeds\\About Deeds.doc");
		}

		private void lblDocDeeds_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_aboutDeeds, "CLICK TO OPEN");
			this.lbl_doc_aboutDeeds.ForeColor = Color.MediumPurple;
			this.lbl_doc_aboutDeeds.Cursor = Cursors.Hand;
		}

		private void lblDocDeeds_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_aboutDeeds.ForeColor = Color.Black;
			this.lbl_doc_aboutDeeds.Cursor = Cursors.Default;
		}

		private void lblLeaseFee_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Clearance\\Land Contract - Leasehold Property.doc");
		}

		private void lblLeaseFee_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_Lease_Fee_LandContract, "CLICK TO OPEN");
			this.lbl_doc_Lease_Fee_LandContract.ForeColor = Color.MediumPurple;
			this.lbl_doc_Lease_Fee_LandContract.Cursor = Cursors.Hand;
		}

		private void lblLeaseFee_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_Lease_Fee_LandContract.ForeColor = Color.Black;
			this.lbl_doc_Lease_Fee_LandContract.Cursor = Cursors.Default;
		}

		private void lblOpenClearance_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Title Customers\\TITLE CLEARANCE CUSTOMER SPECIFICS .xls");
		}

		private void lblOpenClearance_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lblOpenClearanceCustSpecs, "CLICK TO OPEN");
			this.lblOpenClearanceCustSpecs.ForeColor = Color.MediumPurple;
			this.lblOpenClearanceCustSpecs.Cursor = Cursors.Hand;
		}

		private void lblOpenClearance_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lblOpenClearanceCustSpecs.ForeColor = Color.Black;
			this.lblOpenClearanceCustSpecs.Cursor = Cursors.Default;
		}

		private void lblOpenEtitleWkshare_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\iMS Title Insurance Workshare Procedures.doc");
		}

		private void lblOpenEtitleWkshare_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lblOpenEtitleWkshare, "CLICK TO OPEN");
			this.lblOpenEtitleWkshare.ForeColor = Color.MediumPurple;
			this.lblOpenEtitleWkshare.Cursor = Cursors.Hand;
		}

		private void lblOpenEtitleWkshare_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lblOpenEtitleWkshare.ForeColor = Color.Black;
			this.lblOpenEtitleWkshare.Cursor = Cursors.Default;
		}

		private void lblOpenORT_Wkshare_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ortic_workshare_faq.doc");
		}

		private void lblOpenORT_Wkshare_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lblOpenORT_Wkshare, "CLICK TO OPEN");
			this.lblOpenORT_Wkshare.ForeColor = Color.MediumPurple;
			this.lblOpenORT_Wkshare.Cursor = Cursors.Hand;
		}

		private void lblOpenORT_Wkshare_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lblOpenORT_Wkshare.ForeColor = Color.Black;
			this.lblOpenORT_Wkshare.Cursor = Cursors.Default;
		}

		private void lblOpenRunSheet_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\IMS ONLINE ABSTRACT RUN SHEET.doc");
		}

		private void lblOpenRunSheet_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lblOpenRunSheet, "Abstract Run Sheet");
			this.lblOpenRunSheet.ForeColor = Color.MediumPurple;
			this.lblOpenRunSheet.Cursor = Cursors.Hand;
		}

		private void lblOpenRunSheet_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lblOpenRunSheet.ForeColor = Color.Black;
			this.lblOpenRunSheet.Cursor = Cursors.Default;
		}

		private void lblOpenTitleCustSpec_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lblOpenTitleCustSpec, "Title Production Customer Specifics");
			this.lblOpenTitleCustSpec.ForeColor = Color.MediumPurple;
			this.lblOpenTitleCustSpec.Cursor = Cursors.Hand;
		}

		private void lblOpenTitleCustSpec_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lblOpenTitleCustSpec.ForeColor = Color.Black;
			this.lblOpenTitleCustSpec.Cursor = Cursors.Default;
		}

		private void lblOpenTitleProdCustSpecs_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Title Research & Review\\Typing-Review\\Typing-Review Customer Specifics 7-2008.doc");
		}

		private void lblPOA_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Vesting & Deeds\\STEPS TO APPROVE A POWER OF ATTORNEY.doc");
		}

		private void lblPOA_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_approvePOA, "CLICK TO OPEN");
			this.lbl_doc_approvePOA.ForeColor = Color.MediumPurple;
			this.lbl_doc_approvePOA.Cursor = Cursors.Hand;
		}

		private void lblPOA_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_approvePOA.ForeColor = Color.Black;
			this.lbl_doc_approvePOA.Cursor = Cursors.Default;
		}

		private void lblSOL_heloc_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lblSOL_Heloc, "Statutes are measured After Maturity Date if stated or after the instrument Recorded Date");
		}

		private void lblSOL_heloc_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
		}

		private void lblSOL_Mtg_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lblSOL_Mtg, "Statutes are measured After Maturity Date if stated or after the instrument Recorded Date");
		}

		private void lblSOL_Mtg_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
		}

		private void lblVesting_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Clearance\\Title Vesting Explained.doc");
		}

		private void lblVesting_mouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.lbl_doc_aboutVesting, "CLICK TO OPEN");
			this.lbl_doc_aboutVesting.ForeColor = Color.MediumPurple;
			this.lbl_doc_aboutVesting.Cursor = Cursors.Hand;
		}

		private void lblVesting_mouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.RemoveAll();
			this.lbl_doc_aboutVesting.ForeColor = Color.Black;
			this.lbl_doc_aboutVesting.Cursor = Cursors.Default;
		}

		private void LinkLabel_DOI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_misc.DOI_url.StartsWith("http") | this.orb_misc.DOI_url.StartsWith("www"))
			{
				Process.Start(this.orb_misc.DOI_url);
			}
		}

		private void LinkLabel_MyFla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.target = "http://myfloridacounties.com/";
			Process.Start(this.target);
		}

		private void LinkLabel_SecState_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_misc.SecretaryState_url.StartsWith("http") | this.orb_misc.SecretaryState_url.StartsWith("www"))
			{
				Process.Start(this.orb_misc.SecretaryState_url);
			}
		}

		private void LinkLabel_StateCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_misc.State_Code_url.StartsWith("http") | this.orb_misc.State_Code_url.StartsWith("www"))
			{
				Process.Start(this.orb_misc.State_Code_url);
			}
		}

		private void LinkLabel_UCC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.ucc_url.StartsWith("http") | this.orb_obj.ucc_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.ucc_url);
			}
		}

		private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("www.docedge.com");
		}

		private void LinkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://tapestry.fidlar.com/Splash/Default.aspx");
		}

		private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("mailto://tbaer@imortgageservices.com");
		}

		private void LinkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("www.redvision.com");
		}

		private void LinkLabelAssessor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.assessor_url.StartsWith("http") | this.orb_obj.assessor_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.assessor_url);
			}
		}

		private void LinkLabelCoHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.county_homepage.StartsWith("http") | this.orb_obj.county_homepage.StartsWith("www"))
			{
				Process.Start(this.orb_obj.county_homepage);
			}
		}

		private void LinkLabelCounty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.land_url.StartsWith("http") | this.orb_obj.land_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.land_url);
			}
		}

		private void LinkLabelCourt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.court_url.StartsWith("http") | this.orb_obj.court_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.court_url);
			}
		}

		private void LinkLabelForeclosure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.foreclosure_url.StartsWith("http") | this.orb_obj.foreclosure_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.foreclosure_url);
			}
		}

		private void LinkLabelLocTx1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.mywebs[11].StartsWith("http") | this.mywebs[11].StartsWith("www"))
			{
				Process.Start(this.mywebs[11]);
			}
		}

		private void LinkLabelLocTx2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.mywebs[12].StartsWith("http") | this.mywebs[12].StartsWith("www"))
			{
				Process.Start(this.mywebs[12]);
			}
		}

		private void LinkLabelLocTx3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.mywebs[13].StartsWith("http") | this.mywebs[13].StartsWith("www"))
			{
				Process.Start(this.mywebs[13]);
			}
		}

		private void LinkLabelLocTx4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.mywebs[14].StartsWith("http") | this.mywebs[14].StartsWith("www"))
			{
				Process.Start(this.mywebs[14]);
			}
		}

		private void LinkLabelLocTx5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.mywebs[15].StartsWith("http") | this.mywebs[15].StartsWith("www"))
			{
				Process.Start(this.mywebs[15]);
			}
		}

		private void LinkLabelMaps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.map_url.StartsWith("http") | this.orb_obj.map_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.map_url);
			}
		}

		private void LinkLabelOtherTax_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.tax2_url.StartsWith("http") | this.orb_obj.tax2_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.tax2_url);
			}
		}

		private void LinkLabelPlat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.plat_url.StartsWith("http") | this.orb_obj.plat_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.plat_url);
			}
		}

		private void LinkLabelPro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.prothon_url.StartsWith("http") | this.orb_obj.prothon_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.prothon_url);
			}
		}

		private void LinkLabelProbate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.probate_url.StartsWith("http") | this.orb_obj.probate_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.probate_url);
			}
		}

		private void LinkLabelSheriff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.sheriff_url.StartsWith("http") | this.orb_obj.sheriff_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.sheriff_url);
			}
		}

		private void LinkLabelTax_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.tax_url.StartsWith("http") | this.orb_obj.tax_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.tax_url);
			}
		}

		private void LinkLabelTax2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.orb_obj.muniCourt_url.StartsWith("http") | this.orb_obj.muniCourt_url.StartsWith("www"))
			{
				Process.Start(this.orb_obj.muniCourt_url);
			}
		}

		private void linkUS_Legal_Forms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.target = "http://www.uslegalforms.com/realestate/";
			Process.Start(this.target);
		}

		private void madStat(string st)
		{
			long i;
			string[] text;
			DataTable dataTable = new DataTable();
			DataTable dataTable1 = new DataTable();
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm1, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(dataTable);
			this.da.Dispose();
			decimal[] numArray = new decimal[11];
			string[] strArrays = new string[] { null, null, null, null, null, "inhouseCounties", "countyCount", null, null, null, null };
			long j = (long)1;
			for (i = (long)0; i < (long)11; i = checked(i + (long)1))
			{
				numArray[checked((int)i)] = new decimal();
			}
			i = (long)0;
			j = (long)1;
			this.txt_StatsCounties.Text = "";
			this.txt_StatsTaxOffices.Text = "";
			while (j < (long)dataTable.Rows.Count)
			{
				if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[checked((int)j)]["st"].ToString(), st, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbox_StatsStates.Text, "ALL", false) == 0) & (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[checked((int)j)]["ins"].ToString(), "Yes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[checked((int)j)]["props"].ToString(), "Yes", false) == 0))
				{
					numArray[5] = decimal.Add(numArray[5], decimal.One);
					TextBox txtStatsCounties = this.txt_StatsCounties;
					text = new string[] { this.txt_StatsCounties.Text, dataTable.Rows[checked((int)j)]["st"].ToString(), " - ", dataTable.Rows[checked((int)j)]["county"].ToString(), "\r\n" };
					txtStatsCounties.Text = string.Concat(text);
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[checked((int)j)]["st"].ToString(), st, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbox_StatsStates.Text, "ALL", false) == 0)
				{
					numArray[6] = decimal.Add(numArray[6], decimal.One);
				}
				j = checked(j + (long)1);
			}
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(dataTable1);
			this.da.Dispose();
			for (j = (long)2; j < (long)dataTable1.Rows.Count; j = checked(j + (long)1))
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable1.Rows[checked((int)j)]["st"].ToString(), st, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable1.Rows[checked((int)j)]["payee"].ToString(), "", false) != 0)
				{
					numArray[7] = decimal.Add(numArray[7], decimal.One);
					TextBox txtStatsTaxOffices = this.txt_StatsTaxOffices;
					text = new string[] { this.txt_StatsTaxOffices.Text, dataTable1.Rows[checked((int)j)]["st"].ToString(), " - ", dataTable1.Rows[checked((int)j)]["county"].ToString(), " - ", dataTable1.Rows[checked((int)j)]["tax_auth"].ToString(), "\r\n" };
					txtStatsTaxOffices.Text = string.Concat(text);
				}
			}
			if (decimal.Compare(numArray[6], decimal.Zero) != 0)
			{
				Label lblCoOnlineStats = this.lbl_CoOnlineStats;
				text = new string[] { "Of ", Conversions.ToString(numArray[6]), " Counties, ", Conversions.ToString(Math.Round(decimal.Multiply(decimal.Divide(numArray[5], numArray[6]), new decimal((long)100)))), " % Online" };
				lblCoOnlineStats.Text = string.Concat(text);
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbox_StatsStates.Text, "", false) == 0)
			{
				this.lbl_CoOnlineStats.ResetText();
			}
		}

		private void onlineStats()
		{
			int i = 0;
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
			OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder();
			OleDbCommand oleDbCommand = new OleDbCommand();
			string str = "T:\\Monthly & Daily Reports\\2008 Vendor Fee Analysis  Subscriptions.xls";
			string str1 = "data_YTD";
			DataTable dataTable = new DataTable();
			string[] strArrays = new string[14];
			oleDbCommand.CommandType = CommandType.TableDirect;
			string str2 = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", str, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			oleDbCommand.CommandText = string.Concat("Select * From [", str1, "$]");
			oleDbCommand.Connection = new OleDbConnection(str2);
			oleDbDataAdapter.SelectCommand = oleDbCommand;
			oleDbCommandBuilder.DataAdapter = oleDbDataAdapter;
			dataTable.Clear();
			oleDbDataAdapter.Fill(dataTable);
			oleDbDataAdapter.Dispose();
			while (i < 14)
			{
				strArrays[i] = Conversions.ToString(0);
				i = checked(i + 1);
			}
			for (i = 0; i < dataTable.Rows.Count; i = checked(i + 1))
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[i]["Vendor ID"].ToString(), "134392", false) == 0)
				{
					strArrays[13] = Conversions.ToString(Conversions.ToDouble(strArrays[13]) + 1);
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 1)
					{
						strArrays[1] = Conversions.ToString(Conversions.ToDouble(strArrays[1]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 2)
					{
						strArrays[2] = Conversions.ToString(Conversions.ToDouble(strArrays[2]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 3)
					{
						strArrays[3] = Conversions.ToString(Conversions.ToDouble(strArrays[3]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 4)
					{
						strArrays[4] = Conversions.ToString(Conversions.ToDouble(strArrays[4]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 5)
					{
						strArrays[5] = Conversions.ToString(Conversions.ToDouble(strArrays[5]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 6)
					{
						strArrays[6] = Conversions.ToString(Conversions.ToDouble(strArrays[6]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 7)
					{
						strArrays[7] = Conversions.ToString(Conversions.ToDouble(strArrays[7]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 8)
					{
						strArrays[8] = Conversions.ToString(Conversions.ToDouble(strArrays[8]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 9)
					{
						strArrays[9] = Conversions.ToString(Conversions.ToDouble(strArrays[9]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 10)
					{
						strArrays[10] = Conversions.ToString(Conversions.ToDouble(strArrays[10]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 11)
					{
						strArrays[11] = Conversions.ToString(Conversions.ToDouble(strArrays[11]) + 1);
					}
					if (Convert.ToDateTime(dataTable.Rows[i]["Date Billed"].ToString()).Month == 12)
					{
						strArrays[12] = Conversions.ToString(Conversions.ToDouble(strArrays[12]) + 1);
					}
				}
			}
			this.lbl_vstats_YTD.Text = string.Concat("YTD Searches Completed: ", strArrays[13]);
			this.lbl_vstats_Jan.Text = string.Concat("Jan: ", strArrays[1]);
			this.lbl_vstats_Feb.Text = string.Concat("Feb: ", strArrays[2]);
			this.lbl_vstats_Mar.Text = string.Concat("Mar: ", strArrays[3]);
			this.lbl_vstats_Apr.Text = string.Concat("Apr: ", strArrays[4]);
			this.lbl_vstats_May.Text = string.Concat("May: ", strArrays[5]);
			this.lbl_vstats_Jun.Text = string.Concat("Jun: ", strArrays[6]);
			this.lbl_vstats_Jul.Text = string.Concat("Jul: ", strArrays[7]);
			this.lbl_vstats_Aug.Text = string.Concat("Aug: ", strArrays[8]);
			this.lbl_vstats_Sep.Text = string.Concat("Sep: ", strArrays[9]);
			this.lbl_vstats_Oct.Text = string.Concat("Oct: ", strArrays[10]);
			this.lbl_vstats_Nov.Text = string.Concat("Nov: ", strArrays[11]);
			this.lbl_vstats_Dec.Text = string.Concat("Dec: ", strArrays[12]);
		}

		private void pboxAbstr_SOP_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Education\\Online Abstracting\\ONLINE ABSTRACTING PROCEDURES.doc");
		}

		private void pboxAbstr_SOP_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pbox_Abstr_SOP, "CLICK TO OPEN");
			this.pbox_Abstr_SOP.BorderStyle = BorderStyle.Fixed3D;
		}

		private void pboxAbstr_SOP_MouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pbox_Abstr_SOP, "CLICK TO OPEN");
			this.pbox_Abstr_SOP.BorderStyle = BorderStyle.None;
		}

		private void pboxCopy1_MouseClick(object sender, MouseEventArgs e)
		{
			string str = string.Concat(this.lblTxAuth1.Text, "\r\n", this.txtTaxOffice1.Text, "\r\n");
			Clipboard.SetDataObject(str);
		}

		private void pboxCopy3_MouseClick(object sender, MouseEventArgs e)
		{
			Clipboard.SetDataObject(this.txtTaxOffice3.Text);
		}

		private void pboxCopy4_MouseClick(object sender, MouseEventArgs e)
		{
			Clipboard.SetDataObject(this.txtTaxOffice4.Text);
		}

		private void pboxCopy5_MouseClick(object sender, MouseEventArgs e)
		{
			Clipboard.SetDataObject(this.txtTaxOffice5.Text);
		}

		private void pboxOpenClearance_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Title Customers\\TITLE CLEARANCE CUSTOMER SPECIFICS .xls");
		}

		private void pboxOpenClearanceCustSpecs_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenClearanceCustSpecs, "CLICK TO OPEN/EDIT");
			this.pboxOpenClearanceCustSpecs.BorderStyle = BorderStyle.Fixed3D;
		}

		private void pboxOpenClearanceCustSpecs_MouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenClearanceCustSpecs, "CLICK TO OPEN");
			this.pboxOpenClearanceCustSpecs.BorderStyle = BorderStyle.None;
		}

		private void pboxOpenCredCard_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Credit Card Usage tracking.xls");
		}

		private void pboxOpenCredCard_MouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenCredCard, "CLICK TO OPEN");
			this.pboxOpenCredCard.BorderStyle = BorderStyle.None;
		}

		private void pboxOpenCreditCard_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenCredCard, "CLICK TO OPEN");
			this.pboxOpenCredCard.BorderStyle = BorderStyle.Fixed3D;
		}

		private void pboxOpenEtitleWkshare_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\iMS Title Insurance Workshare Procedures.doc");
		}

		private void pboxOpenEtitleWkshare_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenEtitleWkshare, "CLICK TO OPEN");
			this.pboxOpenEtitleWkshare.BorderStyle = BorderStyle.Fixed3D;
		}

		private void pboxOpenEtitleWkshare_MouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenEtitleWkshare, "CLICK TO OPEN");
			this.pboxOpenEtitleWkshare.BorderStyle = BorderStyle.None;
		}

		private void pboxOpenORT_Wkshare_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ortic_workshare_faq.doc");
		}

		private void pboxOpenORT_Wkshare_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenORT_Wkshare, "CLICK TO OPEN");
			this.pboxOpenORT_Wkshare.BorderStyle = BorderStyle.Fixed3D;
		}

		private void pboxOpenORT_Wkshare_MouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenORT_Wkshare, "CLICK TO OPEN");
			this.pboxOpenORT_Wkshare.BorderStyle = BorderStyle.None;
		}

		private void pboxOpenRunSheet_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\IMS ONLINE ABSTRACT RUN SHEET.doc");
		}

		private void pboxOpenRunSheet_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenRunSheet, "CLICK TO OPEN");
			this.pboxOpenRunSheet.BorderStyle = BorderStyle.Fixed3D;
		}

		private void pboxOpenRunSheet_MouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenRunSheet, "CLICK TO OPEN");
			this.pboxOpenRunSheet.BorderStyle = BorderStyle.None;
		}

		private void pboxOpenTitleCustSpecs_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenTitleCustSpecs, "CLICK TO OPEN/EDIT");
			this.pboxOpenTitleCustSpecs.BorderStyle = BorderStyle.Fixed3D;
		}

		private void pboxOpenTitleCustSpecs_MouseLeave(object sender, EventArgs e)
		{
			this.ToolTip2.SetToolTip(this.pboxOpenTitleCustSpecs, "CLICK TO OPEN");
			this.pboxOpenTitleCustSpecs.BorderStyle = BorderStyle.None;
		}

		private void pboxOpenTitleProdSpecs_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\Title Research & Review\\Typing-Review\\Typing-Review Customer Specifics 7-2008.doc");
		}

		private void pbxCopy2_Mouseclick(object sender, MouseEventArgs e)
		{
			Clipboard.SetDataObject(this.txtTaxOffice2.Text);
		}

		private void pbxExport_Click(object sender, EventArgs e)
		{
			string str = "";
			string[] text = new string[] { this.txtTaxOffice1.Text, "\r\n\r\n", this.txtTaxOffice2.Text, "\r\n\r\n", this.txtTaxOffice3.Text, "\r\n\r\n", this.txtTaxOffice4.Text, "\r\n\r\n", this.txtTaxOffice5.Text };
			str = string.Concat(text);
			Clipboard.SetDataObject(str);
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\tax_sheet.doc");
			StreamWriter streamWriter = File.CreateText("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\tax_sheet.doc");
			streamWriter.WriteLine(str);
			streamWriter.Flush();
			streamWriter.Close();
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\tax_sheet.doc");
		}

		private void resetVis()
		{
			this.lbl_attyState.Visible = false;
			this.Panel2.Visible = false;
			this.LinkLabelCounty.Visible = false;
			this.LinkLabel_MyFlCountiesURL.Visible = false;
			this.lbl_MyFlaCounties.Visible = false;
			this.LabelCountyURL.Visible = false;
			this.LinkLabelCourt.Visible = false;
			this.LabelCourt.Visible = false;
			this.LinkLabelTax.Visible = false;
			this.LabelCountyTax.Visible = false;
			this.LinkLabelMaps.Visible = false;
			this.LabelMapsGIS.Visible = false;
			this.LinkLabelProthon.Visible = false;
			this.LabelProthon.Visible = false;
			this.LinkLabelAssessor.Visible = false;
			this.LabelAssessor.Visible = false;
			this.LinkLabelProbate.Visible = false;
			this.LabelProbate.Visible = false;
			this.LinkLabelCoHome.Visible = false;
			this.LabelCountyHome.Visible = false;
			this.LinkLabelPlats.Visible = false;
			this.LinkLabelForeclosure.Visible = false;
			this.LabelForeclosures.Visible = false;
			this.LinkLabelOtherTax.Visible = false;
			this.LabelOtherTax.Visible = false;
			this.LinkLabel_OtherURL.Visible = false;
			this.LabelOtherURL.Visible = false;
			this.LinkLabelMuniCourt.Visible = false;
			this.LabelMuniCourt.Visible = false;
			this.LinkLabelSheriff.Visible = false;
			this.LabelSheriff.Visible = false;
			this.txtComments.Visible = false;
			this.Label_user.Visible = false;
			this.Label_pwd.Visible = false;
			this.txt_login_landP.Visible = false;
			this.txt_login_landU.Visible = false;
			this.txt_myfl_U.Visible = false;
			this.txt_myfl_P.Visible = false;
			this.txt_login_courtU.Visible = false;
			this.txt_login_courtP.Visible = false;
			this.txt_login_tax1U.Visible = false;
			this.txt_login_tax1P.Visible = false;
			this.txt_login_prothonU.Visible = false;
			this.txt_login_prothonP.Visible = false;
			this.txt_login_tax2U.Visible = false;
			this.txt_login_tax2P.Visible = false;
			this.txt_login_probateU.Visible = false;
			this.txt_login_probateP.Visible = false;
			this.txt_login_muniU.Visible = false;
			this.txt_login_muniP.Visible = false;
			this.txt_login_asrU.Visible = false;
			this.txt_login_asrP.Visible = false;
			this.txt_login_otherU.Visible = false;
			this.txt_login_otherP.Visible = false;
			this.txtTaxOffice1.Visible = false;
			this.txtTaxOffice2.Visible = false;
			this.txtTaxOffice3.Visible = false;
			this.txtTaxOffice4.Visible = false;
			this.txtTaxOffice5.Visible = false;
			this.lblTxAuth1.Visible = false;
			this.lblTxAuth2.Visible = false;
			this.lblTxAuth3.Visible = false;
			this.lblTxAuth4.Visible = false;
			this.lblTxAuth5.Visible = false;
			this.linkLocTax1.Visible = false;
			this.linkLocTax2.Visible = false;
			this.linkLocTax3.Visible = false;
			this.linkLocTax4.Visible = false;
			this.linkLocTax5.Visible = false;
			this.pbxCopy1.Visible = false;
			this.pbxCopy2.Visible = false;
			this.pbxCopy3.Visible = false;
			this.pbxCopy4.Visible = false;
			this.pbxCopy5.Visible = false;
			this.lbl_verifDate1.Visible = false;
			this.lbl_verifDate2.Visible = false;
			this.lbl_verifDate3.Visible = false;
			this.lbl_verifDate4.Visible = false;
			this.lbl_verifDate5.Visible = false;
			this.lbl_verified_taxoff1.Visible = false;
			this.lbl_verified_taxoff2.Visible = false;
			this.lbl_verified_taxoff3.Visible = false;
			this.lbl_verified_taxoff4.Visible = false;
			this.lbl_verified_taxoff5.Visible = false;
			this.LabelUseTap.Visible = false;
			this.LabelUseRV.Visible = false;
			this.LabelUseDtree.Visible = false;
			this.lbl_NotFound.Visible = false;
			this.linkUS_Legal_Forms.Visible = false;
			this.lblSOL_Mtg.Visible = false;
			this.Label_mtg.Visible = false;
			this.lblSOL_Heloc.Visible = false;
			this.Label_heloc.Visible = false;
			this.lblSOL_Mech.Visible = false;
			this.Label_mechLien.Visible = false;
			this.lblSOL_Notice.Visible = false;
			this.Label_NOC.Visible = false;
			this.lblSOL_lispen.Visible = false;
			this.Label_lisPendens.Visible = false;
			this.lblSOL_HOA.Visible = false;
			this.Label_HOA.Visible = false;
			this.lblSOL_Hosp.Visible = false;
			this.Label_hospLien.Visible = false;
			this.lblSOL_ClaimLien.Visible = false;
			this.Label_claimLien.Visible = false;
			this.lblSOL_Jgmt.Visible = false;
			this.Label_jgmt.Visible = false;
			this.lblSOL_Support.Visible = false;
			this.Label_support.Visible = false;
			this.lblSOL_StateJgmt.Visible = false;
			this.Label_stateJgmt.Visible = false;
			this.lblSOL_AftAcq.Visible = false;
			this.Label_aftacq.Visible = false;
			this.lblSOL_TERule.Visible = false;
			this.Label_teRule.Visible = false;
			this.lblSOL_Creditor_Claims.Visible = false;
			this.Label_credclaim.Visible = false;
			this.lblSOL_PersTax.Visible = false;
			this.Label_persTax.Visible = false;
			this.lblSOL_Tax_RedemPer.Visible = false;
			this.Label_taxTakRedem.Visible = false;
			this.lblSOL_forecl_redem_per.Visible = false;
			this.Label_forclRedem.Visible = false;
			this.lblSOL_Spousal.Visible = false;
			this.Label_spousal.Visible = false;
			this.txtSOL_notes.Visible = false;
			this.Label_statutecomments.Visible = false;
			this.txt_foreclosure_notes.Visible = false;
			this.Label_fc.Visible = false;
			this.txt_ProbateInfo.Visible = false;
			this.Label_probate.Visible = false;
			this.lblSOL_being_Clause.Visible = false;
			this.LinkLabel_DeptIns.Visible = false;
			this.Label_DOI.Visible = false;
			this.LinkLabel_SecState.Visible = false;
			this.Label_secState.Visible = false;
			this.LinkLabel_State_Code.Visible = false;
			this.Label_stCode.Visible = false;
			this.LinkLabel_UCC.Visible = false;
			this.LabelUCC.Visible = false;
			this.LabelCopy_source.ResetText();
			this.LabelIndex_source.ResetText();
			this.LabelImage_date.ResetText();
			this.LabelIndex_date.ResetText();
			this.LabelCopyPmtType.ResetText();
			this.lbl_copyFeeAmt.ResetText();
			this.lbl_courtIndexDate.ResetText();
			this.lbl_courtImgDate.ResetText();
			this.LabelSubNeeded.ResetText();
			this.lbl_Free.ResetText();
			this.lbl_WeSubscribe.ResetText();
			this.lbl_SubTerm.ResetText();
			this.lbl_IndexPmtMethod.ResetText();
			this.lbl_IndexFeeAmt.ResetText();
			this.LabelUseIns.ResetText();
			this.LabelUseProps.ResetText();
			this.LabelUseCopy.ResetText();
			this.lbl_CoOnlineStats.ResetText();
		}

		private void TabPage1_Click(object sender, EventArgs e)
		{
			long i;
			this.onlineStats();
			this.txt_StatsCounties.Text = "";
			this.madStat(this.ComboBoxState.Text);
			this.cbox_StatsStates.Text = this.ComboBoxState.Text;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ComboBoxState.Text, "", false) != 0)
			{
				DataTable dataTable = new DataTable();
				DataTable dataTable1 = new DataTable();
				this.cmd.CommandType = CommandType.TableDirect;
				this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
				this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm1, "$]");
				this.cmd.Connection = new OleDbConnection(this.dsn);
				this.da.SelectCommand = this.cmd;
				this.cmdBuilder.DataAdapter = this.da;
				this.da.Fill(dataTable);
				this.da.Dispose();
				decimal[] numArray = new decimal[11];
				string[] strArrays = new string[] { "land_url", "inHouse", "courts", "taxes", "txOffc", "inhouseCounties", "countyCount", "taxCount", "taxesOnline", null, null };
				long j = (long)1;
				for (i = (long)0; i < (long)11; i = checked(i + (long)1))
				{
					numArray[checked((int)i)] = new decimal();
				}
				i = (long)0;
				for (j = (long)1; j < (long)dataTable.Rows.Count; j = checked(j + (long)1))
				{
					if (dataTable.Rows[checked((int)j)]["land_url"].ToString().StartsWith("www") | dataTable.Rows[checked((int)j)]["land_url"].ToString().StartsWith("http"))
					{
						numArray[0] = decimal.Add(numArray[0], decimal.One);
					}
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[checked((int)j)]["ins"].ToString(), "Yes", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[checked((int)j)]["props"].ToString(), "Yes", false) == 0)
					{
						numArray[1] = decimal.Add(numArray[1], decimal.One);
					}
					if (dataTable.Rows[checked((int)j)]["court_url"].ToString().StartsWith("www") | dataTable.Rows[checked((int)j)]["court_url"].ToString().StartsWith("http"))
					{
						numArray[2] = decimal.Add(numArray[2], decimal.One);
					}
					if (dataTable.Rows[checked((int)j)]["tax_url"].ToString().StartsWith("www") | dataTable.Rows[checked((int)j)]["tax_url"].ToString().StartsWith("http"))
					{
						numArray[3] = decimal.Add(numArray[3], decimal.One);
					}
				}
				this.lbl_OrbStat1.Text = string.Concat(Conversions.ToString(numArray[0]), " or ", Conversions.ToString(Math.Round(decimal.Multiply(decimal.Divide(numArray[0], new decimal(checked(j - (long)1))), new decimal((long)100)))), " %");
				this.lbl_OrbStat2.Text = string.Concat(Conversions.ToString(numArray[1]), " or ", Conversions.ToString(Math.Round(decimal.Multiply(decimal.Divide(numArray[1], new decimal(checked(j - (long)1))), new decimal((long)100)))), " %");
				this.lbl_OrbStat3.Text = string.Concat(Conversions.ToString(numArray[2]), " or ", Conversions.ToString(Math.Round(decimal.Multiply(decimal.Divide(numArray[2], new decimal(checked(j - (long)1))), new decimal((long)100)))), " %");
				this.lbl_OrbStat4.Text = string.Concat(Conversions.ToString(numArray[3]), " or ", Conversions.ToString(Math.Round(decimal.Multiply(decimal.Divide(numArray[3], new decimal(checked(j - (long)1))), new decimal((long)100)))), " %");
				this.cmd.CommandType = CommandType.TableDirect;
				this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
				this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
				this.cmd.Connection = new OleDbConnection(this.dsn);
				this.da.SelectCommand = this.cmd;
				this.cmdBuilder.DataAdapter = this.da;
				this.da.Fill(dataTable1);
				this.da.Dispose();
				for (i = (long)1; i < (long)dataTable1.Rows.Count; i = checked(i + (long)1))
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable1.Rows[checked((int)i)]["payee"].ToString(), null, false) != 0)
					{
						numArray[4] = decimal.Add(numArray[4], decimal.One);
					}
				}
				this.lbl_OrbStats.Text = Conversions.ToString(dataTable.Rows.Count);
				this.lbl_OrbStat5.Text = string.Concat(Conversions.ToString(numArray[4]), " or ", Conversions.ToString(Math.Round(decimal.Multiply(decimal.Divide(numArray[4], new decimal(checked(i - (long)1))), new decimal((long)100)))), " %");
				this.lbl_OrbStat6.Text = Conversions.ToString(dataTable1.Rows.Count);
			}
		}

		private void xlLoad1()
		{
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm1, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.st_cty);
			this.da.Dispose();
		}
	}
}
