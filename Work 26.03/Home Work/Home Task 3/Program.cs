// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int leng(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void random(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 100);
        }
    }
}
void print(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.Write("}");
        Console.WriteLine();
    }
}
void average(double[,] arg)
{
    for (int j = 0; j < arg.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            result = result + arg[i, j];
        }
        result = Math.Round(result / arg.GetLength(0), 1);
        Console.Write($"{result} ");
    }

}





int lenColumn = leng($"Enter column size");
int lenString = leng($"Enter line size");
Console.WriteLine();
double[,] array = new double[lenString, lenColumn];
random(array);
print(array);
Console.WriteLine();
Console.WriteLine($"Column average");
average(array);
