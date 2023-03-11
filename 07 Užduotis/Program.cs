using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo vardą ir amžių. Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.”
            Console.WriteLine("Įveskite vardą: ");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas: {vardas}, o amžius: {amzius}.");

            //Liepkite vartotojui įvesti bet kokį simbolį. Atspausdinkite 3x3 kvadratą iš to simbolio.
            Console.WriteLine("Iveskite bet koki simboli: ");
            char simbolis = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);

            //Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.
            Console.WriteLine("Iveskite bet koki simboli: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}{0}", skaicius);
            Console.WriteLine("{0}{0}{0}{0}", skaicius);
            Console.WriteLine("{0}{0}{0}{0}", skaicius);
            Console.WriteLine("{0}{0}{0}{0}", skaicius);


            /*Liepkite vartotojui įvesti tris skaičius. 
             *Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, 
             *nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane.*/
            Console.WriteLine("Iveskite pirma skaiciu: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Suma: {number1} + {number2} + {number3} = {number1 + number2 + number3}");
            Console.WriteLine($"Atimtis: {number1} - {number2} - {number3} = {number1 - number2 - number3}");
            Console.WriteLine($"Daugyba: {number1} * {number2} * {number3} = {number1 * number2 * number3}");
            Console.WriteLine($"Dalyba: {number1} / {number2} / {number3} = {number1 / number2 / number3}");
        }
    }
}
