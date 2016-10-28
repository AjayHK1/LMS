using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Model;
using Model.Entities;
using BL;


namespace LibraryManagementSystem
{
    public partial class Role : Form
    {
        SqlConnection connectn = null;
        String con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";
        DataTable dt  = new DataTable();

        public Role()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Role_Load(object sender, EventArgs e)
        {
            DisableControls(this);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnSave, "Saves The Data");

            
            try
            {
                connectn = new SqlConnection(con);
                
                SqlDataAdapter adp = new SqlDataAdapter("select * from Role_Master",connectn);
                connectn.Open();
                adp.Fill(dt);
                //dataGridView1.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][""];
                    //dataGridView1[1,1].Value = dt.Rows[i][""];
                    dataGridView1.Rows.Add();
                    dataGridView1["Column1", i].Value = dt.Rows[i]["Role_Id"];
                    dataGridView1["Column2", i].Value = dt.Rows[i]["Role_Name"];
                    dataGridView1["Column3", i].Value = dt.Rows[i]["Role_Status"];
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

        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Enabled = true;
                }

                else if (c is TextBox)
                {
                    c.Enabled = false; c.Text = "";
                }

                else if (c is DataGrid)
                {

                }

                else
                {
                    c.Enabled = false;
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }

            try
            {
                connectn = new SqlConnection(con);
                connectn.Open();
                SqlCommand cmd = new SqlCommand("select Count(*) from Role_Master", connectn);
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());

                textBox1.Text = Convert.ToString(cnt + 1);
                comboBox1.Items.Add("Active");
                comboBox1.Items.Add("InActive");
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connectn.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                RoleMaster r = new RoleMaster();
                r.RoleId = Convert.ToInt32(textBox1.Text);
                r.Role = textBox2.Text;
                if (comboBox1.SelectedItem == "Active")
                {
                    r.RoleActive = "Active";
                }

                else
                {
                    r.RoleActive = "InActive";
                }

                RoleMasterBL bl = new RoleMasterBL();
                int n = bl.SaveRoldata(r);
                MessageBox.Show("Records are Saved...");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Records are not Saved...Please Try Again");
            }

            finally
            {
                DisableControls(this);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                RoleMaster r = new RoleMaster();
                r.RoleId = Convert.ToInt32(textBox1.Text);
                r.Role = textBox2.Text;
                if (comboBox1.SelectedItem == "Active")
                {
                    r.RoleActive = "Active";
                }

                else
                {
                    r.RoleActive = "InActive";
                }

                RoleMasterBL bl = new RoleMasterBL();
                int n = bl.UpdateRoldata(r);
                MessageBox.Show("Record is Updated...");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Records are not Saved...Please Try Again");
            }

            finally
            {
                DisableControls(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                RoleMaster r = new RoleMaster();
                r.RoleId = Convert.ToInt32(textBox1.Text);
                //r.Role = textBox2.Text;
                //if (comboBox1.SelectedItem == "Active")
                //{
                //    r.RoleActive = "Active";
                //}

                //else
                //{
                //    r.RoleActive = "InActive";
                //}

                RoleMasterBL bl = new RoleMasterBL();
                int n = bl.DeleteRoldata(r);
                MessageBox.Show("Record is Deleted...");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Records are not Saved...Please Try Again");
            }

            finally
            {
                DisableControls(this);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
