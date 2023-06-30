using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Services;

namespace PRN211PE_FA22_TrialTest_NguyenTrungTin
{
    public partial class Login : Form
    {
        UserServices userServices;
        public Login()
        {
            InitializeComponent();
            userServices = new UserServices();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if(userServices.GetAll().Where(p => p.UserName.Equals(txtUsername.Text) &&
            p.Password.Equals(txtPassword.Text) &&
            p.UserRole.Equals(1)).FirstOrDefault() != null)
            {
                this.Hide();
                Management frManagement = new Management();
                frManagement.ShowDialog();
            } else
            {
                MessageBox.Show("Login Faild!");
                btnLogin.Enabled = true;
            }

        }
    }
}
