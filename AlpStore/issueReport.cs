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
	/// Description of issueReport.
	/// </summary>
	public partial class issueReport : Form
	{
		
		string conn=System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;
		
		public issueReport()
		{
			
			InitializeComponent();
			
			getList();
		}
		
		public void getList(){
			
			try{
		
			MySqlConnection connect=new MySqlConnection(conn);
			connect.Open();	
			string query="select description from items  ";
			
			MySqlCommand cmd=new MySqlCommand(query,connect);
			
			MySqlDataReader reader;
			
			reader=cmd.ExecuteReader();
			
			while(reader.Read()){
			
				string itm=reader.GetString("description");
				
				itemcode.Items.Add(itm);
			}
			
			connect.Close();
			}catch(Exception ex){
				
				MessageBox.Show(ex.Message);
			}	
		}
		
		
		public void retrieveInfo(){
			DateTime dtfroms=DateTime.Parse(dtfrom.Value.ToString());
			DateTime dttos=DateTime.Parse(dtto.Value.ToString());
			
			string itm= itemcode.Text.ToString();
			
			string query1="select * from issues where itemcode=(select itemcode from items where description=@itemdesc) and issuedate between @dtfrom and @dtto order by issueid desc";
			
			MySqlConnection retCon=new MySqlConnection(conn);
			MySqlCommand retcom= new MySqlCommand(query1,retCon);
			retcom.Parameters.AddWithValue("@dtfrom",dtfroms);
			retcom.Parameters.AddWithValue("@dtto",dttos);
			retcom.Parameters.AddWithValue("@itemdesc",itm);
			
			MySqlDataAdapter retadapt= new MySqlDataAdapter(retcom);
			DataTable ds= new DataTable();
				
				retadapt.Fill(ds);
				
				issrptview.ReadOnly=true;
				
				issrptview.DataSource=ds;
				
				int sum=0;
				
				 for (int i = 0; i < issrptview.Rows.Count; ++i)
					{
				 	sum += Convert.ToInt32(issrptview.Rows[i].Cells[8].Value);
					}
				
				totalissues.Text=sum.ToString();
			
		}
		
		
		
		
		void IssrptbtnClick(object sender, EventArgs e)
		{
			
			retrieveInfo();
				
		}
        
	}
}
