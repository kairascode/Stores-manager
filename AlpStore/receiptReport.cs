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
	/// Description of receiptReport.
	/// </summary>
	public partial class receiptReport : Form
	{
		string conn=System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;
		public receiptReport()
		{
			
			InitializeComponent();
			
			
			getList();
		}
		
		public void getList(){
			
			/*issues n= new issues();
			n.fillCombo();*/
			try{
		
			MySqlConnection connect=new MySqlConnection(conn);
			connect.Open();	
			string query="select description from items  ";
			
			MySqlCommand cmd=new MySqlCommand(query,connect);
			
			MySqlDataReader reader;
			
			reader=cmd.ExecuteReader();
			
			while(reader.Read()){
			
				string itm=reader.GetString("description");
				
				itmselect.Items.Add(itm);
			}
			
			connect.Close();
			}catch(Exception ex){
				
				MessageBox.Show(ex.Message);
			}	
		}
		
		public void retrieveInfo(){
			DateTime dtfroms=DateTime.Parse(dtFrom.Text.ToString());
			DateTime dttos=DateTime.Parse(dtTo.Text.ToString());
			
			string itm= itmselect.Text.ToString();
			
			string query1="select * from receivables where itemcode=(select itemcode from items where description=@itemdesc) and  datereceived between @dtfrom and @dtto";
			
			MySqlConnection retCon=new MySqlConnection(conn);
			MySqlCommand retcom= new MySqlCommand(query1,retCon);
			retcom.Parameters.AddWithValue("@dtfrom",dtfroms);
			retcom.Parameters.AddWithValue("@dtto",dttos);
			retcom.Parameters.AddWithValue("@itemdesc",itm);
			
			MySqlDataAdapter retadapt= new MySqlDataAdapter(retcom);
			DataTable ds= new DataTable();
				
				retadapt.Fill(ds);
				
				receiptRpt.ReadOnly=true;
            //receiptRpt.Name = "RECEIPTS";
				
				receiptRpt.DataSource=ds;
				
				int sum=0;
				
				 for (int i = 0; i < receiptRpt.Rows.Count; ++i)
					{
				 	sum += Convert.ToInt32(receiptRpt.Rows[i].Cells[7].Value);
					}
				
				totalreceived.Text=sum.ToString();
			
		}
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			retrieveInfo();
		}
	}
}
