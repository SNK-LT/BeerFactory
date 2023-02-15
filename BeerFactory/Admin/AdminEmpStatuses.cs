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
	public partial class AdminEmpStatuses : Form
	{
		private BindingSource bs = new BindingSource();

		private OleDbConnection e_cn;
		private string e_reqCount;
		public AdminEmpStatuses(OleDbConnection cn, string reqCount)
		{
			InitializeComponent();
			DataTable dtTmp = new DataTable();
			e_cn = cn;
			e_reqCount = reqCount;

			if(Convert.ToInt32(reqCount) != 0)
			{
				lNoStatuses.Hide();

				string strSQL = String.Format(@"SELECT e.fio AS 'ФИО', scr.req_date AS 'Дата Запроса', w1.description AS 'Текущий статус', 
																			w2.description AS 'Запрашиваемый статус' FROM StatusChangeRequests AS scr													 
																			INNER JOIN Employees AS e ON e.emp_id = scr.emp_id 
																			INNER JOIN WorkStatuses AS w1 ON w1.status_id = scr.cur_status 
																			INNER JOIN WorkStatuses AS w2 on w2.status_id = scr.req_status");

				OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, e_cn);
				dataAdapter.Fill(dtTmp);
				bs.DataSource = dtTmp;
				dgwEmpStatuses.DataSource = bs;
				dgwEmpStatuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

				DataGridViewButtonColumn bColumn1 = new DataGridViewButtonColumn();
				bColumn1.HeaderText = "Сообщение сотрудника";
				bColumn1.Name = "Открыть сообщение";
				bColumn1.Text = "Открыть сообщение";
				bColumn1.UseColumnTextForButtonValue = true;
				dgwEmpStatuses.Columns.Add(bColumn1);

				DataGridViewButtonColumn bColumn2 = new DataGridViewButtonColumn();
				bColumn2.HeaderText = "";
				bColumn2.Name = "Принять";
				bColumn2.Text = "Принять";
				bColumn2.UseColumnTextForButtonValue = true;
				dgwEmpStatuses.Columns.Add(bColumn2);

				DataGridViewButtonColumn bColumn3 = new DataGridViewButtonColumn();
				bColumn3.HeaderText = "";
				bColumn3.Name = "Отказать";
				bColumn3.Text = "Отказать";
				bColumn3.UseColumnTextForButtonValue = true;
				dgwEmpStatuses.Columns.Add(bColumn3);
			}
			else
			{
				this.Height = 133;
				this.Width = 317;
			}
		}


		private void AdminEmpStatuses_Load(object sender, EventArgs e)
		{

		}

		private void dgwEmpStatuses_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 0)
			{
				string fio = dgwEmpStatuses.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value.ToString();

				DataTable dt = new DataTable();
				DataSet ds = new DataSet();
				String strSQL = String.Format("SELECT scr.emp_message FROM StatusChangeRequests AS scr " +
																			"INNER JOIN Employees AS e ON e.emp_id = scr.emp_id " +
																			"WHERE e.fio = '{0}'", fio);

				var dAdapter = new OleDbDataAdapter(strSQL, e_cn);
				dAdapter.Fill(ds, "empMess");

				dt = ds.Tables["empMess"];
				string mess = dt.Rows[0][0].ToString();

				MessageBox.Show(mess, "Сообщение сотрудника");
			}
			else if(e.ColumnIndex == 1)
			{
				DialogResult res = MessageBox.Show("Подтвердить действие?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.Yes)
				{
					string fio = dgwEmpStatuses.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();

					String strSQL = String.Format("EXEC ChangeEmp_Status @fio = '{0}'", fio);

					OleDbCommand cmd = new OleDbCommand(strSQL, e_cn);
					cmd.ExecuteNonQuery();

					AdminEmpStatuses aES = new AdminEmpStatuses(e_cn, e_reqCount);
					this.Hide();
					aES.Show();
				}
			}
			else if(e.ColumnIndex == 2)
			{
				DialogResult res = MessageBox.Show("Подтвердить действие?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.Yes)
				{
					string fio = dgwEmpStatuses.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

					DataTable dt = new DataTable();
					DataSet ds = new DataSet();
					String strSQL = String.Format("SELECT e.emp_id FROM Employees AS e WHERE e.fio = '{0}'", fio);

					var dAdapter = new OleDbDataAdapter(strSQL, e_cn);
					dAdapter.Fill(ds, "empMess");
					dt = ds.Tables["empMess"];
					string emp_id = dt.Rows[0][0].ToString();

					strSQL = String.Format("DELETE FROM StatusChangeRequests WHERE emp_id = '{0}'", emp_id);

					OleDbCommand cmd = new OleDbCommand(strSQL, e_cn);
					cmd.ExecuteNonQuery();

					AdminEmpStatuses aES = new AdminEmpStatuses(e_cn, e_reqCount);
					this.Hide();
					aES.Show();
				}
			}
		}

		private void AdminEmpStatuses_FormClosing(object sender, FormClosingEventArgs e)
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
