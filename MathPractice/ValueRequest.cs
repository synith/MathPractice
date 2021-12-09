using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal static class ValueRequest
    {
        public static float AskForValueFloat(string valueString)
        {
            float value = 0f;
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine($"{valueString} =");

                if (float.TryParse(Console.ReadLine(), out float num))
                {
                    Console.WriteLine($"You've entered {num} as the {valueString} value\n");
                    value = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }
            return value;
        }
        public static int AskForValueInt(string valueString) 
        {
            int value = 0;
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine($"{valueString} =");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine($"You've entered {num} as the {valueString} value\n");
                    value = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }
            return value;
        }
    }
}
