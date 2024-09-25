namespace MathPuzzle
{
    public partial class Form1 : Form
    {

        int num1, num2, result, operation, userInput;
        char sinal;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defineEquation();
        }




        private void defineEquation()
        {
            num1 = random.Next(10, 20);
            num2 = random.Next(3, 10);
            operation = random.Next(5);

            switch (operation)
            {
                case 0:
                    lblResult.Text = (num1 + num2).ToString();
                    break;

                case 1:
                    lblResult.Text = (num1 - num2).ToString();
                    break;

                case 2:
                    lblResult.Text = (num1 / num2).ToString();
                    break;

                case 3:
                    lblResult.Text = (num1 * num2).ToString();
                    break;

                case 4:
                    lblResult.Text = (num1 % num2).ToString();
                    break;

            }



            lblFirst.Text = num1.ToString();
            lblSecond.Text = num2.ToString();
            label5.Text = "?";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.ToUpper(e.KeyChar) == (char)Keys.A)
            {
                label5.Text = "+";
                userInput = 0;
                if (userInput == operation)
                {
                    ShowPlayAgainDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect, try again ");
                    label5.Text = "?";

                }

            }
            else if (char.ToUpper(e.KeyChar) == (char)Keys.S)
            {
                label5.Text = "-";
                userInput = 1;
                if (userInput == operation)
                {
                    ShowPlayAgainDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect, try again ");
                    label5.Text = "?";

                }

            }
            else if (char.ToUpper(e.KeyChar) == (char)Keys.D)
            {
                label5.Text = "/";
                userInput = 2;
                if (userInput == operation)
                {
                    ShowPlayAgainDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect, try again ");
                    label5.Text = "?";

                }

            }
            else if (char.ToUpper(e.KeyChar) == (char)Keys.M)
            {
                label5.Text = "*";
                userInput = 3;
                if (userInput == operation)
                {
                    ShowPlayAgainDialog();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect, try again ");
                    label5.Text = "?";

                }


            }
            else if (char.ToUpper(e.KeyChar) == (char)Keys.R)
            {
                label5.Text = "%";
                userInput = 4;
                if (userInput == operation)
                {
                    ShowPlayAgainDialog();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect, try again ");
                    label5.Text = "?";

                }

            }

        }

        private void ShowPlayAgainDialog()
        {
            var result = MessageBox.Show("Correct! Do you want to play again?", "Play Again", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Generate a new equation
                defineEquation();
            }
            else if (result == DialogResult.No)
            {
                // Close the application
                Application.Exit();
            }
        }

    }
}
