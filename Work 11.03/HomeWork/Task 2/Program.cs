// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());

while (number>999) 
{
    number = number / 10;
}
if (number>99)
{
    int y = number%10;
    Console.WriteLine($"Third digit of the number = {y}");
}
else
{
    Console.WriteLine("There is no third digit");
}