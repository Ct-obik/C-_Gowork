Console.WriteLine("Первое число: ");
int number1 =int.Parse(Console.ReadLine());

Console.WriteLine("Второе число: ");
int number2 =int.Parse(Console.ReadLine());

int numbersqr=number2*number2;

if (numbersqr == number1)
{
    Console.WriteLine("Первое число является");
}
else 
{
    Console.WriteLine("Первое число НЕ является");
}
