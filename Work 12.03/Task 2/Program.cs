

// Про.
// Затем показывает диапазон между точками координат в этой четверти (x и y).

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
    Console.WriteLine($"Диапазон значений координаты х = от {x} до -1");
    Console.Write($"Диапазон значений координаты y = от 1 до {y}");
}
if (quarter==w1)
{
    Console.WriteLine($"Диапазон значений координаты х = от 1 до {x}");
    Console.Write($"Диапазон значений координаты y = от 1 до {y}");
}
if (quarter==w2)
{
    Console.WriteLine($"Диапазон значений координаты х = от {x} до -1");
    Console.Write($"Диапазон значений координаты y = от {y} до -1");
}
if (quarter==w3)
{
    Console.WriteLine($"Диапазон значений координаты х = от 1 до {x}");
    Console.Write($"Диапазон значений координаты y = от {y} до -1");
}