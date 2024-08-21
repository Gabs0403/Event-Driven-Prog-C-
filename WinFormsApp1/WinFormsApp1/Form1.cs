namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Function called when button btnShow is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            getData(); // get information from the textbox
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// Gets the data inserted into the textbox and displays it in a message window
        /// </summary>
        private void getData()
        {
            string data = textBox1.Text;
            if (!String.IsNullOrEmpty(data)) // checks if the data from the textbox is not empty or null
            {
                MessageBox.Show(data);
            }
            else
            {
                MessageBox.Show("Please enter some data!");
            }
        }


        /// <summary>
        /// event handler for when some key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> key pressed </param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) // 13 is the number that represents ENTER
            {
                getData() ;
            }
        }
    }
}
