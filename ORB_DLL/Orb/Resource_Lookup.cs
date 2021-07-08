using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace ORB_DLL.Orb
{
	public class Resource_Lookup
	{
		private string _ins;

		private string _props;

		private string _doc_retrieval;

		private string _subscrFeeAmt;

		private string _subscr_term;

		private string _subscribed;

		private string _sub_need;

		private string _tap;

		private string _rv;

		private string _dtree_desk;

		private string _img_date;

		private string _copy_source;

		private string _copyFeeAmt;

		private string _copy_pmt_method;

		private string _index_date;

		private string _index_source;

		private string _index_pmt_method;

		private string _land_url;

		private string _county_user;

		private string _county_pwd;

		private string _login_required;

		private string _court_url;

		private string _court_user;

		private string _court_pwd;

		private string _courtIndexDate;

		private string _courtImageDate;

		private string _muniCourt_url;

		private string _muniCourt_user;

		private string _muniCourt_pwd;

		private string _tax_url;

		private string _tax_user;

		private string _tax_pwd;

		private string _tax2_url;

		private string _tax2_user;

		private string _tax2_pwd;

		private string _prothon_url;

		private string _pro_user;

		private string _pro_pwd;

		private string _assessor_url;

		private string _assessor_user;

		private string _assessor_pwd;

		private string _probate_url;

		private string _probate_user;

		private string _probate_pwd;

		private string _other_url;

		private string _other_user;

		private string _other_pwd;

		private string _ucc_url;

		private string _map_url;

		private string _plat_url;

		private string _foreclosure_url;

		private string _sheriff_url;

		private string _county_homepage;

		private string _comments;

		public string assessor_pwd
		{
			get
			{
				return this._assessor_pwd;
			}
			set
			{
				this._assessor_pwd = value;
			}
		}

		public string assessor_url
		{
			get
			{
				return this._assessor_url;
			}
			set
			{
				this._assessor_url = value;
			}
		}

		public string assessor_user
		{
			get
			{
				return this._assessor_user;
			}
			set
			{
				this._assessor_user = value;
			}
		}

		public string comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				this._comments = value;
			}
		}

		public string copy_pmt_method
		{
			get
			{
				return this._copy_pmt_method;
			}
			set
			{
				this._copy_pmt_method = value;
			}
		}

		public string copy_source
		{
			get
			{
				return this._copy_source;
			}
			set
			{
				this._copy_source = value;
			}
		}

		public string copyFeeAmt
		{
			get
			{
				return this._copyFeeAmt;
			}
			set
			{
				this._copyFeeAmt = value;
			}
		}

		public string county_homepage
		{
			get
			{
				return this._county_homepage;
			}
			set
			{
				this._county_homepage = value;
			}
		}

		public string county_pwd
		{
			get
			{
				return this._county_pwd;
			}
			set
			{
				this._county_pwd = value;
			}
		}

		public string county_user
		{
			get
			{
				return this._county_user;
			}
			set
			{
				this._county_user = value;
			}
		}

		public string court_pwd
		{
			get
			{
				return this._court_pwd;
			}
			set
			{
				this._court_pwd = value;
			}
		}

		public string court_url
		{
			get
			{
				return this._court_url;
			}
			set
			{
				this._court_url = value;
			}
		}

		public string court_user
		{
			get
			{
				return this._court_user;
			}
			set
			{
				this._court_user = value;
			}
		}

		public string courtImageDate
		{
			get
			{
				return this._courtImageDate;
			}
			set
			{
				this._courtImageDate = value;
			}
		}

		public string courtIndexDate
		{
			get
			{
				return this._courtIndexDate;
			}
			set
			{
				this._courtIndexDate = value;
			}
		}

		public string doc_retrieval
		{
			get
			{
				return this._doc_retrieval;
			}
			set
			{
				this._doc_retrieval = value;
			}
		}

		public string dtree_desk
		{
			get
			{
				return this._dtree_desk;
			}
			set
			{
				this._dtree_desk = value;
			}
		}

		public string foreclosure_url
		{
			get
			{
				return this._foreclosure_url;
			}
			set
			{
				this._foreclosure_url = value;
			}
		}

		public string img_date
		{
			get
			{
				return this._img_date;
			}
			set
			{
				this._img_date = value;
			}
		}

		public string index_date
		{
			get
			{
				return this._index_date;
			}
			set
			{
				this._index_date = value;
			}
		}

		public string index_pmt_method
		{
			get
			{
				return this._index_pmt_method;
			}
			set
			{
				this._index_pmt_method = value;
			}
		}

		public string index_source
		{
			get
			{
				return this._index_source;
			}
			set
			{
				this._index_source = value;
			}
		}

		public string ins
		{
			get
			{
				return this._ins;
			}
			set
			{
				this._ins = value;
			}
		}

		public string land_url
		{
			get
			{
				return this._land_url;
			}
			set
			{
				this._land_url = value;
			}
		}

		public string login_required
		{
			get
			{
				return this._login_required;
			}
			set
			{
				this._login_required = value;
			}
		}

		public string map_url
		{
			get
			{
				return this._map_url;
			}
			set
			{
				this._map_url = value;
			}
		}

		public string muniCourt_pwd
		{
			get
			{
				return this._muniCourt_pwd;
			}
			set
			{
				this._muniCourt_pwd = value;
			}
		}

		public string muniCourt_url
		{
			get
			{
				return this._muniCourt_url;
			}
			set
			{
				this._muniCourt_url = value;
			}
		}

		public string muniCourt_user
		{
			get
			{
				return this._muniCourt_user;
			}
			set
			{
				this._muniCourt_user = value;
			}
		}

		public string other_pwd
		{
			get
			{
				return this._other_pwd;
			}
			set
			{
				this._other_pwd = value;
			}
		}

		public string other_url
		{
			get
			{
				return this._other_url;
			}
			set
			{
				this._other_url = value;
			}
		}

		public string other_user
		{
			get
			{
				return this._other_user;
			}
			set
			{
				this._other_user = value;
			}
		}

		public string plat_url
		{
			get
			{
				return this._plat_url;
			}
			set
			{
				this._plat_url = value;
			}
		}

		public string pro_pwd
		{
			get
			{
				return this._pro_pwd;
			}
			set
			{
				this._pro_pwd = value;
			}
		}

		public string pro_user
		{
			get
			{
				return this._pro_user;
			}
			set
			{
				this._pro_user = value;
			}
		}

		public string probate_pwd
		{
			get
			{
				return this._probate_pwd;
			}
			set
			{
				this._probate_pwd = value;
			}
		}

		public string probate_url
		{
			get
			{
				return this._probate_url;
			}
			set
			{
				this._probate_url = value;
			}
		}

		public string probate_user
		{
			get
			{
				return this._probate_user;
			}
			set
			{
				this._probate_user = value;
			}
		}

		public string props
		{
			get
			{
				return this._props;
			}
			set
			{
				this._props = value;
			}
		}

		public string prothon_url
		{
			get
			{
				return this._prothon_url;
			}
			set
			{
				this._prothon_url = value;
			}
		}

		public string rv
		{
			get
			{
				return this._rv;
			}
			set
			{
				this._rv = value;
			}
		}

		public string sheriff_url
		{
			get
			{
				return this._sheriff_url;
			}
			set
			{
				this._sheriff_url = value;
			}
		}

		public string sub_need
		{
			get
			{
				return this._sub_need;
			}
			set
			{
				this._sub_need = value;
			}
		}

		public string subscr_term
		{
			get
			{
				return this._subscr_term;
			}
			set
			{
				this._subscr_term = value;
			}
		}

		public string subscrFeeAmt
		{
			get
			{
				return this._subscrFeeAmt;
			}
			set
			{
				this._subscrFeeAmt = value;
			}
		}

		public string subscribed
		{
			get
			{
				return this._subscribed;
			}
			set
			{
				this._subscribed = value;
			}
		}

		public string tap
		{
			get
			{
				return this._tap;
			}
			set
			{
				this._tap = value;
			}
		}

		public string tax_pwd
		{
			get
			{
				return this._tax_pwd;
			}
			set
			{
				this._tax_pwd = value;
			}
		}

		public string tax_url
		{
			get
			{
				return this._tax_url;
			}
			set
			{
				this._tax_url = value;
			}
		}

		public string tax_user
		{
			get
			{
				return this._tax_user;
			}
			set
			{
				this._tax_user = value;
			}
		}

		public string tax2_pwd
		{
			get
			{
				return this._tax2_pwd;
			}
			set
			{
				this._tax2_pwd = value;
			}
		}

		public string tax2_url
		{
			get
			{
				return this._tax2_url;
			}
			set
			{
				this._tax2_url = value;
			}
		}

		public string tax2_user
		{
			get
			{
				return this._tax2_user;
			}
			set
			{
				this._tax2_user = value;
			}
		}

		public string ucc_url
		{
			get
			{
				return this._ucc_url;
			}
			set
			{
				this._ucc_url = value;
			}
		}

		public Resource_Lookup(string state, string county, string tax_auth)
		{
			int num = 0;
			DataTable dataTable = new DataTable();
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
			OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder();
			OleDbCommand oleDbCommand = new OleDbCommand();
			string str = "T:\\ONLINE ABSTRACTING\\_ORB\\ORB_files-dontmoveordelete\\ORB_DATABASE.xls";
			string str1 = "orb";
			oleDbCommand.CommandType = CommandType.TableDirect;
			string str2 = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", str, ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"");
			string[] strArrays = new string[] { "Select * From [", str1, "$] where st = '", state, "' and county = '", county, "'" };
			oleDbCommand.CommandText = string.Concat(strArrays);
			oleDbCommand.Connection = new OleDbConnection(str2);
			oleDbDataAdapter.SelectCommand = oleDbCommand;
			oleDbCommandBuilder.DataAdapter = oleDbDataAdapter;
			oleDbDataAdapter.Fill(dataTable);
			oleDbDataAdapter.Dispose();
			num = 0;
			if (dataTable.Rows.Count > 0)
			{
				this.sub_need = dataTable.Rows[num]["sub_need"].ToString();
				this.subscribed = dataTable.Rows[num]["we_subscribe"].ToString();
				this.subscr_term = dataTable.Rows[num]["sub_term"].ToString();
				this.subscrFeeAmt = dataTable.Rows[num]["subFee"].ToString();
				this.tap = dataTable.Rows[num]["tap"].ToString();
				this.rv = dataTable.Rows[num]["rv"].ToString();
				this.dtree_desk = dataTable.Rows[num]["dtree_desk"].ToString();
				this.ins = dataTable.Rows[num]["ins"].ToString();
				this.props = dataTable.Rows[num]["props"].ToString();
				this.doc_retrieval = dataTable.Rows[num]["copy"].ToString();
				this.copy_pmt_method = dataTable.Rows[num]["copy_pmt_method"].ToString();
				this.copyFeeAmt = dataTable.Rows[num]["copyFeeAmt"].ToString();
				this.copy_source = dataTable.Rows[num]["copy_source"].ToString();
				this.img_date = dataTable.Rows[num]["img_date"].ToString();
				this.index_date = dataTable.Rows[num]["index_date"].ToString();
				this.index_source = dataTable.Rows[num]["index_source"].ToString();
				this.index_pmt_method = dataTable.Rows[num]["index_pmt_method"].ToString();
				this.land_url = dataTable.Rows[num]["land_url"].ToString();
				this.county_user = dataTable.Rows[num]["county_user"].ToString();
				this.county_pwd = dataTable.Rows[num]["county_pwd"].ToString();
				this.login_required = dataTable.Rows[num]["login_req"].ToString();
				this.court_url = dataTable.Rows[num]["court_url"].ToString();
				this.court_user = dataTable.Rows[num]["court_user"].ToString();
				this.court_pwd = dataTable.Rows[num]["court_pwd"].ToString();
				this.courtImageDate = dataTable.Rows[num]["courtImgDt"].ToString();
				this.courtIndexDate = dataTable.Rows[num]["courtIndexDt"].ToString();
				this.muniCourt_url = dataTable.Rows[num]["muniCourt_url"].ToString();
				this.muniCourt_user = dataTable.Rows[num]["muni_user"].ToString();
				this.muniCourt_pwd = dataTable.Rows[num]["muni_pwd"].ToString();
				this.tax_url = dataTable.Rows[num]["tax_url"].ToString();
				this.tax_user = dataTable.Rows[num]["tax_user"].ToString();
				this.tax_pwd = dataTable.Rows[num]["tax_pwd"].ToString();
				this.tax2_url = dataTable.Rows[num]["tax2_url"].ToString();
				this.tax2_user = dataTable.Rows[num]["tax2_user"].ToString();
				this.tax2_pwd = dataTable.Rows[num]["tax2_pwd"].ToString();
				this.prothon_url = dataTable.Rows[num]["prothon_url"].ToString();
				this.pro_user = dataTable.Rows[num]["pro_user"].ToString();
				this.pro_pwd = dataTable.Rows[num]["pro_pwd"].ToString();
				this.assessor_url = dataTable.Rows[num]["assessor_url"].ToString();
				this.assessor_user = dataTable.Rows[num]["assessor_user"].ToString();
				this.assessor_pwd = dataTable.Rows[num]["assessor_pwd"].ToString();
				this.probate_url = dataTable.Rows[num]["probate_url"].ToString();
				this.probate_user = dataTable.Rows[num]["probate_user"].ToString();
				this.probate_pwd = dataTable.Rows[num]["probate_pwd"].ToString();
				this.other_url = dataTable.Rows[num]["other_url"].ToString();
				this.other_user = dataTable.Rows[num]["other_user"].ToString();
				this.other_pwd = dataTable.Rows[num]["other_pwd"].ToString();
				this.ucc_url = dataTable.Rows[num]["ucc_url"].ToString();
				this.foreclosure_url = dataTable.Rows[num]["foreclosure_url"].ToString();
				this.plat_url = dataTable.Rows[num]["plat_url"].ToString();
				this.map_url = dataTable.Rows[num]["map_url"].ToString();
				this.sheriff_url = dataTable.Rows[num]["sheriff_url"].ToString();
				this.county_homepage = dataTable.Rows[num]["county_homepage"].ToString();
				this.comments = dataTable.Rows[num]["comments"].ToString();
			}
		}
	}
}