//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76


int message(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void random(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(1, 50);
    }
}

void print(int[] arg)
{
    Console.Write($"[ ");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine($"]");
}

int Max(int[] arg)
{
    int max = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] > arg[max]) max = i;
    }
    return arg[max];
}

int Min(int[] arg)
{
    int min = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] < arg[min]) min = i;
    }
    return arg[min];
}

int difference (int arg1, int arg2)
{
    int result = 0;
    if (arg2 > arg1)
    {
        result = arg2 - arg1;
    }
    if (arg2 < arg1)
    {
        result = arg1 -arg2;
    }
    return result;
}

Console.WriteLine();
int length = message($"Enter array length number");
int[] array = new int[length];

Console.WriteLine();
random(array);
print(array);

Console.WriteLine();
int max = Max(array);
int min = Min(array);
Console.WriteLine($"array max element = {max}");

Console.WriteLine();
Console.WriteLine($"array min element = {min}");

Console.WriteLine();
Console.WriteLine($"Difference between maximum and minimum value = {difference(min, max)}");

Console.WriteLine();
