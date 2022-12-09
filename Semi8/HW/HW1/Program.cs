// 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
int[] MinSum = FindSum(array, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов, равная {MinSum[0]}, находится в {MinSum[1] + 1} строке.");
Console.WriteLine();

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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindSum(int[,] array, int maxValue)
{   // Создаем метод, где есть массив из суммы эл. и с сохранением номера строки. 
    int[] result = new int[2];
    result[0] = maxValue * array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < result[0])
        {
            result[0] = sum;
            result[1] = i;
        }
        sum = 0;
    }
    return result;
}