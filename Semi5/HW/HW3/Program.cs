// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int arraySize = new Random().Next(3, 10);
int[] array = GetArray(arraySize, -100, 100);
Console.WriteLine(String.Join(" ", array));
int min = FindMinNumber (array);
int max = FindMaxNumber (array);
Console.Write(String.Join(" - ", max, min));
Console.Write($" = {max-min}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int FindMinNumber (int[] array)
{
    int min = array[0];
    foreach (int el in array)
    {
        if (el < min)
            min = el;
    }
    return min;
}

int FindMaxNumber (int[] array)
{
    int max = array[0];
    foreach (int el in array)
    {
        if (el > max)
            max = el;
    }
    return max;
}