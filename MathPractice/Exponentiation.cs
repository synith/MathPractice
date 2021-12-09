using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class Exponentiation
    {
        float baseNumber;
        float exponentNumber;
        float result;

        public void ExponentiationExample()
        {
            baseNumber = ValueRequest.AskForValueFloat("base");
            exponentNumber = ValueRequest.AskForValueFloat("exponent");
            CalculateResults();
        }       
        private void CalculateResults()
        {
            result = MathF.Pow(baseNumber, exponentNumber);
            Console.WriteLine($"{baseNumber} to the power of {exponentNumber} is {result}");
        }
    }
}
