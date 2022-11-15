void FillArray(int[] numbers)   // При использовании void нам не нужно использовать команду return
{
    int Length = numbers.Length;
    int index = 0;
    while (index < Length)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }
}                           // 1-10 Мы указываем, что в массиве должны быть разные числа
void PrintArray(int[] num)  // 
{
    int count=num.Length;
    int position =0;
    while(position<count)
    {
        Console.WriteLine(num[position]);
        position++;
    }
}                           // 11-20 Мы выводим на экран
int[] array = new int[10];  // создаём массив из 10 элементов
FillArray(array);           // это метод с 1-10 заполняет наш массив
PrintArray(array);          // этот метод показывает