// Описать сложение 3х чисел с помощью метода.

int sum(int numb1, int numb2, int numb3)
{
 int result = numb1 + numb2 + numb3;
 return result;
}

int[] array = new int[3]{1, 2, 3};

int x = sum(array[0], array[1], array[2]);
Console.WriteLine(x);
