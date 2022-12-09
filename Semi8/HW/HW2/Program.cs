// 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
Console.WriteLine();
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
BubbleSortArray(array);
PrintArray(array);
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

int[] BubbleSort(int[] array)
{   // Пузырьковый метод
    int temp;
    int count = 0;
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                count++;
            }
        }
    }
    return array;
}

void BubbleSortArray(int[,] array)
{
    int[] sortInRow = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortInRow[j] = array[i, j];
        }
        sortInRow = BubbleSort(sortInRow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = sortInRow[j];
        }
    }
}