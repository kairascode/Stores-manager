/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 12:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlpStores
{
	partial class receipts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stnbox = new System.Windows.Forms.GroupBox();
            this.asstation = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoitem = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FROM = new System.Windows.Forms.Label();
            this.snoto = new System.Windows.Forms.TextBox();
            this.snofrom = new System.Windows.Forms.TextBox();
            this.vno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recDate = new System.Windows.Forms.DateTimePicker();
            this.itemunit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recItem = new System.Windows.Forms.Button();
            this.Qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.stnbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.snoitem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.stnbox);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.snoitem);
            this.groupBox1.Controls.Add(this.vno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.recDate);
            this.groupBox1.Controls.Add(this.itemunit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.recItem);
            this.groupBox1.Controls.Add(this.Qty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Supplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECEIPT AREA";
            // 
            // stnbox
            // 
            this.stnbox.Controls.Add(this.asstation);
            this.stnbox.Location = new System.Drawing.Point(18, 113);
            this.stnbox.Name = "stnbox";
            this.stnbox.Size = new System.Drawing.Size(155, 52);
            this.stnbox.TabIndex = 18;
            this.stnbox.TabStop = false;
            this.stnbox.Text = "ASSIGN STATION";
            this.stnbox.Visible = false;
            // 
            // asstation
            // 
            this.asstation.Location = new System.Drawing.Point(6, 22);
            this.asstation.Name = "asstation";
            this.asstation.Size = new System.Drawing.Size(143, 20);
            this.asstation.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // snoitem
            // 
            this.snoitem.Controls.Add(this.label7);
            this.snoitem.Controls.Add(this.FROM);
            this.snoitem.Controls.Add(this.snoto);
            this.snoitem.Controls.Add(this.snofrom);
            this.snoitem.Location = new System.Drawing.Point(484, 102);
            this.snoitem.Name = "snoitem";
            this.snoitem.Size = new System.Drawing.Size(286, 69);
            this.snoitem.TabIndex = 16;
            this.snoitem.TabStop = false;
            this.snoitem.Text = "SERIAL NO";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(64, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "TO";
            // 
            // FROM
            // 
            this.FROM.Location = new System.Drawing.Point(64, 22);
            this.FROM.Name = "FROM";
            this.FROM.Size = new System.Drawing.Size(62, 20);
            this.FROM.TabIndex = 2;
            this.FROM.Text = "FROM";
            // 
            // snoto
            // 
            this.snoto.Location = new System.Drawing.Point(132, 43);
            this.snoto.MaxLength = 9;
            this.snoto.Name = "snoto";
            this.snoto.Size = new System.Drawing.Size(139, 20);
            this.snoto.TabIndex = 1;
            // 
            // snofrom
            // 
            this.snofrom.Location = new System.Drawing.Point(132, 19);
            this.snofrom.MaxLength = 9;
            this.snofrom.Name = "snofrom";
            this.snofrom.Size = new System.Drawing.Size(139, 20);
            this.snofrom.TabIndex = 0;
            // 
            // vno
            // 
            this.vno.Location = new System.Drawing.Point(389, 25);
            this.vno.MaxLength = 7;
            this.vno.Name = "vno";
            this.vno.Size = new System.Drawing.Size(162, 20);
            this.vno.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(305, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "VOUCHER No";
            // 
            // recDate
            // 
            this.recDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.recDate.Location = new System.Drawing.Point(352, 76);
            this.recDate.Name = "recDate";
            this.recDate.Size = new System.Drawing.Size(119, 20);
            this.recDate.TabIndex = 13;
            // 
            // itemunit
            // 
            this.itemunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemunit.FormattingEnabled = true;
            this.itemunit.Location = new System.Drawing.Point(569, 75);
            this.itemunit.Name = "itemunit";
            this.itemunit.Size = new System.Drawing.Size(199, 21);
            this.itemunit.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(484, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "UNIT";
            // 
            // recItem
            // 
            this.recItem.BackColor = System.Drawing.Color.Thistle;
            this.recItem.Location = new System.Drawing.Point(352, 139);
            this.recItem.Name = "recItem";
            this.recItem.Size = new System.Drawing.Size(105, 23);
            this.recItem.TabIndex = 8;
            this.recItem.Text = "RECEIVE";
            this.recItem.UseVisualStyleBackColor = false;
            this.recItem.Click += new System.EventHandler(this.RecItemClick);
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(660, 25);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(108, 20);
            this.Qty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(569, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUANTITY";
            // 
            // Supplier
            // 
            this.Supplier.Location = new System.Drawing.Point(90, 75);
            this.Supplier.MaxLength = 30;
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(160, 20);
            this.Supplier.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "SUPPLIER";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(268, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATE";
            // 
            // itemCode
            // 
            this.itemCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCode.FormattingEnabled = true;
            this.itemCode.Items.AddRange(new object[] {
            ""});
            this.itemCode.Location = new System.Drawing.Point(85, 27);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(199, 21);
            this.itemCode.TabIndex = 1;
            this.itemCode.SelectedIndexChanged += new System.EventHandler(this.ItemCodeSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM ";
            // 
            // receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(794, 344);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "receipts";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RECEIPTS";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.receipts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.stnbox.ResumeLayout(false);
            this.stnbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.snoitem.ResumeLayout(false);
            this.snoitem.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox snofrom;
		private System.Windows.Forms.TextBox snoto;
		private System.Windows.Forms.Label FROM;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox snoitem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox vno;
		private System.Windows.Forms.DateTimePicker recDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox itemunit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Qty;
		private System.Windows.Forms.Button recItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox itemCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Supplier;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox stnbox;
        private System.Windows.Forms.TextBox asstation;
    }
}
