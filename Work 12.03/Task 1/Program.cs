// 1) Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Затем показывает все возможные точки координат в этой четверти (x и y).

//      1    y|    2
//            |
//     ---------------
//      3     |    4  x
//            |
//




Console.WriteLine("Enter x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y = ");
int y = Convert.ToInt32(Console.ReadLine());


if (y != 0 && x !=0)
{
    if (y>0 && x<0) 
    {
        int q = 1; 
        Console.WriteLine($"Ваша координата в четверти {q}");
    }
    if (y>0 && x>0) 
    {
        int q1 = 2; 
        Console.WriteLine($"Ваша координата в четверти {q1}");
    }
    if (y<0 && x<0) 
    {
        int q2 = 3; 
        Console.WriteLine($"Ваша координата в четверти {q2}");
    }
    if (y<0 && x>0) 
    {
        int q3 = 4; 
        Console.WriteLine($"Ваша координата в четверти {q3}");
    }
}
else Console.WriteLine($"Ваша координата не удолетворяет условию задачи");


Console.WriteLine("select quarter number = ");
int quarter = Convert.ToInt32(Console.ReadLine());
int w = 1;
int w1 = 2;
int w2 = 3;
int w3 = 4;
if (quarter==w)
{
    Console.Write($"Возможные координаты по оси х = ");
    for (int i = -1; i > x; i=i-1)
    {
        Console.Write($"{i}; ");
    }
    Console.WriteLine(" ");
    Console.Write($"Возможные координаты по оси y = ");
    for (int i = 1; i < y; i++)
    {
        Console.Write($"{i}; ");
    }
}
if (w1 == quarter)
{
    Console.Write($"Возможные координаты по оси х = ");
    for (int i = 1; i < x; i++)
    {
        Console.Write($"{i}; ");
    }
    Console.WriteLine(" ");
    Console.Write($"Возможные координаты по оси y = ");
    for (int i = 1; i < y; i++)
    {
        Console.Write($"{i}; ");
    }
}
if (w2 == quarter)
{
    Console.Write($"Возможные координаты по оси х = ");
    for (int i = -1; i > x; i=i-1)
    {
        Console.Write($"{i}; ");
    }
    Console.WriteLine(" ");
    Console.Write($"Возможные координаты по оси y = ");
    for (int i = -1; i > y; i=i-1)
    {
        Console.Write($"{i}; ");
    }
}
if (w3 == quarter)
{
    Console.Write($"Возможные координаты по оси х = ");
    for (int i = 1; i < x; i++)
    {
        Console.Write($"{i}; ");
    }
    Console.WriteLine(" ");
    Console.Write($"Возможные координаты по оси y = ");
    for (int i = -1; i > y; i=i-1)
    {
        Console.Write($"{i}; ");
    }
}
