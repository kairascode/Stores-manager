/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 12/5/2017
 * Time: 6:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace AlpStores
{
	/// <summary>
	/// Description of balReport.
	/// </summary>
	public partial class balReport : Form
	{
		string conn=System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;
		public balReport()
		{
			
			InitializeComponent();
			
			DateTime tym= DateTime.Now;
			balDate.Text=tym.ToString();
			
			getBalances();
			
		}
		public void print()
        {
            /*PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);
            PaperSize psize = new PaperSize("Custom", 100, 200);
            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }
*/
        }
		
		public void getBalances(){
		
			MySqlConnection balconn= new MySqlConnection(conn);
			
			string query1="select * from items order by description asc";
			
			MySqlCommand balcommand= new MySqlCommand(query1,balconn);
			
			MySqlDataAdapter baladapt= new MySqlDataAdapter(balcommand);
			
			DataTable dt= new DataTable();
			
			baladapt.Fill(dt);
			
			balancerpt.ReadOnly=true;
			balancerpt.DataSource=dt;
			
		
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			reportDocument.Print();
		}
		
		void ReportDocumentPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Bitmap bm= new Bitmap(this.balancerpt.Width, this.balancerpt.Height);
			balancerpt.DrawToBitmap(bm,new Rectangle(0,0,this.balancerpt.Width, this.balancerpt.Height));
			
			e.Graphics.DrawImage(bm,10,10);
		}
		}
		
		
}



