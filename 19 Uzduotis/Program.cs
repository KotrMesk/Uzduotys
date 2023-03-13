using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašyti For ciklą, kuris suskaičiuotų, kiek skaičių intervale [0 – 1000) dalinasi iš 16.

            int kiekSkaiciu = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 16 == 0)
                {
                    kiekSkaiciu++;
                }
            }
            Console.WriteLine($"Intervale yra {kiekSkaiciu} skaiciai kurie dalinasi is 16");

            /*Liepkite vartotojui įvesti teigiamą skaičių. While ciklo viduje skaičių kelkite vis
            *didesniu laipsniu ir jį išveskite į ekraną, kol skaičius netaps didesnis už 1500.
            */

            Console.Write("Iveskite teigiama skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int laipsnis = 1;
            double rezultatas = skaicius;
            

            while (rezultatas < 1500)
            {
                laipsnis++;
                Console.WriteLine(rezultatas);
                rezultatas = Math.Pow(skaicius, laipsnis);
            }
        }
    }
}
