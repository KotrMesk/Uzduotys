using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje.
            string vardas = "Kotryna";
            Console.WriteLine($"Labas, {vardas}");
            

            /*Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su šiuo amžiumi: “Įvestas amžius: { amžius}”. 
            *Tarp { } nurodytas kintamasis, kurio reikšmė toje vietoje turi būti įstatyta.*/

            int amzius = 35;
            Console.WriteLine($"Įvestas amžius: {amzius}");
            Console.WriteLine();

            //Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje be tarpų tarp šių skaičių(skaičius -25, išvedimas - 2525252525).

            string skaicius = "25";
            Console.WriteLine(skaicius + skaicius + skaicius + skaicius + skaicius);

            //Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje su tarpais tarp šių skaičių(skaičius -25, rezultatas - 25 25 25 25 25).

            
            Console.WriteLine("{0} {0} {0} {0} {0}", skaicius);

        }
    }
}
