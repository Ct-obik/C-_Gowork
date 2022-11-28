﻿// 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int[] array = GetArray(10, 100, 999);
Console.WriteLine(String.Join(" ", array));
int result = CountDoubleNumber(array, 100, 999);
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

int CountDoubleNumber(int[] array, int minValue, int maxValue)
{
    int result = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
            result += 1;
    }
    return result;
}