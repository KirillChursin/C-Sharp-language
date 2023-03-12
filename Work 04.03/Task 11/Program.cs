// Напишите программу которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Enter number - ");
int number = Convert.ToInt32(Console.ReadLine());
int n=number*-1;
while (n<=number)
{
    Console.Write($"{n}, ");
    n = n+1;
}

