using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedstestFem
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jesper", "K", new DateTime(1997, 10, 29));
            Console.WriteLine(person1);
            Console.ReadKey();
        }
    }
}
