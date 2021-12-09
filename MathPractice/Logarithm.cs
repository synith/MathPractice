using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class Logarithm
    {
        float x;
        float b;
        float result;

        public void LogExample()
        {
            Console.WriteLine("Enter x and b to find the value of Log x base b...\n");
            x = ValueRequest.AskForValueFloat("x");
            b = ValueRequest.AskForValueFloat("b");
            CalculateResults();
        }        
        private void CalculateResults()
        {
            result = MathF.Log(x,b);
            result = MathF.Round(result, 4);
            if (result % 1 == 0)
            {
                result = MathF.Round(result);
            }
            Console.WriteLine($"The value of log {x} base {b} is {result}");
        }
    }
}

