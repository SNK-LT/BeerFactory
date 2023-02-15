namespace BeerFactory
{
	partial class NewPurchAcc
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
			this.lName = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lLogin = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.lPassword = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.bCancel = new System.Windows.Forms.Button();
			this.bAccept = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lName
			// 
			this.lName.AutoSize = true;
			this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lName.Location = new System.Drawing.Point(12, 9);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(323, 20);
			this.lName.TabIndex = 0;
			this.lName.Text = "Введите имя или название магазина";
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbName.Location = new System.Drawing.Point(16, 32);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(319, 26);
			this.tbName.TabIndex = 1;
			// 
			// lLogin
			// 
			this.lLogin.AutoSize = true;
			this.lLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lLogin.Location = new System.Drawing.Point(127, 84);
			this.lLogin.Name = "lLogin";
			this.lLogin.Size = new System.Drawing.Size(59, 20);
			this.lLogin.TabIndex = 2;
			this.lLogin.Text = "Логин";
			// 
			// tbLogin
			// 
			this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLogin.Location = new System.Drawing.Point(192, 81);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(143, 26);
			this.tbLogin.TabIndex = 3;
			// 
			// lPassword
			// 
			this.lPassword.AutoSize = true;
			this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lPassword.Location = new System.Drawing.Point(114, 116);
			this.lPassword.Name = "lPassword";
			this.lPassword.Size = new System.Drawing.Size(72, 20);
			this.lPassword.TabIndex = 4;
			this.lPassword.Text = "Пароль";
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPassword.Location = new System.Drawing.Point(192, 113);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(143, 26);
			this.tbPassword.TabIndex = 5;
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(179, 178);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 23);
			this.bCancel.TabIndex = 6;
			this.bCancel.Text = "Отмена";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// bAccept
			// 
			this.bAccept.Location = new System.Drawing.Point(260, 178);
			this.bAccept.Name = "bAccept";
			this.bAccept.Size = new System.Drawing.Size(75, 23);
			this.bAccept.TabIndex = 7;
			this.bAccept.Text = "Создать";
			this.bAccept.UseVisualStyleBackColor = true;
			this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
			// 
			// NewPurchAcc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 212);
			this.Controls.Add(this.bAccept);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.lPassword);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.lLogin);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lName);
			this.Name = "NewPurchAcc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lName;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label lLogin;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.Label lPassword;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bAccept;
	}
}