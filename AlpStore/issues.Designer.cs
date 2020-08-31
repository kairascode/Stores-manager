/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 12:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlpStores
{
	partial class issues
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
            this.isitem = new System.Windows.Forms.GroupBox();
            this.gateData = new System.Windows.Forms.DataGridView();
            this.snoitem = new System.Windows.Forms.GroupBox();
            this.snoto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.snofrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.station = new System.Windows.Forms.TextBox();
            this.recofficer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reqofficer = new System.Windows.Forms.TextBox();
            this.qtyissued = new System.Windows.Forms.TextBox();
            this.voucherno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.stassign = new System.Windows.Forms.GroupBox();
            this.assignStation = new System.Windows.Forms.ComboBox();
            this.isitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gateData)).BeginInit();
            this.snoitem.SuspendLayout();
            this.stassign.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM DESCRIPTION";
            // 
            // itmselect
            // 
            this.itmselect.AllowDrop = true;
            this.itmselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itmselect.FormattingEnabled = true;
            this.itmselect.Location = new System.Drawing.Point(145, 9);
            this.itmselect.Name = "itmselect";
            this.itmselect.Size = new System.Drawing.Size(150, 21);
            this.itmselect.Sorted = true;
            this.itmselect.TabIndex = 1;
            this.itmselect.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // isitem
            // 
            this.isitem.Controls.Add(this.gateData);
            this.isitem.Controls.Add(this.snoitem);
            this.isitem.Controls.Add(this.station);
            this.isitem.Controls.Add(this.recofficer);
            this.isitem.Controls.Add(this.button1);
            this.isitem.Controls.Add(this.reqofficer);
            this.isitem.Controls.Add(this.qtyissued);
            this.isitem.Controls.Add(this.voucherno);
            this.isitem.Controls.Add(this.label6);
            this.isitem.Controls.Add(this.label5);
            this.isitem.Controls.Add(this.label4);
            this.isitem.Controls.Add(this.label3);
            this.isitem.Controls.Add(this.label2);
            this.isitem.Location = new System.Drawing.Point(60, 46);
            this.isitem.Name = "isitem";
            this.isitem.Size = new System.Drawing.Size(682, 356);
            this.isitem.TabIndex = 2;
            this.isitem.TabStop = false;
            this.isitem.Visible = false;
            // 
            // gateData
            // 
            this.gateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gateData.Location = new System.Drawing.Point(0, 203);
            this.gateData.Name = "gateData";
            this.gateData.Size = new System.Drawing.Size(682, 150);
            this.gateData.TabIndex = 14;
            // 
            // snoitem
            // 
            this.snoitem.Controls.Add(this.snoto);
            this.snoitem.Controls.Add(this.label8);
            this.snoitem.Controls.Add(this.snofrom);
            this.snoitem.Controls.Add(this.label7);
            this.snoitem.Location = new System.Drawing.Point(285, 93);
            this.snoitem.Name = "snoitem";
            this.snoitem.Size = new System.Drawing.Size(360, 52);
            this.snoitem.TabIndex = 13;
            this.snoitem.TabStop = false;
            this.snoitem.Text = "SERIAL";
            // 
            // snoto
            // 
            this.snoto.Location = new System.Drawing.Point(214, 19);
            this.snoto.MaxLength = 9;
            this.snoto.Name = "snoto";
            this.snoto.Size = new System.Drawing.Size(140, 20);
            this.snoto.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(192, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "TO";
            // 
            // snofrom
            // 
            this.snofrom.Location = new System.Drawing.Point(57, 18);
            this.snofrom.MaxLength = 9;
            this.snofrom.Name = "snofrom";
            this.snofrom.Size = new System.Drawing.Size(129, 20);
            this.snofrom.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "FROM";
            // 
            // station
            // 
            this.station.Location = new System.Drawing.Point(95, 60);
            this.station.MaxLength = 30;
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(175, 20);
            this.station.TabIndex = 12;
            // 
            // recofficer
            // 
            this.recofficer.Location = new System.Drawing.Point(95, 104);
            this.recofficer.MaxLength = 30;
            this.recofficer.Name = "recofficer";
            this.recofficer.Size = new System.Drawing.Size(175, 20);
            this.recofficer.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ISSUE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // reqofficer
            // 
            this.reqofficer.Location = new System.Drawing.Point(409, 18);
            this.reqofficer.MaxLength = 30;
            this.reqofficer.Name = "reqofficer";
            this.reqofficer.Size = new System.Drawing.Size(195, 20);
            this.reqofficer.TabIndex = 7;
            // 
            // qtyissued
            // 
            this.qtyissued.Location = new System.Drawing.Point(376, 58);
            this.qtyissued.Name = "qtyissued";
            this.qtyissued.Size = new System.Drawing.Size(228, 20);
            this.qtyissued.TabIndex = 6;
            // 
            // voucherno
            // 
            this.voucherno.Location = new System.Drawing.Point(95, 19);
            this.voucherno.MaxLength = 7;
            this.voucherno.Name = "voucherno";
            this.voucherno.Size = new System.Drawing.Size(175, 20);
            this.voucherno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "STATION";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(7, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "RECEIVED BY";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(285, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "REQUISITIONED BY";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(285, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "QUANTITTY ISSUED";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "VOUCHER NO";
            // 
            // stassign
            // 
            this.stassign.Controls.Add(this.assignStation);
            this.stassign.Location = new System.Drawing.Point(469, 9);
            this.stassign.Name = "stassign";
            this.stassign.Size = new System.Drawing.Size(202, 40);
            this.stassign.TabIndex = 5;
            this.stassign.TabStop = false;
            this.stassign.Text = "ASSIGNED STATION";
            this.stassign.Visible = false;
            // 
            // assignStation
            // 
            this.assignStation.AllowDrop = true;
            this.assignStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignStation.FormattingEnabled = true;
            this.assignStation.Location = new System.Drawing.Point(45, 13);
            this.assignStation.Name = "assignStation";
            this.assignStation.Size = new System.Drawing.Size(150, 21);
            this.assignStation.Sorted = true;
            this.assignStation.TabIndex = 2;
            this.assignStation.SelectedIndexChanged += new System.EventHandler(this.assignStation_SelectedIndexChanged_1);
            // 
            // issues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(866, 461);
            this.Controls.Add(this.stassign);
            this.Controls.Add(this.isitem);
            this.Controls.Add(this.itmselect);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "issues";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "S11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.issues_Load);
            this.isitem.ResumeLayout(false);
            this.isitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gateData)).EndInit();
            this.snoitem.ResumeLayout(false);
            this.snoitem.PerformLayout();
            this.stassign.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox snoto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox snofrom;
		private System.Windows.Forms.GroupBox snoitem;
		private System.Windows.Forms.TextBox recofficer;
		private System.Windows.Forms.TextBox station;
		private System.Windows.Forms.TextBox voucherno;
		private System.Windows.Forms.TextBox qtyissued;
		private System.Windows.Forms.TextBox reqofficer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox isitem;
		private System.Windows.Forms.ComboBox itmselect;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gateData;
        private System.Windows.Forms.GroupBox stassign;
        private System.Windows.Forms.ComboBox assignStation;
    }
}
