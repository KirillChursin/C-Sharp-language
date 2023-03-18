// упорядочить значения массива по возрастанию

int[] array = {2, 6, 9, 1, 8, 1, 3};

 void printArray(int[] arg1)
 {
     int length = arg1.Length;
     for (int i = 0; i < length; i++)
     {
         Console.Write($"{arg1[i]} ");
     }
     Console.WriteLine();
 }

void arraySort(int[] arg1)
{
    for (int i = 0; i < arg1.Length-1; i++)
    {
        int minElement = i;
        for (int j = i+1; j < arg1.Length; j++)
        {
            if (arg1[j] < arg1[minElement]) minElement = j;
        }
        int numb = arg1[i];
        arg1[i] = arg1[minElement];
        arg1[minElement] = numb;
    }
}

printArray(array);
arraySort(array);
printArray(array);
