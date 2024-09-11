namespace SignUp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskSSN = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ckShow = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskSSN
            // 
            this.mskSSN.Location = new System.Drawing.Point(102, 98);
            this.mskSSN.Mask = "000-00-0000";
            this.mskSSN.Name = "mskSSN";
            this.mskSSN.Size = new System.Drawing.Size(152, 20);
            this.mskSSN.TabIndex = 1;
            this.mskSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            // 
            // ckShow
            // 
            this.ckShow.AutoSize = true;
            this.ckShow.Location = new System.Drawing.Point(102, 161);
            this.ckShow.Name = "ckShow";
            this.ckShow.Size = new System.Drawing.Size(102, 17);
            this.ckShow.TabIndex = 3;
            this.ckShow.Text = "Show Password";
            this.ckShow.UseVisualStyleBackColor = true;
            this.ckShow.CheckedChanged += new System.EventHandler(this.ckShow_CheckedChanged);
            this.ckShow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckShow_KeyPress);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(100, 196);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(151, 28);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.ckShow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mskSSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskSSN;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox ckShow;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

