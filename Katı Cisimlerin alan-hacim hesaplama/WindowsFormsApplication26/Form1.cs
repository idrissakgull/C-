using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using deneme_dll;

namespace WindowsFormsApplication26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Alan_hesabı alan = new Alan_hesabı();
        Hacim_hesabı hacim = new Hacim_hesabı();
        int a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            deger_atama();
            listBox1.Items.Add(alan.kare(a).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger_atama();
            listBox1.Items.Add(hacim.kup(a).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deger_atama();
            listBox1.Items.Add(alan.dikdortgen(a, b).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deger_atama();
            listBox1.Items.Add(hacim.dikdortgen_prizma(a, b, c).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void deger_atama()
        {

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

        }
    }
}
