// Заменить в тексте все пробелы на /
// заменить в тексте все маленькие бувы к на заклавыне К

 Console.WriteLine ($"enter your text");
 string write = Console.ReadLine();

 string text(string letter, char oldValue, char newValue)
 {
    string result = String.Empty;
    int length = letter.Length;

    for (int i = 0; i < length; i++)
    { 
        if (letter[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{letter[i]}";
    }
    return result;
 }


 string Text = text(write, ' ', '/' );
 Text = text(Text, 'к', 'К');
 Console.WriteLine(Text);


