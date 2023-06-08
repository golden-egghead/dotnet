namespace PE
{
    partial class Update
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
            dtpOpenDate = new DateTimePicker();
            label2 = new Label();
            cboTypeName = new ComboBox();
            txtBranchName = new TextBox();
            txtAccountName = new TextBox();
            lbBranchName = new Label();
            lbOpenDate = new Label();
            lbAccountName = new Label();
            btnUpdate = new Button();
            txtAccountID = new TextBox();
            lbAccountID = new Label();
            SuspendLayout();
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.Location = new Point(178, 164);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(305, 27);
            dtpOpenDate.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 266);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 21;
            label2.Text = "Type Name";
            // 
            // cboTypeName
            // 
            cboTypeName.FormattingEnabled = true;
            cboTypeName.Location = new Point(178, 258);
            cboTypeName.Name = "cboTypeName";
            cboTypeName.Size = new Size(305, 28);
            cboTypeName.TabIndex = 20;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(178, 210);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(305, 27);
            txtBranchName.TabIndex = 18;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(178, 119);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(305, 27);
            txtAccountName.TabIndex = 15;
            // 
            // lbBranchName
            // 
            lbBranchName.AutoSize = true;
            lbBranchName.Location = new Point(48, 217);
            lbBranchName.Name = "lbBranchName";
            lbBranchName.Size = new Size(98, 20);
            lbBranchName.TabIndex = 19;
            lbBranchName.Text = "Branch Name";
            // 
            // lbOpenDate
            // 
            lbOpenDate.AutoSize = true;
            lbOpenDate.Location = new Point(48, 171);
            lbOpenDate.Name = "lbOpenDate";
            lbOpenDate.Size = new Size(81, 20);
            lbOpenDate.TabIndex = 17;
            lbOpenDate.Text = "Open Date";
            // 
            // lbAccountName
            // 
            lbAccountName.AutoSize = true;
            lbAccountName.Location = new Point(48, 126);
            lbAccountName.Name = "lbAccountName";
            lbAccountName.Size = new Size(107, 20);
            lbAccountName.TabIndex = 16;
            lbAccountName.Text = "Account Name";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(178, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAccountID
            // 
            txtAccountID.Enabled = false;
            txtAccountID.Location = new Point(178, 77);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(305, 27);
            txtAccountID.TabIndex = 24;
            // 
            // lbAccountID
            // 
            lbAccountID.AutoSize = true;
            lbAccountID.Location = new Point(48, 84);
            lbAccountID.Name = "lbAccountID";
            lbAccountID.Size = new Size(82, 20);
            lbAccountID.TabIndex = 25;
            lbAccountID.Text = "Account ID";
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 420);
            Controls.Add(txtAccountID);
            Controls.Add(lbAccountID);
            Controls.Add(btnUpdate);
            Controls.Add(dtpOpenDate);
            Controls.Add(label2);
            Controls.Add(cboTypeName);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(lbBranchName);
            Controls.Add(lbOpenDate);
            Controls.Add(lbAccountName);
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpOpenDate;
        private Label label2;
        private ComboBox cboTypeName;
        private TextBox txtBranchName;
        private TextBox txtAccountName;
        private Label lbBranchName;
        private Label lbOpenDate;
        private Label lbAccountName;
        private Button btnUpdate;
        private TextBox txtAccountID;
        private Label lbAccountID;
    }
}