// 68 Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Clear();
int m = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
Console.WriteLine($"Функция Аккермана: A({m},{n}) = {ack(m, n)}");

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
// Функция Аккермана
int ack(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return ack(n - 1, 1);
    else
        return ack(n - 1, ack(n, m - 1));
}