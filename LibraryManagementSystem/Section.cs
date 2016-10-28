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
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Section : Form
    {
        SqlConnection connectn = null;
        String con = "Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True";
        DataTable dt = new DataTable();

        public Section()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Section_Load(object sender, EventArgs e)
        {
            DisableControls(this); //do use PascalCasing for class names and method names.
            LoadDataToGrid();
            
        }

        public void LoadDataToGrid()
        {
            try
            {
                connectn = new SqlConnection(con);

                SqlDataAdapter adp = new SqlDataAdapter("spSelectSectionMasterDetails", connectn);//select * from Section_Master
                connectn.Open();
                adp.Fill(dt);
                //dataGridView1.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["Column1", i].Value = dt.Rows[i]["Sec_Id"];
                    dataGridView1["Column2", i].Value = dt.Rows[i]["Sec_Name"];
                    dataGridView1["Column3", i].Value = dt.Rows[i]["Sec_Status"];
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

        public void LoadSectionId()
        {
            try
            {
                connectn = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand("spCountSectionMasterDetails", connectn);
                connectn.Open();
                SqlDataReader readr;
                readr = cmd.ExecuteReader();
                readr.Read();
                int sectionId = Convert.ToInt32(readr[0].ToString());
                txtSectionId.Text = Convert.ToString(++sectionId); 
                
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
                if (c is Button && c.Text != "New")
                {
                    ((Button)c).Enabled = false;
                }

                else if (c is TextBox)
                {
                    c.Enabled = false; c.Text = "";
                }
                
                else if(c is ComboBox)
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
            LoadSectionId();
            EnableControls(this);
            ComboBoxLoad();
        }

        public void ComboBoxLoad()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("InActive");
        }

        public void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c.Name != "txtSectionId")
                {
                    c.Enabled = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSectionDetails();
        }

        public void SaveSectionDetails()
        {
            SectionMaster section = new SectionMaster();
            section.sectionId = Convert.ToInt32(txtSectionId.Text);
            section.sectionName = txtSectionName.Text;
            section.sectionStatus = cmbStatus.SelectedIndex;

            SectioMasterBL s = new SectioMasterBL();
            s.SaveSectionMasterdata(section);

            MessageBox.Show("Record is Saved","Message",MessageBoxButtons.OK);

            ClearControls();

        }

        public void ClearControls()
        {
            txtSectionId.Text = "";
            txtSectionName.Text = "";
            cmbStatus.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSectionMasterDetails();
        }

        public void UpdateSectionMasterDetails()
        {
            try
            {
                SectionMaster s = new SectionMaster();
                s.sectionId = Convert.ToInt32(txtSectionId.Text);
                s.sectionName = txtSectionName.Text;
                if (cmbStatus.SelectedItem == "Active")
                {
                    s.sectionStatus = 0;
                }

                else
                {
                    s.sectionStatus = 1;
                }

                SectioMasterBL bl = new SectioMasterBL();
                int n = bl.UpdateSectiondata(s);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSectionId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSectionName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int status =  Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            
            cmbStatus.Text = status == 0 ? "Active" :"In Active";

        }

        private void txtSectionName_TextChanged(object sender, EventArgs e)
        {
            if (txtSectionName.TextLength > 20)
            {
                MessageBox.Show("Accepts only 20 characters");
                txtSectionName.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSectionMasterDetails();
        }

        public void DeleteSectionMasterDetails()
        {
            try
            {
                SectionMaster objSec = new SectionMaster();
                objSec.sectionId = Convert.ToInt32(txtSectionId.Text);

                SectioMasterBL bl = new SectioMasterBL();
                int n = bl.DeleteSectionData(objSec);
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
    }
}
