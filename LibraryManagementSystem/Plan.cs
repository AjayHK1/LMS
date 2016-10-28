using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model.Entities;
using BL;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Plan : Form
    {
        SqlConnection connectn = null;
        String con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";
        DataTable dt = new DataTable();
        
        public Plan()
        {
            InitializeComponent();
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            DisableControls(this);
            LoadDataToGrid();
        }

        public void LoadDataToGrid()
        {
            try
            {
                connectn = new SqlConnection(con);

                SqlDataAdapter adp = new SqlDataAdapter("spPlanMasterDetails", connectn);//select * from Section_Master
                connectn.Open();
                adp.Fill(dt);
                //dataGridView1.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["Column1", i].Value = dt.Rows[i]["Plan_Id"];
                    dataGridView1["Column2", i].Value = dt.Rows[i]["Plan_Name"];
                    dataGridView1["Column3", i].Value = dt.Rows[i]["Plan_Doc"];
                    dataGridView1["Column4", i].Value = dt.Rows[i]["Plan_Book_Limit"];
                    dataGridView1["Column5", i].Value = dt.Rows[i]["Plan_Book_Can_Hold"];
                    dataGridView1["Column6", i].Value = dt.Rows[i]["Plan_Validity"];
                    dataGridView1["Column7", i].Value = dt.Rows[i]["Plan_Amount"];
                    dataGridView1["Column8", i].Value = dt.Rows[i]["Plan_Discount"];
                    
                    dataGridView1["Column9", i].Value = Convert.ToInt32(dt.Rows[i]["Plan_Status"]) == 0 ? "Active" : "InActive";
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


        public void LoadPlanId()
        {
            try
            {
                connectn = new SqlConnection(con);

                //SqlCommand cmd = new SqlCommand("spCountPlanMasterDetails", connectn);
                //connectn.Open();
                //SqlDataReader readr;
                //readr = cmd.ExecuteReader();
                //readr.Read();
                //int planId = Convert.ToInt32(readr[0].ToString());
                //txtPlanID.Text = Convert.ToString(++planId);
                SqlCommand cmd = new SqlCommand("spCountPlanMasterDetails", connectn);
                connectn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                txtPlanID.Text = Convert.ToString(++count);
            }

            catch (Exception ex)
            {
                

            }

            finally
            {
                connectn.Close();
            }
        }

        public void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c.Name != "txtPlanID")
                {
                    c.Enabled = true;
                }
            }
        }

        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is Button && c.Text != "New")
                {
                    ((Button)c).Enabled = false;
                }

                else if (c is TextBox)
                {
                    c.Enabled = false; c.Text = "";
                }

                else if (c is ComboBox)
                {
                    c.Enabled = false;
                }

                else if (c is DateTimePicker)
                {
                    c.Enabled = false;
                }


                else if (c is Panel)
                {
                    c.Enabled = false;
                }


            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableControls(this);
            LoadPlanId();
            LoadComboStatus();
        }

        public void LoadComboStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("InActive");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDetails();
        }

        public void SaveDetails()
        {
            PlanMaster objPlan = new PlanMaster();
            objPlan.PlanId = Convert.ToInt32(txtPlanID.Text);
            objPlan.PlanName = txtPlanName.Text;
            objPlan.DateOfCreation = dtpDateOfCreation.Value.Date.ToString("yyyy-MM-dd");
            objPlan.Limit = Convert.ToInt32(txtLimit.Text);
            objPlan.BookOnHold = Convert.ToInt32(txtBookOnHold.Text);
            objPlan.Validity = dtpDateOfValidity.Value.Date.ToString("yyyy-MM-dd");
            objPlan.Amount = Convert.ToDouble(txtAmount.Text);
            objPlan.Discount = Convert.ToDouble(txtDiscount.Text);
            objPlan.Status = cmbStatus.SelectedIndex;

            PlanMasterBL p = new PlanMasterBL();
            int n = p.SavePlanMasterdata(objPlan);

            if (n > 0)
            {
                MessageBox.Show("Record is Saved", "Message", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("Record is Not Saved", "Message", MessageBoxButtons.OK);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlanID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPlanName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtpDateOfCreation.Text =  dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtLimit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBookOnHold.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtValidity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAmount.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDiscount.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbStatus.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePlanDetails();
        }

        public void UpdatePlanDetails()
        {
            try
            {
                PlanMaster p = new PlanMaster();
                p.PlanId = Convert.ToInt32(txtPlanID.Text);
                p.PlanName = txtPlanName.Text;
                p.DateOfCreation = dtpDateOfCreation.Value.Date.ToString("yyyy-MM-dd");
                p.Limit = Convert.ToInt32(txtLimit.Text);
                p.BookOnHold = Convert.ToInt32(txtBookOnHold.Text);
                p.Validity = dtpDateOfValidity.Value.Date.ToString("yyyy-MM-dd");
                p.Amount = Convert.ToInt32(txtAmount.Text);
                p.Discount = Convert.ToInt32(txtDiscount.Text);
                
                if (cmbStatus.SelectedItem == "Active")
                {
                    p.Status = 0;
                }

                else
                {
                    p.Status = 1;
                }

                PlanMasterBL bl = new PlanMasterBL();
                int n = bl.UpdatePlanMasterdata(p);
                MessageBox.Show("Record is Updated...");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Records are not Saved...Please Try Again");
            }

            finally
            {
                //DisableControls(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePlanDetails();
        }

        public int DeletePlanDetails()
        {
            int n = 0;
            try
            {
                PlanMaster p = new PlanMaster();
                p.PlanId = Convert.ToInt32(txtPlanID.Text);

                PlanMasterBL bl = new PlanMasterBL();
                n = bl.DeletePlanMasterdata(p);

                MessageBox.Show("Records are Deleted...");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Records are not Deleted...Please Try Again");
            }

            finally
            {

            }

            return n;
        }
    }
}
