﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int x1 = x / 100*10; // деление на 100 дает нам целый результат, без остатка благодаря int, поэтому умножаем на 10 мы уже целое первое число от нашей начальной цифры.
int x2 = x % 10;
int x3 = x1 + x2;
Console.WriteLine($"Answer = {x3}");
