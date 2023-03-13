using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Paklausti vartotojo, kiek duomenų nori įvesti į masyvą  Pagal tai sukursime tokio dydžio masyvą
             * Iš konsolės įvesti duomenis į masyvą
             * Surasti 2 sumas:
             * Suma1 – kai masyvo elementas yra lyginis skaičius
             * Suma2 – kai masyvo indeksas nėra lyginis skaičius
             */

            //Console.Write("Kiek duomenų norite įvesti į masyvą: ");
            //int[] duomenys = { Convert.ToInt32(Console.ReadLine()) };
            //Console.WriteLine(duomenys[0]);

            Console.Write("Enter multiple numbers separated by spaces: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int[] intNumbers = Array.ConvertAll(numbers, int.Parse);

            Console.WriteLine("Numbers entered:");
            foreach (int num in intNumbers)
            {
                Console.WriteLine(num);

            }
        }
    }
}
