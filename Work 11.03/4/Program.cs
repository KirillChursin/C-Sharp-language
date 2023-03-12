// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Enter first number = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number = ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == Math.Pow(number1, 2)) Console.WriteLine($"The first number is the square of the second number");
else Console.WriteLine($"The first number is not the square of the second number");
