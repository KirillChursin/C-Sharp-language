// генерирует случайное число и находит наибольшую цифру этого числа.

int x = new Random().Next(10, 100);
Console.WriteLine(x);
string x1 = Convert.ToString(x);
int max = 0;
if (x1[1]>x1[max]) 
{
    max = 1;
    
}
Console.WriteLine(x1[max]);