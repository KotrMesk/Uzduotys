using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą
             * Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
             * Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną
             */
            Program p = new Program();
            Console.WriteLine($"Suma: {p.Suma(45, 32, 18)}");
            Console.WriteLine($"Dalyba: {p.Dalmuo(32, 86)}");


            
        }

        private int Suma(int parametras1, int parametras2, int parametras3)
        {
            return parametras1 + parametras2 + parametras3;
        }

        private double Dalmuo(double parametras1, double parametras2)
        {
            return parametras1 / parametras2;
        }
    }
}
