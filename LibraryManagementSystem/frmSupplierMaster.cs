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
    public partial class frmSupplierMaster : Form
    {

        int id = 0;
        SupplierMaster supplierEntity;
        SupplierMasterBL supplier;
        DataTable dt;

        public frmSupplierMaster()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //spRetrieveSupplierId
            RetrieveSupplierID();
            EnableControls(this);
            LoadComboStatus();
        }

        public void LoadComboStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In Active");
        }

        public void EnableControls(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
            {
                control.Enabled = true;
            }

            foreach (Control subControl in panel2.Controls)
            {
                if (subControl.Name != "btnNew")
                {
                    subControl.Enabled = true;
                }
            }
        }

        public void RetrieveSupplierID()
        {
            try
            {
                supplier = new SupplierMasterBL();
                id = supplier.RetrieveSupplierID();
                txtSupplierId.Text = Convert.ToString(++id);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        private void frmSupplierMaster_Load(object sender, EventArgs e)
        {
            //spLoadSupplierDetailsTOGrid
            DisableControls(this);
            GetSupplierDetails();
        }

        public void GetSupplierDetails()
        {
            supplier = new SupplierMasterBL();
            dt = new DataTable();
            try
            {
                dt = supplier.GetSupplierDetails();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["SupplierId", i].Value = dt.Rows[i]["SupplierId"];
                    dataGridView1["SupplierName", i].Value = dt.Rows[i]["SupplierName"];
                    dataGridView1["SupplierStatus", i].Value = Convert.ToInt32(dt.Rows[i]["SupplierStatus"]) == 1 ? "Active" : "In Active";
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        public void DisableControls(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (control.Name != "panel2")
                {
                    control.Enabled = false;
                }

                else
                {
                    foreach (Control subControl in panel2.Controls)
                    {
                        if (subControl.Name != "btnNew")
                        {
                            subControl.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //spSaveSupplierDetails
            if (validateControls())
            {
                SaveSupplierDetails();
                MessageBox.Show("Record is Saved..");
            }

            else
            {
                MessageBox.Show("Record is Not Saved..");
            }
        }

        public bool validateControls()
        {
            int id;
            string ErrorString = "";
            SupplierMaster supplierEntities = new SupplierMaster();

            try
            {
                supplierEntities.supplierId = int.TryParse(txtSupplierId.Text, out id) == true ? id : 0;
                supplierEntities.supplierName = txtSupplierName.Text;
                supplierEntities.supplierStatus = cmbStatus.SelectedIndex;

                supplier = new SupplierMasterBL();
                ErrorString = supplier.ValidationOfControls(supplierEntities);

                if (!string.IsNullOrEmpty(ErrorString))
                {
                    if (ErrorString == "txtSupplierId")
                    {
                        MessageBox.Show("Supplier Id Cannot be Empty!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSupplierId.Focus();
                        return false;
                    }

                    else if (ErrorString == "txtSupplierName")
                    {
                        MessageBox.Show("Supplier Name Cannot be Empty!!! OR It Cannot Exceed 10 Characters...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSupplierName.Focus();
                        return false;
                    }

                    else if (ErrorString == "cmbStatus")
                    {
                        MessageBox.Show("Supplier Status Cannot be Empty!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbStatus.Select();
                        return false;
                    }
                }
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
                return false;
            }

            return true;
        }

        public void SaveSupplierDetails()
        {
            try
            {
                SupplierMaster suplier = new SupplierMaster();
                suplier.supplierId = Convert.ToInt32(txtSupplierId.Text);
                suplier.supplierName = txtSupplierName.Text;
                suplier.supplierStatus = cmbStatus.Text == "Active" ? 1 : 0;

                supplier = new SupplierMasterBL();
                if (supplier.saveSupplierDetails(suplier) > 0)
                {
                    MessageBox.Show("Record is Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Record is Not Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Record is Not Saved", "Information", MessageBoxButtons.OK);
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        public void updateSupplierDetails()
        {
            try
            {
                SupplierMaster suplier = new SupplierMaster();
                suplier.supplierId = Convert.ToInt32(txtSupplierId.Text);
                suplier.supplierName = txtSupplierName.Text;
                suplier.supplierStatus = cmbStatus.Text == "Active" ? 1 : 0;

                supplier = new SupplierMasterBL();
                if (supplier.updateSupplierDetails(suplier) > 0)
                {
                    MessageBox.Show("Record is Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Record is Not Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Record is Not Updated", "Information", MessageBoxButtons.OK);
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //spUpdateSupplierDetails
            
            if (validateControls())
            {
                updateSupplierDetails();
               /// MessageBox.Show("Record is Updated..");
            }

            else
            {
                //MessageBox.Show("Record is Not Updated..");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //spDeleteSupplierDetails
            if (validateControls())
            {
                deleteSupplierDetails();
            }
        }

        public void deleteSupplierDetails()
        {
            int Id = Convert.ToInt32(txtSupplierId.Text);

            supplier = new SupplierMasterBL();
            try
            {
                if (supplier.deleteSupplierDetails(Id) > 0)
                {
                    MessageBox.Show("Record is Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Record is Not Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Record is Not Deleted", "Information", MessageBoxButtons.OK);
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //spSearchSupplierById
            supplier = new SupplierMasterBL();
            dt = new DataTable();
            int Id = 0;

            if (e.KeyChar == (char)13)
            {
                if (supplier.ValidationOfControls(txtSearch.Text))
                {
                    dataGridView1.Rows.Clear();
                    dt = supplier.GetSupplierDetails(Convert.ToInt32(txtSearch.Text));

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1["SupplierId", i].Value = dt.Rows[i]["SupplierId"];
                            dataGridView1["SupplierName", i].Value = dt.Rows[i]["SupplierName"];
                            dataGridView1["SupplierStatus", i].Value = Convert.ToInt32(dt.Rows[i]["SupplierStatus"]) == 1 ? "Active" : "In Active";
                        }
                    }

                    else
                    {
                        MessageBox.Show("There is No Supplier Record with this Id.. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Please Enter the Number","Earning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtSearch.Focus();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbStatus.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }



    }
}

