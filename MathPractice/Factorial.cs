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
            n = ValueRequest.AskForValueInt("n");
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
        private void WriteResults()
        {
            int m = n;
            result = CalculateFactorial(n);
            string resultString = result >= 1000000 ? result.ToString("E") : result.ToString("N0");
            Console.WriteLine($"The value of {m}! is {resultString}");
        }
    }
}
