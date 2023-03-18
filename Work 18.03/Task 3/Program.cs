// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int len(string numb)
{
    int numbLen = numb.Length;
    return numbLen;
}



Console.Write("Enter your number = ");
string length = Console.ReadLine();
Console.WriteLine($"длинна числа = {len(length)}");
