using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus (iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
            *pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
            *skirtą studentų pažymiams saugoti;
            *skirtą mašinų markėms saugoti.
            */
            int[] studentuPazymiai = { 3, 5, 10, 8, 6, 2 };
            Console.WriteLine(studentuPazymiai[0]);
            Console.WriteLine(studentuPazymiai[3]);

            string[] masinos = new string[3];
            masinos[0] = "Mercedes";
            masinos[1] = "Toyota";
            masinos[2] = "Hyundai";

            Console.WriteLine(masinos[2]);

            //Papildyti praeitos užduoties kodą. Išvesti narių skaičių, pirmą narį ir paskutinį  narį bent iš vieno pasirinkto masyvo.
            Console.WriteLine(masinos.Length);
            Console.WriteLine("Pirma reiksme masyve: {0}", masinos[0]);
            Console.WriteLine("Paskutine reiksme masyve: {0}", studentuPazymiai[studentuPazymiai.Length - 1]);
        }
    }
}
