namespace BeerFactory.Admin
{
	partial class EmpInfo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lAddress = new System.Windows.Forms.Label();
			this.lMail = new System.Windows.Forms.Label();
			this.lPhone = new System.Windows.Forms.Label();
			this.lLogin = new System.Windows.Forms.Label();
			this.lPassword = new System.Windows.Forms.Label();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbMail = new System.Windows.Forms.TextBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lAddress
			// 
			this.lAddress.AutoSize = true;
			this.lAddress.Location = new System.Drawing.Point(17, 15);
			this.lAddress.Name = "lAddress";
			this.lAddress.Size = new System.Drawing.Size(38, 13);
			this.lAddress.TabIndex = 0;
			this.lAddress.Text = "Адрес";
			// 
			// lMail
			// 
			this.lMail.AutoSize = true;
			this.lMail.Location = new System.Drawing.Point(17, 41);
			this.lMail.Name = "lMail";
			this.lMail.Size = new System.Drawing.Size(37, 13);
			this.lMail.TabIndex = 1;
			this.lMail.Text = "Почта";
			// 
			// lPhone
			// 
			this.lPhone.AutoSize = true;
			this.lPhone.Location = new System.Drawing.Point(5, 67);
			this.lPhone.Name = "lPhone";
			this.lPhone.Size = new System.Drawing.Size(52, 13);
			this.lPhone.TabIndex = 2;
			this.lPhone.Text = "Телефон";
			// 
			// lLogin
			// 
			this.lLogin.AutoSize = true;
			this.lLogin.Location = new System.Drawing.Point(16, 110);
			this.lLogin.Name = "lLogin";
			this.lLogin.Size = new System.Drawing.Size(38, 13);
			this.lLogin.TabIndex = 3;
			this.lLogin.Text = "Логин";
			// 
			// lPassword
			// 
			this.lPassword.AutoSize = true;
			this.lPassword.Location = new System.Drawing.Point(9, 136);
			this.lPassword.Name = "lPassword";
			this.lPassword.Size = new System.Drawing.Size(45, 13);
			this.lPassword.TabIndex = 4;
			this.lPassword.Text = "Пароль";
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(60, 12);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(236, 20);
			this.tbAddress.TabIndex = 5;
			// 
			// tbMail
			// 
			this.tbMail.Location = new System.Drawing.Point(60, 38);
			this.tbMail.Name = "tbMail";
			this.tbMail.Size = new System.Drawing.Size(236, 20);
			this.tbMail.TabIndex = 6;
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(60, 64);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(236, 20);
			this.tbPhone.TabIndex = 7;
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(60, 107);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(236, 20);
			this.tbLogin.TabIndex = 8;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(60, 133);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(236, 20);
			this.tbPassword.TabIndex = 9;
			// 
			// EmpInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 170);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.tbMail);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.lPassword);
			this.Controls.Add(this.lLogin);
			this.Controls.Add(this.lPhone);
			this.Controls.Add(this.lMail);
			this.Controls.Add(this.lAddress);
			this.Name = "EmpInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.EmpInfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lAddress;
		private System.Windows.Forms.Label lMail;
		private System.Windows.Forms.Label lPhone;
		private System.Windows.Forms.Label lLogin;
		private System.Windows.Forms.Label lPassword;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbMail;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
	}
}