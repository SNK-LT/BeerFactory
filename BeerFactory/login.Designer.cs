namespace BeerFactory
{
	partial class login
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.bEnter = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cn = new System.Data.OleDb.OleDbConnection();
			this.bCreateAcc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbLogin
			// 
			this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLogin.Location = new System.Drawing.Point(109, 12);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(140, 26);
			this.tbLogin.TabIndex = 1;
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPassword.Location = new System.Drawing.Point(109, 52);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(140, 26);
			this.tbPassword.TabIndex = 3;
			// 
			// bEnter
			// 
			this.bEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bEnter.Location = new System.Drawing.Point(144, 84);
			this.bEnter.Name = "bEnter";
			this.bEnter.Size = new System.Drawing.Size(105, 30);
			this.bEnter.TabIndex = 5;
			this.bEnter.Text = "Войти в аккаунт";
			this.bEnter.UseVisualStyleBackColor = true;
			this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(44, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Логин";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(31, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Пароль";
			// 
			// bCreateAcc
			// 
			this.bCreateAcc.Location = new System.Drawing.Point(72, 172);
			this.bCreateAcc.Name = "bCreateAcc";
			this.bCreateAcc.Size = new System.Drawing.Size(117, 23);
			this.bCreateAcc.TabIndex = 8;
			this.bCreateAcc.Text = "Создать аккаунт";
			this.bCreateAcc.UseVisualStyleBackColor = true;
			this.bCreateAcc.Click += new System.EventHandler(this.bCreateAcc_Click);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 207);
			this.Controls.Add(this.bCreateAcc);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bEnter);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbLogin);
			this.Name = "login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLoginClosing);
			this.Load += new System.EventHandler(this.login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button bEnter;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Data.OleDb.OleDbConnection cn;
		private System.Windows.Forms.Button bCreateAcc;
	}
}

