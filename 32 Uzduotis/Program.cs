using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Paprašyti įvesti vartotojo vardą.
             * Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
             * Išvesti šią frazę į konsolę.
             */
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.WriteLine();
            Uzklausa(vardas);
            Console.WriteLine();
        }
        private static void Uzklausa(string vardas)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Labas, {vardas}.");
            
        }
    }
}
