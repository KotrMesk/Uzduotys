using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Liepkite įvesti tris skirtingus skaičius. Suraskite, kuris iš šių skaičių yra didžiausias.
            Console.Write("Iveskite pirma skaiciu: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite trecia skaiciu: ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"Didziausias skaicius: {number1}");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"Didziausias skaicius: {number2}");
            }
            else 
            {
                Console.WriteLine($"Didziausias skaicius: {number3}");
            }


            /*Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
             * ar gautas rezultatas yra [8-10];
             * ar gautas rezultatas yra [5-8);
             * ar gautas rezultatas yra < 5.
             */

            Console.Write("Iveskite egzamino rezultata: ");
            int rezultatas = Convert.ToInt32(Console.ReadLine());

            if (rezultatas >= 8 && rezultatas <= 10)
            {
                Console.WriteLine("Gautas rezultatas yra [8 - 10]");
            }
            else if (rezultatas >= 5 && rezultatas < 8)
            {
                Console.WriteLine("Gautas rezultatas yra [5 - 8)");
            }
            else
            {
                Console.WriteLine("Gautas rezultatas yra mazesnis uz 5");
            }

            /*Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
             * ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
             * ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
             * ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
             * ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
             */

            Console.Write("Iveskite pirma skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());


            if (skaicius1 > skaicius2 && skaicius1 == 20)
            {
                Console.WriteLine("pirmas skaičius yra didesnis už antrąjį ir yra lygus 20");
            }
            if (skaicius2 > skaicius1 && skaicius1 < 100)
            {
                Console.WriteLine("antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
            }
            if (skaicius1 > skaicius2 || skaicius1 == 0)
            {
                Console.WriteLine("pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0");
            }
            if (skaicius2 > skaicius1 || skaicius1 == 5)
            {
                Console.WriteLine("antras skaičius yra didesnis už pirmąjį, arba yra lygus 5");
            }
            

        }
    }
}
