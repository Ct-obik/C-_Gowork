// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)

int a = GetIntNatFromUser("Введите число A: ");
int b = GetIntNatFromUser("Введите число B: ");

Console.WriteLine($"A = {a}; B = {b} -> {NumberToPow(a,b)}");

static int NumberToPow(int number, int power)
{
    if (power == 1) return number;
    return number * NumberToPow(number, power - 1);
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