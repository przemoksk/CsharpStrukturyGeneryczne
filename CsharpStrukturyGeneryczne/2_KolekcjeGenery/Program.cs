using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] pracownik;

            pracownik = new Pracownik[]
            {
                new Pracownik {Imie = "Kata"},
                new Pracownik {Imie = "Kat1", Nazwisko = "Nowa1k"},
                new Pracownik {Imie = "Kata2", Nazwisko = "Nowak2"}
            };

            foreach (var p in pracownik)
            {
                Console.WriteLine(p.Imie + p.Nazwisko);


            }

            for (int i = 0; i < pracownik.Length; i++)
            {
                Console.WriteLine(pracownik[i].Imie + pracownik[i].Nazwisko);
            }

            Console.ReadLine();

            List<Pracownik> pracowniks = new List<Pracownik>
            {

                new Pracownik {Imie = "Adam"},
                new Pracownik {Imie = "Marek", Nazwisko = "Nowak"},
                new Pracownik { Imie = "Hanna", Nazwisko = "Smrek" }
            };

            pracowniks.Add(new Pracownik {Imie= "Henryk", Nazwisko = "Ida" });

            foreach (var item in pracowniks)
            {
                Console.WriteLine("To jest lista" +  item.Imie + item.Nazwisko);
            }
            Console.ReadKey();
        }
    }
}
