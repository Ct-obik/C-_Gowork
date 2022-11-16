Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int max = 1000;
int min = 99;
while (number > min)
{
    if (number < max)
    {
        int a = (number / 10) % 10;
        Console.WriteLine($"Вторая цифра числа - {a}");
        return;
    }
    else
    {
        break;
    }
}
Console.WriteLine("Ошибка ввода");