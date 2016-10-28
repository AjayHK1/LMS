namespace LibraryManagementSystem
{
    partial class Plan
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
            this.lblPlanID = new System.Windows.Forms.Label();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblDateOfCreation = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblBookOnHold = new System.Windows.Forms.Label();
            this.lblValidity = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtBookOnHold = new System.Windows.Forms.TextBox();
            this.txtValidity = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpDateOfCreation = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtTotRec = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.dtpDateOfValidity = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlanID
            // 
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.Location = new System.Drawing.Point(29, 42);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(48, 13);
            this.lblPlanID.TabIndex = 0;
            this.lblPlanID.Text = "Plan ID :";
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Location = new System.Drawing.Point(29, 78);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(65, 13);
            this.lblPlanName.TabIndex = 1;
            this.lblPlanName.Text = "Plan Name :";
            // 
            // lblDateOfCreation
            // 
            this.lblDateOfCreation.AutoSize = true;
            this.lblDateOfCreation.Location = new System.Drawing.Point(29, 115);
            this.lblDateOfCreation.Name = "lblDateOfCreation";
            this.lblDateOfCreation.Size = new System.Drawing.Size(92, 13);
            this.lblDateOfCreation.TabIndex = 2;
            this.lblDateOfCreation.Text = "Date Of Creation :";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(29, 155);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(34, 13);
            this.lblLimit.TabIndex = 3;
            this.lblLimit.Text = "Limit :";
            // 
            // lblBookOnHold
            // 
            this.lblBookOnHold.AutoSize = true;
            this.lblBookOnHold.Location = new System.Drawing.Point(29, 193);
            this.lblBookOnHold.Name = "lblBookOnHold";
            this.lblBookOnHold.Size = new System.Drawing.Size(80, 13);
            this.lblBookOnHold.TabIndex = 4;
            this.lblBookOnHold.Text = "Book On Hold :";
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.Location = new System.Drawing.Point(448, 45);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(46, 13);
            this.lblValidity.TabIndex = 5;
            this.lblValidity.Text = "Validity :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(448, 89);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(448, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 130);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Plan Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DOC";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Limit";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hold";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Validity";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Discount";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Status";
            this.Column9.Name = "Column9";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(32, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 133);
            this.panel1.TabIndex = 9;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(171, 390);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(284, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(510, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPlanID
            // 
            this.txtPlanID.Location = new System.Drawing.Point(137, 37);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(200, 20);
            this.txtPlanID.TabIndex = 14;
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(137, 75);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(200, 20);
            this.txtPlanName.TabIndex = 15;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(137, 151);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(200, 20);
            this.txtLimit.TabIndex = 16;
            // 
            // txtBookOnHold
            // 
            this.txtBookOnHold.Location = new System.Drawing.Point(137, 189);
            this.txtBookOnHold.Name = "txtBookOnHold";
            this.txtBookOnHold.Size = new System.Drawing.Size(200, 20);
            this.txtBookOnHold.TabIndex = 17;
            // 
            // txtValidity
            // 
            this.txtValidity.Location = new System.Drawing.Point(517, 42);
            this.txtValidity.Name = "txtValidity";
            this.txtValidity.Size = new System.Drawing.Size(200, 20);
            this.txtValidity.TabIndex = 18;
            this.txtValidity.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(517, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // dtpDateOfCreation
            // 
            this.dtpDateOfCreation.CustomFormat = "dd-MM-yyyy";
            this.dtpDateOfCreation.Location = new System.Drawing.Point(137, 113);
            this.dtpDateOfCreation.Name = "dtpDateOfCreation";
            this.dtpDateOfCreation.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfCreation.TabIndex = 20;
            this.dtpDateOfCreation.Value = new System.DateTime(2016, 10, 16, 0, 0, 0, 0);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(517, 174);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 21;
            // 
            // txtTotRec
            // 
            this.txtTotRec.Enabled = false;
            this.txtTotRec.Location = new System.Drawing.Point(639, 215);
            this.txtTotRec.Name = "txtTotRec";
            this.txtTotRec.Size = new System.Drawing.Size(89, 20);
            this.txtTotRec.TabIndex = 22;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(517, 130);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDiscount.TabIndex = 24;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(448, 132);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 13);
            this.lblDiscount.TabIndex = 23;
            this.lblDiscount.Text = "Discount :";
            // 
            // dtpDateOfValidity
            // 
            this.dtpDateOfValidity.CustomFormat = "dd-MM-yyyy";
            this.dtpDateOfValidity.Location = new System.Drawing.Point(517, 42);
            this.dtpDateOfValidity.Name = "dtpDateOfValidity";
            this.dtpDateOfValidity.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfValidity.TabIndex = 25;
            this.dtpDateOfValidity.Value = new System.DateTime(2016, 10, 17, 0, 0, 0, 0);
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 434);
            this.Controls.Add(this.dtpDateOfValidity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtTotRec);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpDateOfCreation);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtValidity);
            this.Controls.Add(this.txtBookOnHold);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.txtPlanID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblValidity);
            this.Controls.Add(this.lblBookOnHold);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblDateOfCreation);
            this.Controls.Add(this.lblPlanName);
            this.Controls.Add(this.lblPlanID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Plan";
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblDateOfCreation;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblBookOnHold;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtBookOnHold;
        private System.Windows.Forms.TextBox txtValidity;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDateOfCreation;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtTotRec;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.DateTimePicker dtpDateOfValidity;
    }
}