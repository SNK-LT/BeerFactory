namespace BeerFactory
{
	partial class purchMakeOrder
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
			this.dgwMakeOrder = new System.Windows.Forms.DataGridView();
			this.bMakeOrder = new System.Windows.Forms.Button();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.bBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwMakeOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwMakeOrder
			// 
			this.dgwMakeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwMakeOrder.Location = new System.Drawing.Point(12, 41);
			this.dgwMakeOrder.Name = "dgwMakeOrder";
			this.dgwMakeOrder.Size = new System.Drawing.Size(964, 257);
			this.dgwMakeOrder.TabIndex = 0;
			this.dgwMakeOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwg_CellClicked);
			// 
			// bMakeOrder
			// 
			this.bMakeOrder.Location = new System.Drawing.Point(362, 307);
			this.bMakeOrder.Name = "bMakeOrder";
			this.bMakeOrder.Size = new System.Drawing.Size(147, 31);
			this.bMakeOrder.TabIndex = 1;
			this.bMakeOrder.Text = "Оформить заказ";
			this.bMakeOrder.UseVisualStyleBackColor = true;
			this.bMakeOrder.Click += new System.EventHandler(this.bMakeOrder_Clicked);
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(12, 313);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(344, 20);
			this.tbAddress.TabIndex = 2;
			this.tbAddress.Text = "Введите адрес доставки";
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(12, 12);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(55, 23);
			this.bBack.TabIndex = 3;
			this.bBack.Text = "Назад";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Clicked);
			// 
			// purchMakeOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(988, 453);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.bMakeOrder);
			this.Controls.Add(this.dgwMakeOrder);
			this.Name = "purchMakeOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPurchMakeOrder_Closing);
			this.Load += new System.EventHandler(this.purchMakeOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwMakeOrder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwMakeOrder;
		private System.Windows.Forms.Button bMakeOrder;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Button bBack;
	}
}