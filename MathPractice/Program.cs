using MathPractice;

RequestAnyKey();
while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
{
    Console.WriteLine(
        "Press 1 to enter Rounding example.\n" +
        "Press 2 to enter Remainder example.\n" +
        "Press 3 to enter Exponent calculator.\n" +
        "Press 4 to enter nth Root calculator.\n" +
        "Press 5 to enter Logarithm calculator.\n" +
        "Press 6 to enter Factorials, Permutations and Combinations calculator.\n" +
        "Press 7 to enter Number Bases calculator.\n" +
        "Press 8 to enter FOIL calculator.\n" +
        "Press ESC to Exit.\n");
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.Escape:
            break;
        case ConsoleKey.D1:
            Console.Write("\n");
            Rounding rounding = new();
            rounding.RoundingExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D2:
            Console.Write("\n");
            Remainder remainder = new();
            remainder.RemainderExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D3:
            Console.Write("\n");
            Exponentiation exponentiation = new();
            exponentiation.ExponentiationExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D4:
            Console.Write("\n");
            NthRoot nthRoot = new();
            nthRoot.NthRootExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D5:
            Console.Write("\n");
            Logarithm logarithm = new();
            logarithm.LogExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D6:
            Console.Write("\n");
            FactorialsPermutationsCombinationsMenu();
            RequestAnyKey();
            break;
        case ConsoleKey.D7:
            Console.Write("\n");
            NumberBases numberBases = new();
            numberBases.NumberBaseExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D8:
            Console.Write("\n");
            // FOILExample
            RequestAnyKey();
            break;
        default:
            break;
    }
}

void RequestAnyKey() => Console.WriteLine("\nPress any key to continue.\nPress ESC to exit.\n");

void FactorialsPermutationsCombinationsMenu()
{
    Console.WriteLine("You've entered the Factorials, Permutations and Combinations sub-menu.");
    RequestAnyKey();
    while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
    {
        Console.WriteLine(
            "Press 1 to enter Factorials calculator.\n" +
            "Press 2 to enter Permutations calculator.\n" +
            "Press 3 to enter Combinations calculator.\n" +
            "Press ESC to Exit.\n");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Escape:
                Console.WriteLine("\nYou've returned to the main menu...");
                return;
            case ConsoleKey.D1:
                Console.Write("\n");
                Factorial factorial = new();
                factorial.FactorialExample();
                RequestAnyKey();
                break;
            case ConsoleKey.D2:
                Console.Write("\n");
                Permutation permutation = new();
                permutation.PermutationExample();
                RequestAnyKey();
                break;
            case ConsoleKey.D3:
                Console.Write("\n");
                Combination combination = new();
                combination.CombinationExample();
                RequestAnyKey();
                break;
            default:
                break;
        }
    }
    Console.WriteLine("\nYou've returned to the main menu...");
}