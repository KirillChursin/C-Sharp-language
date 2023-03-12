// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter first number - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number - ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter last number - ");
int number3 = Convert.ToInt32(Console.ReadLine());
int i = 0;
int max = 0;

int[] array = {number1, number2, number3};
while (i<array.Length)
{
    if (array[i]>array[max])
    {
        max = i;
        i++;
    }
    else
    {
        i++;
    }
}
Console.Write("max number = ");
Console.WriteLine(array[max]);

