int number = new Random().Next(100, 1000);   // Генерируем числа от 10 до 99 (надо добавить 1)
int a = number / 100;            // Для получения целого числа
int b = number % 10;            // Для получения остатка от деления
int result = a * 10 + b;
Console.WriteLine($"{number} -> {result}");