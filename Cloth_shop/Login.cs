using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloth_shop
{
    public partial class Login : Form
    {
        frmHomePage my = new frmHomePage();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string x = "user";
            if (txtUserName.Text == x  & txtPassword.Text  == x) 
            
            {
                MessageBox.Show("Login Succuflly");
                my.Show();
            }
            else { MessageBox.Show("Error"); }

        }
    }
}
