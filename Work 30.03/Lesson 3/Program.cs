// Найти факториал числа n 

// int NumberFactorial (int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// Console.WriteLine(NumberFactorial(4));

int NumberFactorial(int n)
{
    if (n == 1) return 1;
    else return n* NumberFactorial(n-1);
}

Console.WriteLine(NumberFactorial(4));