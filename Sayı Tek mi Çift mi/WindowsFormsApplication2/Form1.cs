using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("sayı çift sayıdır");
            }
            else
            {
                MessageBox.Show("sayı tek sayıdır");
            }
        }
    }
}
