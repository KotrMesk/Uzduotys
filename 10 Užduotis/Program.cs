using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite įvesti skaičių.
             * Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
             * Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių. Išveskite abiejų skaičių sumą ir sandaugą.
             */

            Console.Write("Iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius % 2 == 0)
            {
                Console.WriteLine($"Jus ivedete: {skaicius}.\nJusu skaicius pakeltas penktuoju laipsniu: {Math.Pow(skaicius, 5)}");
            }
            if (skaicius % 4 != 0)
            {
                Console.WriteLine("Jusu skaicius nesidalina is 4, iveskite nauja skaiciu: ");
                int skaicius1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Suma: {skaicius} + {skaicius1} = {skaicius + skaicius1}");
                Console.WriteLine($"Sandauga: {skaicius} * {skaicius1} = {skaicius * skaicius1}");
            }
        }
    }
}