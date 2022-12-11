// 66 Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N (включая сами числа).

Console.Clear();
int m = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
Console.WriteLine($"Сумма всех чисел от {m} и до {n} = {GetSum(m, n)}");

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

int GetSum(int m, int n)
{
    if (m < n)
    {
        if (m == n) return m;
        else return m + GetSum((m + 1), n);
    }
    else
    {
        if (m == n) return m;
        else return m + GetSum((m - 1), n);
    }
}
