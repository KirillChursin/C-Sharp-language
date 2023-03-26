// // Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101
// // 3  -> 11
// // 2  -> 10



int numb(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int x = numb($"Enter decimal number");

string result = " ";

while (x !=0)
{
    result = (Convert.ToString(x % 2)) + result;
    x /= 2; 
}
Console.Write(result);
