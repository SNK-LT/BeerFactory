using BeerFactory.SupportFuncs;
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
	public partial class editOrderStatus : Form
	{
		private OleDbConnection e_cn;
		private string e_myStatus;
		private string e_myId;
		private string e_reqCount;
		DataTable Statuses { get; set; }
		public editOrderStatus(OleDbConnection cn, string myStatus, string myId, string reqCount)
		{
			InitializeComponent();
			e_cn = cn;
			e_myStatus = myStatus;
			e_myId = myId;
			e_reqCount = reqCount;

			Statuses = StoredProcedures.getAllOrderStatuses(e_cn, myStatus);

			foreach (DataRow statRow in Statuses.Rows)
			{
				comboBox1.Items.Add(statRow["description"].ToString());
			}
		}

		private void editOrderStatus_Load(object sender, EventArgs e)
		{

		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			
		}

		private void bSave_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			DataSet ds = new DataSet();
			String strSQL = String.Format("SELECT os.status_id FROM OrderStatuses AS os WHERE os.description = '{0}'", comboBox1.Text);

			var dAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dAdapter.Fill(ds, "myStat");

			dt = ds.Tables["myStat"];


			strSQL = String.Format("UPDATE Orders SET status_id = '{0}' WHERE Orders.ord_id = '{1}'", dt.Rows[0][0].ToString(), e_myId);

			OleDbCommand cmd = new OleDbCommand(strSQL, e_cn);
			cmd.ExecuteNonQuery();

			if(comboBox1.Text == "Выполнен")
			{
				strSQL = String.Format("UPDATE Orders SET execution_date = GETDATE() WHERE Orders.ord_id = '{0}'", e_myId);

				cmd = new OleDbCommand(strSQL, e_cn);
				cmd.ExecuteNonQuery();
			}
			AdminPurchOrdersForm aPOF = new AdminPurchOrdersForm(e_cn, e_reqCount);
			this.Close();
			aPOF.Show();
		}

		private void bCancel_Click_1(object sender, EventArgs e)
		{
			AdminPurchOrdersForm aPOF = new AdminPurchOrdersForm(e_cn, e_reqCount);
			this.Close();
			aPOF.Show();
		}
	}
}
