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
            xValue = ValueRequest.AskForValueInt("x");
            ConvertX();
        }        
        private void ConvertX()
        {
            string binaryValue = Convert.ToString(xValue, 2);
            string hexValue = Convert.ToString(xValue, 16);
            Console.WriteLine($"{xValue} converted to \nbinary is {binaryValue}\nhexadecimal is {hexValue}");
        }
    }
}
