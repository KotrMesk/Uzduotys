using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _37_Uzduotis
{
    internal class Salis
    {
        internal string pavadinimas { get; }
        internal string prezidentas { get; }
        internal int plotas { get; }
        internal int gyventojuSkaicius { get; }
        internal int vidutinisAtlyginimas { get; set; }
        internal int[] augimas { get; }

        internal Salis(string pavadinimas, string prezidentas, int plotas, int gyventojuSkaicius, int vidutinisAtlyginimas, int[] augimas)
        {
            this.pavadinimas = pavadinimas;
            this.prezidentas = prezidentas;
            this.plotas = plotas;
            this.gyventojuSkaicius = gyventojuSkaicius;
            this.vidutinisAtlyginimas = vidutinisAtlyginimas;
            this.augimas = augimas;
            this.augimas = augimas;
        }

        internal Salis(string pavadinimas, string prezidentas, int[] augimas)
        {
            this.pavadinimas = pavadinimas;
            this.prezidentas = prezidentas;
            this.augimas = augimas;
        }

        internal Salis(string pavadinimas, int plotas, int[] augimas)
        {
            this.pavadinimas = pavadinimas;
            this.plotas = plotas;
            this.augimas = augimas;

        }

        internal Salis(string pavadinimas, int gyventojuSkaicius, int vidutinisAtlyginimas, int[] augimas)
        {
            this.pavadinimas = pavadinimas;
            this.gyventojuSkaicius = gyventojuSkaicius;
            this.vidutinisAtlyginimas = vidutinisAtlyginimas;
            this.augimas = augimas;
        }

        internal void Informacija()
        {

            Console.WriteLine($"{pavadinimas}:");
            Console.WriteLine($"Prezidentas: {prezidentas}");
            Console.WriteLine($"Plotas: {plotas} kv.m.");
            Console.WriteLine($"Populiacija: {gyventojuSkaicius}");
            Console.WriteLine($"Vidutinis atlyginimas: {vidutinisAtlyginimas} eur.");
            Console.WriteLine($"Augimas 2013: {augimas[0]}");
        }

        internal void Masyvas(int[] augimas)
        {
            if (augimas[0] > augimas[1])
            {
                Console.WriteLine($"Augimas 2014 - 2016 metais: {augimas[0]}, {augimas[1]}");
            }
            else
            {
                Console.WriteLine($"Augimas 2014: {augimas[0]}");
            }
        }
    }
}
