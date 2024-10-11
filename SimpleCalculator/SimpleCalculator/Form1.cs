using System.Reflection.Emit;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private TextBox lastFocusedTextbox;



        public Form1()
        {
            InitializeComponent();
        }

        private void cbMult_CheckedChanged(object sender, EventArgs e)
        {
            btnMult.Visible = cbMult.Checked;
        }

        private void cbDiv_CheckedChanged(object sender, EventArgs e)
        {
            btnDiv.Visible = cbDiv.Checked;

        }

        private void rbShow_CheckedChanged(object sender, EventArgs e)
        {
            btnRemainder.Visible = rbShow.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirst.Text)
                && !string.IsNullOrEmpty(txtSecond.Text))
            {
                string result = (decimal.Parse(txtFirst.Text) + decimal.Parse(txtSecond.Text)).ToString();
                txtResult.Text = result;
                char operand = '+';

                ShowCalculation(operand, result);
            }
            else
            {
                MessageBox.Show("Please provide two operands!");
            }

        }
        private void brnSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirst.Text)
                && !string.IsNullOrEmpty(txtSecond.Text))
            {
                string result = (decimal.Parse(txtFirst.Text) - decimal.Parse(txtSecond.Text)).ToString();
                txtResult.Text = result;
                char operand = '-';

                ShowCalculation(operand, result);
            }
            else
            {
                MessageBox.Show("Please provide two operands!");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirst.Text)
                && !string.IsNullOrEmpty(txtSecond.Text))
            {
                string result = (decimal.Parse(txtFirst.Text) * decimal.Parse(txtSecond.Text)).ToString();
                txtResult.Text = result;
                char operand = '*';

                ShowCalculation(operand, result);
            }
            else
            {
                MessageBox.Show("Please provide two operands!");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirst.Text)
                && !string.IsNullOrEmpty(txtSecond.Text))
            {
                string result = Math.Round(decimal.Parse(txtFirst.Text) / decimal.Parse(txtSecond.Text), 2).ToString();
                txtResult.Text = result;
                char operand = '/';
                ShowCalculation(operand, result);
            }
            else
            {
                MessageBox.Show("Please provide two operands!");
            }
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirst.Text)
                && !string.IsNullOrEmpty(txtSecond.Text))
            {
                string result = (decimal.Parse(txtFirst.Text) % decimal.Parse(txtSecond.Text)).ToString();
                txtResult.Text = result;
                char operand = '%';


                ShowCalculation(operand, result);
            }
            else
            {
                MessageBox.Show("Please provide two operands!");
            }
        }


        private void ShowCalculation(char operand, string result)
        {

            string textToLiv = $"{txtFirst.Text} {operand} {txtSecond.Text} = {result}";


            ListViewItem liv = new ListViewItem();
            liv.Text = textToLiv;
            listView1.Items.Add(liv);

        }

        private void btnFunc1_Click(object sender, EventArgs e)
        {
            txtFirst.Text = txtResult.Text;
            txtResult.Text = string.Empty;
            txtSecond.Text = string.Empty;
            txtSecond.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Nothing to erase");
            }

            else if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to be removed!");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void btnFunc2_Click(object sender, EventArgs e)
        {
            txtFirst.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtSecond.Text = string.Empty;
            txtFirst.Focus();
        }

        private void txtFirst_Enter(object sender, EventArgs e)
        {
            lastFocusedTextbox = (TextBox)sender; // Store the last focused textbox
        }

        private void txtSecond_Enter(object sender, EventArgs e)
        {
            lastFocusedTextbox = (TextBox)sender; // Store the last focused textbox
        }

        private void brnFunc3_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextbox != null)
            {
                lastFocusedTextbox.Text = string.Empty;
            }
        }

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e,txtFirst);
        }

        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(e, txtSecond);
        }
        private void isDigit(KeyPressEventArgs e, TextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
