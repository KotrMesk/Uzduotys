using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Į ekraną išveskite kelis sunumeruotus pasirinkimus
             * 1 - stacionarus kompiuteris
             * 2 - nešiojamas kompiuteris
             * 3 - planšetė 
             */

            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nešiojamas kompiuteris");
            Console.WriteLine("3 - planšetė");

            //Liepkite vartotojui įvesti pasirinkimo numerį. 

            Console.WriteLine("Pasirinkite numeri (1, 2 arba 3): ");

            /*Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz:
             * nešiojamuoju kompiuteriu galite naudotis visur
             * stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
             * planšete galite naudotis visur
             */

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                    break;
                case "2":
                    Console.WriteLine("nešiojamuoju kompiuteriu galite naudotis visur");
                    break;
                case "3":
                    Console.WriteLine("planšete galite naudotis visur");
                    break;
            //Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }



        }
    }
}
