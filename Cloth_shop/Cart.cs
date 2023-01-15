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
    public partial class frmCart : Form
    {
        public static frmCart Total;
        public frmCart()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            frmHomePage.Price = 0;
            this.Close();
            MessageBox.Show("Thank you for shoping with us");
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            frmHomePage.Price = 0;
            this.Close();
            MessageBox.Show("Canceled successfully");
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Your total price is " + frmHomePage.Price + ".\nDo you want to continue ?";
        }
    }
}
