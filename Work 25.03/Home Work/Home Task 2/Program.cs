// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2 // формула вычисления точки пересечения
                             


Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
// найдем х, для этого вычтем из первого уровнения второе получится y-y = (k1 - k2)*x - (b1 - b2)
// перенесем резултат k*x в левую часть уравнения, для этого нужно k *-1. Однако в коде левая часть является переменной, поэтому пишем код заранее подготовленный
// далее согласно формуле, надо разделить результат b на результат k, получаем х.
double x = -(b1 - b2) / (k1 - k2); 
// что бы получить y - подставляем во второе уровнение значение х.
double y = k1 * x + b1;
 
x = Math.Round(x, 1);
y = Math.Round(y, 1);
 
Console.WriteLine($"Point intersection: ({x};{y})");