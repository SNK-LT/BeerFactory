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
	public partial class NewAcc : Form
	{
		private BindingSource bs = new BindingSource();
		private OleDbConnection e_cn;
		public NewAcc(OleDbConnection cn)
		{
			InitializeComponent();
			e_cn = cn;
			DataTable dtTmp = new DataTable();
			cbPostName.Items.Add("Грузчик");
			cbPostName.Items.Add("Кладовщик");
			cbPostName.Items.Add("Бухгалтер");
			cbPostName.Items.Add("Охранник");
			cbPostName.Items.Add("Водитель");
		}

		private void NewAcc_Load(object sender, EventArgs e)
		{

		}

		private void bAccept_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Создастся новый сотрудник, продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{

				String strSQL = String.Format("EXEC Add_NewEmployee @fio = '{0}', " +
																			"@post_name = '{1}', @login = '{2}', @password = '{3}'",
																			 tbFio.Text, cbPostName.Text, tbLogin.Text, tbPassword.Text);

				OleDbCommand cmd = new OleDbCommand(strSQL, e_cn);
				cmd.ExecuteNonQuery();

				NewAcc nA = new NewAcc(e_cn);
				this.Hide();
				nA.Show();
			}
		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Данные будут стёрты, продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				EmpControl eC = new EmpControl(e_cn);
				this.Hide();
				eC.Show();
			}
		}
	}
}
