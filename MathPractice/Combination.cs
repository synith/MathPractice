using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class Combination
    {
        int n;
        int k;
        BigInteger result;

        public void CombinationExample()
        {
            Console.WriteLine("Enter n and k as whole numbers to find C(n,k)....\n");
            AskForN();
            AskForK();
            CalculateResults();
        }
        void AskForN()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("n =");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine($"You've entered {num} as the n value\n");
                    n = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }
        }
        void AskForK()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("k =");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine($"You've entered {num} as the k value\n");
                    k = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }
        }
        private void CalculateResults()
        {
            Factorial factorial = new();

            result = factorial.CalculateFactorial(n) / (factorial.CalculateFactorial(n - k) * factorial.CalculateFactorial(k));
            result.ToString("E");
            Console.WriteLine($"C({n},{k}) = {result}");
        }
    }
}
