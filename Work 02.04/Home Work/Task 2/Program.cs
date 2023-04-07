// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumIntervalNumbers (int arg1, int arg2)
{
    if(arg1 <= arg2 && arg1 > 0)
    {
        Console.WriteLine($"{arg1}");
        if (arg2 == arg1) return arg2; 
        else return arg1 + SumIntervalNumbers(arg1+1, arg2);
    }
    else return -1;
}

Console.WriteLine($"Enter first number");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter second number");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumIntervalNumbers(FirstNumber, SecondNumber)}");

