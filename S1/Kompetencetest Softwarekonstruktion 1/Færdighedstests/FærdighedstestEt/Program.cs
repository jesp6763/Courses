using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedstestEt
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = string.Empty;
            string efternavn = string.Empty;
            Console.WriteLine("Skriv dit fornavn: ");
            fornavn = Console.ReadLine();

            Console.WriteLine("Skriv dit efternavn");
            efternavn = Console.ReadLine();

            Console.WriteLine(string.Format("Du hedder {0} {1}", fornavn, efternavn));
            Console.ReadKey();
        }
    }
}
