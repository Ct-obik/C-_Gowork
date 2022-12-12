// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"

int n = GetIntNatFromUser("Введите значение N: ");
Console.Write($"N = {n} -> 1");
RecursionOneToN(2, n);

static void RecursionOneToN (int curNum, int n)
{
    if (curNum > n)
        return;
    Console.Write($", {curNum}");
    curNum++;
    RecursionOneToN(curNum, n);
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