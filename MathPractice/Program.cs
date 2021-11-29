// See https://aka.ms/new-console-template for more information

int firstNumber = 1;
int secondNumber = 20;
float thirdNumber = 3.42f;

float sum = firstNumber + secondNumber + thirdNumber;
decimal sumDecimal = ((decimal)sum);
double sumDouble = ((double)sum);
Console.WriteLine($"{firstNumber} + {secondNumber} + {thirdNumber} = {sum}");
sumDouble = Math.Round(sumDouble);
sumDecimal = Math.Round(sumDecimal, 1);
sum = MathF.Round(sum);
Console.WriteLine("Math.Round for a double with no specified amount of digits = " + sumDouble);
Console.WriteLine("Math.Round for a decimal to 1 digit = " + sumDecimal);
Console.WriteLine("MathF.Round for a float = " + sum);