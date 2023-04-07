// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.\

int ArraySize(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void FillArrayRandom(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray1dRepeat(int[] arg, int[] arg2) // создаем принт для одномерных массивов, где указывается сколько раз повторялос число в массиве
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        if (arg2[i] != 0)
        {
            Console.WriteLine($"Value {arg[i]} repeat {arg2[i]} times");
        }
    }
}

bool MassiveCheck(int arg, int[] arg1)         // метод проверяющий, встречается ли число в массиве. Если нет возвращаем true, если да то false.
{
    bool flag = true;
    for (int i = 0; i < arg1.Length; i++)
    {
        if (arg == arg1[i])
        {
            flag = false;
            break;
        }
    }
    return flag;
}

void FeelUniqueValue(int[,] arg, int[] arg2)   // метод присваивающий новому массиву уникальные значения (не повторяет значения) массива, путем перебора значений из основного массива array и определения их повторов.
{
    for (int k = 0; k < arg2.Length; k++)
    {
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            for (int j = 0; j < arg.GetLength(1); j++)
            {
                if (MassiveCheck(arg[i, j], arg2))
                {
                    arg2[k] = arg[i, j];
                }
            }
        }
    }

}

void DuplicateValues(int[,] arg1, int[] unique, int[] check) // метод присваивающий новому массиву количество повторений среди элементов одного массива.
{

    for (int k = 0; k < unique.Length; k++)
    {
        int count = 0;
        for (int i = 0; i < arg1.GetLength(0); i++)
        {
            for (int j = 0; j < arg1.GetLength(1); j++)
            {
                if (arg1[i, j] == unique[k])
                {
                    count++;
                }
            }
        }
        check[k] = count;
    }
}



int lenColumn = ArraySize($"Enter column size");
int lenRow = ArraySize($"Enter line size");
int[,] array = new int[lenRow, lenColumn];
int[] uniqueValue = new int[array.GetLength(0) * array.GetLength(1)]; // тут будем хранить уникальные эелементы
int[] count = new int[array.GetLength(0) * array.GetLength(1)]; ; // количесто уникальных элементов в изначальном массиве
FillArrayRandom(array);
PrintArray(array);
FeelUniqueValue(array, uniqueValue);
DuplicateValues(array, uniqueValue, count);
Console.WriteLine();
PrintArray1dRepeat(uniqueValue, count);

