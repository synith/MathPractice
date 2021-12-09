using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class NthRoot
    {
        float x;
        float n;
        float result;

        public void NthRootExample()
        {
            Console.WriteLine("Enter x and n to find the nth root of x....\n");
            x = ValueRequest.AskForValueFloat("x");
            n = ValueRequest.AskForValueFloat("n");
            CalculateResults();
        }
        private void CalculateResults()
        {
            result = MathF.Pow(x, 1/n);
            result = MathF.Round(result, 4);
            if (result % 1 == 0)
            {
                result = MathF.Round(result);
            }
            Console.WriteLine($"The {n} root of {x} is {result}");
        }
    }
}
