// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int num = GetNumberFromUser("Введите целое число массива: ", "Ошибка ввода!");
int numbers = CountPosNumbers(num);
Console.WriteLine($"Больше нуля = {numbers} ");

int CountPosNumbers(int num)
{
    int count = 0;
    int[] array = new int[num];
    for (int i = 0; num > i; i++)
    {
        array[i] = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
        if (array[i] > 0) count++;

    }
    return count;
}

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