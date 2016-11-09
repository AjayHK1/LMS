using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Entities;
using BL.Abstract;
using BL;
using ErrorHandling;

namespace LibraryManagementSystem
{
    public partial class frmRack : Form
    {
        RackMaster rack;
        RackMasterBL rackBL;

        public frmRack()
        {
            InitializeComponent();
        }

        private void frmRack_Load(object sender, EventArgs e)
        {
            DisableControls(this);
            GetRackDetailsFromDB();
        }

        public void GetRackDetailsFromDB()
        {
            DataTable dt = new DataTable();
            RackMasterBL rackBL = new RackMasterBL();
            dt = rackBL.GetRackDetails();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1["RackId", i].Value = dt.Rows[i]["Rack_Id"];
                dataGridView1["RackName", i].Value = dt.Rows[i]["Rack_Name"];
                dataGridView1["RackStatus", i].Value = dt.Rows[i]["Rack_Status"].ToString() == "1" ? "Active" : "In Active";
            }
        }

        public void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                //if (c is Button && c.Text != "New")
                //{
                //    ((Button)c).Enabled = false;
                //}

                if (c is TextBox)
                {
                    c.Enabled = false;
                    c.Text = "";
                }

                //else if (c is ComboBox)
                //{
                //    c.Enabled = false;
                //}

                //else if (c is DataGridView)
                //{
                //    c.Enabled = false;
                //}


                //else if (c is Panel)
                //{
                //    c.Enabled = false;
                //}

                else if (c is Panel && c.Name == "panel1")
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
                    dataGridView1.Enabled = false;
                }


            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableControls(this);
            LoadRackId();
            LoadComboStatus();
        }

        public void LoadRackId()
        {
            rackBL = new RackMasterBL();
            int count = rackBL.RetrieveRackId();
            txtRackID.Text = Convert.ToString(++count);
        }

        public void LoadComboStatus()
        {
            cmbRackStatus.Items.Add("Active");
            cmbRackStatus.Items.Add("In Active");
        }

        public void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                }

                else if (c is Panel && c.Name == "panel1")
                {
                    foreach (Control c1 in panel1.Controls)
                    {
                        if (c1.Name == "txtRackID")
                        {
                            c1.Enabled = false;
                        }

                        else
                        {

                            c1.Enabled = true;
                        }
                    }

                }

                else if (c is Panel && c.Name == "panel2")
                {
                    dataGridView1.Enabled = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRackDetails();
        }

        public void SaveRackDetails()
        {
            try
            {
                rack = new RackMaster();
                rack.rackId = Convert.ToInt32(txtRackID.Text);
                rack.rackName = txtRackName.Text;
                rack.rackStatus = cmbRackStatus.Text == "Active" ? 1 : 0;

                rackBL = new RackMasterBL();
                if (rackBL.SaveRackMasterDetails(rack) > 0)
                {
                    MessageBox.Show("Rack Details Are Saved..", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Rack Details Are Not Saved..", "Information", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Rack Details Are Not Saved..", "Information", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDetailsFromGrid();
        }

        public void GetDetailsFromGrid()
        {
            txtRackID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtRackName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbRackStatus.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRackDetails();
        }

        public void UpdateRackDetails()
        {

            try
            {
                rack = new RackMaster();
                rack.rackId = Convert.ToInt32(txtRackID.Text);
                rack.rackName = txtRackName.Text;
                rack.rackStatus = cmbRackStatus.Text == "Active" ? 1 : 0;

                rackBL = new RackMasterBL();
                if (rackBL.UpdateRackMasterDetails(rack) > 0)
                {
                    MessageBox.Show("Rack Details Are Updated..", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Rack Details Are Not Updated..", "Information", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Rack Details Are Not Updated..", "Information", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRackDetails();
        }

        public void DeleteRackDetails()
        {
            try
            {
                rackBL = new RackMasterBL();
                int rackId = Convert.ToInt32(txtRackID.Text);
                if (rackBL.DeleteRackMasterDetails(rackId) > 0)
                {
                    MessageBox.Show("Rack Details Are Deleted..", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Rack Details Are Not Deleted..", "Information", MessageBoxButtons.OK);
                }
                
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                MessageBox.Show("Rack Details Are Not Updated..", "Information", MessageBoxButtons.OK);
            }
        }
    }
}
