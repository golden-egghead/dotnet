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

namespace FirstProject
{
    public partial class Login : Form
    {
        BankAccountTypeContext context;
        public Login()
        {
            InitializeComponent();
            context = new BankAccountTypeContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (context.Users.Where(p => p.UserName.Equals(username) && p.Password.Equals(password) && p.UserRole.Equals(1)).FirstOrDefault() != null)
            {
                MessageBox.Show("Login success", "Notification", MessageBoxButtons.OK);

                this.Hide();

                Form frManagement = new Management();
                frManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login faild", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
