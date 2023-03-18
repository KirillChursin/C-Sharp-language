//  Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int sum (int numb)
{
    int result = 0;
    int length = numb;
    for (int i = 1; i <= length; i++)
    {
        result = i+result;
    }
    return result;
}
Console.WriteLine($"Enter number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sum 1 to your numb = {sum(x)}");