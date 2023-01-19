/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Clear();

int DigitSum(int Number)
{
    int SumOfDigits = 0;
    int ModNumber = Math.Abs(Number);
    while(ModNumber > 0)
    {
        SumOfDigits += ModNumber % 10;
        ModNumber /= 10;
    }
    return SumOfDigits;
}

Console.Write("Input random integer number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits of {N} equals {DigitSum(N)}");
