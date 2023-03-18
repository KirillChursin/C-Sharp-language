// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine($"Enter first number");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter second number");
int y = Convert.ToInt32(Console.ReadLine());

int degree(int numb1, int numb2)
{
    int result = numb1;
    int length = numb2;
    for (int i = 1; i < length; i++)
    {
        result = numb1 * result;
    }
    return result;
}

int degreeResult = degree(x, y);
Console.WriteLine($"erection result {degreeResult}");