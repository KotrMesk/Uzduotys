using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Sukurti void tipo metodą, kuriam paduosim masyvą.
             * Metodas turi išvesti masyvo sumą (sumai skaičiuoti naudoti for ciklą ir .Sum()  funkciją. 
             * Tuomet metodas išves į konsolę 2 tokias pačias sumas suskaičiuotas  skirtingais būdais)
             * Išsikviesti metodą.
             */
            
            int[] masyvas = new int[] { 1, 2, 3 };
            
            Suma(masyvas);
            SumaIf(masyvas);

        }

        static void Suma(int[] masyvas)
        {
            Console.WriteLine(masyvas.Sum());
        }
        static void SumaIf(int[] masyvas)
        {
            int suma = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                suma += masyvas[i];
            }
            Console.WriteLine(suma);
        }
    }
}
