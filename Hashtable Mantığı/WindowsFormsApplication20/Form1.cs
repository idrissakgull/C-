using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable deneme = new Hashtable();
            deneme.Add("Kalem", "Pencil");//Nesne ismi ve kendisi. Burada nesneye eleman eklenmiş. Birinci yöntem
            deneme.Add("Sıra", "Desk");//Nesne ismi ve kendisi. Burada nesneye eleman eklenmiş. Birinci yöntem
            deneme["defter"] = "Notebook";//Nesne ismi ve kendisi. Burada nesneye eleman eklenmiş. İkinci yöntem.
            deneme["Sözlük"] = "Dictionary"; //Nesne ismi ve kendisi. Burada nesneye eleman eklenmiş İkinci yöntem.
            ICollection anahtarlar = deneme.Keys;//ICollection türünde anahtar isimli değişken tanımlanmış ve buna deneme değişkeninin key özellikleri atanmış.
            foreach (string s in anahtarlar)//Ekranda önce anaktar isimleri görüntülenecek.
                listBox1.Items.Add(s);
            ICollection degerler = deneme.Values;//ICollection türünde değerler isimli değişken tanımlanmış ve buna deneme değişkeninin key özellikleri atanmış.
            foreach (string s in degerler)//Ekranda daha sonra değer elemanlarının isimleri görüntülenecek.
                listBox1.Items.Add(s);
            listBox1.Items.Add("Toplam kelime: " + deneme.Count);
        }
    }
}
