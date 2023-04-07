// Рекурсия - метод вызывающий самого себя, ниже рахберем пример написания кода делающего одно и то же, разными способами. 

// вывести на консоль строку чисел от arg1 до arg2. Сделаем с помощью возвращающегося медода

// string NumbFor (int arg1, int arg2)
// {
//     string result = string.Empty;
//     for (int i = arg1; i <= arg2; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// Console.WriteLine(NumbFor(1, 5));

// А теперь сделаем с помощью рекурсии.

string NumberFor (int arg1, int arg2)
{
    if (arg1 < arg2) 
    {
        return $"{arg1} " + NumberFor (arg1+1, arg2);
    }
    else return $"{arg2}";
}

Console.WriteLine(NumberFor(1, 5));