// Найти факториал числа N

int Fact = 1;
int x = 1;
Console.Write("Enter number = ");
int number = Convert.ToInt32(Console.ReadLine());
while (x<=number)
{
    Fact = Fact * x;
    x = x + 1;
}
Console.Write(Fact);