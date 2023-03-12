// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());
if (first_number>second_number)
{
    Console.Write("max = ");
    Console.WriteLine(first_number);
    Console.Write("min = ");
    Console.WriteLine(second_number);
}
if (second_number>first_number)
{
    {
        Console.Write("max = ");
        Console.WriteLine(second_number);
        Console.Write("min = ");
        Console.WriteLine(first_number);
    }
}
if (first_number == second_number)
{
    Console.Write("All numbers are equal");
}
