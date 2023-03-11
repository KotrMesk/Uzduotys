using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.
            Console.Write("Iveskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti");
            }
            else
            {
                Console.WriteLine("Jus negalite balsuoti");
            }

            /*Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
             * Patikrinti, ar skaičius neigiamas, jei taip - aprėkti vartotoją 
             * Patikrinti, ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
             * Patikrinti, ar skaičius lyginis, jei taip - išvesti “taip, skaičius yra lyginis”;
             * Patikrinti, ar skaičius dalinasi iš 4, jei taip - išvesti “taip, dalinasi iš 4”;
             * Patikrinti, ar skaičius yra didesnis nei 10, jei taip - išvesti “taip, skaičius yra didesnis už 10”.
             */

            Console.Write("Iveskite bet koki skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius < 0)
            {
                Console.WriteLine("Negalima ivesti neigiamo skaiciau!");
            }
            if (skaicius > 0)
            {
                Console.WriteLine("Sveikiname, ivedete teigiama skaiciu");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Taip, skaicius yra lyginis");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Taip, dalinasi is 4");
            }
            if (skaicius > 10)
            {
                Console.WriteLine("Taip, skaičius yra didesnis už 10");
            }

            /*Liepkite vartotojui įvesti penkis  du savo pažymius, raskite šių pažymių vidurkį, 
             * patikrinkite, ar vidurkis yra lygus arba didesnis už 5, jei taip, išveskite “Valio!!!”.
             */
            Console.Write("Iveskite pirma savo pazymi: ");
            int pazymys1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra savo pazymi: ");
            int pazymys2 = Convert.ToInt32(Console.ReadLine());
            int vidurkis = (pazymys1 + pazymys2)/2;
            Console.WriteLine();
            Console.WriteLine($"Jusu pazymiu vidurkis: {vidurkis}");
            
            if (vidurkis >= 5)
            {
                Console.WriteLine("Valio!");
            }
            

        }
    }
}
