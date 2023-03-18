// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] element = new int [8]{1, 2 ,5, 7, 19, 4 , 27, 32};

void arrayPrint(int[] arrayElement)
{
    int length = arrayElement.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arrayElement[i]} ");
    }
}


arrayPrint(element);


