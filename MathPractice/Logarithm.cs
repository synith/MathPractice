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
            AskForX();
            AskForB();
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
        void AskForB()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("b =");

                if (float.TryParse(Console.ReadLine(), out float num))
                {
                    Console.WriteLine($"You've entered {num} as the b value\n");
                    b = num;
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

