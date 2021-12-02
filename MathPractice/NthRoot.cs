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
            AskForX();
            AskForN();
            CalculateResults();
        }
        void AskForX()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("x =");

                if (float.TryParse(Console.ReadLine(), out float num))
                {
                    Console.WriteLine($"You've entered {num} as the x value\n");
                    x = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }
        }
        void AskForN()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("n =");

                if (float.TryParse(Console.ReadLine(), out float num))
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
