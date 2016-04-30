using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
         double val1;
            double val2 ;
            double result;
            string symbol;
        int trackpoint=0;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            val2 = 0;
            val1 = 0;
            symbol = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn2.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn7.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn9.Text;
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btnpoint.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            symbol = "+";
            val1 = double.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
          

        }

        private void btnstore_Click(object sender, EventArgs e)
        {

        }

        private void btnequal_Click(object sender, EventArgs e)
        {
           
            double val2 = double.Parse(txtdisplay.Text);
            double result;

            if (symbol == "+")
            {
                result = val1 + val2;
                txtdisplay.Text = result.ToString();
            }
            else if (symbol == "-")
            {
                result = val1 - val2;
                txtdisplay.Text = result.ToString();
            }
            else if (symbol == "*")
            {
                result = val1 * val2;
                txtdisplay.Text = result.ToString();
            }
            else if (symbol == "/")
            {
                result = val1 / val2;
                txtdisplay.Text = result.ToString();
            }

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            symbol = "-";
            val1 = double.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            symbol = "*";
            val1 = double.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            symbol = "/";
            val1 = double.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
        }

    }
}