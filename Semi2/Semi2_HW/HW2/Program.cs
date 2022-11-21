Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int min = 99;
while (number > 99) number /= 10;
Console.WriteLine($"Третья цифра числа - {number % 10}");
Console.WriteLine("Третьей цифры нет");