/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 12:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AlpStores
{
    /// <summary>
    /// Description of receipts.
    /// </summary>
    public partial class receipts : Form
	{
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;
       		
		public receipts()
		{	
			InitializeComponent();
			
			fillCombo();			
		}

        public void dbUpdater() {
            string sup = Supplier.Text.ToString().ToUpper();
            DateTime dt = DateTime.Parse(recDate.Text.ToString());
            string qt = Qty.Text.ToString();
            string itm = itemCode.Text.ToString();
            string itmunit = itemunit.Text.ToString();
            string vnos = vno.Text.ToString();
            string snotos = snoto.Text.ToString();
            string ast = asstation.Text.ToString().ToUpper();
            string snofroms = snofrom.Text.ToString();

            MySqlConnection conn3 = new MySqlConnection(conn);
            conn3.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn3;
            cmd.Parameters.AddWithValue("@itemcode", itm);
            cmd.Parameters.AddWithValue("@sup", sup);
            cmd.Parameters.AddWithValue("@asstation", ast);
            cmd.Parameters.AddWithValue("@qt", qt);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@itemunit", itmunit);
            cmd.Parameters.AddWithValue("@vno", vnos);
            cmd.Parameters.AddWithValue("@snofrom", snofroms);
            cmd.Parameters.AddWithValue("@snoto", snotos);
            cmd.CommandText = "insert into receivables(itemcode,voucherno,supplier,station_assigned,snofrom,snoto,quantity,unit,datereceived,remarks)values((select itemcode from items where description=@itemcode),@vno,@sup,@asstation,@snofrom,@snoto,@qt,@itemunit,@dt,'N')";

            cmd.ExecuteNonQuery();
            
            MessageBox.Show("SUCCESSFUL RECEIPT");

            viewReceipts();
            conn3.Close();
        }

        public void calculatebal() {

            try
            {

                string itms = itemCode.Text.ToString();

                string query = "select balance from items where description=@desc";

                MySqlConnection calreccon = new MySqlConnection(conn);

                calreccon.Open();

                MySqlCommand rec = new MySqlCommand(query, calreccon);
                rec.Parameters.AddWithValue("@desc", itms);

                MySqlDataReader balreader;

                balreader = rec.ExecuteReader();

                while (balreader.Read())
                {

                    double bal = double.Parse(balreader[0].ToString());

                    string itmcode = itemCode.Text.ToString();

                    double qty = double.Parse(Qty.Text.ToString());

                    double closebal = bal + qty;

                    MySqlConnection CALconn = new MySqlConnection(conn);
                   
                    CALconn.Open();
                    string updatequery = "update items set balance=@bal where description=@desc";
                    MySqlCommand updater = new MySqlCommand(updatequery, CALconn);

                    updater.Parameters.AddWithValue("@desc", itmcode);
                    updater.Parameters.AddWithValue("@bal", closebal);

                    updater.ExecuteNonQuery();
                   

                    CALconn.Close();
                    
                    dbUpdater();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }
        public void Checktyp() {
            string itmtyp = itemCode.Text.ToString();
            
            MySqlConnection tcon = new MySqlConnection(conn);
            tcon.Open();
            string tquery = "select typ from items where description= @itmtyp";
            MySqlCommand tcom = new MySqlCommand(tquery,tcon);
            tcom.Parameters.AddWithValue("@itmtyp", itmtyp);
            MySqlDataReader tread = tcom.ExecuteReader();
            while (tread.Read())
            {
                string typresult = tread[0].ToString();
             

                if (typresult == "SERIALIZED")
                  {
                      CheckSno();
                  }
                  else
                  {
                      calculatebal();
                  }
            }
        }
        public void CheckSno() {
            //if () { }
            string snofroms = snofrom.Text.ToString();
            MySqlConnection snocon = new MySqlConnection(conn);
            snocon.Open();
            string qsno = "select snofrom from receivables where snofrom=@snos";
            MySqlCommand snocom = new MySqlCommand(qsno,snocon);
            snocom.Parameters.AddWithValue("@snos",snofroms);
            MySqlDataReader snoread=snocom.ExecuteReader();
            if (snoread.Read())
            {
                MessageBox.Show(" AN ITEM WITH SERIAL NUMBER"+snofroms+" HAS BEEN RECEIVED BEFORE...TRY AGAIN", "SYSTEM CONTROL");
                

                return;
            }
            else {
                calculatebal();

            }
            

        }


        public void itemReceipt() {

            string itm = itemCode.Text.ToString();
            string chckvno = vno.Text.ToString();
            string snofroms = snofrom.Text.ToString();
 
            MySqlConnection conn2 = new MySqlConnection(conn);
            //check empty fields
            conn2.Open();
            if (Supplier.Text != "" && recDate.Text != "" && Qty.Text != "" && itemCode.Text != "" && itemunit.Text != "" && vno.Text != "" && asstation.Text != "")
            {

                if ((Regex.IsMatch(vno.Text, "[0-9]+")) && (Regex.IsMatch(Qty.Text, "[0-9]+")) && (Regex.IsMatch(Supplier.Text, "[A-Za-z]+")) && (Regex.IsMatch(asstation.Text, "[A-Za-z]+")))
                {


                    string q1 = "select voucherno from  receivables where itemcode=(select itemcode from items where description=@itm) and voucherno=@chkvno and snofrom=@sno";

                    MySqlCommand checkunique = new MySqlCommand(q1, conn2);
                    checkunique.Parameters.AddWithValue("@chkvno", chckvno);
                    checkunique.Parameters.AddWithValue("@itm", itm);
                    checkunique.Parameters.AddWithValue("@sno", snofroms);
                    MySqlDataReader veryread;
                    veryread = checkunique.ExecuteReader();

                    if (veryread.Read())
                    {
                        MessageBox.Show("ITEM ALREADY RECEIVED BEFORE VIDE VOUCHER NO::" + chckvno, "ALERT");
                        return;

                    }
                    else
                    {
                        Checktyp();

                    }
                }
                else {
                    MessageBox.Show("INVALID USER INPUT!!!","INPUT CONTROLS");

                }
            }
            else
            {

                MessageBox.Show("EMPTY FIELDS DETECTED", "WARNING!!!");
                return;
            }

            conn2.Dispose();
        }
     	
       	
		public void fillCombo(){
		
			try{
				
			MySqlConnection connect;
			
			string query="select description from items ORDER BY description asc";
			connect=new MySqlConnection(conn);
			
			connect.Open();
			
			MySqlCommand cmd=new MySqlCommand(query,connect);
			
			
			MySqlDataReader reader;
			
			reader=cmd.ExecuteReader();
			
			while(reader.Read()){
			
				string itm=reader[0].ToString();
			
				itemCode.Items.Add(itm);
                   				
			}
                MySqlConnection unitcon = new MySqlConnection(conn);
                unitcon.Open();
                string q2 = "select udesc from stunits";
                MySqlCommand unitcom = new MySqlCommand(q2,unitcon);
                MySqlDataReader unitread;
                unitread = unitcom.ExecuteReader();
                while (unitread.Read()) {
                    string units = unitread[0].ToString();
                    itemunit.Items.Add(units);
                }
			connect.Close();
                unitcon.Close();
			}catch(Exception ex){
				
				MessageBox.Show(ex.Message);
			}
					
		}

        public void viewReceipts()
        {
            try
            {

                MySqlConnection connects = new MySqlConnection(conn);

                string query = "select itemcode,voucherno,supplier,station_assigned,snofrom,snoto,quantity,unit from receivables order by transid desc";

                MySqlCommand com = new MySqlCommand(query, connects);

                MySqlDataAdapter adapt = new MySqlDataAdapter(com);

                DataTable ds = new DataTable();

                adapt.Fill(ds);

                dataGridView1.ReadOnly = true;

                dataGridView1.DataSource = ds;

                connects.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        void RecItemClick(object sender, EventArgs e)
		{
            itemReceipt();
        }
		
		void ItemCodeSelectedIndexChanged(object sender, EventArgs e)
		{
			
			MySqlConnection contype=new MySqlConnection(conn);
			contype.Open();
			string itemset=itemCode.Text.ToString();
			
			string qtype="select typ from items where description=@itemtype";
			
			MySqlCommand typecom= new MySqlCommand(qtype,contype);
			typecom.Parameters.AddWithValue("@itemtype",itemset);
			MySqlDataReader typereader;
						
			typereader=typecom.ExecuteReader();
			
			while(typereader.Read())
            {
               
                string typ=typereader.GetString("typ");

                if (typ == null)
                    return;

                if (typ=="SERIALIZED") {
                    snofrom.Text = "";
                    snoto.Text = "";
                    asstation.Text = "";
                    snofrom.ReadOnly = false;
                    snoto.ReadOnly = false;
                    stnbox.Visible=true;
                }

				
				if(typ=="DESERIALIZED"){
                    snofrom.Text = "0";
                    snoto.Text = "0";
                    snofrom.ReadOnly = true;
                    snoto.ReadOnly = true;
                    asstation.Text = "NA";
                    stnbox.Visible=false;
                }
			}
			
			
			
		}

        private void receipts_Load(object sender, EventArgs e)
        {

        }
    }
}
