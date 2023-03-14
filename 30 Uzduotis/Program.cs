using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Leiskite vartotojui įvesti du sveikuosius skaičius į programą.  Sukurkite ir panaudokite šiuos metodus:
            *Suma;
            *Skirtumas;
            *Sandauga;
            *Dalmuo;
            */
            
            Console.WriteLine("Įveskite du skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            
            Suma(skaicius1, skaicius2);
            Atimtis(skaicius1, skaicius2);
            Daugyba(skaicius1, skaicius2);
            Dalyba(skaicius1, skaicius2);

        }
        private static void Suma(int skaicius1, int skaicius2)
        {
            
            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
        }
        private static void Atimtis(int skaicius1, int skaicius2)
        {

            Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
        }
        private static void Daugyba(int skaicius1, int skaicius2)
        {

            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
        }
        private static void Dalyba(int skaicius1, int skaicius2)
        {

            Console.WriteLine($"{skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");
        }
    }
}
