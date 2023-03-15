using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Įvesti du skaičius iš konsolės
             * 
             * Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: 
             * sudėtis, atimtis,  kėlimas 4 laipsniu sudėjus abu skaičius, kvadratinė šaknis sudėjus abu skaičius.
             * 
             * Parašyti po atskirą metodą kiekvienam veiksmui (sudėčiai ir atimčiai naudoti  int tipą, o visiems kitiems double).
             * 
             * Su switch() patikrinti kokį veiksmą atlikti ir kiekviename case‘e išsikviesti  atitinkamą metodą, 
             * jei tokio case‘o nėra – informuoti vartotoją, jog tokio  veiksmo nėra.
             */

            Console.WriteLine("Įveskite du skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koki veiksma norite atlikti (sudetis/atimtis/kelimas 4 laipsniu/saknis sumos)?: ");
            string pasirinkimas = Console.ReadLine();
            Program p = new Program();
            switch (pasirinkimas)
            {
                case "sudetis":
                    Console.WriteLine(p.Suma(skaicius1, skaicius2));
                    break;
                case "atimtis":
                    Console.WriteLine(p.Atimits(skaicius1, skaicius2));
                    break;
                case "kelimas 4 laipsniu":
                    Console.WriteLine(p.KelimasLaipsniu(skaicius1, skaicius2));
                    break;
                case "saknis sumos":
                    Console.WriteLine(p.Saknis(skaicius1, skaicius2));
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;

            }


        }
        private int Suma(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }
        private int Atimits(int skaicius1, int skaicius2)
        {
            return skaicius1 +- skaicius2;
        }
        private double KelimasLaipsniu(int skaicius1, int skaicius2)
        {
            return Math.Pow(skaicius1 + skaicius2, 2);
        }
        private double Saknis(int skaicius1, int skaicius2)
        {
            return Math.Sqrt(skaicius1 + skaicius2);
        }
        

    }
}
