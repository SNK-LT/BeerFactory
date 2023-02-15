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

namespace BeerFactory.Admin
{
	public partial class EmpControl : Form
	{
		private BindingSource bs = new BindingSource();
		private OleDbConnection e_cn;
		public EmpControl(OleDbConnection cn)
		{
			InitializeComponent();
			e_cn = cn;
			DataTable dtTmp = new DataTable();

			string strSQL = String.Format(@"SELECT e.emp_id AS 'Номер сотрудника', e.fio AS 'ФИО', 
																			e.employment_data AS 'Дата трудоустройства', p.name AS 'Должность', 
																			ws.description AS 'Рабочий статус' FROM Employees AS e
																			INNER JOIN Posts AS p ON p.post_id = e.post_id
																			INNER JOIN WorkStatuses AS ws ON ws.status_id = e.status_id");

			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, e_cn);
			dataAdapter.Fill(dtTmp);
			bs.DataSource = dtTmp;
			dgwEMPS.DataSource = bs;
			dgwEMPS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

			DataGridViewButtonColumn bColumn1 = new DataGridViewButtonColumn();
			bColumn1.HeaderText = "";
			bColumn1.Name = "Личная инф.";
			bColumn1.Text = "Личная инф.";
			bColumn1.UseColumnTextForButtonValue = true;
			dgwEMPS.Columns.Add(bColumn1);

			DataGridViewButtonColumn bColumn2 = new DataGridViewButtonColumn();
			bColumn2.HeaderText = "";
			bColumn2.Name = "Удалить";
			bColumn2.Text = "Удалить";
			bColumn2.UseColumnTextForButtonValue = true;
			dgwEMPS.Columns.Add(bColumn2);
		}

		private void EmpControl_Load(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgwEMPS.Rows)
			{
				if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() == "Уволен")
				{
					row.Cells[6].Style.BackColor = Color.Red;
				}
				else if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() == "Обычный")
				{
					row.Cells[6].Style.BackColor = Color.LightGreen;
				}
			}
		}

		private void dgwEMPS_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach (DataGridViewRow row in dgwEMPS.Rows)
			{
				if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() == "Уволен")
				{
					row.Cells[6].Style.BackColor = Color.Red;
				}
				else if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() == "Обычный")
				{
					row.Cells[6].Style.BackColor = Color.LightGreen;
				}
			}
			if(e.ColumnIndex == 0)
			{
				EmpInfo ef = new EmpInfo(e_cn, dgwEMPS.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString());
				ef.Show();
			}
			else if (e.ColumnIndex == 1)
			{
				DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить сотрудника?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (res == DialogResult.Yes)
				{
					StoredProcedures.dellEmp(e_cn, dgwEMPS.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
					this.Hide();
					EmpControl eC = new EmpControl(e_cn);
					eC.Show();
				}
			}
		}

		private void bBack_Click(object sender, EventArgs e)
		{
			AdminForm aF = new AdminForm(e_cn);
			this.Hide();
			aF.Show();
		}

		private void EmpControl_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}

		private void bNewAcc_Click(object sender, EventArgs e)
		{
			NewAcc nA = new NewAcc(e_cn);
			this.Hide();
			nA.Show();
		}
	}
}
