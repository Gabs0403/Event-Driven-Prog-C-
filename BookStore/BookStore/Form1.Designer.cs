namespace BookStore
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
            cmbBookName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nudQTY = new NumericUpDown();
            label7 = new Label();
            txtSubtotal = new TextBox();
            txtChangeDue = new TextBox();
            txtTendered = new TextBox();
            txtTotal = new TextBox();
            lstBook = new ListView();
            nameColumn = new ColumnHeader();
            QTYcolumn = new ColumnHeader();
            priceColumn = new ColumnHeader();
            nuTax = new NumericUpDown();
            btnAdd = new Button();
            btnRemove = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQTY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuTax).BeginInit();
            SuspendLayout();
            // 
            // cmbBookName
            // 
            cmbBookName.FormattingEnabled = true;
            cmbBookName.Items.AddRange(new object[] { "Harry Potter ($199.00)", "Intro to C# ($60.00)", "Programming for Dummies ($150.00)" });
            cmbBookName.Location = new Point(106, 25);
            cmbBookName.Name = "cmbBookName";
            cmbBookName.Size = new Size(223, 23);
            cmbBookName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 402);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Tax(%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 374);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Subtotal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 490);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "Change Due";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 432);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 6;
            label6.Text = "Total";
            // 
            // nudQTY
            // 
            nudQTY.Location = new Point(106, 66);
            nudQTY.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQTY.Name = "nudQTY";
            nudQTY.Size = new Size(117, 23);
            nudQTY.TabIndex = 7;
            nudQTY.TextAlign = HorizontalAlignment.Right;
            nudQTY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 461);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 9;
            label7.Text = "Tendered";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(211, 366);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(118, 23);
            txtSubtotal.TabIndex = 10;
            txtSubtotal.Text = "$0.00";
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtChangeDue
            // 
            txtChangeDue.Location = new Point(213, 482);
            txtChangeDue.Name = "txtChangeDue";
            txtChangeDue.ReadOnly = true;
            txtChangeDue.Size = new Size(118, 23);
            txtChangeDue.TabIndex = 11;
            txtChangeDue.Text = "$0.00";
            txtChangeDue.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTendered
            // 
            txtTendered.Location = new Point(211, 453);
            txtTendered.Name = "txtTendered";
            txtTendered.Size = new Size(118, 23);
            txtTendered.TabIndex = 12;
            txtTendered.Text = "$0.00";
            txtTendered.TextAlign = HorizontalAlignment.Right;
            txtTendered.TextChanged += txtTendered_TextChanged;
            txtTendered.KeyPress += txtTendered_KeyPress;
            txtTendered.Leave += txtTendered_Leave;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(211, 424);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(118, 23);
            txtTotal.TabIndex = 13;
            txtTotal.Text = "$0.00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lstBook
            // 
            lstBook.Columns.AddRange(new ColumnHeader[] { nameColumn, QTYcolumn, priceColumn });
            lstBook.FullRowSelect = true;
            lstBook.Location = new Point(45, 148);
            lstBook.Name = "lstBook";
            lstBook.Size = new Size(284, 212);
            lstBook.TabIndex = 8;
            lstBook.UseCompatibleStateImageBehavior = false;
            lstBook.View = View.Details;
            // 
            // nameColumn
            // 
            nameColumn.Text = "Book Name";
            nameColumn.Width = 120;
            // 
            // QTYcolumn
            // 
            QTYcolumn.Text = "QTY";
            QTYcolumn.TextAlign = HorizontalAlignment.Center;
            // 
            // priceColumn
            // 
            priceColumn.Text = "Price";
            priceColumn.TextAlign = HorizontalAlignment.Right;
            priceColumn.Width = 80;
            // 
            // nuTax
            // 
            nuTax.DecimalPlaces = 2;
            nuTax.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            nuTax.Location = new Point(213, 395);
            nuTax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nuTax.Minimum = new decimal(new int[] { 725, 0, 0, 131072 });
            nuTax.Name = "nuTax";
            nuTax.Size = new Size(116, 23);
            nuTax.TabIndex = 14;
            nuTax.TextAlign = HorizontalAlignment.Right;
            nuTax.Value = new decimal(new int[] { 725, 0, 0, 131072 });
            nuTax.Click += nuTax_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(128, 102);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(197, 102);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(63, 29);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(266, 102);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(63, 29);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += brnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 523);
            Controls.Add(btnReset);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(nuTax);
            Controls.Add(txtTotal);
            Controls.Add(txtTendered);
            Controls.Add(txtChangeDue);
            Controls.Add(txtSubtotal);
            Controls.Add(label7);
            Controls.Add(lstBook);
            Controls.Add(nudQTY);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBookName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudQTY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuTax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBookName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudQTY;
        private Label label7;
        private TextBox txtSubtotal;
        private TextBox txtChangeDue;
        private TextBox txtTendered;
        private TextBox txtTotal;
        private ListView lstBook;
        private NumericUpDown nuTax;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnReset;
        private ColumnHeader nameColumn;
        private ColumnHeader QTYcolumn;
        private ColumnHeader priceColumn;
    }
}
