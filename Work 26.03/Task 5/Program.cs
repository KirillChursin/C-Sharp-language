// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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
void turn (int[,] arg)
{
    int length = arg.GetLength(0)-1;
    for (int j = 0; j < arg.GetLength(1); j++)
    {
        int temp = arg[0,j];
        arg[0,j] = arg[length,j];
        arg[length,j] = temp;
    }
}

int lenColumn = leng($"Enter column size");
int lenString = leng($"Enter line size");
int[,] array = new int [lenString,lenColumn ];
random(array);
print(array);
Console.WriteLine();
turn(array);
print(array);
