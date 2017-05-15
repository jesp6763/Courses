using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedstestFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string calcString = Console.ReadLine();
            string[] split = calcString.Split(' ');
            int num1 = int.Parse(split[0]);
            string calcType = split[1];
            int num2 = int.Parse(split[2]);

            Console.WriteLine(string.Format("Result: {0}", Calculate(num1, num2, calcType)));
            Console.ReadKey();
        }

        // Ansvar for at beregne +, -, *, / og % af to tal som brugeren har indtastet
        private static float Calculate(float a, float b, string calcType)
        {
            float result = 0;

            switch (calcType)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "%":
                    result = a % b;
                    break;
            }

            return result;
        }
    }
}
