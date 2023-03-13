using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Susikurkite savaitės temperatūrų rodmenų masyvą. Raskite:
             * žemiausią temperatūrą;
             * didžiausią temperatūrą;
             * vidurkį;
             * Temperatūrų, esančių žemiau už vidurkį, kiekį;
             * Temperatūrų, esančių aukščiau už vidurkį, kiekį.
             */

            int[] temperatura = { 5, 10, 13, 8, 25 };
            int min = temperatura.Min();
            int max = temperatura.Max();
            int vidurkis = temperatura.Sum() / temperatura.Length;
            int kiekis1 = 0;
            int kiekis2 = 0;
            Console.WriteLine($"Maziausias skaicius: {min}");
            Console.WriteLine($"Didziausias skaicius: {max}");
            Console.WriteLine($"Vidurkis: {vidurkis}");
            foreach (int maziauNei in temperatura)
            {
                if (maziauNei < vidurkis)
                {
                    kiekis1++;
                }
            }
            Console.WriteLine($"Temperatūrų, esančių žemiau už vidurkį, kiekis: {kiekis1}");

            foreach (int daugiauNei in temperatura)
            {
                if (daugiauNei > vidurkis)
                {
                    kiekis2++;
                }
            }
            Console.WriteLine($"Temperatūrų, esančių žemiau už vidurkį, kiekis: {kiekis2}");
            Console.WriteLine();
            /*Susikurkite studentų pažymių masyvą. Raskite:
             * geriausią pažymį;
             * kiek mokinių yra gavę dešimtukus;
             * kiek mokinių yra gavę neigiamą pažymį (žemiau nei 4);
             * pažymių vidurkį.
             */

            int[] pazymiai = { 5, 10, 7, 3, 10 };
            int geriausias = pazymiai.Max();
            int pazymiuVidurkis = pazymiai.Sum() / pazymiai.Length;
            int kiekMokiniu = 0;
            int kiekMokiniu2 = 0;
            Console.WriteLine($"Geriausias pazimys: {geriausias}");
            Console.WriteLine($"Pazymiu vidurkis: {pazymiuVidurkis}");

            foreach (int desimtukas in pazymiai)
            {
                if (desimtukas == 10)
                {
                    kiekMokiniu++;
                }
            }
            Console.WriteLine($"Kiek mokinių yra gavę dešimtukus: {kiekMokiniu}");

            foreach (int desimtukas in pazymiai)
            {
                if (desimtukas < 4)
                {
                    kiekMokiniu2++;
                }
            }
            Console.WriteLine($"Kiek mokinių yra gavę neigiama pazymi (zemiau nei 4): {kiekMokiniu2}");
        }
    }
}
