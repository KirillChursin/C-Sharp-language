// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int leng(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void random(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 100);
        }
    }
}
void print(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}
void seeker(int[,] arg, int arg2)
{
    int count = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (arg[i, j] == arg2)
            {
                Console.WriteLine($"The desired number have in array, by index [{i},{j}]");
                count ++;
                break;
            }
            
        }
    }
    if (count == 0 )
    {
        Console.WriteLine($"Array does not contain the number you are looking for");
    }
}

int lenColumn = leng($"Enter column size");
int lenString = leng($"Enter line size");
int[,] array = new int[lenString, lenColumn];
random(array);
print(array);
int find = leng($"Enter number you want find = ");
seeker(array, find);
