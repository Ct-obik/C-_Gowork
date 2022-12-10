// 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
int x = GetNumberFromUser("Введите число слоев массива: ", "Ошибка ввода!");
int y = GetNumberFromUser("Введите число строк массива: ", "Ошибка ввода!");
int z = GetNumberFromUser("Введите число столбцов массива: ", "Ошибка ввода!");
int n = 89; // Кол-во положительных четных чисел

if (n < x * y * z) Console.WriteLine("Наш массив будет содержать повторяющиеся двузначные числа! Запустите программу заново.");
else
{
    int[,,] array = Get3dArray(x, y, z);
    PrintArray(array);
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

int[,,] Get3dArray(int x, int y, int z)
{
    int[,,] newArray = new int[x, y, z];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                newArray[i, j, k] = GetNoCloneNumber(newArray, 10, 99, i, j, k);
            }
        }
    }
    return newArray;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Убираем повторения
int GetNoCloneNumber(int[,,] array, int min, int max, int i, int j, int k)
{
    int value = 0;
    bool exist = true;
    while (exist)
    {
        bool break1 = false;
        value = new Random().Next(min, max + 1);
        for (int i1 = 0; i1 < array.GetLength(0); i1++)
        {
            if (break1) break;
            for (int j1 = 0; j1 < array.GetLength(1); j1++)
            {
                if (break1) break;
                for (int k1 = 0; k1 < array.GetLength(2); k1++)
                {
                    if (array[i1, j1, k1] == value)
                    {
                        break1 = true;
                        break;
                    }
                    if (i1 == i && j1 == j && k1 == k) exist = false;
                }
            }
        }
    }
    return value;
}