// 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

Console.Clear();
int[] array = GetArray(10, -8, 8);
Console.WriteLine(String.Join(" ", array));
ReplaceSign(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReplaceSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}
