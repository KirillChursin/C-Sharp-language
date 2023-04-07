// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int UserValue(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                int num = new Random().Next(10, 100);
                while (CheckNewNumber(arg, num))
                {
                    num = new Random().Next(10, 100);
                }
                arg[i, j, k] = num;
            }
        }
    }
}

bool CheckNewNumber(int[,,] arg1, int num)
{
    for (int i = 0; i < arg1.GetLength(0); i++)
    {
        for (int j = 0; j < arg1.GetLength(1); j++)
        {
            for (int n = 0; n < arg1.GetLength(2); n++)
            {
                if (arg1[i, j, n] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

// Способ решения через рекурсию.
// void FillArray(int[,,] arg)
// {
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg.GetLength(1); j++)
//         {
//             for (int k = 0; k < arg.GetLength(2); k++)
//             {
//                 arg[i, j, k] = MassiveCheckForNewNumb(arg);
//             }
//         }
//     }
// }

// int MassiveCheckForNewNumb(int[,,] arg1)
// {
//     int result = new Random().Next(10, 100);
//     for (int i = 0; i < arg1.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg1.GetLength(1); j++)
//         {
//             for (int n = 0; n < arg1.GetLength(2); n++)
//             {
//                 if (arg1[i, j, n] == result)
//                 {
//                     result = MassiveCheckForNewNumb(arg1);
//                     return result;
//                 }
//             }
//         }
//     }
//     return result;
// }

void PrintArray(int[,,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = 0; k < arg.GetLength(2); k++)
            {
                Console.Write($"{arg[i, j, k]}[{i}, {j}, {k}]  ");
            }
            Console.WriteLine();
        }
    }
}

void СonditionСheck(int[,,] arg, int xAxis, int yAxis, int zAxis)
{
    if (xAxis * yAxis * zAxis < 100)
    {
        {
            FillArray(arg);
            PrintArray(arg);
        }
    }
    else Console.WriteLine($"Еhe length of the array does not allow you to set unique values for elements");
}

int x = UserValue($"Enter the value of the x-axis");
int y = UserValue($"Enter the value of the y-axis");
int z = UserValue($"Enter scale value");
int[,,] array = new int[x, y, z];
int[] conditionСheck = new int[z * y * z];
СonditionСheck(array, x, y, z);

