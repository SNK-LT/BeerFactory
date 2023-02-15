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
	public partial class NewPurchAcc : Form
	{
		private BindingSource bs = new BindingSource();
		private OleDbConnection e_cn;
		public NewPurchAcc(OleDbConnection cn)
		{
			InitializeComponent();
			e_cn = cn;
			DataTable dtTmp = new DataTable();
		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Данные будут стёрты, продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				login l = new login();
				this.Hide();
				l.Show();
			}
		}

		private void bAccept_Click(object sender, EventArgs e)
		{
			String strSQL = String.Format("EXEC Add_NewPurch @login = '{0}', @password = '{1}', @name = '{2}'", 
																		 tbLogin.Text, tbPassword.Text, tbName.Text);

			OleDbCommand cmd = new OleDbCommand(strSQL, e_cn);
			cmd.ExecuteNonQuery();


			MessageBox.Show("Акаунт успешно создан");

			login l = new login();
			this.Hide();
			l.Show();
		}
	}
}
