using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedstestTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result = i * 7;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
