using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _38_Uzduotis
{
    class Gyvunas
    {
        protected string Pavadinimas { get; set; }
        protected int Amzius { get; set; }
        public Gyvunas(string Pavadinimas, int Amzius)
        {
            this.Pavadinimas = Pavadinimas;
            this.Amzius = Amzius;
            
        }
    }
    class Gyvate : Gyvunas
    {
        protected string spalva { get; set; }

        public Gyvate(string Pavadinimas, int Amzius, string spalva) : base(Pavadinimas, Amzius) 
        {
            this.Pavadinimas = Pavadinimas;
            this.Amzius = Amzius;
            this.spalva = spalva;
        }

        internal void Informacija()
        {
            Console.WriteLine($"Gyvunas {Pavadinimas} ({Amzius} m.)");
            Console.WriteLine($"Spalva: {spalva}");
        }
    }
}
