namespace BeerFactory
{
	partial class AdminForm
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
			this.bStatuses = new System.Windows.Forms.Button();
			this.bOrders = new System.Windows.Forms.Button();
			this.bEmp = new System.Windows.Forms.Button();
			this.bPurch = new System.Windows.Forms.Button();
			this.bExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bStatuses
			// 
			this.bStatuses.Location = new System.Drawing.Point(12, 12);
			this.bStatuses.Name = "bStatuses";
			this.bStatuses.Size = new System.Drawing.Size(190, 36);
			this.bStatuses.TabIndex = 0;
			this.bStatuses.Text = "Запросы сотрудников";
			this.bStatuses.UseVisualStyleBackColor = true;
			this.bStatuses.Click += new System.EventHandler(this.bStatuses_Click);
			// 
			// bOrders
			// 
			this.bOrders.Location = new System.Drawing.Point(12, 54);
			this.bOrders.Name = "bOrders";
			this.bOrders.Size = new System.Drawing.Size(190, 36);
			this.bOrders.TabIndex = 1;
			this.bOrders.Text = "Заказы клиентов";
			this.bOrders.UseVisualStyleBackColor = true;
			this.bOrders.Click += new System.EventHandler(this.bPurchOrders_Click);
			// 
			// bEmp
			// 
			this.bEmp.Location = new System.Drawing.Point(232, 12);
			this.bEmp.Name = "bEmp";
			this.bEmp.Size = new System.Drawing.Size(190, 36);
			this.bEmp.TabIndex = 2;
			this.bEmp.Text = "Сотрудники";
			this.bEmp.UseVisualStyleBackColor = true;
			this.bEmp.Click += new System.EventHandler(this.bEmp_Click);
			// 
			// bPurch
			// 
			this.bPurch.Location = new System.Drawing.Point(232, 54);
			this.bPurch.Name = "bPurch";
			this.bPurch.Size = new System.Drawing.Size(190, 36);
			this.bPurch.TabIndex = 3;
			this.bPurch.Text = "Клиенты";
			this.bPurch.UseVisualStyleBackColor = true;
			this.bPurch.Click += new System.EventHandler(this.bPurch_Click);
			// 
			// bExit
			// 
			this.bExit.Location = new System.Drawing.Point(181, 115);
			this.bExit.Name = "bExit";
			this.bExit.Size = new System.Drawing.Size(75, 23);
			this.bExit.TabIndex = 4;
			this.bExit.Text = "Выход";
			this.bExit.UseVisualStyleBackColor = true;
			this.bExit.Click += new System.EventHandler(this.bExit_Clicked);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 150);
			this.Controls.Add(this.bExit);
			this.Controls.Add(this.bPurch);
			this.Controls.Add(this.bEmp);
			this.Controls.Add(this.bOrders);
			this.Controls.Add(this.bStatuses);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_Closing);
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bStatuses;
		private System.Windows.Forms.Button bOrders;
		private System.Windows.Forms.Button bEmp;
		private System.Windows.Forms.Button bPurch;
		private System.Windows.Forms.Button bExit;
	}
}