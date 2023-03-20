//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
        arg[i] = new Random().Next(100, 1000);
    }
}

void print(int[] arg)
{
    Console.Write($"[");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine($"]");
}

int even (int[] arg)
{
    string text = "Array dont have even numbers = ";
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] % 2 == 0)
        {
            result++;
            text = $"Sum even numbers in array = ";
        }
    }
    Console.Write(text);
     return result; 
}

int length = message($"Enter array length number");
int[] array = new int [length];
random(array);
print(array);
int sumEvenElementArray = even(array);
Console.WriteLine($"{sumEvenElementArray}");
