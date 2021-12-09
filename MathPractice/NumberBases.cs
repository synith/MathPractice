using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class NumberBases
    {
        int xValue;

        public void NumberBaseExample()
        {
            Console.WriteLine("Enter x as a whole number to have it converted to binary and hexadecimal.");
            AskForX();
            ConvertX();
        }
        void AskForX()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine("x =");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine($"You've entered {num} as the x value\n");
                    xValue = num;
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("invalid entry, please try again");
                }
            }
        }
        private void ConvertX()
        {
            string binaryValue = Convert.ToString(xValue, 2);
            string hexValue = Convert.ToString(xValue, 16);
            Console.WriteLine($"{xValue} converted to \nbinary is {binaryValue}\nhexadecimal is {hexValue}");
        }
    }
}
