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

using BeerFactory.SupportFuncs;

namespace BeerFactory
{
	public partial class PurchForm : Form
	{
		private OleDbConnection e_cn;
		private string e_myLogin;
		public PurchForm(OleDbConnection cn, string myLogin)
		{
			InitializeComponent();
			e_cn = cn;
			e_myLogin = myLogin;
		}

		private void PurchForm_Load(object sender, EventArgs e)
		{

		}

		private void bOrders_Click(object sender, EventArgs e)
		{
			pOrders pO = new pOrders(e_cn, e_myLogin);
			this.Hide();
			pO.Show();
		}

		private void bExit_Clicked(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void fPurch_Closing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}

		private void bMakeOrder_Clicked(object sender, EventArgs e)
		{
			purchMakeOrder pMO = new purchMakeOrder(e_cn, e_myLogin);
			this.Hide();
			pMO.Show();
		}
	}
}
