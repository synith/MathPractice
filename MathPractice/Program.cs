// See https://aka.ms/new-console-template for more information

Random random = new Random();

int firstNumber;
int secondNumber;
float thirdNumber;

float sum;
float sumRoundWhole;

decimal sumDecimal;
double sumDouble;

int roundFloorNumber;
int roundCeilingNumber;

Console.WriteLine("Press any key to continue.\nPress ESC to exit.\n");
while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
{
    RandomizeNumbers();

    sum = AddThreeNumbersIntoFloat(firstNumber, secondNumber, thirdNumber);
    WriteSum();

    CreateDifferentTypesFromSum();
    RoundNumbers();
    WriteRoundedNumbers();
    Console.WriteLine("Press any key to continue.\nPress ESC to exit.\n");
}

void RandomizeNumbers()
{
    firstNumber = random.Next(0, 11);
    secondNumber = random.Next(0, 11);
    thirdNumber = random.Next(0, 11) + random.NextSingle();
}
float AddThreeNumbersIntoFloat(int firstNumber, int secondNumber, float thirdNumber)
{
    sum = firstNumber + secondNumber + thirdNumber;
    return sum;
}
void WriteSum()
{
    Console.WriteLine($"float sum = {firstNumber} + {secondNumber} + {thirdNumber} = {sum}\n");
}
void CreateDifferentTypesFromSum()
{
    sumDecimal = ((decimal)sum);
    sumDouble = ((double)sum);
}
void RoundNumbers()
{
    sumDouble = Math.Round(sumDouble);
    sumDecimal = Math.Round(sumDecimal, 3);
    sumRoundWhole = MathF.Round(sum);
    roundCeilingNumber = (int)MathF.Ceiling(sum);
    roundFloorNumber = (int)MathF.Floor(sum);
}
void WriteRoundedNumbers()
{    
    Console.WriteLine("Math.Round for a double with no specified amount of digits = " + sumDouble);
    Console.WriteLine("Math.Round for a decimal to 3 digits = " + sumDecimal);    
    Console.WriteLine("Ceiling of sum = " + roundCeilingNumber);
    Console.WriteLine("Floor of sum = " + roundFloorNumber);
    Console.WriteLine("MathF.Round for a float with no specified amount of digits = " + sumRoundWhole + "\n");
}