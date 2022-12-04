// 50: Напишите программу, которая на вход принимает ПОЗИЦИИ элемента в двумерном массиве, 
// и возвращает ЗНАЧЕНИЕ этого элемента или же указание, что такого элемента нет.

Console.Clear();
int row = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 10);
PrintArray(matrix);
int ruser = GetNumberFromUser("Введите номер сторки: ", "Ошибка ввода!");
int cuser = GetNumberFromUser("Введите номер столбца: ", "Ошибка ввода!");
FindUserNumber(matrix, ruser, cuser);


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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindUserNumber(int[,] array, int row, int col)
{
    if (row > array.GetLength(0) - 1 || col > array.GetLength(1) - 1)
    {
        Console.WriteLine("Такой позиции нет в массиве");
    }
    else Console.WriteLine($"Значение нашего элемента = {array[row, col]}");
}