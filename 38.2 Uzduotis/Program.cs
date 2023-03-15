using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38._2_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*nusikopijuokite praeitos užduoties kodą į naują projektą.
             * Base klasėje parašykite virtualų išvedimo metodą.
             * Paveldinčioje klasėje pakeiskite esamą išvedimo metodą, kad jis override‘intu base klasės virtual metodą.
             * Base klasėje sukurkite private const kintamąjį, kadangi jo negalima pasiekti  už klasės ribų – base klasėje sukurkite public metodą, 
             * kuris išspausdina  private const kintamąjį. Panaudoję šį metodą, iškvieskite jį paveldinčios klasės išvedimo metode.
             */

            Gyvunas gyvunas1 = new Gyvunas("Suo", 3);
            Gyvate gyvunas2 = new Gyvate("Gyvate", 1, "melyna");

            gyvunas2.Informacija();


        }
    }
}
