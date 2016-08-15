using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm1
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }

        private void wbal_Click(object sender, EventArgs e)
        {
            int bal = 5000;

            int withdraw = int.Parse(txtwithdraw.Text);
            currentbal.Text = (bal - withdraw).ToString();
 
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void currentbal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtwithdraw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
