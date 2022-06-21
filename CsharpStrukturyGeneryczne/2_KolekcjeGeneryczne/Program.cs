using _2_KolekcjeGeneryczne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracowniks = new List<Pracownik>();

            pracowniks.Add(new Pracownik { Imie = "Jan", Nazwisko = "Kowalski" });

            foreach (var item in pracowniks)
            {
                Console.WriteLine("111" + item.Imie);
                Console.WriteLine(item.Imie.Contains("Jan"));

            }
            Console.ReadKey();
        }
    }
}
