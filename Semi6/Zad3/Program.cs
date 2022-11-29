// Перевести число в двоичную систему

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int res = ResultAnotherNumber(num);
Console.WriteLine($"{num} -> {res}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int ResultAnotherNumber(int num)
{
    int res = 0;
    int count = 0;
    while (num > 0)
    {
        res += num % 2 * (int)Math.Pow(10, count);
        num = num / 2;
        count += 1;
    }
    return res;
}