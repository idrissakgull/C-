using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread islem1;
        Thread islem2;
        Thread islem3;
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            islem1 = new Thread(new ThreadStart(metot1));
            islem2 = new Thread(new ThreadStart(metot2));
            islem3 = new Thread(new ThreadStart(metot3));
            islem1.Start();
            islem2.Start();
            islem3.Start();
        }
        int i = 100;
        int j = 100;

        void metot1()
        {
            while (true)
            {
                listBox1.Items.Add(i++);
                Thread.Sleep(1000);
            }
        }
        void metot2()
        {
            while (true)
            {
                listBox2.Items.Add(15 * j++);
                Thread.Sleep(1000);
            }
        }

        void metot3()
        {
            while (true)
                label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            islem1.Abort();
            islem2.Abort();
            islem3.Abort();
        }
    }
}
