/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 11:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlpStores
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sYSTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rECEIPTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rECEIVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDDNEWITEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iSSUESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iSSUESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rECEIPTSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.iSSUESToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.iTEMBALANCESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alpTime = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sYSTEMToolStripMenuItem,
									this.rECEIPTSToolStripMenuItem,
									this.iSSUESToolStripMenuItem,
									this.rEPORTSToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(1190, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sYSTEMToolStripMenuItem
			// 
			this.sYSTEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.lOGOUTToolStripMenuItem});
			this.sYSTEMToolStripMenuItem.Name = "sYSTEMToolStripMenuItem";
			this.sYSTEMToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.sYSTEMToolStripMenuItem.Text = "SYSTEM";
			// 
			// lOGOUTToolStripMenuItem
			// 
			this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
			this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.lOGOUTToolStripMenuItem.Text = "EXIT SYSTEM";
			this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.LOGOUTToolStripMenuItemClick);
			// 
			// rECEIPTSToolStripMenuItem
			// 
			this.rECEIPTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.rECEIVEToolStripMenuItem,
									this.aDDNEWITEMToolStripMenuItem});
			this.rECEIPTSToolStripMenuItem.Name = "rECEIPTSToolStripMenuItem";
			this.rECEIPTSToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
			this.rECEIPTSToolStripMenuItem.Text = "RECEIPTS";
			// 
			// rECEIVEToolStripMenuItem
			// 
			this.rECEIVEToolStripMenuItem.Name = "rECEIVEToolStripMenuItem";
			this.rECEIVEToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.rECEIVEToolStripMenuItem.Text = "RECEIVE";
			this.rECEIVEToolStripMenuItem.Click += new System.EventHandler(this.RECEIVEToolStripMenuItemClick);
			// 
			// aDDNEWITEMToolStripMenuItem
			// 
			this.aDDNEWITEMToolStripMenuItem.Name = "aDDNEWITEMToolStripMenuItem";
			this.aDDNEWITEMToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.aDDNEWITEMToolStripMenuItem.Text = "ADD NEW ITEM";
			this.aDDNEWITEMToolStripMenuItem.Click += new System.EventHandler(this.ADDNEWITEMToolStripMenuItemClick);
			// 
			// iSSUESToolStripMenuItem
			// 
			this.iSSUESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.iSSUESToolStripMenuItem1});
			this.iSSUESToolStripMenuItem.Name = "iSSUESToolStripMenuItem";
			this.iSSUESToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
			this.iSSUESToolStripMenuItem.Text = "ISSUES";
			// 
			// iSSUESToolStripMenuItem1
			// 
			this.iSSUESToolStripMenuItem1.Name = "iSSUESToolStripMenuItem1";
			this.iSSUESToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
			this.iSSUESToolStripMenuItem1.Text = "ISSUES";
			this.iSSUESToolStripMenuItem1.Click += new System.EventHandler(this.ISSUESToolStripMenuItem1Click);
			// 
			// rEPORTSToolStripMenuItem
			// 
			this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.rECEIPTSToolStripMenuItem1,
									this.iSSUESToolStripMenuItem2,
									this.iTEMBALANCESToolStripMenuItem});
			this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
			this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.rEPORTSToolStripMenuItem.Text = "REPORTS";
			// 
			// rECEIPTSToolStripMenuItem1
			// 
			this.rECEIPTSToolStripMenuItem1.Name = "rECEIPTSToolStripMenuItem1";
			this.rECEIPTSToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
			this.rECEIPTSToolStripMenuItem1.Text = "RECEIPTS";
			this.rECEIPTSToolStripMenuItem1.Click += new System.EventHandler(this.RECEIPTSToolStripMenuItem1Click);
			// 
			// iSSUESToolStripMenuItem2
			// 
			this.iSSUESToolStripMenuItem2.Name = "iSSUESToolStripMenuItem2";
			this.iSSUESToolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
			this.iSSUESToolStripMenuItem2.Text = "ISSUES";
			this.iSSUESToolStripMenuItem2.Click += new System.EventHandler(this.ISSUESToolStripMenuItem2Click);
			// 
			// iTEMBALANCESToolStripMenuItem
			// 
			this.iTEMBALANCESToolStripMenuItem.Name = "iTEMBALANCESToolStripMenuItem";
			this.iTEMBALANCESToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.iTEMBALANCESToolStripMenuItem.Text = "ITEM BALANCES";
			this.iTEMBALANCESToolStripMenuItem.Click += new System.EventHandler(this.ITEMBALANCESToolStripMenuItemClick);
			// 
			// alpTime
			// 
			this.alpTime.BackColor = System.Drawing.Color.MediumTurquoise;
			this.alpTime.Location = new System.Drawing.Point(810, 0);
			this.alpTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.alpTime.Name = "alpTime";
			this.alpTime.Size = new System.Drawing.Size(169, 24);
			this.alpTime.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Fuchsia;
			this.ClientSize = new System.Drawing.Size(1190, 667);
			this.Controls.Add(this.alpTime);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0.9D;
			this.ShowIcon = false;
			this.Text = "ALPRIDE INVENTORY MANAGEMENT SYSTEM ";
			this.TransparencyKey = System.Drawing.Color.White;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem iTEMBALANCESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iSSUESToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem rECEIPTSToolStripMenuItem1;
		private System.Windows.Forms.Label alpTime;
		private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iSSUESToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem iSSUESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDDNEWITEMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rECEIVEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rECEIPTSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sYSTEMToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
