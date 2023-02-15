namespace BeerFactory
{
	partial class empStatus
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
			this.tbcurStatus = new System.Windows.Forms.Label();
			this.bChangeStatus = new System.Windows.Forms.Button();
			this.cbStatuses = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbMess = new System.Windows.Forms.TextBox();
			this.bSend = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.bBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(143, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ваш текущий статус:";
			// 
			// tbcurStatus
			// 
			this.tbcurStatus.AutoSize = true;
			this.tbcurStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbcurStatus.Location = new System.Drawing.Point(359, 9);
			this.tbcurStatus.Name = "tbcurStatus";
			this.tbcurStatus.Size = new System.Drawing.Size(78, 25);
			this.tbcurStatus.TabIndex = 1;
			this.tbcurStatus.Text = "Статус";
			// 
			// bChangeStatus
			// 
			this.bChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bChangeStatus.Location = new System.Drawing.Point(81, 60);
			this.bChangeStatus.Name = "bChangeStatus";
			this.bChangeStatus.Size = new System.Drawing.Size(319, 34);
			this.bChangeStatus.TabIndex = 2;
			this.bChangeStatus.Text = "Запросить изменение статуса";
			this.bChangeStatus.UseVisualStyleBackColor = true;
			this.bChangeStatus.Click += new System.EventHandler(this.bChangeStatus_Clicked);
			// 
			// cbStatuses
			// 
			this.cbStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbStatuses.FormattingEnabled = true;
			this.cbStatuses.Location = new System.Drawing.Point(217, 115);
			this.cbStatuses.Name = "cbStatuses";
			this.cbStatuses.Size = new System.Drawing.Size(183, 33);
			this.cbStatuses.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(76, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Новый статус";
			// 
			// tbMess
			// 
			this.tbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbMess.Location = new System.Drawing.Point(81, 177);
			this.tbMess.Multiline = true;
			this.tbMess.Name = "tbMess";
			this.tbMess.Size = new System.Drawing.Size(319, 215);
			this.tbMess.TabIndex = 5;
			// 
			// bSend
			// 
			this.bSend.Location = new System.Drawing.Point(325, 398);
			this.bSend.Name = "bSend";
			this.bSend.Size = new System.Drawing.Size(75, 23);
			this.bSend.TabIndex = 6;
			this.bSend.Text = "Отправить";
			this.bSend.UseVisualStyleBackColor = true;
			this.bSend.Click += new System.EventHandler(this.bSend_Clicked);
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(244, 398);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 23);
			this.bCancel.TabIndex = 7;
			this.bCancel.Text = "Отмена";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Clicked);
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(12, 12);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(50, 23);
			this.bBack.TabIndex = 8;
			this.bBack.Text = "Назад";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Clicked);
			// 
			// empStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 431);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bSend);
			this.Controls.Add(this.tbMess);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbStatuses);
			this.Controls.Add(this.bChangeStatus);
			this.Controls.Add(this.tbcurStatus);
			this.Controls.Add(this.label1);
			this.Name = "empStatus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEmpStatus_Closing);
			this.Load += new System.EventHandler(this.empStatus_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label tbcurStatus;
		private System.Windows.Forms.Button bChangeStatus;
		private System.Windows.Forms.ComboBox cbStatuses;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbMess;
		private System.Windows.Forms.Button bSend;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bBack;
	}
}