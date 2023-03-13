using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
             * Suraskite įžambinę ir ją išveskite į ekraną.
             */
            Console.Write("Iveskite pirma stataus trikampio statinio ilgi: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra stataus trikampio statinio ilgi: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Trikampio izambine: {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))}");

        }
    }
}
