using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUŞLU_HESAP_MAKİNESİ
{
    public partial class Form1 : Form
    {

        private char _islem;
       private bool _temizlik;
        private int _ilksayi;

        private object ekranLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _temizlik = true;
            _ilksayi = Convert.ToInt32(label.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label.Text = "00.00";
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "2";
        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "3";
        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "4";
        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "5";
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "8";
        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_temizlik)
            {
                label.Text = "";
                _temizlik = false;
            }
            if (label.Text == "00.00") label.Text = "";
            label.Text += "0";
        }

        private void tuşartı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _temizlik = true;
            _ilksayi = Convert.ToInt32(label.Text);
        }

        private void tuşeşittir_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(label.Text);
            int sonuc;

            switch (_islem)
            {

                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                case 'x':
                    sonuc = _ilksayi * ikincisayi;
                
                    break;
                default:
                    sonuc = 0;
                    break;


            }
            label.Text = Convert.ToString(sonuc);
        }

        private void tuşeksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _temizlik = true;
            _ilksayi = Convert.ToInt32(label.Text);
        }

        private void tuşçarpı_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _temizlik = true;
            _ilksayi = Convert.ToInt32(label.Text);
        }
    }
}
