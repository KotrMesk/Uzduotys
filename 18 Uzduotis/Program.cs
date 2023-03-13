using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Tikslas:
             * Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
             * Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
             * Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
             * Iš anksto žinoma informacija:
             * Darbo valandų per dieną - 8 val.
             * Vartotojo įvedama informacija:
             * Kiek darbuotojas gali iškepti kepalų per valandą.
             * Kiek darbuotojų turi kepykla.
             * Vieno kepalo savikaina.
             * Vieno kepalo pardavimo kaina.
             * Kiek kepykla turi tą dieną iškepti kepalų (užsakymai).
             */

            Console.Write("Iveskite kiek darbuotoju turi kepykla: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite kiek darbuotojas gali iskepti kepalu per valanda: ");
            int kepaluPerValanda = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite kepalo savikaina: ");
            int kepaloSavikaina = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite pardavimo kaina: ");
            int kepaloKaina = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite kiek kepykla turi tą dieną iškepti kepalų: ");
            int uzsakymoKiekis = Convert.ToInt32(Console.ReadLine());

            int darboDiena = 8;

            int kepalaiPerDiena = darbuotojai * kepaluPerValanda * darboDiena;
            int pelnas = (kepaloKaina - kepaloSavikaina) * darbuotojai * kepaluPerValanda * darboDiena;

            if (kepalaiPerDiena == uzsakymoKiekis)
            {
                Console.WriteLine("Uzsakyma spejo ivykdyti");
                Console.WriteLine($"Iskepta kepalu per diena: {kepalaiPerDiena}");
                Console.WriteLine($"Dienos pelnas: {pelnas}");
            }
            else if (kepalaiPerDiena < uzsakymoKiekis)
            {
                Console.WriteLine($"Kepykla nespejo iskepti {uzsakymoKiekis - kepalaiPerDiena} kepalu");
            }


        }
    }
}
