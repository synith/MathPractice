using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    using static ValueRequest;
    internal class DegRadConverter
    {
        public void DegRadConverterExample()
        {
            Console.WriteLine(
                "1.) Convert from Degrees to Radians\n" +
                "2.) Convert from Radians to Degrees\n");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    ConvertDegToRad();
                    break;
                case ConsoleKey.D2:
                    ConvertRadToDeg();
                    break;
                default:
                    break;
            }
        }
        void ConvertDegToRad()
        {
            float angleDeg = AskForValueFloat("Angle in Degrees");
            float angleRad = angleDeg * MathF.PI / 180;
            Console.WriteLine($"{angleDeg} degrees is equal to {angleRad} radians.");
        }
        void ConvertRadToDeg()
        {
            float angleRad = AskForValueFloat("Angle in Radians");
            float angleDeg = angleRad * 180 / MathF.PI;
            Console.WriteLine($"{angleRad} radians is equal to {angleDeg} degrees.");
        }
    }
}
