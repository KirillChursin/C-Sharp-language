// Вычислить среднее арефметическое между 3 числами.


Console.WriteLine("Enter number 1 = ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2 = ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 3 = ");
int number3 = Convert.ToInt32(Console.ReadLine());

int i = 0;
int sum = 0;
int[] array = {number1, number2, number3};
while (i<array.Length)
{
    sum = sum + array[i];
    i = i+1;
}
int Average = sum/array.Length;
Console.Write("Average = " );
Console.Write(Average);