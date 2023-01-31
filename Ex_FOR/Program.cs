 Console.Clear;
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

// Task
// ==== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" Заменить большими "K",
// а большие "C" заменить маленькими "c".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласия прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки!

    int length = text.Length; // определение длинны строки
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue ) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result; // возврат результата
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);
