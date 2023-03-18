// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// // 4 -> 24 
// // 5 -> 120

int len(int numb)
{
    int length = numb;
    int result = 1;
    for (int i = 1; i <= length; i++)
    {
        result = i*result;
    }
    return result;
}

int x = Convert.ToInt32(Console.ReadLine());
int product = len(x);
Console.WriteLine($"{product}");