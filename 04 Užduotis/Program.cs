using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite reikiamus kintamuosius užduočiai atlikti. Į ekraną išveskite: Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
            *Tarp { } nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti įstatytos.*/

            string marke = "Hyundai";
            string modelis = "I20 active";
            int metai = 2019;
            int rida = 20000;
            Console.WriteLine($"Automobilio {marke} {modelis} ({metai} m.) rida - {rida} km.");

        }
    }
}
