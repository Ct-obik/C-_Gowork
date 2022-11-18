Console.Clear();

try
Console.WriteLine("Введите X ");
int X = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите Y ");
int Y = int.Parse(Console.ReadLine() ?? "");

catch (Exception exc)
{
Console.WriteLine($"Ошибка ввода данных" { exc.Message});
return;
}

if (X > 0 && Y > 0)                 // Исправить блок по фэншую
{
    Console.WriteLine("1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка. Точка попадает на оси координат.");
}