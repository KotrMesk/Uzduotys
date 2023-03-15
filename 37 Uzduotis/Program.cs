using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*sukurti klasę Salis su kintamaisiais: Pavadinimas, Prezidentas, Plotas,  GyventojuSkaicius, VidutinisAtlyginimas ir masyvu Augimas, 
             * kur saugosime 5  metų rodmenis, kiek gyventojų gimė kasmet.
             * Sukurti 4 skirtingus konstruktorius.
             * Klasės viduje sukurti metodą, kad išvestų visą informaciją apie šalį.
             * Susikurti 4 objektus, jiems priskirti reikšmes su skirtingais konstruktoriais ir  naudojant sukurtą metodą išvesti kiekvienos šalies informaciją.
             * Klasės viduje sukurti void tipo metodą, kuris pagal duotą reikšmę iš consolės(masyvo indeksą / elemento vietą masyve), 
             * išvestų į ekraną masyvo elemento  reikšmę ir jei reikšmė didesnė už sekančią reikšmę (n + 1) - išvesti ir tą reikšmę.
             */
            
            int[] populiacija1 = new int[] { 1000, 500, 35809, 843120, 89000};
            Salis salis1 = new Salis("Lietuva", "Gitanas Nauseda", 65300, 2800000, 800, populiacija1);
            salis1.Informacija();
            salis1.Masyvas(populiacija1);
            Console.WriteLine();
            int[] populiacija2 = new int[] { 658, 5000, 35809, 843120, 89000 };
            Salis salis2 = new Salis("Estija", "Alar Karis", populiacija2);
            salis2.Informacija();
            salis2.Masyvas(populiacija2);
            Console.WriteLine();
            int[] populiacija3 = new int[] { -320, 5000, 7000, -6800, -3523 };
            Salis salis3 = new Salis("Latvija", 64589, populiacija3);
            salis3.Informacija();
            salis3.Masyvas(populiacija3);
            Console.WriteLine();
            int[] populiacija4 = new int[] { 4579, 5000, 35809, 843120, 89000 };
            Salis salis4 = new Salis("Lenkija", 38000000, 1700, populiacija4);
            salis4.Informacija();
            salis4.Masyvas(populiacija4);
        }
    }
}
