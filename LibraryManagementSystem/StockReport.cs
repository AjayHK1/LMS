using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;

namespace LibraryManagementSystem
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            LoadReportToGrid();
            MarkMaxMinQty();
        }

        public void MarkMaxMinQty()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["Qty"].Value) < 30)
                {
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.YellowGreen;
                }

                else if (Convert.ToInt32(row.Cells["Qty"].Value) == 40)
                {
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
                }
                //////////////////////////////////////////////////////////////////
                
            }
        }

        public void LoadReportToGrid()
        {
            StockReportBL stkReportBL = new StockReportBL();
            DataSet ds = stkReportBL.LoadReportToGrid();
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int Id;
                if(int.TryParse(txtSearch.Text,out Id))
                {
                    LoadReportToGrid(Id);
                }

                MarkMaxMinQty();
                
            }
        }

        public void LoadReportToGrid(int bookId)
        {
            StockReportBL stkReportBL = new StockReportBL();
            DataSet ds = stkReportBL.LoadReportToGrid(bookId);
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //MarkMaxMinQty();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            MarkMaxMinQty();
        }
    }
}
