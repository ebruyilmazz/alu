using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Toplama")
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 + sayi2;
                textBox3.Text = (Convert.ToString(sonuc));
            }
            else if (comboBox1.Text == "Çıkarma")
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 - sayi2;
                textBox3.Text = (Convert.ToString(sonuc));
            }
            else if (comboBox1.Text == "Bölme")
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 / sayi2;
                textBox3.Text = (Convert.ToString(sonuc));
            }
            else if (comboBox1.Text == "Çarpma")
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 * sayi2;
                textBox3.Text = (Convert.ToString(sonuc));
            }

            if (comboBox1.Text == "VE")
            {
                string binary = " ";
                string ikilik = " ";
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int toplam = sayi1 + sayi2;
                textBox3.Text = Convert.ToString(toplam);

                while (sayi1 != 0)
                {
                    int sonuc = sayi1 % 2;
                    sayi1 = sayi1 / 2;
                    ikilik = Convert.ToString(sonuc) + ikilik;

                }
                while (sayi2 != 0)
                {
                    int sonuc = sayi2 % 2;
                    sayi2 = sayi2 / 2;
                    binary = Convert.ToString(sonuc) + binary;
                }
                textBox4.Text = binary;
                textBox5.Text = ikilik;
                string degisken = " ";
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a & b;

                while (c != 0)
                {
                    int x = c % 2;
                    c = c / 2;
                    degisken = Convert.ToString(x) + degisken;

                }
                textBox6.Text = degisken;

            }

            if (comboBox1.Text == "VEYA")
            {
                string binary=" ";
                string ikilik = " ";
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int toplam = sayi1 + sayi2;
                textBox3.Text= Convert.ToString(toplam);

                while (sayi1 != 0)
                {
                    int sonuc = sayi1 % 2;
                    sayi1 = sayi1 / 2;
                    ikilik = Convert.ToString(sonuc) + ikilik;

                }
                while (sayi2 != 0)
                {
                    int sonuc = sayi2 % 2;
                    sayi2 = sayi2 / 2;
                    binary = Convert.ToString(sonuc) + binary;
                }
                textBox4.Text = binary;
                textBox5.Text = ikilik;
                string degisken = " ";
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a | b;

                while (c != 0)
                {
                    int x = c % 2;
                    c = c / 2;
                    degisken = Convert.ToString(x) + degisken;

                }
                textBox6.Text = degisken;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Toplama");
            comboBox1.Items.Add("Çıkarma");
            comboBox1.Items.Add("Bölme");
            comboBox1.Items.Add("Çarpma");
            comboBox1.Items.Add("VE");
            comboBox1.Items.Add("VEYA");

            comboBox2.Items.Add("VE");
            comboBox2.Items.Add("VEYA");
            comboBox2.Items.Add("XOR");
            comboBox2.Items.Add("XNOR");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "VEYA")
            {

                string birinci = Convert.ToString(textBox7.Text);
                string ikinci = Convert.ToString(textBox8.Text);


                string[] dizi = new string[birinci.Length];

                for (int i = 0; i < birinci.Length; i++)
                {
                    if (birinci[i] == '1' && ikinci[i] == '1')
                    {
                        dizi[i] = "1";
                    }
                    if (birinci[i] == '1' && ikinci[i] == '0')
                    {
                        dizi[i] = "1";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '0')
                    {
                        dizi[i] = "0";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '1')
                    {
                        dizi[i] = "1";
                    }

                }
                string cevap = "";

                for (int i = 0; i < birinci.Length; i++)
                {
                    cevap = cevap + dizi[i];
                }

                textBox9.Text = cevap;
            }

            else if (comboBox2.Text == "VE")
            {

                string birinci = Convert.ToString(textBox7.Text);
                string ikinci = Convert.ToString(textBox8.Text);


                string[] dizi = new string[birinci.Length];

                for (int i = 0; i < birinci.Length; i++)
                {
                    if (birinci[i] == '1' && ikinci[i] == '1')
                    {
                        dizi[i] = "1";
                    }
                    if (birinci[i] == '1' && ikinci[i] == '0')
                    {
                        dizi[i] = "0";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '0')
                    {
                        dizi[i] = "0";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '1')
                    {
                        dizi[i] = "0";
                    }

                }
                string cevap = "";

                for (int i = 0; i < birinci.Length; i++)
                {
                    cevap = cevap + dizi[i];
                }

                textBox9.Text = cevap;
            }

            else if (comboBox2.Text == "XNOR")
            {

                string birinci = Convert.ToString(textBox7.Text);
                string ikinci = Convert.ToString(textBox8.Text);


                string[] dizi = new string[birinci.Length];

                for (int i = 0; i < birinci.Length; i++)
                {
                    if (birinci[i] == '1' && ikinci[i] == '1')
                    {
                        dizi[i] = "1";
                    }
                    if (birinci[i] == '1' && ikinci[i] == '0')
                    {
                        dizi[i] = "0";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '0')
                    {
                        dizi[i] = "1";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '1')
                    {
                        dizi[i] = "0";
                    }

                }
                string cevap = "";

                for (int i = 0; i < birinci.Length; i++)
                {
                    cevap = cevap + dizi[i];
                }

                textBox9.Text = cevap;
            }

            else if (comboBox2.Text == "XOR")
            {

                string birinci = Convert.ToString(textBox7.Text);
                string ikinci = Convert.ToString(textBox8.Text);


                string[] dizi = new string[birinci.Length];

                for (int i = 0; i < birinci.Length; i++)
                {
                    if (birinci[i] == '1' && ikinci[i] == '1')
                    {
                        dizi[i] = "0";
                    }
                    if (birinci[i] == '1' && ikinci[i] == '0')
                    {
                        dizi[i] = "1";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '0')
                    {
                        dizi[i] = "0";
                    }
                    if (birinci[i] == '0' && ikinci[i] == '1')
                    {
                        dizi[i] = "1";
                    }

                }
                string cevap = "";

                for (int i = 0; i < birinci.Length; i++)
                {
                    cevap = cevap + dizi[i];
                }

                textBox9.Text = cevap;
            }
        }

   
    }

    
}
