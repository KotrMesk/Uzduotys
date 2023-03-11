using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.
            Console.Write("Iveskite betkoki skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int daugiklis = 1;
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");

            //Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį.
            Console.WriteLine("Iveskite pirma skaiciu: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ivesti skaiciai: {number1}, {number2}, {number3}\nSkaiciu vidurkis: {(number1 + number2 + number3)/3}");

            /*Liepkite įvesti tris skaičius. 
             * Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu, 
             * taip pat tuos skaičius, padalintus iš dviejų.*/

            Console.WriteLine("Iveskite pirma skaiciu: ");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            double skaicius3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ivesti skaiciai: {skaicius1}, {skaicius2}, {skaicius3}");
            Console.WriteLine($"Skaiciai kvadratu: {Math.Pow(skaicius1,2)}, {Math.Pow(skaicius2, 2)}, {Math.Pow(skaicius3, 2)}");
            Console.WriteLine($"Skaiciai kubu: {Math.Pow(skaicius1,3)}, {Math.Pow(skaicius2, 3)}, {Math.Pow(skaicius3, 3)}");
            Console.WriteLine($"Skaiciai padalinti is 2: {skaicius1 / 2}, {skaicius2 / 2}, {skaicius3 / 2}");





        }
    }
}
