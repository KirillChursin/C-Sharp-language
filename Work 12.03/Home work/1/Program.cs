// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 5 одинаково читающиеся с лева на право и наоборот.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine($"Enter number = ");
string palindrome = Console.ReadLine();


if ((palindrome[0] == palindrome[4]) & (palindrome[0] == palindrome[4]))
{
    Console.WriteLine($"Yours number is a palindrome");
}
else
{
    Console.WriteLine($"Yours number isn't a palindrome ");
}
