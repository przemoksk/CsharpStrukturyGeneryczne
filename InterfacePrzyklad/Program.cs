using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrzyklad
{

    interface IProdukty
    {
        void pokaz_nazwe(string nazwa);
        void pokaz_cene(double cena);


    }

    class Program
    {
        static void KonsolaWypisz(double d)
        { Console.WriteLine("delegat: " + d);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            
            Kursy kursy = new Kursy();

            kursy.pokaz_cene(100);
            kursy.pokaz_nazwe("test");

            Drukowanie drukowanie = new Drukowanie();
////
            



         }

  
    }
}
