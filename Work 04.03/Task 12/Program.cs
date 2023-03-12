// Программа принимающая на вход трехзначное число, а на выходе показывает последнюю цифру числа.

Console.WriteLine("Enter three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
number = number % 10;
Console.Write("Last digit of your number = ");
Console.WriteLine(number);