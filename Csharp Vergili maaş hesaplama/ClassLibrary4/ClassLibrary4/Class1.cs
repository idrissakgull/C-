using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sirket_dll;

namespace sirket_dll
{
    public class maas
    {


        public int gelirvergisi(int gelir)
        {

            return gelir = gelir * 25 / 100;


        }
        public int damgavergisi(int gelir)
        {

            return gelir = gelir * 7 / 100;


        }
        public int emeklikisi(int gelir)
        {

            return gelir = gelir * 16 / 100;



        }

        public int emeklidevlet(int gelir)
        {
            return gelir = gelir * 20 / 100;

        }


    }
}