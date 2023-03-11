using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Išveskite pasirinkto skaičiaus daugybos lentelę.
            int skaicius = 8;
            int daugiklis = 0;
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");
            Console.WriteLine($"{skaicius} * {++daugiklis} = {skaicius * daugiklis}");

            //Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
            int number = 55;
            Console.WriteLine($"{number} * {number} = {number *= number}");


        }
    }
}
