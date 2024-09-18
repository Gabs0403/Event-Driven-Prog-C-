using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz1
{
    public partial class Form1 : Form
    {
        string firstName, lastName, sex, race = string.Empty, characteristics = string.Empty;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkRace();
            checkCharacteristics();


            if(!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(sex))  
            { 
                ListViewItem liv = new ListViewItem();
                liv.Text = firstName + " " + lastName + " - " + sex + " - " + race + characteristics;

                listView1.Items.Add(liv.Text);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
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
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dpSex.Text = string.Empty;
            rbWhite.Checked = true;

            listView1.Clear();

            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Checked = false;
                }
            }

            txtFirstName.Focus();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtLastName.Focus();
            }
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dpSex.Focus();
            }
        }

        private void cbHonest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbHonest.Checked = !cbHonest.Checked;
            }
        }

        private void cbCompassionate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbCompassionate.Checked = !cbCompassionate.Checked;
            }
        }

        private void cbHardWorking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbHardWorking.Checked = !cbHardWorking.Checked;
            }
        }

        private void cbResponsible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbResponsible.Checked = !cbResponsible.Checked;
            }
        }

        private void cbHumble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cbHumble.Checked = !cbHumble.Checked;
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnRemove_Click(sender, e);
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lastName = txtLastName.Text;
        }

        private void dpSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            sex = dpSex.SelectedItem.ToString();
        }

        private void checkRace()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    race = radioButton.Text;
                }
            }
        }
        private void checkCharacteristics()
        {
            string selectedItems = string.Empty;

            foreach (Control control in groupBox2.Controls)
            {
                if(control is CheckBox checkBox && checkBox.Checked)
                {
                    selectedItems += checkBox.Text + ", ";
                }
            }
            if (selectedItems.Length > 0)
            {
                selectedItems = selectedItems.Remove(selectedItems.Length - 2);
            }

            characteristics = string.IsNullOrEmpty(selectedItems) ? string.Empty : $"( {selectedItems})";

        }
    }
}
