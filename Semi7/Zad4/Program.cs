// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали  

int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 10);
int sum = GetDiagonalSum(matrix);
PrintArray(matrix);
Console.WriteLine($"Сумма элементов по диагонали = {sum}");

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
            result[i, j] = new Random().Next(minValue, maxValue + 1); ;
        }
    }
    return result;
}

int GetDiagonalSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
            {
                sum += array[i, j];
            }
    }
    return sum;
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