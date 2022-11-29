// Создаём копию массива

Console.Clear();
int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
int[] copyArray = CopyArray1(array);
Console.WriteLine(String.Join(" ", copyArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}
