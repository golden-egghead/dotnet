namespace FirstProject
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
            dgvStudent = new DataGridView();
            txtID = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            lbID = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            lbPhoneNumber = new Label();
            lbEmail = new Label();
            lbDescription = new Label();
            txtDescription = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnRemove = new Button();
            fontDialog1 = new FontDialog();
            lbStudentManagement = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(41, 350);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.Size = new Size(986, 312);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellDoubleClick += dgvStudent_CellDoubleClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(669, 29);
            txtID.Name = "txtID";
            txtID.Size = new Size(358, 27);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(669, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(358, 27);
            txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(669, 112);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(358, 27);
            txtAge.TabIndex = 3;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(552, 36);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 4;
            lbID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 75);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 119);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(669, 296);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(801, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(552, 162);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(108, 20);
            lbPhoneNumber.TabIndex = 9;
            lbPhoneNumber.Text = "Phone Number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(552, 207);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 10;
            lbEmail.Text = "Email";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(552, 254);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(85, 20);
            lbDescription.TabIndex = 11;
            lbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(669, 247);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(358, 27);
            txtDescription.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(669, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(669, 155);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(358, 27);
            txtPhoneNumber.TabIndex = 4;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(933, 296);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lbStudentManagement
            // 
            lbStudentManagement.AutoSize = true;
            lbStudentManagement.FlatStyle = FlatStyle.System;
            lbStudentManagement.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudentManagement.ForeColor = Color.SteelBlue;
            lbStudentManagement.Location = new Point(41, 29);
            lbStudentManagement.Name = "lbStudentManagement";
            lbStudentManagement.Size = new Size(505, 67);
            lbStudentManagement.TabIndex = 13;
            lbStudentManagement.Text = "Student Management";
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 732);
            Controls.Add(lbStudentManagement);
            Controls.Add(btnRemove);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtDescription);
            Controls.Add(lbDescription);
            Controls.Add(lbEmail);
            Controls.Add(lbPhoneNumber);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbID);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(dgvStudent);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAge;
        private Label lbID;
        private Label label2;
        private Label label3;
        private Button btnCreate;
        private Button btnUpdate;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private Label lbDescription;
        private TextBox txtDescription;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnRemove;
        private FontDialog fontDialog1;
        private Label lbStudentManagement;
    }
}