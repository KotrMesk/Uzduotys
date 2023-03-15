using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Uzduotis
{
    internal class Mokinys
    {
        internal string vardas { get; }
        internal string pavarde { get; }
        internal int amzius { get; }
        internal int klase { get; }
        internal List<int> pazymiai { get; set; }

        public Mokinys(string vardas, string pavarde, int amzius, int klase, List<int> pazymiai)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
            this.klase = klase;
            this.pazymiai = pazymiai;
            
        }

        internal void Informacija()
        {

            Console.WriteLine($"Mokinys: {vardas} {pavarde} ({amzius} m.)");
            Console.WriteLine($"Klase: {klase}");
            Console.WriteLine($"Pazymiu vidurkis: {pazymiai.Average()}");
        }

        internal void MokyklosBaigimas()
        {
            if (klase < 12)
            {
                Console.WriteLine($"Mokinys baigs mokykla uz {12 - klase} metu.");
            }
            else if (klase == 12)
            {
                Console.WriteLine("Mokinys baigs mokykla siais metais.");
            }
        }

        //public static int Teigiami(List<int> pazymiai)
        //{
        //    List<int> pazymiaiTeigiami = pazymiai.Where(n => n > 4).ToList();

        //    Console.WriteLine(pazymiaiTeigiami.Count());
        //}
    }
}
