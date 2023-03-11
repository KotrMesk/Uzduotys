using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Užduoti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes. Pvz.: 4 + 5 = 9
            int a = 5;
            int b = 5;
            int suma = a + b;
            int atimtis = a - b;
            int daugyba = a * b;
            int dalyba = a / b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.WriteLine("{0} - {1} = {2}", a, b, atimtis);
            Console.WriteLine("{0} * {1} = {2}", a, b, daugyba);
            Console.WriteLine("{0} / {1} = {2}", a, b, dalyba);

            //Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.
            int skaicius = 5;
            Console.WriteLine($"Skaičius: {skaicius}");
            Console.WriteLine("Skaičius kvadratu: {0}", Math.Pow(skaicius, 2));
            Console.WriteLine("Skaičius kubu: {0}", Math.Pow(skaicius, 3));

            //Išveskite į ekraną trijų skaičių sandaugą.
            Console.WriteLine($"{5} * {3} * {8} = {5 * 3 * 8}");

            /*Išveskite į ekraną šių veiksmų atsakymus:
            *-1 + 4 * 6
            *14 + -4 * 6 / 11
            *2 + 15 / 6 * 1 - 7 % 2
            *Turite gauti: 23, 12, 3.*/

            Console.WriteLine($"{-1 + 4 * 6}");
            Console.WriteLine($"{14 + -4 * 6 / 11}");
            Console.WriteLine($"{2 + 15 / 6 * 1 - 7 % 2}");


        }
    }
}
