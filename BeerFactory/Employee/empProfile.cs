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

using BeerFactory.SupportFuncs;

namespace BeerFactory
{
	public partial class empProfile : Form
	{
		DataTable myInfo { get; set; }
		private OleDbConnection e_cn;
		private string e_myLogin;

		private string buff_tbName;
		private string buff_tbAddress;
		private string buff_tbPhone;
		private string buff_tbMail;

		public empProfile(OleDbConnection cn, string myLogin)
		{
			InitializeComponent();
			e_cn = cn;
			e_myLogin = myLogin;
			myInfo = StoredProcedures.getEmpIfo(cn, myLogin);

			bSave.Hide();
			bCancel.Hide();

			tbName.Enabled = false;
			tbPost.Enabled = false;
			tbAddress.Enabled = false;
			tbPhone.Enabled = false;
			tbMail.Enabled = false;

			tbName.Text = myInfo.Rows[0]["fio"].ToString();
			tbPost.Text = StoredProcedures.getPostName(e_cn, e_myLogin);
			tbAddress.Text = myInfo.Rows[0]["home_address"].ToString();
			tbPhone.Text = myInfo.Rows[0]["phone"].ToString();
			tbMail.Text = myInfo.Rows[0]["mail"].ToString();

			buff_tbName = tbName.Text;
			buff_tbAddress = tbAddress.Text;
			buff_tbPhone = tbPhone.Text;
			buff_tbMail = tbMail.Text;

		}

		private void empProfile_Load(object sender, EventArgs e)
		{

		}

		private void bEdit_Clicked(object sender, EventArgs e)
		{
			bSave.Show();
			bCancel.Show();

			bEdit.Enabled = false;

			tbName.Enabled = true;
			tbAddress.Enabled = true;
			tbPhone.Enabled = true;
			tbMail.Enabled = true;

			tbName.BackColor = Color.LightGreen;
			tbPost.BackColor = Color.Red;
			tbAddress.BackColor = Color.LightGreen;
			tbPhone.BackColor = Color.LightGreen;
			tbMail.BackColor = Color.LightGreen;
		}

		private void bSave_Clicked(object sender, EventArgs e)
		{
			StoredProcedures.changeEmpInfo(e_cn, tbName.Text, tbAddress.Text, tbPhone.Text, tbMail.Text, e_myLogin);

			bSave.Hide();
			bCancel.Hide();

			bEdit.Enabled = true;

			tbName.Enabled = false;
			tbAddress.Enabled = false;
			tbPhone.Enabled = false;
			tbMail.Enabled = false;

			tbName.BackColor = SystemColors.Window;
			tbPost.BackColor = SystemColors.Window;
			tbAddress.BackColor = SystemColors.Window;
			tbPhone.BackColor = SystemColors.Window;
			tbMail.BackColor = SystemColors.Window;
		}

		private void bCancel_Clicked(object sender, EventArgs e)
		{

			tbName.Text = buff_tbName;
			tbAddress.Text = buff_tbAddress;
			tbPhone.Text = buff_tbPhone;	
			tbMail.Text = buff_tbMail;

			bSave.Hide();
			bCancel.Hide();

			bEdit.Enabled = true;

			tbName.Enabled = false;
			tbAddress.Enabled = false;
			tbPhone.Enabled = false;
			tbMail.Enabled = false;

			tbName.BackColor = SystemColors.Window;
			tbPost.BackColor = SystemColors.Window;
			tbAddress.BackColor = SystemColors.Window;
			tbPhone.BackColor = SystemColors.Window;
			tbMail.BackColor = SystemColors.Window;
		}

		private void fEmpProfile_Closing(object sender, FormClosingEventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res != DialogResult.Yes)
				e.Cancel = true;
		}

		private void bBack_Clicked(object sender, EventArgs e)
		{
			EmpForm ef = new EmpForm(e_cn, e_myLogin);
			this.Hide();
			ef.Show();
		}

		private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
