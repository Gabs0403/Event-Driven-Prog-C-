namespace MathPuzzle
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
            lblFirst = new Label();
            lblSecond = new Label();
            label3 = new Label();
            lblResult = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirst.Location = new Point(65, 97);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(83, 32);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "label1";
            lblFirst.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecond.Location = new Point(196, 97);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(83, 32);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "label2";
            lblSecond.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 97);
            label3.Name = "label3";
            label3.Size = new Size(31, 32);
            label3.TabIndex = 2;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(347, 97);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(83, 32);
            lblResult.TabIndex = 3;
            lblResult.Text = "label4";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 97);
            label5.Name = "label5";
            label5.Size = new Size(25, 32);
            label5.TabIndex = 4;
            label5.Text = "?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(65, 250);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 5;
            label1.Text = "Press";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(65, 280);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 6;
            label2.Text = "A for '+'";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(65, 312);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 7;
            label4.Text = "S for '-'";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(65, 341);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 8;
            label6.Text = "M for '*'";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(65, 371);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 9;
            label7.Text = "D for '/'";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(65, 405);
            label8.Name = "label8";
            label8.Size = new Size(94, 28);
            label8.TabIndex = 10;
            label8.Text = "R for '%'";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 501);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(lblSecond);
            Controls.Add(lblFirst);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirst;
        private Label lblSecond;
        private Label label3;
        private Label lblResult;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
