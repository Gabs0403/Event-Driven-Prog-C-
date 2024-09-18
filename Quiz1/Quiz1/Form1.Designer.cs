using System.Drawing;
using System.Windows.Forms;

namespace Quiz1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPacific = new System.Windows.Forms.RadioButton();
            this.rbAsian = new System.Windows.Forms.RadioButton();
            this.rbLatino = new System.Windows.Forms.RadioButton();
            this.rbAmerican = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHumble = new System.Windows.Forms.CheckBox();
            this.cbResponsible = new System.Windows.Forms.CheckBox();
            this.cbHardWorking = new System.Windows.Forms.CheckBox();
            this.cbCompassionate = new System.Windows.Forms.CheckBox();
            this.cbHonest = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(118, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(334, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(334, 22);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // dpSex
            // 
            this.dpSex.FormattingEnabled = true;
            this.dpSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.dpSex.Location = new System.Drawing.Point(118, 112);
            this.dpSex.Name = "dpSex";
            this.dpSex.Size = new System.Drawing.Size(334, 24);
            this.dpSex.TabIndex = 4;
            this.dpSex.SelectedIndexChanged += new System.EventHandler(this.dpSex_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sex/Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(526, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(526, 76);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 25);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(526, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 25);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPacific);
            this.groupBox1.Controls.Add(this.rbAsian);
            this.groupBox1.Controls.Add(this.rbLatino);
            this.groupBox1.Controls.Add(this.rbAmerican);
            this.groupBox1.Controls.Add(this.rbBlack);
            this.groupBox1.Controls.Add(this.rbWhite);
            this.groupBox1.Location = new System.Drawing.Point(26, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 197);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Race and Ethnicity";
            // 
            // rbPacific
            // 
            this.rbPacific.AutoSize = true;
            this.rbPacific.Location = new System.Drawing.Point(22, 155);
            this.rbPacific.Name = "rbPacific";
            this.rbPacific.Size = new System.Drawing.Size(193, 20);
            this.rbPacific.TabIndex = 5;
            this.rbPacific.Text = "Pacific Islander or Hawaiian";
            this.rbPacific.UseVisualStyleBackColor = true;
            // 
            // rbAsian
            // 
            this.rbAsian.AutoSize = true;
            this.rbAsian.Location = new System.Drawing.Point(22, 128);
            this.rbAsian.Name = "rbAsian";
            this.rbAsian.Size = new System.Drawing.Size(62, 20);
            this.rbAsian.TabIndex = 4;
            this.rbAsian.Text = "Asian";
            this.rbAsian.UseVisualStyleBackColor = true;
            // 
            // rbLatino
            // 
            this.rbLatino.AutoSize = true;
            this.rbLatino.Location = new System.Drawing.Point(22, 101);
            this.rbLatino.Name = "rbLatino";
            this.rbLatino.Size = new System.Drawing.Size(135, 20);
            this.rbLatino.TabIndex = 3;
            this.rbLatino.Text = "Latino or Hispanic";
            this.rbLatino.UseVisualStyleBackColor = true;
            // 
            // rbAmerican
            // 
            this.rbAmerican.AutoSize = true;
            this.rbAmerican.Location = new System.Drawing.Point(22, 75);
            this.rbAmerican.Name = "rbAmerican";
            this.rbAmerican.Size = new System.Drawing.Size(226, 20);
            this.rbAmerican.TabIndex = 2;
            this.rbAmerican.Text = "American Indian or Alaska Native";
            this.rbAmerican.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(22, 48);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(181, 20);
            this.rbBlack.TabIndex = 1;
            this.rbBlack.Text = "Black or African American";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Checked = true;
            this.rbWhite.Location = new System.Drawing.Point(22, 21);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(144, 20);
            this.rbWhite.TabIndex = 0;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White or Caucasian";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 389);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 170);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHumble);
            this.groupBox2.Controls.Add(this.cbResponsible);
            this.groupBox2.Controls.Add(this.cbHardWorking);
            this.groupBox2.Controls.Add(this.cbCompassionate);
            this.groupBox2.Controls.Add(this.cbHonest);
            this.groupBox2.Location = new System.Drawing.Point(483, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 197);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character Traits";
            // 
            // cbHumble
            // 
            this.cbHumble.AutoSize = true;
            this.cbHumble.Location = new System.Drawing.Point(15, 129);
            this.cbHumble.Name = "cbHumble";
            this.cbHumble.Size = new System.Drawing.Size(76, 20);
            this.cbHumble.TabIndex = 4;
            this.cbHumble.Text = "Humble";
            this.cbHumble.UseVisualStyleBackColor = true;
            this.cbHumble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHumble_KeyPress);
            // 
            // cbResponsible
            // 
            this.cbResponsible.AutoSize = true;
            this.cbResponsible.Location = new System.Drawing.Point(15, 102);
            this.cbResponsible.Name = "cbResponsible";
            this.cbResponsible.Size = new System.Drawing.Size(106, 20);
            this.cbResponsible.TabIndex = 3;
            this.cbResponsible.Text = "Responsible";
            this.cbResponsible.UseVisualStyleBackColor = true;
            this.cbResponsible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbResponsible_KeyPress);
            // 
            // cbHardWorking
            // 
            this.cbHardWorking.AutoSize = true;
            this.cbHardWorking.Location = new System.Drawing.Point(15, 76);
            this.cbHardWorking.Name = "cbHardWorking";
            this.cbHardWorking.Size = new System.Drawing.Size(109, 20);
            this.cbHardWorking.TabIndex = 2;
            this.cbHardWorking.Text = "Hard-working";
            this.cbHardWorking.UseVisualStyleBackColor = true;
            this.cbHardWorking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHardWorking_KeyPress);
            // 
            // cbCompassionate
            // 
            this.cbCompassionate.AutoSize = true;
            this.cbCompassionate.Location = new System.Drawing.Point(15, 48);
            this.cbCompassionate.Name = "cbCompassionate";
            this.cbCompassionate.Size = new System.Drawing.Size(124, 20);
            this.cbCompassionate.TabIndex = 1;
            this.cbCompassionate.Text = "Compassionate";
            this.cbCompassionate.UseVisualStyleBackColor = true;
            this.cbCompassionate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCompassionate_KeyPress);
            // 
            // cbHonest
            // 
            this.cbHonest.AutoSize = true;
            this.cbHonest.Location = new System.Drawing.Point(15, 21);
            this.cbHonest.Name = "cbHonest";
            this.cbHonest.Size = new System.Drawing.Size(72, 20);
            this.cbHonest.TabIndex = 0;
            this.cbHonest.Text = "Honest";
            this.cbHonest.UseVisualStyleBackColor = true;
            this.cbHonest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHonest_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private ComboBox dpSex;
        private Label label3;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnReset;
        private GroupBox groupBox1;
        private ListView listView1;
        private GroupBox groupBox2;
        private RadioButton rbPacific;
        private RadioButton rbAsian;
        private RadioButton rbLatino;
        private RadioButton rbAmerican;
        private RadioButton rbBlack;
        private RadioButton rbWhite;
        private CheckBox cbHumble;
        private CheckBox cbResponsible;
        private CheckBox cbHardWorking;
        private CheckBox cbCompassionate;
        private CheckBox cbHonest;
    }
}

