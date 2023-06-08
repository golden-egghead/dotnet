namespace PE
{
    partial class Management
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
            dgvManagement = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lbAccountID = new Label();
            lbAccountName = new Label();
            lbOpenDate = new Label();
            lbBranchName = new Label();
            txtAccountID = new TextBox();
            txtAccountName = new TextBox();
            txtBranchName = new TextBox();
            cboTypeName = new ComboBox();
            label2 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            dtpOpenDate = new DateTimePicker();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvManagement).BeginInit();
            SuspendLayout();
            // 
            // dgvManagement
            // 
            dgvManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManagement.Location = new Point(12, 12);
            dgvManagement.Name = "dgvManagement";
            dgvManagement.RowHeadersWidth = 51;
            dgvManagement.RowTemplate.Height = 29;
            dgvManagement.Size = new Size(852, 188);
            dgvManagement.TabIndex = 0;
            dgvManagement.CellContentDoubleClick += dgvManagement_CellContentDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 217);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(435, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(474, 217);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbAccountID
            // 
            lbAccountID.AutoSize = true;
            lbAccountID.Location = new Point(12, 264);
            lbAccountID.Name = "lbAccountID";
            lbAccountID.Size = new Size(82, 20);
            lbAccountID.TabIndex = 3;
            lbAccountID.Text = "Account ID";
            // 
            // lbAccountName
            // 
            lbAccountName.AutoSize = true;
            lbAccountName.Location = new Point(12, 309);
            lbAccountName.Name = "lbAccountName";
            lbAccountName.Size = new Size(107, 20);
            lbAccountName.TabIndex = 4;
            lbAccountName.Text = "Account Name";
            // 
            // lbOpenDate
            // 
            lbOpenDate.AutoSize = true;
            lbOpenDate.Location = new Point(12, 354);
            lbOpenDate.Name = "lbOpenDate";
            lbOpenDate.Size = new Size(81, 20);
            lbOpenDate.TabIndex = 5;
            lbOpenDate.Text = "Open Date";
            // 
            // lbBranchName
            // 
            lbBranchName.AutoSize = true;
            lbBranchName.Location = new Point(12, 400);
            lbBranchName.Name = "lbBranchName";
            lbBranchName.Size = new Size(98, 20);
            lbBranchName.TabIndex = 6;
            lbBranchName.Text = "Branch Name";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(142, 257);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(305, 27);
            txtAccountID.TabIndex = 3;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(142, 302);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(305, 27);
            txtAccountName.TabIndex = 4;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(142, 393);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(305, 27);
            txtBranchName.TabIndex = 6;
            // 
            // cboTypeName
            // 
            cboTypeName.FormattingEnabled = true;
            cboTypeName.Location = new Point(142, 441);
            cboTypeName.Name = "cboTypeName";
            cboTypeName.Size = new Size(305, 28);
            cboTypeName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 449);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 11;
            label2.Text = "Type Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(356, 487);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 41);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(142, 487);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 41);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.Location = new Point(142, 347);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(305, 27);
            dtpOpenDate.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(715, 460);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 68);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 573);
            Controls.Add(btnUpdate);
            Controls.Add(dtpOpenDate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(cboTypeName);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(txtAccountID);
            Controls.Add(lbBranchName);
            Controls.Add(lbOpenDate);
            Controls.Add(lbAccountName);
            Controls.Add(lbAccountID);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvManagement);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvManagement;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lbAccountID;
        private Label lbAccountName;
        private Label lbOpenDate;
        private Label lbBranchName;
        private TextBox txtAccountID;
        private TextBox txtAccountName;
        private TextBox txtBranchName;
        private ComboBox cboTypeName;
        private Label label2;
        private Button btnDelete;
        private Button btnAdd;
        private DateTimePicker dtpOpenDate;
        private Button btnUpdate;
    }
}