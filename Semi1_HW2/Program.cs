Console.Write("Введите первое число: ");
string? numbera = Console.ReadLine();
int a = int.Parse(numbera);
Console.WriteLine(a);
Console.Write("Введите второе число: ");
string? numberb = Console.ReadLine();
int b = int.Parse(numberb);
Console.WriteLine(b);
Console.Write("Введите третье число: ");
string? numberc = Console.ReadLine();
int c = int.Parse(numberc);
Console.WriteLine(c);
int max = a;
if (max<b)
    {
    max = b;
    }
if (max<c)
    {
    max = c;
    }
else
    {
    Console.WriteLine($"Максимальное число равно {max}");
    }