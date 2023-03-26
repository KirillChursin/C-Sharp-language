// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int numb(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int a = numb($"Enter the length of side a");
int b = numb($"Enter the length of side b");
int c = numb($"Enter the length of side c");

if (a < b+c || b < a+c || c < b+a)
{
    Console.Write($"No");
}
else Console.Write($"Yes");