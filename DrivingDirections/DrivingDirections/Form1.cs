namespace DrivingDirections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible) {
                button1.Text = "Show Directions";
                textBox1.Visible = false;
            }
            else
            {
                button1.Text = "Hide Directions";
                textBox1.Visible= true;
            }            
        }
    }
}
