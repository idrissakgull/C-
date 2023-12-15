using System;
using System.Windows.Forms;
using sirket_dll;

namespace WindowsFormsApplication27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        maas maas = new maas();

        private void Form1_Load(object sender, EventArgs e)
        {
         int  adet =Convert.ToInt16( Microsoft.VisualBasic.Interaction.InputBox("personel sayısı?", "personel bilgi", ""));


            for(int i = 0; i < adet; i++)
            {
                String ad = Microsoft.VisualBasic.Interaction.InputBox("personel adı?", "personel bilgi", "");
                int gelir = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("personel maaşı?", "personel bilgisi", ""));

                int a = maas.gelirvergisi(gelir);
                int b = maas.damgavergisi(gelir);
                int c = maas.emeklikisi(gelir);
                int d = maas.emeklidevlet(gelir);

                int netmaas = gelir - a - b - c - d;


                listBox1.Items.Add("adı:"+ad+"\t"+"GelirVegisi:"+ a + "\t"+"DamgaVergisi:" +b +"\t"+"EmekliKisi:"+ c +"\t"+"EmekliDevlet:"+ d+"\t"+"NetMaaş:"+netmaas);
             




            }
           
        }

     
    }
}
