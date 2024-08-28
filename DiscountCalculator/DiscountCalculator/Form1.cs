using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) { 
                e.Handled = true;
            }
            if((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        private void priceBox_textChanged(object sender, EventArgs e)
        {
            string itemPrice = textBox1.Text.Contains('$') ? textBox1.Text.Replace('$', ' ') : textBox1.Text;

            if (checkBox1.Checked ) {
                textBox_total.Text = "$ " + (int.Parse(itemPrice) - int.Parse(itemPrice) * numericUpDown1.Value/100).ToString();
            }
            else
            {
                textBox_total.Text = "S " + itemPrice;
            }

        }
    }
}
