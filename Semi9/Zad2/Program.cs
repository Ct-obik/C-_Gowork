// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"

int m = GetIntNatFromUser("Введите значение M: ");
int n = GetIntNatFromUser("Введите значение N: ");

Console.Write($"M = {m}; N = {n} -> ");
RecursionOneToN(m, n, true);

static void RecursionOneToN (int curNum, int n, bool startCheck)
{
    if (curNum > n)
        return;

    if (startCheck)
        Console.Write($"{curNum}");
    else
        Console.Write($", {curNum}");
    curNum++;
    
    RecursionOneToN(curNum, n, false);
}

static int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}