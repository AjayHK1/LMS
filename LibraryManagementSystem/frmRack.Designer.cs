﻿namespace LibraryManagementSystem
{
    partial class frmRack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRackID = new System.Windows.Forms.TextBox();
            this.txtRackName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblRackStatus = new System.Windows.Forms.Label();
            this.cmbRackStatus = new System.Windows.Forms.ComboBox();
            this.lblRackName = new System.Windows.Forms.Label();
            this.lblRackId = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RackStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRackID
            // 
            this.txtRackID.Location = new System.Drawing.Point(113, 24);
            this.txtRackID.Name = "txtRackID";
            this.txtRackID.Size = new System.Drawing.Size(100, 20);
            this.txtRackID.TabIndex = 0;
            // 
            // txtRackName
            // 
            this.txtRackName.Location = new System.Drawing.Point(113, 66);
            this.txtRackName.Name = "txtRackName";
            this.txtRackName.Size = new System.Drawing.Size(100, 20);
            this.txtRackName.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(248, 178);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.lblRackStatus);
            this.panel1.Controls.Add(this.cmbRackStatus);
            this.panel1.Controls.Add(this.lblRackName);
            this.panel1.Controls.Add(this.lblRackId);
            this.panel1.Controls.Add(this.txtRackID);
            this.panel1.Controls.Add(this.txtRackName);
            this.panel1.Location = new System.Drawing.Point(15, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 147);
            this.panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(242, 83);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(242, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(242, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblRackStatus
            // 
            this.lblRackStatus.AutoSize = true;
            this.lblRackStatus.Location = new System.Drawing.Point(17, 109);
            this.lblRackStatus.Name = "lblRackStatus";
            this.lblRackStatus.Size = new System.Drawing.Size(69, 13);
            this.lblRackStatus.TabIndex = 6;
            this.lblRackStatus.Text = "Rack Status:";
            // 
            // cmbRackStatus
            // 
            this.cmbRackStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRackStatus.FormattingEnabled = true;
            this.cmbRackStatus.Location = new System.Drawing.Point(112, 106);
            this.cmbRackStatus.Name = "cmbRackStatus";
            this.cmbRackStatus.Size = new System.Drawing.Size(100, 21);
            this.cmbRackStatus.TabIndex = 5;
            // 
            // lblRackName
            // 
            this.lblRackName.AutoSize = true;
            this.lblRackName.Location = new System.Drawing.Point(18, 64);
            this.lblRackName.Name = "lblRackName";
            this.lblRackName.Size = new System.Drawing.Size(64, 13);
            this.lblRackName.TabIndex = 4;
            this.lblRackName.Text = "Rack Name";
            // 
            // lblRackId
            // 
            this.lblRackId.AutoSize = true;
            this.lblRackId.Location = new System.Drawing.Point(18, 26);
            this.lblRackId.Name = "lblRackId";
            this.lblRackId.Size = new System.Drawing.Size(47, 13);
            this.lblRackId.TabIndex = 3;
            this.lblRackId.Text = "Rack ID";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(196, 181);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search :";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 158);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RackId,
            this.RackName,
            this.RackStatus});
            this.dataGridView1.Location = new System.Drawing.Point(15, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 146);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // RackId
            // 
            this.RackId.HeaderText = "Rack ID";
            this.RackId.Name = "RackId";
            // 
            // RackName
            // 
            this.RackName.HeaderText = "Rack Name";
            this.RackName.Name = "RackName";
            // 
            // RackStatus
            // 
            this.RackStatus.HeaderText = "Rack Status";
            this.RackStatus.Name = "RackStatus";
            // 
            // frmRack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 373);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRack";
            this.Text = "Rack";
            this.Load += new System.EventHandler(this.frmRack_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRackID;
        private System.Windows.Forms.TextBox txtRackName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRackName;
        private System.Windows.Forms.Label lblRackId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RackStatus;
        private System.Windows.Forms.Label lblRackStatus;
        private System.Windows.Forms.ComboBox cmbRackStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
    }
}