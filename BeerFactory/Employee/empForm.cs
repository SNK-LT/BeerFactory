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

	public partial class EmpForm : Form
	{
		private OleDbConnection e_cn;
		private string e_myLogin;

		public EmpForm(OleDbConnection cn, string myLogin)
		{
			InitializeComponent();
			e_cn = cn;
			e_myLogin = myLogin;
		}

		private void bProfile_Click(object sender, EventArgs e)
		{
			empProfile eP = new empProfile(e_cn, e_myLogin);
			this.Hide();
			eP.Show();
		}

		private void bMyStatus_Click(object sender, EventArgs e)
		{
			empStatus eS = new empStatus(e_cn, e_myLogin);
			this.Hide();
			eS.Show();
		}

		private void bExit_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void EmpForm_Load(object sender, EventArgs e)
		{

		}

		private void fEmp_Closing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}
	}
}
