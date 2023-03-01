namespace _1Kelime1İşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random rastgele = new Random();
        int harfsayac = 0;
        int sayisayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            harfsayac++;
            string k1, k2, k3, k4, k5, k6, k7, k8;
            int harfler;
            string[] dizi = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            if (harfsayac == 1 )
            {
                harfler = rastgele.Next(0, dizi.Length);
                k1 = (dizi[harfler]);
                label1.Text = k1.ToString();
                label1.Visible = true;
            }
            else if (harfsayac == 2 )
            {
                harfler = rastgele.Next(0, dizi.Length);
                k2 = (dizi[harfler]);
                label2.Text = k2.ToString();
                label2.Visible = true;
            }
            else if (harfsayac == 3)
            {
                harfler = rastgele.Next(0, dizi.Length);
                k3 = (dizi[harfler]);
                label3.Text = k3.ToString();
                label3.Visible = true;
            }
            else if (harfsayac == 4)
            {
                harfler = rastgele.Next(0, dizi.Length);
                k4 = (dizi[harfler]);
                label4.Text = k4.ToString();
                label4.Visible = true;
            }
            else if (harfsayac == 5)
            {
                harfler = rastgele.Next(0, dizi.Length);
                k5 = (dizi[harfler]);
                label5.Text = k5.ToString();
                label5.Visible = true;
            }
            else if (harfsayac == 6)
            {
                harfler = rastgele.Next(0, dizi.Length);
                k6 = (dizi[harfler]);
                label6.Text = k6.ToString();
                label6.Visible = true;
            }
            else if (harfsayac == 7)
            {
                harfler = rastgele.Next(0, dizi.Length);
                k7 = (dizi[harfler]);
                label7.Text = k7.ToString();
                label7.Visible = true;
            }
            else if (harfsayac == 8)
            {
                harfler = rastgele.Next(0, dizi.Length);
                k8 = (dizi[harfler]);
                label8.Text = k8.ToString();
                label8.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "_";
            label1.Visible = true;
            label2.Text = "_";
            label2.Visible = true;
            label3.Text = "_";
            label3.Visible = true;
            label4.Text = "_";
            label4.Visible = true;
            label5.Text = "_";
            label5.Visible = true;
            label6.Text = "_";
            label6.Visible = true;
            label7.Text = "_";
            label7.Visible = true;
            label8.Text = "_";
            label8.Visible = true;
            label10.Text = "_";
            label11.Text = "_";
            label12.Text = "_";
            label13.Text = "_";
            label14.Text = "_";
            label15.Text = "_";
            label16.Text = "_";
            label17.Text = "_";
            label18.Text = "_";
            label18.Visible = true;
            label19.Text = "_";
            label19.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayisayac++;
            string s1, s2, s3, s4, s5, s6, s7, s8;
            string s9,s10, s11;
            int sayilar;
            int sayilar2;
            string[] dizi = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi2 = {"50","75","80"};
            
            if (sayisayac == 1)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s1 = (dizi[sayilar]);
                label10.Text = s1.ToString();
                label10.Visible = true;
            }
            else if (sayisayac == 2)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s2 = (dizi[sayilar]);
                label11.Text = s2.ToString();
                label11.Visible = true;
            }
            else if (sayisayac == 3)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s3 = (dizi[sayilar]);
                label12.Text = s3.ToString();
                label12.Visible = true;
            }
            else if (sayisayac == 4)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s4 = (dizi[sayilar]);
                label13.Text = s4.ToString();
                label13.Visible = true;
            }
            else if (sayisayac == 5)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s5 = (dizi[sayilar]);
                label14.Text = s5.ToString();
                label14.Visible = true;
            }
            else if (sayisayac == 6)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s6 = (dizi[sayilar]);
                label15.Text = s6.ToString();
                label15.Visible = true;
            }
            else if (sayisayac == 7)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s7 = (dizi[sayilar]);
                label16.Text = s7.ToString();
                label16.Visible = true;
            }
            else if (sayisayac == 8)
            {
                sayilar = rastgele.Next(0, dizi.Length);
                s8 = (dizi[sayilar]);
                label17.Text = s8.ToString();
                label17.Visible = true;
            }
            else if (sayisayac == 9)
            {
                sayilar2 = rastgele.Next(0, dizi2.Length);
                s9 = (dizi2[sayilar2]);
                label18.Text = s9.ToString();
                label18.Visible = true;
            }
            else if (sayisayac == 10)
            {
                Random rnd = new Random();
                int RastgeleSayi1 = rnd.Next(100, 700);
                label19.Text = RastgeleSayi1.ToString();
            }
        }
    }
}