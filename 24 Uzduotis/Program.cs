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
            Console.WriteLine("Kiek duomenu nori ivesti i masyva?");
            int kiek = Convert.ToInt32(Console.ReadLine());

            int[] skaiciai = new int[kiek];

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine("Iveskite skaiciu: ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma1 = 0;

            foreach (int skaicius in skaiciai)
            {
                if (skaicius % 2 == 0)
                {
                    suma1 += skaicius;
                }

            }
            Console.WriteLine($"Lyginiu skaiciu suma: {suma1}");

            int suma2 = 0;

            for (int i = 0; i < skaiciai.Length; i++)
            {
                if (i % 2 != 0)
                {
                    suma2 += skaiciai[i];
                }
            }
            Console.WriteLine($"Nelyginiu skaiciu suma: {suma2}");
        }
    }
}