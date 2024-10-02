namespace Quiz2
{
    public partial class Form1 : Form
    {
        
        


        public Form1()
        {
            InitializeComponent();
        }

        private void gpBoxDifficulties_Enter(object sender, EventArgs e)
        {
            foreach (Control control in gpBoxDifficulties.Controls)
            {
                if (control is RadioButton radioButton && !radioButton.Checked)
                {
                    btnPlay.Enabled = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int difficulty = 0;
            if (rbEasy.Checked)
            {
                difficulty = 1;
            }
            else
            {
                difficulty = rbMedium.Checked ? 2 : 3;
                
            }

            MathGame mathGame = new MathGame(difficulty);
            mathGame.Show();

        }
    }
}
