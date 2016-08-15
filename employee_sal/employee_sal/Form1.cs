using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_sal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string name = txtname.Text;
            double  basicsal = double.Parse(txtsal.Text);
            double netsal=0;
            if (chkda.Checked == true)
            {
                netsal += basicsal + 1000;
            }
            if (chkhr.Checked == true)
            {
                netsal += basicsal + 6000;
            }
            if (chkins.Checked == true)
            {
                netsal += basicsal + 4000;
            }
            if (chkea.Checked == true)
            {
                netsal += basicsal + 10000;
            }
            else
            {
                netsal += basicsal;
            }
            
            txttotal.Text = netsal.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtsal.Text = "";
            txttotal.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
