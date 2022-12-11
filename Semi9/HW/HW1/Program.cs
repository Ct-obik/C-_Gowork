// 64 Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.Clear();
int a = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");

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

string GetSum(int a, int b)
{
    if (a <= b) return GetSum(a + 1, b) + $"{a} ";
    else return string.Empty;
}

if (a < 1) Console.WriteLine($"Введите другое число!");
else Console.WriteLine(GetSum(1, a));