// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("monday = 1");
Console.WriteLine("thusday = 2");
Console.WriteLine("wednesday = 3");
Console.WriteLine("thursdau = 4");
Console.WriteLine("friday = 5");
Console.WriteLine("saturday = 6");
Console.WriteLine("sunday = 7");
Console.Write("Enter a number to find out if today is a holiday or not = ");
int number = Convert.ToInt16(Console.ReadLine());
if (number == 6) Console.Write($"Holiday");
if (number == 7) Console.Write($"Holiday");
if (number<6) Console.Write($"Not a holiday");
if (number>7) Console.WriteLine($"Wrong number");