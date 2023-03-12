// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter three-digit number");
int number = Convert.ToInt16(Console.ReadLine());
int x = (number%100)/10;
Console.WriteLine($"second number = {x}");
