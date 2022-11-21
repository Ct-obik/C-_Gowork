Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
if (number>99)
    {
        while (number > 999) 
        {
            number /= 10;
            Console.WriteLine($"Третья цифра числа - {number % 10}");
            return;
        }
        Console.WriteLine($"Третья цифра числа - {number % 10}");
    }
else
{
    Console.WriteLine("Третьей цифры нет");
}