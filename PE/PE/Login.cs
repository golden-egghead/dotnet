using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Models;
using Services.Services;

namespace PE
{
    public partial class Login : Form
    {
        BankAccountTypeContext _context;
        public Login()
        {
            InitializeComponent();
            _context = new BankAccountTypeContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if(_context.Users.Where(p => p.UserName.Equals(txtUsername.Text) && 
            p.Password.Equals(txtPassword.Text) && p.UserRole.Equals(1)).FirstOrDefault() != null ) 
            {
                this.Hide();
                Management frManagement = new Management();
                frManagement.ShowDialog();
            } else
            {
                MessageBox.Show("Login fail!");
                btnLogin.Enabled = true;
            }
        }
    }
}
