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
    public partial class frmHomePage : Form
    {
        public static double Price;
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Price += 40;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Price += 20;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Price += 30;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Price += 15;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Price += 13;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Price += 57;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Price += 62;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Price += 21;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Price += 16;

        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmCart s = new frmCart();
            s.ShowDialog();
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice1_Click(object sender, EventArgs e)
        {

        }
    }
}
