/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 12/5/2017
 * Time: 6:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlpStores
{
	partial class balReport
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.balDate = new System.Windows.Forms.Label();
			this.balancerpt = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.reportDocument = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.balancerpt)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(43, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "CATALOGUED ITEMS BALANCES AS AT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// balDate
			// 
			this.balDate.Location = new System.Drawing.Point(272, 34);
			this.balDate.Name = "balDate";
			this.balDate.Size = new System.Drawing.Size(100, 18);
			this.balDate.TabIndex = 1;
			// 
			// balancerpt
			// 
			this.balancerpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.balancerpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.balancerpt.Location = new System.Drawing.Point(30, 90);
			this.balancerpt.Name = "balancerpt";
			this.balancerpt.Size = new System.Drawing.Size(510, 152);
			this.balancerpt.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(406, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "PRINT REPORT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// reportDocument
			// 
			this.reportDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ReportDocumentPrintPage);
			// 
			// balReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 243);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.balancerpt);
			this.Controls.Add(this.balDate);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "balReport";
			this.Text = "ITEM BALANCES REPORT";
			((System.ComponentModel.ISupportInitialize)(this.balancerpt)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Drawing.Printing.PrintDocument reportDocument;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView balancerpt;
		private System.Windows.Forms.Label balDate;
		private System.Windows.Forms.Label label1;
	}
}
