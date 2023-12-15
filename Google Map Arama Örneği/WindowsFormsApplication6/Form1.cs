using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Donustur()
        {
            textBox1.Text = textBox1.Text.Replace("ı", "i");
            textBox1.Text = textBox1.Text.Replace("ü", "u");
            textBox1.Text = textBox1.Text.Replace("ğ", "g");
            textBox1.Text = textBox1.Text.Replace("İ", "I");
            textBox1.Text = textBox1.Text.Replace("Ğ", "G");
            textBox1.Text = textBox1.Text.Replace("Ü", "U");
            textBox1.Text = textBox1.Text.Replace("Ç", "C");
            textBox1.Text = textBox1.Text.Replace("ç", "c");
            textBox1.Text = textBox1.Text.Replace("ö", "o");
            textBox1.Text = textBox1.Text.Replace("Ö", "O");
            textBox1.Text = textBox1.Text.Replace("Ş", "S");
            textBox1.Text = textBox1.Text.Replace("ş", "s");

            textBox2.Text = textBox2.Text.Replace("ı", "i");
            textBox2.Text = textBox2.Text.Replace("ü", "u");
            textBox2.Text = textBox2.Text.Replace("ğ", "g");
            textBox2.Text = textBox2.Text.Replace("İ", "I");
            textBox2.Text = textBox2.Text.Replace("Ğ", "G");
            textBox2.Text = textBox2.Text.Replace("Ü", "U");
            textBox2.Text = textBox2.Text.Replace("Ç", "C");
            textBox2.Text = textBox2.Text.Replace("ç", "c");
            textBox2.Text = textBox2.Text.Replace("ö", "o");
            textBox2.Text = textBox2.Text.Replace("Ö", "O");
            textBox2.Text = textBox2.Text.Replace("Ş", "S");
            textBox2.Text = textBox2.Text.Replace("ş", "s");

            textBox3.Text = textBox3.Text.Replace("ı", "i");
            textBox3.Text = textBox3.Text.Replace("ü", "u");
            textBox3.Text = textBox3.Text.Replace("ğ", "g");
            textBox3.Text = textBox3.Text.Replace("İ", "I");
            textBox3.Text = textBox3.Text.Replace("Ğ", "G");
            textBox3.Text = textBox3.Text.Replace("Ü", "U");
            textBox3.Text = textBox3.Text.Replace("Ç", "C");
            textBox3.Text = textBox3.Text.Replace("ç", "c");
            textBox3.Text = textBox3.Text.Replace("ö", "o");
            textBox3.Text = textBox3.Text.Replace("Ö", "O");
            textBox3.Text = textBox3.Text.Replace("Ş", "S");
            textBox3.Text = textBox3.Text.Replace("ş", "s");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Donustur();
            string sokak = textBox1.Text;
            string sehir = textBox2.Text;
            string ulke = textBox3.Text;
            string posta = textBox4.Text;
            try
            {
                StringBuilder adres = new StringBuilder();
                adres.Append("https://www.google.com/maps/place/");

                if (sokak != String.Empty)
                {
                    adres.Append(sokak + "," + "+");
                }
                if (sehir != String.Empty)
                {
                    adres.Append(sehir + "," + "+");
                }
                if (ulke != String.Empty)
                {
                    adres.Append(ulke + "," + "+");
                }
                if (posta != String.Empty)
                {
                    adres.Append(posta + "," + "+");
                }
                webBrowser1.Navigate(adres.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }
    }
}
