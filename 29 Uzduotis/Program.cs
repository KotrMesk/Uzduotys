using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Parašykite metodą, kuris pasisveikintų su vartotoju.
             * Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
             * Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda formatuotai
             */
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Labas");
            Console.WriteLine("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite savo hobį: ");
            string hobis = Console.ReadLine();
            Uzklausa(vardas, amzius, hobis);



        }
        private static void Uzklausa(string vardas, int amzius, string hobis)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Labas, {vardas} ({amzius} m.).");
            Console.WriteLine($"Jūsų įrašytas hobis: {hobis}");
        }
    }
}
