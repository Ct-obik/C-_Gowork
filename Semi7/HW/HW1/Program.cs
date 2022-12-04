// 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// (типы вещ-ых чисел: float, double, long double)

Console.Clear();
int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
double[,] matrix = GetArray(row, col, -10, 10);
PrintArray(matrix);

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

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {            // далее создаём вещественное число
            var random= new Random();
            double r=random.NextDouble();
            result[i, j] =Math.Round((r * (maxValue - minValue) + minValue), 2); 
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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