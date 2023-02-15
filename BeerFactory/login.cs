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

using BeerFactory.SupportFuncs;

namespace BeerFactory
{
	public partial class login : Form
	{
		DataTable Users { get; set; }
		public login()
		{
			InitializeComponent();

			cn.ConnectionString = @"Provider=SQLNCLIRDA11; Data Source=DESKTOP-KR40PBT\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=BeerFactory";
			cn.Open();
			Users = StoredProcedures.getAccounts(cn);
		}

		private void login_Load(object sender, EventArgs e)
		{

		}

		private void bEnter_Click(object sender, EventArgs e)
		{
			var inputLog = tbLogin.Text;
			bool entered = false;
			foreach(DataRow logRow in Users.Rows) 
			{
				if (inputLog == logRow["login"].ToString() && tbPassword.Text == logRow["password"].ToString())
				{
					entered = true;
					switch (logRow["login"].ToString()[0])
					{
						case 'p':
							{
								PurchForm pf = new PurchForm(cn, inputLog);
								this.Hide();
								pf.Show();
								break;
							}
						case 'e':
							{
								EmpForm ef = new EmpForm(cn, inputLog);
								this.Hide();
								ef.Show();
								break;
							}
						case 'l':
							{
								AdminForm af = new AdminForm(cn);
								this.Hide();
								af.Show();
								break;
							}
					}
				}
			}
			if (!entered)
			{
				MessageBox.Show("Неверный Логин или Пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void fLoginClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;

		}

		private void bCreateAcc_Click(object sender, EventArgs e)
		{
			NewPurchAcc nPA = new NewPurchAcc(cn);
			this.Hide();
			nPA.Show();
		}
	}
}
