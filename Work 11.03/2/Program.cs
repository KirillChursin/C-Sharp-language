﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


int n = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());

if (n%x!=0)
{
    int y = n%x;
    Console.WriteLine($"Остаток деления = {y}");
}
else Console.Write("Кратно");