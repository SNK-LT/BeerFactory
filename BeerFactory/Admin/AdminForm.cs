using BeerFactory.Admin;
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

namespace BeerFactory
{
	public partial class AdminForm : Form
	{
		private OleDbConnection e_cn;
		private string e_reqCount;
		private string ordCount;
		public AdminForm(OleDbConnection cn)
		{
			InitializeComponent();
			e_cn = cn;

			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT COUNT(scr.id) FROM StatusChangeRequests AS scr");

			var dAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dAdapter.Fill(ds, "ReqCount");
			dt = ds.Tables["ReqCount"];

			e_reqCount = dt.Rows[0][0].ToString();
			bStatuses.Text += " (" + Convert.ToInt32(e_reqCount) + ")";

			String strSQL2 = String.Format("SELECT COUNT(o.ord_id) FROM Orders AS o " +
														 "INNER JOIN OrderStatuses AS os ON os.status_id = o.status_id " +
														 "WHERE os.description = 'Оформление'");

			dAdapter = new OleDbDataAdapter(strSQL2, e_cn);
			dAdapter.Fill(ds, "Orders");
			dt = ds.Tables["Orders"];

			ordCount = dt.Rows[0][0].ToString();
			bOrders.Text += " (" + Convert.ToInt32(ordCount) + ")";
		}

		private void bExit_Clicked(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void AdminForm_Closing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}

		private void bStatuses_Click(object sender, EventArgs e)
		{
			AdminEmpStatuses aES = new AdminEmpStatuses(e_cn, e_reqCount);
			this.Hide();
			aES.Show();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{

		}

		private void bPurchOrders_Click(object sender, EventArgs e)
		{
			AdminPurchOrdersForm aPOF = new AdminPurchOrdersForm(e_cn, ordCount);
			this.Hide();
			aPOF.Show();
		}

		private void bEmp_Click(object sender, EventArgs e)
		{
			EmpControl eC = new EmpControl(e_cn);
			this.Hide();
			eC.Show();
		}

		private void bPurch_Click(object sender, EventArgs e)
		{
			PurchControl pC = new PurchControl(e_cn);
			this.Hide();
			pC.Show();
		}
	}
}
