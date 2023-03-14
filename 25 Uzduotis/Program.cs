using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu. Rasti  didžiausią pažymį.
             * Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu. Rasti mažiausią pažymį.
             */




            Console.Write("Iveskite 5 pazymius vienoje eiluteje atskiriant tarpu: ");
            string input = Console.ReadLine();

            string[] pazymiai = input.Split(' ');

            int[] pazimys = Array.ConvertAll(pazymiai, int.Parse);

            Console.WriteLine($"Didziausias pazymys: {pazimys.Max()}");

            Console.Write("Iveskite 5 pazymius vienoje eiluteje atskiriant kableliu: ");
            string ivedimas = Console.ReadLine();

            string[] ivertinimai = ivedimas.Split(',');
            
            int[] ivertinimas = Array.ConvertAll(ivertinimai, int.Parse);

            Console.WriteLine($"Maziausias pazymys: {ivertinimas.Min()}");


        }
    }
}
