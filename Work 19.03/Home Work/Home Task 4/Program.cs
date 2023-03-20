// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int message(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void random(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(1, 50);
    }
}

void print(int[] arg)
{
    Console.Write($"[ ");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine($"]");
}

void product (int[] arg, int[] arg2)
{
    int result = 0;
    int max = arg.Length - 1;
    int min = 0;
    for (int i = 0; i < arg.Length / 2; i++)
    {
        arg2[i] = arg[min] * arg[max];
        min++;
        max--;
    }
}


int arrayLength = message("Enter array length number"); // создаем переменную включающую в себя длинну массива, запуском метода приглашающего к вводу определящего вводимое нами значение.
int[] array = new int[arrayLength];                     // создаем массив с длинной введенного нами числа.
random(array);                                          // присваиваем элементам массива случайные значения
Console.Write($"array[] = ");
print(array);                                           // выводим массив на консоль.
Console.WriteLine();
int[] newArray = new int [arrayLength / 2];             // создаем новый массив размером в 2 раза короче первого (если не четное, то округляем в меньшую сторону).
product(array, newArray);                               // присваиваем элементам нового массива значения - произведение пар первого массива.
Console.WriteLine($"Getting the product of a pair of numbers, and putting them into a new array");
Console.WriteLine();
Console.Write($"newArray[] = ");
print(newArray);                                        // выводим новый массив на экран




