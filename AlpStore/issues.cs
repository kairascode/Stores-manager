/*
 * Created by SharpDevelop.
 * User: ALEX KAIRA
 * Date: 9/6/2017
 * Time: 12:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Text.RegularExpressions;


namespace AlpStores
{
	
	public partial class issues : Form
	{
		string conn=System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;
		public issues()
		{
			
			InitializeComponent();
			
			
			FillCombo();
			
		}
		public void FillCombo(){ //fills items list from the database
		
			try{
		
			MySqlConnection connect=new MySqlConnection(conn);
			connect.Open();	
			string query="select description from items";
			
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
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)//checks for serialized items
		{
			
			string itemtype=itmselect.Text.ToString();
				
			MySqlConnection conne=new MySqlConnection(conn);
			conne.Open();
			string qu="select * from items where description=@itemcode";
			
			MySqlCommand serio=new MySqlCommand(qu,conne);
			serio.Parameters.AddWithValue("@itemcode",itemtype);
			
			MySqlDataReader redd;
			
			redd=serio.ExecuteReader();
			if (redd == null)
				return;
			
			while(redd.Read()){
			
				string typ=redd.GetString("typ");
				if (typ == null)
					return;
				
				if(typ=="SERIALIZED"){
					
					isitem.Show();
					isitem.Text=itemtype;
                    snofrom.Text = "";
                    snoto.Text = "";
                    snofrom.ReadOnly = false;
                    snoto.ReadOnly = false;
                    stassign.Show();
                    MySqlConnection asscon = new MySqlConnection(conn);
                    asscon.Open();
                    string qs = "select station_assigned ,min(snofrom)from receivables where itemcode=(select itemcode from items where description=@de )and remarks=''";
                    MySqlCommand asscom = new MySqlCommand(qs,asscon);
                    asscom.Parameters.AddWithValue("@de",itemtype);
                    MySqlDataReader assread;
                    assread = asscom.ExecuteReader();
                    while (assread.Read())
                    {

                        string stations = assread[0].ToString();
                        assignStation.Items.Add(stations);

                    }
                   
                }
				
				if(typ=="DESERIALIZED"){
					isitem.Show();
					isitem.Text=itemtype;
					//snoitem.Hide();
                    //viewIssues.Show();
                    snofrom.Text = "0";
                    snoto.Text = "0";
                    snofrom.ReadOnly=true;
                    snoto.ReadOnly = true;
                    stassign.Hide();
                    assignStation.Text = "";
					}			
			}
			
		}

        public void InputChecker()
        {//checks for empty fields
            if (voucherno.Text != "" && reqofficer.Text != "" && station.Text != "" && qtyissued.Text != "" && recofficer.Text != "")
            {
                if ((Regex.IsMatch(voucherno.Text, "[0-9]+")) && (Regex.IsMatch(reqofficer.Text, "[A-Za-z]+")) && (Regex.IsMatch(qtyissued.Text, "[0-9]+")) &&
                    (Regex.IsMatch(station.Text, "[A-Za-z]+")) && (Regex.IsMatch(recofficer.Text, "[A-Za-z]+")) && (Regex.IsMatch(snofrom.Text, "[0-9]+"))
                    && (Regex.IsMatch(snoto.Text, "[0-9]+")))
                {
                    CheckUnique();
                
                }
                else
                {
                    MessageBox.Show("INVALID USER INPUT DETECTED!!!", "INPUT CONTROL");
                    return;
                }

            }

            else
            {

                MessageBox.Show("EMPTY FIELDS DETECTED...","INPUT CONTROL");
                return;
            }

        }
        public void Checktyp()
        {
            string itmtyp = itmselect.Text.ToString();

            
            MySqlConnection tcon = new MySqlConnection(conn);
            tcon.Open();
            string tquery = "select typ from items where description= @itmtyp";
            MySqlCommand tcom = new MySqlCommand(tquery, tcon);
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
                    CalculateBal();
                }
            }
        }
        public void CheckSno()
        {
            string snoy = snofrom.Text.ToString();
            
            MySqlConnection snocon = new MySqlConnection(conn);
            snocon.Open();
            string qsno = "select snofrom from issues where snofrom=@snos";
           
            MySqlCommand snocom = new MySqlCommand(qsno, snocon);
            snocom.Parameters.AddWithValue("@snos", snoy);
            MySqlDataReader snoread = snocom.ExecuteReader();

            if (snoread.Read())
            {
                MessageBox.Show(" AN ITEM WITH SERIAL NUMBER" + snoy + " HAS BEEN RECEIVED BEFORE...TRY AGAIN", "SYSTEM CONTROL");
                return;
            }
            else
            {
                CalculateBal();

            }


        }

        public void CheckUnique()
        {
           // inputChecker();

            string vf = voucherno.Text.ToString();
            string itmsel = itmselect.Text.ToString();
            string snoy = snofrom.Text.ToString();

            string Q1 = "select voucherno from issues where itemcode=(select itemcode from items where description=@itmd) and voucherno=@chkvno";
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            MySqlCommand uniqcom = new MySqlCommand(Q1, con);
            uniqcom.Parameters.AddWithValue("@chkvno", vf);
            uniqcom.Parameters.AddWithValue("@itmd", itmsel);
         
            MySqlDataReader rd;
            rd = uniqcom.ExecuteReader();
            if (rd.Read())
            {
             
                    MessageBox.Show("VOUCHER NO"+"   "+vf+"   "+"HAS BEEN USED BEFORE TO ISSUE"+"   "+itmsel+"   "+ "HENCE ISSUE DISALLOWED..","INPUT CONTROL");
                     voucherno.Focus();
                    return;
            }
            else{

               Checktyp();
                return;
            }
        }

        public void CalculateBal()
        { //main function for the issue form
            string itemdesc = itmselect.Text.ToString();

            try
            {
                MySqlConnection calconn = new MySqlConnection(conn);
                calconn.Open();
                double baliss = 0;
                double balrecs = 0;
                string issuesbal = "select COALESCE(sum(quantity),0) from issues where itemcode=(select itemcode from items where description=@desc)";
                string receiptbal = "select COALESCE(sum(quantity),0) from receivables where itemcode=(select itemcode from items where description=@desc)";

                MySqlCommand calculate1 = new MySqlCommand(issuesbal, calconn);
                calculate1.Parameters.AddWithValue("@desc", itemdesc);
                MySqlDataReader balreader;
                balreader = calculate1.ExecuteReader();
                if (balreader.Read())
                {

                    baliss = double.Parse(balreader[0].ToString());
                   
                }
                
                balreader.Close();
               MySqlCommand calculate2 = new MySqlCommand(receiptbal, calconn);
                calculate2.Parameters.AddWithValue("desc", itemdesc);
                MySqlDataReader recreader;
                recreader = calculate2.ExecuteReader();
                
                while (recreader.Read()) { 
                                     
                     balrecs = double.Parse(recreader[0].ToString());
                    
                }

                double openbal = balrecs - baliss;
               
               if (openbal <= 0)
                {
                    MessageBox.Show("THE BALANCE IS ZERO. ISSUE FAILED","SYSTEM CONTROL");

                    return;
                }
                else
                
                    if (openbal >0)
                    {
                        string desc = isitem.Text.ToString();
                    double qty = double.Parse(qtyissued.Text.ToString());
                  
                    double closebal = 0;
                       closebal = openbal-qty;
                                    
                    if(closebal>=0) {

                        MySqlConnection updatecon = new MySqlConnection(conn);
                        string query = "update items set balance=@closebal where description=@descs";
                        updatecon.Open();

                        MySqlCommand updater = new MySqlCommand(query, updatecon);
                        updater.Parameters.AddWithValue("@descs", desc);
                        updater.Parameters.AddWithValue("@closebal", closebal);

                        updater.ExecuteNonQuery();

                        recordIssue();
                    } 
                    else {
                        MessageBox.Show("ISSUE FAILED. THE BALANCE IN SYSTEM IS LESS THAN THEN QUANTITY REQUISITONED!!","PROCESS CONTROL");
                        return;
                    }
                    }

                }
            catch (Exception ecal)
            {
                MessageBox.Show(ecal.Message);
            }
        }
        public void PrintReceipt()
        { //allows for printing of gate pass

            string vno = voucherno.Text.ToString();
            string stations = station.Text.ToString();
            string itms = itmselect.Text.ToString();
            string qty = qtyissued.Text.ToString();
            string reqo = reqofficer.Text.ToString();
            string reco = recofficer.Text.ToString();
            string snofroms = snofrom.Text.ToString();
            string snotos = snoto.Text.ToString();

            DataTable dt = new DataTable();
            dt.AsDataView();

            DataRow dr;

            // SET COLUMNS FOR THE TABLE
            // DataColumn dc1 = new DataColumn("No");
            //dc1.AutoIncrement = true;
            //dc1.AutoIncrementStep = 1;

            //dt.Columns.Add(dc1);
            dt.Columns.Add("VOUCHER NO", typeof(int)).ReadOnly = true;
            dt.Columns.Add("ITEM", typeof(string)).ReadOnly = true;
            dt.Columns.Add("REQUISITIONED BY", typeof(string)).ReadOnly = true;
            dt.Columns.Add("STATION", typeof(string)).ReadOnly = true;
            dt.Columns.Add("QUANTITY", typeof(int)).ReadOnly = true;
            dt.Columns.Add("RECEIVED BY", typeof(string)).ReadOnly = true;
            dt.Columns.Add("SERIAL NO FROM").ReadOnly = true;
            dt.Columns.Add("SERIAL NO TO").ReadOnly = true;

           dr = dt.NewRow();
           // foreach (DataRow dr in dt.Rows)
           // {
                // BIND INPUT TO THE TABLE
                // dr["No"] =dc1;
                dr["VOUCHER NO"] = vno;
                dr["ITEM"] = itms;
                dr["REQUISITIONED BY"] = reqo;
                dr["STATION"] = stations;
                dr["QUANTITY"] = qty;
                dr["RECEIVED BY"] = reco;
                dr["SERIAL NO FROM"] = snofroms;
                dr["SERIAL NO TO"] = snotos;
           
            dt.Rows.Add(dr);
           // }

            gateData.DataSource = dt;
            
        }


        public void recordIssue()
        { //records issue details in the database

            try
            {
                string vno = voucherno.Text.ToString();
                string scounty = station.Text.ToString().ToUpper();
                string itemcode = itmselect.Text.ToString();
                string quantity = qtyissued.Text.ToString();
                string reqby = reqofficer.Text.ToString().ToUpper();
                string recby = recofficer.Text.ToString().ToUpper();
                string snofroms = snofrom.Text.ToString();
                string snotos = snoto.Text.ToString();

                MySqlConnection connect = new MySqlConnection(conn);
                connect.Open();

                MySqlCommand isscom = new MySqlCommand();
                isscom.Connection = connect;
                isscom.Parameters.AddWithValue("@vno", vno);
                isscom.Parameters.AddWithValue("@scounty", scounty);
                isscom.Parameters.AddWithValue("@itemcode", itemcode);
                isscom.Parameters.AddWithValue("@quantity", quantity);
                isscom.Parameters.AddWithValue("@reqby", reqby);
                isscom.Parameters.AddWithValue("@recofficer", recby);
                isscom.Parameters.AddWithValue("@snofrom", snofroms);
                isscom.Parameters.AddWithValue("@snoto", snotos);

                isscom.CommandText = "insert into issues(itemcode,voucherno,snofrom,snoto,reqby,issueto,scounty,quantity)values((select itemcode from items where description=@itemcode),@vno,@snofrom,@snoto,@reqby,@recofficer,@scounty,@quantity);" +
                    "update receivables set remarks='Y'where snofrom=@snofrom";

                isscom.ExecuteNonQuery();
                		
                MessageBox.Show("ISSUE SUCCESSFUL","SYSTEM CONTROL");

                PrintReceipt();

                isscom.Dispose();

                connect.Close();
                return;

                
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);

            }

        }
        void BtnprintClick(object sender, EventArgs e)
		{
            
            Printer ppt = new Printer();

            ppt.print();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
            InputChecker();
			voucherno.Text="";
			station.Text="";
			itmselect.Text="";
			qtyissued.Text="";
			reqofficer.Text="";
			recofficer.Text="";
			snofrom.Text="";
			snoto.Text="";		
		}

        private void assignStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void assignStation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string ast = assignStation.Text.ToString();

            string qst = "select receivables.snofrom,receivables.snoto from receivables where station_assigned=@ast";
            MySqlConnection aster = new MySqlConnection(conn);
            aster.Open();
            MySqlCommand astercom = new MySqlCommand(qst, aster);
            astercom.Parameters.AddWithValue("@ast", ast);
            MySqlDataReader asteread;
            asteread = astercom.ExecuteReader();
            while (asteread.Read())
            {
                snofrom.Text = asteread[0].ToString();
                snoto.Text = asteread[1].ToString();
                station.Text = ast;
            }

        }

        private void issues_Load(object sender, EventArgs e)
        {

        }
    }
}
