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
	public partial class PurchControl : Form
	{
		private BindingSource bs = new BindingSource();
		private OleDbConnection e_cn;
		public PurchControl(OleDbConnection cn)
		{
			InitializeComponent();
			e_cn = cn;
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT p.name AS 'Покупатель' FROM Purchasers AS p");

			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dataAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgwPurchControl.DataSource = bs;
			dgwPurchControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

			DataGridViewButtonColumn bColumn1 = new DataGridViewButtonColumn();
			bColumn1.HeaderText = "";
			bColumn1.Name = "Удалить";
			bColumn1.Text = "Удалить";
			bColumn1.UseColumnTextForButtonValue = true;
			dgwPurchControl.Columns.Add(bColumn1);
		}

		private void PurchControl_Load(object sender, EventArgs e)
		{

		}

		private void dgwPurchControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgwPurchControl_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить заказчика?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.Yes)
				{
					string strSQL = String.Format("EXEC DellPurch @name = '{0}'", dgwPurchControl.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());

					OleDbCommand cmd = new OleDbCommand(strSQL, e_cn);
					cmd.ExecuteNonQuery();

					PurchControl pC = new PurchControl(e_cn);
					this.Hide();
					pC.Show();
				}
			}
		}

		private void bBack_Click(object sender, EventArgs e)
		{
			AdminForm aF = new AdminForm(e_cn);
			this.Hide();
			aF.Show();
		}

		private void PurchControl_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}
	}
}
