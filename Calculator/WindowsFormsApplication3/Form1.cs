using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            num1 = int.Parse(txtno1.Text);
            num2 = int.Parse(txtno2.Text);
            MessageBox.Show("sum= " + (num1 + num2));
        }
    }
}
