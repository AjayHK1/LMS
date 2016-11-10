using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Entities;
using Model.Connection;
using BL;

namespace LibraryManagementSystem
{
    public partial class Book : Form
    {
        DBConnection con = new DBConnection();
        DataTable dt = new DataTable();
        public Book()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            LoadBookId();
            LoadComboBox();
            EnableControls(this);
        }

        public void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c.Name != "txtBookId")
                {
                    c.Enabled = true;
                }
            }
        }

        public void LoadComboBox()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In Active");
        }

        private void Book_Load(object sender, EventArgs e)
        {
            DisableControls(this);
            LoadDataToGrid();
        }

        public void LoadDataToGrid()  //Use DAL,Class Create Const,Enum
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spLoadBookDataToGrid", con.ActiveCon());
                SqlDataAdapter ad = new SqlDataAdapter(cmd);   //
                ad.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["BookId", i].Value = dt.Rows[i]["Book_Id"];
                    dataGridView1["BookName", i].Value = dt.Rows[i]["Book_Name"];
                    dataGridView1["BookStatus", i].Value = dt.Rows[i]["Book_Status"];
                }
            }

            catch (Exception ex)
            {
                BookMasterBL objbook = new BookMasterBL();
                objbook.InserToErrorLog("Book", ex.Message.ToString(), "LoadDataToGrid");
            }

            finally
            {
                con.CloseCon();
            }
        }

        public void LoadBookId()
        {
            int count = 0;
            
            try
            {
                SqlCommand cmd = new SqlCommand("spCntBookRecords", con.ActiveCon());
                count = Convert.ToInt32(cmd.ExecuteScalar());
                txtBookId.Text = Convert.ToString(++count);
                
            }

            catch (Exception ex)
            {
                BookMasterBL objbook = new BookMasterBL();
                objbook.InserToErrorLog("Book", ex.Message.ToString(), "LoadBookId");
            }

            finally
            {
                con.CloseCon();
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


                else if (c is GroupBox)
                {
                    c.Enabled = false;
                }


            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BookMasterBL objbook = new BookMasterBL();
            try
            {
                BookMaster b = new BookMaster(); //b--->>bookmaster 
                b.BookId = Convert.ToInt32(txtBookId.Text);
                b.BookName = txtBookName.Text;
                b.BookStatus =Convert.ToString(cmbStatus.SelectedItem);

                
                objbook.SaveBookMasterdata(b);
                MessageBox.Show("Record is Saved...");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Record is Not Saved...");
                objbook.InserToErrorLog("Book", ex.Message.ToString(), "btnSave_Click");
            }

            finally
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbStatus.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookMasterBL objbook = new BookMasterBL();
            try
            {
                BookMaster b = new BookMaster();
                b.BookId = Convert.ToInt32(txtBookId.Text);
                b.BookName = txtBookName.Text;
                b.BookStatus = Convert.ToString(cmbStatus.SelectedItem);

                
                objbook.UpdateBookMasterData(b);
                MessageBox.Show("Record is Updated...");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Record is Not Updated...");
                objbook.InserToErrorLog("Book", ex.Message.ToString(), "btnUpdate_Click");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookMasterBL objbook = new BookMasterBL();
            try
            {
                BookMaster b = new BookMaster();
                b.BookId = Convert.ToInt32(txtBookId.Text);

                
                objbook.DeleteBookMasterData(b);
                MessageBox.Show("Record is Deleted...");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Record is Not Deleted...");
                objbook.InserToErrorLog("Book", ex.Message.ToString(), "btnDelete_Click");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                int Id;
                if(int.TryParse(txtSearch.Text,out Id))
                {
                    LoadDataToGrid(Id);
                }
            }
        }

        public void LoadDataToGrid(int bookId)
        {
            BookMasterBL bookBL = new BookMasterBL();
            DataTable dt = bookBL.LoadBookDataToGrid(bookId);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1["BookId", i].Value = dt.Rows[i]["Book_Id"];
                dataGridView1["BookName", i].Value = dt.Rows[i]["Book_Name"];
                dataGridView1["BookStatus", i].Value = dt.Rows[i]["Book_Status"];
            }
        }
    }
}
