// 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.

// k1*x+b1=k2*x+b2      x=(b1-b2)/(k2-k1)
//          y=k1*(b1-b2)/(k2-k1)+b1

Console.Clear();
double b1 = GetNumberFromUser("Введите целое число для b1: ", "Ошибка ввода!");
double k1 = GetNumberFromUser("Введите целое число для k1: ", "Ошибка ввода!");
double b2 = GetNumberFromUser("Введите целое число для b2: ", "Ошибка ввода!");
double k2 = GetNumberFromUser("Введите целое число для k2: ", "Ошибка ввода!");
double x = LetsFindX(b1, k1, b2, k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых = ({x};{y})");

double LetsFindX(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    if (k2 == k1)
    {
        Console.WriteLine("Деление на ноль недопустимо. Запустите программу и введите заново");
        Environment.Exit(0);  // Нашёл. Записал себе и думаю, часто может пригодится. Главное, чтоб программу не мучала.
    }
    return x;
}

double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

//      Интересная информация:
//  Случайное деление на ноль в компьютерной программе порой становится причиной дорогих 
// или опасных сбоев в работе управляемого программой оборудования. 
// К примеру, 21 сентября 1997 года в результате деления на ноль 
// в компьютеризированной управляющей системе крейсера USS Yorktown (CG-48) 
// Военно-морского флота США произошло отключение всего электронного оборудования в системе,
// в результате чего силовая установка корабля прекратила свою работу/