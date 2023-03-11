using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
             * ar pirmas skaičius didesnis už antrą;
             * ar antras skaičius didesnis už trečią;
             * ar trečias skaičius didesnis už pirmą;
             * ar pirmi du skaičiai lygūs;
             */

            Console.WriteLine("Iveskite pirma skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine($"{skaicius1} yra didesnis uz {skaicius2}");
            }
            else if (skaicius2 > skaicius3)
            {
                Console.WriteLine($"{skaicius2} yra didesnis uz {skaicius3}");
            }
            else if (skaicius3 > skaicius1)
            {
                Console.WriteLine($"{skaicius3} yra didesnis uz {skaicius1}");
            }
            else if (skaicius1 == skaicius2)
            {
                Console.WriteLine($"{skaicius1} yra lygus {skaicius2}");
            }

            /*Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
             * ar temperatūra < 0 - išvesti “žiauriai šalta”;
             * ar temperatūra < 10 - išvesti “labai šalta”;
             * ar temperatūra < 20 - išvesti “šalta”;
             * ar temperatūra < 30 - išvesti “normali temperatūra”;
             * ar temperatūra < 40 - išvesti “karšta”;
             * ar temperatūra >= 40 - išvesti “visiškai degina”;
             */

            Console.Write("Iveskite sios dienos oro temperatura: ");
            int temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("žiauriai šalta");
            }
            else if (temperatura < 10) 
            {
                Console.WriteLine("labai šalta");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("šalta");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("normali temperatūra");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("karšta");
            }
            else if (temperatura >= 40)
            {
                Console.WriteLine("visiškai degina");
            }
        }
    }
}
