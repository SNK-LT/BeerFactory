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

namespace BeerFactory
{
	public partial class empStatus : Form
	{
		DataTable myStatus{ get; set; }
		private OleDbConnection e_cn;
		private string e_myLogin;
		private string buff_myMessage;
		public empStatus(OleDbConnection cn, string myLogin)
		{
			InitializeComponent();
			e_cn = cn;
			e_myLogin = myLogin;

			buff_myMessage = tbMess.Text;

			bSend.Hide();
			bCancel.Hide();
			tbMess.Hide();
			label2.Hide();
			cbStatuses.Hide();

			this.Height = 150;

			myStatus = StoredProcedures.getCurStatus(e_cn, e_myLogin);
			tbcurStatus.Text = myStatus.Rows[0][0].ToString();
			if (tbcurStatus.Text == "Обычный")
			{
				tbcurStatus.BackColor = Color.LightGreen;
			}
			else
			{
				tbcurStatus.BackColor = Color.Orange;
			}

			myStatus = StoredProcedures.getAllStatuses(e_cn, tbcurStatus.Text);

			foreach (DataRow statRow in myStatus.Rows)
			{
				cbStatuses.Items.Add(statRow["description"].ToString());
			}
		}

		private void empStatus_Load(object sender, EventArgs e)
		{

		}

		private void bChangeStatus_Clicked(object sender, EventArgs e)
		{
			this.Height = 470;

			bSend.Show();
			bCancel.Show();
			tbMess.Show();
			label2.Show();
			cbStatuses.Show();
		}

		private void bSend_Clicked(object sender, EventArgs e)
		{
			StoredProcedures.sendStatusChangeReq(e_cn, e_myLogin, cbStatuses.Text, tbMess.Text);

			this.Height = 150;
			tbMess.Text = buff_myMessage;

			bSend.Hide();
			bCancel.Hide();
			tbMess.Hide();
			label2.Hide();
			cbStatuses.Hide();
		}

		private void bCancel_Clicked(object sender, EventArgs e)
		{
			this.Height = 150;
			tbMess.Text = buff_myMessage;

			bSend.Hide();
			bCancel.Hide();
			tbMess.Hide();
			label2.Hide();
			cbStatuses.Hide();
		}

		private void fEmpStatus_Closing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}

		private void bBack_Clicked(object sender, EventArgs e)
		{
			EmpForm eF = new EmpForm(e_cn, e_myLogin);
			this.Hide();
			eF.Show();
		}
	}
}
