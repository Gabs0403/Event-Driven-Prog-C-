namespace SimpleCalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            txtResult = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            brnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnRemainder = new Button();
            cbMult = new CheckBox();
            cbDiv = new CheckBox();
            groupBox1 = new GroupBox();
            rbHide = new RadioButton();
            rbShow = new RadioButton();
            btnFunc1 = new Button();
            btnFunc2 = new Button();
            brnFunc3 = new Button();
            button9 = new Button();
            button10 = new Button();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 38);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "First Operand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 38);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Second Operand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 38);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 38);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Calculation Histoy";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(39, 61);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 4;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(208, 61);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(125, 27);
            txtSecond.TabIndex = 5;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(405, 61);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(350, 50);
            label5.Name = "label5";
            label5.Size = new Size(36, 38);
            label5.TabIndex = 7;
            label5.Text = "=";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnAdd.ImageAlign = ContentAlignment.TopLeft;
            btnAdd.Location = new Point(139, 127);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // brnSub
            // 
            brnSub.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            brnSub.Location = new Point(139, 162);
            brnSub.Name = "brnSub";
            brnSub.Size = new Size(94, 29);
            brnSub.TabIndex = 9;
            brnSub.Text = "-";
            brnSub.UseVisualStyleBackColor = true;
            brnSub.Click += brnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnMult.Location = new Point(139, 197);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(94, 29);
            btnMult.TabIndex = 10;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnDiv.Location = new Point(139, 232);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 29);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnRemainder
            // 
            btnRemainder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnRemainder.Location = new Point(139, 267);
            btnRemainder.Name = "btnRemainder";
            btnRemainder.Size = new Size(94, 29);
            btnRemainder.TabIndex = 12;
            btnRemainder.Text = "%";
            btnRemainder.UseVisualStyleBackColor = true;
            btnRemainder.Click += btnRemainder_Click;
            // 
            // cbMult
            // 
            cbMult.AutoSize = true;
            cbMult.Checked = true;
            cbMult.CheckState = CheckState.Checked;
            cbMult.Location = new Point(12, 197);
            cbMult.Name = "cbMult";
            cbMult.Size = new Size(125, 24);
            cbMult.TabIndex = 13;
            cbMult.Text = "Show * Button";
            cbMult.UseVisualStyleBackColor = true;
            cbMult.CheckedChanged += cbMult_CheckedChanged;
            // 
            // cbDiv
            // 
            cbDiv.AutoSize = true;
            cbDiv.Checked = true;
            cbDiv.CheckState = CheckState.Checked;
            cbDiv.Location = new Point(12, 232);
            cbDiv.Name = "cbDiv";
            cbDiv.Size = new Size(125, 24);
            cbDiv.TabIndex = 14;
            cbDiv.Text = "Show / Button";
            cbDiv.UseVisualStyleBackColor = true;
            cbDiv.CheckedChanged += cbDiv_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbHide);
            groupBox1.Controls.Add(rbShow);
            groupBox1.Location = new Point(12, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(137, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Module Button";
            // 
            // rbHide
            // 
            rbHide.AutoSize = true;
            rbHide.Location = new Point(6, 56);
            rbHide.Name = "rbHide";
            rbHide.Size = new Size(114, 24);
            rbHide.TabIndex = 1;
            rbHide.Text = "Hide % Hide";
            rbHide.UseVisualStyleBackColor = true;
            // 
            // rbShow
            // 
            rbShow.AutoSize = true;
            rbShow.Checked = true;
            rbShow.Location = new Point(6, 26);
            rbShow.Name = "rbShow";
            rbShow.Size = new Size(130, 24);
            rbShow.TabIndex = 0;
            rbShow.TabStop = true;
            rbShow.Text = "Show % Button";
            rbShow.UseVisualStyleBackColor = true;
            rbShow.CheckedChanged += rbShow_CheckedChanged;
            // 
            // btnFunc1
            // 
            btnFunc1.Location = new Point(381, 111);
            btnFunc1.Name = "btnFunc1";
            btnFunc1.Size = new Size(149, 64);
            btnFunc1.TabIndex = 16;
            btnFunc1.Text = "Move result to first operand";
            btnFunc1.UseVisualStyleBackColor = true;
            // 
            // btnFunc2
            // 
            btnFunc2.Location = new Point(381, 181);
            btnFunc2.Name = "btnFunc2";
            btnFunc2.Size = new Size(149, 50);
            btnFunc2.TabIndex = 17;
            btnFunc2.Text = "Clear all calculation field";
            btnFunc2.UseVisualStyleBackColor = true;
            // 
            // brnFunc3
            // 
            brnFunc3.Location = new Point(381, 237);
            brnFunc3.Name = "brnFunc3";
            brnFunc3.Size = new Size(149, 59);
            brnFunc3.TabIndex = 18;
            brnFunc3.Text = "Clear current Field";
            brnFunc3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(566, 339);
            button9.Name = "button9";
            button9.Size = new Size(222, 41);
            button9.TabIndex = 19;
            button9.Text = "Clear History";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(566, 386);
            button10.Name = "button10";
            button10.Size = new Size(222, 41);
            button10.TabIndex = 20;
            button10.Text = "Delete Selected Item";
            button10.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(566, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(222, 266);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(brnFunc3);
            Controls.Add(btnFunc2);
            Controls.Add(btnFunc1);
            Controls.Add(groupBox1);
            Controls.Add(cbDiv);
            Controls.Add(cbMult);
            Controls.Add(btnRemainder);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(brnSub);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(txtResult);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtResult;
        private Label label5;
        private Button btnAdd;
        private Button brnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnRemainder;
        private CheckBox cbMult;
        private CheckBox cbDiv;
        private GroupBox groupBox1;
        private RadioButton rbHide;
        private RadioButton rbShow;
        private Button btnFunc1;
        private Button btnFunc2;
        private Button brnFunc3;
        private Button button9;
        private Button button10;
        private ListView listView1;
    }
}
