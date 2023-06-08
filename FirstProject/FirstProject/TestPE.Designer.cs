namespace FirstProject
{
    partial class TestPE
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            lbID = new Label();
            lbName = new Label();
            lbAge = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(136, 173);
            txtID.Name = "txtID";
            txtID.Size = new Size(286, 27);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 240);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 27);
            txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(136, 305);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(286, 27);
            txtAge.TabIndex = 2;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(51, 180);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 3;
            lbID.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(51, 247);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 4;
            lbName.Text = "Name";
            // 
            // lbAge
            // 
            lbAge.AutoSize = true;
            lbAge.Location = new Point(51, 312);
            lbAge.Name = "lbAge";
            lbAge.Size = new Size(36, 20);
            lbAge.TabIndex = 5;
            lbAge.Text = "Age";
            // 
            // TestPE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbAge);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Name = "TestPE";
            Text = "TestPE";
            Load += TestPE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAge;
        private Label lbID;
        private Label lbName;
        private Label lbAge;
    }
}