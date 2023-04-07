// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillArrayRandom(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 10);
        }
    }
}

void FillArrayDescendingOrder(int[,] arg, int[,] arg2)
{
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            int result = 0;
            for (int j = 0; j < arg.GetLength(1); j++)
            {
                result = result + arg[i, j];
                arg2[i,0] = result;
            }
            
        }
}

void PrintNewArray(int[,] arg, int[,] arg2)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.Write($"= {arg2[i,0]}");
        Console.WriteLine();
    }
}

int MinimumArayElementIndex (int[,] arg)
{
    int min = arg[0,0];
    int minRow = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (arg[i, j] < min)
            {
                min = arg[i, j];
                minRow = i;
            }
        }
    }
    return minRow;
}



Console.WriteLine();
int[,] array = new int[5, 4];
int[,] NewArray = new int[5, 1];
FillArrayRandom(array);
Console.WriteLine();
FillArrayDescendingOrder(array, NewArray);
PrintNewArray(array, NewArray);
Console.WriteLine();
Console.WriteLine($"minimum summ elements in row {MinimumArayElementIndex(NewArray)}");

