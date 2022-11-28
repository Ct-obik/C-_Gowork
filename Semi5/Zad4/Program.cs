// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] array = GetArray(123, 0, 1000);
int count = CountNumbers(array, 10, 99);
Console.Write(String.Join(" ", array));
Console.WriteLine($" Rоличество элементов массива от 10 до 99 = {count}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int CountNumbers(int[] array, int minValue, int maxValue)
{
    int count = 0;
    foreach (int el in array)
    {
        if (minValue <= el && el <= maxValue)
        {
            count += 1;
        }
    }
    return count;
}