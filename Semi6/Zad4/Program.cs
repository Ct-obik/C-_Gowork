// Вывести первые числа Фибоначи с 0 и 1
// Фибоначи число равно сумме двум пред.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int[] array = Fibonachi(num);
Console.WriteLine(String.Join(" ", array));

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

int[] Fibonachi(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
        array[i] = array[i - 2] + array[i - 1];
    return array;
}