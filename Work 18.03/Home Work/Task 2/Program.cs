// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




// Console.WriteLine($"Enter number");
// int numb = Convert.ToInt32(Console.ReadLine()); превращаем это в метод выводящий сообщение введите число и возвращающий вводимое пользоваетелем значение
int myNumb (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int numb = myNumb($"Enter number");

// int result = 0;
// while (numb > 0)
// {
//     result = result + numb % 10;
//     numb = numb / 10;
// }
// Console.WriteLine(result); превращаем все это в метод сохраняя в результат сумму цифр в числе.

int sumNember (int arg)
{
    int result = 0;
    while (arg > 0) // создаем цикл что бы дальше перебирать все цифры числа.
    {
        result += arg % 10; // %10 показывает последнюю цифру числа и суммирует ее с result, где изначально result = 0, потом 0 + пеоследння цифра числа и так, пока не переберутся все цифры числа.
        arg = arg / 10; // /10 присваивает в arg число без последней цифры числа.
    }
    return result;
}

Console.WriteLine($"sum elements your number = {sumNember(numb)}");
