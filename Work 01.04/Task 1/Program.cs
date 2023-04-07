// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.




int ArraySize(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void FillArrayRamnom(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 100);
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

void ChangeString(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = i + 1; j < arg.GetLength(1); j++)
        {
            int temp = arg[i, j];
            arg[i, j] = arg[j, i];
            arg[j, i] = temp;
        }
    }
}

int lenColumn = ArraySize($"Enter column size");
int lenRow = ArraySize($"Enter line size");
int[,] array = new int[lenRow, lenColumn];
FillArrayRamnom(array);
PrintArray(array);
Console.WriteLine();
if (lenRow != lenColumn) Console.WriteLine($"Unable to replace rows and columns");
else 
{
    ChangeString(array);
    PrintArray(array);
}
