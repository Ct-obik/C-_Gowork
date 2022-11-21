// Задача с заменой букв и символов в данном тексте
//пробелы заменить чёрточками
//маленькие буквы "к" заменить большими "К"
//большие "В" заменать на маленькие "в"

string text = "- Я думаю, - сказал князь, улыбаясь - что, "
            + "ежели бы вас послали вместо нашего милого Винцентгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//памятка:
//string s = "nekiy text'
//            0123....
//s[3] - для того, чтобы получить символ    -> получим i

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text [i]}";
    }
    return result;
}

string NewText = Replace(text, ' ', '|');   // используем метод для за замены пробелов на черточки
Console.WriteLine(NewText);

Console.WriteLine();
NewText = Replace(NewText, 'к', 'К');   // используем метод для замены маленькой к на БОЛЬШУЮ
Console.WriteLine(NewText);

Console.WriteLine();
NewText = Replace(NewText, 'В', 'в');   // используем метод для замены большой В на маленькую
Console.WriteLine(NewText);