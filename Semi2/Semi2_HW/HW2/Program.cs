Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int min = 99;
while (true)
{
    if (number > min)
    {
        int a = ((number / 100) % 10);
        Console.WriteLine($"Третья цифра числа - {a}");
        return;
    }
    else
    {
        break;
    }
}
Console.WriteLine("Третьей цифры нет");