// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int writeRead (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int sumAllDigit (int arg)
{
    int result = 0;
    while (arg>0)
    {
        result += arg % 10;
        arg = arg / 10;
    }
    return result;
}

int numb = writeRead($"Enter number");
Console.WriteLine(sumAllDigit(numb));


// Console.WriteLine($"Enter number");
// int numb = Convert.ToInt32(Console.ReadLine()); превращаем это в метод выводящий сообщение введите число и возвращающий вводимое пользоваетелем значение
int myNumb (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int numb = myNumb($"Enter number");

int result = 0;
while (numb > 0)
{
    result = result + numb % 10;
    numb = numb / 10;
}
Console.WriteLine(result);

