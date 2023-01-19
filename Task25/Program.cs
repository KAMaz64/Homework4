/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Clear();

int Pow(int Number, int Degree)
{
    if(Degree == 0) return 1;

    int Solution = Number;
    for (int i = 2; i <= Degree; i++)
    {
        Solution *= Number;        
    }
    return Solution;
}

Console.Write("Input random integer number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input random positive integer degree: ");
int D = Convert.ToInt32(Console.ReadLine());

if (D < 0)
{
    Console.Write("Data error: Degree (power) must be positive integer");
}

else
{
    Console.WriteLine($"{N} to the power of {D} equals {Pow(N,D)}");
}
