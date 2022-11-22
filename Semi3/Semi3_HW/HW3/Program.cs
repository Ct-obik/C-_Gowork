// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
int N = 0;
InitNumberByUser(ref N);
PrintTabByCube(N);

static void InitNumberByUser(ref int N)
{
    try
    {
        Console.Write("Введите число N: ");
        N = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    } 
    Console.Write($"{N} -> ");
}
static void PrintTabByCube(int N)
{
    for (int i=1; i<=N; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write($"{result}  ");
    }
}