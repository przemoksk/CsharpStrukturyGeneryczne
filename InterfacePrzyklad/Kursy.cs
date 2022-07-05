using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrzyklad
{
    class Kursy : IProdukty
    {
      public  void pokaz_cene(double cena)
        {
            Console.WriteLine(cena);
            Console.ReadKey();
        }

   public void pokaz_nazwe(string nazwa)
        {
            Console.WriteLine(nazwa);
            Console.ReadKey();
            
        }
    }
}
