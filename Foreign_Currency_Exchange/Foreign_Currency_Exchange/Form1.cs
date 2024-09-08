using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Foreign_Currency_Exchange
{
    public partial class Form1 : Form
    {
        decimal gdecDollars;
        decimal gdecExchangeValue;
        decimal gdecStability;




        public Form1()
        {
            InitializeComponent();
        }


        private void txtDollars_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e);
            
        }

        private void txtDollars_TextChanged(object sender, EventArgs e)
        {
            


            if (string.IsNullOrEmpty(txtDollars.Text) || txtDollars.Text == "$" || txtDollars.Text == "$." || txtDollars.Text == ".")
            {
                gdecDollars = 0;
            }
            else
            {
                

                decimal textWithoutDollar = decimal.Parse(txtDollars.Text.Replace("$",""));


                gdecDollars = textWithoutDollar;
            }


            calcExchangeValue();
        }


        private void radGood_CheckedChanged(object sender, EventArgs e)
        {
            calcExchangeValue();
        }

        private void radModerate_CheckedChanged(object sender, EventArgs e)
        {
            calcExchangeValue();
        }

        private void radPoor_CheckedChanged(object sender, EventArgs e)
        {
            calcExchangeValue();
        }

        private void nudExchangeRate_ValueChanged(object sender, EventArgs e)
        {
            calcExchangeValue();
            
        }


        private void txtDollars_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDollars.Text) || txtDollars.Text == "$" || txtDollars.Text == "$." || txtDollars.Text == ".")
            {
                txtDollars.Text = "$0.00";
            }
            else
            {
                decimal textWithoutDollar = decimal.Parse(txtDollars.Text.Replace("$", ""));

                txtDollars.Text = '$' + textWithoutDollar.ToString("0.00");
            }

        }


        private void calcExchangeValue()
        {
            checkStability();
            gdecExchangeValue = Math.Round(gdecDollars * nudExchangeRate.Value, 2, MidpointRounding.AwayFromZero);
            txtExchangeValue.Text = gdecExchangeValue.ToString("c");
            calcCommission();
        }

        private void calcCommission()
        {
            txtCommission.Text = (gdecExchangeValue * gdecStability).ToString("c");
        }

        private void checkStability()
        {
            if (radGood.Checked)
            {
                gdecStability = 0.01M;

            }
            else
            {
                gdecStability = radModerate.Checked ? 0.02M : 0.03M;
            }


        }
        private void isDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtDollars.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDollars.Text = "$0.00";
            nudExchangeRate.Value = 1;
            radGood.Checked = true;
            radModerate.Checked = false;
            radPoor.Checked = false;
            txtDollars.Focus();
        }
    }
}
