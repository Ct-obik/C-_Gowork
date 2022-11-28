// Задайте массив из 12 эл-ов, заполненный случ. числами в промежутках [-9;9]
// Найти сумму отриц-ых и полож-ых элементов массива

Console.Clear();
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));     //String.Join - помогает представить массив ввиде строки

int PositiveSum = GetPositiveSum(array);
int NegativeSum = GetNegativeSum(array);

Console.WriteLine($"Positive sum ={PositiveSum}, negative sum = {NegativeSum} ");

// Возвращаем массив из size элементов,
// заполненный случ. числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetPositiveSum(int[] arr)
{
    int PositiveSum = 0;
    foreach (int el in arr)     // если нам не нужно перебирать эл. массива
    {
        if (el > 0) PositiveSum += el;
    }
    return PositiveSum;
}

// Второй вариант нахождения суммы на примере
int GetNegativeSum(int[] arr)
{
    int NegativeSum = 0;
    foreach (int el in arr)
    {
        NegativeSum += el < 0 ? el : 0;     // Если число меньше 0, то суммируем, иначе число приравниваем к 0 и суммируем уже 0
    }
    return NegativeSum;
}