// 62 Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
Console.WriteLine();

if (rows < 2 || columns < 2) Console.WriteLine("Введите другие числа");
else
{
    int[,] array = new int[rows, columns];
    array = FillBySpiral(array);
    PrintArray(array);
}
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
// Заполнение по спирали
int[,] FillBySpiral(int[,] array)
{
    int i = 0;
    int j = 0;
    int el = 1;
    while (el <= rows * columns)
    {
        while (j + 1 < rows)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = el;
                el++;
            }
            if (el > rows * columns || array[i, j + 1] != 0)
                break;
            j++;
        }
        while (i + 1 < columns)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = el;
                el++;
            }
            if (el > rows * columns || array[i + 1, j] != 0)
                break;
            i++;
        }
        while (j - 1 >= 0)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = el;
                el++;
            }
            if (el > rows * columns || array[i, j - 1] != 0)
                break;
            j--;
        }
        while (i - 1 >= 1)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = el;
                el++;
            }
            if (el > rows * columns || array[i - 1, j] != 0)
                break;
            i--;
        }
    }
    return array;
}
