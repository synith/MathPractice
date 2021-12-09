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
            n = ValueRequest.AskForValueInt("n");
            k = ValueRequest.AskForValueInt("k");
            CalculateResults();
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
