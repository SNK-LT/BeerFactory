namespace BeerFactory.Admin
{
	partial class NewAcc
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
			this.lFio = new System.Windows.Forms.Label();
			this.lPostName = new System.Windows.Forms.Label();
			this.lLogin = new System.Windows.Forms.Label();
			this.lPassword = new System.Windows.Forms.Label();
			this.tbFio = new System.Windows.Forms.TextBox();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.bCancel = new System.Windows.Forms.Button();
			this.bAccept = new System.Windows.Forms.Button();
			this.cbPostName = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lFio
			// 
			this.lFio.AutoSize = true;
			this.lFio.Location = new System.Drawing.Point(38, 15);
			this.lFio.Name = "lFio";
			this.lFio.Size = new System.Drawing.Size(34, 13);
			this.lFio.TabIndex = 0;
			this.lFio.Text = "ФИО";
			// 
			// lPostName
			// 
			this.lPostName.AutoSize = true;
			this.lPostName.Location = new System.Drawing.Point(11, 41);
			this.lPostName.Name = "lPostName";
			this.lPostName.Size = new System.Drawing.Size(65, 13);
			this.lPostName.TabIndex = 1;
			this.lPostName.Text = "Должность";
			// 
			// lLogin
			// 
			this.lLogin.AutoSize = true;
			this.lLogin.Location = new System.Drawing.Point(38, 85);
			this.lLogin.Name = "lLogin";
			this.lLogin.Size = new System.Drawing.Size(38, 13);
			this.lLogin.TabIndex = 2;
			this.lLogin.Text = "Логин";
			// 
			// lPassword
			// 
			this.lPassword.AutoSize = true;
			this.lPassword.Location = new System.Drawing.Point(31, 111);
			this.lPassword.Name = "lPassword";
			this.lPassword.Size = new System.Drawing.Size(45, 13);
			this.lPassword.TabIndex = 3;
			this.lPassword.Text = "Пароль";
			// 
			// tbFio
			// 
			this.tbFio.Location = new System.Drawing.Point(82, 12);
			this.tbFio.Name = "tbFio";
			this.tbFio.Size = new System.Drawing.Size(214, 20);
			this.tbFio.TabIndex = 4;
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(82, 82);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(214, 20);
			this.tbLogin.TabIndex = 6;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(82, 108);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(214, 20);
			this.tbPassword.TabIndex = 7;
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(136, 144);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 23);
			this.bCancel.TabIndex = 8;
			this.bCancel.Text = "Отмена";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// bAccept
			// 
			this.bAccept.Location = new System.Drawing.Point(221, 144);
			this.bAccept.Name = "bAccept";
			this.bAccept.Size = new System.Drawing.Size(75, 23);
			this.bAccept.TabIndex = 9;
			this.bAccept.Text = "Принять";
			this.bAccept.UseVisualStyleBackColor = true;
			this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
			// 
			// cbPostName
			// 
			this.cbPostName.FormattingEnabled = true;
			this.cbPostName.Location = new System.Drawing.Point(82, 38);
			this.cbPostName.Name = "cbPostName";
			this.cbPostName.Size = new System.Drawing.Size(214, 21);
			this.cbPostName.TabIndex = 10;
			// 
			// NewAcc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 179);
			this.Controls.Add(this.cbPostName);
			this.Controls.Add(this.bAccept);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.tbFio);
			this.Controls.Add(this.lPassword);
			this.Controls.Add(this.lLogin);
			this.Controls.Add(this.lPostName);
			this.Controls.Add(this.lFio);
			this.Name = "NewAcc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.NewAcc_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lFio;
		private System.Windows.Forms.Label lPostName;
		private System.Windows.Forms.Label lLogin;
		private System.Windows.Forms.Label lPassword;
		private System.Windows.Forms.TextBox tbFio;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bAccept;
		private System.Windows.Forms.ComboBox cbPostName;
	}
}