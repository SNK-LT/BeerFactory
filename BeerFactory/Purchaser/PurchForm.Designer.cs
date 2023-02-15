namespace BeerFactory
{
	partial class PurchForm
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
			this.bMakeOrder = new System.Windows.Forms.Button();
			this.bOrders = new System.Windows.Forms.Button();
			this.bLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bMakeOrder
			// 
			this.bMakeOrder.Location = new System.Drawing.Point(42, 69);
			this.bMakeOrder.Name = "bMakeOrder";
			this.bMakeOrder.Size = new System.Drawing.Size(127, 47);
			this.bMakeOrder.TabIndex = 1;
			this.bMakeOrder.Text = "ОФОРМИТЬ ЗАКАЗ";
			this.bMakeOrder.UseVisualStyleBackColor = true;
			this.bMakeOrder.Click += new System.EventHandler(this.bMakeOrder_Clicked);
			// 
			// bOrders
			// 
			this.bOrders.Location = new System.Drawing.Point(42, 16);
			this.bOrders.Name = "bOrders";
			this.bOrders.Size = new System.Drawing.Size(127, 47);
			this.bOrders.TabIndex = 2;
			this.bOrders.Text = "МОИ ЗАКАЗЫ";
			this.bOrders.UseVisualStyleBackColor = true;
			this.bOrders.Click += new System.EventHandler(this.bOrders_Click);
			// 
			// bLogout
			// 
			this.bLogout.Location = new System.Drawing.Point(68, 135);
			this.bLogout.Name = "bLogout";
			this.bLogout.Size = new System.Drawing.Size(74, 24);
			this.bLogout.TabIndex = 3;
			this.bLogout.Text = "ВЫЙТИ";
			this.bLogout.UseVisualStyleBackColor = true;
			this.bLogout.Click += new System.EventHandler(this.bExit_Clicked);
			// 
			// PurchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(218, 190);
			this.Controls.Add(this.bLogout);
			this.Controls.Add(this.bOrders);
			this.Controls.Add(this.bMakeOrder);
			this.Name = "PurchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPurch_Closing);
			this.Load += new System.EventHandler(this.PurchForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button bMakeOrder;
		private System.Windows.Forms.Button bOrders;
		private System.Windows.Forms.Button bLogout;
	}
}