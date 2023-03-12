//Find max of three numbers
//

Console.WriteLine("Enter number 1 = ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2 = ");
int a2 = Convert.ToInt32(Console.ReadLine());

int[ ] array = {a1, a2};
int i = 0;
int max = 0;
while (i < array.Length)
{
    if (array[i]>array[max])
       max = i;
       i = i+1;
}
Console.Write("max = ");
Console.WriteLine(array[max]);