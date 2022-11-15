int number = new Random().Next(10, 100);   // Генерируем числа от 10 до 99 (надо добавить 1)

int a = number / 10;            // Для получения целого числа
int b = number % 10;            // Для получения остатка от деления

int max;
if (a > b)
    max = a;
else
    max = b;

Console.WriteLine($"{number} -> {max}");