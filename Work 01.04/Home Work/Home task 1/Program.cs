// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ArraySize(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArrayRandom(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 15);
        }
    }
}

void PrintArray(int[,] arg)
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

void FillArrayDescendingOrder(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1)-1; j++)
        {
            for (int m = j+1; m < arg.GetLength(1); m++)
            {
                if (arg[i, j] < arg[i, m])
                {
                    int temp = arg[i, j];
                    arg[i, j] = arg[i, m];
                    arg[i, m] = temp;
                }
            }

        }
    }
}

int lenColumn = ArraySize($"Enter column size");
int lenRow = ArraySize($"Enter line size");
Console.WriteLine();
int[,] array = new int[lenRow, lenColumn];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
FillArrayDescendingOrder(array);
PrintArray(array);

