using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckShow.Checked;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(ValidatePassword(txtPassword.Text) && !string.IsNullOrEmpty(txtName.Text) && (mskSSN.Text.Length == 11))
            {
                MessageBox.Show("Success signing up!","Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("One or more credentials are wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private bool HasAtLeastTwoLetters(string password)
        {
            return password.Count(char.IsLetter) >= 2;
        }

        private bool HasMaximumLength(string password)
        {
            return password.Length <= 20;
        }

        private bool HasNumber(string password)
        {
            return password.Any(char.IsDigit);
        }

        private bool HasSpecialCharacter(string password)
        {
            return password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private bool HasUppercaseLetter(string password)
        {
            return password.Any(char.IsUpper);
        }

        private bool HasMinimumLength(string password)
        {
            return password.Length >= 10;
        }

        private bool ValidatePassword(string password)
        {
            return HasMinimumLength(password) &&
                   HasUppercaseLetter(password) &&
                   HasSpecialCharacter(password) &&
                   HasAtLeastTwoLetters(password) &&
                   HasNumber(password) &&
                   HasMaximumLength(password);
        }

        private void ckShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) ckShow.Checked = !ckShow.Checked;  
        }
    }
}
