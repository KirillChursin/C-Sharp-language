// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int length (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void random (int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(0, 123);
    }
}

void print (int[] arg)
{
    Console.Write($"[");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine($"]");
}

int elementLineSegment (int[] arg)
{
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if ((arg[i] > 9) & (arg[i] < 100))
        {
            result++;
        }
    }
    return result;
}



int arrayLength = length("Enter array length number");
int[] array = new int [arrayLength];
random(array);
print(array);
Console.WriteLine($"Тumber of array elements from 10 to 99 = {elementLineSegment(array)}");

