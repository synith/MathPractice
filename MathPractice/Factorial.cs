using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class Factorial
    {
        int n;
        BigInteger result;

        public void FactorialExample()
        {
            Console.WriteLine("Enter n as a whole number to find the value of n!...\n");
            AskForN();
            WriteResults();
        }
        public BigInteger CalculateFactorial(int n)
        {
            BigInteger result = n;
            while (n > 1)
            {
                result *= (n - 1);
                n--;
            }
            return result;
        }
        void AskForN()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("n =");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine($"You've entered {num} as n\n");
                    n = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }
        }
        private void WriteResults()
        {
            int m = n;
            result = CalculateFactorial(n);
            
            Console.WriteLine($"The value of {m}! is {result.ToString("E")}");
        }
    }
}
