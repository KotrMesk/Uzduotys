using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
             * ar jis lygus 1: išveskite visų trijų skaičių sumą;
             * ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
             * ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
             */

            Console.WriteLine("Iveskite pirma skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine($"Visu skaiciu suma: {skaicius1 + skaicius2 + skaicius3}");
                    break;
                case 2:
                    Console.WriteLine($"Pirmo ir trecio skaiciu suma: {skaicius1 + skaicius3}");
                    break;
                case 3:
                    Console.WriteLine($"Antro ir trecio skaiciu suma: {skaicius2 + skaicius3}");
                    break;
            }

            /* Liepkite vartotojui įvesti gyvūno rūšį. Su switch patikrinkite:
             * ar įvestas gyvūnas yra šuo;
             * ar įvestas gyvūnas yra katė;
             * ar įvestas gyvūnas yra žiurkėnas.
             */

            Console.WriteLine("Iveskite gyvuna: ");
            string gyvunas = Console.ReadLine();

            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("Gyvunas yra suo");
                    break;
                case "kate":
                    Console.WriteLine("Gyvunas yra kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Gyvunas yra ziurkenas");
                    break;
                    
            }

        }
    }
}
