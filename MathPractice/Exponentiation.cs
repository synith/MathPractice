using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class Exponentiation
    {
        int baseNumber;
        int exponentNumber;
        int result;

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

                if (int.TryParse(Console.ReadLine(), out int num))
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

                if (int.TryParse(Console.ReadLine(), out int num))
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
            result = (int)Math.Pow(baseNumber, exponentNumber);
            Console.WriteLine($"{baseNumber} to the power of {exponentNumber} is {result}");
        }
    }
}
