using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Entities;
using BL;
using ErrorHandling;


namespace LibraryManagementSystem
{
    public partial class Profile : Form
    {
        AdminMaster admin = new AdminMaster();
        IAdminMasterBL adminBL = new AdminMasterBL();
        DataTable dt = new DataTable();

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DisableControls(this);
            LoadGridDetails();
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

                else if (c is DataGridView)
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
            GetAdminProfileId();
            LoadRoleNames();
            LoadComboStatus();
            
        }

        public void LoadGridDetails()
        {
            try
            {
               dt = adminBL.LoadGridDetails();
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   dataGridView1.Rows.Add();
                   dataGridView1["Column1", i].Value = dt.Rows[i]["Pro_User_Id"];
                   dataGridView1["Column2", i].Value = dt.Rows[i]["Pro_Name"];
                   dataGridView1["Column3", i].Value = dt.Rows[i]["Pro_Email"];
                   dataGridView1["Column4", i].Value = dt.Rows[i]["Pro_Mobile"];
                   dataGridView1["Column5", i].Value = dt.Rows[i]["Pro_Password"];
                   dataGridView1["Column6", i].Value = dt.Rows[i]["Pro_Address"];
                   dataGridView1["Column7", i].Value = dt.Rows[i]["Pro_Role"];
                   dataGridView1["Column8", i].Value = dt.Rows[i]["Pro_Status"];
                   dataGridView1["Column8", i].Value = dt.Rows[i]["Pro_Status"].Equals(1) ? "Active" : "InActive"; 
               }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        public void GetAdminProfileId()
        {
            //txtUserID.Text = Convert.ToString(adminBL.RetrieveProUserId());
            int id = (adminBL.RetrieveProUserId());
            txtUserID.Text = Convert.ToString(++id);
        }

        public void LoadRoleNames()
        {
            dt = adminBL.LoadRoleName();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbRole.Items.Add(dt.Rows[i]["Role Name"]);
                }
            }
        }

        public void LoadComboStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In Active");
        }

        public void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c.Name != "txtUserID")
                {
                    c.Enabled = true;
                }

                //if (c is Panel && c.Name == "panel1")
                //{
                //    foreach (Control c1 in panel1.Controls)
                //    {
                //        if (c1.Name == "txtPlanId")
                //        {
                //            c1.Enabled = false;
                //        }
                //    }

                //}
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProfileDetails();
        }

        public void SaveProfileDetails()
        {
            try
            {
                admin.ProUserId = Convert.ToInt32(txtUserID.Text);
                admin.ProUserName = txtName.Text;
                admin.Mobile = txtMobile.Text;
                admin.EMail = txtEMail.Text;
                admin.Password = txtPassword.Text;
                admin.Address = txtAddress.Text;
                admin.Role = adminBL.RetrieveRoleId(cmbRole.Text);
                admin.Status = cmbStatus.SelectedItem == "Active" ? 1 : 0;

                //adminBL.SaveBookMasterData(admin);
                if (adminBL.SaveProfileData(admin) > 0)
                {
                    MessageBox.Show("Record is Saved","Information",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Record is Not Saved...Please Try Again", "Information", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProfileDetails();
        }

        public void UpdateProfileDetails()
        {
            try
            {
                admin.ProUserId = Convert.ToInt32(txtUserID.Text);
                admin.ProUserName = txtName.Text;
                admin.Mobile = txtMobile.Text;
                admin.EMail = txtEMail.Text;
                admin.Password = txtPassword.Text;
                admin.Address = txtAddress.Text;
                admin.Role = adminBL.RetrieveRoleId(cmbRole.Text);
                admin.Status = cmbStatus.SelectedItem == "Active" ? 1 : 0;

                //adminBL.SaveBookMasterData(admin);
                if (adminBL.UpdateProfileData(admin) > 0)
                {
                    MessageBox.Show("Record is Updated", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Record is Not Updated...Please Try Again", "Information", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEMail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMobile.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            cmbRole.Text = GetRoleName(id);
            cmbStatus.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        public string GetRoleName(int id)
        {
           return adminBL.RetrieveRoleName(id);
        }
    }
}
