Console.WriteLine("Введите номер дня недели:");
int number = int.Parse(Console.ReadLine());
while (true)
{
    Console.WriteLine("Является выходным?");
    if (number ==1)
    {
        Console.WriteLine($"{number} -> Понедельник не выходной");
        return;
    }
    if (number == 2)
    {
        Console.WriteLine($"{number} -> Вторник не выходной");
        return;
    }
    if (number ==3)
    {
        Console.WriteLine($"{number} -> Среда не выходной");
        return;
    }
    if (number == 4)
    {
        Console.WriteLine($"{number} -> Четверг не выходной");
        return;
    }
    if (number ==5)
    {
        Console.WriteLine($"{number} -> Пятница не выходной");
        return;
    }
    if (number ==6)
    {
        Console.WriteLine($"{number} -> Суббота выходной");
        return;
    }
    if (number == 7)
    {
        Console.WriteLine($"{number} -> Воскресенье выходной");
        return;
    }
    else
    {
        break;
    }
}
Console.WriteLine("Ошибка ввода, введите ещё раз");