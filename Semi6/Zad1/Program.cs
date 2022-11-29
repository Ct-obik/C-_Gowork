// Перевернуть массив наоборот

Console.Clear();
int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
// первый выбор
int[] reversArray = ReversArray1(array);
Console.WriteLine(String.Join(" ", reversArray));
// второй вариант
ReversArray2(array);
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
    // можно сохранить это для дальнейшего использования, но память зависит от условий
int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
    // проходим в половине элементов массива и плюс экономит память
void ReversArray2(int[] inArray)    
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];                     // чтобы не потерять
        inArray[i] = inArray[inArray.Length - 1 - i];   // перемещаем с конца
        inArray[inArray.Length - 1 - i] = k;        // возвращаем значение
    }
}