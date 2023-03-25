// Создадим двухмерный массив рандомных значений от 1 до 9 

int stringLength(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int columnLength(string message)
{
    Console.WriteLine(message);
    int y = Convert.ToInt32(Console.ReadLine());
    return y;
}

void random (int[,] arg) // создаем метод для вложения рандомных значений в элементы массива
{
    for (int i = 0; i < arg.GetLength(0); i++) // задаем цикл для перечисления строк в массиве
    {
        for (int j = 0; j < arg.GetLength(1); j++) //задаем цикл для перечисления в строке столбцов , получается цикл перечисляет все столбцы в строке, затем переходит на новую строку и заного перечисляет.
        {
            arg[i, j] = new Random().Next(1, 10); // вкладываем в каждый элемент рандомное значение
        }
    }
}

void print (int[,] arg) // создаем метод выводящий на экран значения двухмерного массива
{
    for (int i = 0; i < arg.GetLength(0); i++) //цикл для строк
    {
        for (int j = 0; j < arg.GetLength(1); j++) //цикл для стобцов
        {
            Console.Write($"{arg[i , j]} "); // выводим на экран массив, делаем в что бы в одной строке писались столбцы.
        }
        Console.WriteLine(); // вывод на экран отступа пустой строки для написания новой строки массива с новой строки.
    }
}

int stringLeng = stringLength($"Enter string legth");
int columnLeng = columnLength($"Enter column length");

int[,] matrix = new int [stringLeng, columnLeng]; // создаем новый двухмерный массив где x строки, y столбцы
random(matrix);
print(matrix);

