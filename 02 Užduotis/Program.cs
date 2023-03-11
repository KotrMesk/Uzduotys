using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite savo vardą: ");
            String vardas = Console.ReadLine();
            string linija = new string('-', vardas.Length);
            string tarpas = new string(' ', vardas.Length);
            Console.WriteLine($"---{linija}---");
            Console.WriteLine($"|  {tarpas}  |");
            Console.WriteLine($"|  {vardas}  |");
            Console.WriteLine($"|  {tarpas}  |");
            Console.WriteLine($"---{linija}---");
        }
    }
}
