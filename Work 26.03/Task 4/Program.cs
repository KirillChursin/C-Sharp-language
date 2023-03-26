// Задайте двухмерный массив размеров M x N.
// Каждый элемент массива находится по формуле A[M,N] = M+N;

// M = 3, N = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int leng(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void random (double[,] arg)
{
    for (int m = 0; m < arg.GetLength(0); m++)
    {
        for (int n = 0; n < arg.GetLength(1); n++)
        {
            arg[m,n] = m + n;
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


int lenString = leng($"Enter line size");
int lenColumn = leng($"Enter column size");
double[,] array = new double [lenString,lenColumn ];
random(array);
print(array);

