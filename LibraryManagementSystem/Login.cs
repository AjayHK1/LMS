using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        int n = 0;
        SqlConnection connectn = null;
        string con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connectn = new SqlConnection(con);
                //SqlCommand cmd = new SqlCommand("Select * from Profile_Master where Pro_Name='"+ textBox2.Text +"' and Pro_Password='"+textBox1.Text +"'", connectn);
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Profile_Master where Pro_Name='" + textBox2.Text + "' and Pro_Password='" + textBox1.Text + "'", connectn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    LMS obj = new LMS();
                    obj.Show();
                }

                else
                {
                    MessageBox.Show("Invalid UserName and Password","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connectn.Close();
            }



            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Password obj = new Change_Password();            
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
