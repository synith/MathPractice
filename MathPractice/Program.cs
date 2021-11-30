// See https://aka.ms/new-console-template for more information



using MathPractice;

RequestAnyKey();
while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
{
    Console.WriteLine("Press 1 to enter Rounding Example.\nPress 2 to enter Remainder Example.\nPress ESC to Exit.\n");
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
        default:
            break;
    }
}

void RequestAnyKey() => Console.WriteLine("\nPress any key to continue.\nPress ESC to exit.\n");
