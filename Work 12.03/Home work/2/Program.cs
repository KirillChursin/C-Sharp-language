// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// формула нахождения длины = корень(х1-х2)
// задаем координаты первой точки
Console.WriteLine($" enter the values of the first coordinate x, y, c: ");
double x = Convert.ToDouble(Console.ReadLine()); // задаем координату х
double y = Convert.ToDouble(Console.ReadLine()); // задаем координату у
double c = Convert.ToDouble(Console.ReadLine());

// // задаем координату второй точки
Console.WriteLine($" enter the values of the second coordinate x, y, c: ");
double x1 = Convert.ToDouble(Console.ReadLine()); // задаем координату х1
double y1 = Convert.ToDouble(Console.ReadLine()); // задаем координату у1
double c1 = Convert.ToDouble(Console.ReadLine()); // задаем координату у1

// double s = Math.Sqrt((x-x1)*(x-x1)+(y-y1)*(y-y1)+(c-c1)*(c-c1));

// Console.WriteLine();
// Console.WriteLine($" S coordinat = {Math.Round(s,2)}");

double sq(double numb1, double numb2)  // создаем метод для нахождения (x-x1)*(x-x1)
{
    double sqare = Math.Pow((numb1 - numb2), 2);
    return sqare;
}

double first = sq(x,x1);
double second = sq(y,y1);
double last = sq(c, c1);

double root(double arg1, double arg2, double arg3) // создаем метод возводящий полученные выше значения в корень.
{
    double result = Math.Sqrt(arg1 + arg2 + arg3);
    return result;
}

double s = root(first, second, last);

Console.WriteLine();
Console.WriteLine($" S coordinat = {Math.Round(s,2)}");
