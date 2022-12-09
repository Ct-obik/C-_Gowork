// 55 Создайте двумерный массив. Напишите программу,
// которая заменяет смтроки на столбцы. В случае,
// если это невозможно, программа должная вывести сообщение для пользователя.

Console.Clear();
Console.Write("Введите кол-во строк массива: ", "Ошибка ввода!");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ", "Ошибка ввода!");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);  
int[,] newReversArray = ReversArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(newReversArray);
                  

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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

int[,] ReversArray(int[,] arr)
{
    int[,] revers = new int[arr.GetLength(1), arr.GetLength(0)] ;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            revers[i,j] = arr[j,i];
        }
    }
    return revers;
}