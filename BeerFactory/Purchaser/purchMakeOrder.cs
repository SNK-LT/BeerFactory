using BeerFactory.SupportFuncs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BeerFactory
{
	public partial class purchMakeOrder : Form
	{
		DataTable myNewOrder { get; set; }
		private BindingSource bs = new BindingSource();

		private OleDbConnection e_cn;
		private string e_myLogin;
		public purchMakeOrder(OleDbConnection cn, string login)
		{
			InitializeComponent();

			DataTable dtTmp = new DataTable();
			e_cn = cn;
			e_myLogin = login;

			string strSQL = String.Format(@"SELECT p.product_id AS 'Номер', p.name AS 'Название', p.price AS 'Цена', p.volume AS 'Объём',  
																		  c.name AS 'Материал ёмкости', p.type AS 'Тип пива',
																			p.info AS 'Информация', p.product_id AS 'Содержание' FROM Products AS p
																			INNER JOIN Components AS c ON c.component_id = p.material_id");

			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dataAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgwMakeOrder.DataSource = bs;

			DataGridViewTextBoxColumn tbColumn1 = new DataGridViewTextBoxColumn();
			tbColumn1.HeaderText = "Количество";
			tbColumn1.Name = "tbCount";

			dgwMakeOrder.Columns.Add(tbColumn1);
		}

		private void purchMakeOrder_Load(object sender, EventArgs e)
		{

		}

		private void dwg_CellClicked(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 6)
			{
				MessageBox.Show(dgwMakeOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Тип пива",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(e.ColumnIndex == 7)
			{
				MessageBox.Show(dgwMakeOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Информация",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(e.ColumnIndex == 8)
			{
				productInfo pf = new productInfo(e_cn, dgwMakeOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
				pf.Show();
			}
		}

		private void bMakeOrder_Clicked(object sender, EventArgs e)
		{
			bool errorShown1 = false;
			bool errorShown2 = false;
			int i = 0;
			foreach (DataGridViewRow row in dgwMakeOrder.Rows)
			{
				if(row.Cells[0].Value != null)
				{
					i++;
					int ignoreMe;
					if(!(int.TryParse(row.Cells[0].Value.ToString(), out ignoreMe)))
					{
						row.Cells[0].Value = null;
						if (!errorShown1)
						{
							MessageBox.Show("В качестве количества может быть только целочисленное число", "Ошибка!",
													MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						errorShown1 = true;
						i = 0;
					}
					else
					{
						int count = Convert.ToInt32(row.Cells[0].Value.ToString());
						if (count >= 1000 || count <= 0)
						{
							row.Cells[0].Value = null;
							if (!errorShown2)
							{
								MessageBox.Show("Лимит на количество одной продукции '1 - 1000'", "Ошибка!",
														MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							errorShown2 = true;
							i = 0;
						}
					}
				}

			}

			if(i != 0)
			{

				if (tbAddress.Text == "Введите адрес доставки")
				{
					MessageBox.Show("Введите адрес доставки!", "Ошибка!",
													MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					string newOrd_id = StoredProcedures.makeNew_Order(e_cn, e_myLogin, tbAddress.Text);
					foreach (DataGridViewRow row in dgwMakeOrder.Rows)
					{
						if (row.Cells[0].Value != null)
						{
							StoredProcedures.makeNew_OrderDetail(e_cn, newOrd_id, row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString());
						}

					}
					MessageBox.Show("Заказ успешно обрботан!", " ",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					purchMakeOrder pMO = new purchMakeOrder(e_cn, e_myLogin);
					this.Hide();
					pMO.Show();
				}
			}
		}

		private void bBack_Clicked(object sender, EventArgs e)
		{
			PurchForm pF = new PurchForm(e_cn, e_myLogin);
			this.Hide();
			pF.Show();
		}

		private void fPurchMakeOrder_Closing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}
	}
}
