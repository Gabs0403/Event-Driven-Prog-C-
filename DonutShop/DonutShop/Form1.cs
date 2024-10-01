using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutShop
{
    public partial class Form1 : Form
    {
        decimal sDonutPrice, sDonutQTY, subTotal, sCoffeePrice;
        string sDonutName = string.Empty;
        string sCoffeeName = string.Empty;



        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkDonut();
            checkCoffee();


            bool donutExist = false, coffeeExist = false;
            ListViewItem liv = new ListViewItem();

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == sDonutName)
                {
                    int currentQTY = Convert.ToInt32(item.SubItems[1].Text);
                    int newQTY = currentQTY + (int)nupQTY.Value;
                    item.SubItems[1].Text = (newQTY.ToString());
                    item.SubItems[2].Text = (newQTY * sDonutPrice).ToString();

                    donutExist = true;
                    break;


                }



            }

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == sCoffeeName && ckCoffee.Checked)
                {
                    int currentQTY = Convert.ToInt32(item.SubItems[1].Text);
                    int newQTY = currentQTY + (int)nupQTY.Value;
                    item.SubItems[1].Text = (newQTY.ToString());
                    item.SubItems[2].Text = (newQTY * sCoffeePrice).ToString();

                    coffeeExist = true;
                    break;


                }
            }

            if (!donutExist)
            {

                liv.Text = sDonutName;
                liv.SubItems.Add(nupQTY.Value.ToString());
                liv.SubItems.Add((sDonutPrice * nupQTY.Value).ToString());
                listView1.Items.Add(liv);
                 
            }

            if (ckCoffee.Checked && !coffeeExist)
            {

                liv = new ListViewItem();
                liv.Text = sCoffeeName;
                liv.SubItems.Add(nupQTY.Value.ToString());
                liv.SubItems.Add((sCoffeePrice * nupQTY.Value).ToString());
                listView1.Items.Add(liv);
                
            }
            nupQTY.Value = 1;
            displayPrices();

        }

        private void ckCoffee_CheckedChanged(object sender, EventArgs e)
        {
            gpCoffee.Visible = ckCoffee.Checked;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("List is empty!");
            }

            else if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                listView1.Items[listView1.Items.Count - 1].Remove();

            }
            displayPrices();
        }

        private void checkDonut()
        {
            if (donut1.Checked)
            {
                sDonutName = donut1.Text;

                sDonutPrice = 1.35m;
            }
            else if (donut2.Checked)

            {
                sDonutName = donut2.Text;
                sDonutPrice = 1.45m;
            }
            else if (donut3.Checked)
            {
                sDonutName = donut3.Text;
                sDonutPrice = 1.75m;
            }
            else if (donut4.Checked)
            {
                sDonutName = donut4.Text;
                sDonutPrice = 1.90m;
            }
            else if (donut5.Checked)
            {
                sDonutName = donut5.Text;
                sDonutPrice = 2.55m;
            }
            else
            {
                sDonutName = donut6.Text;
                sDonutPrice = 1.50m;

            }



        }

        private void checkCoffee()
        {
            if (ckCoffee.Checked)
            {
                if (coffee1.Checked)
                {
                    sCoffeeName = coffee1.Text;
                    sCoffeePrice = 1.99m;
                }
                else if (coffee2.Checked)
                {
                    sCoffeeName = coffee2.Text;
                    sCoffeePrice = 2.49m;
                }
                else
                {
                    sCoffeeName = coffee3.Text;
                    sCoffeePrice = 3.49m;
                }
            }
        }

        private void txtTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtChangeDue.Focus();
            }
            isDigit(e);
        }

        private void txtTendered_TextChanged(object sender, EventArgs e)
        {

            displayPrices();
        }

        private void nuTax_ValueChanged(object sender, EventArgs e)
        {
            displayPrices();
        }

        private void displayPrices()
        {

            decimal price = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                price += Convert.ToDecimal(item.SubItems[2].Text.Replace("$", ""));
            }

            txtSubtotal.Text = price.ToString("c");
            decimal finalPrice = price + (price * (nuTax.Value / 100));
            txtTotal.Text = finalPrice.ToString("c");
            updateChangeDue();

        }

        private void updateChangeDue()
        {
            if (!string.IsNullOrEmpty(txtTendered.Text) && !string.IsNullOrEmpty(txtTotal.Text))
            {

                string tender = txtTendered.Text.Replace("$", "");
                string total = txtTotal.Text.Replace("$", "");


                decimal tenderedAmount = decimal.Parse(tender);
                decimal totalAmount = decimal.Parse(total);


                if (tenderedAmount < totalAmount)
                {
                    txtChangeDue.Text = "-" + (tenderedAmount - totalAmount).ToString("c");
                }
                else
                {
                    txtChangeDue.Text = (tenderedAmount - totalAmount).ToString("c");
                }

            }
        }

        private void isDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtTendered.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
