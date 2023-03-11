using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Raskite visų skaičių nuo 1 iki 100 sumą.
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Suma skaiciu nuo 1 iki 100: " + suma);

            //Raskite visų lyginių skaičių nuo 20 iki 40 sumą.
            int sumaLyginiu = 0;
            for (int i = 20; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    sumaLyginiu += i;
                }
            }
            Console.WriteLine("Suma lyginiu skaiciu tarp 20 ir 40: " + sumaLyginiu);

            //Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.

            int sumaNelyginiu = 0;
            for (int i = 30; i <= 60; i++)
            {
                if (i % 2 != 0)
                {
                    sumaNelyginiu += i;
                }
            }
            Console.WriteLine("Suma nelyginiu skaiciu tarp 30 ir 60: " + sumaNelyginiu);

            //Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba 5, sumą.

            int sumaDidele = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumaDidele += i;
                }
            }
            Console.WriteLine("Suma skaiciu iki 1000 kurie dalinasi is 3 arba 5: " + sumaDidele);


        }
    }
}
