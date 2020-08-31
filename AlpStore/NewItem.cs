/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
//using System.Data.Common;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace AlpStores
{
	/// <summary>
	/// Description of NewItem.
	/// </summary>
	public partial class NewItem : Form
	{
		
	string conn=System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;
		public NewItem()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			getItemcode();
			
			
			
			
		}
		public void getItemcode(){
		
			try{
				
			MySqlConnection connect;
			
			
			string query="select max(itemcode)+1 from items";
			
			connect=new MySqlConnection(conn);
			
			connect.Open();
			
			MySqlCommand cmd=new MySqlCommand(query,connect);
			
			
			MySqlDataReader reader=cmd.ExecuteReader();
						
			while(reader.Read()){
			
				string sno=reader[0].ToString();
				
				if(sno==""){
				
					itemcode.Text="100";
				
				
				}else{
					itemcode.Text=reader[0].ToString();
				}
							
			}
			
			
			}catch(Exception ex){
				
				MessageBox.Show(ex.Message);
			}
					
		}
		public void getReport(){
		
			try{
				
				
				
				MySqlConnection connect= new MySqlConnection(conn);
               
			
				string query="select * from items order by itemcode desc";
				
				MySqlCommand com= new MySqlCommand(query,connect);
				
				//com.ExecuteNonQuery();
				
				MySqlDataAdapter adapt= new MySqlDataAdapter(com);
				
				DataTable ds= new DataTable();
				//DataSet dst= new DataSet();
				adapt.Fill(ds);
				
				dataGridView1.ReadOnly=true;
				
				dataGridView1.DataSource=ds;
				
				//dataGridView1.Rows.Add(Column1);
				
			}catch(Exception ex){
			
				MessageBox.Show(ex.Message);
			
			}
		}

        public void checkUnique() {
            string itm = itemdesc.Text.ToString();
            string q1 = "select description from items where description=@itm";

           MySqlConnection conner = new MySqlConnection(conn);
            conner.Open();

            MySqlCommand cmd = new MySqlCommand(q1,conner);
            cmd.Parameters.AddWithValue("@itm",itm);

            MySqlDataReader reder;
            reder = cmd.ExecuteReader();
            if (reder.Read())
            {
                MessageBox.Show(itm + "::IS ALREADY IN THE CATALOG");
                itemdesc.Text = "";
                return;
            }
            else {

                addItems();

                conner.Close();
                return;
            }
        }
				
public void addItems(){
		
	if(itemcode.Text!=""&&itemdesc.Text!=""&&rddeserial.Checked||rdserial.Checked){
                if ((Regex.IsMatch(itemdesc.Text, "[A-Z]+")))
                {
                    try
                    {
                        string itm = itemcode.Text.ToString();

                        string itdesc = itemdesc.Text.ToString();

                        string rdvalue = "";
                        if (rdserial.Checked == true)
                        {
                            rdvalue = rdserial.Text;

                        }
                        if (rddeserial.Checked == true)
                        {

                            rdvalue = rddeserial.Text;
                        }
                        MySqlConnection conns;

                        string query = "insert into items(itemcode,description,typ)values(@itm,@desc,@type)";

                        conns = new MySqlConnection(conn);
                        conns.Open();

                        MySqlCommand com = new MySqlCommand(query, conns);
                        com.Parameters.AddWithValue("@itm", itm);
                        com.Parameters.AddWithValue("@desc", itdesc);
                        com.Parameters.AddWithValue("@type", rdvalue);

                        com.ExecuteNonQuery();

                        MessageBox.Show("item added to item list successfully");
                        itemdesc.Text = "";

                        getReport();
                        getItemcode();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }

                }
                else {
                    MessageBox.Show("INVALID DESCRIPTION DETECTED!!!","INPUT CONTROL");
                }

                }
                else {
                		MessageBox.Show("EMPTY FIELDS DETECTED","WARNING!!!");
			}
		}


        void AdditemClick(object sender, EventArgs e)
		{

            checkUnique();
			
			
		}

        private void NewItem_Load(object sender, EventArgs e)
        {

        }
    }
}
