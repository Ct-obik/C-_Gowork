// Задайте двумерный массив размером m*n
// заполненный случ. целыми числами
Console.Clear();
Console.Write("Введите кол-во строк массива: ", "Ошибка ввода!");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ", "Ошибка ввода!");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);  // запятая - размерность массива: "int[]" - одномерный массив 
PrintArray(array);                              // "int[,]" - двумерный массив и так далее

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
    for (int i = 0; i < inArray.GetLength(0); i++)    // GetLength(номер измирения) - фун-я, позволяет ссылаться на некую цифру, начиная с нуля, чтобы взять кол-во эл-ов
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");  // Выводим на экран
        }
        Console.WriteLine();
    }
}