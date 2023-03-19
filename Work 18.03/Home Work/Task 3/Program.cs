// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]

int invitation (string message) // создаем метод, который будет выводить сообщение приглащающее ко вводу значения длинны массива и считывать вводимое нами число, дальше подставляя его в длинну массива
{
   Console.WriteLine(message); // делаем команду которая будет выводить заданное позже ссобщение
   int result = Convert.ToInt32(Console.ReadLine()); // в результат запишем переконвертированное из строки в число, вводимое значение.
   return result; //возвращаем результат, которым будет введенное нами значение
}
int length = invitation ("Enter array length number"); // задаем переменной length значение метода, где возвращаемый результат равен вводимому числу, и выводится прописанное сообщение.

void random (int[] element)
{
   for (int i = 0; i < element.Length; i++)
   {
      element[i] = new Random().Next(1,50);
   }
}

void write (int[] elementPrint)
{
   Console.Write($"[");
   for (int i = 0; i < elementPrint.Length; i++)
   {
      Console.Write($"{elementPrint[i]} ");
   }
   Console.Write($"]");
}

int[] array = new int[length]; // создаем массив, где прописываем ео название, которое будет подставляться в методы, и который имеет длинну заданную нами с помощью метода prompt.

random(array);
write(array);
