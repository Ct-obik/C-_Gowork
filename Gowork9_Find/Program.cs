int[] array = { 4, 56, 34, 54, 32, 6, 7, 89, 89};
int n = array.Length;
int find = 89;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Нашли число: {index}");
        break;  // Команда для остановки поиска, чтобы не показывать дублирующие значения 
    }
    index++;
}
