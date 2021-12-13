using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    using static ValueRequest;
    internal class FirstOuterInnerLast
    {
        float a;
        float b;
        float c;
        float d;

        public void FoilExample()
        {
            Console.WriteLine("Enter a,b,c,d to calculate (ax+b)(cx+d)\n");
            a = AskForValueFloat("a");
            b = AskForValueFloat("b");
            c = AskForValueFloat("c");
            d = AskForValueFloat("d");
            CalculateResult();
        }

        private void CalculateResult()
        {
            float first = a * c;
            float outer = a * d;
            float inner = b * c;
            float last = b * d;

            Console.WriteLine($"{first}x^2 + {outer + inner}x + {last}");
        }
    }
}
