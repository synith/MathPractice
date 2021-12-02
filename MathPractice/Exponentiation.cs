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
            AskForBase();
            AskForExponent();
            CalculateResults();
        }
        void AskForBase()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("Enter the base number...");

                if (float.TryParse(Console.ReadLine(), out float num))
                {
                    Console.WriteLine($"You entered {num} as the base\n");
                    baseNumber = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }

        }
        void AskForExponent()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("Enter the exponent number...");

                if (float.TryParse(Console.ReadLine(), out float num))
                {
                    Console.WriteLine($"You entered {num} as the exponent\n");
                    exponentNumber = num;
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
            result = MathF.Pow(baseNumber, exponentNumber);
            Console.WriteLine($"{baseNumber} to the power of {exponentNumber} is {result}");
        }
    }
}
