using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    using static ValueRequest;
    internal class SinCosTan
    {
        public void SinCosTanExample()
        {
            Console.WriteLine("Enter your angle in radians to find the sine, cosine and tangent of your angle\n");
            float angleRad = AskForValueFloat("angle");
            float sin = MathF.Sin(angleRad);
            float cos = MathF.Cos(angleRad);
            float tan = MathF.Tan(angleRad);

            Console.WriteLine(
                $"sin({angleRad}) = {sin}\n" + 
                $"cos({angleRad}) = {cos}\n" + 
                $"tan({angleRad}) = {tan}\n");
        }
    }
}
