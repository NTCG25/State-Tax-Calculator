using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            double tax1 = Convert.ToDouble(before_Tax.Text);
            double tax2 = Convert.ToDouble(state_Tax.Text);

            double result = tax1 * tax2 / 100;

            after_Tax.Text = Convert.ToString(result + tax1);              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
