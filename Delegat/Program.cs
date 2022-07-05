using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Program
    {
        static void Main(string[] args)
        {


            Action<double> drukuj = d => Console.WriteLine(d);
            drukuj(7);


            Action<int, int, int> test = (a, b, c) => Console.WriteLine(a+b+c);
            test(1, 2, 3);

            Console.ReadLine();
           


        }
    }
}
