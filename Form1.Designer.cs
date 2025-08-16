namespace PC_Optimizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            button13 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cal Sans SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(287, 24);
            label1.TabIndex = 0;
            label1.Text = "Salam, Optimizerə xoş gəlmisiz!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Cal Sans SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(358, 44);
            label2.TabIndex = 1;
            label2.Text = "Optimizer sizin sisteminizin daha sürətli işləməsi üçün müxtəlif ayarlar edərək sürətlənmnəsinə kömək edir.";
            // 
            // label5
            // 
            label5.Font = new Font("Cal Sans SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(427, 259);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 16;
            label5.Text = "versiya 0.2";
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.Location = new Point(626, 11);
            button13.Name = "button13";
            button13.Size = new Size(18, 18);
            button13.TabIndex = 17;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
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
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 128);
            panel1.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(109, 106);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 3;
            label4.Text = "RAM Ayarları";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(109, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(8, 0, 0, 0);
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(3, 106);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 1;
            label3.Text = "Plan Ayarları";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.images_removebg_preview;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(8, 0, 0, 0);
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button13);
            panel2.Location = new Point(-2, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 45);
            panel2.TabIndex = 20;
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
            // button1
            // 
            button1.Location = new Point(516, 254);
            button1.Name = "button1";
            button1.Size = new Size(129, 26);
            button1.TabIndex = 21;
            button1.Text = "Güncəlləmələri yoxla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(657, 290);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "PC Optimizer by ThByte";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Button button13;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
