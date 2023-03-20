// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 



// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.





int numb (string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int arrayLength = numb($"Enter array length number");

int[] array = new int[arrayLength];

void random (int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(-9,10);
    } 
}
random(array);

void print(int [] arg)
{   Console.Write($"[ ");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.Write($"]");
}
print(array);

int sumPlus (int[] arg)
{
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] > 0)
        {
            result += arg[i];
        }
    } 
    return result;
}

int sumMinus (int[] arg)
{
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] < 0)
        {
            result += arg[i];
        }
    } 
    return result;
}

Console.WriteLine();
int sumPozitive = sumPlus(array);
Console.WriteLine(sumPozitive);

int sumNegative = sumMinus(array);
Console.WriteLine(sumNegative);
