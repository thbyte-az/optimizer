namespace PC_Optimizer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            button13 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            button3 = new Button();
            button11 = new Button();
            button12 = new Button();
            button4 = new Button();
            button6 = new Button();
            button9 = new Button();
            button8 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Cal Sans SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(336, 264);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 23;
            label5.Text = "versiya 0.2";
            // 
            // label2
            // 
            label2.Font = new Font("Cal Sans SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(14, 74);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(395, 44);
            label2.TabIndex = 22;
            label2.Text = "Bu ayarlar sizin sisteminizdəki proses sayını RAM dəyərlərinizə uyğun olaraq azaldır.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cal Sans SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(14, 48);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(124, 24);
            label1.TabIndex = 21;
            label1.Text = "RAM Ayarları";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("8-bit Limit (BRK)", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(10, 7);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 18;
            label6.Text = "ThByte";
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.Location = new Point(401, 12);
            button13.Name = "button13";
            button13.Size = new Size(18, 18);
            button13.TabIndex = 17;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(4, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 139);
            panel1.TabIndex = 24;
            // 
            // button7
            // 
            button7.Location = new Point(171, 99);
            button7.Name = "button7";
            button7.Size = new Size(153, 23);
            button7.TabIndex = 30;
            button7.Text = "32 GB RAM";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(153, 23);
            button3.TabIndex = 26;
            button3.Text = "2 və daha az RAM";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button11
            // 
            button11.Location = new Point(330, 12);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 33;
            button11.Text = "64 GB RAM";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(171, 12);
            button12.Name = "button12";
            button12.Size = new Size(153, 23);
            button12.TabIndex = 34;
            button12.Text = "12 GB RAM";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button4
            // 
            button4.Location = new Point(171, 41);
            button4.Name = "button4";
            button4.Size = new Size(153, 23);
            button4.TabIndex = 27;
            button4.Text = "16 GB RAM";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 41);
            button6.Name = "button6";
            button6.Size = new Size(153, 23);
            button6.TabIndex = 29;
            button6.Text = "4GB RAM";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 99);
            button9.Name = "button9";
            button9.Size = new Size(153, 23);
            button9.TabIndex = 32;
            button9.Text = "8GB RAM";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 70);
            button8.Name = "button8";
            button8.Size = new Size(153, 23);
            button8.TabIndex = 31;
            button8.Text = "6GB RAM";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(171, 70);
            button5.Name = "button5";
            button5.Size = new Size(153, 23);
            button5.TabIndex = 28;
            button5.Text = "24 GB RAM";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button13);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 45);
            panel2.TabIndex = 25;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 26);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(41, 13);
            label7.TabIndex = 21;
            label7.Text = "Optimizer";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 294);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Optimizer - RAM Ayarları";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button button13;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Button button7;
        private Button button3;
        private Button button11;
        private Button button12;
        private Button button4;
        private Button button6;
        private Button button9;
        private Button button8;
        private Button button5;
    }
}