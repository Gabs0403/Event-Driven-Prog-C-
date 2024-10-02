namespace Quiz2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpBoxDifficulties = new GroupBox();
            rbHard = new RadioButton();
            rbMedium = new RadioButton();
            rbEasy = new RadioButton();
            btnPlay = new Button();
            btnClose = new Button();
            gpBoxDifficulties.SuspendLayout();
            SuspendLayout();
            // 
            // gpBoxDifficulties
            // 
            gpBoxDifficulties.Controls.Add(rbHard);
            gpBoxDifficulties.Controls.Add(rbMedium);
            gpBoxDifficulties.Controls.Add(rbEasy);
            gpBoxDifficulties.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            gpBoxDifficulties.Location = new Point(35, 55);
            gpBoxDifficulties.Name = "gpBoxDifficulties";
            gpBoxDifficulties.Size = new Size(205, 198);
            gpBoxDifficulties.TabIndex = 0;
            gpBoxDifficulties.TabStop = false;
            gpBoxDifficulties.Text = "Difficulty";
            gpBoxDifficulties.Enter += gpBoxDifficulties_Enter;
            // 
            // rbHard
            // 
            rbHard.AutoSize = true;
            rbHard.Location = new Point(28, 141);
            rbHard.Name = "rbHard";
            rbHard.Size = new Size(56, 21);
            rbHard.TabIndex = 2;
            rbHard.Text = "Hard";
            rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(28, 92);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(77, 21);
            rbMedium.TabIndex = 1;
            rbMedium.Text = "Medium";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            rbEasy.AutoSize = true;
            rbEasy.Location = new Point(28, 46);
            rbEasy.Name = "rbEasy";
            rbEasy.Size = new Size(53, 21);
            rbEasy.TabIndex = 0;
            rbEasy.Text = "Easy";
            rbEasy.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            btnPlay.Enabled = false;
            btnPlay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPlay.Location = new Point(284, 64);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(116, 90);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClose.Location = new Point(284, 160);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 90);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 346);
            Controls.Add(btnClose);
            Controls.Add(btnPlay);
            Controls.Add(gpBoxDifficulties);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            gpBoxDifficulties.ResumeLayout(false);
            gpBoxDifficulties.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpBoxDifficulties;
        private RadioButton rbHard;
        private RadioButton rbMedium;
        private RadioButton rbEasy;
        private Button btnPlay;
        private Button btnClose;
    }
}
