namespace BeerFactory
{
	partial class empProfile
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbPost = new System.Windows.Forms.TextBox();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.tbMail = new System.Windows.Forms.TextBox();
			this.bSave = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.bEdit = new System.Windows.Forms.Button();
			this.bBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(102, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Должность";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Адрес проживания";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(74, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Номер телефона";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(130, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Почта";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(173, 15);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(220, 20);
			this.tbName.TabIndex = 5;
			// 
			// tbPost
			// 
			this.tbPost.Location = new System.Drawing.Point(173, 41);
			this.tbPost.Name = "tbPost";
			this.tbPost.Size = new System.Drawing.Size(220, 20);
			this.tbPost.TabIndex = 6;
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(173, 67);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(220, 20);
			this.tbAddress.TabIndex = 7;
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(173, 93);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(220, 20);
			this.tbPhone.TabIndex = 8;
			this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
			// 
			// tbMail
			// 
			this.tbMail.Location = new System.Drawing.Point(173, 119);
			this.tbMail.Name = "tbMail";
			this.tbMail.Size = new System.Drawing.Size(220, 20);
			this.tbMail.TabIndex = 9;
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(321, 189);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(70, 23);
			this.bSave.TabIndex = 10;
			this.bSave.Text = "Сохранить";
			this.bSave.UseVisualStyleBackColor = true;
			this.bSave.Click += new System.EventHandler(this.bSave_Clicked);
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(245, 189);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(70, 23);
			this.bCancel.TabIndex = 11;
			this.bCancel.Text = "Отменить";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Clicked);
			// 
			// bEdit
			// 
			this.bEdit.Location = new System.Drawing.Point(18, 197);
			this.bEdit.Name = "bEdit";
			this.bEdit.Size = new System.Drawing.Size(102, 23);
			this.bEdit.TabIndex = 12;
			this.bEdit.Text = "Редактироваать";
			this.bEdit.UseVisualStyleBackColor = true;
			this.bEdit.Click += new System.EventHandler(this.bEdit_Clicked);
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(8, 12);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(51, 23);
			this.bBack.TabIndex = 13;
			this.bBack.Text = "Назад";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Clicked);
			// 
			// empProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 239);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.bEdit);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.tbMail);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.tbPost);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "empProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEmpProfile_Closing);
			this.Load += new System.EventHandler(this.empProfile_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbPost;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.TextBox tbMail;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bEdit;
		private System.Windows.Forms.Button bBack;
	}
}