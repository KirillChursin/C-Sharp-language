// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int numb(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void fib(int[] arg) // задаем значения чисел фибоначчи
{
    arg[0] = 0;
    arg[1] = 1;
    int i = 0;
    for (i = 2; i < arg.Length; i++)
    {

        arg[i] = arg[i - 1] + arg[i - 2];
    }
}

void print(int[] array) // выводим на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int length = numb($"Enter number fibonacci");

int[] array = new int[length];
fib(array);
print(array);
