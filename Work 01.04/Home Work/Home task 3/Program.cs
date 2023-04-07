// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MatrixProduct(int[,] arg1, int[,] arg2, int[,] arg3)
{
    for (int i = 0; i < arg1.GetLength(0); i++)
    {
        for (int j = 0; j < arg2.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < arg1.GetLength(1); k++)
            {
                result += arg1[i, k] * arg2[k, j];
            }
            arg3[i, j] = result;
        }
    }
}


int lenRow = ArraySize($"Enter line size");
int lenColumn = ArraySize($"Enter column size");
int[,] MatrixA = new int[lenRow, lenColumn];
int[,] MatrixB = new int[lenRow, lenColumn];
int[,] MatrixResult = new int[lenRow, lenColumn];
FillArrayRandom(MatrixA);
FillArrayRandom(MatrixB);
MatrixProduct(MatrixA, MatrixB, MatrixResult);
PrintArray(MatrixA);
Console.WriteLine();
PrintArray(MatrixB);
Console.WriteLine();
PrintArray(MatrixResult);

