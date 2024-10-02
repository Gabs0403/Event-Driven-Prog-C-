using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class MathGame : Form
    {
        int firstNumber, secondNumber, result, corrects = 0, incorrects = 0, difficulty;
        string[] operation = { "+", "-", "*", "/", "%" };
        Random random = new Random();


        public MathGame()
        {
            InitializeComponent();
        }
        public MathGame(int difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;



        }

        private void MathGame_Load(object sender, EventArgs e)
        {
            generateNewEquation(difficulty);
        }



        private void calculateResult(string operation)
        {
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber; break;
                case "-":
                    result = firstNumber - secondNumber; break;
                case "*":
                    result = firstNumber * secondNumber; break;
                case "/":
                    result = firstNumber / secondNumber; break;
                case "%":
                    result = firstNumber % secondNumber; break;

            }

        }

        private void generateNewEquation(int difficulty)
        {
            switch (difficulty)
            {
                case 1:
                    firstNumber = random.Next(10, 50);
                    secondNumber = random.Next(1, 10);
                    break;
                case 2:
                    firstNumber = random.Next(100, 500);
                    secondNumber = random.Next(50, 100);
                    break;
                case 3:
                    firstNumber = random.Next(500, 1000);
                    secondNumber = random.Next(100, 500);
                    break;
            }


            string calculation = operation[random.Next(operation.Length)];

            calculateResult(calculation);
            label3.Text = firstNumber.ToString();
            label5.Text = secondNumber.ToString();
            label4.Text = calculation;

        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int answer))
            {
                if (answer == result)
                {
                    corrects++;
                    label1.Text = "Correct: " + corrects.ToString();
                    label8.Text = "Correct!";
                    label8.ForeColor = Color.Green;
                    label8.Visible = true;
                    textBox1.Clear();

                    generateNewEquation(difficulty);
                }
                else
                {
                    corrects = 0;
                    incorrects++;
                    label2.Text = "Incorrect: " + incorrects.ToString();
                    label8.Text = "Incorrect!";
                    label8.ForeColor = Color.Red;
                    label8.Visible = true;
                    textBox1.Clear();

                }
            }
            else
            {
                corrects = 0;
                incorrects++;
                label2.Text = "Incorrect: " + incorrects.ToString();
                label8.Text = "Incorrect!";
                
                label8.ForeColor = Color.Red;
                label8.Visible = true;
                textBox1.Clear();
            }


            
            if(corrects == 3)
            {
                MessageBox.Show("You have won the game!");
                this.Close();
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCheck_Click(sender, e);
            }
            isDigit(e);
        }

        private void isDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox1.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
