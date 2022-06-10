using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa
    {
        private double[] bufor;
        private int poczatekBufora;
        private int koniecBufora;

        public KolejkaKolowa() : this(pojemnosc: 5)
        { }


        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatekBufora = 2;
            koniecBufora = 0;
        }

        public void Zapisz()

        {
            poczatekBufora = 5;
            //   var wynik = bufor[poczatekBufora];
            var wynik = poczatekBufora;
            poczatekBufora = (poczatekBufora + 1);
            var wynik2 = poczatekBufora;
            Console.WriteLine(wynik);
            Console.WriteLine(wynik2);
            Console.ReadLine();
        }


       

    }
}

