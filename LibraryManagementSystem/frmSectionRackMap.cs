using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BL;
using Model.Entities;

namespace LibraryManagementSystem
{
    public partial class frmSectionRackMap : Form
    {
        DataTable dt;
        SectionRackMapMaster secRac;
        SecRackMapBL secRacBL;

        public frmSectionRackMap()
        {
            InitializeComponent();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSectionRackMap_Load(object sender, EventArgs e)
        {
            DisableControls(this);
            LoadGridDetails();
        }

        public void LoadGridDetails()
        {
            try
            {
                secRacBL = new SecRackMapBL();
                dt = secRacBL.LoadGridDetails();

                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["SectionRackId", i].Value = dt.Rows[i]["Sr_Id"];

                    //int sectionId = Convert.ToInt32(dt.Rows[i]["Sec_Id"]);
                    dataGridView1["SectionName", i].Value = dt.Rows[i]["Section Name"];

                    //int rackId = Convert.ToInt32(dt.Rows[i]["Rack_Id"]);
                    dataGridView1["RackName", i].Value = dt.Rows[i]["Rack Name"];
                    
                    dataGridView1["PrintOrder", i].Value = dt.Rows[i]["Sr_Print"];
                    dataGridView1["Status", i].Value = dt.Rows[i]["Sr_Status"].ToString() == "1" ? "Active" : "In Active";
                }

                lblCount.Text = Convert.ToString(dt.Rows.Count);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }


        public void LoadSecRacID()
        {

            try
            {
                secRacBL = new SecRackMapBL();
                int count = secRacBL.LoadSecRackMapId();
                txt_SecRac_ID.Text = Convert.ToString(++count);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        public void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is Panel && c.Name == "panel1")
                {
                    foreach (Control c1 in panel1.Controls)
                    {
                        if (c1.Name == "btnNew")
                        {
                            c1.Enabled = true;
                        }

                        else
                        {
                            c1.Enabled = false;
                        }
                    }

                }

                else if (c is Panel && c.Name == "panel2")
                {
                    panel2.Enabled = false;
                    dataGridView1.Enabled = false;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableControls(this);
            LoadSecRacID();
            LoadRackName();
            LoadSectionName();
            LoadComboStatus();
        }

        public void LoadComboStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In Active");
        }

        public void LoadRackName()
        {
            try
            {
                secRacBL = new SecRackMapBL();
                dt = secRacBL.LoadRackName();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmbRackName.Items.Add(dt.Rows[i]["Rack Name"]);
                    }
                    //dt = null;
                    //sectnBL = null;
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Records Are Cannot be Displayed..", "Information", MessageBoxButtons.OK);
            }

            
        }

        public void LoadSectionName()
        {
            try
            {
                secRacBL = new SecRackMapBL();
                dt = secRacBL.LoadSectionName();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmbSectioName.Items.Add(dt.Rows[i]["Section Name"]);
                    }
                    
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Records Are Cannot be Displayed..", "Information", MessageBoxButtons.OK);
            }

            
        }

        public void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is Panel && c.Name == "panel1")
                {
                    foreach (Control c1 in panel1.Controls)
                    {
                        c1.Enabled = true;
                    }
                }

                else if (c is Panel && c.Name == "panel2")
                {
                    panel2.Enabled = true;
                    dataGridView1.Enabled = true;
                }

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                secRac = new SectionRackMapMaster();
                secRac.sr_rac_map_id = Convert.ToInt32(txt_SecRac_ID.Text);
                secRac.racId = cmbRackName.SelectedIndex + 1;
                secRac.secId = cmbSectioName.SelectedIndex + 1;
                secRac.print = Convert.ToInt32(txtPrint.Text);
                secRac.status = cmbStatus.Text == "Active" ? 1 : 0;

                secRacBL = new SecRackMapBL();
                if (secRacBL.SaveSecRacMapRecords(secRac) > 0)
                {
                    MessageBox.Show("Records Are Saved..", "Information", MessageBoxButtons.OK);
                }
                
                else
                {
                    MessageBox.Show("Records Are Not Saved..", "Information", MessageBoxButtons.OK);
                }
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Records Are Not Saved..", "Information", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDetailsFromGridToIndividualControls();
        }

        public void GetDetailsFromGridToIndividualControls()
        {
            txt_SecRac_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbRackName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbSectioName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrint.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbStatus.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSectionRackMapDetails();
        }

        public void UpdateSectionRackMapDetails()
        {
            try
            {
                secRac = new SectionRackMapMaster();
                secRac.sr_rac_map_id = Convert.ToInt32(txt_SecRac_ID.Text);
                secRac.racId = cmbRackName.SelectedIndex + 1;
                secRac.secId = cmbSectioName.SelectedIndex + 1;
                secRac.print = Convert.ToInt32(txtPrint.Text);
                secRac.status = cmbStatus.Text == "Active" ? 1 : 0;

                secRacBL = new SecRackMapBL();
                if (secRacBL.UpdateSecRacMapRecords(secRac) > 0)
                {
                    MessageBox.Show("Records Are Updated..", "Information", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Records Are Not Updated..", "Information", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Records Are Not Updated..", "Information", MessageBoxButtons.OK);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int secRacId = Convert.ToInt32(txt_SecRac_ID.Text);
            DeleteSectionRackMapDetails(secRacId);
        }

        public void DeleteSectionRackMapDetails(int secRacId)
        {
            try
            {
                secRac = new SectionRackMapMaster();
                secRac.sr_rac_map_id = Convert.ToInt32(txt_SecRac_ID.Text);

                secRacBL = new SecRackMapBL();
                if (secRacBL.DeleteSectionRackMapDetails(secRacId) > 0)
                {
                    MessageBox.Show("Records Are Deleted..", "Information", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Records Are Not Deleted..", "Information", MessageBoxButtons.OK);
                }
            }

            catch(Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Records Are Not Deleted..", "Information", MessageBoxButtons.OK);
            } 
        }
    }
}
