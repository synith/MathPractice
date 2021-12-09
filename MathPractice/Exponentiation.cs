using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    using static ValueRequest;
    internal class Exponentiation
    {
        float baseNumber;
        float exponentNumber;
        float result;

        public void ExponentiationExample()
        {
            baseNumber = AskForValueFloat("base");
            exponentNumber = AskForValueFloat("exponent");
            CalculateResults();
        }       
        private void CalculateResults()
        {
            result = MathF.Pow(baseNumber, exponentNumber);
            Console.WriteLine($"{baseNumber} to the power of {exponentNumber} is {result}");
        }
    }
}
