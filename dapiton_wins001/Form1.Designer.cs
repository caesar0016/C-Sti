namespace dapiton_wins001
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
            this.getTotalCourse = new System.Windows.Forms.TextBox();
            this.getPrice = new System.Windows.Forms.TextBox();
            this.getName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getTotalCourse
            // 
            this.getTotalCourse.Location = new System.Drawing.Point(309, 169);
            this.getTotalCourse.Multiline = true;
            this.getTotalCourse.Name = "getTotalCourse";
            this.getTotalCourse.Size = new System.Drawing.Size(185, 41);
            this.getTotalCourse.TabIndex = 1;
            // 
            // getPrice
            // 
            this.getPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPrice.Location = new System.Drawing.Point(309, 246);
            this.getPrice.Multiline = true;
            this.getPrice.Name = "getPrice";
            this.getPrice.Size = new System.Drawing.Size(185, 41);
            this.getPrice.TabIndex = 3;
            this.getPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // getName
            // 
            this.getName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getName.Location = new System.Drawing.Point(309, 89);
            this.getName.Multiline = true;
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(185, 38);
            this.getName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter price of the book:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Total  Enrolled Course";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Click to print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.getPrice);
            this.Controls.Add(this.getTotalCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox getTotalCourse;
        private TextBox getPrice;
        private TextBox getName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}