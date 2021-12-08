﻿using MathPractice;

RequestAnyKey();
while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
{
    Console.WriteLine(
        "Press 1 to enter Rounding Example.\n" +
        "Press 2 to enter Remainder Example.\n" +
        "Press 3 to enter Exponent Example.\n" +
        "Press 4 to enter nth Root Example.\n" +
        "Press 5 to enter Logarithm Example.\n" +
        "Press 6 to enter Factorials, Permutations and Combinations Example.\n" +
        "Press ESC to Exit.\n");
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.Escape:
            return;
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
            RequestAnyKey();
            break;
        case ConsoleKey.D4:
            Console.Write("\n");
            NthRoot nthRoot = new NthRoot();
            nthRoot.NthRootExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D5:
            Console.Write("\n");
            Logarithm logarithm = new Logarithm();
            logarithm.LogExample();
            RequestAnyKey();
            break;
        case ConsoleKey.D6:
            Console.Write("\n");
            FactorialsPermutationsCombinationsMenu();
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
            "Press 1 to enter Factorials Example.\n" +
            "Press 2 to enter Permutations Example.\n" +
            "Press 3 to enter Combinations Example.\n" +
            "Press ESC to Exit.\n");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Escape:
                Console.WriteLine("\nYou've returned to the main menu...");
                return;
            case ConsoleKey.D1:
                Console.Write("\n");
                // Factorial example
                RequestAnyKey();
                break;
            case ConsoleKey.D2:
                Console.Write("\n");
                // Permutations example
                RequestAnyKey();
                break;
            case ConsoleKey.D3:
                Console.Write("\n");
                // Combinations example
                RequestAnyKey();
                break;
            default:
                break;
        }
    }
    Console.WriteLine("\nYou've returned to the main menu...");
}