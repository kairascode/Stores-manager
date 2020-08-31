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
	partial class receiptReport
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
            this.itmselect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.recrptbtn = new System.Windows.Forms.Button();
            this.receiptRpt = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.totalreceived = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.receiptRpt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM DESCRIPTION";
            // 
            // itmselect
            // 
            this.itmselect.AllowDrop = true;
            this.itmselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itmselect.FormattingEnabled = true;
            this.itmselect.Location = new System.Drawing.Point(119, 10);
            this.itmselect.Name = "itmselect";
            this.itmselect.Size = new System.Drawing.Size(161, 21);
            this.itmselect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(286, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "REPORT PERIOD FROM";
            this.label2.Click += new System.EventHandler(this.Label2Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(417, 10);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(103, 20);
            this.dtFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(527, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "TO";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(556, 10);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(103, 20);
            this.dtTo.TabIndex = 5;
            // 
            // recrptbtn
            // 
            this.recrptbtn.Location = new System.Drawing.Point(665, 10);
            this.recrptbtn.Name = "recrptbtn";
            this.recrptbtn.Size = new System.Drawing.Size(75, 23);
            this.recrptbtn.TabIndex = 6;
            this.recrptbtn.Text = "VIEW";
            this.recrptbtn.UseVisualStyleBackColor = true;
            this.recrptbtn.Click += new System.EventHandler(this.Button1Click);
            // 
            // receiptRpt
            // 
            this.receiptRpt.AllowUserToDeleteRows = false;
            this.receiptRpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receiptRpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptRpt.Location = new System.Drawing.Point(13, 75);
            this.receiptRpt.Name = "receiptRpt";
            this.receiptRpt.ReadOnly = true;
            this.receiptRpt.Size = new System.Drawing.Size(800, 150);
            this.receiptRpt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "TOTAL RECEIVED";
            // 
            // totalreceived
            // 
            this.totalreceived.Location = new System.Drawing.Point(130, 49);
            this.totalreceived.Name = "totalreceived";
            this.totalreceived.ReadOnly = true;
            this.totalreceived.Size = new System.Drawing.Size(100, 20);
            this.totalreceived.TabIndex = 10;
            // 
            // receiptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 261);
            this.Controls.Add(this.totalreceived);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.receiptRpt);
            this.Controls.Add(this.recrptbtn);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itmselect);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "receiptReport";
            this.Text = "REPORT ON RECEIPTS";
            ((System.ComponentModel.ISupportInitialize)(this.receiptRpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox totalreceived;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView receiptRpt;
		private System.Windows.Forms.Button recrptbtn;
		private System.Windows.Forms.DateTimePicker dtTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox itmselect;
		private System.Windows.Forms.Label label1;
	}
}
