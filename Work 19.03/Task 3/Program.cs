// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да





int message (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void random (int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(-9, 10);
    }
}

void seeker (int[] arg, int find)
{
    string text = "No";
    
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] == find)
        {
            text = "Yes";
            break;
        }
    }
    Console.WriteLine($"{text}");

    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] == find)
        {
            Console.WriteLine($"Search number index = {i}");
            break;
        }
    }
}

void print (int[] arg)
{
    Console.Write($"[");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine($"]");
}

int arrayLength = message($"Enter array length number");
int[] array = new int[arrayLength];
random(array);
print(array);
int find = message($"Enter the number you want to search");
seeker(array, find);

