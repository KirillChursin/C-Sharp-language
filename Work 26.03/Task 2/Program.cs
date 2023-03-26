// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int sumEl(int[,]arg)
{
    int result = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (i == j)
            {
                result += arg[i,j];
            }
        }
    }
    return result;
}
int leng(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void random (int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,100);
        }
    }
}
void print (int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i,j]} ");
        }
        Console.WriteLine();
    }
}

int lenColumn = leng($"Enter column size");
int lenString = leng($"Enter line size");
int[,] array = new int [lenString,lenColumn ];
random(array);
print(array);
int x = sumEl(array);
Console.WriteLine();
Console.Write($"The sum of the elements on the main diagonal = {x}");

