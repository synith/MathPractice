using MathPractice;

RequestAnyKey();
while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
{
    Console.WriteLine(
        "Press 1 to enter Rounding Example.\n" +
        "Press 2 to enter Remainder Example.\n" +
        "Press 3 to enter Exponent Example.\n" + 
        "Press ESC to Exit.\n");
    switch (Console.ReadKey(true).Key)
    {        
        case ConsoleKey.D1:
            Console.Write("\n");
            Rounding rounding = new Rounding();
            rounding.RoundingExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D2:
            Console.Write("\n");
            Remainder remainder = new Remainder();
            remainder.RemainderExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D3:
            Console.Write("\n");
            Exponentiation exponentiation = new Exponentiation();
            exponentiation.ExponentiationExample();
            // Exponent example here
            RequestAnyKey();
            break;
        default:
            break;
    }
}

void RequestAnyKey() => Console.WriteLine("\nPress any key to continue.\nPress ESC to exit.\n");
