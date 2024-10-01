using System.Reflection.Emit;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMult_CheckedChanged(object sender, EventArgs e)
        {
            btnMult.Visible = cbMult.Checked ? true : false;
        }

        private void cbDiv_CheckedChanged(object sender, EventArgs e)
        {
            btnDiv.Visible = cbDiv.Checked ? true : false;

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
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirst.Text)
                && !string.IsNullOrEmpty(txtSecond.Text))
            {
                string result = (decimal.Parse(txtFirst.Text) / decimal.Parse(txtSecond.Text)).ToString();
                txtResult.Text = result;
                char operand = '/';
                ShowCalculation(operand, result);
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
        }





        private void ShowCalculation(char operand, string result)
        {

            string textToLiv = $"{txtFirst.Text} {operand} {txtSecond.Text} = {result}";


            ListViewItem liv = new ListViewItem();
            liv.Text = textToLiv;
            listView1.Items.Add(liv);

        }

        
    }
}
