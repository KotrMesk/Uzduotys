using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _36_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Sukurti klasę Mokinys su kintamaisiais: vardas, pavardė, amžius, klasė ir  pažymių sąrašą, kur saugosime 5 pažymius.
             * Sukurti konstruktorių, kad priskirtų reikšmes. 
             * Klasės viduje sukurti metodą, kad išvestų visą informaciją apie mokinį.
             * Susikurti 3 objektus, jiems priskirti reikšmes ir naudojant sukurtą metodą  išvesti kiekvieno mokinio informaciją.
             */

            /*Klasės viduje sukurti void tipo metodą, kuris išvestų į ekraną už, kiek metų  mokinys baigs mokyklą, 
             * jei atsakymas 0 – tuomet išvesti „Mokinys mokyklą  baigs šiais metais“. 
             * Iškviesti metodą Main‘o viduje visiems objektams.
             * Main‘o viduje naudojant Sąrašo komandas Max() ir Min() išvesti į ekraną
              * kiekvieno mokinio geriausią ir blogiausią pažymį.
              * 
              * Sukurti int tipo metodą (pagrindinės klasės viduje), kuriam paduosim kintamąjį, kurio tipas yra Mokinys.  
              * Metodas turi apskaičiuoti, kiek yra mokinio pažymių, didesnių už 4. Išvesti šią informaciją apie kiekvieną mokinį.
              */
            List<int> mokinioPazymiai1 = new List<int> { 6, 7, 4, 9, 5 };
            Mokinys mokinys1 = new Mokinys("Jonas", "Jonaitis", 11, 6, mokinioPazymiai1);
            List<int> mokinioPazymiai2 = new List<int> { 8, 9, 10, 10, 10 };
            Mokinys mokinys2 = new Mokinys("Lina", "Linaite", 12, 6, mokinioPazymiai2);
            List<int> mokinioPazymiai3 = new List<int> { 6, 6, 9, 5, 5 };
            Mokinys mokinys3 = new Mokinys("Arunas", "Arunaitis", 17, 12, mokinioPazymiai3);
            mokinys1.Informacija();
            Console.WriteLine($"Mokinio zemiausias pazymys: {mokinioPazymiai1.Min()}");
            Console.WriteLine($"Mokinio auksciausias pazymys: {mokinioPazymiai1.Max()}");
            mokinys1.MokyklosBaigimas();
            Console.WriteLine();
            mokinys2.Informacija();
            Console.WriteLine($"Mokinio zemiausias pazymys: {mokinioPazymiai2.Min()}");
            Console.WriteLine($"Mokinio auksciausias pazymys: {mokinioPazymiai2.Max()}");
            mokinys2.MokyklosBaigimas();
            Console.WriteLine();
            mokinys3.Informacija();
            Console.WriteLine($"Mokinio zemiausias pazymys: {mokinioPazymiai3.Min()}");
            Console.WriteLine($"Mokinio auksciausias pazymys: {mokinioPazymiai3.Max()}");
            mokinys3.MokyklosBaigimas();



        }

    }
}
