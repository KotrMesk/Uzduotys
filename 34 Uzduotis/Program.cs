using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Įvesti du skaičius iš konsolės
             * Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: Daugybą ar  dalybą
             * Parašyti po atskirą metodą kiekvienam veiksmui (daugybai naudoti int tipą, o  dalybai double)
             * Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, 
             * jei tokio  veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.
             */

            Console.WriteLine("Įveskite du skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koki veiksma norite atlikti (Daugyba/Dalyba)?: ");
            string pasirinkimas = Console.ReadLine();

            Program p = new Program();
            if (pasirinkimas == "Daugyba")
            {
                Console.WriteLine($"Daugyba: {p.Daugyba(skaicius1, skaicius2)}");
            }
            else if (pasirinkimas == "Dalyba")
            {
                Console.WriteLine($"Dalyba: {p.Dalyba(skaicius1, skaicius2)}");
            }
            else
            {
                Console.WriteLine("Tokio veiksmo nera");
            }


        }
        private int Daugyba(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }
        private double Dalyba(double skaicius1, double skaicius2)
        {
            return skaicius1 / skaicius2;
        }
    }
}
