using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    /// <summary>
    /// Provides static methods for requesting values from <see cref="Console"/>.
    /// </summary>
    internal static class ValueRequest
    {

        /// <summary>
        /// Writes in console requesting a value named <paramref name="valueName"/> to be entered.
        /// </summary>
        /// <param name="valueName">The name of the value being requested.</param>
        /// <returns>The value read from console.</returns>
        public static float AskForValueFloat(string valueName)
        {
            float value = 0f;
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine($"{valueName} =");

                if (float.TryParse(Console.ReadLine(), out float num))
                {
                    Console.WriteLine($"You've entered {num} as the {valueName} value\n");
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

        /// <summary>
        /// Writes in console requesting a value named <paramref name="valueName"/> to be entered.
        /// </summary>
        /// <param name="valueName">The name of the value being requested.</param>
        /// <returns>The value read from console.</returns>
        public static int AskForValueInt(string valueName) 
        {
            int value = 0;
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine($"{valueName} =");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine($"You've entered {num} as the {valueName} value\n");
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
