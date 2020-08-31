using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AlpStores
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }


        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;


        private void lgnbtn_Click(object sender, EventArgs e)
        {
            if (userid.Text == "" || usercode.Text == "")
            {
                MessageBox.Show("EMPTY FIELDS DETECTED", "SYSTEM WARNING!!!");
            }
            else if ((Regex.IsMatch(userid.Text, "[Aa-zZ]+")) && (Regex.IsMatch(usercode.Text, "[0-9]+")))
            {

                try
                {

                    string coder = userid.Text.ToString().ToLower();
                    string pass =usercode.Text.ToString();
                    MySqlConnection connector = new MySqlConnection(conn);
                    connector.Open();
                    string query = "select logid,password  from loggers";
                    MySqlCommand cmdconn = new MySqlCommand(query, connector);
                    cmdconn.Parameters.AddWithValue("@pass", pass);
                    cmdconn.Parameters.AddWithValue("@coder", coder);

                    MySqlDataReader conread;
                    conread = cmdconn.ExecuteReader();
                    while (conread.Read())
                    {

                        string logkey = conread[1].ToString();
                        string logid = conread[0].ToString();



                        if (coder == logid && pass == logkey)
                        {
                            this.Hide();

                            MainForm n = new MainForm();

                            n.Show();

                            return;
                        }
                        else if(coder!=logid && pass!=logkey){
                            MessageBox.Show("INVALID LOGIN CREDENTIALS!!!","SYSTEM WARNING!!");
                            
                            userid.Text = "";
                            usercode.Text = "";
                            return;
                            

                        }
                    }


                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            else {
                MessageBox.Show("INVALID USER ID OR CODE DETECTED!!!","INPUT CONTROL>>");

            }
    }
        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("APPLICATION IS ABOUT TO TERMINATE","TERMINATE ALERT!!",MessageBoxButtons.OKCancel);

            
            Application.ExitThread();
          //  this.Dispose();
        }

        private void userid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void usercode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            resetpass b = new resetpass();
            b.Show();


        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}
