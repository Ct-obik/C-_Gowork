// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Пояснение: 
// 1) (АхВ)*(СхD) - имеет смысл только при В=С
// 2) (АхВ)*(СхD) = (АхD) - новая матрица

Console.Clear();
int rows1 = GetNumberFromUser("Введите количество строк 1 массива: ", "Ошибка ввода!");
int columns1 = GetNumberFromUser("Введите количество столбцов 1 массива: ", "Ошибка ввода!");
int rows2 = GetNumberFromUser("Введите количество строк 2 массива: ", "Ошибка ввода!");
int columns2 = GetNumberFromUser("Введите количество столбцов 2 массива: ", "Ошибка ввода!");
Console.WriteLine();
int[,] array1 = GetArray(rows1, columns1, 0, 4);
int[,] array2 = GetArray(rows2, columns2, 0, 4);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
// int[,] newArray = ResultOf2Array(array1,array2);
if (columns1 != rows2) Console.WriteLine("Произведение этих матриц найти невозможно!");
else
{
    int[,] newArray = ResultOf2Array(array1, array2);
    PrintArray(newArray);
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

int[,] ResultOf2Array(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int row = 0; row < array1.GetLength(0); row++)
    {
        for (int column = 0; column < array2.GetLength(1); column++)
        {
            for (int i = 0; i < array2.GetLength(1); i++)
            {
                result[row, column] += array1[row, i] * array2[i, column];
            }
        }
    }
    return result;
}