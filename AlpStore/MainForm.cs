/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 11:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlpStores
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		DateTime tym= DateTime.UtcNow;
		alpTime.Text=tym.ToString();
		
		}
		
		void QUARTERLYToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void RECEIVEToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.IsMdiContainer=false;
			this.IsMdiContainer=true;
			receipts recs= new receipts();
			recs.MdiParent=this;
			recs.Show();
			this.LayoutMdi(MdiLayout.Cascade);
			
		}
		
		void ADDNEWITEMToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.IsMdiContainer=false;
			this.IsMdiContainer=true;
			NewItem nitem= new NewItem();
			nitem.MdiParent=this;
			nitem.Show();
			this.LayoutMdi(MdiLayout.Cascade);	
		}
		
		void DELETEITEMToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void PRINTGATEPASSToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.IsMdiContainer=false;
			this.IsMdiContainer=true;
			gatePass gpass= new gatePass();
			gpass.MdiParent=this;
			gpass.Show();
			this.LayoutMdi(MdiLayout.Cascade);			
		}
		
		void LOGOUTToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			DialogResult res=MessageBox.Show("Are you sure you want to exit?","ALERT!!!",MessageBoxButtons.YesNo);
			
			if(res == DialogResult.Yes)
					{
    					this.Dispose();
               
                Index ind = new Index();
                ind.Show();

					}
			else if (res == DialogResult.No)
					{
    		
					}
			
		}
		
		void ISSUESToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.IsMdiContainer=false;
			this.IsMdiContainer=true;
			issues df= new issues();
			df.MdiParent=this;
			df.Show();
			this.LayoutMdi(MdiLayout.Cascade);	
		}
		
		void RECEIPTSToolStripMenuItem1Click(object sender, EventArgs e)
		{
			this.IsMdiContainer=false;
			this.IsMdiContainer=true;
			receiptReport recrpt= new receiptReport();
			recrpt.MdiParent=this;
			recrpt.Show();
			this.LayoutMdi(MdiLayout.Cascade);	
			
		}
		
		void ISSUESToolStripMenuItem2Click(object sender, EventArgs e)
		{
			this.IsMdiContainer=false;
			this.IsMdiContainer=true;
			issueReport issrpt= new issueReport();
			issrpt.MdiParent=this;
			issrpt.Show();
			this.LayoutMdi(MdiLayout.Cascade);	
			
		}
		
		void ITEMBALANCESToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.IsMdiContainer=false;
			this.IsMdiContainer=true;
			balReport balrpt= new balReport();
			balrpt.MdiParent=this;
			balrpt.Show();
			this.LayoutMdi(MdiLayout.Cascade);		
		}
	}
}
