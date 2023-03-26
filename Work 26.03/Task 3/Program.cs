// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int leng(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void random (double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = Convert.ToDouble(new Random().Next(1,100));
        }
    }
}
void print (double[,] arg)
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

void change (double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arg[i,j] = Math.Pow(arg[i,j], 2);
            }
        }
    }
}


int lenColumn = leng($"Задайте длинну столбцов");
int lenString = leng($"Задайте длинну строк массива");
double[,] array = new double [lenString,lenColumn];
random(array);
print(array);
change(array);
Console.WriteLine();
print(array);
