using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;
using ORB_DLL.Orb;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
	[DesignerGenerated]
	public class frm_Edit : Form
	{
		private IContainer components;

		[AccessedThroughProperty("cboxCounty_EditORB")]
		private ComboBox _cboxCounty_EditORB;

		[AccessedThroughProperty("Label12")]
		private System.Windows.Forms.Label _Label12;

		[AccessedThroughProperty("Label1")]
		private System.Windows.Forms.Label _Label1;

		[AccessedThroughProperty("cboxState_EditORB")]
		private ComboBox _cboxState_EditORB;

		[AccessedThroughProperty("Button_SAVE")]
		private System.Windows.Forms.Button _Button_SAVE;

		[AccessedThroughProperty("Button_EXITupdates")]
		private System.Windows.Forms.Button _Button_EXITupdates;

		[AccessedThroughProperty("Button_SEARCH")]
		private System.Windows.Forms.Button _Button_SEARCH;

		[AccessedThroughProperty("Label25")]
		private System.Windows.Forms.Label _Label25;

		[AccessedThroughProperty("cboxTaxAuth_EditORB")]
		private ComboBox _cboxTaxAuth_EditORB;

		[AccessedThroughProperty("Label27")]
		private System.Windows.Forms.Label _Label27;

		[AccessedThroughProperty("cboxTaxAuthType_EditORB")]
		private ComboBox _cboxTaxAuthType_EditORB;

		[AccessedThroughProperty("Label29")]
		private System.Windows.Forms.Label _Label29;

		[AccessedThroughProperty("Button_Reset")]
		private System.Windows.Forms.Button _Button_Reset;

		[AccessedThroughProperty("Button_ExitApp")]
		private System.Windows.Forms.Button _Button_ExitApp;

		[AccessedThroughProperty("TabPage07")]
		private TabPage _TabPage07;

		[AccessedThroughProperty("txtInput_SOL_Vesting")]
		private System.Windows.Forms.TextBox _txtInput_SOL_Vesting;

		[AccessedThroughProperty("txtInput_SOL_SupportObl")]
		private System.Windows.Forms.TextBox _txtInput_SOL_SupportObl;

		[AccessedThroughProperty("txtInput_SOL_PersonalTax")]
		private System.Windows.Forms.TextBox _txtInput_SOL_PersonalTax;

		[AccessedThroughProperty("txtInput_SOL_StateJgmt")]
		private System.Windows.Forms.TextBox _txtInput_SOL_StateJgmt;

		[AccessedThroughProperty("txtInput_SOL_HospLien")]
		private System.Windows.Forms.TextBox _txtInput_SOL_HospLien;

		[AccessedThroughProperty("txtInput_SOL_SpousalState")]
		private System.Windows.Forms.TextBox _txtInput_SOL_SpousalState;

		[AccessedThroughProperty("txtInput_SOL_HelocRD")]
		private System.Windows.Forms.TextBox _txtInput_SOL_HelocRD;

		[AccessedThroughProperty("txtInput_SOL_MtgRD")]
		private System.Windows.Forms.TextBox _txtInput_SOL_MtgRD;

		[AccessedThroughProperty("txtInput_SOL_AfterAcquired")]
		private System.Windows.Forms.TextBox _txtInput_SOL_AfterAcquired;

		[AccessedThroughProperty("txtInput_SOL_TE_Rule")]
		private System.Windows.Forms.TextBox _txtInput_SOL_TE_Rule;

		[AccessedThroughProperty("txtInput_SOL_ForeclosureRedem")]
		private System.Windows.Forms.TextBox _txtInput_SOL_ForeclosureRedem;

		[AccessedThroughProperty("txtInput_SOL_TaxTakingRedem")]
		private System.Windows.Forms.TextBox _txtInput_SOL_TaxTakingRedem;

		[AccessedThroughProperty("txtInput_SOL_HOALien")]
		private System.Windows.Forms.TextBox _txtInput_SOL_HOALien;

		[AccessedThroughProperty("txtInput_SOL_CreditorClaims")]
		private System.Windows.Forms.TextBox _txtInput_SOL_CreditorClaims;

		[AccessedThroughProperty("txtInput_SOL_Jgmt")]
		private System.Windows.Forms.TextBox _txtInput_SOL_Jgmt;

		[AccessedThroughProperty("txtInput_SOL_ClaimOfLien")]
		private System.Windows.Forms.TextBox _txtInput_SOL_ClaimOfLien;

		[AccessedThroughProperty("txtInput_SOL_Notice")]
		private System.Windows.Forms.TextBox _txtInput_SOL_Notice;

		[AccessedThroughProperty("txtInput_SOL_MechLiens")]
		private System.Windows.Forms.TextBox _txtInput_SOL_MechLiens;

		[AccessedThroughProperty("txtInput_SOL_LisPendens")]
		private System.Windows.Forms.TextBox _txtInput_SOL_LisPendens;

		[AccessedThroughProperty("txtInput_SOL_HelocAM")]
		private System.Windows.Forms.TextBox _txtInput_SOL_HelocAM;

		[AccessedThroughProperty("txtInput_SOL_MtgAM")]
		private System.Windows.Forms.TextBox _txtInput_SOL_MtgAM;

		[AccessedThroughProperty("txtSOL_notes")]
		private System.Windows.Forms.TextBox _txtSOL_notes;

		[AccessedThroughProperty("Label96")]
		private System.Windows.Forms.Label _Label96;

		[AccessedThroughProperty("Label31")]
		private System.Windows.Forms.Label _Label31;

		[AccessedThroughProperty("Label32")]
		private System.Windows.Forms.Label _Label32;

		[AccessedThroughProperty("Label73")]
		private System.Windows.Forms.Label _Label73;

		[AccessedThroughProperty("Label75")]
		private System.Windows.Forms.Label _Label75;

		[AccessedThroughProperty("Label82")]
		private System.Windows.Forms.Label _Label82;

		[AccessedThroughProperty("Label90")]
		private System.Windows.Forms.Label _Label90;

		[AccessedThroughProperty("Label91")]
		private System.Windows.Forms.Label _Label91;

		[AccessedThroughProperty("Label30")]
		private System.Windows.Forms.Label _Label30;

		[AccessedThroughProperty("Label77")]
		private System.Windows.Forms.Label _Label77;

		[AccessedThroughProperty("Label76")]
		private System.Windows.Forms.Label _Label76;

		[AccessedThroughProperty("Label74")]
		private System.Windows.Forms.Label _Label74;

		[AccessedThroughProperty("Label79")]
		private System.Windows.Forms.Label _Label79;

		[AccessedThroughProperty("Label81")]
		private System.Windows.Forms.Label _Label81;

		[AccessedThroughProperty("Label83")]
		private System.Windows.Forms.Label _Label83;

		[AccessedThroughProperty("Label85")]
		private System.Windows.Forms.Label _Label85;

		[AccessedThroughProperty("Label87")]
		private System.Windows.Forms.Label _Label87;

		[AccessedThroughProperty("Label88")]
		private System.Windows.Forms.Label _Label88;

		[AccessedThroughProperty("Label89")]
		private System.Windows.Forms.Label _Label89;

		[AccessedThroughProperty("Label92")]
		private System.Windows.Forms.Label _Label92;

		[AccessedThroughProperty("Label93")]
		private System.Windows.Forms.Label _Label93;

		[AccessedThroughProperty("Label94")]
		private System.Windows.Forms.Label _Label94;

		[AccessedThroughProperty("TabPage03")]
		private TabPage _TabPage03;

		[AccessedThroughProperty("Label35")]
		private System.Windows.Forms.Label _Label35;

		[AccessedThroughProperty("txt_TaxDateVerified")]
		private System.Windows.Forms.TextBox _txt_TaxDateVerified;

		[AccessedThroughProperty("txtInput_TaxCertTAT")]
		private System.Windows.Forms.TextBox _txtInput_TaxCertTAT;

		[AccessedThroughProperty("txtInput_LocalTaxURL")]
		private System.Windows.Forms.TextBox _txtInput_LocalTaxURL;

		[AccessedThroughProperty("txtInput_NewTaxState")]
		private System.Windows.Forms.TextBox _txtInput_NewTaxState;

		[AccessedThroughProperty("txtInput_NewTaxCounty")]
		private System.Windows.Forms.TextBox _txtInput_NewTaxCounty;

		[AccessedThroughProperty("txtInput_TaxCertFee")]
		private System.Windows.Forms.TextBox _txtInput_TaxCertFee;

		[AccessedThroughProperty("txtInput_TaxPayeeState")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeeState;

		[AccessedThroughProperty("txtInput_TaxOfficeHours")]
		private System.Windows.Forms.TextBox _txtInput_TaxOfficeHours;

		[AccessedThroughProperty("txtInput_TaxDueDates")]
		private System.Windows.Forms.TextBox _txtInput_TaxDueDates;

		[AccessedThroughProperty("txtInput_TaxComments")]
		private System.Windows.Forms.TextBox _txtInput_TaxComments;

		[AccessedThroughProperty("txtInput_TaxAuthName")]
		private System.Windows.Forms.TextBox _txtInput_TaxAuthName;

		[AccessedThroughProperty("txtInput_TaxAuthType")]
		private System.Windows.Forms.TextBox _txtInput_TaxAuthType;

		[AccessedThroughProperty("txtInput_TaxPayeePhone")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeePhone;

		[AccessedThroughProperty("txtInput_TaxPayeeZip")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeeZip;

		[AccessedThroughProperty("txtInput_TaxPayeeFax")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeeFax;

		[AccessedThroughProperty("txtInput_TaxPayeeCity")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeeCity;

		[AccessedThroughProperty("txtInput_TaxPayeeStr2")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeeStr2;

		[AccessedThroughProperty("txtInput_TaxPayeeStr1")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeeStr1;

		[AccessedThroughProperty("txtInput_TaxPayeeName")]
		private System.Windows.Forms.TextBox _txtInput_TaxPayeeName;

		[AccessedThroughProperty("Label4")]
		private System.Windows.Forms.Label _Label4;

		[AccessedThroughProperty("Label26")]
		private System.Windows.Forms.Label _Label26;

		[AccessedThroughProperty("lblNewState")]
		private System.Windows.Forms.Label _lblNewState;

		[AccessedThroughProperty("lblTaxCounty")]
		private System.Windows.Forms.Label _lblTaxCounty;

		[AccessedThroughProperty("Label28")]
		private System.Windows.Forms.Label _Label28;

		[AccessedThroughProperty("chkbxTaxCertRequired")]
		private System.Windows.Forms.CheckBox _chkbxTaxCertRequired;

		[AccessedThroughProperty("Button_NEW")]
		private System.Windows.Forms.Button _Button_NEW;

		[AccessedThroughProperty("cboxInput_TaxBillingCycle")]
		private ComboBox _cboxInput_TaxBillingCycle;

		[AccessedThroughProperty("Label57")]
		private System.Windows.Forms.Label _Label57;

		[AccessedThroughProperty("Label59")]
		private System.Windows.Forms.Label _Label59;

		[AccessedThroughProperty("Label60")]
		private System.Windows.Forms.Label _Label60;

		[AccessedThroughProperty("Label54")]
		private System.Windows.Forms.Label _Label54;

		[AccessedThroughProperty("Label53")]
		private System.Windows.Forms.Label _Label53;

		[AccessedThroughProperty("Label51")]
		private System.Windows.Forms.Label _Label51;

		[AccessedThroughProperty("Label44")]
		private System.Windows.Forms.Label _Label44;

		[AccessedThroughProperty("Label45")]
		private System.Windows.Forms.Label _Label45;

		[AccessedThroughProperty("Label46")]
		private System.Windows.Forms.Label _Label46;

		[AccessedThroughProperty("Label47")]
		private System.Windows.Forms.Label _Label47;

		[AccessedThroughProperty("Label48")]
		private System.Windows.Forms.Label _Label48;

		[AccessedThroughProperty("Label49")]
		private System.Windows.Forms.Label _Label49;

		[AccessedThroughProperty("Label50")]
		private System.Windows.Forms.Label _Label50;

		[AccessedThroughProperty("TabPage01")]
		private TabPage _TabPage01;

		[AccessedThroughProperty("ckbxLoginRequired")]
		private System.Windows.Forms.CheckBox _ckbxLoginRequired;

		[AccessedThroughProperty("Label33")]
		private System.Windows.Forms.Label _Label33;

		[AccessedThroughProperty("txtInput_UCC_url")]
		private System.Windows.Forms.TextBox _txtInput_UCC_url;

		[AccessedThroughProperty("txtInput_OtherURLPwd")]
		private System.Windows.Forms.TextBox _txtInput_OtherURLPwd;

		[AccessedThroughProperty("txtInput_OtherURLUsername")]
		private System.Windows.Forms.TextBox _txtInput_OtherURLUsername;

		[AccessedThroughProperty("txtInput_ProbatePwd")]
		private System.Windows.Forms.TextBox _txtInput_ProbatePwd;

		[AccessedThroughProperty("txtInput_ProbateUsername")]
		private System.Windows.Forms.TextBox _txtInput_ProbateUsername;

		[AccessedThroughProperty("txtInput_ProthonPwd")]
		private System.Windows.Forms.TextBox _txtInput_ProthonPwd;

		[AccessedThroughProperty("txtInput_ProthonUsername")]
		private System.Windows.Forms.TextBox _txtInput_ProthonUsername;

		[AccessedThroughProperty("txtInput_AssessorPwd")]
		private System.Windows.Forms.TextBox _txtInput_AssessorPwd;

		[AccessedThroughProperty("txtInput_AssessorUsername")]
		private System.Windows.Forms.TextBox _txtInput_AssessorUsername;

		[AccessedThroughProperty("txtInput_TaxLocalPwd")]
		private System.Windows.Forms.TextBox _txtInput_TaxLocalPwd;

		[AccessedThroughProperty("txtInput_TaxLocalUsername")]
		private System.Windows.Forms.TextBox _txtInput_TaxLocalUsername;

		[AccessedThroughProperty("txtInput_TaxCountyPwd")]
		private System.Windows.Forms.TextBox _txtInput_TaxCountyPwd;

		[AccessedThroughProperty("txtInput_TaxCountyUsername")]
		private System.Windows.Forms.TextBox _txtInput_TaxCountyUsername;

		[AccessedThroughProperty("txtInput_MuniCtPwd")]
		private System.Windows.Forms.TextBox _txtInput_MuniCtPwd;

		[AccessedThroughProperty("txtInput_MuniCtUsername")]
		private System.Windows.Forms.TextBox _txtInput_MuniCtUsername;

		[AccessedThroughProperty("txtInput_CivCtPwd")]
		private System.Windows.Forms.TextBox _txtInput_CivCtPwd;

		[AccessedThroughProperty("txtInput_CivCtUsername")]
		private System.Windows.Forms.TextBox _txtInput_CivCtUsername;

		[AccessedThroughProperty("txtInput_LandPwd")]
		private System.Windows.Forms.TextBox _txtInput_LandPwd;

		[AccessedThroughProperty("txtInput_LandUsername")]
		private System.Windows.Forms.TextBox _txtInput_LandUsername;

		[AccessedThroughProperty("txtInput_OtherURL")]
		private System.Windows.Forms.TextBox _txtInput_OtherURL;

		[AccessedThroughProperty("txtInput_CountyHomeURL")]
		private System.Windows.Forms.TextBox _txtInput_CountyHomeURL;

		[AccessedThroughProperty("txtInput_ForeclosureURL")]
		private System.Windows.Forms.TextBox _txtInput_ForeclosureURL;

		[AccessedThroughProperty("txtInput_SheriffURL")]
		private System.Windows.Forms.TextBox _txtInput_SheriffURL;

		[AccessedThroughProperty("txtInput_ProbateURL")]
		private System.Windows.Forms.TextBox _txtInput_ProbateURL;

		[AccessedThroughProperty("txtInput_ProthonURL")]
		private System.Windows.Forms.TextBox _txtInput_ProthonURL;

		[AccessedThroughProperty("txtInput_MapURL")]
		private System.Windows.Forms.TextBox _txtInput_MapURL;

		[AccessedThroughProperty("txtInput_PlatsURL")]
		private System.Windows.Forms.TextBox _txtInput_PlatsURL;

		[AccessedThroughProperty("txtInput_AssessorURL")]
		private System.Windows.Forms.TextBox _txtInput_AssessorURL;

		[AccessedThroughProperty("txtInput_Tax2URL")]
		private System.Windows.Forms.TextBox _txtInput_Tax2URL;

		[AccessedThroughProperty("txtInput_TaxCountyURL")]
		private System.Windows.Forms.TextBox _txtInput_TaxCountyURL;

		[AccessedThroughProperty("txtInput_MuniCtURL")]
		private System.Windows.Forms.TextBox _txtInput_MuniCtURL;

		[AccessedThroughProperty("txtInput_CivCtIndexURL")]
		private System.Windows.Forms.TextBox _txtInput_CivCtIndexURL;

		[AccessedThroughProperty("txtInput_LandIndexURL")]
		private System.Windows.Forms.TextBox _txtInput_LandIndexURL;

		[AccessedThroughProperty("Label55")]
		private System.Windows.Forms.Label _Label55;

		[AccessedThroughProperty("Label24")]
		private System.Windows.Forms.Label _Label24;

		[AccessedThroughProperty("Label23")]
		private System.Windows.Forms.Label _Label23;

		[AccessedThroughProperty("Label22")]
		private System.Windows.Forms.Label _Label22;

		[AccessedThroughProperty("Label21")]
		private System.Windows.Forms.Label _Label21;

		[AccessedThroughProperty("Label18")]
		private System.Windows.Forms.Label _Label18;

		[AccessedThroughProperty("Label19")]
		private System.Windows.Forms.Label _Label19;

		[AccessedThroughProperty("Label20")]
		private System.Windows.Forms.Label _Label20;

		[AccessedThroughProperty("Label15")]
		private System.Windows.Forms.Label _Label15;

		[AccessedThroughProperty("Label16")]
		private System.Windows.Forms.Label _Label16;

		[AccessedThroughProperty("Label17")]
		private System.Windows.Forms.Label _Label17;

		[AccessedThroughProperty("Label11")]
		private System.Windows.Forms.Label _Label11;

		[AccessedThroughProperty("Label13")]
		private System.Windows.Forms.Label _Label13;

		[AccessedThroughProperty("Label14")]
		private System.Windows.Forms.Label _Label14;

		[AccessedThroughProperty("Label7")]
		private System.Windows.Forms.Label _Label7;

		[AccessedThroughProperty("Label9")]
		private System.Windows.Forms.Label _Label9;

		[AccessedThroughProperty("Label8")]
		private System.Windows.Forms.Label _Label8;

		[AccessedThroughProperty("TabPage05")]
		private TabPage _TabPage05;

		[AccessedThroughProperty("Label40")]
		private System.Windows.Forms.Label _Label40;

		[AccessedThroughProperty("Label39")]
		private System.Windows.Forms.Label _Label39;

		[AccessedThroughProperty("txtInput_PlatImageDate")]
		private System.Windows.Forms.TextBox _txtInput_PlatImageDate;

		[AccessedThroughProperty("txtInput_MuniCourtImageDate")]
		private System.Windows.Forms.TextBox _txtInput_MuniCourtImageDate;

		[AccessedThroughProperty("txtInput_CivCourtImageDate")]
		private System.Windows.Forms.TextBox _txtInput_CivCourtImageDate;

		[AccessedThroughProperty("txtInput_LandImageDate")]
		private System.Windows.Forms.TextBox _txtInput_LandImageDate;

		[AccessedThroughProperty("txtInput_PlatIndexDate")]
		private System.Windows.Forms.TextBox _txtInput_PlatIndexDate;

		[AccessedThroughProperty("txtInput_MuniCourtIndexDate")]
		private System.Windows.Forms.TextBox _txtInput_MuniCourtIndexDate;

		[AccessedThroughProperty("txtInput_CivCourtIndexDate")]
		private System.Windows.Forms.TextBox _txtInput_CivCourtIndexDate;

		[AccessedThroughProperty("txtInput_LandIndexDate")]
		private System.Windows.Forms.TextBox _txtInput_LandIndexDate;

		[AccessedThroughProperty("Label34")]
		private System.Windows.Forms.Label _Label34;

		[AccessedThroughProperty("Label36")]
		private System.Windows.Forms.Label _Label36;

		[AccessedThroughProperty("Label37")]
		private System.Windows.Forms.Label _Label37;

		[AccessedThroughProperty("Label38")]
		private System.Windows.Forms.Label _Label38;

		[AccessedThroughProperty("ckbxProdTaxReports")]
		private System.Windows.Forms.CheckBox _ckbxProdTaxReports;

		[AccessedThroughProperty("Label3")]
		private System.Windows.Forms.Label _Label3;

		[AccessedThroughProperty("ckbxProdDocRet")]
		private System.Windows.Forms.CheckBox _ckbxProdDocRet;

		[AccessedThroughProperty("ckbxProdIns")]
		private System.Windows.Forms.CheckBox _ckbxProdIns;

		[AccessedThroughProperty("ckbxProdPropReports")]
		private System.Windows.Forms.CheckBox _ckbxProdPropReports;

		[AccessedThroughProperty("TabPage06")]
		private TabPage _TabPage06;

		[AccessedThroughProperty("txtInput_Copy_Pmt_Method")]
		private System.Windows.Forms.TextBox _txtInput_Copy_Pmt_Method;

		[AccessedThroughProperty("txtInput_Index_Pmt_Method")]
		private System.Windows.Forms.TextBox _txtInput_Index_Pmt_Method;

		[AccessedThroughProperty("txtInput_SubscripTerm")]
		private System.Windows.Forms.TextBox _txtInput_SubscripTerm;

		[AccessedThroughProperty("txtInput_CopySource")]
		private System.Windows.Forms.TextBox _txtInput_CopySource;

		[AccessedThroughProperty("txtInput_LandIndexSource")]
		private System.Windows.Forms.TextBox _txtInput_LandIndexSource;

		[AccessedThroughProperty("txtInput_SubscripFeeAmt")]
		private System.Windows.Forms.TextBox _txtInput_SubscripFeeAmt;

		[AccessedThroughProperty("txtCopyFeeAmount")]
		private System.Windows.Forms.TextBox _txtCopyFeeAmount;

		[AccessedThroughProperty("txtInput_Comments")]
		private System.Windows.Forms.TextBox _txtInput_Comments;

		[AccessedThroughProperty("label61")]
		private System.Windows.Forms.Label _label61;

		[AccessedThroughProperty("ckbxSubscripIsFree")]
		private System.Windows.Forms.CheckBox _ckbxSubscripIsFree;

		[AccessedThroughProperty("ckbxWeAreSubscribed")]
		private System.Windows.Forms.CheckBox _ckbxWeAreSubscribed;

		[AccessedThroughProperty("ckbxSubscripNeeded")]
		private System.Windows.Forms.CheckBox _ckbxSubscripNeeded;

		[AccessedThroughProperty("Label43")]
		private System.Windows.Forms.Label _Label43;

		[AccessedThroughProperty("Label42")]
		private System.Windows.Forms.Label _Label42;

		[AccessedThroughProperty("Label84")]
		private System.Windows.Forms.Label _Label84;

		[AccessedThroughProperty("Label80")]
		private System.Windows.Forms.Label _Label80;

		[AccessedThroughProperty("Label78")]
		private System.Windows.Forms.Label _Label78;

		[AccessedThroughProperty("Label10")]
		private System.Windows.Forms.Label _Label10;

		[AccessedThroughProperty("ckbxUseTapestry")]
		private System.Windows.Forms.CheckBox _ckbxUseTapestry;

		[AccessedThroughProperty("ckbxUseDatatree")]
		private System.Windows.Forms.CheckBox _ckbxUseDatatree;

		[AccessedThroughProperty("Label6")]
		private System.Windows.Forms.Label _Label6;

		[AccessedThroughProperty("ckbxUseRedVision")]
		private System.Windows.Forms.CheckBox _ckbxUseRedVision;

		[AccessedThroughProperty("Label2")]
		private System.Windows.Forms.Label _Label2;

		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		[AccessedThroughProperty("txtInput_DelinqTaxURL")]
		private System.Windows.Forms.TextBox _txtInput_DelinqTaxURL;

		[AccessedThroughProperty("Label5")]
		private System.Windows.Forms.Label _Label5;

		[AccessedThroughProperty("Label41")]
		private System.Windows.Forms.Label _Label41;

		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[AccessedThroughProperty("Label66")]
		private System.Windows.Forms.Label _Label66;

		[AccessedThroughProperty("txtInput_DeedNotes")]
		private System.Windows.Forms.TextBox _txtInput_DeedNotes;

		[AccessedThroughProperty("Label65")]
		private System.Windows.Forms.Label _Label65;

		[AccessedThroughProperty("txtInput_HomesteadNotes")]
		private System.Windows.Forms.TextBox _txtInput_HomesteadNotes;

		[AccessedThroughProperty("Label64")]
		private System.Windows.Forms.Label _Label64;

		[AccessedThroughProperty("txtInput_ForeclosureNotes")]
		private System.Windows.Forms.TextBox _txtInput_ForeclosureNotes;

		[AccessedThroughProperty("Label58")]
		private System.Windows.Forms.Label _Label58;

		[AccessedThroughProperty("txtInput_ProbateNotes")]
		private System.Windows.Forms.TextBox _txtInput_ProbateNotes;

		[AccessedThroughProperty("ckbx_BeingClause")]
		private System.Windows.Forms.CheckBox _ckbx_BeingClause;

		[AccessedThroughProperty("Label69")]
		private System.Windows.Forms.Label _Label69;

		[AccessedThroughProperty("txtInput_AttyNotes")]
		private System.Windows.Forms.TextBox _txtInput_AttyNotes;

		[AccessedThroughProperty("Label68")]
		private System.Windows.Forms.Label _Label68;

		[AccessedThroughProperty("txtInput_PolicyNotes")]
		private System.Windows.Forms.TextBox _txtInput_PolicyNotes;

		[AccessedThroughProperty("ckbx_AttyTitleSearch")]
		private System.Windows.Forms.CheckBox _ckbx_AttyTitleSearch;

		[AccessedThroughProperty("txtInput_NotaryURL")]
		private System.Windows.Forms.TextBox _txtInput_NotaryURL;

		[AccessedThroughProperty("Label67")]
		private System.Windows.Forms.Label _Label67;

		[AccessedThroughProperty("txtInput_State_CodeURL")]
		private System.Windows.Forms.TextBox _txtInput_State_CodeURL;

		[AccessedThroughProperty("txtInput_Sec_of_State_url")]
		private System.Windows.Forms.TextBox _txtInput_Sec_of_State_url;

		[AccessedThroughProperty("txtInput_DOIurl")]
		private System.Windows.Forms.TextBox _txtInput_DOIurl;

		[AccessedThroughProperty("Label56")]
		private System.Windows.Forms.Label _Label56;

		[AccessedThroughProperty("Label62")]
		private System.Windows.Forms.Label _Label62;

		[AccessedThroughProperty("Label63")]
		private System.Windows.Forms.Label _Label63;

		[AccessedThroughProperty("cbox_DeedPrep")]
		private ComboBox _cbox_DeedPrep;

		[AccessedThroughProperty("Label52")]
		private System.Windows.Forms.Label _Label52;

		[AccessedThroughProperty("ckbx_Homestead")]
		private System.Windows.Forms.CheckBox _ckbx_Homestead;

		[AccessedThroughProperty("ckbx_AttyCloser")]
		private System.Windows.Forms.CheckBox _ckbx_AttyCloser;

		[AccessedThroughProperty("lblOpenORB")]
		private System.Windows.Forms.Label _lblOpenORB;

		[AccessedThroughProperty("pboxOpenORB")]
		private PictureBox _pboxOpenORB;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		private System.Data.DataTable dt0;

		private F2_Resource_Lookup orb_obj;

		private Statutes_Lookup orbStats;

		private int i;

		private int c;

		private string dsn;

		private StringBuilder sb;

		private System.Data.DataTable dt;

		private OleDbDataAdapter da;

		private OleDbCommandBuilder cmdBuilder;

		private OleDbCommand cmd;

		private string Import_File;

		private string sheetNm1;

		private string sheetNm2;

		private string sheetNm3;

		private string sheetNm4;

		private string sheetNm5;

		private string sheetNm7;

		private string sheetNm8;

		internal virtual System.Windows.Forms.Button Button_ExitApp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_ExitApp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.Button_ExitApp_Click);
				if (this._Button_ExitApp != null)
				{
					this._Button_ExitApp.Click -= eventHandler;
				}
				this._Button_ExitApp = value;
				if (this._Button_ExitApp != null)
				{
					this._Button_ExitApp.Click += eventHandler;
				}
			}
		}

		internal virtual System.Windows.Forms.Button Button_EXITupdates
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_EXITupdates;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.Button_EXITupdates_Click);
				if (this._Button_EXITupdates != null)
				{
					this._Button_EXITupdates.Click -= eventHandler;
				}
				this._Button_EXITupdates = value;
				if (this._Button_EXITupdates != null)
				{
					this._Button_EXITupdates.Click += eventHandler;
				}
			}
		}

		internal virtual System.Windows.Forms.Button Button_NEW
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_NEW;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.Button_NEW_Click);
				if (this._Button_NEW != null)
				{
					this._Button_NEW.Click -= eventHandler;
				}
				this._Button_NEW = value;
				if (this._Button_NEW != null)
				{
					this._Button_NEW.Click += eventHandler;
				}
			}
		}

		internal virtual System.Windows.Forms.Button Button_Reset
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_Reset;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.Button_Reset_Click);
				if (this._Button_Reset != null)
				{
					this._Button_Reset.Click -= eventHandler;
				}
				this._Button_Reset = value;
				if (this._Button_Reset != null)
				{
					this._Button_Reset.Click += eventHandler;
				}
			}
		}

		internal virtual System.Windows.Forms.Button Button_SAVE
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_SAVE;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.Button_SAVE_Click);
				if (this._Button_SAVE != null)
				{
					this._Button_SAVE.Click -= eventHandler;
				}
				this._Button_SAVE = value;
				if (this._Button_SAVE != null)
				{
					this._Button_SAVE.Click += eventHandler;
				}
			}
		}

		internal virtual System.Windows.Forms.Button Button_SEARCH
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_SEARCH;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.Button_SEARCH_Click);
				if (this._Button_SEARCH != null)
				{
					this._Button_SEARCH.Click -= eventHandler;
				}
				this._Button_SEARCH = value;
				if (this._Button_SEARCH != null)
				{
					this._Button_SEARCH.Click += eventHandler;
				}
			}
		}

		internal virtual ComboBox cbox_DeedPrep
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbox_DeedPrep;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbox_DeedPrep = value;
			}
		}

		internal virtual ComboBox cboxCounty_EditORB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cboxCounty_EditORB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.cboxCounty_EditORB_SelectedIndexChanged);
				if (this._cboxCounty_EditORB != null)
				{
					this._cboxCounty_EditORB.TextChanged -= eventHandler;
				}
				this._cboxCounty_EditORB = value;
				if (this._cboxCounty_EditORB != null)
				{
					this._cboxCounty_EditORB.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboxInput_TaxBillingCycle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cboxInput_TaxBillingCycle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboxInput_TaxBillingCycle = value;
			}
		}

		internal virtual ComboBox cboxState_EditORB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cboxState_EditORB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.cboxState_EditORB_TextChanged);
				if (this._cboxState_EditORB != null)
				{
					this._cboxState_EditORB.TextChanged -= eventHandler;
				}
				this._cboxState_EditORB = value;
				if (this._cboxState_EditORB != null)
				{
					this._cboxState_EditORB.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboxTaxAuth_EditORB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cboxTaxAuth_EditORB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_Edit frmEdit = this;
				EventHandler eventHandler = new EventHandler(frmEdit.cboxTaxAuth_EditORB_SelectedIndexChanged);
				if (this._cboxTaxAuth_EditORB != null)
				{
					this._cboxTaxAuth_EditORB.TextChanged -= eventHandler;
				}
				this._cboxTaxAuth_EditORB = value;
				if (this._cboxTaxAuth_EditORB != null)
				{
					this._cboxTaxAuth_EditORB.TextChanged += eventHandler;
				}
			}
		}

		internal virtual ComboBox cboxTaxAuthType_EditORB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cboxTaxAuthType_EditORB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cboxTaxAuthType_EditORB = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox chkbxTaxCertRequired
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkbxTaxCertRequired;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkbxTaxCertRequired = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbx_AttyCloser
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbx_AttyCloser;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbx_AttyCloser = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbx_AttyTitleSearch
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbx_AttyTitleSearch;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbx_AttyTitleSearch = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbx_BeingClause
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbx_BeingClause;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbx_BeingClause = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbx_Homestead
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbx_Homestead;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbx_Homestead = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxLoginRequired
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxLoginRequired;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxLoginRequired = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxProdDocRet
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxProdDocRet;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxProdDocRet = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxProdIns
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxProdIns;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxProdIns = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxProdPropReports
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxProdPropReports;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxProdPropReports = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxProdTaxReports
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxProdTaxReports;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxProdTaxReports = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxSubscripIsFree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxSubscripIsFree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxSubscripIsFree = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxSubscripNeeded
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxSubscripNeeded;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxSubscripNeeded = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxUseDatatree
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxUseDatatree;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxUseDatatree = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxUseRedVision
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxUseRedVision;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxUseRedVision = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxUseTapestry
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxUseTapestry;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxUseTapestry = value;
			}
		}

		internal virtual System.Windows.Forms.CheckBox ckbxWeAreSubscribed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ckbxWeAreSubscribed;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ckbxWeAreSubscribed = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label1
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

		internal virtual System.Windows.Forms.Label Label10
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

		internal virtual System.Windows.Forms.Label Label11
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

		internal virtual System.Windows.Forms.Label Label12
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

		internal virtual System.Windows.Forms.Label Label13
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

		internal virtual System.Windows.Forms.Label Label14
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

		internal virtual System.Windows.Forms.Label Label15
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

		internal virtual System.Windows.Forms.Label Label16
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

		internal virtual System.Windows.Forms.Label Label17
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

		internal virtual System.Windows.Forms.Label Label18
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

		internal virtual System.Windows.Forms.Label Label19
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

		internal virtual System.Windows.Forms.Label Label2
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

		internal virtual System.Windows.Forms.Label Label20
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

		internal virtual System.Windows.Forms.Label Label21
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

		internal virtual System.Windows.Forms.Label Label22
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

		internal virtual System.Windows.Forms.Label Label23
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

		internal virtual System.Windows.Forms.Label Label24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label24 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label25
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

		internal virtual System.Windows.Forms.Label Label26
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

		internal virtual System.Windows.Forms.Label Label27
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

		internal virtual System.Windows.Forms.Label Label28
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

		internal virtual System.Windows.Forms.Label Label29
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

		internal virtual System.Windows.Forms.Label Label3
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

		internal virtual System.Windows.Forms.Label Label30
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

		internal virtual System.Windows.Forms.Label Label31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label31 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label32
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

		internal virtual System.Windows.Forms.Label Label33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label33 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label34
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

		internal virtual System.Windows.Forms.Label Label35
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

		internal virtual System.Windows.Forms.Label Label36
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

		internal virtual System.Windows.Forms.Label Label37
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

		internal virtual System.Windows.Forms.Label Label38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label38 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label39
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

		internal virtual System.Windows.Forms.Label Label4
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

		internal virtual System.Windows.Forms.Label Label40
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

		internal virtual System.Windows.Forms.Label Label41
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

		internal virtual System.Windows.Forms.Label Label42
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label42;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label42 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label43
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label43;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label43 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label44
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label44;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label44 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label45
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label45;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label45 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label46
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

		internal virtual System.Windows.Forms.Label Label47
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label47;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label47 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label48
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

		internal virtual System.Windows.Forms.Label Label49
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

		internal virtual System.Windows.Forms.Label Label5
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

		internal virtual System.Windows.Forms.Label Label50
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

		internal virtual System.Windows.Forms.Label Label51
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

		internal virtual System.Windows.Forms.Label Label52
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

		internal virtual System.Windows.Forms.Label Label53
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label53;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label53 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label54
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

		internal virtual System.Windows.Forms.Label Label55
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

		internal virtual System.Windows.Forms.Label Label56
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

		internal virtual System.Windows.Forms.Label Label57
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label57;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label57 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label58
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

		internal virtual System.Windows.Forms.Label Label59
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label59;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label59 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label6
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

		internal virtual System.Windows.Forms.Label Label60
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label60;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label60 = value;
			}
		}

		internal virtual System.Windows.Forms.Label label61
		{
			[DebuggerNonUserCode]
			get
			{
				return this._label61;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._label61 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label62
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

		internal virtual System.Windows.Forms.Label Label63
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label63;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label63 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label64
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

		internal virtual System.Windows.Forms.Label Label65
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label65;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label65 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label66
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

		internal virtual System.Windows.Forms.Label Label67
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label67;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label67 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label68
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label68;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label68 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label69
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label69;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label69 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label7
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

		internal virtual System.Windows.Forms.Label Label73
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

		internal virtual System.Windows.Forms.Label Label74
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

		internal virtual System.Windows.Forms.Label Label75
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

		internal virtual System.Windows.Forms.Label Label76
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

		internal virtual System.Windows.Forms.Label Label77
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

		internal virtual System.Windows.Forms.Label Label78
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

		internal virtual System.Windows.Forms.Label Label79
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label79;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label79 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label8
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

		internal virtual System.Windows.Forms.Label Label80
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

		internal virtual System.Windows.Forms.Label Label81
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label81;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label81 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label82
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

		internal virtual System.Windows.Forms.Label Label83
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label83;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label83 = value;
			}
		}

		internal virtual System.Windows.Forms.Label Label84
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

		internal virtual System.Windows.Forms.Label Label85
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

		internal virtual System.Windows.Forms.Label Label87
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

		internal virtual System.Windows.Forms.Label Label88
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

		internal virtual System.Windows.Forms.Label Label89
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

		internal virtual System.Windows.Forms.Label Label9
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

		internal virtual System.Windows.Forms.Label Label90
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

		internal virtual System.Windows.Forms.Label Label91
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

		internal virtual System.Windows.Forms.Label Label92
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

		internal virtual System.Windows.Forms.Label Label93
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

		internal virtual System.Windows.Forms.Label Label94
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

		internal virtual System.Windows.Forms.Label Label96
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

		internal virtual System.Windows.Forms.Label lblNewState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblNewState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblNewState = value;
			}
		}

		internal virtual System.Windows.Forms.Label lblOpenORB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblOpenORB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblOpenORB = value;
			}
		}

		internal virtual System.Windows.Forms.Label lblTaxCounty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTaxCounty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTaxCounty = value;
			}
		}

		internal virtual PictureBox pboxOpenORB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pboxOpenORB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pboxOpenORB = value;
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
				frm_Edit frmEdit = this;
				DrawItemEventHandler drawItemEventHandler = new DrawItemEventHandler(frmEdit.TabControl1_DrawItem);
				if (this._TabControl1 != null)
				{
					this._TabControl1.DrawItem -= drawItemEventHandler;
				}
				this._TabControl1 = value;
				if (this._TabControl1 != null)
				{
					this._TabControl1.DrawItem += drawItemEventHandler;
				}
			}
		}

		internal virtual TabPage TabPage01
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage01;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage01 = value;
			}
		}

		internal virtual TabPage TabPage03
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage03;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage03 = value;
			}
		}

		internal virtual TabPage TabPage05
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage05;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage05 = value;
			}
		}

		internal virtual TabPage TabPage06
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage06;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage06 = value;
			}
		}

		internal virtual TabPage TabPage07
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage07;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage07 = value;
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

		internal virtual System.Windows.Forms.TextBox txt_TaxDateVerified
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_TaxDateVerified;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_TaxDateVerified = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtCopyFeeAmount
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCopyFeeAmount;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtCopyFeeAmount = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_AssessorPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_AssessorPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_AssessorPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_AssessorURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_AssessorURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_AssessorURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_AssessorUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_AssessorUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_AssessorUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_AttyNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_AttyNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_AttyNotes = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_CivCourtImageDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_CivCourtImageDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_CivCourtImageDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_CivCourtIndexDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_CivCourtIndexDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_CivCourtIndexDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_CivCtIndexURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_CivCtIndexURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_CivCtIndexURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_CivCtPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_CivCtPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_CivCtPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_CivCtUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_CivCtUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_CivCtUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_Comments
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_Comments;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_Comments = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_Copy_Pmt_Method
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_Copy_Pmt_Method;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_Copy_Pmt_Method = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_CopySource
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_CopySource;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_CopySource = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_CountyHomeURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_CountyHomeURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_CountyHomeURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_DeedNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_DeedNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_DeedNotes = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_DelinqTaxURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_DelinqTaxURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_DelinqTaxURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_DOIurl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_DOIurl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_DOIurl = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ForeclosureNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ForeclosureNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ForeclosureNotes = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ForeclosureURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ForeclosureURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ForeclosureURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_HomesteadNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_HomesteadNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_HomesteadNotes = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_Index_Pmt_Method
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_Index_Pmt_Method;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_Index_Pmt_Method = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_LandImageDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_LandImageDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_LandImageDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_LandIndexDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_LandIndexDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_LandIndexDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_LandIndexSource
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_LandIndexSource;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_LandIndexSource = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_LandIndexURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_LandIndexURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_LandIndexURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_LandPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_LandPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_LandPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_LandUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_LandUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_LandUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_LocalTaxURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_LocalTaxURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_LocalTaxURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_MapURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_MapURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_MapURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_MuniCourtImageDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_MuniCourtImageDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_MuniCourtImageDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_MuniCourtIndexDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_MuniCourtIndexDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_MuniCourtIndexDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_MuniCtPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_MuniCtPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_MuniCtPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_MuniCtURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_MuniCtURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_MuniCtURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_MuniCtUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_MuniCtUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_MuniCtUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_NewTaxCounty
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_NewTaxCounty;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_NewTaxCounty = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_NewTaxState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_NewTaxState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_NewTaxState = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_NotaryURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_NotaryURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_NotaryURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_OtherURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_OtherURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_OtherURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_OtherURLPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_OtherURLPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_OtherURLPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_OtherURLUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_OtherURLUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_OtherURLUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_PlatImageDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_PlatImageDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_PlatImageDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_PlatIndexDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_PlatIndexDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_PlatIndexDate = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_PlatsURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_PlatsURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_PlatsURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_PolicyNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_PolicyNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_PolicyNotes = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ProbateNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ProbateNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ProbateNotes = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ProbatePwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ProbatePwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ProbatePwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ProbateURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ProbateURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ProbateURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ProbateUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ProbateUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ProbateUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ProthonPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ProthonPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ProthonPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ProthonURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ProthonURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ProthonURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_ProthonUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_ProthonUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_ProthonUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_Sec_of_State_url
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_Sec_of_State_url;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_Sec_of_State_url = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SheriffURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SheriffURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SheriffURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_AfterAcquired
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_AfterAcquired;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_AfterAcquired = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_ClaimOfLien
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_ClaimOfLien;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_ClaimOfLien = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_CreditorClaims
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_CreditorClaims;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_CreditorClaims = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_ForeclosureRedem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_ForeclosureRedem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_ForeclosureRedem = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_HelocAM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_HelocAM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_HelocAM = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_HelocRD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_HelocRD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_HelocRD = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_HOALien
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_HOALien;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_HOALien = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_HospLien
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_HospLien;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_HospLien = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_Jgmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_Jgmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_Jgmt = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_LisPendens
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_LisPendens;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_LisPendens = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_MechLiens
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_MechLiens;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_MechLiens = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_MtgAM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_MtgAM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_MtgAM = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_MtgRD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_MtgRD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_MtgRD = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_Notice
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_Notice;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_Notice = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_PersonalTax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_PersonalTax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_PersonalTax = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_SpousalState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_SpousalState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_SpousalState = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_StateJgmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_StateJgmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_StateJgmt = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_SupportObl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_SupportObl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_SupportObl = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_TaxTakingRedem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_TaxTakingRedem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_TaxTakingRedem = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_TE_Rule
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_TE_Rule;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_TE_Rule = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SOL_Vesting
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SOL_Vesting;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SOL_Vesting = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_State_CodeURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_State_CodeURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_State_CodeURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SubscripFeeAmt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SubscripFeeAmt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SubscripFeeAmt = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_SubscripTerm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_SubscripTerm;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_SubscripTerm = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_Tax2URL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_Tax2URL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_Tax2URL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxAuthName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxAuthName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxAuthName = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxAuthType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxAuthType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxAuthType = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxCertFee
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxCertFee;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxCertFee = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxCertTAT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxCertTAT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxCertTAT = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxComments
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxComments;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxComments = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxCountyPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxCountyPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxCountyPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxCountyURL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxCountyURL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxCountyURL = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxCountyUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxCountyUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxCountyUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxDueDates
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxDueDates;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxDueDates = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxLocalPwd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxLocalPwd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxLocalPwd = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxLocalUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxLocalUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxLocalUsername = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxOfficeHours
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxOfficeHours;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxOfficeHours = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeeCity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeeCity;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeeCity = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeeFax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeeFax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeeFax = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeeName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeeName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeeName = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeePhone
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeePhone;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeePhone = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeeState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeeState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeeState = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeeStr1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeeStr1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeeStr1 = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeeStr2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeeStr2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeeStr2 = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_TaxPayeeZip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_TaxPayeeZip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_TaxPayeeZip = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtInput_UCC_url
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtInput_UCC_url;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtInput_UCC_url = value;
			}
		}

		internal virtual System.Windows.Forms.TextBox txtSOL_notes
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

		public frm_Edit()
		{
			frm_Edit frmEdit = this;
			base.Load += new EventHandler(frmEdit.frm_Edit_Load);
			this.dt0 = new System.Data.DataTable();
			this.i = 0;
			this.c = 0;
			this.sb = new StringBuilder();
			this.dt = new System.Data.DataTable();
			this.da = new OleDbDataAdapter();
			this.cmdBuilder = new OleDbCommandBuilder();
			this.cmd = new OleDbCommand();
			this.Import_File = "T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ORB_DATABASE.xls";
			this.sheetNm1 = "orb";
			this.sheetNm2 = "taxes";
			this.sheetNm3 = "state_counsels";
			this.sheetNm4 = "statutes";
			this.sheetNm5 = "other_logins";
			this.sheetNm7 = "misc";
			this.sheetNm8 = "customers";
			this.InitializeComponent();
		}

		private void Button_ExitApp_Click(object sender, EventArgs e)
		{
			this.Close();
			System.Windows.Forms.Application.OpenForms["Form1"].Close();
		}

		private void Button_EXITupdates_Click(object sender, EventArgs e)
		{
			Form1 thisForm = ((Form1)System.Windows.Forms.Application.OpenForms["Form1"]);
			thisForm.Panel2.Visible = false;
			thisForm.TabControl1.Visible = true;
			thisForm.SplitContainer1.Visible = true;
			thisForm.SplitContainer1.Panel1Collapsed = false;
			thisForm.SplitContainer1.Height = 363;
		}

		private void Button_NEW_Click(object sender, EventArgs e)
		{
			this.txtInput_NewTaxState.ResetText();
			this.txtInput_NewTaxCounty.ResetText();
			this.txtInput_TaxAuthType.ResetText();
			this.txtInput_TaxAuthName.ResetText();
			this.txtInput_TaxPayeeName.ResetText();
			this.txtInput_TaxPayeeStr1.ResetText();
			this.txtInput_LocalTaxURL.ResetText();
			this.txtInput_TaxPayeeStr2.ResetText();
			this.txtInput_TaxPayeeCity.ResetText();
			this.txtInput_TaxPayeeState.ResetText();
			this.txtInput_TaxPayeeZip.ResetText();
			this.txtInput_TaxPayeePhone.ResetText();
			this.txtInput_TaxPayeeFax.ResetText();
			this.txtInput_TaxOfficeHours.ResetText();
			this.txtInput_TaxCertFee.ResetText();
			this.txtInput_TaxDueDates.ResetText();
			this.txtInput_TaxComments.ResetText();
			this.chkbxTaxCertRequired.Checked = false;
		}

		private void Button_Reset_Click(object sender, EventArgs e)
		{
			this.cboxState_EditORB.ResetText();
			this.cboxCounty_EditORB.ResetText();
			this.cboxCounty_EditORB.Items.Clear();
			this.cboxCounty_EditORB.Text = "choose";
			this.cboxTaxAuth_EditORB.Items.Clear();
			this.cboxTaxAuth_EditORB.Text = "choose";
			this.cboxTaxAuthType_EditORB.Items.Clear();
			this.cboxTaxAuthType_EditORB.Text = "choose";
		}

		private void Button_SAVE_Click(object sender, EventArgs e)
		{
			int i;
			Microsoft.Office.Interop.Excel.Application applicationClass = new Microsoft.Office.Interop.Excel.ApplicationClass()
			{
				Visible = false
			};
			Workbook workbook = applicationClass.Workbooks.Open("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ORB_DATABASE.xls", Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			Worksheet worksheets = (Worksheet)workbook.Worksheets["orb"];
			Worksheet worksheet = (Worksheet)workbook.Worksheets["taxes"];
			Worksheet worksheets1 = (Worksheet)workbook.Worksheets["statutes"];
			Worksheet worksheet1 = (Worksheet)workbook.Worksheets["Letters"];
			Worksheet worksheets2 = (Worksheet)workbook.Worksheets["misc"];
			Worksheet worksheet2 = (Worksheet)workbook.Worksheets["customers"];
			long str = (long)0;
			long upper = (long)-1;
			long num = (long)0;
			long str1 = (long)0;
			long num1 = (long)0;
			long count = (long)2;
			string[,] strArrays = new string[8, 71];
			for (i = 1; i <= 70; i = checked(i + 1))
			{
				strArrays[0, i] = worksheet1.Range[string.Concat("A", Conversions.ToString(i)), Missing.Value].Value.ToString();
			}
			i = 1;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TabControl1.SelectedTab.Name.ToString(), "TabPage06", false) == 0)
			{
				strArrays[1, 0] = "orb";
				while (i <= 64)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheets.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString(), null, false) != 0)
					{
						strArrays[1, i] = worksheets.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString();
					}
					i = checked(i + 1);
				}
				i = 1;
				while (count <= (long)worksheets.Rows.Count)
				{
					if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.cboxState_EditORB.SelectedItem, worksheets.Range[string.Concat("A", Conversions.ToString(count)), Missing.Value].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.cboxCounty_EditORB.SelectedItem, worksheets.Range[string.Concat("B", Conversions.ToString(count)), Missing.Value].Value, false))))
					{
						str = count;
						count = checked(count + (long)worksheets.Rows.Count);
					}
					count = checked(count + (long)1);
				}
				count = (long)2;
				if (!this.ckbxSubscripNeeded.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("sub_need", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("sub_need", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbxWeAreSubscribed.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("we_subscribe", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("we_subscribe", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				worksheets.Range[string.Concat(this.ColHeads("sub_term", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_SubscripTerm.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("subFee", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_SubscripFeeAmt.Text.ToString();
				if (!this.ckbxUseDatatree.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("dtree_desk", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("dtree_desk", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbxUseTapestry.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("tap", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("tap", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbxUseRedVision.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("rv", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("rv", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				string.Concat(this.ColHeads("comments", "orb", strArrays), Conversions.ToString(str));
				worksheets.Range[string.Concat(this.ColHeads("comments", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_Comments.Text.ToString();
				Marshal.FinalReleaseComObject(worksheets);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TabControl1.SelectedTab.Name.ToString(), "TabPage05", false) == 0)
			{
				strArrays[1, 0] = "orb";
				while (i <= 64)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheets.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString(), null, false) != 0)
					{
						strArrays[1, i] = worksheets.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString();
					}
					i = checked(i + 1);
				}
				i = 1;
				while (count <= (long)worksheets.Rows.Count)
				{
					if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.cboxState_EditORB.SelectedItem, worksheets.Range[string.Concat("A", Conversions.ToString(count)), Missing.Value].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.cboxCounty_EditORB.SelectedItem, worksheets.Range[string.Concat("B", Conversions.ToString(count)), Missing.Value].Value, false))))
					{
						str = count;
						count = checked(count + (long)worksheets.Rows.Count);
					}
					count = checked(count + (long)1);
				}
				count = (long)2;
				if (!this.ckbxProdIns.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("ins", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("ins", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbxProdPropReports.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("props", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("props", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbxProdDocRet.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("copy", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("copy", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Yes";
				}
				Marshal.FinalReleaseComObject(worksheets);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TabControl1.SelectedTab.Name.ToString(), "TabPage01", false) == 0)
			{
				strArrays[1, 0] = "orb";
				while (i <= 64)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheets.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString(), null, false) != 0)
					{
						strArrays[1, i] = worksheets.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString();
					}
					i = checked(i + 1);
				}
				i = 1;
				while (count <= (long)worksheets.Rows.Count)
				{
					if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.cboxState_EditORB.SelectedItem, worksheets.Range[string.Concat("A", Conversions.ToString(count)), Missing.Value].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.cboxCounty_EditORB.SelectedItem, worksheets.Range[string.Concat("B", Conversions.ToString(count)), Missing.Value].Value, false))))
					{
						str = count;
						count = checked(count + (long)worksheets.Rows.Count);
					}
					count = checked(count + (long)1);
				}
				count = (long)2;
				if (!this.ckbxLoginRequired.Checked)
				{
					worksheets.Range[string.Concat(this.ColHeads("login_req", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "N";
				}
				else
				{
					worksheets.Range[string.Concat(this.ColHeads("login_req", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = "Y";
				}
				worksheets.Range[string.Concat(this.ColHeads("land_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_LandIndexURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("county_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_LandUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("county_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_LandPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("index_date", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_LandIndexDate.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("img_date", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_LandImageDate.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("copy_source", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_CopySource.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("copy_pmt_method", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_Copy_Pmt_Method.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("copyFeeAmt", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtCopyFeeAmount.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("index_pmt_method", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_Index_Pmt_Method.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("subscrFeeAmt", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_SubscripFeeAmt.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("subscr_term", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_SubscripTerm.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("assessor_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_AssessorURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("assessor_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_AssessorUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("assessor_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_AssessorPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("tax_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_TaxCountyURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("tax_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_TaxCountyUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("tax_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_TaxCountyPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("delinq_tax_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_DelinqTaxURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("tax2_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_Tax2URL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("tax2_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_TaxLocalUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("tax2_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_TaxLocalPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("ucc_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_UCC_url.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("muniCourt_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_MuniCtURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("muni_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_MuniCtUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("muni_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_MuniCtPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("prothon_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_ProthonURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("pro_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_ProthonUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("pro_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_ProthonPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("sheriff_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_SheriffURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("court_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_CivCtIndexURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("court_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_CivCtUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("court_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_CivCtPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("foreclosure_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_ForeclosureURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("probate_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_ProbateURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("probate_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_ProbateUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("probate_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_ProbatePwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("map_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_MapURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("plat_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_PlatsURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("county_homepage", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_CountyHomeURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("other_url", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_OtherURL.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("other_user", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_OtherURLUsername.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("other_pwd", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_OtherURLPwd.Text.ToString();
				worksheets.Range[string.Concat(this.ColHeads("index_source", "orb", strArrays), Conversions.ToString(str)), Missing.Value].Value = this.txtInput_LandIndexSource.Text.ToString();
				Marshal.FinalReleaseComObject(worksheets);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TabControl1.SelectedTab.Name.ToString(), "TabPage03", false) == 0)
			{
				strArrays[2, 0] = "taxes";
				while (i <= 21)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheet.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString(), "", false) != 0)
					{
						strArrays[2, i] = worksheet.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString();
					}
					i = checked(i + 1);
				}
				i = 1;
				this.cboxState_EditORB.Text = this.txtInput_NewTaxState.Text.ToUpper();
				this.cboxCounty_EditORB.Text = this.txtInput_NewTaxCounty.Text.ToUpper();
				this.cboxTaxAuth_EditORB.Text = this.txtInput_TaxAuthName.Text.ToUpper();
				this.cboxTaxAuthType_EditORB.Text = this.txtInput_TaxAuthType.Text.ToUpper();
				while (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(worksheet.Range[string.Concat("A", Conversions.ToString(count)), Missing.Value].Value)), "", false) != 0)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxState_EditORB.Text, Convert.ToString(RuntimeHelpers.GetObjectValue(worksheet.Range[string.Concat("A", Conversions.ToString(count)), Missing.Value].Value)), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxCounty_EditORB.Text, Convert.ToString(RuntimeHelpers.GetObjectValue(worksheet.Range[string.Concat("B", Conversions.ToString(count)), Missing.Value].Value)), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxTaxAuth_EditORB.Text, Convert.ToString(RuntimeHelpers.GetObjectValue(worksheet.Range[string.Concat("C", Conversions.ToString(count)), Missing.Value].Value)), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxTaxAuthType_EditORB.Text, Convert.ToString(RuntimeHelpers.GetObjectValue(worksheet.Range[string.Concat("D", Conversions.ToString(count)), Missing.Value].Value)), false) == 0)
					{
						upper = count;
					}
					count = checked(count + (long)1);
				}
				if (upper == (long)-1)
				{
					upper = count;
				}
				count = (long)2;
				worksheet.Range[string.Concat(this.ColHeads("st", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_NewTaxState.Text.ToString().ToUpper();
				worksheet.Range[string.Concat(this.ColHeads("county", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_NewTaxCounty.Text.ToString().ToUpper();
				worksheet.Range[string.Concat(this.ColHeads("tax_auth", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxAuthName.Text.ToString().ToUpper();
				worksheet.Range[string.Concat(this.ColHeads("tax_auth_type", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxAuthType.Text.ToString().ToUpper();
				worksheet.Range[string.Concat(this.ColHeads("dt_verified", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txt_TaxDateVerified.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("locTx_url", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_LocalTaxURL.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("phone", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeePhone.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("fax", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeeFax.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("cert_req", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.chkbxTaxCertRequired.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("cert_fee", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxCertFee.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("cycle", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.cboxInput_TaxBillingCycle.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("due_dates", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxDueDates.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("hours", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxOfficeHours.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("notes", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxComments.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("tat", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxCertTAT.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("payee", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeeName.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("street1", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeeStr1.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("street2", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeeStr2.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("city", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeeCity.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("tx_st", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeeState.Text.ToString();
				worksheet.Range[string.Concat(this.ColHeads("zip", "taxes", strArrays), Conversions.ToString(upper)), Missing.Value].Value = this.txtInput_TaxPayeeZip.Text.ToString();
				Marshal.FinalReleaseComObject(worksheet);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TabControl1.SelectedTab.Name.ToString(), "TabPage07", false) == 0)
			{
				strArrays[4, 0] = "statutes";
				while (i <= 27)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheets1.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString(), "", false) != 0)
					{
						strArrays[4, i] = worksheets1.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString();
					}
					i = checked(i + 1);
				}
				i = 1;
				while (count <= (long)worksheets1.Rows.Count)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.cboxState_EditORB.SelectedItem, worksheets1.Range[string.Concat("A", Conversions.ToString(count)), Missing.Value].Value, false))
					{
						num = count;
						count = checked(count + (long)worksheets1.Rows.Count);
					}
					count = checked(count + (long)1);
				}
				count = (long)2;
				worksheets1.Range[string.Concat(this.ColHeads("mtg1RD", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_MtgRD.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("mtg1AM", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_MtgAM.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("helAM", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_HelocAM.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("helRD", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_HelocRD.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("mech_lien", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_MechLiens.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("NOC", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_Notice.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("LP", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_LisPendens.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("HOA", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_HOALien.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("hosp_lien", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_HospLien.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("claim_of_lien", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_ClaimOfLien.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("jgmt", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_Jgmt.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("supt_obl", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_SupportObl.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("state_jgmt", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_StateJgmt.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("aft_acq_lien", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_AfterAcquired.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("TE_rule", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_TE_Rule.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("cred_claims", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_CreditorClaims.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("pers_tx_liens", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_PersonalTax.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("forecl_redem_per", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_ForeclosureRedem.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("tax_redem_per", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_TaxTakingRedem.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("vesting", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_Vesting.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("spousal", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtInput_SOL_SpousalState.Text.ToString();
				worksheets1.Range[string.Concat(this.ColHeads("notes", "statutes", strArrays), Conversions.ToString(num)), Missing.Value].Value = this.txtSOL_notes.Text.ToString();
				Marshal.FinalReleaseComObject(worksheets1);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TabControl1.SelectedTab.Name.ToString(), "TabPage1", false) == 0)
			{
				strArrays[7, 0] = "misc";
				while (i <= 17)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(worksheets2.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString(), "", false) != 0)
					{
						strArrays[7, i] = worksheets2.Range[string.Concat(strArrays[0, i], Conversions.ToString(1)), Missing.Value].Value.ToString();
					}
					i = checked(i + 1);
				}
				i = 1;
				while (count <= (long)worksheets2.Rows.Count)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.cboxState_EditORB.SelectedItem, worksheets2.Range[string.Concat("A", Conversions.ToString(count)), Missing.Value].Value, false))
					{
						str1 = count;
						count = checked(count + (long)worksheets2.Rows.Count);
					}
					count = checked(count + (long)1);
				}
				count = (long)2;
				worksheets2.Range[string.Concat(this.ColHeads("sec_state_url", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_Sec_of_State_url.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("dept_ins_url", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_DOIurl.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("atty_notes", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_AttyNotes.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("homestead_notes", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_HomesteadNotes.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("deed_notes", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_DeedNotes.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("policy_notes", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_PolicyNotes.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("foreclosure_notes", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_ForeclosureNotes.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("probate_notes", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_ProbateNotes.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("notary_url", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.txtInput_NotaryURL.Text.ToString();
				worksheets2.Range[string.Concat(this.ColHeads("deed_prep", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = this.cbox_DeedPrep.Text.ToString();
				if (!this.ckbx_Homestead.Checked)
				{
					worksheets2.Range[string.Concat(this.ColHeads("homestead", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets2.Range[string.Concat(this.ColHeads("homestead", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbx_AttyTitleSearch.Checked)
				{
					worksheets2.Range[string.Concat(this.ColHeads("atty_search", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets2.Range[string.Concat(this.ColHeads("atty_search", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbx_AttyCloser.Checked)
				{
					worksheets2.Range[string.Concat(this.ColHeads("atty_close", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets2.Range[string.Concat(this.ColHeads("atty_close", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "Yes";
				}
				if (!this.ckbx_BeingClause.Checked)
				{
					worksheets2.Range[string.Concat(this.ColHeads("being_clause", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "No";
				}
				else
				{
					worksheets2.Range[string.Concat(this.ColHeads("being_clause", "misc", strArrays), Conversions.ToString(str1)), Missing.Value].Value = "Yes";
				}
				Marshal.FinalReleaseComObject(worksheets);
			}
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			Marshal.FinalReleaseComObject(worksheet1);
			workbook.Close(true, Missing.Value, Missing.Value);
			Marshal.FinalReleaseComObject(workbook);
			applicationClass.Quit();
			Marshal.FinalReleaseComObject(applicationClass);
		}

		private void Button_SEARCH_Click(object sender, EventArgs e)
		{
			string text = this.cboxState_EditORB.Text;
			string str = this.cboxCounty_EditORB.Text;
			string text1 = this.cboxTaxAuth_EditORB.Text;
			string str1 = this.cboxTaxAuthType_EditORB.Text;
			if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text1, "", false) == 0) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "", false) != 0)
			{
				this.orb_obj = new F2_Resource_Lookup(text, str);
				this.cmd.CommandType = CommandType.TableDirect;
				this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
				this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm1, "$]");
				this.cmd.Connection = new OleDbConnection(this.dsn);
				this.da.SelectCommand = this.cmd;
				this.cmdBuilder.DataAdapter = this.da;
				this.da.Fill(this.dt);
				this.da.Dispose();
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxState_EditORB.Text, "", false) != 0)
				{
					while (this.c <= checked(this.dt.Rows.Count - 1))
					{
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["st"].ToString(), this.cboxState_EditORB.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["county"].ToString(), this.cboxCounty_EditORB.Text, false) == 0)
						{
							this.txtInput_LandIndexURL.Text = this.orb_obj.F2land_url;
							this.txtInput_LandUsername.Text = this.orb_obj.F2county_user;
							this.txtInput_LandPwd.Text = this.orb_obj.F2county_pwd;
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2Login_Required, "Y", false) == 0)
							{
								this.ckbxLoginRequired.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2Login_Required, "N", false) == 0)
							{
								this.ckbxLoginRequired.Checked = false;
							}
							else if (null == this.orb_obj.F2Login_Required | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2Login_Required, "**", false) == 0)
							{
								this.ckbxLoginRequired.Checked = false;
							}
							this.txtInput_CivCtIndexURL.Text = this.orb_obj.F2court_url;
							this.txtInput_CivCtUsername.Text = this.orb_obj.F2court_user;
							this.txtInput_CivCtPwd.Text = this.orb_obj.F2court_pwd;
							this.txtInput_MuniCtURL.Text = this.orb_obj.F2muniCourt_url;
							this.txtInput_MuniCtUsername.Text = this.orb_obj.F2muniCourt_user;
							this.txtInput_MuniCtPwd.Text = this.orb_obj.F2muniCourt_pwd;
							this.txtInput_TaxCountyURL.Text = this.orb_obj.F2tax_url;
							this.txtInput_TaxCountyUsername.Text = this.orb_obj.F2tax_user;
							this.txtInput_TaxCountyPwd.Text = this.orb_obj.F2tax_pwd;
							this.txtInput_Tax2URL.Text = this.orb_obj.F2tax2_url;
							this.txtInput_TaxLocalUsername.Text = this.orb_obj.F2tax2_user;
							this.txtInput_TaxLocalPwd.Text = this.orb_obj.F2tax2_pwd;
							this.txtInput_PlatsURL.Text = this.orb_obj.F2plat_url;
							this.txtInput_MapURL.Text = this.orb_obj.F2map_url;
							this.txtInput_ProthonURL.Text = this.orb_obj.F2prothon_url;
							this.txtInput_ProthonUsername.Text = this.orb_obj.F2pro_user;
							this.txtInput_ProthonPwd.Text = this.orb_obj.F2pro_pwd;
							this.txtInput_AssessorURL.Text = this.orb_obj.F2assessor_url;
							this.txtInput_AssessorUsername.Text = this.orb_obj.F2assessor_user;
							this.txtInput_AssessorPwd.Text = this.orb_obj.F2assessor_pwd;
							this.txtInput_ProbateURL.Text = this.orb_obj.F2probate_url;
							this.txtInput_ProbateUsername.Text = this.orb_obj.F2pro_user;
							this.txtInput_ProbatePwd.Text = this.orb_obj.F2pro_pwd;
							this.txtInput_SheriffURL.Text = this.orb_obj.F2sheriff_url;
							this.txtInput_ForeclosureURL.Text = this.orb_obj.F2foreclosure_url;
							this.txtInput_CountyHomeURL.Text = this.orb_obj.F2county_homepage;
							this.txtInput_OtherURL.Text = this.orb_obj.F2other_url;
							this.txtInput_OtherURLUsername.Text = this.orb_obj.F2other_user;
							this.txtInput_OtherURLPwd.Text = this.orb_obj.F2other_pwd;
							this.txtInput_CopySource.Text = this.orb_obj.F2copy_source;
							this.txtInput_LandIndexSource.Text = this.orb_obj.F2index_source;
							this.txtCopyFeeAmount.Text = this.orb_obj.F2copyFeeAmt;
							this.txtInput_SubscripFeeAmt.Text = this.orb_obj.F2subFeeAmt;
							this.txtInput_SubscripTerm.Text = this.orb_obj.F2subTerm;
							this.txtInput_Index_Pmt_Method.Text = this.orb_obj.F2Index_pmt_method;
							this.txtInput_Copy_Pmt_Method.Text = this.orb_obj.F2Copy_pmt_method;
							this.txtInput_Comments.Text = this.orb_obj.F2comments;
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2sub_need, "Yes", false) != 0)
							{
								if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2sub_need, "yes", false) != 0)
								{
									if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2sub_need, "Y", false) == 0)
									{
										goto Label1;
									}
									if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2sub_need, "No", false) != 0)
									{
										if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2sub_need, "no", false) != 0)
										{
											if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2sub_need, "N", false) == 0)
											{
												goto Label2;
											}
											if (this.orb_obj.F2sub_need == null)
											{
												this.ckbxSubscripNeeded.Checked = false;
												goto Label0;
											}
											else
											{
												goto Label0;
											}
										}
									}
								Label2:
									this.ckbxSubscripNeeded.Checked = false;
									goto Label0;
								}
							}
						Label1:
							this.ckbxSubscripNeeded.Checked = true;
						Label0:
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2subscribed, "Yes", false) != 0)
							{
								if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2subscribed, "yes", false) != 0)
								{
									if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2subscribed, "Y", false) == 0)
									{
										goto Label4;
									}
									if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2subscribed, "No", false) != 0)
									{
										if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2subscribed, "no", false) != 0)
										{
											if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2subscribed, "N", false) == 0)
											{
												goto Label5;
											}
											if (this.orb_obj.F2subscribed == null)
											{
												this.ckbxWeAreSubscribed.Checked = false;
												goto Label3;
											}
											else
											{
												goto Label3;
											}
										}
									}
								Label5:
									this.ckbxWeAreSubscribed.Checked = false;
									goto Label3;
								}
							}
						Label4:
							this.ckbxWeAreSubscribed.Checked = true;
						Label3:
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2tap, "Yes", false) == 0)
							{
								this.ckbxUseTapestry.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2tap, "No", false) == 0)
							{
								this.ckbxUseTapestry.Checked = false;
							}
							else if (this.orb_obj.F2tap == null)
							{
								this.ckbxUseTapestry.Checked = false;
							}
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2rv, "Yes", false) == 0)
							{
								this.ckbxUseRedVision.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2rv, "No", false) == 0)
							{
								this.ckbxUseRedVision.Checked = false;
							}
							else if (this.orb_obj.F2rv != null)
							{
								this.ckbxUseRedVision.Checked = false;
							}
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2dtree_desk, "Yes", false) == 0)
							{
								this.ckbxUseDatatree.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2dtree_desk, "No", false) == 0)
							{
								this.ckbxUseDatatree.Checked = false;
							}
							else if (this.orb_obj.F2dtree_desk != null)
							{
								this.ckbxUseDatatree.Checked = false;
							}
							this.txtInput_LandImageDate.Text = this.orb_obj.F2img_date;
							this.txtInput_LandIndexDate.Text = this.orb_obj.F2index_date;
							this.txtInput_CivCourtImageDate.Text = this.orb_obj.F2courtImageDate;
							this.txtInput_CivCourtIndexDate.Text = this.orb_obj.F2courtIndexDate;
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2ins, "Yes", false) == 0)
							{
								this.ckbxProdIns.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2ins, "No", false) == 0)
							{
								this.ckbxProdIns.Checked = false;
							}
							else if (this.orb_obj.F2ins != null)
							{
								this.ckbxProdIns.Checked = false;
							}
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2props, "Yes", false) == 0)
							{
								this.ckbxProdPropReports.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2props, "No", false) == 0)
							{
								this.ckbxProdPropReports.Checked = false;
							}
							else if (this.orb_obj.F2props != null)
							{
								this.ckbxProdPropReports.Checked = false;
							}
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2doc_retrieval, "Yes", false) == 0)
							{
								this.ckbxProdDocRet.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.orb_obj.F2doc_retrieval, "No", false) == 0)
							{
								this.ckbxProdDocRet.Checked = false;
							}
							else if (this.orb_obj.F2doc_retrieval != null)
							{
								this.ckbxProdDocRet.Checked = false;
							}
							this.txtInput_Comments.Text = this.orb_obj.F2comments;
							this.c = checked(this.dt.Rows.Count + this.c);
						}
						this.c = checked(this.c + 1);
					}
				}
				OleDbCommand oleDbCommand = new OleDbCommand();
				System.Data.DataTable dataTable = new System.Data.DataTable();
				int num = 0;
				oleDbCommand.CommandType = CommandType.TableDirect;
				this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
				oleDbCommand.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
				oleDbCommand.Connection = new OleDbConnection(this.dsn);
				this.da.SelectCommand = oleDbCommand;
				this.cmdBuilder.DataAdapter = this.da;
				this.da.Fill(dataTable);
				this.da.Dispose();
				num = 0;
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxTaxAuth_EditORB.Text, "", false) != 0)
				{
					while (num <= checked(dataTable.Rows.Count - 1))
					{
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[num]["st"].ToString(), this.cboxState_EditORB.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[num]["county"].ToString(), this.cboxCounty_EditORB.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[num]["tax_auth"].ToString(), this.cboxTaxAuth_EditORB.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[num]["tax_auth_type"].ToString(), this.cboxTaxAuthType_EditORB.Text, false) == 0)
						{
							this.txtInput_NewTaxState.Text = dataTable.Rows[num]["st"].ToString();
							this.txtInput_NewTaxCounty.Text = dataTable.Rows[num]["county"].ToString();
							this.txt_TaxDateVerified.Text = dataTable.Rows[num]["dt_verified"].ToString();
							this.lblTaxCounty.Text = string.Concat(this.lblTaxCounty.Text, dataTable.Rows[num]["county"].ToString());
							this.txtInput_TaxAuthType.Text = dataTable.Rows[num]["tax_auth_type"].ToString();
							this.txtInput_TaxAuthName.Text = dataTable.Rows[num]["tax_auth"].ToString();
							this.txtInput_TaxPayeeName.Text = dataTable.Rows[num]["payee"].ToString();
							this.txtInput_TaxPayeeStr1.Text = dataTable.Rows[num]["street1"].ToString();
							this.txtInput_LocalTaxURL.Text = dataTable.Rows[num]["locTx_url"].ToString();
							this.txtInput_TaxPayeeStr2.Text = dataTable.Rows[num]["street2"].ToString();
							this.txtInput_TaxPayeeCity.Text = dataTable.Rows[num]["city"].ToString();
							this.txtInput_TaxPayeeState.Text = dataTable.Rows[num]["tx_st"].ToString();
							this.txtInput_TaxPayeeZip.Text = dataTable.Rows[num]["zip"].ToString();
							this.txtInput_TaxPayeePhone.Text = dataTable.Rows[num]["phone"].ToString();
							this.txtInput_TaxPayeeFax.Text = dataTable.Rows[num]["fax"].ToString();
							this.txtInput_TaxOfficeHours.Text = dataTable.Rows[num]["hours"].ToString();
							this.txtInput_TaxCertFee.Text = dataTable.Rows[num]["cert_fee"].ToString();
							this.txtInput_TaxCertTAT.Text = dataTable.Rows[num]["tat"].ToString();
							this.txtInput_TaxDueDates.Text = dataTable.Rows[num]["due_dates"].ToString();
							this.txtInput_TaxComments.Text = dataTable.Rows[num]["notes"].ToString();
							this.txt_TaxDateVerified.Text = dataTable.Rows[num]["dt_verified"].ToString();
							this.cboxInput_TaxBillingCycle.Text = dataTable.Rows[num]["cycle"].ToString();
							if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[num]["cert_req"].ToString(), "Y", false) == 0)
							{
								this.chkbxTaxCertRequired.Checked = true;
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataTable.Rows[num]["cert_req"].ToString(), "N", false) == 0)
							{
								this.chkbxTaxCertRequired.Checked = false;
							}
							else if (dataTable.Rows[num]["cert_req"].ToString() != null)
							{
								this.chkbxTaxCertRequired.Checked = false;
							}
						}
						num = checked(num + 1);
					}
				}
				this.orbStats = new Statutes_Lookup(text);
				this.dt.Clear();
				this.cmd.CommandType = CommandType.TableDirect;
				this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
				this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
				this.cmd.Connection = new OleDbConnection(this.dsn);
				this.da.SelectCommand = this.cmd;
				this.cmdBuilder.DataAdapter = this.da;
				this.da.Fill(this.dt);
				this.da.Dispose();
				this.c = 0;
				while (this.c <= checked(this.dt.Rows.Count - 1))
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["st"].ToString(), text, false) == 0)
					{
						this.txtInput_SOL_MtgRD.Text = this.orbStats.SOL_MtgRD;
						this.txtInput_SOL_MtgAM.Text = this.orbStats.SOL_MtgAM;
						this.txtInput_SOL_HelocAM.Text = this.orbStats.SOL_HelocAM;
						this.txtInput_SOL_HelocRD.Text = this.orbStats.SOL_HelocRD;
						this.txtInput_SOL_MechLiens.Text = this.orbStats.SOL_Mech;
						this.txtInput_SOL_Notice.Text = this.orbStats.SOL_Notice;
						this.txtInput_SOL_LisPendens.Text = this.orbStats.SOL_lispen;
						this.txtInput_SOL_HOALien.Text = this.orbStats.SOL_HOA;
						this.txtInput_SOL_HospLien.Text = this.orbStats.SOL_Hosp;
						this.txtInput_SOL_ClaimOfLien.Text = this.orbStats.SOL_ClaimLien;
						this.txtInput_SOL_Jgmt.Text = this.orbStats.SOL_Jgmt;
						this.txtInput_SOL_SupportObl.Text = this.orbStats.SOL_Support;
						this.txtInput_SOL_StateJgmt.Text = this.orbStats.SOL_StateJgmt;
						this.txtInput_SOL_AfterAcquired.Text = this.orbStats.SOL_AftAcq;
						this.txtInput_SOL_TE_Rule.Text = this.orbStats.SOL_TERule;
						this.txtInput_SOL_CreditorClaims.Text = this.orbStats.SOL_Creditor_Claims;
						this.txtInput_SOL_PersonalTax.Text = this.orbStats.SOL_PersTax;
						this.txtInput_SOL_ForeclosureRedem.Text = this.orbStats.SOL_Foreclosure_RedemPer;
						this.txtInput_SOL_TaxTakingRedem.Text = this.orbStats.SOL_Tax_RedemPer;
						this.txtInput_SOL_SpousalState.Text = this.orbStats.SOL_Spousal;
						this.txtSOL_notes.Text = this.orbStats.SOL_notes;
						this.c = checked(this.dt.Rows.Count + this.c);
					}
					this.c = checked(this.c + 1);
				}
			}
			this.dt.Clear();
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm7, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.dt);
			this.da.Dispose();
			this.c = 0;
			while (this.c <= checked(this.dt.Rows.Count - 1))
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["st"].ToString(), text, false) == 0)
				{
					this.txtInput_Sec_of_State_url.Text = this.dt.Rows[this.c]["sec_state_url"].ToString();
					this.txtInput_DOIurl.Text = this.dt.Rows[this.c]["dept_ins_url"].ToString();
					this.txtInput_State_CodeURL.Text = this.dt.Rows[this.c]["state_code_url"].ToString();
					this.txtInput_AttyNotes.Text = this.dt.Rows[this.c]["atty_notes"].ToString();
					this.txtInput_HomesteadNotes.Text = this.dt.Rows[this.c]["homestead_notes"].ToString();
					this.txtInput_DeedNotes.Text = this.dt.Rows[this.c]["deed_notes"].ToString();
					this.txtInput_PolicyNotes.Text = this.dt.Rows[this.c]["policy_notes"].ToString();
					this.txtInput_ForeclosureNotes.Text = this.dt.Rows[this.c]["foreclosure_notes"].ToString();
					this.txtInput_ProbateNotes.Text = this.dt.Rows[this.c]["probate_notes"].ToString();
					this.txtInput_NotaryURL.Text = this.dt.Rows[this.c]["notary_url"].ToString();
					this.cbox_DeedPrep.Text = this.dt.Rows[this.c]["deed_prep"].ToString();
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["atty_search"].ToString(), "YES", false) == 0)
					{
						this.ckbx_AttyTitleSearch.Checked = true;
					}
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["atty_close"].ToString(), "YES", false) == 0)
					{
						this.ckbx_AttyCloser.Checked = true;
					}
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["being_clause"].ToString(), "YES", false) == 0)
					{
						this.ckbx_BeingClause.Checked = true;
					}
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[this.c]["homestead"].ToString(), "YES", false) == 0)
					{
						this.ckbx_Homestead.Checked = true;
					}
					this.c = checked(this.dt.Rows.Count + this.c);
				}
				this.c = checked(this.c + 1);
			}
		}

		private void cboxCounty_EditORB_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.dt);
			this.da.Dispose();
			this.cboxTaxAuth_EditORB.Items.Clear();
			this.cboxTaxAuth_EditORB.ResetText();
			this.cboxTaxAuthType_EditORB.Items.Clear();
			this.cboxTaxAuthType_EditORB.ResetText();
			this.lblTaxCounty.ResetText();
			this.resetInputs();
			short num = 0;
			bool flag = false;
			while (this.i < this.dt.Rows.Count)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxState_EditORB.Text.ToString(), this.dt.Rows[this.i]["st"].ToString(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxCounty_EditORB.Text.ToString(), this.dt.Rows[this.i]["county"].ToString(), false) == 0)
				{
					this.cboxTaxAuth_EditORB.Items.Add("choose");
					num = 0;
					flag = false;
					while (num < this.cboxTaxAuth_EditORB.Items.Count)
					{
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboxTaxAuth_EditORB.Items[num].ToString(), this.dt.Rows[this.i]["tax_auth"].ToString(), false) == 0)
						{
							flag = true;
						}
						num = checked((short)(checked(num + 1)));
					}
					if (!flag)
					{
						this.cboxTaxAuth_EditORB.Items.Add(this.dt.Rows[this.i]["tax_auth"].ToString());
					}
				}
				this.i = checked(this.i + 1);
			}
			if (this.cboxTaxAuth_EditORB.Items.Contains(""))
			{
				this.cboxTaxAuth_EditORB.Items.Remove("");
			}
		}

		private void cboxState_EditORB_TextChanged(object sender, EventArgs e)
		{
			string text = this.cboxState_EditORB.Text;
			if (text.Length >= 2)
			{
				this.cboxCounty_EditORB.ResetText();
				this.cboxCounty_EditORB.Items.Clear();
				this.cboxTaxAuth_EditORB.ResetText();
				this.cboxTaxAuth_EditORB.Items.Clear();
				this.cboxTaxAuthType_EditORB.ResetText();
				this.cboxTaxAuthType_EditORB.Items.Clear();
				this.lblTaxCounty.ResetText();
				this.resetInputs();
				for (int i = 0; i < this.dt0.Rows.Count; i = checked(i + 1))
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt0.Rows[i]["st"].ToString(), text, false) == 0)
					{
						this.cboxCounty_EditORB.Items.Add(this.dt0.Rows[i]["county"].ToString());
					}
				}
			}
		}

		private void cboxTaxAuth_EditORB_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm2, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.dt);
			this.da.Dispose();
			this.lblTaxCounty.ResetText();
			this.resetInputs();
			this.cboxTaxAuthType_EditORB.ResetText();
			this.cboxTaxAuthType_EditORB.Items.Clear();
			for (int i = 0; i < this.dt.Rows.Count; i = checked(i + 1))
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[i]["st"].ToString(), this.cboxState_EditORB.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[i]["county"].ToString(), this.cboxCounty_EditORB.Text, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dt.Rows[i]["tax_auth"].ToString(), this.cboxTaxAuth_EditORB.Text, false) == 0)
				{
					if (!this.cboxTaxAuthType_EditORB.Items.Contains(this.dt.Rows[i]["tax_auth_type"].ToString()))
					{
						this.cboxTaxAuthType_EditORB.Items.Add(this.dt.Rows[i]["tax_auth_type"].ToString());
					}
				}
			}
		}

		private string ColHeads(string head, string shet, string[,] headers)
		{
			string str = "";
			short num = 1;
			long num1 = (long)1;
			while (num <= 7)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(headers[num, 0], shet, false) == 0)
				{
					while (num1 <= (long)70)
					{
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(headers[num, checked((int)num1)], head, false) == 0)
						{
							str = headers[0, checked((int)num1)];
							num1 = checked(num1 + (long)70);
							num = checked((short)(checked(num + 7)));
						}
						num1 = checked(num1 + (long)1);
					}
				}
				num = checked((short)(checked(num + 1)));
			}
			return str;
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

		private void frm_Edit_Load(object sender, EventArgs e)
		{
			this.cmd.CommandType = CommandType.TableDirect;
			this.dsn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", this.Import_File, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			this.cmd.CommandText = string.Concat("Select * From [", this.sheetNm1, "$]");
			this.cmd.Connection = new OleDbConnection(this.dsn);
			this.da.SelectCommand = this.cmd;
			this.cmdBuilder.DataAdapter = this.da;
			this.da.Fill(this.dt0);
			this.da.Dispose();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frm_Edit));
			this.cboxCounty_EditORB = new ComboBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cboxState_EditORB = new ComboBox();
			this.Button_SAVE = new System.Windows.Forms.Button();
			this.Button_EXITupdates = new System.Windows.Forms.Button();
			this.Button_SEARCH = new System.Windows.Forms.Button();
			this.Label25 = new System.Windows.Forms.Label();
			this.cboxTaxAuth_EditORB = new ComboBox();
			this.Label27 = new System.Windows.Forms.Label();
			this.cboxTaxAuthType_EditORB = new ComboBox();
			this.Label29 = new System.Windows.Forms.Label();
			this.Button_Reset = new System.Windows.Forms.Button();
			this.Button_ExitApp = new System.Windows.Forms.Button();
			this.TabPage07 = new TabPage();
			this.txtInput_SOL_Vesting = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_SupportObl = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_PersonalTax = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_StateJgmt = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_HospLien = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_SpousalState = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_HelocRD = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_MtgRD = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_AfterAcquired = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_TE_Rule = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_ForeclosureRedem = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_TaxTakingRedem = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_HOALien = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_CreditorClaims = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_Jgmt = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_ClaimOfLien = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_Notice = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_MechLiens = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_LisPendens = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_HelocAM = new System.Windows.Forms.TextBox();
			this.txtInput_SOL_MtgAM = new System.Windows.Forms.TextBox();
			this.txtSOL_notes = new System.Windows.Forms.TextBox();
			this.Label96 = new System.Windows.Forms.Label();
			this.Label31 = new System.Windows.Forms.Label();
			this.Label32 = new System.Windows.Forms.Label();
			this.Label73 = new System.Windows.Forms.Label();
			this.Label75 = new System.Windows.Forms.Label();
			this.Label82 = new System.Windows.Forms.Label();
			this.Label90 = new System.Windows.Forms.Label();
			this.Label91 = new System.Windows.Forms.Label();
			this.Label30 = new System.Windows.Forms.Label();
			this.Label77 = new System.Windows.Forms.Label();
			this.Label76 = new System.Windows.Forms.Label();
			this.Label74 = new System.Windows.Forms.Label();
			this.Label79 = new System.Windows.Forms.Label();
			this.Label81 = new System.Windows.Forms.Label();
			this.Label83 = new System.Windows.Forms.Label();
			this.Label85 = new System.Windows.Forms.Label();
			this.Label87 = new System.Windows.Forms.Label();
			this.Label88 = new System.Windows.Forms.Label();
			this.Label89 = new System.Windows.Forms.Label();
			this.Label92 = new System.Windows.Forms.Label();
			this.Label93 = new System.Windows.Forms.Label();
			this.Label94 = new System.Windows.Forms.Label();
			this.TabPage03 = new TabPage();
			this.Label41 = new System.Windows.Forms.Label();
			this.txtInput_DelinqTaxURL = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label35 = new System.Windows.Forms.Label();
			this.txt_TaxDateVerified = new System.Windows.Forms.TextBox();
			this.txtInput_TaxCertTAT = new System.Windows.Forms.TextBox();
			this.txtInput_LocalTaxURL = new System.Windows.Forms.TextBox();
			this.txtInput_NewTaxState = new System.Windows.Forms.TextBox();
			this.txtInput_NewTaxCounty = new System.Windows.Forms.TextBox();
			this.txtInput_TaxCertFee = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeeState = new System.Windows.Forms.TextBox();
			this.txtInput_TaxOfficeHours = new System.Windows.Forms.TextBox();
			this.txtInput_TaxDueDates = new System.Windows.Forms.TextBox();
			this.txtInput_TaxComments = new System.Windows.Forms.TextBox();
			this.txtInput_TaxAuthName = new System.Windows.Forms.TextBox();
			this.txtInput_TaxAuthType = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeePhone = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeeZip = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeeFax = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeeCity = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeeStr2 = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeeStr1 = new System.Windows.Forms.TextBox();
			this.txtInput_TaxPayeeName = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label26 = new System.Windows.Forms.Label();
			this.lblNewState = new System.Windows.Forms.Label();
			this.lblTaxCounty = new System.Windows.Forms.Label();
			this.Label28 = new System.Windows.Forms.Label();
			this.chkbxTaxCertRequired = new System.Windows.Forms.CheckBox();
			this.Button_NEW = new System.Windows.Forms.Button();
			this.cboxInput_TaxBillingCycle = new ComboBox();
			this.Label57 = new System.Windows.Forms.Label();
			this.Label59 = new System.Windows.Forms.Label();
			this.Label60 = new System.Windows.Forms.Label();
			this.Label54 = new System.Windows.Forms.Label();
			this.Label53 = new System.Windows.Forms.Label();
			this.Label51 = new System.Windows.Forms.Label();
			this.Label44 = new System.Windows.Forms.Label();
			this.Label45 = new System.Windows.Forms.Label();
			this.Label46 = new System.Windows.Forms.Label();
			this.Label47 = new System.Windows.Forms.Label();
			this.Label48 = new System.Windows.Forms.Label();
			this.Label49 = new System.Windows.Forms.Label();
			this.Label50 = new System.Windows.Forms.Label();
			this.TabPage01 = new TabPage();
			this.txtInput_NotaryURL = new System.Windows.Forms.TextBox();
			this.Label67 = new System.Windows.Forms.Label();
			this.txtInput_State_CodeURL = new System.Windows.Forms.TextBox();
			this.txtInput_Sec_of_State_url = new System.Windows.Forms.TextBox();
			this.txtInput_DOIurl = new System.Windows.Forms.TextBox();
			this.Label56 = new System.Windows.Forms.Label();
			this.Label62 = new System.Windows.Forms.Label();
			this.Label63 = new System.Windows.Forms.Label();
			this.ckbxLoginRequired = new System.Windows.Forms.CheckBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.txtInput_UCC_url = new System.Windows.Forms.TextBox();
			this.txtInput_OtherURLPwd = new System.Windows.Forms.TextBox();
			this.txtInput_OtherURLUsername = new System.Windows.Forms.TextBox();
			this.txtInput_ProbatePwd = new System.Windows.Forms.TextBox();
			this.txtInput_ProbateUsername = new System.Windows.Forms.TextBox();
			this.txtInput_ProthonPwd = new System.Windows.Forms.TextBox();
			this.txtInput_ProthonUsername = new System.Windows.Forms.TextBox();
			this.txtInput_AssessorPwd = new System.Windows.Forms.TextBox();
			this.txtInput_AssessorUsername = new System.Windows.Forms.TextBox();
			this.txtInput_TaxLocalPwd = new System.Windows.Forms.TextBox();
			this.txtInput_TaxLocalUsername = new System.Windows.Forms.TextBox();
			this.txtInput_TaxCountyPwd = new System.Windows.Forms.TextBox();
			this.txtInput_TaxCountyUsername = new System.Windows.Forms.TextBox();
			this.txtInput_MuniCtPwd = new System.Windows.Forms.TextBox();
			this.txtInput_MuniCtUsername = new System.Windows.Forms.TextBox();
			this.txtInput_CivCtPwd = new System.Windows.Forms.TextBox();
			this.txtInput_CivCtUsername = new System.Windows.Forms.TextBox();
			this.txtInput_LandPwd = new System.Windows.Forms.TextBox();
			this.txtInput_LandUsername = new System.Windows.Forms.TextBox();
			this.txtInput_OtherURL = new System.Windows.Forms.TextBox();
			this.txtInput_CountyHomeURL = new System.Windows.Forms.TextBox();
			this.txtInput_ForeclosureURL = new System.Windows.Forms.TextBox();
			this.txtInput_SheriffURL = new System.Windows.Forms.TextBox();
			this.txtInput_ProbateURL = new System.Windows.Forms.TextBox();
			this.txtInput_ProthonURL = new System.Windows.Forms.TextBox();
			this.txtInput_MapURL = new System.Windows.Forms.TextBox();
			this.txtInput_PlatsURL = new System.Windows.Forms.TextBox();
			this.txtInput_AssessorURL = new System.Windows.Forms.TextBox();
			this.txtInput_Tax2URL = new System.Windows.Forms.TextBox();
			this.txtInput_TaxCountyURL = new System.Windows.Forms.TextBox();
			this.txtInput_MuniCtURL = new System.Windows.Forms.TextBox();
			this.txtInput_CivCtIndexURL = new System.Windows.Forms.TextBox();
			this.txtInput_LandIndexURL = new System.Windows.Forms.TextBox();
			this.Label55 = new System.Windows.Forms.Label();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.TabPage05 = new TabPage();
			this.Label40 = new System.Windows.Forms.Label();
			this.Label39 = new System.Windows.Forms.Label();
			this.txtInput_PlatImageDate = new System.Windows.Forms.TextBox();
			this.txtInput_MuniCourtImageDate = new System.Windows.Forms.TextBox();
			this.txtInput_CivCourtImageDate = new System.Windows.Forms.TextBox();
			this.txtInput_LandImageDate = new System.Windows.Forms.TextBox();
			this.txtInput_PlatIndexDate = new System.Windows.Forms.TextBox();
			this.txtInput_MuniCourtIndexDate = new System.Windows.Forms.TextBox();
			this.txtInput_CivCourtIndexDate = new System.Windows.Forms.TextBox();
			this.txtInput_LandIndexDate = new System.Windows.Forms.TextBox();
			this.Label34 = new System.Windows.Forms.Label();
			this.Label36 = new System.Windows.Forms.Label();
			this.Label37 = new System.Windows.Forms.Label();
			this.Label38 = new System.Windows.Forms.Label();
			this.ckbxProdTaxReports = new System.Windows.Forms.CheckBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.ckbxProdDocRet = new System.Windows.Forms.CheckBox();
			this.ckbxProdIns = new System.Windows.Forms.CheckBox();
			this.ckbxProdPropReports = new System.Windows.Forms.CheckBox();
			this.TabPage06 = new TabPage();
			this.txtInput_Copy_Pmt_Method = new System.Windows.Forms.TextBox();
			this.txtInput_Index_Pmt_Method = new System.Windows.Forms.TextBox();
			this.txtInput_SubscripTerm = new System.Windows.Forms.TextBox();
			this.txtInput_CopySource = new System.Windows.Forms.TextBox();
			this.txtInput_LandIndexSource = new System.Windows.Forms.TextBox();
			this.txtInput_SubscripFeeAmt = new System.Windows.Forms.TextBox();
			this.txtCopyFeeAmount = new System.Windows.Forms.TextBox();
			this.txtInput_Comments = new System.Windows.Forms.TextBox();
			this.label61 = new System.Windows.Forms.Label();
			this.ckbxSubscripIsFree = new System.Windows.Forms.CheckBox();
			this.ckbxWeAreSubscribed = new System.Windows.Forms.CheckBox();
			this.ckbxSubscripNeeded = new System.Windows.Forms.CheckBox();
			this.Label43 = new System.Windows.Forms.Label();
			this.Label42 = new System.Windows.Forms.Label();
			this.Label84 = new System.Windows.Forms.Label();
			this.Label80 = new System.Windows.Forms.Label();
			this.Label78 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.ckbxUseTapestry = new System.Windows.Forms.CheckBox();
			this.ckbxUseDatatree = new System.Windows.Forms.CheckBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.ckbxUseRedVision = new System.Windows.Forms.CheckBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TabControl1 = new TabControl();
			this.TabPage1 = new TabPage();
			this.ckbx_Homestead = new System.Windows.Forms.CheckBox();
			this.cbox_DeedPrep = new ComboBox();
			this.Label52 = new System.Windows.Forms.Label();
			this.Label69 = new System.Windows.Forms.Label();
			this.txtInput_AttyNotes = new System.Windows.Forms.TextBox();
			this.Label68 = new System.Windows.Forms.Label();
			this.txtInput_PolicyNotes = new System.Windows.Forms.TextBox();
			this.ckbx_AttyCloser = new System.Windows.Forms.CheckBox();
			this.ckbx_AttyTitleSearch = new System.Windows.Forms.CheckBox();
			this.ckbx_BeingClause = new System.Windows.Forms.CheckBox();
			this.Label66 = new System.Windows.Forms.Label();
			this.txtInput_DeedNotes = new System.Windows.Forms.TextBox();
			this.Label65 = new System.Windows.Forms.Label();
			this.txtInput_HomesteadNotes = new System.Windows.Forms.TextBox();
			this.Label64 = new System.Windows.Forms.Label();
			this.txtInput_ForeclosureNotes = new System.Windows.Forms.TextBox();
			this.Label58 = new System.Windows.Forms.Label();
			this.txtInput_ProbateNotes = new System.Windows.Forms.TextBox();
			this.lblOpenORB = new System.Windows.Forms.Label();
			this.pboxOpenORB = new PictureBox();
			this.ToolTip1 = new ToolTip(this.components);
			this.TabPage07.SuspendLayout();
			this.TabPage03.SuspendLayout();
			this.TabPage01.SuspendLayout();
			this.TabPage05.SuspendLayout();
			this.TabPage06.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((ISupportInitialize)this.pboxOpenORB).BeginInit();
			this.SuspendLayout();
			this.cboxCounty_EditORB.DropDownHeight = 60;
			this.cboxCounty_EditORB.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboxCounty_EditORB.ForeColor = Color.Indigo;
			this.cboxCounty_EditORB.FormattingEnabled = true;
			this.cboxCounty_EditORB.IntegralHeight = false;
			ComboBox cboxCountyEditORB = this.cboxCounty_EditORB;
			System.Drawing.Point .Location = new System.Drawing.Point(5, 86);
			cboxCountyEditORB.Location = .Location;
			this.cboxCounty_EditORB.Name = "cboxCounty_EditORB";
			ComboBox comboBox = this.cboxCounty_EditORB;
			System.Drawing.Size .Size = new System.Drawing.Size(157, 21);
			comboBox.Size = .Size;
			this.cboxCounty_EditORB.TabIndex = 2;
			this.Label12.AutoSize = true;
			System.Windows.Forms.Label label12 = this.Label12;
			.Location = new System.Drawing.Point(5, 73);
			label12.Location = .Location;
			this.Label12.Name = "Label12";
			System.Windows.Forms.Label label = this.Label12;
			.Size = new System.Drawing.Size(92, 13);
			label.Size = .Size;
			this.Label12.TabIndex = 27;
			this.Label12.Text = "Choose A County:";
			this.Label1.AutoSize = true;
			System.Windows.Forms.Label label1 = this.Label1;
			.Location = new System.Drawing.Point(5, 33);
			label1.Location = .Location;
			this.Label1.Name = "Label1";
			System.Windows.Forms.Label label11 = this.Label1;
			.Size = new System.Drawing.Size(84, 13);
			label11.Size = .Size;
			this.Label1.TabIndex = 31;
			this.Label1.Text = "Choose A State:";
			this.cboxState_EditORB.DropDownHeight = 60;
			this.cboxState_EditORB.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboxState_EditORB.ForeColor = Color.Indigo;
			this.cboxState_EditORB.FormattingEnabled = true;
			this.cboxState_EditORB.IntegralHeight = false;
			this.cboxState_EditORB.ItemHeight = 13;
			ComboBox.ObjectCollection items = this.cboxState_EditORB.Items;
			object[] objArray = new object[] { "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" };
			items.AddRange(objArray);
			ComboBox cboxStateEditORB = this.cboxState_EditORB;
			.Location = new System.Drawing.Point(5, 49);
			cboxStateEditORB.Location = .Location;
			this.cboxState_EditORB.Name = "cboxState_EditORB";
			ComboBox cboxStateEditORB1 = this.cboxState_EditORB;
			.Size = new System.Drawing.Size(62, 21);
			cboxStateEditORB1.Size = .Size;
			this.cboxState_EditORB.TabIndex = 1;
			this.Button_SAVE.BackColor = Color.FromArgb(220, 185, 255);
			this.Button_SAVE.FlatAppearance.BorderColor = Color.Purple;
			this.Button_SAVE.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_SAVE.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_SAVE.FlatStyle = FlatStyle.Flat;
			this.Button_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Pixel);
			this.Button_SAVE.ForeColor = Color.Indigo;
			System.Windows.Forms.Button buttonSAVE = this.Button_SAVE;
			.Location = new System.Drawing.Point(41, 241);
			buttonSAVE.Location = .Location;
			this.Button_SAVE.Name = "Button_SAVE";
			System.Windows.Forms.Button button = this.Button_SAVE;
			.Size = new System.Drawing.Size(78, 36);
			button.Size = .Size;
			this.Button_SAVE.TabIndex = 7;
			this.Button_SAVE.Text = "SAVE CHANGES";
			this.Button_SAVE.UseVisualStyleBackColor = false;
			this.Button_EXITupdates.BackColor = Color.FromArgb(220, 185, 255);
			this.Button_EXITupdates.FlatAppearance.BorderColor = Color.Purple;
			this.Button_EXITupdates.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_EXITupdates.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_EXITupdates.FlatStyle = FlatStyle.Flat;
			this.Button_EXITupdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Pixel);
			this.Button_EXITupdates.ForeColor = Color.Indigo;
			System.Windows.Forms.Button buttonEXITupdates = this.Button_EXITupdates;
			.Location = new System.Drawing.Point(41, 283);
			buttonEXITupdates.Location = .Location;
			this.Button_EXITupdates.Name = "Button_EXITupdates";
			System.Windows.Forms.Button buttonEXITupdates1 = this.Button_EXITupdates;
			.Size = new System.Drawing.Size(78, 36);
			buttonEXITupdates1.Size = .Size;
			this.Button_EXITupdates.TabIndex = 8;
			this.Button_EXITupdates.Text = "Return to ORB";
			this.Button_EXITupdates.UseVisualStyleBackColor = false;
			this.Button_SEARCH.BackColor = Color.FromArgb(220, 185, 255);
			this.Button_SEARCH.FlatAppearance.BorderColor = Color.Purple;
			this.Button_SEARCH.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_SEARCH.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_SEARCH.FlatStyle = FlatStyle.Flat;
			this.Button_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Pixel);
			this.Button_SEARCH.ForeColor = Color.Indigo;
			System.Windows.Forms.Button buttonSEARCH = this.Button_SEARCH;
			.Location = new System.Drawing.Point(6, 194);
			buttonSEARCH.Location = .Location;
			this.Button_SEARCH.Name = "Button_SEARCH";
			System.Windows.Forms.Button buttonSEARCH1 = this.Button_SEARCH;
			.Size = new System.Drawing.Size(71, 36);
			buttonSEARCH1.Size = .Size;
			this.Button_SEARCH.TabIndex = 5;
			this.Button_SEARCH.Text = "SEARCH";
			this.Button_SEARCH.UseVisualStyleBackColor = false;
			this.Label25.AutoSize = true;
			System.Windows.Forms.Label label25 = this.Label25;
			.Location = new System.Drawing.Point(5, 110);
			label25.Location = .Location;
			this.Label25.Name = "Label25";
			System.Windows.Forms.Label label251 = this.Label25;
			.Size = new System.Drawing.Size(114, 13);
			label251.Size = .Size;
			this.Label25.TabIndex = 61;
			this.Label25.Text = "Choose Tax Authority :";
			this.cboxTaxAuth_EditORB.DropDownHeight = 60;
			this.cboxTaxAuth_EditORB.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboxTaxAuth_EditORB.ForeColor = Color.Indigo;
			this.cboxTaxAuth_EditORB.FormattingEnabled = true;
			this.cboxTaxAuth_EditORB.IntegralHeight = false;
			ComboBox cboxTaxAuthEditORB = this.cboxTaxAuth_EditORB;
			.Location = new System.Drawing.Point(4, 126);
			cboxTaxAuthEditORB.Location = .Location;
			this.cboxTaxAuth_EditORB.Name = "cboxTaxAuth_EditORB";
			ComboBox cboxTaxAuthEditORB1 = this.cboxTaxAuth_EditORB;
			.Size = new System.Drawing.Size(158, 21);
			cboxTaxAuthEditORB1.Size = .Size;
			this.cboxTaxAuth_EditORB.TabIndex = 3;
			this.Label27.AutoSize = true;
			this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label27 = this.Label27;
			.Location = new System.Drawing.Point(11, 9);
			label27.Location = .Location;
			this.Label27.Name = "Label27";
			System.Windows.Forms.Label label271 = this.Label27;
			.Size = new System.Drawing.Size(141, 13);
			label271.Size = .Size;
			this.Label27.TabIndex = 65;
			this.Label27.Text = "UPDATE RESOURCES:";
			this.cboxTaxAuthType_EditORB.DropDownHeight = 300;
			this.cboxTaxAuthType_EditORB.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cboxTaxAuthType_EditORB.ForeColor = Color.Indigo;
			this.cboxTaxAuthType_EditORB.FormattingEnabled = true;
			this.cboxTaxAuthType_EditORB.IntegralHeight = false;
			ComboBox cboxTaxAuthTypeEditORB = this.cboxTaxAuthType_EditORB;
			.Location = new System.Drawing.Point(5, 166);
			cboxTaxAuthTypeEditORB.Location = .Location;
			this.cboxTaxAuthType_EditORB.Name = "cboxTaxAuthType_EditORB";
			ComboBox cboxTaxAuthTypeEditORB1 = this.cboxTaxAuthType_EditORB;
			.Size = new System.Drawing.Size(158, 21);
			cboxTaxAuthTypeEditORB1.Size = .Size;
			this.cboxTaxAuthType_EditORB.TabIndex = 4;
			this.Label29.AutoSize = true;
			System.Windows.Forms.Label label29 = this.Label29;
			.Location = new System.Drawing.Point(6, 150);
			label29.Location = .Location;
			this.Label29.Name = "Label29";
			System.Windows.Forms.Label label291 = this.Label29;
			.Size = new System.Drawing.Size(131, 13);
			label291.Size = .Size;
			this.Label29.TabIndex = 97;
			this.Label29.Text = "Choose the TaxAuth Type";
			this.Button_Reset.BackColor = Color.FromArgb(220, 185, 255);
			this.Button_Reset.FlatAppearance.BorderColor = Color.Purple;
			this.Button_Reset.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_Reset.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_Reset.FlatStyle = FlatStyle.Flat;
			this.Button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Pixel);
			this.Button_Reset.ForeColor = Color.Indigo;
			System.Windows.Forms.Button buttonReset = this.Button_Reset;
			.Location = new System.Drawing.Point(83, 194);
			buttonReset.Location = .Location;
			this.Button_Reset.Name = "Button_Reset";
			System.Windows.Forms.Button buttonReset1 = this.Button_Reset;
			.Size = new System.Drawing.Size(79, 36);
			buttonReset1.Size = .Size;
			this.Button_Reset.TabIndex = 6;
			this.Button_Reset.Text = "RESET INPUTS";
			this.Button_Reset.UseVisualStyleBackColor = false;
			this.Button_ExitApp.BackColor = Color.FromArgb(220, 185, 255);
			this.Button_ExitApp.FlatAppearance.BorderColor = Color.Purple;
			this.Button_ExitApp.FlatAppearance.MouseDownBackColor = Color.Magenta;
			this.Button_ExitApp.FlatAppearance.MouseOverBackColor = Color.Cyan;
			this.Button_ExitApp.FlatStyle = FlatStyle.Flat;
			this.Button_ExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Pixel);
			this.Button_ExitApp.ForeColor = Color.Indigo;
			System.Windows.Forms.Button buttonExitApp = this.Button_ExitApp;
			.Location = new System.Drawing.Point(41, 325);
			buttonExitApp.Location = .Location;
			this.Button_ExitApp.Name = "Button_ExitApp";
			System.Windows.Forms.Button buttonExitApp1 = this.Button_ExitApp;
			.Size = new System.Drawing.Size(78, 36);
			buttonExitApp1.Size = .Size;
			this.Button_ExitApp.TabIndex = 9;
			this.Button_ExitApp.Text = "QUIT ORB";
			this.Button_ExitApp.UseVisualStyleBackColor = false;
			this.TabPage07.AutoScroll = true;
			this.TabPage07.BackColor = Color.AliceBlue;
			this.TabPage07.Controls.Add(this.txtInput_SOL_Vesting);
			this.TabPage07.Controls.Add(this.txtInput_SOL_SupportObl);
			this.TabPage07.Controls.Add(this.txtInput_SOL_PersonalTax);
			this.TabPage07.Controls.Add(this.txtInput_SOL_StateJgmt);
			this.TabPage07.Controls.Add(this.txtInput_SOL_HospLien);
			this.TabPage07.Controls.Add(this.txtInput_SOL_SpousalState);
			this.TabPage07.Controls.Add(this.txtInput_SOL_HelocRD);
			this.TabPage07.Controls.Add(this.txtInput_SOL_MtgRD);
			this.TabPage07.Controls.Add(this.txtInput_SOL_AfterAcquired);
			this.TabPage07.Controls.Add(this.txtInput_SOL_TE_Rule);
			this.TabPage07.Controls.Add(this.txtInput_SOL_ForeclosureRedem);
			this.TabPage07.Controls.Add(this.txtInput_SOL_TaxTakingRedem);
			this.TabPage07.Controls.Add(this.txtInput_SOL_HOALien);
			this.TabPage07.Controls.Add(this.txtInput_SOL_CreditorClaims);
			this.TabPage07.Controls.Add(this.txtInput_SOL_Jgmt);
			this.TabPage07.Controls.Add(this.txtInput_SOL_ClaimOfLien);
			this.TabPage07.Controls.Add(this.txtInput_SOL_Notice);
			this.TabPage07.Controls.Add(this.txtInput_SOL_MechLiens);
			this.TabPage07.Controls.Add(this.txtInput_SOL_LisPendens);
			this.TabPage07.Controls.Add(this.txtInput_SOL_HelocAM);
			this.TabPage07.Controls.Add(this.txtInput_SOL_MtgAM);
			this.TabPage07.Controls.Add(this.txtSOL_notes);
			this.TabPage07.Controls.Add(this.Label96);
			this.TabPage07.Controls.Add(this.Label31);
			this.TabPage07.Controls.Add(this.Label32);
			this.TabPage07.Controls.Add(this.Label73);
			this.TabPage07.Controls.Add(this.Label75);
			this.TabPage07.Controls.Add(this.Label82);
			this.TabPage07.Controls.Add(this.Label90);
			this.TabPage07.Controls.Add(this.Label91);
			this.TabPage07.Controls.Add(this.Label30);
			this.TabPage07.Controls.Add(this.Label77);
			this.TabPage07.Controls.Add(this.Label76);
			this.TabPage07.Controls.Add(this.Label74);
			this.TabPage07.Controls.Add(this.Label79);
			this.TabPage07.Controls.Add(this.Label81);
			this.TabPage07.Controls.Add(this.Label83);
			this.TabPage07.Controls.Add(this.Label85);
			this.TabPage07.Controls.Add(this.Label87);
			this.TabPage07.Controls.Add(this.Label88);
			this.TabPage07.Controls.Add(this.Label89);
			this.TabPage07.Controls.Add(this.Label92);
			this.TabPage07.Controls.Add(this.Label93);
			this.TabPage07.Controls.Add(this.Label94);
			TabPage tabPage07 = this.TabPage07;
			.Location = new System.Drawing.Point(4, 22);
			tabPage07.Location = .Location;
			this.TabPage07.Name = "TabPage07";
			TabPage tabPage = this.TabPage07;
			System.Windows.Forms.Padding .Padding = new System.Windows.Forms.Padding(3);
			tabPage.Padding = .Padding;
			TabPage tabPage071 = this.TabPage07;
			.Size = new System.Drawing.Size(594, 373);
			tabPage071.Size = .Size;
			this.TabPage07.TabIndex = 6;
			this.TabPage07.Text = "Statutes";
			System.Windows.Forms.TextBox txtInputSOLVesting = this.txtInput_SOL_Vesting;
			.Location = new System.Drawing.Point(363, 233);
			txtInputSOLVesting.Location = .Location;
			this.txtInput_SOL_Vesting.Name = "txtInput_SOL_Vesting";
			System.Windows.Forms.TextBox textBox = this.txtInput_SOL_Vesting;
			.Size = new System.Drawing.Size(212, 20);
			textBox.Size = .Size;
			this.txtInput_SOL_Vesting.TabIndex = 222;
			System.Windows.Forms.TextBox txtInputSOLSupportObl = this.txtInput_SOL_SupportObl;
			.Location = new System.Drawing.Point(363, 84);
			txtInputSOLSupportObl.Location = .Location;
			this.txtInput_SOL_SupportObl.Name = "txtInput_SOL_SupportObl";
			System.Windows.Forms.TextBox txtInputSOLSupportObl1 = this.txtInput_SOL_SupportObl;
			.Size = new System.Drawing.Size(97, 20);
			txtInputSOLSupportObl1.Size = .Size;
			this.txtInput_SOL_SupportObl.TabIndex = 213;
			System.Windows.Forms.TextBox txtInputSOLPersonalTax = this.txtInput_SOL_PersonalTax;
			.Location = new System.Drawing.Point(363, 61);
			txtInputSOLPersonalTax.Location = .Location;
			this.txtInput_SOL_PersonalTax.Name = "txtInput_SOL_PersonalTax";
			System.Windows.Forms.TextBox txtInputSOLPersonalTax1 = this.txtInput_SOL_PersonalTax;
			.Size = new System.Drawing.Size(97, 20);
			txtInputSOLPersonalTax1.Size = .Size;
			this.txtInput_SOL_PersonalTax.TabIndex = 212;
			System.Windows.Forms.TextBox txtInputSOLStateJgmt = this.txtInput_SOL_StateJgmt;
			.Location = new System.Drawing.Point(363, 38);
			txtInputSOLStateJgmt.Location = .Location;
			this.txtInput_SOL_StateJgmt.Name = "txtInput_SOL_StateJgmt";
			System.Windows.Forms.TextBox txtInputSOLStateJgmt1 = this.txtInput_SOL_StateJgmt;
			.Size = new System.Drawing.Size(97, 20);
			txtInputSOLStateJgmt1.Size = .Size;
			this.txtInput_SOL_StateJgmt.TabIndex = 211;
			System.Windows.Forms.TextBox txtInputSOLHospLien = this.txtInput_SOL_HospLien;
			.Location = new System.Drawing.Point(363, 134);
			txtInputSOLHospLien.Location = .Location;
			this.txtInput_SOL_HospLien.Name = "txtInput_SOL_HospLien";
			System.Windows.Forms.TextBox txtInputSOLHospLien1 = this.txtInput_SOL_HospLien;
			.Size = new System.Drawing.Size(97, 20);
			txtInputSOLHospLien1.Size = .Size;
			this.txtInput_SOL_HospLien.TabIndex = 215;
			System.Windows.Forms.TextBox txtInputSOLSpousalState = this.txtInput_SOL_SpousalState;
			.Location = new System.Drawing.Point(363, 107);
			txtInputSOLSpousalState.Location = .Location;
			this.txtInput_SOL_SpousalState.Name = "txtInput_SOL_SpousalState";
			System.Windows.Forms.TextBox txtInputSOLSpousalState1 = this.txtInput_SOL_SpousalState;
			.Size = new System.Drawing.Size(97, 20);
			txtInputSOLSpousalState1.Size = .Size;
			this.txtInput_SOL_SpousalState.TabIndex = 214;
			System.Windows.Forms.TextBox txtInputSOLHelocRD = this.txtInput_SOL_HelocRD;
			.Location = new System.Drawing.Point(176, 65);
			txtInputSOLHelocRD.Location = .Location;
			this.txtInput_SOL_HelocRD.Name = "txtInput_SOL_HelocRD";
			System.Windows.Forms.TextBox txtInputSOLHelocRD1 = this.txtInput_SOL_HelocRD;
			.Size = new System.Drawing.Size(48, 20);
			txtInputSOLHelocRD1.Size = .Size;
			this.txtInput_SOL_HelocRD.TabIndex = 203;
			System.Windows.Forms.TextBox txtInputSOLMtgRD = this.txtInput_SOL_MtgRD;
			.Location = new System.Drawing.Point(176, 41);
			txtInputSOLMtgRD.Location = .Location;
			this.txtInput_SOL_MtgRD.Name = "txtInput_SOL_MtgRD";
			System.Windows.Forms.TextBox txtInputSOLMtgRD1 = this.txtInput_SOL_MtgRD;
			.Size = new System.Drawing.Size(48, 20);
			txtInputSOLMtgRD1.Size = .Size;
			this.txtInput_SOL_MtgRD.TabIndex = 201;
			System.Windows.Forms.TextBox txtInputSOLAfterAcquired = this.txtInput_SOL_AfterAcquired;
			.Location = new System.Drawing.Point(363, 259);
			txtInputSOLAfterAcquired.Location = .Location;
			this.txtInput_SOL_AfterAcquired.Name = "txtInput_SOL_AfterAcquired";
			System.Windows.Forms.TextBox txtInputSOLAfterAcquired1 = this.txtInput_SOL_AfterAcquired;
			.Size = new System.Drawing.Size(212, 20);
			txtInputSOLAfterAcquired1.Size = .Size;
			this.txtInput_SOL_AfterAcquired.TabIndex = 219;
			System.Windows.Forms.TextBox txtInputSOLTERule = this.txtInput_SOL_TE_Rule;
			.Location = new System.Drawing.Point(363, 209);
			txtInputSOLTERule.Location = .Location;
			this.txtInput_SOL_TE_Rule.Name = "txtInput_SOL_TE_Rule";
			System.Windows.Forms.TextBox txtInputSOLTERule1 = this.txtInput_SOL_TE_Rule;
			.Size = new System.Drawing.Size(212, 20);
			txtInputSOLTERule1.Size = .Size;
			this.txtInput_SOL_TE_Rule.TabIndex = 218;
			System.Windows.Forms.TextBox txtInputSOLForeclosureRedem = this.txtInput_SOL_ForeclosureRedem;
			.Location = new System.Drawing.Point(363, 184);
			txtInputSOLForeclosureRedem.Location = .Location;
			this.txtInput_SOL_ForeclosureRedem.Name = "txtInput_SOL_ForeclosureRedem";
			System.Windows.Forms.TextBox txtInputSOLForeclosureRedem1 = this.txtInput_SOL_ForeclosureRedem;
			.Size = new System.Drawing.Size(212, 20);
			txtInputSOLForeclosureRedem1.Size = .Size;
			this.txtInput_SOL_ForeclosureRedem.TabIndex = 217;
			System.Windows.Forms.TextBox txtInputSOLTaxTakingRedem = this.txtInput_SOL_TaxTakingRedem;
			.Location = new System.Drawing.Point(363, 161);
			txtInputSOLTaxTakingRedem.Location = .Location;
			this.txtInput_SOL_TaxTakingRedem.Name = "txtInput_SOL_TaxTakingRedem";
			System.Windows.Forms.TextBox txtInputSOLTaxTakingRedem1 = this.txtInput_SOL_TaxTakingRedem;
			.Size = new System.Drawing.Size(212, 20);
			txtInputSOLTaxTakingRedem1.Size = .Size;
			this.txtInput_SOL_TaxTakingRedem.TabIndex = 216;
			System.Windows.Forms.TextBox txtInputSOLHOALien = this.txtInput_SOL_HOALien;
			.Location = new System.Drawing.Point(126, 233);
			txtInputSOLHOALien.Location = .Location;
			this.txtInput_SOL_HOALien.Name = "txtInput_SOL_HOALien";
			System.Windows.Forms.TextBox txtInputSOLHOALien1 = this.txtInput_SOL_HOALien;
			.Size = new System.Drawing.Size(98, 20);
			txtInputSOLHOALien1.Size = .Size;
			this.txtInput_SOL_HOALien.TabIndex = 210;
			System.Windows.Forms.TextBox txtInputSOLCreditorClaims = this.txtInput_SOL_CreditorClaims;
			.Location = new System.Drawing.Point(126, 209);
			txtInputSOLCreditorClaims.Location = .Location;
			this.txtInput_SOL_CreditorClaims.Name = "txtInput_SOL_CreditorClaims";
			System.Windows.Forms.TextBox txtInputSOLCreditorClaims1 = this.txtInput_SOL_CreditorClaims;
			.Size = new System.Drawing.Size(98, 20);
			txtInputSOLCreditorClaims1.Size = .Size;
			this.txtInput_SOL_CreditorClaims.TabIndex = 209;
			System.Windows.Forms.TextBox txtInputSOLJgmt = this.txtInput_SOL_Jgmt;
			.Location = new System.Drawing.Point(126, 185);
			txtInputSOLJgmt.Location = .Location;
			this.txtInput_SOL_Jgmt.Name = "txtInput_SOL_Jgmt";
			System.Windows.Forms.TextBox txtInputSOLJgmt1 = this.txtInput_SOL_Jgmt;
			.Size = new System.Drawing.Size(98, 20);
			txtInputSOLJgmt1.Size = .Size;
			this.txtInput_SOL_Jgmt.TabIndex = 208;
			System.Windows.Forms.TextBox txtInputSOLClaimOfLien = this.txtInput_SOL_ClaimOfLien;
			.Location = new System.Drawing.Point(126, 161);
			txtInputSOLClaimOfLien.Location = .Location;
			this.txtInput_SOL_ClaimOfLien.Name = "txtInput_SOL_ClaimOfLien";
			System.Windows.Forms.TextBox txtInputSOLClaimOfLien1 = this.txtInput_SOL_ClaimOfLien;
			.Size = new System.Drawing.Size(98, 20);
			txtInputSOLClaimOfLien1.Size = .Size;
			this.txtInput_SOL_ClaimOfLien.TabIndex = 207;
			System.Windows.Forms.TextBox txtInputSOLNotice = this.txtInput_SOL_Notice;
			.Location = new System.Drawing.Point(126, 137);
			txtInputSOLNotice.Location = .Location;
			this.txtInput_SOL_Notice.Name = "txtInput_SOL_Notice";
			System.Windows.Forms.TextBox txtInputSOLNotice1 = this.txtInput_SOL_Notice;
			.Size = new System.Drawing.Size(98, 20);
			txtInputSOLNotice1.Size = .Size;
			this.txtInput_SOL_Notice.TabIndex = 206;
			System.Windows.Forms.TextBox txtInputSOLMechLiens = this.txtInput_SOL_MechLiens;
			.Location = new System.Drawing.Point(126, 113);
			txtInputSOLMechLiens.Location = .Location;
			this.txtInput_SOL_MechLiens.Name = "txtInput_SOL_MechLiens";
			System.Windows.Forms.TextBox txtInputSOLMechLiens1 = this.txtInput_SOL_MechLiens;
			.Size = new System.Drawing.Size(98, 20);
			txtInputSOLMechLiens1.Size = .Size;
			this.txtInput_SOL_MechLiens.TabIndex = 205;
			System.Windows.Forms.TextBox txtInputSOLLisPendens = this.txtInput_SOL_LisPendens;
			.Location = new System.Drawing.Point(126, 89);
			txtInputSOLLisPendens.Location = .Location;
			this.txtInput_SOL_LisPendens.Name = "txtInput_SOL_LisPendens";
			System.Windows.Forms.TextBox txtInputSOLLisPendens1 = this.txtInput_SOL_LisPendens;
			.Size = new System.Drawing.Size(98, 20);
			txtInputSOLLisPendens1.Size = .Size;
			this.txtInput_SOL_LisPendens.TabIndex = 204;
			System.Windows.Forms.TextBox txtInputSOLHelocAM = this.txtInput_SOL_HelocAM;
			.Location = new System.Drawing.Point(94, 65);
			txtInputSOLHelocAM.Location = .Location;
			this.txtInput_SOL_HelocAM.Name = "txtInput_SOL_HelocAM";
			System.Windows.Forms.TextBox txtInputSOLHelocAM1 = this.txtInput_SOL_HelocAM;
			.Size = new System.Drawing.Size(48, 20);
			txtInputSOLHelocAM1.Size = .Size;
			this.txtInput_SOL_HelocAM.TabIndex = 202;
			System.Windows.Forms.TextBox txtInputSOLMtgAM = this.txtInput_SOL_MtgAM;
			.Location = new System.Drawing.Point(94, 41);
			txtInputSOLMtgAM.Location = .Location;
			this.txtInput_SOL_MtgAM.Name = "txtInput_SOL_MtgAM";
			System.Windows.Forms.TextBox txtInputSOLMtgAM1 = this.txtInput_SOL_MtgAM;
			.Size = new System.Drawing.Size(48, 20);
			txtInputSOLMtgAM1.Size = .Size;
			this.txtInput_SOL_MtgAM.TabIndex = 200;
			this.txtSOL_notes.BackColor = Color.Snow;
			this.txtSOL_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtSOL_notes.ForeColor = Color.Purple;
			System.Windows.Forms.TextBox txtSOLNotes = this.txtSOL_notes;
			.Location = new System.Drawing.Point(34, 297);
			txtSOLNotes.Location = .Location;
			this.txtSOL_notes.Multiline = true;
			this.txtSOL_notes.Name = "txtSOL_notes";
			this.txtSOL_notes.ReadOnly = true;
			this.txtSOL_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtSOLNotes1 = this.txtSOL_notes;
			.Size = new System.Drawing.Size(546, 68);
			txtSOLNotes1.Size = .Size;
			this.txtSOL_notes.TabIndex = 220;
			this.txtSOL_notes.Text = "Comments";
			this.Label96.AutoSize = true;
			this.Label96.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label96 = this.Label96;
			.Location = new System.Drawing.Point(308, 236);
			label96.Location = .Location;
			this.Label96.Name = "Label96";
			System.Windows.Forms.Label label961 = this.Label96;
			.Size = new System.Drawing.Size(49, 13);
			label961.Size = .Size;
			this.Label96.TabIndex = 221;
			this.Label96.Text = "Vesting:";
			this.Label31.AutoSize = true;
			this.Label31.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label31 = this.Label31;
			.Location = new System.Drawing.Point(148, 68);
			label31.Location = .Location;
			this.Label31.Name = "Label31";
			System.Windows.Forms.Label label311 = this.Label31;
			.Size = new System.Drawing.Size(22, 13);
			label311.Size = .Size;
			this.Label31.TabIndex = 140;
			this.Label31.Text = "RD";
			this.Label32.AutoSize = true;
			this.Label32.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label32 = this.Label32;
			.Location = new System.Drawing.Point(148, 44);
			label32.Location = .Location;
			this.Label32.Name = "Label32";
			System.Windows.Forms.Label label321 = this.Label32;
			.Size = new System.Drawing.Size(22, 13);
			label321.Size = .Size;
			this.Label32.TabIndex = 139;
			this.Label32.Text = "RD";
			this.Label73.AutoSize = true;
			this.Label73.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label73 = this.Label73;
			.Location = new System.Drawing.Point(277, 110);
			label73.Location = .Location;
			this.Label73.Name = "Label73";
			System.Windows.Forms.Label label731 = this.Label73;
			.Size = new System.Drawing.Size(80, 13);
			label731.Size = .Size;
			this.Label73.TabIndex = 133;
			this.Label73.Text = "Spousal State:";
			this.Label75.AutoSize = true;
			this.Label75.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label75 = this.Label75;
			.Location = new System.Drawing.Point(281, 64);
			label75.Location = .Location;
			this.Label75.Name = "Label75";
			System.Windows.Forms.Label label751 = this.Label75;
			.Size = new System.Drawing.Size(76, 13);
			label751.Size = .Size;
			this.Label75.TabIndex = 132;
			this.Label75.Text = "Personal Tax:";
			this.Label82.AutoSize = true;
			this.Label82.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label82 = this.Label82;
			.Location = new System.Drawing.Point(292, 137);
			label82.Location = .Location;
			this.Label82.Name = "Label82";
			System.Windows.Forms.Label label821 = this.Label82;
			.Size = new System.Drawing.Size(65, 13);
			label821.Size = .Size;
			this.Label82.TabIndex = 131;
			this.Label82.Text = "Hosp. Lien:";
			this.Label90.AutoSize = true;
			this.Label90.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label90 = this.Label90;
			.Location = new System.Drawing.Point(292, 41);
			label90.Location = .Location;
			this.Label90.Name = "Label90";
			System.Windows.Forms.Label label901 = this.Label90;
			.Size = new System.Drawing.Size(65, 13);
			label901.Size = .Size;
			this.Label90.TabIndex = 130;
			this.Label90.Text = "State Jgmt:";
			this.Label91.AutoSize = true;
			this.Label91.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label91 = this.Label91;
			.Location = new System.Drawing.Point(284, 87);
			label91.Location = .Location;
			this.Label91.Name = "Label91";
			System.Windows.Forms.Label label911 = this.Label91;
			.Size = new System.Drawing.Size(73, 13);
			label911.Size = .Size;
			this.Label91.TabIndex = 129;
			this.Label91.Text = "Support Obl:";
			this.Label30.AutoSize = true;
			this.Label30.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label30 = this.Label30;
			.Location = new System.Drawing.Point(246, 262);
			label30.Location = .Location;
			this.Label30.Name = "Label30";
			System.Windows.Forms.Label label301 = this.Label30;
			.Size = new System.Drawing.Size(111, 13);
			label301.Size = .Size;
			this.Label30.TabIndex = 125;
			this.Label30.Text = "After Acquired Lien:";
			this.Label77.AutoSize = true;
			this.Label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Underline, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label77 = this.Label77;
			.Location = new System.Drawing.Point(14, 7);
			label77.Location = .Location;
			this.Label77.Name = "Label77";
			System.Windows.Forms.Label label771 = this.Label77;
			.Size = new System.Drawing.Size(184, 17);
			label771.Size = .Size;
			this.Label77.TabIndex = 124;
			this.Label77.Text = "STATUTES OF LIMITATION";
			this.Label76.AutoSize = true;
			this.Label76.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label76 = this.Label76;
			.Location = new System.Drawing.Point(266, 188);
			label76.Location = .Location;
			this.Label76.Name = "Label76";
			System.Windows.Forms.Label label761 = this.Label76;
			.Size = new System.Drawing.Size(91, 13);
			label761.Size = .Size;
			this.Label76.TabIndex = 121;
			this.Label76.Text = "Redem. (Forecl):";
			this.Label74.AutoSize = true;
			this.Label74.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label74 = this.Label74;
			.Location = new System.Drawing.Point(268, 164);
			label74.Location = .Location;
			this.Label74.Name = "Label74";
			System.Windows.Forms.Label label741 = this.Label74;
			.Size = new System.Drawing.Size(89, 13);
			label741.Size = .Size;
			this.Label74.TabIndex = 103;
			this.Label74.Text = "Redem. (Taxes):";
			this.Label79.AutoSize = true;
			this.Label79.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label79 = this.Label79;
			.Location = new System.Drawing.Point(31, 212);
			label79.Location = .Location;
			this.Label79.Name = "Label79";
			System.Windows.Forms.Label label791 = this.Label79;
			.Size = new System.Drawing.Size(89, 13);
			label791.Size = .Size;
			this.Label79.TabIndex = 98;
			this.Label79.Text = "Creditor Claims:";
			this.Label81.AutoSize = true;
			this.Label81.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label81 = this.Label81;
			.Location = new System.Drawing.Point(309, 212);
			label81.Location = .Location;
			this.Label81.Name = "Label81";
			System.Windows.Forms.Label label811 = this.Label81;
			.Size = new System.Drawing.Size(48, 13);
			label811.Size = .Size;
			this.Label81.TabIndex = 96;
			this.Label81.Text = "TE Rule:";
			this.Label83.AutoSize = true;
			this.Label83.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label83 = this.Label83;
			.Location = new System.Drawing.Point(57, 188);
			label83.Location = .Location;
			this.Label83.Name = "Label83";
			System.Windows.Forms.Label label831 = this.Label83;
			.Size = new System.Drawing.Size(63, 13);
			label831.Size = .Size;
			this.Label83.TabIndex = 86;
			this.Label83.Text = "Judgment:";
			this.Label85.AutoSize = true;
			this.Label85.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label85 = this.Label85;
			.Location = new System.Drawing.Point(42, 164);
			label85.Location = .Location;
			this.Label85.Name = "Label85";
			System.Windows.Forms.Label label851 = this.Label85;
			.Size = new System.Drawing.Size(78, 13);
			label851.Size = .Size;
			this.Label85.TabIndex = 84;
			this.Label85.Text = "Claim of Lien:";
			this.Label87.AutoSize = true;
			this.Label87.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label87 = this.Label87;
			.Location = new System.Drawing.Point(61, 236);
			label87.Location = .Location;
			this.Label87.Name = "Label87";
			System.Windows.Forms.Label label871 = this.Label87;
			.Size = new System.Drawing.Size(59, 13);
			label871.Size = .Size;
			this.Label87.TabIndex = 82;
			this.Label87.Text = "HOA Lien:";
			this.Label88.AutoSize = true;
			this.Label88.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label88 = this.Label88;
			.Location = new System.Drawing.Point(13, 140);
			label88.Location = .Location;
			this.Label88.Name = "Label88";
			System.Windows.Forms.Label label881 = this.Label88;
			.Size = new System.Drawing.Size(107, 13);
			label881.Size = .Size;
			this.Label88.TabIndex = 80;
			this.Label88.Text = "Notice/Commence:";
			this.Label89.AutoSize = true;
			this.Label89.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label89 = this.Label89;
			.Location = new System.Drawing.Point(56, 116);
			label89.Location = .Location;
			this.Label89.Name = "Label89";
			System.Windows.Forms.Label label891 = this.Label89;
			.Size = new System.Drawing.Size(64, 13);
			label891.Size = .Size;
			this.Label89.TabIndex = 78;
			this.Label89.Text = "Mech.Lien:";
			this.Label92.AutoSize = true;
			this.Label92.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label92 = this.Label92;
			.Location = new System.Drawing.Point(51, 92);
			label92.Location = .Location;
			this.Label92.Name = "Label92";
			System.Windows.Forms.Label label921 = this.Label92;
			.Size = new System.Drawing.Size(69, 13);
			label921.Size = .Size;
			this.Label92.TabIndex = 71;
			this.Label92.Text = "LisPendens:";
			this.Label93.AutoSize = true;
			this.Label93.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label93 = this.Label93;
			.Location = new System.Drawing.Point(21, 68);
			label93.Location = .Location;
			this.Label93.Name = "Label93";
			System.Windows.Forms.Label label931 = this.Label93;
			.Size = new System.Drawing.Size(67, 13);
			label931.Size = .Size;
			this.Label93.TabIndex = 69;
			this.Label93.Text = "HELOC: AM";
			this.Label94.AutoSize = true;
			this.Label94.Font = new System.Drawing.Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label94 = this.Label94;
			.Location = new System.Drawing.Point(7, 44);
			label94.Location = .Location;
			this.Label94.Name = "Label94";
			System.Windows.Forms.Label label941 = this.Label94;
			.Size = new System.Drawing.Size(81, 13);
			label941.Size = .Size;
			this.Label94.TabIndex = 67;
			this.Label94.Text = "Mtg/DOT: AM";
			this.TabPage03.BackColor = Color.AliceBlue;
			this.TabPage03.Controls.Add(this.Label41);
			this.TabPage03.Controls.Add(this.txtInput_DelinqTaxURL);
			this.TabPage03.Controls.Add(this.Label5);
			this.TabPage03.Controls.Add(this.Label35);
			this.TabPage03.Controls.Add(this.txt_TaxDateVerified);
			this.TabPage03.Controls.Add(this.txtInput_TaxCertTAT);
			this.TabPage03.Controls.Add(this.txtInput_LocalTaxURL);
			this.TabPage03.Controls.Add(this.txtInput_NewTaxState);
			this.TabPage03.Controls.Add(this.txtInput_NewTaxCounty);
			this.TabPage03.Controls.Add(this.txtInput_TaxCertFee);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeeState);
			this.TabPage03.Controls.Add(this.txtInput_TaxOfficeHours);
			this.TabPage03.Controls.Add(this.txtInput_TaxDueDates);
			this.TabPage03.Controls.Add(this.txtInput_TaxComments);
			this.TabPage03.Controls.Add(this.txtInput_TaxAuthName);
			this.TabPage03.Controls.Add(this.txtInput_TaxAuthType);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeePhone);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeeZip);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeeFax);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeeCity);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeeStr2);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeeStr1);
			this.TabPage03.Controls.Add(this.txtInput_TaxPayeeName);
			this.TabPage03.Controls.Add(this.Label4);
			this.TabPage03.Controls.Add(this.Label26);
			this.TabPage03.Controls.Add(this.lblNewState);
			this.TabPage03.Controls.Add(this.lblTaxCounty);
			this.TabPage03.Controls.Add(this.Label28);
			this.TabPage03.Controls.Add(this.chkbxTaxCertRequired);
			this.TabPage03.Controls.Add(this.Button_NEW);
			this.TabPage03.Controls.Add(this.cboxInput_TaxBillingCycle);
			this.TabPage03.Controls.Add(this.Label57);
			this.TabPage03.Controls.Add(this.Label59);
			this.TabPage03.Controls.Add(this.Label60);
			this.TabPage03.Controls.Add(this.Label54);
			this.TabPage03.Controls.Add(this.Label53);
			this.TabPage03.Controls.Add(this.Label51);
			this.TabPage03.Controls.Add(this.Label44);
			this.TabPage03.Controls.Add(this.Label45);
			this.TabPage03.Controls.Add(this.Label46);
			this.TabPage03.Controls.Add(this.Label47);
			this.TabPage03.Controls.Add(this.Label48);
			this.TabPage03.Controls.Add(this.Label49);
			this.TabPage03.Controls.Add(this.Label50);
			TabPage tabPage03 = this.TabPage03;
			.Location = new System.Drawing.Point(4, 22);
			tabPage03.Location = .Location;
			this.TabPage03.Name = "TabPage03";
			TabPage tabPage031 = this.TabPage03;
			.Padding = new System.Windows.Forms.Padding(3);
			tabPage031.Padding = .Padding;
			TabPage tabPage1 = this.TabPage03;
			.Size = new System.Drawing.Size(594, 373);
			tabPage1.Size = .Size;
			this.TabPage03.TabIndex = 4;
			this.TabPage03.Text = "Tax Office";
			this.Label41.AutoSize = true;
			System.Windows.Forms.Label label41 = this.Label41;
			.Location = new System.Drawing.Point(308, 210);
			label41.Location = .Location;
			this.Label41.Name = "Label41";
			System.Windows.Forms.Label label411 = this.Label41;
			.Size = new System.Drawing.Size(59, 13);
			label411.Size = .Size;
			this.Label41.TabIndex = 128;
			this.Label41.Text = "Comments:";
			System.Windows.Forms.TextBox txtInputDelinqTaxURL = this.txtInput_DelinqTaxURL;
			.Location = new System.Drawing.Point(22, 147);
			txtInputDelinqTaxURL.Location = .Location;
			this.txtInput_DelinqTaxURL.Name = "txtInput_DelinqTaxURL";
			System.Windows.Forms.TextBox txtInputDelinqTaxURL1 = this.txtInput_DelinqTaxURL;
			.Size = new System.Drawing.Size(219, 20);
			txtInputDelinqTaxURL1.Size = .Size;
			this.txtInput_DelinqTaxURL.TabIndex = 126;
			this.Label5.AutoSize = true;
			System.Windows.Forms.Label label5 = this.Label5;
			.Location = new System.Drawing.Point(20, 131);
			label5.Location = .Location;
			this.Label5.Name = "Label5";
			System.Windows.Forms.Label label51 = this.Label5;
			.Size = new System.Drawing.Size(135, 13);
			label51.Size = .Size;
			this.Label5.TabIndex = 127;
			this.Label5.Text = "Delinquent Taxes Website:";
			this.Label35.AutoSize = true;
			System.Windows.Forms.Label label35 = this.Label35;
			.Location = new System.Drawing.Point(307, 179);
			label35.Location = .Location;
			this.Label35.Name = "Label35";
			System.Windows.Forms.Label label351 = this.Label35;
			.Size = new System.Drawing.Size(68, 13);
			label351.Size = .Size;
			this.Label35.TabIndex = 125;
			this.Label35.Text = "Date Verified";
			System.Windows.Forms.TextBox txtTaxDateVerified = this.txt_TaxDateVerified;
			.Location = new System.Drawing.Point(381, 176);
			txtTaxDateVerified.Location = .Location;
			this.txt_TaxDateVerified.Name = "txt_TaxDateVerified";
			System.Windows.Forms.TextBox txtTaxDateVerified1 = this.txt_TaxDateVerified;
			.Size = new System.Drawing.Size(97, 20);
			txtTaxDateVerified1.Size = .Size;
			this.txt_TaxDateVerified.TabIndex = 124;
			System.Windows.Forms.TextBox txtInputTaxCertTAT = this.txtInput_TaxCertTAT;
			.Location = new System.Drawing.Point(381, 150);
			txtInputTaxCertTAT.Location = .Location;
			this.txtInput_TaxCertTAT.Name = "txtInput_TaxCertTAT";
			System.Windows.Forms.TextBox txtInputTaxCertTAT1 = this.txtInput_TaxCertTAT;
			.Size = new System.Drawing.Size(97, 20);
			txtInputTaxCertTAT1.Size = .Size;
			this.txtInput_TaxCertTAT.TabIndex = 88;
			System.Windows.Forms.TextBox txtInputLocalTaxURL = this.txtInput_LocalTaxURL;
			.Location = new System.Drawing.Point(23, 108);
			txtInputLocalTaxURL.Location = .Location;
			this.txtInput_LocalTaxURL.Name = "txtInput_LocalTaxURL";
			System.Windows.Forms.TextBox txtInputLocalTaxURL1 = this.txtInput_LocalTaxURL;
			.Size = new System.Drawing.Size(219, 20);
			txtInputLocalTaxURL1.Size = .Size;
			this.txtInput_LocalTaxURL.TabIndex = 72;
			System.Windows.Forms.TextBox txtInputNewTaxState = this.txtInput_NewTaxState;
			.Location = new System.Drawing.Point(177, 30);
			txtInputNewTaxState.Location = .Location;
			this.txtInput_NewTaxState.Name = "txtInput_NewTaxState";
			System.Windows.Forms.TextBox txtInputNewTaxState1 = this.txtInput_NewTaxState;
			.Size = new System.Drawing.Size(42, 20);
			txtInputNewTaxState1.Size = .Size;
			this.txtInput_NewTaxState.TabIndex = 69;
			System.Windows.Forms.TextBox txtInputNewTaxCounty = this.txtInput_NewTaxCounty;
			.Location = new System.Drawing.Point(223, 30);
			txtInputNewTaxCounty.Location = .Location;
			this.txtInput_NewTaxCounty.Name = "txtInput_NewTaxCounty";
			System.Windows.Forms.TextBox txtInputNewTaxCounty1 = this.txtInput_NewTaxCounty;
			.Size = new System.Drawing.Size(79, 20);
			txtInputNewTaxCounty1.Size = .Size;
			this.txtInput_NewTaxCounty.TabIndex = 70;
			System.Windows.Forms.TextBox txtInputTaxCertFee = this.txtInput_TaxCertFee;
			.Location = new System.Drawing.Point(381, 124);
			txtInputTaxCertFee.Location = .Location;
			this.txtInput_TaxCertFee.Name = "txtInput_TaxCertFee";
			System.Windows.Forms.TextBox txtInputTaxCertFee1 = this.txtInput_TaxCertFee;
			.Size = new System.Drawing.Size(97, 20);
			txtInputTaxCertFee1.Size = .Size;
			this.txtInput_TaxCertFee.TabIndex = 87;
			System.Windows.Forms.TextBox txtInputTaxPayeeState = this.txtInput_TaxPayeeState;
			.Location = new System.Drawing.Point(190, 250);
			txtInputTaxPayeeState.Location = .Location;
			this.txtInput_TaxPayeeState.Name = "txtInput_TaxPayeeState";
			System.Windows.Forms.TextBox txtInputTaxPayeeState1 = this.txtInput_TaxPayeeState;
			.Size = new System.Drawing.Size(51, 20);
			txtInputTaxPayeeState1.Size = .Size;
			this.txtInput_TaxPayeeState.TabIndex = 77;
			System.Windows.Forms.TextBox txtInputTaxOfficeHours = this.txtInput_TaxOfficeHours;
			.Location = new System.Drawing.Point(381, 78);
			txtInputTaxOfficeHours.Location = .Location;
			this.txtInput_TaxOfficeHours.Name = "txtInput_TaxOfficeHours";
			System.Windows.Forms.TextBox txtInputTaxOfficeHours1 = this.txtInput_TaxOfficeHours;
			.Size = new System.Drawing.Size(173, 20);
			txtInputTaxOfficeHours1.Size = .Size;
			this.txtInput_TaxOfficeHours.TabIndex = 85;
			System.Windows.Forms.TextBox txtInputTaxDueDates = this.txtInput_TaxDueDates;
			.Location = new System.Drawing.Point(381, 53);
			txtInputTaxDueDates.Location = .Location;
			this.txtInput_TaxDueDates.Name = "txtInput_TaxDueDates";
			System.Windows.Forms.TextBox txtInputTaxDueDates1 = this.txtInput_TaxDueDates;
			.Size = new System.Drawing.Size(173, 20);
			txtInputTaxDueDates1.Size = .Size;
			this.txtInput_TaxDueDates.TabIndex = 84;
			System.Windows.Forms.TextBox txtInputTaxComments = this.txtInput_TaxComments;
			.Location = new System.Drawing.Point(310, 225);
			txtInputTaxComments.Location = .Location;
			this.txtInput_TaxComments.Multiline = true;
			this.txtInput_TaxComments.Name = "txtInput_TaxComments";
			this.txtInput_TaxComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputTaxComments1 = this.txtInput_TaxComments;
			.Size = new System.Drawing.Size(263, 87);
			txtInputTaxComments1.Size = .Size;
			this.txtInput_TaxComments.TabIndex = 81;
			System.Windows.Forms.TextBox txtInputTaxAuthName = this.txtInput_TaxAuthName;
			.Location = new System.Drawing.Point(23, 69);
			txtInputTaxAuthName.Location = .Location;
			this.txtInput_TaxAuthName.Name = "txtInput_TaxAuthName";
			System.Windows.Forms.TextBox txtInputTaxAuthName1 = this.txtInput_TaxAuthName;
			.Size = new System.Drawing.Size(219, 20);
			txtInputTaxAuthName1.Size = .Size;
			this.txtInput_TaxAuthName.TabIndex = 71;
			System.Windows.Forms.TextBox txtInputTaxAuthType = this.txtInput_TaxAuthType;
			.Location = new System.Drawing.Point(23, 30);
			txtInputTaxAuthType.Location = .Location;
			this.txtInput_TaxAuthType.Name = "txtInput_TaxAuthType";
			System.Windows.Forms.TextBox txtInputTaxAuthType1 = this.txtInput_TaxAuthType;
			.Size = new System.Drawing.Size(150, 20);
			txtInputTaxAuthType1.Size = .Size;
			this.txtInput_TaxAuthType.TabIndex = 68;
			System.Windows.Forms.TextBox txtInputTaxPayeePhone = this.txtInput_TaxPayeePhone;
			.Location = new System.Drawing.Point(63, 291);
			txtInputTaxPayeePhone.Location = .Location;
			this.txtInput_TaxPayeePhone.Name = "txtInput_TaxPayeePhone";
			System.Windows.Forms.TextBox txtInputTaxPayeePhone1 = this.txtInput_TaxPayeePhone;
			.Size = new System.Drawing.Size(93, 20);
			txtInputTaxPayeePhone1.Size = .Size;
			this.txtInput_TaxPayeePhone.TabIndex = 79;
			System.Windows.Forms.TextBox txtInputTaxPayeeZip = this.txtInput_TaxPayeeZip;
			.Location = new System.Drawing.Point(63, 269);
			txtInputTaxPayeeZip.Location = .Location;
			this.txtInput_TaxPayeeZip.Name = "txtInput_TaxPayeeZip";
			System.Windows.Forms.TextBox txtInputTaxPayeeZip1 = this.txtInput_TaxPayeeZip;
			.Size = new System.Drawing.Size(93, 20);
			txtInputTaxPayeeZip1.Size = .Size;
			this.txtInput_TaxPayeeZip.TabIndex = 78;
			System.Windows.Forms.TextBox txtInputTaxPayeeFax = this.txtInput_TaxPayeeFax;
			.Location = new System.Drawing.Point(190, 291);
			txtInputTaxPayeeFax.Location = .Location;
			this.txtInput_TaxPayeeFax.Name = "txtInput_TaxPayeeFax";
			System.Windows.Forms.TextBox txtInputTaxPayeeFax1 = this.txtInput_TaxPayeeFax;
			.Size = new System.Drawing.Size(111, 20);
			txtInputTaxPayeeFax1.Size = .Size;
			this.txtInput_TaxPayeeFax.TabIndex = 80;
			System.Windows.Forms.TextBox txtInputTaxPayeeCity = this.txtInput_TaxPayeeCity;
			.Location = new System.Drawing.Point(63, 247);
			txtInputTaxPayeeCity.Location = .Location;
			this.txtInput_TaxPayeeCity.Name = "txtInput_TaxPayeeCity";
			System.Windows.Forms.TextBox txtInputTaxPayeeCity1 = this.txtInput_TaxPayeeCity;
			.Size = new System.Drawing.Size(93, 20);
			txtInputTaxPayeeCity1.Size = .Size;
			this.txtInput_TaxPayeeCity.TabIndex = 76;
			System.Windows.Forms.TextBox txtInputTaxPayeeStr2 = this.txtInput_TaxPayeeStr2;
			.Location = new System.Drawing.Point(63, 225);
			txtInputTaxPayeeStr2.Location = .Location;
			this.txtInput_TaxPayeeStr2.Name = "txtInput_TaxPayeeStr2";
			System.Windows.Forms.TextBox txtInputTaxPayeeStr21 = this.txtInput_TaxPayeeStr2;
			.Size = new System.Drawing.Size(239, 20);
			txtInputTaxPayeeStr21.Size = .Size;
			this.txtInput_TaxPayeeStr2.TabIndex = 75;
			System.Windows.Forms.TextBox txtInputTaxPayeeStr1 = this.txtInput_TaxPayeeStr1;
			.Location = new System.Drawing.Point(63, 203);
			txtInputTaxPayeeStr1.Location = .Location;
			this.txtInput_TaxPayeeStr1.Name = "txtInput_TaxPayeeStr1";
			System.Windows.Forms.TextBox txtInputTaxPayeeStr11 = this.txtInput_TaxPayeeStr1;
			.Size = new System.Drawing.Size(239, 20);
			txtInputTaxPayeeStr11.Size = .Size;
			this.txtInput_TaxPayeeStr1.TabIndex = 74;
			System.Windows.Forms.TextBox txtInputTaxPayeeName = this.txtInput_TaxPayeeName;
			.Location = new System.Drawing.Point(63, 181);
			txtInputTaxPayeeName.Location = .Location;
			this.txtInput_TaxPayeeName.Name = "txtInput_TaxPayeeName";
			System.Windows.Forms.TextBox txtInputTaxPayeeName1 = this.txtInput_TaxPayeeName;
			.Size = new System.Drawing.Size(239, 20);
			txtInputTaxPayeeName1.Size = .Size;
			this.txtInput_TaxPayeeName.TabIndex = 73;
			this.Label4.AutoSize = true;
			System.Windows.Forms.Label label4 = this.Label4;
			.Location = new System.Drawing.Point(328, 153);
			label4.Location = .Location;
			this.Label4.Name = "Label4";
			System.Windows.Forms.Label label42 = this.Label4;
			.Size = new System.Drawing.Size(50, 13);
			label42.Size = .Size;
			this.Label4.TabIndex = 121;
			this.Label4.Text = "Cert TAT";
			this.Label26.AutoSize = true;
			System.Windows.Forms.Label label26 = this.Label26;
			.Location = new System.Drawing.Point(21, 92);
			label26.Location = .Location;
			this.Label26.Name = "Label26";
			System.Windows.Forms.Label label261 = this.Label26;
			.Size = new System.Drawing.Size(150, 13);
			label261.Size = .Size;
			this.Label26.TabIndex = 119;
			this.Label26.Text = "Local Tax Web (NOT county):";
			this.lblNewState.AutoSize = true;
			this.lblNewState.ForeColor = Color.Red;
			System.Windows.Forms.Label label2 = this.lblNewState;
			.Location = new System.Drawing.Point(176, 14);
			label2.Location = .Location;
			this.lblNewState.Name = "lblNewState";
			System.Windows.Forms.Label label3 = this.lblNewState;
			.Size = new System.Drawing.Size(32, 13);
			label3.Size = .Size;
			this.lblNewState.TabIndex = 116;
			this.lblNewState.Text = "State";
			this.lblTaxCounty.AutoSize = true;
			this.lblTaxCounty.ForeColor = Color.Red;
			System.Windows.Forms.Label label6 = this.lblTaxCounty;
			.Location = new System.Drawing.Point(221, 14);
			label6.Location = .Location;
			this.lblTaxCounty.Name = "lblTaxCounty";
			System.Windows.Forms.Label label7 = this.lblTaxCounty;
			.Size = new System.Drawing.Size(82, 13);
			label7.Size = .Size;
			this.lblTaxCounty.TabIndex = 114;
			this.lblTaxCounty.Text = "TAX COUNTY: ";
			this.Label28.AutoSize = true;
			System.Windows.Forms.Label label28 = this.Label28;
			.Location = new System.Drawing.Point(331, 127);
			label28.Location = .Location;
			this.Label28.Name = "Label28";
			System.Windows.Forms.Label label281 = this.Label28;
			.Size = new System.Drawing.Size(47, 13);
			label281.Size = .Size;
			this.Label28.TabIndex = 113;
			this.Label28.Text = "Cert Fee";
			this.chkbxTaxCertRequired.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox = this.chkbxTaxCertRequired;
			.Location = new System.Drawing.Point(381, 105);
			checkBox.Location = .Location;
			this.chkbxTaxCertRequired.Name = "chkbxTaxCertRequired";
			System.Windows.Forms.CheckBox checkBox1 = this.chkbxTaxCertRequired;
			.Size = new System.Drawing.Size(112, 17);
			checkBox1.Size = .Size;
			this.chkbxTaxCertRequired.TabIndex = 86;
			this.chkbxTaxCertRequired.Text = "Tax Cert Required";
			this.chkbxTaxCertRequired.UseVisualStyleBackColor = true;
			System.Windows.Forms.Button buttonNEW = this.Button_NEW;
			.Location = new System.Drawing.Point(506, 10);
			buttonNEW.Location = .Location;
			this.Button_NEW.Name = "Button_NEW";
			System.Windows.Forms.Button buttonNEW1 = this.Button_NEW;
			.Size = new System.Drawing.Size(63, 23);
			buttonNEW1.Size = .Size;
			this.Button_NEW.TabIndex = 89;
			this.Button_NEW.Text = "NEW";
			this.Button_NEW.UseVisualStyleBackColor = true;
			this.cboxInput_TaxBillingCycle.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections = this.cboxInput_TaxBillingCycle.Items;
			objArray = new object[] { "Annual", "Semi-Annual", "Quarterly", "Summer-Winter" };
			objectCollections.AddRange(objArray);
			ComboBox cboxInputTaxBillingCycle = this.cboxInput_TaxBillingCycle;
			.Location = new System.Drawing.Point(381, 27);
			cboxInputTaxBillingCycle.Location = .Location;
			this.cboxInput_TaxBillingCycle.Name = "cboxInput_TaxBillingCycle";
			ComboBox cboxInputTaxBillingCycle1 = this.cboxInput_TaxBillingCycle;
			.Size = new System.Drawing.Size(97, 21);
			cboxInputTaxBillingCycle1.Size = .Size;
			this.cboxInput_TaxBillingCycle.TabIndex = 83;
			this.Label57.AutoSize = true;
			System.Windows.Forms.Label label57 = this.Label57;
			.Location = new System.Drawing.Point(324, 31);
			label57.Location = .Location;
			this.Label57.Name = "Label57";
			System.Windows.Forms.Label label571 = this.Label57;
			.Size = new System.Drawing.Size(49, 13);
			label571.Size = .Size;
			this.Label57.TabIndex = 105;
			this.Label57.Text = "Bill Cycle";
			this.Label59.AutoSize = true;
			System.Windows.Forms.Label label59 = this.Label59;
			.Location = new System.Drawing.Point(307, 83);
			label59.Location = .Location;
			this.Label59.Name = "Label59";
			System.Windows.Forms.Label label591 = this.Label59;
			.Size = new System.Drawing.Size(66, 13);
			label591.Size = .Size;
			this.Label59.TabIndex = 100;
			this.Label59.Text = "Office Hours";
			this.Label60.AutoSize = true;
			System.Windows.Forms.Label label60 = this.Label60;
			.Location = new System.Drawing.Point(315, 57);
			label60.Location = .Location;
			this.Label60.Name = "Label60";
			System.Windows.Forms.Label label601 = this.Label60;
			.Size = new System.Drawing.Size(58, 13);
			label601.Size = .Size;
			this.Label60.TabIndex = 99;
			this.Label60.Text = "Due Dates";
			this.Label54.AutoSize = true;
			System.Windows.Forms.Label label54 = this.Label54;
			.Location = new System.Drawing.Point(160, 295);
			label54.Location = .Location;
			this.Label54.Name = "Label54";
			System.Windows.Forms.Label label541 = this.Label54;
			.Size = new System.Drawing.Size(24, 13);
			label541.Size = .Size;
			this.Label54.TabIndex = 97;
			this.Label54.Text = "Fax";
			this.Label53.AutoSize = true;
			System.Windows.Forms.Label label53 = this.Label53;
			.Location = new System.Drawing.Point(21, 53);
			label53.Location = .Location;
			this.Label53.Name = "Label53";
			System.Windows.Forms.Label label531 = this.Label53;
			.Size = new System.Drawing.Size(103, 13);
			label531.Size = .Size;
			this.Label53.TabIndex = 95;
			this.Label53.Text = "Tax Authority Name:";
			this.Label51.AutoSize = true;
			System.Windows.Forms.Label label511 = this.Label51;
			.Location = new System.Drawing.Point(21, 14);
			label511.Location = .Location;
			this.Label51.Name = "Label51";
			System.Windows.Forms.Label label512 = this.Label51;
			.Size = new System.Drawing.Size(102, 13);
			label512.Size = .Size;
			this.Label51.TabIndex = 91;
			this.Label51.Text = "Tax Type Collected:";
			this.Label44.AutoSize = true;
			System.Windows.Forms.Label label44 = this.Label44;
			.Location = new System.Drawing.Point(167, 253);
			label44.Location = .Location;
			this.Label44.Name = "Label44";
			System.Windows.Forms.Label label441 = this.Label44;
			.Size = new System.Drawing.Size(17, 13);
			label441.Size = .Size;
			this.Label44.TabIndex = 89;
			this.Label44.Text = "St";
			this.Label45.AutoSize = true;
			System.Windows.Forms.Label label45 = this.Label45;
			.Location = new System.Drawing.Point(33, 253);
			label45.Location = .Location;
			this.Label45.Name = "Label45";
			System.Windows.Forms.Label label451 = this.Label45;
			.Size = new System.Drawing.Size(24, 13);
			label451.Size = .Size;
			this.Label45.TabIndex = 79;
			this.Label45.Text = "City";
			this.Label46.AutoSize = true;
			System.Windows.Forms.Label label46 = this.Label46;
			.Location = new System.Drawing.Point(19, 299);
			label46.Location = .Location;
			this.Label46.Name = "Label46";
			System.Windows.Forms.Label label461 = this.Label46;
			.Size = new System.Drawing.Size(38, 13);
			label461.Size = .Size;
			this.Label46.TabIndex = 81;
			this.Label46.Text = "Phone";
			this.Label47.AutoSize = true;
			System.Windows.Forms.Label label47 = this.Label47;
			.Location = new System.Drawing.Point(35, 276);
			label47.Location = .Location;
			this.Label47.Name = "Label47";
			System.Windows.Forms.Label label471 = this.Label47;
			.Size = new System.Drawing.Size(22, 13);
			label471.Size = .Size;
			this.Label47.TabIndex = 80;
			this.Label47.Text = "Zip";
			this.Label48.AutoSize = true;
			System.Windows.Forms.Label label48 = this.Label48;
			.Location = new System.Drawing.Point(20, 184);
			label48.Location = .Location;
			this.Label48.Name = "Label48";
			System.Windows.Forms.Label label481 = this.Label48;
			.Size = new System.Drawing.Size(37, 13);
			label481.Size = .Size;
			this.Label48.TabIndex = 76;
			this.Label48.Text = "Payee";
			this.Label49.AutoSize = true;
			System.Windows.Forms.Label label49 = this.Label49;
			.Location = new System.Drawing.Point(7, 230);
			label49.Location = .Location;
			this.Label49.Name = "Label49";
			System.Windows.Forms.Label label491 = this.Label49;
			.Size = new System.Drawing.Size(50, 13);
			label491.Size = .Size;
			this.Label49.TabIndex = 78;
			this.Label49.Text = "Str Adrs2";
			this.Label50.AutoSize = true;
			System.Windows.Forms.Label label50 = this.Label50;
			.Location = new System.Drawing.Point(7, 207);
			label50.Location = .Location;
			this.Label50.Name = "Label50";
			System.Windows.Forms.Label label501 = this.Label50;
			.Size = new System.Drawing.Size(50, 13);
			label501.Size = .Size;
			this.Label50.TabIndex = 77;
			this.Label50.Text = "Str Adrs1";
			this.TabPage01.AutoScroll = true;
			this.TabPage01.BackColor = Color.AliceBlue;
			this.TabPage01.Controls.Add(this.txtInput_NotaryURL);
			this.TabPage01.Controls.Add(this.Label67);
			this.TabPage01.Controls.Add(this.txtInput_State_CodeURL);
			this.TabPage01.Controls.Add(this.txtInput_Sec_of_State_url);
			this.TabPage01.Controls.Add(this.txtInput_DOIurl);
			this.TabPage01.Controls.Add(this.Label56);
			this.TabPage01.Controls.Add(this.Label62);
			this.TabPage01.Controls.Add(this.Label63);
			this.TabPage01.Controls.Add(this.ckbxLoginRequired);
			this.TabPage01.Controls.Add(this.Label33);
			this.TabPage01.Controls.Add(this.txtInput_UCC_url);
			this.TabPage01.Controls.Add(this.txtInput_OtherURLPwd);
			this.TabPage01.Controls.Add(this.txtInput_OtherURLUsername);
			this.TabPage01.Controls.Add(this.txtInput_ProbatePwd);
			this.TabPage01.Controls.Add(this.txtInput_ProbateUsername);
			this.TabPage01.Controls.Add(this.txtInput_ProthonPwd);
			this.TabPage01.Controls.Add(this.txtInput_ProthonUsername);
			this.TabPage01.Controls.Add(this.txtInput_AssessorPwd);
			this.TabPage01.Controls.Add(this.txtInput_AssessorUsername);
			this.TabPage01.Controls.Add(this.txtInput_TaxLocalPwd);
			this.TabPage01.Controls.Add(this.txtInput_TaxLocalUsername);
			this.TabPage01.Controls.Add(this.txtInput_TaxCountyPwd);
			this.TabPage01.Controls.Add(this.txtInput_TaxCountyUsername);
			this.TabPage01.Controls.Add(this.txtInput_MuniCtPwd);
			this.TabPage01.Controls.Add(this.txtInput_MuniCtUsername);
			this.TabPage01.Controls.Add(this.txtInput_CivCtPwd);
			this.TabPage01.Controls.Add(this.txtInput_CivCtUsername);
			this.TabPage01.Controls.Add(this.txtInput_LandPwd);
			this.TabPage01.Controls.Add(this.txtInput_LandUsername);
			this.TabPage01.Controls.Add(this.txtInput_OtherURL);
			this.TabPage01.Controls.Add(this.txtInput_CountyHomeURL);
			this.TabPage01.Controls.Add(this.txtInput_ForeclosureURL);
			this.TabPage01.Controls.Add(this.txtInput_SheriffURL);
			this.TabPage01.Controls.Add(this.txtInput_ProbateURL);
			this.TabPage01.Controls.Add(this.txtInput_ProthonURL);
			this.TabPage01.Controls.Add(this.txtInput_MapURL);
			this.TabPage01.Controls.Add(this.txtInput_PlatsURL);
			this.TabPage01.Controls.Add(this.txtInput_AssessorURL);
			this.TabPage01.Controls.Add(this.txtInput_Tax2URL);
			this.TabPage01.Controls.Add(this.txtInput_TaxCountyURL);
			this.TabPage01.Controls.Add(this.txtInput_MuniCtURL);
			this.TabPage01.Controls.Add(this.txtInput_CivCtIndexURL);
			this.TabPage01.Controls.Add(this.txtInput_LandIndexURL);
			this.TabPage01.Controls.Add(this.Label55);
			this.TabPage01.Controls.Add(this.Label24);
			this.TabPage01.Controls.Add(this.Label23);
			this.TabPage01.Controls.Add(this.Label22);
			this.TabPage01.Controls.Add(this.Label21);
			this.TabPage01.Controls.Add(this.Label18);
			this.TabPage01.Controls.Add(this.Label19);
			this.TabPage01.Controls.Add(this.Label20);
			this.TabPage01.Controls.Add(this.Label15);
			this.TabPage01.Controls.Add(this.Label16);
			this.TabPage01.Controls.Add(this.Label17);
			this.TabPage01.Controls.Add(this.Label11);
			this.TabPage01.Controls.Add(this.Label13);
			this.TabPage01.Controls.Add(this.Label14);
			this.TabPage01.Controls.Add(this.Label7);
			this.TabPage01.Controls.Add(this.Label9);
			this.TabPage01.Controls.Add(this.Label8);
			TabPage tabPage01 = this.TabPage01;
			.Location = new System.Drawing.Point(4, 22);
			tabPage01.Location = .Location;
			this.TabPage01.Name = "TabPage01";
			TabPage tabPage011 = this.TabPage01;
			.Padding = new System.Windows.Forms.Padding(3);
			tabPage011.Padding = .Padding;
			TabPage tabPage012 = this.TabPage01;
			.Size = new System.Drawing.Size(594, 373);
			tabPage012.Size = .Size;
			this.TabPage01.TabIndex = 2;
			this.TabPage01.Text = "WebURLSs & Logins";
			System.Windows.Forms.TextBox txtInputNotaryURL = this.txtInput_NotaryURL;
			.Location = new System.Drawing.Point(125, 430);
			txtInputNotaryURL.Location = .Location;
			this.txtInput_NotaryURL.Name = "txtInput_NotaryURL";
			System.Windows.Forms.TextBox txtInputNotaryURL1 = this.txtInput_NotaryURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputNotaryURL1.Size = .Size;
			this.txtInput_NotaryURL.TabIndex = 268;
			this.Label67.AutoSize = true;
			System.Windows.Forms.Label label67 = this.Label67;
			.Location = new System.Drawing.Point(59, 432);
			label67.Location = .Location;
			this.Label67.Name = "Label67";
			System.Windows.Forms.Label label671 = this.Label67;
			.Size = new System.Drawing.Size(63, 13);
			label671.Size = .Size;
			this.Label67.TabIndex = 269;
			this.Label67.Text = "Notary URL";
			System.Windows.Forms.TextBox txtInputStateCodeURL = this.txtInput_State_CodeURL;
			.Location = new System.Drawing.Point(125, 407);
			txtInputStateCodeURL.Location = .Location;
			this.txtInput_State_CodeURL.Name = "txtInput_State_CodeURL";
			System.Windows.Forms.TextBox txtInputStateCodeURL1 = this.txtInput_State_CodeURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputStateCodeURL1.Size = .Size;
			this.txtInput_State_CodeURL.TabIndex = 267;
			System.Windows.Forms.TextBox txtInputSecOfStateUrl = this.txtInput_Sec_of_State_url;
			.Location = new System.Drawing.Point(125, 384);
			txtInputSecOfStateUrl.Location = .Location;
			this.txtInput_Sec_of_State_url.Name = "txtInput_Sec_of_State_url";
			System.Windows.Forms.TextBox txtInputSecOfStateUrl1 = this.txtInput_Sec_of_State_url;
			.Size = new System.Drawing.Size(235, 20);
			txtInputSecOfStateUrl1.Size = .Size;
			this.txtInput_Sec_of_State_url.TabIndex = 266;
			System.Windows.Forms.TextBox txtInputDOIurl = this.txtInput_DOIurl;
			.Location = new System.Drawing.Point(125, 361);
			txtInputDOIurl.Location = .Location;
			this.txtInput_DOIurl.Name = "txtInput_DOIurl";
			System.Windows.Forms.TextBox txtInputDOIurl1 = this.txtInput_DOIurl;
			.Size = new System.Drawing.Size(235, 20);
			txtInputDOIurl1.Size = .Size;
			this.txtInput_DOIurl.TabIndex = 265;
			this.Label56.AutoSize = true;
			System.Windows.Forms.Label label56 = this.Label56;
			.Location = new System.Drawing.Point(59, 409);
			label56.Location = .Location;
			this.Label56.Name = "Label56";
			System.Windows.Forms.Label label561 = this.Label56;
			.Size = new System.Drawing.Size(60, 13);
			label561.Size = .Size;
			this.Label56.TabIndex = 263;
			this.Label56.Text = "State Code";
			this.Label62.AutoSize = true;
			System.Windows.Forms.Label label62 = this.Label62;
			.Location = new System.Drawing.Point(50, 386);
			label62.Location = .Location;
			this.Label62.Name = "Label62";
			System.Windows.Forms.Label label621 = this.Label62;
			.Size = new System.Drawing.Size(69, 13);
			label621.Size = .Size;
			this.Label62.TabIndex = 262;
			this.Label62.Text = "Sec. of State";
			this.Label63.AutoSize = true;
			System.Windows.Forms.Label label63 = this.Label63;
			.Location = new System.Drawing.Point(60, 363);
			label63.Location = .Location;
			this.Label63.Name = "Label63";
			System.Windows.Forms.Label label631 = this.Label63;
			.Size = new System.Drawing.Size(59, 13);
			label631.Size = .Size;
			this.Label63.TabIndex = 261;
			this.Label63.Text = "Dept of Ins";
			this.ckbxLoginRequired.AutoSize = true;
			this.ckbxLoginRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			System.Windows.Forms.CheckBox checkBox2 = this.ckbxLoginRequired;
			.Location = new System.Drawing.Point(515, 30);
			checkBox2.Location = .Location;
			this.ckbxLoginRequired.Name = "ckbxLoginRequired";
			System.Windows.Forms.CheckBox checkBox3 = this.ckbxLoginRequired;
			.Size = new System.Drawing.Size(73, 17);
			checkBox3.Size = .Size;
			this.ckbxLoginRequired.TabIndex = 111;
			this.ckbxLoginRequired.Text = "must login";
			this.ckbxLoginRequired.UseVisualStyleBackColor = true;
			this.Label33.AutoSize = true;
			System.Windows.Forms.Label label33 = this.Label33;
			.Location = new System.Drawing.Point(53, 316);
			label33.Location = .Location;
			this.Label33.Name = "Label33";
			System.Windows.Forms.Label label331 = this.Label33;
			.Size = new System.Drawing.Size(66, 13);
			label331.Size = .Size;
			this.Label33.TabIndex = 110;
			this.Label33.Text = "UCC Search";
			System.Windows.Forms.TextBox txtInputUCCUrl = this.txtInput_UCC_url;
			.Location = new System.Drawing.Point(125, 313);
			txtInputUCCUrl.Location = .Location;
			this.txtInput_UCC_url.Name = "txtInput_UCC_url";
			System.Windows.Forms.TextBox txtInputUCCUrl1 = this.txtInput_UCC_url;
			.Size = new System.Drawing.Size(235, 20);
			txtInputUCCUrl1.Size = .Size;
			this.txtInput_UCC_url.TabIndex = 64;
			System.Windows.Forms.TextBox txtInputOtherURLPwd = this.txtInput_OtherURLPwd;
			.Location = new System.Drawing.Point(442, 336);
			txtInputOtherURLPwd.Location = .Location;
			this.txtInput_OtherURLPwd.Name = "txtInput_OtherURLPwd";
			System.Windows.Forms.TextBox txtInputOtherURLPwd1 = this.txtInput_OtherURLPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputOtherURLPwd1.Size = .Size;
			this.txtInput_OtherURLPwd.TabIndex = 67;
			System.Windows.Forms.TextBox txtInputOtherURLUsername = this.txtInput_OtherURLUsername;
			.Location = new System.Drawing.Point(366, 336);
			txtInputOtherURLUsername.Location = .Location;
			this.txtInput_OtherURLUsername.Name = "txtInput_OtherURLUsername";
			System.Windows.Forms.TextBox txtInputOtherURLUsername1 = this.txtInput_OtherURLUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputOtherURLUsername1.Size = .Size;
			this.txtInput_OtherURLUsername.TabIndex = 66;
			System.Windows.Forms.TextBox txtInputProbatePwd = this.txtInput_ProbatePwd;
			.Location = new System.Drawing.Point(442, 225);
			txtInputProbatePwd.Location = .Location;
			this.txtInput_ProbatePwd.Name = "txtInput_ProbatePwd";
			System.Windows.Forms.TextBox txtInputProbatePwd1 = this.txtInput_ProbatePwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputProbatePwd1.Size = .Size;
			this.txtInput_ProbatePwd.TabIndex = 60;
			System.Windows.Forms.TextBox txtInputProbateUsername = this.txtInput_ProbateUsername;
			.Location = new System.Drawing.Point(366, 225);
			txtInputProbateUsername.Location = .Location;
			this.txtInput_ProbateUsername.Name = "txtInput_ProbateUsername";
			System.Windows.Forms.TextBox txtInputProbateUsername1 = this.txtInput_ProbateUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputProbateUsername1.Size = .Size;
			this.txtInput_ProbateUsername.TabIndex = 59;
			System.Windows.Forms.TextBox txtInputProthonPwd = this.txtInput_ProthonPwd;
			.Location = new System.Drawing.Point(442, 203);
			txtInputProthonPwd.Location = .Location;
			this.txtInput_ProthonPwd.Name = "txtInput_ProthonPwd";
			System.Windows.Forms.TextBox txtInputProthonPwd1 = this.txtInput_ProthonPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputProthonPwd1.Size = .Size;
			this.txtInput_ProthonPwd.TabIndex = 57;
			System.Windows.Forms.TextBox txtInputProthonUsername = this.txtInput_ProthonUsername;
			.Location = new System.Drawing.Point(366, 203);
			txtInputProthonUsername.Location = .Location;
			this.txtInput_ProthonUsername.Name = "txtInput_ProthonUsername";
			System.Windows.Forms.TextBox txtInputProthonUsername1 = this.txtInput_ProthonUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputProthonUsername1.Size = .Size;
			this.txtInput_ProthonUsername.TabIndex = 56;
			System.Windows.Forms.TextBox txtInputAssessorPwd = this.txtInput_AssessorPwd;
			.Location = new System.Drawing.Point(442, 137);
			txtInputAssessorPwd.Location = .Location;
			this.txtInput_AssessorPwd.Name = "txtInput_AssessorPwd";
			System.Windows.Forms.TextBox txtInputAssessorPwd1 = this.txtInput_AssessorPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputAssessorPwd1.Size = .Size;
			this.txtInput_AssessorPwd.TabIndex = 52;
			System.Windows.Forms.TextBox txtInputAssessorUsername = this.txtInput_AssessorUsername;
			.Location = new System.Drawing.Point(366, 137);
			txtInputAssessorUsername.Location = .Location;
			this.txtInput_AssessorUsername.Name = "txtInput_AssessorUsername";
			System.Windows.Forms.TextBox txtInputAssessorUsername1 = this.txtInput_AssessorUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputAssessorUsername1.Size = .Size;
			this.txtInput_AssessorUsername.TabIndex = 51;
			System.Windows.Forms.TextBox txtInputTaxLocalPwd = this.txtInput_TaxLocalPwd;
			.Location = new System.Drawing.Point(442, 115);
			txtInputTaxLocalPwd.Location = .Location;
			this.txtInput_TaxLocalPwd.Name = "txtInput_TaxLocalPwd";
			System.Windows.Forms.TextBox txtInputTaxLocalPwd1 = this.txtInput_TaxLocalPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputTaxLocalPwd1.Size = .Size;
			this.txtInput_TaxLocalPwd.TabIndex = 49;
			System.Windows.Forms.TextBox txtInputTaxLocalUsername = this.txtInput_TaxLocalUsername;
			.Location = new System.Drawing.Point(366, 115);
			txtInputTaxLocalUsername.Location = .Location;
			this.txtInput_TaxLocalUsername.Name = "txtInput_TaxLocalUsername";
			System.Windows.Forms.TextBox txtInputTaxLocalUsername1 = this.txtInput_TaxLocalUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputTaxLocalUsername1.Size = .Size;
			this.txtInput_TaxLocalUsername.TabIndex = 48;
			System.Windows.Forms.TextBox txtInputTaxCountyPwd = this.txtInput_TaxCountyPwd;
			.Location = new System.Drawing.Point(442, 93);
			txtInputTaxCountyPwd.Location = .Location;
			this.txtInput_TaxCountyPwd.Name = "txtInput_TaxCountyPwd";
			System.Windows.Forms.TextBox txtInputTaxCountyPwd1 = this.txtInput_TaxCountyPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputTaxCountyPwd1.Size = .Size;
			this.txtInput_TaxCountyPwd.TabIndex = 46;
			System.Windows.Forms.TextBox txtInputTaxCountyUsername = this.txtInput_TaxCountyUsername;
			.Location = new System.Drawing.Point(366, 93);
			txtInputTaxCountyUsername.Location = .Location;
			this.txtInput_TaxCountyUsername.Name = "txtInput_TaxCountyUsername";
			System.Windows.Forms.TextBox txtInputTaxCountyUsername1 = this.txtInput_TaxCountyUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputTaxCountyUsername1.Size = .Size;
			this.txtInput_TaxCountyUsername.TabIndex = 45;
			System.Windows.Forms.TextBox txtInputMuniCtPwd = this.txtInput_MuniCtPwd;
			.Location = new System.Drawing.Point(442, 71);
			txtInputMuniCtPwd.Location = .Location;
			this.txtInput_MuniCtPwd.Name = "txtInput_MuniCtPwd";
			System.Windows.Forms.TextBox txtInputMuniCtPwd1 = this.txtInput_MuniCtPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputMuniCtPwd1.Size = .Size;
			this.txtInput_MuniCtPwd.TabIndex = 43;
			System.Windows.Forms.TextBox txtInputMuniCtUsername = this.txtInput_MuniCtUsername;
			.Location = new System.Drawing.Point(366, 71);
			txtInputMuniCtUsername.Location = .Location;
			this.txtInput_MuniCtUsername.Name = "txtInput_MuniCtUsername";
			System.Windows.Forms.TextBox txtInputMuniCtUsername1 = this.txtInput_MuniCtUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputMuniCtUsername1.Size = .Size;
			this.txtInput_MuniCtUsername.TabIndex = 42;
			System.Windows.Forms.TextBox txtInputCivCtPwd = this.txtInput_CivCtPwd;
			.Location = new System.Drawing.Point(442, 49);
			txtInputCivCtPwd.Location = .Location;
			this.txtInput_CivCtPwd.Name = "txtInput_CivCtPwd";
			System.Windows.Forms.TextBox txtInputCivCtPwd1 = this.txtInput_CivCtPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputCivCtPwd1.Size = .Size;
			this.txtInput_CivCtPwd.TabIndex = 40;
			System.Windows.Forms.TextBox txtInputCivCtUsername = this.txtInput_CivCtUsername;
			.Location = new System.Drawing.Point(366, 49);
			txtInputCivCtUsername.Location = .Location;
			this.txtInput_CivCtUsername.Name = "txtInput_CivCtUsername";
			System.Windows.Forms.TextBox txtInputCivCtUsername1 = this.txtInput_CivCtUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputCivCtUsername1.Size = .Size;
			this.txtInput_CivCtUsername.TabIndex = 39;
			System.Windows.Forms.TextBox txtInputLandPwd = this.txtInput_LandPwd;
			.Location = new System.Drawing.Point(442, 27);
			txtInputLandPwd.Location = .Location;
			this.txtInput_LandPwd.Name = "txtInput_LandPwd";
			System.Windows.Forms.TextBox txtInputLandPwd1 = this.txtInput_LandPwd;
			.Size = new System.Drawing.Size(70, 20);
			txtInputLandPwd1.Size = .Size;
			this.txtInput_LandPwd.TabIndex = 37;
			System.Windows.Forms.TextBox txtInputLandUsername = this.txtInput_LandUsername;
			.Location = new System.Drawing.Point(366, 27);
			txtInputLandUsername.Location = .Location;
			this.txtInput_LandUsername.Name = "txtInput_LandUsername";
			System.Windows.Forms.TextBox txtInputLandUsername1 = this.txtInput_LandUsername;
			.Size = new System.Drawing.Size(70, 20);
			txtInputLandUsername1.Size = .Size;
			this.txtInput_LandUsername.TabIndex = 36;
			System.Windows.Forms.TextBox txtInputOtherURL = this.txtInput_OtherURL;
			.Location = new System.Drawing.Point(125, 335);
			txtInputOtherURL.Location = .Location;
			this.txtInput_OtherURL.Name = "txtInput_OtherURL";
			System.Windows.Forms.TextBox txtInputOtherURL1 = this.txtInput_OtherURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputOtherURL1.Size = .Size;
			this.txtInput_OtherURL.TabIndex = 65;
			System.Windows.Forms.TextBox txtInputCountyHomeURL = this.txtInput_CountyHomeURL;
			.Location = new System.Drawing.Point(125, 291);
			txtInputCountyHomeURL.Location = .Location;
			this.txtInput_CountyHomeURL.Name = "txtInput_CountyHomeURL";
			System.Windows.Forms.TextBox txtInputCountyHomeURL1 = this.txtInput_CountyHomeURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputCountyHomeURL1.Size = .Size;
			this.txtInput_CountyHomeURL.TabIndex = 63;
			System.Windows.Forms.TextBox txtInputForeclosureURL = this.txtInput_ForeclosureURL;
			.Location = new System.Drawing.Point(125, 269);
			txtInputForeclosureURL.Location = .Location;
			this.txtInput_ForeclosureURL.Name = "txtInput_ForeclosureURL";
			System.Windows.Forms.TextBox txtInputForeclosureURL1 = this.txtInput_ForeclosureURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputForeclosureURL1.Size = .Size;
			this.txtInput_ForeclosureURL.TabIndex = 62;
			System.Windows.Forms.TextBox txtInputSheriffURL = this.txtInput_SheriffURL;
			.Location = new System.Drawing.Point(125, 247);
			txtInputSheriffURL.Location = .Location;
			this.txtInput_SheriffURL.Name = "txtInput_SheriffURL";
			System.Windows.Forms.TextBox txtInputSheriffURL1 = this.txtInput_SheriffURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputSheriffURL1.Size = .Size;
			this.txtInput_SheriffURL.TabIndex = 61;
			System.Windows.Forms.TextBox txtInputProbateURL = this.txtInput_ProbateURL;
			.Location = new System.Drawing.Point(125, 225);
			txtInputProbateURL.Location = .Location;
			this.txtInput_ProbateURL.Name = "txtInput_ProbateURL";
			System.Windows.Forms.TextBox txtInputProbateURL1 = this.txtInput_ProbateURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputProbateURL1.Size = .Size;
			this.txtInput_ProbateURL.TabIndex = 58;
			System.Windows.Forms.TextBox txtInputProthonURL = this.txtInput_ProthonURL;
			.Location = new System.Drawing.Point(125, 203);
			txtInputProthonURL.Location = .Location;
			this.txtInput_ProthonURL.Name = "txtInput_ProthonURL";
			System.Windows.Forms.TextBox txtInputProthonURL1 = this.txtInput_ProthonURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputProthonURL1.Size = .Size;
			this.txtInput_ProthonURL.TabIndex = 55;
			System.Windows.Forms.TextBox txtInputMapURL = this.txtInput_MapURL;
			.Location = new System.Drawing.Point(125, 181);
			txtInputMapURL.Location = .Location;
			this.txtInput_MapURL.Name = "txtInput_MapURL";
			System.Windows.Forms.TextBox txtInputMapURL1 = this.txtInput_MapURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputMapURL1.Size = .Size;
			this.txtInput_MapURL.TabIndex = 54;
			System.Windows.Forms.TextBox txtInputPlatsURL = this.txtInput_PlatsURL;
			.Location = new System.Drawing.Point(125, 159);
			txtInputPlatsURL.Location = .Location;
			this.txtInput_PlatsURL.Name = "txtInput_PlatsURL";
			System.Windows.Forms.TextBox txtInputPlatsURL1 = this.txtInput_PlatsURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputPlatsURL1.Size = .Size;
			this.txtInput_PlatsURL.TabIndex = 53;
			System.Windows.Forms.TextBox txtInputAssessorURL = this.txtInput_AssessorURL;
			.Location = new System.Drawing.Point(125, 137);
			txtInputAssessorURL.Location = .Location;
			this.txtInput_AssessorURL.Name = "txtInput_AssessorURL";
			System.Windows.Forms.TextBox txtInputAssessorURL1 = this.txtInput_AssessorURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputAssessorURL1.Size = .Size;
			this.txtInput_AssessorURL.TabIndex = 50;
			System.Windows.Forms.TextBox txtInputTax2URL = this.txtInput_Tax2URL;
			.Location = new System.Drawing.Point(125, 115);
			txtInputTax2URL.Location = .Location;
			this.txtInput_Tax2URL.Name = "txtInput_Tax2URL";
			System.Windows.Forms.TextBox txtInputTax2URL1 = this.txtInput_Tax2URL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputTax2URL1.Size = .Size;
			this.txtInput_Tax2URL.TabIndex = 47;
			System.Windows.Forms.TextBox txtInputTaxCountyURL = this.txtInput_TaxCountyURL;
			.Location = new System.Drawing.Point(125, 93);
			txtInputTaxCountyURL.Location = .Location;
			this.txtInput_TaxCountyURL.Name = "txtInput_TaxCountyURL";
			System.Windows.Forms.TextBox txtInputTaxCountyURL1 = this.txtInput_TaxCountyURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputTaxCountyURL1.Size = .Size;
			this.txtInput_TaxCountyURL.TabIndex = 44;
			System.Windows.Forms.TextBox txtInputMuniCtURL = this.txtInput_MuniCtURL;
			.Location = new System.Drawing.Point(125, 71);
			txtInputMuniCtURL.Location = .Location;
			this.txtInput_MuniCtURL.Name = "txtInput_MuniCtURL";
			System.Windows.Forms.TextBox txtInputMuniCtURL1 = this.txtInput_MuniCtURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputMuniCtURL1.Size = .Size;
			this.txtInput_MuniCtURL.TabIndex = 41;
			System.Windows.Forms.TextBox txtInputCivCtIndexURL = this.txtInput_CivCtIndexURL;
			.Location = new System.Drawing.Point(125, 49);
			txtInputCivCtIndexURL.Location = .Location;
			this.txtInput_CivCtIndexURL.Name = "txtInput_CivCtIndexURL";
			System.Windows.Forms.TextBox txtInputCivCtIndexURL1 = this.txtInput_CivCtIndexURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputCivCtIndexURL1.Size = .Size;
			this.txtInput_CivCtIndexURL.TabIndex = 38;
			System.Windows.Forms.TextBox txtInputLandIndexURL = this.txtInput_LandIndexURL;
			.Location = new System.Drawing.Point(125, 27);
			txtInputLandIndexURL.Location = .Location;
			this.txtInput_LandIndexURL.Name = "txtInput_LandIndexURL";
			System.Windows.Forms.TextBox txtInputLandIndexURL1 = this.txtInput_LandIndexURL;
			.Size = new System.Drawing.Size(235, 20);
			txtInputLandIndexURL1.Size = .Size;
			this.txtInput_LandIndexURL.TabIndex = 35;
			this.Label55.AutoSize = true;
			System.Windows.Forms.Label label55 = this.Label55;
			.Location = new System.Drawing.Point(122, 11);
			label55.Location = .Location;
			this.Label55.Name = "Label55";
			System.Windows.Forms.Label label551 = this.Label55;
			.Size = new System.Drawing.Size(150, 13);
			label551.Size = .Size;
			this.Label55.TabIndex = 108;
			this.Label55.Text = "Website URL (http:// or www)";
			this.Label24.AutoSize = true;
			System.Windows.Forms.Label label24 = this.Label24;
			.Location = new System.Drawing.Point(450, 11);
			label24.Location = .Location;
			this.Label24.Name = "Label24";
			System.Windows.Forms.Label label241 = this.Label24;
			.Size = new System.Drawing.Size(53, 13);
			label241.Size = .Size;
			this.Label24.TabIndex = 80;
			this.Label24.Text = "Password";
			this.Label23.AutoSize = true;
			System.Windows.Forms.Label label23 = this.Label23;
			.Location = new System.Drawing.Point(373, 11);
			label23.Location = .Location;
			this.Label23.Name = "Label23";
			System.Windows.Forms.Label label231 = this.Label23;
			.Size = new System.Drawing.Size(55, 13);
			label231.Size = .Size;
			this.Label23.TabIndex = 79;
			this.Label23.Text = "Username";
			this.Label22.AutoSize = true;
			System.Windows.Forms.Label label22 = this.Label22;
			.Location = new System.Drawing.Point(86, 339);
			label22.Location = .Location;
			this.Label22.Name = "Label22";
			System.Windows.Forms.Label label221 = this.Label22;
			.Size = new System.Drawing.Size(33, 13);
			label221.Size = .Size;
			this.Label22.TabIndex = 76;
			this.Label22.Text = "Other";
			this.Label21.AutoSize = true;
			System.Windows.Forms.Label label21 = this.Label21;
			.Location = new System.Drawing.Point(33, 118);
			label21.Location = .Location;
			this.Label21.Name = "Label21";
			System.Windows.Forms.Label label211 = this.Label21;
			.Size = new System.Drawing.Size(86, 13);
			label211.Size = .Size;
			this.Label21.TabIndex = 75;
			this.Label21.Text = "Tax Web (Local)";
			this.Label18.AutoSize = true;
			System.Windows.Forms.Label label18 = this.Label18;
			.Location = new System.Drawing.Point(66, 184);
			label18.Location = .Location;
			this.Label18.Name = "Label18";
			System.Windows.Forms.Label label181 = this.Label18;
			.Size = new System.Drawing.Size(53, 13);
			label181.Size = .Size;
			this.Label18.TabIndex = 58;
			this.Label18.Text = "MAP/GIS";
			this.Label19.AutoSize = true;
			System.Windows.Forms.Label label19 = this.Label19;
			.Location = new System.Drawing.Point(75, 228);
			label19.Location = .Location;
			this.Label19.Name = "Label19";
			System.Windows.Forms.Label label191 = this.Label19;
			.Size = new System.Drawing.Size(44, 13);
			label191.Size = .Size;
			this.Label19.TabIndex = 60;
			this.Label19.Text = "Probate";
			this.Label20.AutoSize = true;
			System.Windows.Forms.Label label20 = this.Label20;
			.Location = new System.Drawing.Point(52, 206);
			label20.Location = .Location;
			this.Label20.Name = "Label20";
			System.Windows.Forms.Label label201 = this.Label20;
			.Size = new System.Drawing.Size(67, 13);
			label201.Size = .Size;
			this.Label20.TabIndex = 59;
			this.Label20.Text = "Prothonotary";
			this.Label15.AutoSize = true;
			System.Windows.Forms.Label label15 = this.Label15;
			.Location = new System.Drawing.Point(82, 250);
			label15.Location = .Location;
			this.Label15.Name = "Label15";
			System.Windows.Forms.Label label151 = this.Label15;
			.Size = new System.Drawing.Size(37, 13);
			label151.Size = .Size;
			this.Label15.TabIndex = 55;
			this.Label15.Text = "Sheriff";
			this.Label16.AutoSize = true;
			System.Windows.Forms.Label label16 = this.Label16;
			.Location = new System.Drawing.Point(24, 294);
			label16.Location = .Location;
			this.Label16.Name = "Label16";
			System.Windows.Forms.Label label161 = this.Label16;
			.Size = new System.Drawing.Size(95, 13);
			label161.Size = .Size;
			this.Label16.TabIndex = 57;
			this.Label16.Text = "County Homepage";
			this.Label17.AutoSize = true;
			System.Windows.Forms.Label label17 = this.Label17;
			.Location = new System.Drawing.Point(52, 272);
			label17.Location = .Location;
			this.Label17.Name = "Label17";
			System.Windows.Forms.Label label171 = this.Label17;
			.Size = new System.Drawing.Size(67, 13);
			label171.Size = .Size;
			this.Label17.TabIndex = 56;
			this.Label17.Text = "Foreclosures";
			this.Label11.AutoSize = true;
			System.Windows.Forms.Label label111 = this.Label11;
			.Location = new System.Drawing.Point(26, 96);
			label111.Location = .Location;
			this.Label11.Name = "Label11";
			System.Windows.Forms.Label label112 = this.Label11;
			.Size = new System.Drawing.Size(93, 13);
			label112.Size = .Size;
			this.Label11.TabIndex = 52;
			this.Label11.Text = "Tax Web (County)";
			this.Label13.AutoSize = true;
			System.Windows.Forms.Label label13 = this.Label13;
			.Location = new System.Drawing.Point(89, 162);
			label13.Location = .Location;
			this.Label13.Name = "Label13";
			System.Windows.Forms.Label label131 = this.Label13;
			.Size = new System.Drawing.Size(30, 13);
			label131.Size = .Size;
			this.Label13.TabIndex = 54;
			this.Label13.Text = "Plats";
			this.Label14.AutoSize = true;
			System.Windows.Forms.Label label14 = this.Label14;
			.Location = new System.Drawing.Point(70, 140);
			label14.Location = .Location;
			this.Label14.Name = "Label14";
			System.Windows.Forms.Label label141 = this.Label14;
			.Size = new System.Drawing.Size(49, 13);
			label141.Size = .Size;
			this.Label14.TabIndex = 53;
			this.Label14.Text = "Assessor";
			this.Label7.AutoSize = true;
			System.Windows.Forms.Label label71 = this.Label7;
			.Location = new System.Drawing.Point(59, 30);
			label71.Location = .Location;
			this.Label7.Name = "Label7";
			System.Windows.Forms.Label label72 = this.Label7;
			.Size = new System.Drawing.Size(60, 13);
			label72.Size = .Size;
			this.Label7.TabIndex = 49;
			this.Label7.Text = "Land Index";
			this.Label9.AutoSize = true;
			System.Windows.Forms.Label label9 = this.Label9;
			.Location = new System.Drawing.Point(10, 74);
			label9.Location = .Location;
			this.Label9.Name = "Label9";
			System.Windows.Forms.Label label95 = this.Label9;
			.Size = new System.Drawing.Size(109, 13);
			label95.Size = .Size;
			this.Label9.TabIndex = 51;
			this.Label9.Text = "Municipal Court Index";
			this.Label8.AutoSize = true;
			System.Windows.Forms.Label label8 = this.Label8;
			.Location = new System.Drawing.Point(36, 52);
			label8.Location = .Location;
			this.Label8.Name = "Label8";
			System.Windows.Forms.Label label84 = this.Label8;
			.Size = new System.Drawing.Size(83, 13);
			label84.Size = .Size;
			this.Label8.TabIndex = 50;
			this.Label8.Text = "Civil Court Index";
			this.TabPage05.BackColor = Color.AliceBlue;
			this.TabPage05.Controls.Add(this.Label40);
			this.TabPage05.Controls.Add(this.Label39);
			this.TabPage05.Controls.Add(this.txtInput_PlatImageDate);
			this.TabPage05.Controls.Add(this.txtInput_MuniCourtImageDate);
			this.TabPage05.Controls.Add(this.txtInput_CivCourtImageDate);
			this.TabPage05.Controls.Add(this.txtInput_LandImageDate);
			this.TabPage05.Controls.Add(this.txtInput_PlatIndexDate);
			this.TabPage05.Controls.Add(this.txtInput_MuniCourtIndexDate);
			this.TabPage05.Controls.Add(this.txtInput_CivCourtIndexDate);
			this.TabPage05.Controls.Add(this.txtInput_LandIndexDate);
			this.TabPage05.Controls.Add(this.Label34);
			this.TabPage05.Controls.Add(this.Label36);
			this.TabPage05.Controls.Add(this.Label37);
			this.TabPage05.Controls.Add(this.Label38);
			this.TabPage05.Controls.Add(this.ckbxProdTaxReports);
			this.TabPage05.Controls.Add(this.Label3);
			this.TabPage05.Controls.Add(this.ckbxProdDocRet);
			this.TabPage05.Controls.Add(this.ckbxProdIns);
			this.TabPage05.Controls.Add(this.ckbxProdPropReports);
			TabPage tabPage05 = this.TabPage05;
			.Location = new System.Drawing.Point(4, 22);
			tabPage05.Location = .Location;
			this.TabPage05.Name = "TabPage05";
			TabPage tabPage051 = this.TabPage05;
			.Padding = new System.Windows.Forms.Padding(3);
			tabPage051.Padding = .Padding;
			TabPage tabPage052 = this.TabPage05;
			.Size = new System.Drawing.Size(594, 373);
			tabPage052.Size = .Size;
			this.TabPage05.TabIndex = 1;
			this.TabPage05.Text = "Products & Index Dates";
			this.Label40.AutoSize = true;
			System.Windows.Forms.Label label40 = this.Label40;
			.Location = new System.Drawing.Point(162, 172);
			label40.Location = .Location;
			this.Label40.Name = "Label40";
			System.Windows.Forms.Label label401 = this.Label40;
			.Size = new System.Drawing.Size(59, 13);
			label401.Size = .Size;
			this.Label40.TabIndex = 134;
			this.Label40.Text = "Index Date";
			this.Label39.AutoSize = true;
			System.Windows.Forms.Label label39 = this.Label39;
			.Location = new System.Drawing.Point(259, 172);
			label39.Location = .Location;
			this.Label39.Name = "Label39";
			System.Windows.Forms.Label label391 = this.Label39;
			.Size = new System.Drawing.Size(67, 13);
			label391.Size = .Size;
			this.Label39.TabIndex = 133;
			this.Label39.Text = "Images Date";
			System.Windows.Forms.TextBox txtInputPlatImageDate = this.txtInput_PlatImageDate;
			.Location = new System.Drawing.Point(253, 263);
			txtInputPlatImageDate.Location = .Location;
			this.txtInput_PlatImageDate.Name = "txtInput_PlatImageDate";
			System.Windows.Forms.TextBox txtInputPlatImageDate1 = this.txtInput_PlatImageDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputPlatImageDate1.Size = .Size;
			this.txtInput_PlatImageDate.TabIndex = 34;
			System.Windows.Forms.TextBox txtInputMuniCourtImageDate = this.txtInput_MuniCourtImageDate;
			.Location = new System.Drawing.Point(253, 238);
			txtInputMuniCourtImageDate.Location = .Location;
			this.txtInput_MuniCourtImageDate.Name = "txtInput_MuniCourtImageDate";
			System.Windows.Forms.TextBox txtInputMuniCourtImageDate1 = this.txtInput_MuniCourtImageDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputMuniCourtImageDate1.Size = .Size;
			this.txtInput_MuniCourtImageDate.TabIndex = 32;
			System.Windows.Forms.TextBox txtInputCivCourtImageDate = this.txtInput_CivCourtImageDate;
			.Location = new System.Drawing.Point(253, 213);
			txtInputCivCourtImageDate.Location = .Location;
			this.txtInput_CivCourtImageDate.Name = "txtInput_CivCourtImageDate";
			System.Windows.Forms.TextBox txtInputCivCourtImageDate1 = this.txtInput_CivCourtImageDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputCivCourtImageDate1.Size = .Size;
			this.txtInput_CivCourtImageDate.TabIndex = 30;
			System.Windows.Forms.TextBox txtInputLandImageDate = this.txtInput_LandImageDate;
			.Location = new System.Drawing.Point(253, 188);
			txtInputLandImageDate.Location = .Location;
			this.txtInput_LandImageDate.Name = "txtInput_LandImageDate";
			System.Windows.Forms.TextBox txtInputLandImageDate1 = this.txtInput_LandImageDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputLandImageDate1.Size = .Size;
			this.txtInput_LandImageDate.TabIndex = 28;
			System.Windows.Forms.TextBox txtInputPlatIndexDate = this.txtInput_PlatIndexDate;
			.Location = new System.Drawing.Point(151, 263);
			txtInputPlatIndexDate.Location = .Location;
			this.txtInput_PlatIndexDate.Name = "txtInput_PlatIndexDate";
			System.Windows.Forms.TextBox txtInputPlatIndexDate1 = this.txtInput_PlatIndexDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputPlatIndexDate1.Size = .Size;
			this.txtInput_PlatIndexDate.TabIndex = 33;
			System.Windows.Forms.TextBox txtInputMuniCourtIndexDate = this.txtInput_MuniCourtIndexDate;
			.Location = new System.Drawing.Point(151, 238);
			txtInputMuniCourtIndexDate.Location = .Location;
			this.txtInput_MuniCourtIndexDate.Name = "txtInput_MuniCourtIndexDate";
			System.Windows.Forms.TextBox txtInputMuniCourtIndexDate1 = this.txtInput_MuniCourtIndexDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputMuniCourtIndexDate1.Size = .Size;
			this.txtInput_MuniCourtIndexDate.TabIndex = 31;
			System.Windows.Forms.TextBox txtInputCivCourtIndexDate = this.txtInput_CivCourtIndexDate;
			.Location = new System.Drawing.Point(151, 213);
			txtInputCivCourtIndexDate.Location = .Location;
			this.txtInput_CivCourtIndexDate.Name = "txtInput_CivCourtIndexDate";
			System.Windows.Forms.TextBox txtInputCivCourtIndexDate1 = this.txtInput_CivCourtIndexDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputCivCourtIndexDate1.Size = .Size;
			this.txtInput_CivCourtIndexDate.TabIndex = 29;
			System.Windows.Forms.TextBox txtInputLandIndexDate = this.txtInput_LandIndexDate;
			.Location = new System.Drawing.Point(151, 188);
			txtInputLandIndexDate.Location = .Location;
			this.txtInput_LandIndexDate.Name = "txtInput_LandIndexDate";
			System.Windows.Forms.TextBox txtInputLandIndexDate1 = this.txtInput_LandIndexDate;
			.Size = new System.Drawing.Size(86, 20);
			txtInputLandIndexDate1.Size = .Size;
			this.txtInput_LandIndexDate.TabIndex = 27;
			this.Label34.AutoSize = true;
			System.Windows.Forms.Label label34 = this.Label34;
			.Location = new System.Drawing.Point(115, 266);
			label34.Location = .Location;
			this.Label34.Name = "Label34";
			System.Windows.Forms.Label label341 = this.Label34;
			.Size = new System.Drawing.Size(30, 13);
			label341.Size = .Size;
			this.Label34.TabIndex = 124;
			this.Label34.Text = "Plats";
			this.Label36.AutoSize = true;
			System.Windows.Forms.Label label36 = this.Label36;
			.Location = new System.Drawing.Point(85, 191);
			label36.Location = .Location;
			this.Label36.Name = "Label36";
			System.Windows.Forms.Label label361 = this.Label36;
			.Size = new System.Drawing.Size(60, 13);
			label361.Size = .Size;
			this.Label36.TabIndex = 121;
			this.Label36.Text = "Land Index";
			this.Label37.AutoSize = true;
			System.Windows.Forms.Label label37 = this.Label37;
			.Location = new System.Drawing.Point(36, 241);
			label37.Location = .Location;
			this.Label37.Name = "Label37";
			System.Windows.Forms.Label label371 = this.Label37;
			.Size = new System.Drawing.Size(109, 13);
			label371.Size = .Size;
			this.Label37.TabIndex = 123;
			this.Label37.Text = "Municipal Court Index";
			this.Label38.AutoSize = true;
			System.Windows.Forms.Label label38 = this.Label38;
			.Location = new System.Drawing.Point(62, 216);
			label38.Location = .Location;
			this.Label38.Name = "Label38";
			System.Windows.Forms.Label label381 = this.Label38;
			.Size = new System.Drawing.Size(83, 13);
			label381.Size = .Size;
			this.Label38.TabIndex = 122;
			this.Label38.Text = "Civil Court Index";
			this.ckbxProdTaxReports.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox4 = this.ckbxProdTaxReports;
			.Location = new System.Drawing.Point(151, 128);
			checkBox4.Location = .Location;
			this.ckbxProdTaxReports.Name = "ckbxProdTaxReports";
			System.Windows.Forms.CheckBox checkBox5 = this.ckbxProdTaxReports;
			.Size = new System.Drawing.Size(84, 17);
			checkBox5.Size = .Size;
			this.ckbxProdTaxReports.TabIndex = 26;
			this.ckbxProdTaxReports.Text = "Tax Reports";
			this.ckbxProdTaxReports.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			System.Windows.Forms.Label label310 = this.Label3;
			.Location = new System.Drawing.Point(130, 39);
			label310.Location = .Location;
			this.Label3.Name = "Label3";
			System.Windows.Forms.Label label10 = this.Label3;
			.Size = new System.Drawing.Size(267, 13);
			label10.Size = .Size;
			this.Label3.TabIndex = 45;
			this.Label3.Text = "iMS Products that can be completed online in this area:";
			this.ckbxProdDocRet.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox6 = this.ckbxProdDocRet;
			.Location = new System.Drawing.Point(151, 64);
			checkBox6.Location = .Location;
			this.ckbxProdDocRet.Name = "ckbxProdDocRet";
			System.Windows.Forms.CheckBox checkBox7 = this.ckbxProdDocRet;
			.Size = new System.Drawing.Size(91, 17);
			checkBox7.Size = .Size;
			this.ckbxProdDocRet.TabIndex = 23;
			this.ckbxProdDocRet.Text = "Doc Retrieval";
			this.ckbxProdDocRet.UseVisualStyleBackColor = true;
			this.ckbxProdIns.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox8 = this.ckbxProdIns;
			.Location = new System.Drawing.Point(151, 85);
			checkBox8.Location = .Location;
			this.ckbxProdIns.Name = "ckbxProdIns";
			System.Windows.Forms.CheckBox checkBox9 = this.ckbxProdIns;
			.Size = new System.Drawing.Size(73, 17);
			checkBox9.Size = .Size;
			this.ckbxProdIns.TabIndex = 24;
			this.ckbxProdIns.Text = "Insurance";
			this.ckbxProdIns.UseVisualStyleBackColor = true;
			this.ckbxProdPropReports.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox10 = this.ckbxProdPropReports;
			.Location = new System.Drawing.Point(151, 105);
			checkBox10.Location = .Location;
			this.ckbxProdPropReports.Name = "ckbxProdPropReports";
			System.Windows.Forms.CheckBox checkBox11 = this.ckbxProdPropReports;
			.Size = new System.Drawing.Size(100, 17);
			checkBox11.Size = .Size;
			this.ckbxProdPropReports.TabIndex = 25;
			this.ckbxProdPropReports.Text = "Property reports";
			this.ckbxProdPropReports.UseVisualStyleBackColor = true;
			this.TabPage06.BackColor = Color.AliceBlue;
			this.TabPage06.Controls.Add(this.txtInput_Copy_Pmt_Method);
			this.TabPage06.Controls.Add(this.txtInput_Index_Pmt_Method);
			this.TabPage06.Controls.Add(this.txtInput_SubscripTerm);
			this.TabPage06.Controls.Add(this.txtInput_CopySource);
			this.TabPage06.Controls.Add(this.txtInput_LandIndexSource);
			this.TabPage06.Controls.Add(this.txtInput_SubscripFeeAmt);
			this.TabPage06.Controls.Add(this.txtCopyFeeAmount);
			this.TabPage06.Controls.Add(this.txtInput_Comments);
			this.TabPage06.Controls.Add(this.label61);
			this.TabPage06.Controls.Add(this.ckbxSubscripIsFree);
			this.TabPage06.Controls.Add(this.ckbxWeAreSubscribed);
			this.TabPage06.Controls.Add(this.ckbxSubscripNeeded);
			this.TabPage06.Controls.Add(this.Label43);
			this.TabPage06.Controls.Add(this.Label42);
			this.TabPage06.Controls.Add(this.Label84);
			this.TabPage06.Controls.Add(this.Label80);
			this.TabPage06.Controls.Add(this.Label78);
			this.TabPage06.Controls.Add(this.Label10);
			this.TabPage06.Controls.Add(this.ckbxUseTapestry);
			this.TabPage06.Controls.Add(this.ckbxUseDatatree);
			this.TabPage06.Controls.Add(this.Label6);
			this.TabPage06.Controls.Add(this.ckbxUseRedVision);
			this.TabPage06.Controls.Add(this.Label2);
			TabPage tabPage06 = this.TabPage06;
			.Location = new System.Drawing.Point(4, 22);
			tabPage06.Location = .Location;
			this.TabPage06.Name = "TabPage06";
			TabPage tabPage061 = this.TabPage06;
			.Padding = new System.Windows.Forms.Padding(3);
			tabPage061.Padding = .Padding;
			TabPage tabPage062 = this.TabPage06;
			.Size = new System.Drawing.Size(594, 373);
			tabPage062.Size = .Size;
			this.TabPage06.TabIndex = 0;
			this.TabPage06.Text = "Subscription Info";
			System.Windows.Forms.TextBox txtInputCopyPmtMethod = this.txtInput_Copy_Pmt_Method;
			.Location = new System.Drawing.Point(269, 143);
			txtInputCopyPmtMethod.Location = .Location;
			this.txtInput_Copy_Pmt_Method.Name = "txtInput_Copy_Pmt_Method";
			System.Windows.Forms.TextBox txtInputCopyPmtMethod1 = this.txtInput_Copy_Pmt_Method;
			.Size = new System.Drawing.Size(100, 20);
			txtInputCopyPmtMethod1.Size = .Size;
			this.txtInput_Copy_Pmt_Method.TabIndex = 19;
			System.Windows.Forms.TextBox txtInputIndexPmtMethod = this.txtInput_Index_Pmt_Method;
			.Location = new System.Drawing.Point(420, 103);
			txtInputIndexPmtMethod.Location = .Location;
			this.txtInput_Index_Pmt_Method.Name = "txtInput_Index_Pmt_Method";
			System.Windows.Forms.TextBox txtInputIndexPmtMethod1 = this.txtInput_Index_Pmt_Method;
			.Size = new System.Drawing.Size(100, 20);
			txtInputIndexPmtMethod1.Size = .Size;
			this.txtInput_Index_Pmt_Method.TabIndex = 16;
			System.Windows.Forms.TextBox txtInputSubscripTerm = this.txtInput_SubscripTerm;
			.Location = new System.Drawing.Point(164, 104);
			txtInputSubscripTerm.Location = .Location;
			this.txtInput_SubscripTerm.Name = "txtInput_SubscripTerm";
			System.Windows.Forms.TextBox txtInputSubscripTerm1 = this.txtInput_SubscripTerm;
			.Size = new System.Drawing.Size(139, 20);
			txtInputSubscripTerm1.Size = .Size;
			this.txtInput_SubscripTerm.TabIndex = 14;
			System.Windows.Forms.TextBox txtInputCopySource = this.txtInput_CopySource;
			.Location = new System.Drawing.Point(16, 144);
			txtInputCopySource.Location = .Location;
			this.txtInput_CopySource.Name = "txtInput_CopySource";
			System.Windows.Forms.TextBox txtInputCopySource1 = this.txtInput_CopySource;
			.Size = new System.Drawing.Size(139, 20);
			txtInputCopySource1.Size = .Size;
			this.txtInput_CopySource.TabIndex = 17;
			System.Windows.Forms.TextBox txtInputLandIndexSource = this.txtInput_LandIndexSource;
			.Location = new System.Drawing.Point(16, 105);
			txtInputLandIndexSource.Location = .Location;
			this.txtInput_LandIndexSource.Name = "txtInput_LandIndexSource";
			System.Windows.Forms.TextBox txtInputLandIndexSource1 = this.txtInput_LandIndexSource;
			.Size = new System.Drawing.Size(139, 20);
			txtInputLandIndexSource1.Size = .Size;
			this.txtInput_LandIndexSource.TabIndex = 13;
			System.Windows.Forms.TextBox txtInputSubscripFeeAmt = this.txtInput_SubscripFeeAmt;
			.Location = new System.Drawing.Point(309, 103);
			txtInputSubscripFeeAmt.Location = .Location;
			this.txtInput_SubscripFeeAmt.Name = "txtInput_SubscripFeeAmt";
			System.Windows.Forms.TextBox txtInputSubscripFeeAmt1 = this.txtInput_SubscripFeeAmt;
			.Size = new System.Drawing.Size(100, 20);
			txtInputSubscripFeeAmt1.Size = .Size;
			this.txtInput_SubscripFeeAmt.TabIndex = 15;
			System.Windows.Forms.TextBox textBox1 = this.txtCopyFeeAmount;
			.Location = new System.Drawing.Point(164, 144);
			textBox1.Location = .Location;
			this.txtCopyFeeAmount.Name = "txtCopyFeeAmount";
			System.Windows.Forms.TextBox textBox2 = this.txtCopyFeeAmount;
			.Size = new System.Drawing.Size(100, 20);
			textBox2.Size = .Size;
			this.txtCopyFeeAmount.TabIndex = 18;
			System.Windows.Forms.TextBox txtInputComments = this.txtInput_Comments;
			.Location = new System.Drawing.Point(19, 258);
			txtInputComments.Location = .Location;
			this.txtInput_Comments.Multiline = true;
			this.txtInput_Comments.Name = "txtInput_Comments";
			this.txtInput_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputComments1 = this.txtInput_Comments;
			.Size = new System.Drawing.Size(493, 72);
			txtInputComments1.Size = .Size;
			this.txtInput_Comments.TabIndex = 23;
			this.label61.AutoSize = true;
			System.Windows.Forms.Label label43 = this.label61;
			.Location = new System.Drawing.Point(269, 128);
			label43.Location = .Location;
			this.label61.Name = "label61";
			System.Windows.Forms.Label label52 = this.label61;
			.Size = new System.Drawing.Size(94, 13);
			label52.Size = .Size;
			this.label61.TabIndex = 71;
			this.label61.Text = "Copy Pmt Method:";
			this.ckbxSubscripIsFree.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox12 = this.ckbxSubscripIsFree;
			.Location = new System.Drawing.Point(16, 55);
			checkBox12.Location = .Location;
			this.ckbxSubscripIsFree.Name = "ckbxSubscripIsFree";
			System.Windows.Forms.CheckBox checkBox13 = this.ckbxSubscripIsFree;
			.Size = new System.Drawing.Size(115, 17);
			checkBox13.Size = .Size;
			this.ckbxSubscripIsFree.TabIndex = 12;
			this.ckbxSubscripIsFree.Text = "Subscription is free";
			this.ckbxSubscripIsFree.UseVisualStyleBackColor = true;
			this.ckbxWeAreSubscribed.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox14 = this.ckbxWeAreSubscribed;
			.Location = new System.Drawing.Point(16, 32);
			checkBox14.Location = .Location;
			this.ckbxWeAreSubscribed.Name = "ckbxWeAreSubscribed";
			System.Windows.Forms.CheckBox checkBox15 = this.ckbxWeAreSubscribed;
			.Size = new System.Drawing.Size(117, 17);
			checkBox15.Size = .Size;
			this.ckbxWeAreSubscribed.TabIndex = 11;
			this.ckbxWeAreSubscribed.Text = "We are Subscribed";
			this.ckbxWeAreSubscribed.UseVisualStyleBackColor = true;
			this.ckbxSubscripNeeded.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox16 = this.ckbxSubscripNeeded;
			.Location = new System.Drawing.Point(16, 11);
			checkBox16.Location = .Location;
			this.ckbxSubscripNeeded.Name = "ckbxSubscripNeeded";
			System.Windows.Forms.CheckBox checkBox17 = this.ckbxSubscripNeeded;
			.Size = new System.Drawing.Size(125, 17);
			checkBox17.Size = .Size;
			this.ckbxSubscripNeeded.TabIndex = 10;
			this.ckbxSubscripNeeded.Text = "Subscription Needed";
			this.ckbxSubscripNeeded.UseVisualStyleBackColor = true;
			this.Label43.AutoSize = true;
			System.Windows.Forms.Label label431 = this.Label43;
			.Location = new System.Drawing.Point(16, 88);
			label431.Location = .Location;
			this.Label43.Name = "Label43";
			System.Windows.Forms.Label label432 = this.Label43;
			.Size = new System.Drawing.Size(100, 13);
			label432.Size = .Size;
			this.Label43.TabIndex = 69;
			this.Label43.Text = "Land Index Source:";
			this.Label42.AutoSize = true;
			System.Windows.Forms.Label label421 = this.Label42;
			.Location = new System.Drawing.Point(16, 128);
			label421.Location = .Location;
			this.Label42.Name = "Label42";
			System.Windows.Forms.Label label422 = this.Label42;
			.Size = new System.Drawing.Size(71, 13);
			label422.Size = .Size;
			this.Label42.TabIndex = 68;
			this.Label42.Text = "Copy Source:";
			this.Label84.AutoSize = true;
			System.Windows.Forms.Label label841 = this.Label84;
			.Location = new System.Drawing.Point(16, 242);
			label841.Location = .Location;
			this.Label84.Name = "Label84";
			System.Windows.Forms.Label label842 = this.Label84;
			.Size = new System.Drawing.Size(59, 13);
			label842.Size = .Size;
			this.Label84.TabIndex = 65;
			this.Label84.Text = "Comments:";
			this.Label80.AutoSize = true;
			System.Windows.Forms.Label label80 = this.Label80;
			.Location = new System.Drawing.Point(164, 128);
			label80.Location = .Location;
			this.Label80.Name = "Label80";
			System.Windows.Forms.Label label801 = this.Label80;
			.Size = new System.Drawing.Size(57, 13);
			label801.Size = .Size;
			this.Label80.TabIndex = 64;
			this.Label80.Text = "Copy Fees";
			this.Label78.AutoSize = true;
			System.Windows.Forms.Label label78 = this.Label78;
			.Location = new System.Drawing.Point(309, 87);
			label78.Location = .Location;
			this.Label78.Name = "Label78";
			System.Windows.Forms.Label label781 = this.Label78;
			.Size = new System.Drawing.Size(86, 13);
			label781.Size = .Size;
			this.Label78.TabIndex = 63;
			this.Label78.Text = "Subscription Fee";
			this.Label10.AutoSize = true;
			System.Windows.Forms.Label label101 = this.Label10;
			.Location = new System.Drawing.Point(164, 88);
			label101.Location = .Location;
			this.Label10.Name = "Label10";
			System.Windows.Forms.Label label102 = this.Label10;
			.Size = new System.Drawing.Size(137, 13);
			label102.Size = .Size;
			this.Label10.TabIndex = 53;
			this.Label10.Text = "Land Index Subscrip. Term:";
			this.ckbxUseTapestry.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox18 = this.ckbxUseTapestry;
			.Location = new System.Drawing.Point(190, 226);
			checkBox18.Location = .Location;
			this.ckbxUseTapestry.Name = "ckbxUseTapestry";
			System.Windows.Forms.CheckBox checkBox19 = this.ckbxUseTapestry;
			.Size = new System.Drawing.Size(67, 17);
			checkBox19.Size = .Size;
			this.ckbxUseTapestry.TabIndex = 22;
			this.ckbxUseTapestry.Text = "Tapestry";
			this.ckbxUseTapestry.UseVisualStyleBackColor = true;
			this.ckbxUseDatatree.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox20 = this.ckbxUseDatatree;
			.Location = new System.Drawing.Point(190, 205);
			checkBox20.Location = .Location;
			this.ckbxUseDatatree.Name = "ckbxUseDatatree";
			System.Windows.Forms.CheckBox checkBox21 = this.ckbxUseDatatree;
			.Size = new System.Drawing.Size(67, 17);
			checkBox21.Size = .Size;
			this.ckbxUseDatatree.TabIndex = 21;
			this.ckbxUseDatatree.Text = "Datatree";
			this.ckbxUseDatatree.UseVisualStyleBackColor = true;
			this.Label6.AutoSize = true;
			System.Windows.Forms.Label label61 = this.Label6;
			.Location = new System.Drawing.Point(420, 87);
			label61.Location = .Location;
			this.Label6.Name = "Label6";
			System.Windows.Forms.Label label64 = this.Label6;
			.Size = new System.Drawing.Size(135, 13);
			label64.Size = .Size;
			this.Label6.TabIndex = 48;
			this.Label6.Text = "Index Subscr. Pmt Method:";
			this.ckbxUseRedVision.AutoSize = true;
			System.Windows.Forms.CheckBox checkBox22 = this.ckbxUseRedVision;
			.Location = new System.Drawing.Point(190, 184);
			checkBox22.Location = .Location;
			this.ckbxUseRedVision.Name = "ckbxUseRedVision";
			System.Windows.Forms.CheckBox checkBox23 = this.ckbxUseRedVision;
			.Size = new System.Drawing.Size(74, 17);
			checkBox23.Size = .Size;
			this.ckbxUseRedVision.TabIndex = 20;
			this.ckbxUseRedVision.Text = "RedVision";
			this.ckbxUseRedVision.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			System.Windows.Forms.Label label210 = this.Label2;
			.Location = new System.Drawing.Point(16, 184);
			label210.Location = .Location;
			this.Label2.Name = "Label2";
			System.Windows.Forms.Label label212 = this.Label2;
			.Size = new System.Drawing.Size(151, 13);
			label212.Size = .Size;
			this.Label2.TabIndex = 38;
			this.Label2.Text = "Data Providers with Coverage:";
			this.TabControl1.Controls.Add(this.TabPage06);
			this.TabControl1.Controls.Add(this.TabPage05);
			this.TabControl1.Controls.Add(this.TabPage01);
			this.TabControl1.Controls.Add(this.TabPage03);
			this.TabControl1.Controls.Add(this.TabPage07);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
			TabControl tabControl1 = this.TabControl1;
			.Location = new System.Drawing.Point(168, 0);
			tabControl1.Location = .Location;
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			TabControl tabControl = this.TabControl1;
			.Size = new System.Drawing.Size(602, 399);
			tabControl.Size = .Size;
			this.TabControl1.TabIndex = 55;
			this.TabPage1.BackColor = Color.AliceBlue;
			this.TabPage1.Controls.Add(this.ckbx_Homestead);
			this.TabPage1.Controls.Add(this.cbox_DeedPrep);
			this.TabPage1.Controls.Add(this.Label52);
			this.TabPage1.Controls.Add(this.Label69);
			this.TabPage1.Controls.Add(this.txtInput_AttyNotes);
			this.TabPage1.Controls.Add(this.Label68);
			this.TabPage1.Controls.Add(this.txtInput_PolicyNotes);
			this.TabPage1.Controls.Add(this.ckbx_AttyCloser);
			this.TabPage1.Controls.Add(this.ckbx_AttyTitleSearch);
			this.TabPage1.Controls.Add(this.ckbx_BeingClause);
			this.TabPage1.Controls.Add(this.Label66);
			this.TabPage1.Controls.Add(this.txtInput_DeedNotes);
			this.TabPage1.Controls.Add(this.Label65);
			this.TabPage1.Controls.Add(this.txtInput_HomesteadNotes);
			this.TabPage1.Controls.Add(this.Label64);
			this.TabPage1.Controls.Add(this.txtInput_ForeclosureNotes);
			this.TabPage1.Controls.Add(this.Label58);
			this.TabPage1.Controls.Add(this.txtInput_ProbateNotes);
			TabPage tabPage11 = this.TabPage1;
			.Location = new System.Drawing.Point(4, 22);
			tabPage11.Location = .Location;
			this.TabPage1.Name = "TabPage1";
			TabPage tabPage12 = this.TabPage1;
			.Padding = new System.Windows.Forms.Padding(3);
			tabPage12.Padding = .Padding;
			TabPage tabPage2 = this.TabPage1;
			.Size = new System.Drawing.Size(594, 373);
			tabPage2.Size = .Size;
			this.TabPage1.TabIndex = 7;
			this.TabPage1.Text = "Misc.";
			this.ckbx_Homestead.AutoSize = true;
			System.Windows.Forms.CheckBox ckbxHomestead = this.ckbx_Homestead;
			.Location = new System.Drawing.Point(318, 10);
			ckbxHomestead.Location = .Location;
			this.ckbx_Homestead.Name = "ckbx_Homestead";
			System.Windows.Forms.CheckBox ckbxHomestead1 = this.ckbx_Homestead;
			.Size = new System.Drawing.Size(167, 17);
			ckbxHomestead1.Size = .Size;
			this.ckbx_Homestead.TabIndex = 268;
			this.ckbx_Homestead.Text = "State Recognizes Homestead";
			this.ckbx_Homestead.UseVisualStyleBackColor = true;
			this.cbox_DeedPrep.FormattingEnabled = true;
			ComboBox.ObjectCollection items1 = this.cbox_DeedPrep.Items;
			objArray = new object[] { "ATTY", "ATTY recommended", "IMS", "PARTY or ATTY" };
			items1.AddRange(objArray);
			ComboBox cboxDeedPrep = this.cbox_DeedPrep;
			.Location = new System.Drawing.Point(320, 55);
			cboxDeedPrep.Location = .Location;
			this.cbox_DeedPrep.Name = "cbox_DeedPrep";
			ComboBox cboxDeedPrep1 = this.cbox_DeedPrep;
			.Size = new System.Drawing.Size(121, 21);
			cboxDeedPrep1.Size = .Size;
			this.cbox_DeedPrep.TabIndex = 267;
			this.Label52.AutoSize = true;
			System.Windows.Forms.Label label521 = this.Label52;
			.Location = new System.Drawing.Point(317, 38);
			label521.Location = .Location;
			this.Label52.Name = "Label52";
			System.Windows.Forms.Label label522 = this.Label52;
			.Size = new System.Drawing.Size(109, 13);
			label522.Size = .Size;
			this.Label52.TabIndex = 266;
			this.Label52.Text = "Who prepares deeds:";
			this.Label69.AutoSize = true;
			System.Windows.Forms.Label label69 = this.Label69;
			.Location = new System.Drawing.Point(34, 94);
			label69.Location = .Location;
			this.Label69.Name = "Label69";
			System.Windows.Forms.Label label691 = this.Label69;
			.Size = new System.Drawing.Size(80, 13);
			label691.Size = .Size;
			this.Label69.TabIndex = 265;
			this.Label69.Text = "Attorney Notes:";
			System.Windows.Forms.TextBox txtInputAttyNotes = this.txtInput_AttyNotes;
			.Location = new System.Drawing.Point(36, 109);
			txtInputAttyNotes.Location = .Location;
			this.txtInput_AttyNotes.Multiline = true;
			this.txtInput_AttyNotes.Name = "txtInput_AttyNotes";
			this.txtInput_AttyNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputAttyNotes1 = this.txtInput_AttyNotes;
			.Size = new System.Drawing.Size(265, 65);
			txtInputAttyNotes1.Size = .Size;
			this.txtInput_AttyNotes.TabIndex = 258;
			this.Label68.AutoSize = true;
			System.Windows.Forms.Label label68 = this.Label68;
			.Location = new System.Drawing.Point(35, 184);
			label68.Location = .Location;
			this.Label68.Name = "Label68";
			System.Windows.Forms.Label label681 = this.Label68;
			.Size = new System.Drawing.Size(115, 13);
			label681.Size = .Size;
			this.Label68.TabIndex = 263;
			this.Label68.Text = "Policy Issuance Notes:";
			System.Windows.Forms.TextBox txtInputPolicyNotes = this.txtInput_PolicyNotes;
			.Location = new System.Drawing.Point(37, 199);
			txtInputPolicyNotes.Location = .Location;
			this.txtInput_PolicyNotes.Multiline = true;
			this.txtInput_PolicyNotes.Name = "txtInput_PolicyNotes";
			this.txtInput_PolicyNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputPolicyNotes1 = this.txtInput_PolicyNotes;
			.Size = new System.Drawing.Size(263, 69);
			txtInputPolicyNotes1.Size = .Size;
			this.txtInput_PolicyNotes.TabIndex = 259;
			this.ckbx_AttyCloser.AutoSize = true;
			System.Windows.Forms.CheckBox ckbxAttyCloser = this.ckbx_AttyCloser;
			.Location = new System.Drawing.Point(36, 57);
			ckbxAttyCloser.Location = .Location;
			this.ckbx_AttyCloser.Name = "ckbx_AttyCloser";
			System.Windows.Forms.CheckBox ckbxAttyCloser1 = this.ckbx_AttyCloser;
			.Size = new System.Drawing.Size(141, 17);
			ckbxAttyCloser1.Size = .Size;
			this.ckbx_AttyCloser.TabIndex = 257;
			this.ckbx_AttyCloser.Text = "Attorney must close loan";
			this.ckbx_AttyCloser.UseVisualStyleBackColor = true;
			this.ckbx_AttyTitleSearch.AutoSize = true;
			System.Windows.Forms.CheckBox ckbxAttyTitleSearch = this.ckbx_AttyTitleSearch;
			.Location = new System.Drawing.Point(36, 34);
			ckbxAttyTitleSearch.Location = .Location;
			this.ckbx_AttyTitleSearch.Name = "ckbx_AttyTitleSearch";
			System.Windows.Forms.CheckBox ckbxAttyTitleSearch1 = this.ckbx_AttyTitleSearch;
			.Size = new System.Drawing.Size(263, 17);
			ckbxAttyTitleSearch1.Size = .Size;
			this.ckbx_AttyTitleSearch.TabIndex = 256;
			this.ckbx_AttyTitleSearch.Text = "Attorney Opinion of Title Required (Insurance only)";
			this.ckbx_AttyTitleSearch.UseVisualStyleBackColor = true;
			this.ckbx_BeingClause.AutoSize = true;
			System.Windows.Forms.CheckBox ckbxBeingClause = this.ckbx_BeingClause;
			.Location = new System.Drawing.Point(36, 11);
			ckbxBeingClause.Location = .Location;
			this.ckbx_BeingClause.Name = "ckbx_BeingClause";
			System.Windows.Forms.CheckBox ckbxBeingClause1 = this.ckbx_BeingClause;
			.Size = new System.Drawing.Size(202, 17);
			ckbxBeingClause1.Size = .Size;
			this.ckbx_BeingClause.TabIndex = 255;
			this.ckbx_BeingClause.Text = "Being Clause Required (legal descrip)";
			this.ckbx_BeingClause.UseVisualStyleBackColor = true;
			this.Label66.AutoSize = true;
			System.Windows.Forms.Label label66 = this.Label66;
			.Location = new System.Drawing.Point(316, 280);
			label66.Location = .Location;
			this.Label66.Name = "Label66";
			System.Windows.Forms.Label label661 = this.Label66;
			.Size = new System.Drawing.Size(92, 13);
			label661.Size = .Size;
			this.Label66.TabIndex = 136;
			this.Label66.Text = "Deed Prep Notes:";
			System.Windows.Forms.TextBox txtInputDeedNotes = this.txtInput_DeedNotes;
			.Location = new System.Drawing.Point(318, 295);
			txtInputDeedNotes.Location = .Location;
			this.txtInput_DeedNotes.Multiline = true;
			this.txtInput_DeedNotes.Name = "txtInput_DeedNotes";
			this.txtInput_DeedNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputDeedNotes1 = this.txtInput_DeedNotes;
			.Size = new System.Drawing.Size(263, 63);
			txtInputDeedNotes1.Size = .Size;
			this.txtInput_DeedNotes.TabIndex = 263;
			this.Label65.AutoSize = true;
			System.Windows.Forms.Label label65 = this.Label65;
			.Location = new System.Drawing.Point(316, 184);
			label65.Location = .Location;
			this.Label65.Name = "Label65";
			System.Windows.Forms.Label label651 = this.Label65;
			.Size = new System.Drawing.Size(95, 13);
			label651.Size = .Size;
			this.Label65.TabIndex = 134;
			this.Label65.Text = "Homestead Notes:";
			System.Windows.Forms.TextBox txtInputHomesteadNotes = this.txtInput_HomesteadNotes;
			.Location = new System.Drawing.Point(318, 199);
			txtInputHomesteadNotes.Location = .Location;
			this.txtInput_HomesteadNotes.Multiline = true;
			this.txtInput_HomesteadNotes.Name = "txtInput_HomesteadNotes";
			this.txtInput_HomesteadNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputHomesteadNotes1 = this.txtInput_HomesteadNotes;
			.Size = new System.Drawing.Size(263, 69);
			txtInputHomesteadNotes1.Size = .Size;
			this.txtInput_HomesteadNotes.TabIndex = 262;
			this.Label64.AutoSize = true;
			System.Windows.Forms.Label label641 = this.Label64;
			.Location = new System.Drawing.Point(317, 94);
			label641.Location = .Location;
			this.Label64.Name = "Label64";
			System.Windows.Forms.Label label642 = this.Label64;
			.Size = new System.Drawing.Size(96, 13);
			label642.Size = .Size;
			this.Label64.TabIndex = 132;
			this.Label64.Text = "Foreclosure Notes:";
			System.Windows.Forms.TextBox txtInputForeclosureNotes = this.txtInput_ForeclosureNotes;
			.Location = new System.Drawing.Point(319, 109);
			txtInputForeclosureNotes.Location = .Location;
			this.txtInput_ForeclosureNotes.Multiline = true;
			this.txtInput_ForeclosureNotes.Name = "txtInput_ForeclosureNotes";
			this.txtInput_ForeclosureNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputForeclosureNotes1 = this.txtInput_ForeclosureNotes;
			.Size = new System.Drawing.Size(263, 65);
			txtInputForeclosureNotes1.Size = .Size;
			this.txtInput_ForeclosureNotes.TabIndex = 261;
			this.Label58.AutoSize = true;
			System.Windows.Forms.Label label58 = this.Label58;
			.Location = new System.Drawing.Point(36, 280);
			label58.Location = .Location;
			this.Label58.Name = "Label58";
			System.Windows.Forms.Label label581 = this.Label58;
			.Size = new System.Drawing.Size(78, 13);
			label581.Size = .Size;
			this.Label58.TabIndex = 130;
			this.Label58.Text = "Probate Notes:";
			System.Windows.Forms.TextBox txtInputProbateNotes = this.txtInput_ProbateNotes;
			.Location = new System.Drawing.Point(38, 295);
			txtInputProbateNotes.Location = .Location;
			this.txtInput_ProbateNotes.Multiline = true;
			this.txtInput_ProbateNotes.Name = "txtInput_ProbateNotes";
			this.txtInput_ProbateNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			System.Windows.Forms.TextBox txtInputProbateNotes1 = this.txtInput_ProbateNotes;
			.Size = new System.Drawing.Size(263, 65);
			txtInputProbateNotes1.Size = .Size;
			this.txtInput_ProbateNotes.TabIndex = 260;
			this.lblOpenORB.AutoSize = true;
			this.lblOpenORB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			System.Windows.Forms.Label label70 = this.lblOpenORB;
			.Location = new System.Drawing.Point(38, 375);
			label70.Location = .Location;
			this.lblOpenORB.Name = "lblOpenORB";
			System.Windows.Forms.Label label86 = this.lblOpenORB;
			.Size = new System.Drawing.Size(113, 15);
			label86.Size = .Size;
			this.lblOpenORB.TabIndex = 190;
			this.lblOpenORB.Text = "Edit ORB Database";
			this.lblOpenORB.Visible = false;
			this.pboxOpenORB.Image = Resources.xls_icon;
			PictureBox pictureBox = this.pboxOpenORB;
			.Location = new System.Drawing.Point(7, 370);
			pictureBox.Location = .Location;
			this.pboxOpenORB.Name = "pboxOpenORB";
			PictureBox pictureBox1 = this.pboxOpenORB;
			.Size = new System.Drawing.Size(23, 25);
			pictureBox1.Size = .Size;
			this.pboxOpenORB.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pboxOpenORB.TabIndex = 189;
			this.pboxOpenORB.TabStop = false;
			this.pboxOpenORB.Tag = "ORB_database";
			this.pboxOpenORB.Visible = false;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Honeydew;
			.Size = new System.Drawing.Size(820, 399);
			this.ClientSize = .Size;
			this.Controls.Add(this.lblOpenORB);
			this.Controls.Add(this.pboxOpenORB);
			this.Controls.Add(this.Button_ExitApp);
			this.Controls.Add(this.Button_Reset);
			this.Controls.Add(this.cboxTaxAuthType_EditORB);
			this.Controls.Add(this.Label29);
			this.Controls.Add(this.Label27);
			this.Controls.Add(this.cboxTaxAuth_EditORB);
			this.Controls.Add(this.Button_SEARCH);
			this.Controls.Add(this.Label25);
			this.Controls.Add(this.Button_EXITupdates);
			this.Controls.Add(this.Button_SAVE);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cboxState_EditORB);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.cboxCounty_EditORB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "frm_Edit";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit ORB Database";
			this.TabPage07.ResumeLayout(false);
			this.TabPage07.PerformLayout();
			this.TabPage03.ResumeLayout(false);
			this.TabPage03.PerformLayout();
			this.TabPage01.ResumeLayout(false);
			this.TabPage01.PerformLayout();
			this.TabPage05.ResumeLayout(false);
			this.TabPage05.PerformLayout();
			this.TabPage06.ResumeLayout(false);
			this.TabPage06.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			((ISupportInitialize)this.pboxOpenORB).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void lblOpenORB_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ORB_DATABASE.xls");
		}

		private void pboxOpenORB_Click(object sender, EventArgs e)
		{
			Process.Start("T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ORB_DATABASE.xls");
		}

		private void pboxOpenORB_MouseHover(object sender, EventArgs e)
		{
			this.ToolTip1.SetToolTip(this.pboxOpenORB, "CLICK TO EDIT");
		}

		private void resetInputs()
		{
			this.txtInput_CopySource.ResetText();
			this.txtInput_LandIndexSource.ResetText();
			this.txtCopyFeeAmount.ResetText();
			this.txtInput_SubscripFeeAmt.ResetText();
			this.txtInput_SubscripTerm.ResetText();
			this.txtInput_Index_Pmt_Method.ResetText();
			this.txtInput_Comments.ResetText();
			this.ckbxSubscripNeeded.CheckState = CheckState.Unchecked;
			this.ckbxWeAreSubscribed.CheckState = CheckState.Unchecked;
			this.ckbxUseDatatree.CheckState = CheckState.Unchecked;
			this.ckbxUseRedVision.CheckState = CheckState.Unchecked;
			this.ckbxUseTapestry.CheckState = CheckState.Unchecked;
			this.ckbxProdDocRet.CheckState = CheckState.Unchecked;
			this.ckbxProdIns.CheckState = CheckState.Unchecked;
			this.ckbxProdPropReports.CheckState = CheckState.Unchecked;
			this.ckbxProdTaxReports.CheckState = CheckState.Unchecked;
			this.txtInput_CivCourtIndexDate.ResetText();
			this.txtInput_LandIndexDate.ResetText();
			this.txtInput_CivCourtImageDate.ResetText();
			this.txtInput_LandImageDate.ResetText();
			this.txtInput_MuniCourtImageDate.ResetText();
			this.txtInput_MuniCourtIndexDate.ResetText();
			this.txtInput_PlatImageDate.ResetText();
			this.txtInput_PlatIndexDate.ResetText();
			this.txtInput_LandIndexURL.ResetText();
			this.txtInput_CivCtIndexURL.ResetText();
			this.txtInput_TaxCountyURL.ResetText();
			this.txtInput_ProthonURL.ResetText();
			this.txtInput_AssessorURL.ResetText();
			this.txtInput_MapURL.ResetText();
			this.txtInput_ProbateURL.ResetText();
			this.txtInput_CountyHomeURL.ResetText();
			this.txtInput_ForeclosureURL.ResetText();
			this.txtInput_PlatsURL.ResetText();
			this.txtInput_MuniCtURL.ResetText();
			this.txtInput_Tax2URL.ResetText();
			this.txtInput_SheriffURL.ResetText();
			this.txtInput_LandUsername.ResetText();
			this.txtInput_LandPwd.ResetText();
			this.txtInput_CivCtUsername.ResetText();
			this.txtInput_CivCtPwd.ResetText();
			this.txtInput_TaxCountyUsername.ResetText();
			this.txtInput_TaxCountyPwd.ResetText();
			this.txtInput_ProthonUsername.ResetText();
			this.txtInput_ProthonPwd.ResetText();
			this.txtInput_LandImageDate.ResetText();
			this.txtInput_LandIndexDate.ResetText();
			this.ckbxUseRedVision.Checked = false;
			this.txtInput_NewTaxState.ResetText();
			this.txtInput_NewTaxCounty.ResetText();
			this.txt_TaxDateVerified.ResetText();
			this.txtInput_TaxAuthType.ResetText();
			this.txtInput_TaxAuthName.ResetText();
			this.txtInput_TaxPayeeName.ResetText();
			this.txtInput_TaxPayeeStr1.ResetText();
			this.txtInput_LocalTaxURL.ResetText();
			this.txtInput_TaxPayeeStr2.ResetText();
			this.txtInput_TaxPayeeCity.ResetText();
			this.txtInput_TaxPayeeState.ResetText();
			this.txtInput_TaxPayeeZip.ResetText();
			this.txtInput_TaxPayeePhone.ResetText();
			this.txtInput_TaxPayeeFax.ResetText();
			this.txtInput_TaxOfficeHours.ResetText();
			this.txtInput_TaxCertFee.ResetText();
			this.txtInput_TaxCertTAT.ResetText();
			this.txtInput_TaxDueDates.ResetText();
			this.txtInput_TaxComments.ResetText();
			this.chkbxTaxCertRequired.Checked = false;
			this.txtInput_SOL_MtgRD.ResetText();
			this.txtInput_SOL_MtgAM.ResetText();
			this.txtInput_SOL_HelocAM.ResetText();
			this.txtInput_SOL_HelocRD.ResetText();
			this.txtInput_SOL_MechLiens.ResetText();
			this.txtInput_SOL_Notice.ResetText();
			this.txtInput_SOL_LisPendens.ResetText();
			this.txtInput_SOL_HOALien.ResetText();
			this.txtInput_SOL_HospLien.ResetText();
			this.txtInput_SOL_ClaimOfLien.ResetText();
			this.txtInput_SOL_Jgmt.ResetText();
			this.txtInput_SOL_SupportObl.ResetText();
			this.txtInput_SOL_StateJgmt.ResetText();
			this.txtInput_SOL_AfterAcquired.ResetText();
			this.txtInput_SOL_TE_Rule.ResetText();
			this.txtInput_SOL_CreditorClaims.ResetText();
			this.txtInput_SOL_PersonalTax.ResetText();
			this.txtInput_SOL_ForeclosureRedem.ResetText();
			this.txtInput_SOL_SpousalState.ResetText();
			this.txtSOL_notes.ResetText();
		}

		private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphics = e.Graphics;
			TabPage item = this.TabControl1.TabPages[e.Index];
			StringFormat stringFormat = new StringFormat();
			float x = (float)e.Bounds.X;
			float y = (float)(checked(e.Bounds.Y + 2));
			float width = (float)e.Bounds.Width;
			System.Drawing.Rectangle bounds = e.Bounds;
			RectangleF rectangleF = new RectangleF(x, y, width, (float)(checked(bounds.Height - 2)));
			stringFormat.Alignment = StringAlignment.Center;
			string text = item.Text;
			Brush solidBrush = new SolidBrush(item.BackColor);
			graphics.FillRectangle(solidBrush, e.Bounds);
			solidBrush = new SolidBrush(item.ForeColor);
			graphics.DrawString(text, this.TabControl1.Font, solidBrush, rectangleF, stringFormat);
		}
	}
}