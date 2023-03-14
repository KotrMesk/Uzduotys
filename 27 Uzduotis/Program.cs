using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Susikurti žodžių sąrašą. 
             * Rasti trumpiausią ir ilgiausią žodžius, juos išvesti į  ekraną, 
             * prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
             * Tip: string kintamasis iš tiesų yra char masyvas, todėl galite naudoti zodis.Length
             */

            List<string> zodziai = new List<string> { "suo", "kate", "gyvate", "kupranugaris" };

            string trumpasZodis = zodziai.OrderBy(s => s.Length).First();
            string ilgasZodis = zodziai.OrderBy(s => s.Length).Last();

            Console.WriteLine($"Trumpiausias zodis: {trumpasZodis}");
            Console.WriteLine($"Ilgiausias zodis: {ilgasZodis}");

            foreach (string zodis in zodziai)
            {
                Console.WriteLine($"{zodis} sudarytas is {zodis.Length} raidziu");
            }

        }
    }
}
