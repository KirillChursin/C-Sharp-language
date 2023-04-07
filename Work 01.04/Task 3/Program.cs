// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int MinimumElement(int[,] arg)
{
    int min = arg[0,0];
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (arg[i, j] < min)
            {
                min = arg[i, j];
            }
        }
    }
    return min;
}
int MinimumElementPositionRow(int[,] arg)
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
int MinimumElementPositionColumn(int[,] arg)
{
    int min = arg[0,0];
    int minColumn = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (arg[i, j] < min)
            {
                min = arg[i, j];
                minColumn = j;
            }
        }
    }
    return minColumn;
}

void CopyElement(int[,] oldArray, int[,] newArray)
{
    for (int i = 0; i < oldArray.GetLength(0); i++)
    {
        for (int j = 0; j < oldArray.GetLength(1); j++)
        {
            {
                if (i != MinimumElementPositionRow(oldArray) && j != MinimumElementPositionColumn(oldArray))
                {
                    newArray[i,j] = oldArray[i,j];
                }
            }
        }
    }
}

void PrintNewArray (int[,] arg, int[,] oldArray)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (arg[i,j] != 0)
            {
                Console.Write($"{arg[i,j]} ");
            }
        }
        if (i != MinimumElementPositionRow(oldArray))
        {
            Console.WriteLine();
        }
    }
}

int lenColumn = ArraySize($"Enter column size");
int lenRow = ArraySize($"Enter line size");
int[,] array = new int[lenRow, lenColumn];
int[,] DeleteMinimumElementRowColumn = new int[lenRow, lenColumn];
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
MinimumElement(array);
Console.WriteLine(MinimumElement(array));
MinimumElementPositionRow(array);
MinimumElementPositionColumn(array);
CopyElement(array, DeleteMinimumElementRowColumn);
Console.WriteLine();
PrintNewArray(DeleteMinimumElementRowColumn, array);
