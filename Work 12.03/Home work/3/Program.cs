// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write($" Enter your number = ");
double numb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Сube table from one to your number");
for (int i = 1; i <= numb; i++)
{
    Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
}