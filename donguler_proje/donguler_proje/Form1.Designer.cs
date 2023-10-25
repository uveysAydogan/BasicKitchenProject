namespace donguler_proje
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(962, 28);
            label1.Name = "label1";
            label1.Size = new Size(342, 26);
            label1.TabIndex = 0;
            label1.Text = "Un ve Yumurta Karıştırılıyor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(962, 138);
            label2.Name = "label2";
            label2.Size = new Size(289, 26);
            label2.TabIndex = 1;
            label2.Text = "Çırpma Islemi Yapılıyor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(962, 246);
            label3.Name = "label3";
            label3.Size = new Size(450, 26);
            label3.TabIndex = 2;
            label3.Text = "Malzemeler Ekleniyor ve Karıstırılyor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(962, 356);
            label4.Name = "label4";
            label4.Size = new Size(195, 26);
            label4.TabIndex = 3;
            label4.Text = "Pasta Pisiriliyor";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(962, 57);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(437, 45);
            progressBar1.TabIndex = 4;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(962, 167);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(437, 45);
            progressBar2.TabIndex = 5;
//            progressBar2.Click += progressBar2_Click;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(962, 275);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(437, 45);
            progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(962, 385);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(437, 45);
            progressBar4.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1310, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1257, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1418, 238);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1163, 348);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Felix Titling", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 20);
            label5.Name = "label5";
            label5.Size = new Size(578, 93);
            label5.TabIndex = 12;
            label5.Text = "Uveys's Fırın";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Felix Titling", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 94);
            label6.Name = "label6";
            label6.Size = new Size(434, 43);
            label6.TabIndex = 13;
            label6.Text = "Mutfak Yazılımları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1471, 680);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
    }
}