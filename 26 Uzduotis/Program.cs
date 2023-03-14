using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100. Raskite:
             * mažiausią skaičių;
             * didžiausią skaičių;
             * vidurkį;
             * kiek skaičių yra žemesni už vidurkį;
             * lyginių skaičių sumą;
             */

            List<int> skaiciai = new List<int> { 10, 89, 3, 2};
            Console.WriteLine($"Maziausias skaicius: {skaiciai.Min()}");
            Console.WriteLine($"Didziausias skaicius: {skaiciai.Max()}");
            Console.WriteLine($"Vidurkis: {skaiciai.Average()}");

            int mazesniUzVidurki = 0;

            foreach ( int i in skaiciai )
            {
                if ( i < skaiciai.Average() )
                {
                    mazesniUzVidurki++;
                }
            }
            Console.WriteLine($"Skaiciu mazesniu uz vidurki kiekis: {mazesniUzVidurki}");

            int suma = 0;
            foreach (int i in skaiciai)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine($"Lyginiu skaiciu suma: {suma}");

            /* Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.  
             * Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę. Raskite:
             * didžiausią pažymį;
             * mažiausią pažymį;
             * vidurkį;
             */

            Console.WriteLine("Kiek duomenu nori ivesti i masyva?");
            int kiek = Convert.ToInt32(Console.ReadLine());

            List<int> pazymiai = new List<int>();

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Iveskite skaiciu: ");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine($"Didziausias pazymys: {pazymiai.Max()}");
            Console.WriteLine($"Maziausias pazymys: {pazymiai.Min()}");
            Console.WriteLine($"Vidurkis: {pazymiai.Average()}");
        }
    }
}
