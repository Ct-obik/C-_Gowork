// находим 2 цифру из 3-х значного числа
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int max = 1000;
int min = 99;
while (true)
{
    if (number >min && number < max)  
    {
    Console.WriteLine($"Вторая цифра числа - {number / 10 % 10}");
    }
    else
    {
    Console.WriteLine("Ошибка");
    }
    return;
}
Console.WriteLine("Ошибка ввода");