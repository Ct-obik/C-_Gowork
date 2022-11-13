Console.WriteLine("Введите число: ");
double numbera=Convert.ToDouble(Console.ReadLine());

if (numbera%2 ==0)
{
    Console.WriteLine($"Число {numbera} чётное");
}
else
{
Console.WriteLine($"Число {numbera} НЕчётное");
}