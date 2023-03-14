using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Uzduotis
{
    internal class Zodziai
    {
        internal static void Main(string[] args)
        {
            //Aprašykite ir iškvieskite metodą, kuris išvestų bet kokį jūsų pasirinktą tekstą.
            Pasisveikinimas();
            Pasisveikinimas();
            Pasisveikinimas();
            Atsisveikinimas();


        }

        private static void Pasisveikinimas()
        {
            Console.WriteLine("Labas");
        }

        private static void Atsisveikinimas()
        {
            Console.WriteLine("Ate");
        }
    }
}
