// //  Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]





int arrayLen(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void random(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(-9, 10);
    }
}

void print(int[] arg)
{
    Console.Write($"[");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine($"]");
}

void coup(int[] arg)
{
    for (int i = 0; i < arg.Length/2; i++)
    {
                int x = arg[i];
                arg[i] = arg[(arg.Length-1)-i];
                arg[(arg.Length-1)-i] = x;
    }
}

int length = arrayLen($"Enter number array length =  ");
int[] array = new int[length];
random(array);
print(array);
coup(array);
print(array);


