using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sukurkite bazinę klasę Gyvunas su protected kintamaisiais ir paveldinčia klasę Gyvate. 
             * Paveldinčioje klasėje turi būti metodas, kuris išveda visus klasės  kintamuosius į ekraną.
             * Bazinės klasės konstruktorių panaudokite paveldinčioje klasėje.
             * Išveskite paveldinčios klasės kintamuosius į ekraną.
             */

            Gyvunas gyvunas1 = new Gyvunas("Suo", 3);
            Gyvate gyvunas2 = new Gyvate("Gyvate", 1, "melyna");
           
            gyvunas2.Informacija();

        }
    }
}
