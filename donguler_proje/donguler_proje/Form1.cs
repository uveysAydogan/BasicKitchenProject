namespace donguler_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                label1.BackColor = Color.Green;
                pictureBox1.Visible = true;
                MessageBox.Show("Un ve Yumurta Karýþtýrýldý!");
                timer2.Start();
            }
            if (sayac == 1)
            {
                label1.BackColor = Color.LightPink;
            }
            if (sayac == 2)
            {
                label1.BackColor = Color.White;
                sayac = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar2.Value += 10;
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label2.BackColor = Color.Green;
                pictureBox2.Visible = true;
                MessageBox.Show("Çýrpma Ýþlemi Bitti!");
                timer3.Start();
            }
            if (sayac == 1)
            {
                label2.BackColor = Color.LightPink;
            }
            if (sayac == 2)
            {
                label2.BackColor = Color.White;
                sayac = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar3.Value += 10;
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label3.BackColor = Color.Green;
                pictureBox3.Visible = true;
                MessageBox.Show("Malzemeler ekleniyor ve karýþtýrýlýyor!");
                timer4.Start();
            }
            if (sayac == 1)
            {
                label3.BackColor = Color.LightPink;
            }
            if (sayac == 2)
            {
                label3.BackColor = Color.White;
                sayac = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            progressBar4.Value += 1;
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.LightPink;
            }
            if (progressBar4.Value % 2 == 1)
            {
                label4.BackColor = Color.White;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                pictureBox4.Visible = true;
                MessageBox.Show("Pastamýz Hazýr Oldu :)");
            }

        }
    }
}