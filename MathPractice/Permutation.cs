using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    using static ValueRequest;
    internal class Permutation
    {
        int n;
        int k;
        BigInteger result;

        public void PermutationExample()
        {
            Console.WriteLine("Enter n and k as whole numbers to find P(n,k)....\n");
            n = AskForValueInt("n");
            k = AskForValueInt("k");
            CalculateResults();
        }        
        private void CalculateResults()
        {
            Factorial factorial = new();

            result = factorial.CalculateFactorial(n) / factorial.CalculateFactorial(n - k);
            string resultString = result >= 1000000 ? result.ToString("E") : result.ToString("N0");
            Console.WriteLine($"P({n},{k}) = {resultString}");
        }
    }
}
