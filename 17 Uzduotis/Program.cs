using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui įvesti teigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. 
             * Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.
             */

            Console.Write("Iveskite teigiama skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius > 0)
            {
                Console.WriteLine(skaicius);
                skaicius--;
            }

            Console.WriteLine();
            
            /*Liepkite vartotojui įvesti neigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. 
             * Pvz.: -4 -3 -2 -1 0. Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
             */

            Console.Write("Iveskite neigiama skaiciu: ");
            int neigSkaicius = Convert.ToInt32(Console.ReadLine());

            while(neigSkaicius <= 0)
            {
                Console.Write($"{neigSkaicius} ");
                neigSkaicius++;
            }

            /*Padarykite skaičiuotuvą. 
             * Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. 
             * Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai, išvedant kartu ir atliekamus veiksmus. 
             * Pvz.:5 + 4 = 9 
             * 5 - 4 = 1 
             * Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
             */
            Console.WriteLine();
            Console.WriteLine();

            string arNoriSkaiciuoti = "t";

            while (arNoriSkaiciuoti == "t")
            {
                
                Console.Write("Iveskite pirma skaiciu: ");
                int skaicius1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Iveskite antra skaiciu: ");
                int skaicius2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
                Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
                Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
                Console.WriteLine($"{skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");
                Console.WriteLine("ar norite toliau skaiciuoti? t/n");
                arNoriSkaiciuoti = Console.ReadLine();
            }
        }
    }
}
