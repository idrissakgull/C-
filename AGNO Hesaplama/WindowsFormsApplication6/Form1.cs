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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final;
            vize = Convert.ToInt16(textBox1.Text);
            final = Convert.ToInt16(textBox2.Text);
            int ort = Convert.ToInt16((vize*0.4)+(final*0.6));
            label5.Text = Convert.ToString(ort);
            if (ort>=50)
            {
                label7.Text = "BAŞARILI"+" "+"J";
                label7.ForeColor = Color.Green;
            }
            else
            { 
                label7.Text = "BAŞARISIZ"+" "+"X";             
                label7.ForeColor = Color.Red;   
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
