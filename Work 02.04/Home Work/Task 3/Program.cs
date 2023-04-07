// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int arg1, int arg2)
{
    if( arg1 == 0) return arg2 + 1;
    else if (arg1 > 0 && arg2 == 0) return Akkerman(arg1-1, 1);
    else if (arg1 > 0 && arg2 > 0) return Akkerman(arg1-1, Akkerman(arg1, arg2-1));
    return Akkerman(arg1,arg2);
}


Console.WriteLine($"Enter n value");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter m value");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Akkerman(m, n)}");