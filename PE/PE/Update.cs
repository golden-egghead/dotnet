using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        public Update(string accountID, string accountName, DateTime openDate, string branchName, ComboBox typeName)
        {
            InitializeComponent();

            txtAccountID.Text = accountID;
            txtAccountName.Text = accountName;
            txtBranchName.Text = branchName;
            dtpOpenDate.Text = openDate.ToString();
            cboTypeName.Text = typeName.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
