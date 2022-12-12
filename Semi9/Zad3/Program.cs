// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12

int number = GetIntNatFromUser("Введите число: ");

Console.WriteLine($"{number} -> {DigitsSumInNumber(number, 0)}");



static int DigitsSumInNumber(int number, int sum)
{
    if (number == 0)
        return sum;
    sum += number % 10;
    number = number / 10;
    return DigitsSumInNumber(number, sum);
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