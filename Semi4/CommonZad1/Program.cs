Console.Clear();
int number = GetNumberFromUser("Ввести число: ", "Ошибка ввода");
int sumNumbers = GetSumNumber(number);
Console.WriteLine($"{number} -> {sumNumbers}");




int GetSumNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
        sum += i;    // =+ - помогает сразу прибовлять к пред. sum = sum + i
    return sum;
}
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))       // тоже самое isCorrect == true
            return userNumber;
        else    // else можно убрать т.к. выше есть return
            Console.WriteLine(errorMessage);
    }
}