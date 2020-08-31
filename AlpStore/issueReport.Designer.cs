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
	partial class issueReport
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
			this.itemcode = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtfrom = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.dtto = new System.Windows.Forms.DateTimePicker();
			this.issrptbtn = new System.Windows.Forms.Button();
			this.issrptview = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.totalissues = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.issrptview)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "ITEM DESCRIPTION";
			// 
			// itemcode
			// 
			this.itemcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.itemcode.FormattingEnabled = true;
			this.itemcode.Location = new System.Drawing.Point(135, 28);
			this.itemcode.Name = "itemcode";
			this.itemcode.Size = new System.Drawing.Size(128, 21);
			this.itemcode.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(270, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "REPORT PERIOD FROM";
			// 
			// dtfrom
			// 
			this.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtfrom.Location = new System.Drawing.Point(400, 28);
			this.dtfrom.Name = "dtfrom";
			this.dtfrom.Size = new System.Drawing.Size(100, 20);
			this.dtfrom.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(507, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "TO";
			// 
			// dtto
			// 
			this.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtto.Location = new System.Drawing.Point(533, 27);
			this.dtto.Name = "dtto";
			this.dtto.Size = new System.Drawing.Size(95, 20);
			this.dtto.TabIndex = 5;
			// 
			// issrptbtn
			// 
			this.issrptbtn.Location = new System.Drawing.Point(649, 26);
			this.issrptbtn.Name = "issrptbtn";
			this.issrptbtn.Size = new System.Drawing.Size(75, 23);
			this.issrptbtn.TabIndex = 6;
			this.issrptbtn.Text = "VIEW";
			this.issrptbtn.UseVisualStyleBackColor = true;
			this.issrptbtn.Click += new System.EventHandler(this.IssrptbtnClick);
			// 
			// issrptview
			// 
			this.issrptview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.issrptview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.issrptview.Location = new System.Drawing.Point(36, 98);
			this.issrptview.Name = "issrptview";
			this.issrptview.Size = new System.Drawing.Size(813, 150);
			this.issrptview.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(71, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "TOTAL ISSUED";
			// 
			// totalissues
			// 
			this.totalissues.Location = new System.Drawing.Point(163, 69);
			this.totalissues.Name = "totalissues";
			this.totalissues.ReadOnly = true;
			this.totalissues.Size = new System.Drawing.Size(100, 20);
			this.totalissues.TabIndex = 9;
			// 
			// issueReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 328);
			this.Controls.Add(this.totalissues);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.issrptview);
			this.Controls.Add(this.issrptbtn);
			this.Controls.Add(this.dtto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtfrom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.itemcode);
			this.Controls.Add(this.label1);
			this.Name = "issueReport";
			this.Text = "REPORT ON ISSUES DONE";
			((System.ComponentModel.ISupportInitialize)(this.issrptview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox totalissues;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView issrptview;
		private System.Windows.Forms.Button issrptbtn;
		private System.Windows.Forms.DateTimePicker dtto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtfrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox itemcode;
		private System.Windows.Forms.Label label1;
	}
}
