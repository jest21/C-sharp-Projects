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
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            int bal= 5000;

            int deposit=int.Parse(txtdeposit.Text);
            curbalance.Text = (bal + deposit).ToString( );
        }

        private void cancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}
