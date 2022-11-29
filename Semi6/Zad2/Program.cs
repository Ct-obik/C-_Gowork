// Напишите программу, которая принимает на вход 3 числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.                 

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите целое число2: ", "Ошибка ввода!");
int num3 = GetNumberFromUser("Введите целое число3: ", "Ошибка ввода!");
bool proverka = IsTriangle(num, num2, num3);
Console.WriteLine($"Может ли существовать -> {(proverka?"ДА":"НЕТ")}");
                                                // bool  true:false

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

bool IsTriangle(int num, int num2, int num3)
{
    if (num < num2 + num3 && num2 < num + num3 && num3 < num + num2)
    {
        return true;
    }
    return false;
}