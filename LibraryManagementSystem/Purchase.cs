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

namespace LibraryManagementSystem
{
    public partial class Purchase : Form
    {
        PurchaseBL purchasebl;
        PurchaseEntities purchase;
        int sIno = 0;
        DataTable dt;


        public Purchase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnableControls(this);
            GetPurchaseId();
            LoadComboStatus();
        }

        public void LoadComboStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In Active");
        }

        public void EnableControls(Control con)
        {
            foreach (Control cntrl in con.Controls)
            {
                if (cntrl is Panel && cntrl.Name == "panel4")
                {
                    foreach (Control ctrl1 in cntrl.Controls)
                    {
                        ctrl1.Enabled = true;
                    }       
                }

                else
                {
                    cntrl.Enabled = true;
                }
            }
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            DisableControls(this);
        }


        public void GetPurchaseId()
        {
            purchasebl = new PurchaseBL();

            try
            {
                int Id = purchasebl.GetPurchaseId();
                txtPurchaseId.Text = Convert.ToString(++Id);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);

            }

        }

        public void DisableControls(Control con)
        {
            foreach (Control control in con.Controls)
            {
                if (control is Panel && control.Name != "panel4")
                {
                    panel1.Enabled = false;
                    panel2.Enabled = false;

                }

                else if (control is Panel && control.Name == "panel4")
                {
                    foreach (Control c in panel4.Controls)
                    {
                        if (c.Name != "btnNew")
                        {
                            c.Enabled = false;
                        }
                    }
                }

                else
                {
                    control.Enabled = false;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addBookDetailsToGrid();
        }

        public void addBookDetailsToGrid()
        {
            string firstColumn = Convert.ToString(++sIno);
            string secondColumn = txtBookId.Text;
            string thirdColumn = txtBookName.Text;
            string fourthColumn = txtQty.Text;
            string fifthColumn = txtRate.Text;
            string sixthColumn = txtAmount.Text;
            string[] row = { firstColumn, secondColumn, thirdColumn, fourthColumn, fifthColumn, sixthColumn };
            dataGridView1.Rows.Add(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePurchaseDetails();
        }

        public void SavePurchaseDetails()
        {
            purchasebl = new PurchaseBL();

            try
            {
                purchase = new PurchaseEntities();
                purchase.purchaseId = Convert.ToInt32(txtPurchaseId.Text);
                purchase.purchaseFrom = txtPurchaseFrom.Text;
                purchase.purcahseDate = Convert.ToDateTime(dtpPurchaseDate.Text);
                purchase.purchaseStatus = Convert.ToString(cmbStatus.Text) == "Active" ? 1 : 0;

                dt = new DataTable();
                //dt.Columns.Add("SI No");
                dt.Columns.Add("Pur_Id");
                dt.Columns.Add("Pur_Date");
                dt.Columns.Add("BookId");
                dt.Columns.Add("BookName");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Rate");
                dt.Columns.Add("Amount");
                dt.Columns.Add("Status");

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dt.Rows.Add();
                    dt.Rows[i]["Pur_Id"] = purchase.purchaseId;
                    //dt.Rows[i]["SI No"] = dataGridView1["SINo", i].Value;
                    dt.Rows[i]["Pur_Date"] = purchase.purcahseDate;
                    dt.Rows[i]["BookId"] = dataGridView1["BookId", i].Value;
                    dt.Rows[i]["BookName"] = dataGridView1["BookName", i].Value;
                    dt.Rows[i]["Quantity"] = dataGridView1["Qty", i].Value;
                    dt.Rows[i]["Rate"] = dataGridView1["Rate", i].Value;
                    dt.Rows[i]["Amount"] = dataGridView1["Amount", i].Value;
                    dt.Rows[i]["Status"] = purchase.purchaseStatus;
                }

                purchasebl.SavePurchaseDetails(purchase, dt);
            }

            catch (Exception ex)
            {
                string errorMessage = ErrorHandling.Class1.CreateErrorMessage(ex);
                ErrorHandling.Class1.LogFileWrite(errorMessage);

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
            //spLoadPurchaseDetailsByPurchaseId
        }
    }
}
