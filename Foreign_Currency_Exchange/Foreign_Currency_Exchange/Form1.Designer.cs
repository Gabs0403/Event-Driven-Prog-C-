namespace Foreign_Currency_Exchange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDollars = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtExchangeValue = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPoor = new System.Windows.Forms.RadioButton();
            this.radModerate = new System.Windows.Forms.RadioButton();
            this.radGood = new System.Windows.Forms.RadioButton();
            this.nudExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollars:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exchange Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exchange Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Commission";
            // 
            // txtDollars
            // 
            this.txtDollars.Location = new System.Drawing.Point(136, 45);
            this.txtDollars.Name = "txtDollars";
            this.txtDollars.Size = new System.Drawing.Size(80, 20);
            this.txtDollars.TabIndex = 0;
            this.txtDollars.Text = "$0.00";
            this.txtDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDollars.TextChanged += new System.EventHandler(this.txtDollars_TextChanged);
            this.txtDollars.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDollars_KeyPress);
            this.txtDollars.Leave += new System.EventHandler(this.txtDollars_Leave);
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(179, 265);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.ReadOnly = true;
            this.txtCommission.Size = new System.Drawing.Size(92, 20);
            this.txtCommission.TabIndex = 6;
            this.txtCommission.TabStop = false;
            this.txtCommission.Text = "$0.00";
            this.txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExchangeValue
            // 
            this.txtExchangeValue.Location = new System.Drawing.Point(23, 265);
            this.txtExchangeValue.Name = "txtExchangeValue";
            this.txtExchangeValue.ReadOnly = true;
            this.txtExchangeValue.Size = new System.Drawing.Size(92, 20);
            this.txtExchangeValue.TabIndex = 7;
            this.txtExchangeValue.TabStop = false;
            this.txtExchangeValue.Text = "$0.00";
            this.txtExchangeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(108, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPoor);
            this.groupBox1.Controls.Add(this.radModerate);
            this.groupBox1.Controls.Add(this.radGood);
            this.groupBox1.Location = new System.Drawing.Point(179, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency Stability";
            // 
            // radPoor
            // 
            this.radPoor.AutoSize = true;
            this.radPoor.Location = new System.Drawing.Point(12, 73);
            this.radPoor.Name = "radPoor";
            this.radPoor.Size = new System.Drawing.Size(47, 17);
            this.radPoor.TabIndex = 2;
            this.radPoor.Text = "Poor";
            this.radPoor.UseVisualStyleBackColor = true;
            this.radPoor.CheckedChanged += new System.EventHandler(this.radPoor_CheckedChanged);
            // 
            // radModerate
            // 
            this.radModerate.AutoSize = true;
            this.radModerate.Location = new System.Drawing.Point(12, 50);
            this.radModerate.Name = "radModerate";
            this.radModerate.Size = new System.Drawing.Size(70, 17);
            this.radModerate.TabIndex = 1;
            this.radModerate.Text = "Moderate";
            this.radModerate.UseVisualStyleBackColor = true;
            this.radModerate.CheckedChanged += new System.EventHandler(this.radModerate_CheckedChanged);
            // 
            // radGood
            // 
            this.radGood.AutoSize = true;
            this.radGood.Checked = true;
            this.radGood.Location = new System.Drawing.Point(12, 27);
            this.radGood.Name = "radGood";
            this.radGood.Size = new System.Drawing.Size(51, 17);
            this.radGood.TabIndex = 0;
            this.radGood.TabStop = true;
            this.radGood.Text = "Good";
            this.radGood.UseVisualStyleBackColor = true;
            this.radGood.CheckedChanged += new System.EventHandler(this.radGood_CheckedChanged);
            // 
            // nudExchangeRate
            // 
            this.nudExchangeRate.DecimalPlaces = 2;
            this.nudExchangeRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudExchangeRate.Location = new System.Drawing.Point(28, 156);
            this.nudExchangeRate.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.nudExchangeRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudExchangeRate.Name = "nudExchangeRate";
            this.nudExchangeRate.Size = new System.Drawing.Size(75, 20);
            this.nudExchangeRate.TabIndex = 1;
            this.nudExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudExchangeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExchangeRate.ValueChanged += new System.EventHandler(this.nudExchangeRate_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 370);
            this.Controls.Add(this.nudExchangeRate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtExchangeValue);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtDollars);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foreign Currency Exchange";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDollars;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtExchangeValue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPoor;
        private System.Windows.Forms.RadioButton radModerate;
        private System.Windows.Forms.RadioButton radGood;
        private System.Windows.Forms.NumericUpDown nudExchangeRate;
    }
}

