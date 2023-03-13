using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja  degalų 100 – ui km. 
             * Susikurkite masyvą, kuriame saugotumėte skirtingose kelionėse nuvažiuotų kilometrų rodmenis. Raskite:
             * trumpiausia kelione
             * ilgiausia kelione
             * kiek kuro sanaudu sunaudojo automobilis (skaičiavimui reikės rasti visus nuvažiuotus km).
             */

            double degaluSanaudos = 11;
            int[] keliones = { 100, 240, 80, 530, 1200 };
            int min = keliones.Min();
            int max = keliones.Max();
            double sanaudosKelioniu = keliones.Sum() * degaluSanaudos / 100;
            Console.WriteLine($"Trumpiausia kelione: {min}");
            Console.WriteLine($"Ilgiausia kelione: {max}");
            Console.WriteLine($"Visu kelioniu kuro sanaudos: {sanaudosKelioniu}");
        }
    }
}
