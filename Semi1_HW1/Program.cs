Console.Write("Введите первое число: ");
string? numbera = Console.ReadLine();
int a = int.Parse(numbera);
Console.WriteLine(a);
Console.Write("Введите второе число: ");
string? numberb = Console.ReadLine();
int b = int.Parse(numberb);
Console.WriteLine(b);
if (a>b)
    {
    Console.WriteLine($"Максимальное {a}");
    }
if (a<b)
    {
    Console.WriteLine($"Максимальное {b}");
    }
else
    {
    Console.WriteLine($"{a} равно {b}");
    }