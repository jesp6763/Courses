using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedstestTre
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool hasWon = false;
            int guessedNumber = -1;
            int numberToGuess = rnd.Next(1, 10);

            while (!hasWon)
            {
                Console.WriteLine("Gæt et tal mellem 1 og 10");
                if(int.TryParse(Console.ReadLine(), out guessedNumber))
                {
                    if (guessedNumber > 10 || guessedNumber < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Du skal skrive et tal mellem 1 og 10");
                    }
                    else if (guessedNumber == numberToGuess)
                    {
                        hasWon = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Desværre, det var ikke det rigtige tal.");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Det skal være tal, ikke bogstaver");
                }
            }
        }
    }
}

// Brugeren skal gætte et tal mellem 1 og 10.
// Hvis man gætter forkert skal brugeren få vist en fejlbesked.
// Programmet skal afsluttes når brugeren har gættet rigtigt
