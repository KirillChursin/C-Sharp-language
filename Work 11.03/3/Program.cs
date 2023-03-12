// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Enter number = ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%7==0)
 if (number%23==0) 
    {
     Console.WriteLine($"Number multiple 7 and 23");
    }
else Console.WriteLine($"Number dont multiple 7 and 23");
