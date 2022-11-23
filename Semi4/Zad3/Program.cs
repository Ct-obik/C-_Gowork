// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int productNumbers = GetProductNumbers(num);
Console.WriteLine($"{num} -> {productNumbers}");
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}
int GetProductNumbers(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i ++) product *= i;
    return product;
}