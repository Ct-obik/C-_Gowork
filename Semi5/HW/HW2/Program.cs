// 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int arraySize = new Random().Next(3, 10);
int[] array = GetArray(arraySize, -100, 100);
Console.WriteLine(String.Join(" ", array));
int result = SumNumbersNoDbl(array);
Console.WriteLine(String.Join(" ", result));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumNumbersNoDbl(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i++)  // Или можно использовать: for (int i = 1; i < array.Length; i += 2)
    {                                       //                          result += array[i]
        if (i % 2 == 0)             
            result = result + 0;
        else result += array[i];
    }
    return result;
}