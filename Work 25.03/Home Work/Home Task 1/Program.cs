// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int length(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void number(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"Enter {i + 1} number = ");
        arg[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int task (int[] arg)
{
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] > 0)
        {
            result = result + 1;
        }
    }
    return result;
}


int len = length($"Enter how many numbers you want write");

int[] array = new int[len];
number(array);
int x = task(array);
Console.Write($"You write {x} numbers greater than zero.");


