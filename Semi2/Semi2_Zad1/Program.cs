
int number = new Random().Next(10, 100);   // Генерируем числа от 10 до 99 (надо добавить 1)
Console.WriteLine($"{number}-> ");

int a = number / 10;            // Для получения целого числа
Console.WriteLine($"a = {a} ");
int b = number % 10;            // Для получения остатка от деления
Console.WriteLine($"b = {b} ");