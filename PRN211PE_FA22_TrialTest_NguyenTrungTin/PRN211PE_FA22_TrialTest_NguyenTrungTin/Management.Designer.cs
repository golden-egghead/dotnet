namespace PRN211PE_FA22_TrialTest_NguyenTrungTin
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
            txtSeachValue = new TextBox();
            btnSearch = new Button();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            txtPrice = new TextBox();
            cboCategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvManagement).BeginInit();
            SuspendLayout();
            // 
            // dgvManagement
            // 
            dgvManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManagement.Location = new Point(747, 111);
            dgvManagement.Name = "dgvManagement";
            dgvManagement.RowHeadersWidth = 51;
            dgvManagement.RowTemplate.Height = 29;
            dgvManagement.Size = new Size(599, 637);
            dgvManagement.TabIndex = 0;
            dgvManagement.CellDoubleClick += dgvManagement_CellDoubleClick;
            // 
            // txtSeachValue
            // 
            txtSeachValue.Location = new Point(747, 42);
            txtSeachValue.Name = "txtSeachValue";
            txtSeachValue.Size = new Size(198, 27);
            txtSeachValue.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(960, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(165, 111);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(450, 27);
            txtProductName.TabIndex = 5;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(165, 178);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(450, 27);
            txtProductCode.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(165, 241);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(450, 27);
            txtPrice.TabIndex = 7;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(165, 311);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(239, 28);
            cboCategory.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 118);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 10;
            label2.Text = "ProductName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 181);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 11;
            label3.Text = "ProductCode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 248);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 12;
            label4.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 319);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 14;
            label6.Text = "Category";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(165, 42);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 27);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(343, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 27);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(521, 42);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 27);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 746);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(btnSearch);
            Controls.Add(txtSeachValue);
            Controls.Add(dgvManagement);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvManagement;
        private TextBox txtSeachValue;
        private Button btnSearch;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private TextBox txtPrice;
        private ComboBox cboCategory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
    }
}