// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 





int arrayLen(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void random(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(-9, 10);
    }
}

void print(int[] arg)
{
    Console.Write($"[ ");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.Write($"]");
}

void arrayChange(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {

        arg[i] = arg[i] * -1;
    }
}

int arrayLength = arrayLen($"Enter your array length number"); // запускаем метод приглашающий к вводу, и возвращающий значение ввода, присваиваем значение ввода в переменную
int[] array = new int[arrayLength]; // создаем массив с длинной равной значению переменной, которой присвоено число ввода.
random(array); // вызываем массив присваивающий рандомные значения элементам нашего созданного массива.
print(array); // вызываем метод выводящий каждый элемент массива на консоль.
arrayChange(array); // запускаем метод меняющий все минусовые значения элементов массива с положительных на отрицательные и наоборот.
Console.WriteLine();
print(array); // выводим измененные значения на консоль.

