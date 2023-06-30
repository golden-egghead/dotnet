using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore_NguyenTrungTin
{
    public partial class Login : Form
    {
        PetShopMemberServices petShopMemberServices;
        public Login()
        {
            InitializeComponent();
            petShopMemberServices = new PetShopMemberServices();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if(petShopMemberServices.GetAll().Where(p => p.EmailAddress.Equals(txtUsername.Text)
            && p.MemberPassword.Equals(txtPassword.Text)
            && p.MemberRole.Equals(2)).FirstOrDefault() != null )
            {
                PetManagement frPetManagement = new PetManagement();
                this.Hide();
                frPetManagement.ShowDialog();
            } else
            {
                MessageBox.Show("You have no permission to access this function");
            }
        }
    }
}
