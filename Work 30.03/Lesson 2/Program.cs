// Сумма чисел от 1 до n

// int NumberSum (int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         result += i;
//     }
//     return result;
// }

// Console.WriteLine(NumberSum(3));

int NumberSum (int n)
{
    if (n == 1) return 1;
    else return n + NumberSum(n-1);
}

Console.WriteLine(NumberSum(3));