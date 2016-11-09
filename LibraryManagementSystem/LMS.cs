using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LMS : Form
    {
        private int childFormNumber = 0;

        public LMS()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void LMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role obj = new Role();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void LMS_Load(object sender, EventArgs e)
        {

        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section obj = new Section();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Profile obj = new Profile();
            //obj.MdiParent = this;
            //obj.StartPosition = FormStartPosition.CenterParent;
            //obj.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan obj = new Plan();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase obj = new Purchase();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_In_Register obj = new Book_In_Register();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Out_Register obj = new Book_Out_Register();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book obj = new Book();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRack obj = new frmRack();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            
        }

        private void sectionRackMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSectionRackMap obj = new frmSectionRackMap();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReport StockReport = new StockReport(); //stockreport
            StockReport.MdiParent = this;
            StockReport.StartPosition = FormStartPosition.CenterParent;
            StockReport.Show();
        }
    }
}
