// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int IntervalNaturalNumbers (int arg)
{
    Console.Write($"{arg} ");
    if (arg == 1) return 1;
    else return arg - IntervalNaturalNumbers(arg - 1);
}
Console.WriteLine($"Enter natural number");
int number = Convert.ToInt32(Console.ReadLine());
IntervalNaturalNumbers(number);