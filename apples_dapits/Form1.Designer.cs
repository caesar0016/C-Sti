namespace apples_dapits
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
            this.getQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.getPcs = new System.Windows.Forms.TextBox();
            this.getPrice = new System.Windows.Forms.TextBox();
            this.getDouble = new System.Windows.Forms.TextBox();
            this.getInt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getQty
            // 
            this.getQty.AutoSize = true;
            this.getQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getQty.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getQty.Location = new System.Drawing.Point(119, 66);
            this.getQty.Name = "getQty";
            this.getQty.Size = new System.Drawing.Size(98, 30);
            this.getQty.TabIndex = 0;
            this.getQty.Text = "Apple Pcs";
            this.getQty.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apple Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(116, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Price (Double)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Price (int)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(74, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(577, 160);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(74, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(577, 160);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // getPcs
            // 
            this.getPcs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.getPcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getPcs.Location = new System.Drawing.Point(332, 55);
            this.getPcs.Multiline = true;
            this.getPcs.Name = "getPcs";
            this.getPcs.Size = new System.Drawing.Size(232, 53);
            this.getPcs.TabIndex = 6;
            this.getPcs.TextChanged += new System.EventHandler(this.getPcs_TextChanged);
            // 
            // getPrice
            // 
            this.getPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.getPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getPrice.Location = new System.Drawing.Point(332, 123);
            this.getPrice.Multiline = true;
            this.getPrice.Name = "getPrice";
            this.getPrice.Size = new System.Drawing.Size(232, 53);
            this.getPrice.TabIndex = 9;
            // 
            // getDouble
            // 
            this.getDouble.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.getDouble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getDouble.Location = new System.Drawing.Point(332, 274);
            this.getDouble.Multiline = true;
            this.getDouble.Name = "getDouble";
            this.getDouble.Size = new System.Drawing.Size(232, 53);
            this.getDouble.TabIndex = 10;
            // 
            // getInt
            // 
            this.getInt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.getInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getInt.Location = new System.Drawing.Point(332, 344);
            this.getInt.Multiline = true;
            this.getInt.Name = "getInt";
            this.getInt.Size = new System.Drawing.Size(232, 53);
            this.getInt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(677, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getInt);
            this.Controls.Add(this.getDouble);
            this.Controls.Add(this.getPrice);
            this.Controls.Add(this.getPcs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getQty);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Apple Pcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label getQty;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox getPcs;
        private TextBox getPrice;
        private TextBox getDouble;
        private TextBox getInt;
        private Button button1;
    }
}