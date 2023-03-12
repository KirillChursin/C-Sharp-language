// найти элемент массива равный find number.

int[] array = {1, 1, 3 , 4, 6, 7, 8, 9};
int i = 0;
Console.Write("Enter find number = ");
int find = Convert.ToInt32(Console.ReadLine());
while (i<array.Length)
{
    
    if (find == array[i])
    {
        Console.Write("Search find number index = ");
        Console.WriteLine(i);
        break;
    }
    i++;
}
if (i>=array.Length)
{
    Console.WriteLine("Array dont have find number");
}


