using System.Diagnostics.Eventing.Reader;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal bookPrice, price, finalPrice;
        int quantity = 1, change = 0;
        string bookName;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkPrice();
            checkQuantity();
            checkName();



            if (bookPrice != 0 && bookName != null)
            {
                updateList();
                displayPrices();

                cmbBookName.Text = string.Empty;
                nudQTY.Value = 1;

            }

        }

        private void nuTax_ValueChanged(object sender, EventArgs e)
        {
            displayPrices();
        }




        private void renderPrice()
        {
            txtSubtotal.Text = (bookPrice * quantity).ToString("c");
        }

        private void checkPrice()
        {
            if (cmbBookName.SelectedIndex == 0)
            {
                bookPrice = 199;
            }
            else if (cmbBookName.SelectedIndex == 1)
            {
                bookPrice = 60;
            }
            else if (cmbBookName.SelectedIndex == 2)
            {
                bookPrice = 150;
            }

        }

        private void checkQuantity()
        {
            quantity = (int)nudQTY.Value;

        }

        private void checkName()
        {
            bookName = cmbBookName.Text.Split('(')[0].Trim();

        }

        private void updateList()
        {

            if (string.IsNullOrEmpty(bookName)) return;


            bool bookExists = false;
            ListViewItem liv = new ListViewItem();

            foreach (ListViewItem item in lstBook.Items)
            {
                if (item.Text == bookName)
                {
                    int currentQTY = Convert.ToInt32(item.SubItems[1].Text);
                    int newTQY = currentQTY + (int)nudQTY.Value;

                    item.SubItems[1].Text = newTQY.ToString();
                    item.SubItems[2].Text = (newTQY * bookPrice).ToString("c");

                    bookExists = true;
                    break;
                }
            }

            if (!bookExists)
            {
                liv.Text = bookName;
                liv.SubItems.Add(nudQTY.Value.ToString());
                liv.SubItems.Add((bookPrice * quantity).ToString("c"));
                lstBook.Items.Add(liv);
            }

        }

        private void displayPrices()
        {

            price = 0;
            foreach (ListViewItem item in lstBook.Items)
            {
                price += Convert.ToDecimal(item.SubItems[2].Text.Replace("$", ""));
            }

            txtSubtotal.Text = price.ToString("c");
            finalPrice = price + (price * (nuTax.Value / 100));
            txtTotal.Text = finalPrice.ToString("c");
            updateChangeDue();




        }


        private void txtTendered_TextChanged(object sender, EventArgs e)
        {

            displayPrices();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBook.Items.Count == 0)
            {
                MessageBox.Show("Nothing to erase");
            }

            else if (lstBook.SelectedItems.Count > 0)
            {
                lstBook.Items.Remove(lstBook.SelectedItems[0]);
            }
            else
            {
                lstBook.Items[lstBook.Items.Count - 1].Remove();

            }
            displayPrices();
        }

        private void brnReset_Click(object sender, EventArgs e)
        {
            cmbBookName.Text = "";
            price = 0;
            nudQTY.Value = 1;
            lstBook.Items.Clear();
            nuTax.Value = 7.25m;
            bookPrice = 0;
            bookName = "";
            txtTendered.Text = "$0.00";
            finalPrice = 0;
            displayPrices();
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

        private void txtTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtChangeDue.Focus();
            }
            isDigit(e);
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

        private void txtTendered_Leave(object sender, EventArgs e)
        {
            if (txtChangeDue.Text.Contains("-"))
            {
                MessageBox.Show("Tender amount needs to be higher than total amount!");
                txtTendered.Focus();    
            }
        }
    }
}