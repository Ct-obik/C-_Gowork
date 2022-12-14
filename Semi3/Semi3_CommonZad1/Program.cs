Console.Clear();
int UserInput = InitCoordinatesByUser(); // Вызов метода с передачей параметров по ссылке (ref)
PrintQuarterByCoords(UserInput);          // Вызов метода с передачей параметров по значению
static int  InitCoordinatesByUser()
{
    try
    {
        Console.Write("Введите число от 1 до 4: ");
        return int.Parse(Console.ReadLine() ?? "");
        
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
static void PrintQuarterByCoords(int number1)
{
    if (number1 == 1)
    {
        Console.WriteLine($"X > 0   Y > 0");
    }
    else if (number1 == 2)
    {
        Console.WriteLine($"X < 0   Y > 0");
    }
    else if (number1 == 3)
    {
        Console.WriteLine($"X < 0   Y < 0");
    }
    else if (number1 == 4)
    {
        Console.WriteLine($"X > 0   Y < 0");
    }
    else
    {
        Console.WriteLine($"Читай условие");
    }
}
