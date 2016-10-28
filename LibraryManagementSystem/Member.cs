using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Model.Entities;
using Model.Connection;
using BL;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        DBConnection dbcon = new DBConnection();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
             DisableControls(this);
             LoadDataToGrid();
        }

        public void LoadDataToGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spLoadMemberDataToGrid", dbcon.ActiveCon());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["MemberId", i].Value = dt.Rows[i]["Member_Id"];
                    dataGridView1["MemberName", i].Value = dt.Rows[i]["Member_Name"];
                    dataGridView1["EMail", i].Value = dt.Rows[i]["Member_Email"];
                    dataGridView1["Mobile", i].Value = dt.Rows[i]["Member_Mobile"];
                    dataGridView1["DOB", i].Value = dt.Rows[i]["Member_DOB"];
                    dataGridView1["DOJ", i].Value = dt.Rows[i]["Member_DOJ"];
                    dataGridView1["Address", i].Value = dt.Rows[i]["Member_Address"];
                    //dataGridView1["Status", i].Value = dt.Rows[i]["Member_Status"];//
                    if (dt.Rows[i]["Member_Status"] == "1")
                    {
                        dataGridView1["Status", i].Value = "Active";
                    }

                    else
                    {
                        dataGridView1["Status", i].Value = "In Active";
                    }


                    dataGridView1["PlanId", i].Value = dt.Rows[i]["Plan Id"];
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                dbcon.CloseCon();
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
                LoadComboPlan();
                LoadComboStatus();
                
            }

            public void LoadComboStatus()
            {
                cmbStatus.Items.Add("Active");
                cmbStatus.Items.Add("In Active");
            }

            public void LoadPlanId()
            {
                int n = 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("spCountMemberMasterDetails", dbcon.ActiveCon());
                    n = Convert.ToInt32(cmd.ExecuteScalar());
                    txtMemberId.Text = Convert.ToString(++n);
                }

                catch (Exception ex)
                {

                }

                finally
                {
                    dbcon.CloseCon();
                }
            }

            public void LoadComboPlan()
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spLoadPlanName",dbcon.ActiveCon());
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable d = new DataTable();
                    adp.Fill(d);

                    for (int i = 0; i < d.Rows.Count; i++)
                    {
                        cmbPlan.Items.Add(d.Rows[i]["Plan Name"]);
                    }
                }

                catch (Exception ex)
                {

                }
            }
            
            public void EnableControls(Control con)
            {
                foreach (Control c in con.Controls)
                {
                    if (c.Name != "txtMemberId")
                    {
                        c.Enabled = true;
                    }

                    if (c is Panel && c.Name == "panel1")
                    {
                        foreach (Control c1 in panel1.Controls)
                        {
                            if (c1.Name == "txtPlanId")
                            {
                                c1.Enabled = false;
                            }
                        }
                        
                    }
                }
            }

            private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
            {
                string name = cmbPlan.Text;
                try
                {
                    DBConnection dbCon = new DBConnection();
                    SqlCommand cmd = new SqlCommand("spLoadPlanId", dbCon.ActiveCon());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Plan_Name", name);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    txtPlanId.Text = Convert.ToString(count);
                }
                catch (Exception ex)
                {

                }

                finally
                {
                    dbcon.CloseCon();
                }
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                int n = 0;
                try
                {
                    MemberMaster objMem = new MemberMaster();
                    objMem.MemberId = Convert.ToInt32(txtMemberId.Text);
                    objMem.MemberName = txtName.Text;
                    objMem.MemberEmail = txtEMail.Text;
                    objMem.Mobile = txtMobile.Text;
                    objMem.MemberDOB = dtpDOB.Value.Date.ToString("yyyy-MM-dd");
                    objMem.MemberDOJ = dtpDOJ.Value.Date.ToString("yyyy-MM-dd");
                    objMem.MemberAddress = txtAddress.Text;
                    objMem.PlanId = Convert.ToInt32(txtPlanId.Text);
                    //objMem.PlanName = cmbPlan.Text;
                    objMem.MemberStatus = cmbStatus.Text == "Active" ? 1 : 0;

                    MemberMasterBL objMemBL = new MemberMasterBL();
                    n = objMemBL.SaveMemberMaster(objMem);
                    if (n > 0)
                    {
                        MessageBox.Show("Record is Saved..");
                    }

                    else
                    {
                        MessageBox.Show("Record is Not Saved..");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Record is Not Saved..");
                }

                finally
                {

                }
            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                txtMemberId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtEMail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtMobile.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dtpDOB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dtpDOJ.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                txtPlanId.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cmbStatus.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                int n = Convert.ToInt32(txtPlanId.Text);
                LoadPlaName(n);
            }

            public void LoadPlaName(int k)
            {
                
                try
                {
                    SqlCommand cmd = new SqlCommand("spRetrievePlanName", dbcon.ActiveCon());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlanId", k);
                    cmbPlan.Text = Convert.ToString(cmd.ExecuteScalar());
                }

                catch (Exception ex)
                {

                }

                finally
                {
                    dbcon.CloseCon();
                }
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                int n = 0;
                try
                {
                    MemberMaster objMem = new MemberMaster();
                    objMem.MemberId = Convert.ToInt32(txtMemberId.Text);
                    objMem.MemberName = txtName.Text;
                    objMem.MemberEmail = txtEMail.Text;
                    objMem.Mobile = txtMobile.Text;
                    objMem.MemberDOB = dtpDOB.Value.Date.ToString("yyyy-MM-dd");
                    objMem.MemberDOJ = dtpDOJ.Value.Date.ToString("yyyy-MM-dd");
                    objMem.MemberAddress = txtAddress.Text;
                    objMem.PlanId = Convert.ToInt32(txtPlanId.Text);
                    //objMem.PlanName = cmbPlan.Text;
                    objMem.MemberStatus = cmbStatus.Text == "Active" ? 1 : 0;

                    MemberMasterBL objMemBL = new MemberMasterBL();
                    n = objMemBL.UpdateMemberMaster(objMem);
                    if (n > 0)
                    {
                        MessageBox.Show("Record is Updated..");
                    }

                    else
                    {
                        MessageBox.Show("Record is Not Updated..");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Record is Not Updated..");
                }

                finally
                {
                    dbcon.CloseCon();
                }
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                int n = 0;
                try
                {
                    MemberMaster objMem = new MemberMaster();
                    objMem.MemberId = Convert.ToInt32(txtMemberId.Text);

                    MemberMasterBL objMemBL = new MemberMasterBL();
                    n = objMemBL.DeleteMemberMaster(objMem);
                    if (n > 0)
                    {
                        MessageBox.Show("Record is Deleted..");
                    }

                    else
                    {
                        MessageBox.Show("Record is Not Deleted..");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Record is Not Deleted..");
                }

                finally
                {

                }
            }

        }
}

