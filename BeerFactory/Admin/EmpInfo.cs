using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerFactory.Admin
{
	public partial class EmpInfo : Form
	{
		private BindingSource bs = new BindingSource();
		private OleDbConnection e_cn;
		private string e_empId;

		public EmpInfo(OleDbConnection cn, string empID)
		{
			InitializeComponent();
			DataTable dtTmp = new DataTable();
			e_cn = cn;
			e_empId = empID;

			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT e.home_address, e.mail, e.phone, u.login, u.password FROM Employees AS e " +
																		"INNER JOIN Users AS u ON u.login = e.login " +
																		"WHERE e.emp_id = {0}", e_empId);

			var dAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dAdapter.Fill(ds, "EMPInfo");

			dt = ds.Tables["EMPInfo"];

			tbAddress.Text = dt.Rows[0][0].ToString();
			tbMail.Text = dt.Rows[0][1].ToString();
			tbPhone.Text = dt.Rows[0][2].ToString();
			tbLogin.Text = dt.Rows[0][3].ToString();
			tbPassword.Text = dt.Rows[0][4].ToString();

			tbAddress.Enabled = false;
			tbMail.Enabled = false;
			tbPhone.Enabled = false;
			tbLogin.Enabled = false;
			tbPassword.Enabled = false;
		}

		private void EmpInfo_Load(object sender, EventArgs e)
		{

		}
	}
}
