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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            if (balrad.Checked)
            {
                int bal = 5000;
                MessageBox.Show("Your Balance is Rs." + bal.ToString());
            }
            if (withdrawrad.Checked)
            {
                withdraw f2 = new withdraw();
                f2.Show();
            }
            if (depositrad.Checked)
            {
                deposit f3 = new deposit();
                f3.Show();
            }

            if (quitrad.Checked)
            {
                Application.Exit();
            }
        }
    }
}
