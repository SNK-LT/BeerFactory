using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace BeerFactory
{

	public partial class pOrders : Form
	{
		private BindingSource bs = new BindingSource();

		DataTable myInfo { get; set; }
		private OleDbConnection e_cn;
		private string e_myLogin;

		public pOrders(OleDbConnection cn, string login)
		{
			InitializeComponent();
			DataTable dtTmp = new DataTable();
			e_cn = cn;
			e_myLogin = login;

			string strSQL = String.Format(@"SELECT p.name, o.placement_date, o.execution_date, 
																		  os.description, o.adress, SUM(od.fullPrice) AS 'СУММА' FROM Orders AS o
																			INNER JOIN OrderStatuses AS os ON os.status_id = o.status_id
																			INNER JOIN Purchasers AS p ON p.login = o.login
																			INNER JOIN OrderDetails AS od ON od.ord_id = o.ord_id
																			WHERE p.login = '{0}'
																			GROUP BY p.name, o.placement_date, o.execution_date, os.description, o.adress",
																			e_myLogin);

			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dataAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgwOrders.DataSource = bs;
			dgwOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

			foreach (DataGridViewRow row in dgwOrders.Rows)
			{
				if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == "Выполнен")
				{
					row.Cells[3].Style.BackColor = Color.LightGreen;
				}
			}
		}

		private void pOrders_Load(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgwOrders.Rows)
			{
				if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == "Выполнен")
				{
					row.Cells[3].Style.BackColor = Color.LightGreen;
				}
				else if(row.Cells[3].Value != null && row.Cells[3].Value.ToString() == "Отмена") 
				{
					row.Cells[3].Style.BackColor = Color.Red;
				}
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void bReturn_Clicked(object sender, EventArgs e)
		{
			PurchForm pF = new PurchForm(e_cn, e_myLogin);
			this.Hide();
			pF.Show();
		}

		private void fPOrders_Closing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}

		private void CellClicked(object sender, DataGridViewCellEventArgs e)
		{
			foreach (DataGridViewRow row in dgwOrders.Rows)
			{
				if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == "Выполнен")
				{
					row.Cells[3].Style.BackColor = Color.LightGreen;
				}
				else if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == "Отмена")
				{
					row.Cells[3].Style.BackColor = Color.Red;
				}
			}
		}
	}
}
