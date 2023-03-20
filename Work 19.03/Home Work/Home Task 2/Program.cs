// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



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
        arg[i] = new Random().Next(1, 10);
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
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (i % 2 == 0)
        {
            result = result + arg[i];
        }
    }
     return result; 
}

int length = message($"Enter array length number");
int[] array = new int [length];
random(array);
Console.Write.Line();
print(array);
int sumElementEvenPos = even(array);
Console.WriteLine($"Sum elements even index position = {sumElementEvenPos}");
Console.Write.Line();
