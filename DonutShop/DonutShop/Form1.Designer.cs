namespace DonutShop
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
            this.gpDonuts = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nuTax = new System.Windows.Forms.NumericUpDown();
            this.txtChangeDue = new System.Windows.Forms.TextBox();
            this.txtTendered = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.ckCoffee = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listQTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nupQTY = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gpCoffee = new System.Windows.Forms.GroupBox();
            this.coffee3 = new System.Windows.Forms.RadioButton();
            this.coffee1 = new System.Windows.Forms.RadioButton();
            this.coffee2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.donut6 = new System.Windows.Forms.RadioButton();
            this.donut5 = new System.Windows.Forms.RadioButton();
            this.donut4 = new System.Windows.Forms.RadioButton();
            this.donut3 = new System.Windows.Forms.RadioButton();
            this.donut2 = new System.Windows.Forms.RadioButton();
            this.donut1 = new System.Windows.Forms.RadioButton();
            this.gpDonuts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQTY)).BeginInit();
            this.gpCoffee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDonuts
            // 
            this.gpDonuts.Controls.Add(this.donut6);
            this.gpDonuts.Controls.Add(this.donut5);
            this.gpDonuts.Controls.Add(this.donut4);
            this.gpDonuts.Controls.Add(this.donut3);
            this.gpDonuts.Controls.Add(this.donut2);
            this.gpDonuts.Controls.Add(this.donut1);
            this.gpDonuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDonuts.Location = new System.Drawing.Point(23, 25);
            this.gpDonuts.Name = "gpDonuts";
            this.gpDonuts.Size = new System.Drawing.Size(367, 396);
            this.gpDonuts.TabIndex = 0;
            this.gpDonuts.TabStop = false;
            this.gpDonuts.Text = "Donuts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nuTax);
            this.groupBox2.Controls.Add(this.txtChangeDue);
            this.groupBox2.Controls.Add(this.txtTendered);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(425, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Change Due";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tendered";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tax(%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "SubTotal";
            // 
            // nuTax
            // 
            this.nuTax.DecimalPlaces = 2;
            this.nuTax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nuTax.Location = new System.Drawing.Point(244, 45);
            this.nuTax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuTax.Minimum = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            this.nuTax.Name = "nuTax";
            this.nuTax.Size = new System.Drawing.Size(103, 22);
            this.nuTax.TabIndex = 8;
            this.nuTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuTax.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            this.nuTax.ValueChanged += new System.EventHandler(this.nuTax_ValueChanged);
            // 
            // txtChangeDue
            // 
            this.txtChangeDue.Location = new System.Drawing.Point(244, 124);
            this.txtChangeDue.Name = "txtChangeDue";
            this.txtChangeDue.ReadOnly = true;
            this.txtChangeDue.Size = new System.Drawing.Size(103, 22);
            this.txtChangeDue.TabIndex = 3;
            this.txtChangeDue.Text = "$0";
            this.txtChangeDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTendered
            // 
            this.txtTendered.Location = new System.Drawing.Point(244, 98);
            this.txtTendered.Name = "txtTendered";
            this.txtTendered.Size = new System.Drawing.Size(103, 22);
            this.txtTendered.TabIndex = 2;
            this.txtTendered.Text = "$0";
            this.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTendered.TextChanged += new System.EventHandler(this.txtTendered_TextChanged);
            this.txtTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTendered_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(244, 72);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 22);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "$0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(244, 19);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(103, 22);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.Text = "$0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckCoffee
            // 
            this.ckCoffee.AutoSize = true;
            this.ckCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCoffee.Location = new System.Drawing.Point(14, 464);
            this.ckCoffee.Name = "ckCoffee";
            this.ckCoffee.Size = new System.Drawing.Size(119, 22);
            this.ckCoffee.TabIndex = 2;
            this.ckCoffee.Text = "Add Coffee?";
            this.ckCoffee.UseVisualStyleBackColor = true;
            this.ckCoffee.CheckedChanged += new System.EventHandler(this.ckCoffee_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listItem,
            this.listQTY,
            this.listPrice});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(426, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 280);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listItem
            // 
            this.listItem.Text = "Item";
            this.listItem.Width = 220;
            // 
            // listQTY
            // 
            this.listQTY.Text = "QTY";
            this.listQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listPrice
            // 
            this.listPrice.Text = "Price";
            this.listPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nupQTY
            // 
            this.nupQTY.Location = new System.Drawing.Point(425, 28);
            this.nupQTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQTY.Name = "nupQTY";
            this.nupQTY.Size = new System.Drawing.Size(79, 20);
            this.nupQTY.TabIndex = 4;
            this.nupQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(536, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 21);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(639, 27);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 21);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gpCoffee
            // 
            this.gpCoffee.Controls.Add(this.coffee3);
            this.gpCoffee.Controls.Add(this.coffee1);
            this.gpCoffee.Controls.Add(this.coffee2);
            this.gpCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCoffee.Location = new System.Drawing.Point(139, 438);
            this.gpCoffee.Name = "gpCoffee";
            this.gpCoffee.Size = new System.Drawing.Size(251, 138);
            this.gpCoffee.TabIndex = 7;
            this.gpCoffee.TabStop = false;
            this.gpCoffee.Text = "Coffees";
            this.gpCoffee.Visible = false;
            // 
            // coffee3
            // 
            this.coffee3.AutoSize = true;
            this.coffee3.Location = new System.Drawing.Point(20, 72);
            this.coffee3.Name = "coffee3";
            this.coffee3.Size = new System.Drawing.Size(148, 20);
            this.coffee3.TabIndex = 5;
            this.coffee3.TabStop = true;
            this.coffee3.Text = "Capuccino ($3.49)";
            this.coffee3.UseVisualStyleBackColor = true;
            // 
            // coffee1
            // 
            this.coffee1.AutoSize = true;
            this.coffee1.Checked = true;
            this.coffee1.Location = new System.Drawing.Point(20, 26);
            this.coffee1.Name = "coffee1";
            this.coffee1.Size = new System.Drawing.Size(179, 20);
            this.coffee1.TabIndex = 3;
            this.coffee1.TabStop = true;
            this.coffee1.Text = "Regular Coffee ($1.99)";
            this.coffee1.UseVisualStyleBackColor = true;
            // 
            // coffee2
            // 
            this.coffee2.AutoSize = true;
            this.coffee2.Location = new System.Drawing.Point(20, 49);
            this.coffee2.Name = "coffee2";
            this.coffee2.Size = new System.Drawing.Size(141, 20);
            this.coffee2.TabIndex = 4;
            this.coffee2.TabStop = true;
            this.coffee2.Text = "Espresso ($2.49)";
            this.coffee2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "QTY";
            // 
            // donut6
            // 
            this.donut6.AutoSize = true;
            this.donut6.Image = global::DonutShop.Properties.Resources.almond_optimized;
            this.donut6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donut6.Location = new System.Drawing.Point(197, 271);
            this.donut6.Name = "donut6";
            this.donut6.Size = new System.Drawing.Size(166, 95);
            this.donut6.TabIndex = 5;
            this.donut6.TabStop = true;
            this.donut6.Text = "Choc Almond ($1.90)";
            this.donut6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donut6.UseVisualStyleBackColor = true;
            // 
            // donut5
            // 
            this.donut5.AutoSize = true;
            this.donut5.Image = global::DonutShop.Properties.Resources.bendera_optimized;
            this.donut5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donut5.Location = new System.Drawing.Point(32, 271);
            this.donut5.Name = "donut5";
            this.donut5.Size = new System.Drawing.Size(134, 95);
            this.donut5.TabIndex = 4;
            this.donut5.TabStop = true;
            this.donut5.Text = "Bendera ($2.55)";
            this.donut5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donut5.UseVisualStyleBackColor = true;
            // 
            // donut4
            // 
            this.donut4.AutoSize = true;
            this.donut4.Image = global::DonutShop.Properties.Resources.chocolate_frosted_75x42;
            this.donut4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donut4.Location = new System.Drawing.Point(197, 172);
            this.donut4.Name = "donut4";
            this.donut4.Size = new System.Drawing.Size(149, 62);
            this.donut4.TabIndex = 3;
            this.donut4.TabStop = true;
            this.donut4.Text = "Choc Frost ($1.90)";
            this.donut4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donut4.UseVisualStyleBackColor = true;
            // 
            // donut3
            // 
            this.donut3.AutoSize = true;
            this.donut3.Image = global::DonutShop.Properties.Resources.black_forest_optimized;
            this.donut3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donut3.Location = new System.Drawing.Point(32, 141);
            this.donut3.Name = "donut3";
            this.donut3.Size = new System.Drawing.Size(162, 95);
            this.donut3.TabIndex = 2;
            this.donut3.TabStop = true;
            this.donut3.Text = "Black Forest ($1.75)";
            this.donut3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donut3.UseVisualStyleBackColor = true;
            // 
            // donut2
            // 
            this.donut2.AutoSize = true;
            this.donut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donut2.Image = global::DonutShop.Properties.Resources.sugar_raised_75x50;
            this.donut2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donut2.Location = new System.Drawing.Point(197, 65);
            this.donut2.Name = "donut2";
            this.donut2.Size = new System.Drawing.Size(170, 70);
            this.donut2.TabIndex = 1;
            this.donut2.TabStop = true;
            this.donut2.Text = "Sugar Raised ($1.45)";
            this.donut2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donut2.UseVisualStyleBackColor = true;
            // 
            // donut1
            // 
            this.donut1.AutoSize = true;
            this.donut1.Checked = true;
            this.donut1.Cursor = System.Windows.Forms.Cursors.Default;
            this.donut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donut1.Image = global::DonutShop.Properties.Resources.glazed_2_75x50;
            this.donut1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.donut1.Location = new System.Drawing.Point(32, 65);
            this.donut1.Name = "donut1";
            this.donut1.Size = new System.Drawing.Size(124, 70);
            this.donut1.TabIndex = 0;
            this.donut1.TabStop = true;
            this.donut1.Text = "Glazed ($1.35)";
            this.donut1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donut1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpCoffee);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nupQTY);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ckCoffee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpDonuts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donut Shop";
            this.gpDonuts.ResumeLayout(false);
            this.gpDonuts.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQTY)).EndInit();
            this.gpCoffee.ResumeLayout(false);
            this.gpCoffee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDonuts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckCoffee;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown nupQTY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RadioButton donut3;
        private System.Windows.Forms.RadioButton donut2;
        private System.Windows.Forms.RadioButton donut1;
        private System.Windows.Forms.NumericUpDown nuTax;
        private System.Windows.Forms.TextBox txtChangeDue;
        private System.Windows.Forms.TextBox txtTendered;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ColumnHeader listItem;
        private System.Windows.Forms.ColumnHeader listQTY;
        private System.Windows.Forms.ColumnHeader listPrice;
        private System.Windows.Forms.GroupBox gpCoffee;
        private System.Windows.Forms.RadioButton coffee3;
        private System.Windows.Forms.RadioButton coffee1;
        private System.Windows.Forms.RadioButton coffee2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton donut6;
        private System.Windows.Forms.RadioButton donut5;
        private System.Windows.Forms.RadioButton donut4;
    }
}

