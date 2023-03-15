using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38._2_Uzduotis
{
    class Gyvunas
    {
        protected string Pavadinimas { get; set; }
        protected int Amzius { get; set; }

        private const string Rusis = "Zinduolis";
        public Gyvunas(string Pavadinimas, int Amzius)
        {
            this.Pavadinimas = Pavadinimas;
            this.Amzius = Amzius;

        }

        public virtual void Informacija()
        {
            Console.WriteLine($"Gyvunas {Pavadinimas} ({Amzius} m.)");
            
        }
        public virtual void Zinduolis()
        {
            Console.WriteLine($"Gyvunas {Pavadinimas} ({Amzius} m.), {Rusis}");

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

        public override void Informacija()
        {
            base.Zinduolis();
            Console.WriteLine($"Spalva: {spalva}");
        }
    }
}
