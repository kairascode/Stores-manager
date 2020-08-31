/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlpStores
{
	partial class NewItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.itemcode = new System.Windows.Forms.TextBox();
            this.itemdesc = new System.Windows.Forms.TextBox();
            this.additem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rddeserial = new System.Windows.Forms.RadioButton();
            this.rdserial = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM CODE";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(190, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPTION";
            // 
            // itemcode
            // 
            this.itemcode.Location = new System.Drawing.Point(84, 29);
            this.itemcode.Name = "itemcode";
            this.itemcode.ReadOnly = true;
            this.itemcode.Size = new System.Drawing.Size(100, 20);
            this.itemcode.TabIndex = 2;
            // 
            // itemdesc
            // 
            this.itemdesc.Location = new System.Drawing.Point(284, 26);
            this.itemdesc.Name = "itemdesc";
            this.itemdesc.Size = new System.Drawing.Size(124, 20);
            this.itemdesc.TabIndex = 3;
            // 
            // additem
            // 
            this.additem.Location = new System.Drawing.Point(427, 65);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(68, 23);
            this.additem.TabIndex = 4;
            this.additem.Text = "ADD";
            this.additem.UseVisualStyleBackColor = true;
            this.additem.Click += new System.EventHandler(this.AdditemClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(621, 163);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(414, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "TYPE";
            // 
            // rddeserial
            // 
            this.rddeserial.Location = new System.Drawing.Point(579, 20);
            this.rddeserial.Name = "rddeserial";
            this.rddeserial.Size = new System.Drawing.Size(104, 24);
            this.rddeserial.TabIndex = 8;
            this.rddeserial.TabStop = true;
            this.rddeserial.Text = "DESERIALIZED";
            this.rddeserial.UseVisualStyleBackColor = true;
            // 
            // rdserial
            // 
            this.rdserial.Location = new System.Drawing.Point(469, 20);
            this.rdserial.Name = "rdserial";
            this.rdserial.Size = new System.Drawing.Size(104, 24);
            this.rdserial.TabIndex = 9;
            this.rdserial.TabStop = true;
            this.rdserial.Text = "SERIALIZED";
            this.rdserial.UseVisualStyleBackColor = true;
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(711, 304);
            this.Controls.Add(this.rdserial);
            this.Controls.Add(this.rddeserial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.itemdesc);
            this.Controls.Add(this.itemcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewItem";
            this.Opacity = 0.9D;
            this.Text = "NewItem";
            this.Load += new System.EventHandler(this.NewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.RadioButton rdserial;
		private System.Windows.Forms.RadioButton rddeserial;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button additem;
		private System.Windows.Forms.TextBox itemdesc;
		private System.Windows.Forms.TextBox itemcode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
