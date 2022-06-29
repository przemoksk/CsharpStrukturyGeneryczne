using _2_KolekcjeGeneryczne;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStrukturyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {


            Queue<Pracownik> kolejka = new Queue<Pracownik>();

            kolejka.Enqueue(new Pracownik { Imie = "Jan", Nazwisko = "Kowalski" });
            kolejka.Enqueue(new Pracownik { Imie = "Kasia", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Adam", Nazwisko = "Zielon" });

            foreach (var item in kolejka)
            {
                Console.WriteLine(item.Imie);
            }
          

            Queue p = new Queue();
            p.Enqueue("a");
            p.Enqueue(1);
            p.Enqueue("1qwqwqa");

            p.Dequeue();
          //  p.Dequeue();

            foreach (var item in p)
            {
                Console.WriteLine("Nowa kolejka--------------" + item);
            }
            

            Console.ReadLine();



            Stack<Pracownik> stos = new Stack<Pracownik>();

            stos.Push(new Pracownik { Imie = "Jan", Nazwisko = "Kowalski" });
            stos.Push(new Pracownik { Imie = "Kasia", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Adam", Nazwisko = "Zielon" });

            foreach (var item in stos)
            {
                Console.WriteLine("stos: " + item.Imie + item.Nazwisko);
            }

           

            kolejka.Count();

            var _pracownik = new Dictionary<string,Pracownik>();


            _pracownik.Add("001", new Pracownik { Imie = "Jan", Nazwisko = "Kowalski" });
            _pracownik.Add("002", new Pracownik { Imie = "Adam", Nazwisko = "Nowak" });
            _pracownik.Add("003", new Pracownik { Imie = "Anna", Nazwisko = "Zielona" });


            foreach (var item in _pracownik)
            {
                Console.WriteLine("Słownik: " + item.Value.Nazwisko);
            }



            // dodawnie listy pracownikow do s lownika


            var _pracownikL = new Dictionary<string, List<Pracownik>>();

            _pracownikL.Add("Nowak", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowakowski" } });

            _pracownikL.Add("Nowak1", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowakowski" } });

            _pracownikL["Nowak1"].Add(new Pracownik { Nazwisko = "Kowalski" });
            _pracownikL["Nowak1"].Add(new Pracownik { Nazwisko = "Chwalczuk" });

            

            foreach (var item in _pracownikL)
            {

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko); 
                }

                Console.WriteLine(item.Value);
            }


            Console.ReadLine();





        }
    }
}
