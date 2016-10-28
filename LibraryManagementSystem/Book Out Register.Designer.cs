namespace LibraryManagementSystem
{
    partial class Book_Out_Register
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
            this.lblRegID = new System.Windows.Forms.Label();
            this.lblMemID = new System.Windows.Forms.Label();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookOutDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.SINo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegID
            // 
            this.lblRegID.AutoSize = true;
            this.lblRegID.Location = new System.Drawing.Point(17, 32);
            this.lblRegID.Name = "lblRegID";
            this.lblRegID.Size = new System.Drawing.Size(47, 13);
            this.lblRegID.TabIndex = 0;
            this.lblRegID.Text = "Reg ID :";
            // 
            // lblMemID
            // 
            this.lblMemID.AutoSize = true;
            this.lblMemID.Location = new System.Drawing.Point(17, 70);
            this.lblMemID.Name = "lblMemID";
            this.lblMemID.Size = new System.Drawing.Size(50, 13);
            this.lblMemID.TabIndex = 1;
            this.lblMemID.Text = "Mem ID :";
            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.Location = new System.Drawing.Point(440, 32);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(78, 13);
            this.lblRegDate.TabIndex = 2;
            this.lblRegDate.Text = "Register Date :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(475, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(20, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 152);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SINo,
            this.BookId,
            this.BookName,
            this.BookOutDate,
            this.Qty});
            this.dataGridView1.Location = new System.Drawing.Point(9, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(713, 135);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblBookOutDate);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Controls.Add(this.lblBookId);
            this.panel2.Controls.Add(this.dtpBookOutDate);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.txtBookID);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(20, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 45);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalItems);
            this.panel3.Controls.Add(this.btnView);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(20, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 36);
            this.panel3.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(630, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(166, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(328, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(409, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(490, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(70, 29);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(100, 20);
            this.txtRegID.TabIndex = 7;
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(70, 67);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(100, 20);
            this.txtMemID.TabIndex = 8;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(15, 17);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 20);
            this.txtBookID.TabIndex = 8;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(159, 17);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(468, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(526, 67);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegDate.Location = new System.Drawing.Point(526, 29);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(121, 20);
            this.dtpRegDate.TabIndex = 12;
            // 
            // dtpBookOutDate
            // 
            this.dtpBookOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookOutDate.Location = new System.Drawing.Point(303, 17);
            this.dtpBookOutDate.Name = "dtpBookOutDate";
            this.dtpBookOutDate.Size = new System.Drawing.Size(121, 20);
            this.dtpBookOutDate.TabIndex = 13;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(10, 1);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(50, 13);
            this.lblBookId.TabIndex = 14;
            this.lblBookId.Text = "Book Id :";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(160, 1);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(69, 13);
            this.lblBookName.TabIndex = 15;
            this.lblBookName.Text = "Book Name :";
            // 
            // lblBookOutDate
            // 
            this.lblBookOutDate.AutoSize = true;
            this.lblBookOutDate.Location = new System.Drawing.Point(301, 1);
            this.lblBookOutDate.Name = "lblBookOutDate";
            this.lblBookOutDate.Size = new System.Drawing.Size(84, 13);
            this.lblBookOutDate.TabIndex = 16;
            this.lblBookOutDate.Text = "Book Out Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-498, -166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(466, 1);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(29, 13);
            this.lblQty.TabIndex = 17;
            this.lblQty.Text = "Qty :";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(6, 8);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(65, 13);
            this.lblTotalItems.TabIndex = 13;
            this.lblTotalItems.Text = "Total Items :";
            // 
            // SINo
            // 
            this.SINo.HeaderText = "SINo";
            this.SINo.Name = "SINo";
            this.SINo.ReadOnly = true;
            // 
            // BookId
            // 
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.FillWeight = 400F;
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookOutDate
            // 
            this.BookOutDate.HeaderText = "Book Out Date";
            this.BookOutDate.Name = "BookOutDate";
            this.BookOutDate.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Book_Out_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 368);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpRegDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.txtRegID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRegDate);
            this.Controls.Add(this.lblMemID);
            this.Controls.Add(this.lblRegID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Book_Out_Register";
            this.Text = "Book_Out_Register";
            this.Load += new System.EventHandler(this.Book_Out_Register_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegID;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblBookOutDate;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.DateTimePicker dtpBookOutDate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SINo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}