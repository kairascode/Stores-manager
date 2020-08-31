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
    public partial class resetpass : Form
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["appConns"].ConnectionString;

        public resetpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usid = uid.Text.ToString();
            string ocode = oldcode.Text.ToString();
            string ncode = newcode.Text.ToString();
            string ccode = confirmcode.Text.ToString();

            if (usid != "" && ocode != "" && ncode != "" && ccode != "")
            {
                if ((Regex.IsMatch(uid.Text, "[a-z]+")) && (Regex.IsMatch(oldcode.Text, "[A-Za-z0-9]+")) && (Regex.IsMatch(newcode.Text, "[A-Za-z0-9]+"))
                    && (Regex.IsMatch(confirmcode.Text, "[A-Za-z0-9]+")))
                {

                    string q2 = "select logid,password from loggers where logid=@log and password=@pas";

                    MySqlConnection con = new MySqlConnection(conn);
                    con.Open();
                    MySqlCommand resetcom = new MySqlCommand(q2, con);
                    resetcom.Parameters.AddWithValue("@log", usid);
                    resetcom.Parameters.AddWithValue("@pas", ocode);

                    MySqlDataReader readers;

                    readers = resetcom.ExecuteReader();

                    if (readers.Read())
                    {
                        string ocod = readers[1].ToString();

                        if (ncode != ocod)
                        {
                            if (ncode == ccode)
                            {
                                MySqlConnection conw = new MySqlConnection(conn);
                                conw.Open();
                                string q5 = "update loggers set password=@ucode where logid=@uid";
                                MySqlCommand updater = new MySqlCommand(q5, conw);
                                updater.Parameters.AddWithValue("@ucode", ccode);
                                updater.Parameters.AddWithValue("@uid", usid);
                                //updater.CommandText = "update loggers set password=@ucode where logid=@uid";
                                updater.ExecuteNonQuery();

                               MessageBox.Show( "YOU HAVE SUCCESSFULLY RESET YOUR USER CODE","SYSTEM CONTROL");
                                this.Dispose();
                                Index x = new Index();
                                x.Show();

                            }
                            else
                            {
                                outputer.Text = "NEW AND CONFIRM CODE DIFFER";
                                return;
                            }
                        }
                        else
                        {
                            outputer.Text = "THE USERCODE HAS BEEN USED BEFORE. USE A NEW PASSWORD!!";
                            return;
                        }
                    }




                }
                else
                {
                    outputer.Text = "INVALID USER INPUT";

                }
            }
            else {
                outputer.Text = "EMPTY FIELDS DETECTED!!";
            }
        }

        private void resetpass_Load(object sender, EventArgs e)
        {
           
        }
    }
}
