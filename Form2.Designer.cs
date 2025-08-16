namespace PC_Optimizer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            button13 = new Button();
            button2 = new Button();
            label5 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button13);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 45);
            panel2.TabIndex = 25;
            panel2.MouseDown += panel2_MouseDown_1;
            panel2.MouseMove += panel2_MouseMove_1;
            panel2.MouseUp += panel2_MouseUp_1;
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
            button13.Location = new Point(344, 12);
            button13.Name = "button13";
            button13.Size = new Size(18, 18);
            button13.TabIndex = 17;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(16, 12);
            button2.Name = "button2";
            button2.Size = new Size(153, 23);
            button2.TabIndex = 3;
            button2.Text = "Plan - Ultra Performance";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.Font = new Font("Cal Sans SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(291, 176);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 23;
            label5.Text = "versiya 0.2";
            // 
            // button1
            // 
            button1.Location = new Point(175, 12);
            button1.Name = "button1";
            button1.Size = new Size(153, 23);
            button1.TabIndex = 2;
            button1.Text = "Plan - High Performance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.Font = new Font("Cal Sans SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(358, 44);
            label2.TabIndex = 22;
            label2.Text = "Bu ayar sənin sisteminin güc istifadəsini artırıb vəya azaldaraq fps və performansda artış qazandırır";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cal Sans SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(16, 51);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(119, 24);
            label1.TabIndex = 21;
            label1.Text = "Plan Ayarları";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 49);
            panel1.TabIndex = 24;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 205);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Optimizer - Plan Ayarları";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Button button13;
        private Button button2;
        private Label label5;
        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}