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
	public partial class AdminPurchOrdersForm : Form
	{
		private BindingSource bs = new BindingSource();

		private OleDbConnection e_cn;
		private string e_reqCount;
		public AdminPurchOrdersForm(OleDbConnection cn, string reqCount)
		{
			InitializeComponent();
			DataTable dtTmp = new DataTable();
			e_cn = cn;
			e_reqCount = reqCount;


			string strSQL = String.Format(@"SELECT o.ord_id AS 'Номер заказа', p.name AS 'Заказчик', o.placement_date AS 'Дата оформления', o.execution_date AS 'Дата выполнения', 
																		  os.description AS 'Статус заказа', o.adress AS 'Адрес досставки', SUM(od.fullPrice) AS 'Сумма заказа' FROM Orders AS o
																			INNER JOIN OrderStatuses AS os ON os.status_id = o.status_id
																			INNER JOIN Purchasers AS p ON p.login = o.login
																			INNER JOIN OrderDetails AS od ON od.ord_id = o.ord_id
																			GROUP BY o.ord_id, p.name, o.placement_date, o.execution_date, os.description, o.adress");

			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dataAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgwPurchOrders.DataSource = bs;
			dgwPurchOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

			DataGridViewButtonColumn bColumn1 = new DataGridViewButtonColumn();
			bColumn1.HeaderText = "";
			bColumn1.Name = "Удалить заказ";
			bColumn1.Text = "Удалить заказ";
			bColumn1.UseColumnTextForButtonValue = true;
			dgwPurchOrders.Columns.Add(bColumn1);

		}

		private void AdminPurchOrdersForm_Load(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgwPurchOrders.Rows)
			{
				if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "Оформление")
				{
					row.Cells[5].Style.BackColor = Color.Orange;
				}
				else if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "Выполнен")
				{
					row.Cells[5].Style.BackColor = Color.LightGreen;
				}
			}
		}

		private void dgwPurchOrders_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach (DataGridViewRow row in dgwPurchOrders.Rows)
			{
				if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "Оформление")
				{
					row.Cells[5].Style.BackColor = Color.Orange;
				}
				else if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == "Выполнен")
				{
					row.Cells[5].Style.BackColor = Color.LightGreen;
				}
			}

			if (e.ColumnIndex == 5)
			{
				editOrderStatus eOS = new editOrderStatus(e_cn, dgwPurchOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), 
																								  dgwPurchOrders.Rows[e.RowIndex].Cells[e.ColumnIndex - 4].Value.ToString(), 
																									e_reqCount);
				this.Hide();
				eOS.Show();
			}
			else if(e.ColumnIndex == 0)
			{
				DialogResult res = MessageBox.Show("Удалить заказ?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.Yes)
				{
					String strSQL = String.Format("DELETE FROM Orders WHERE ord_id = '{0}'", 
																				 dgwPurchOrders.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());

					OleDbCommand cmd = new OleDbCommand(strSQL, e_cn);
					cmd.ExecuteNonQuery();

					AdminPurchOrdersForm aPOF = new AdminPurchOrdersForm(e_cn, e_reqCount);
					this.Hide();
					aPOF.Show();
				}
			}
		}

		private void AdminPurchOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}

		private void bBack_Click(object sender, EventArgs e)
		{
			AdminForm aF = new AdminForm(e_cn);
			this.Hide();
			aF.Show();
		}
	}
}
