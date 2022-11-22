//Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
string n;
while (number > 9999 && number < 100000)
{
    int num0 = number / 10000;
    int num1 = (number / 1000) % 10;
    int num3 = (number % 100) / 10;
    int num4 = number % 10;
    if (num0 == num4 && num1 == num3)
    {
        n = "DA";
    }
    else
    {
        n = "NET";
    }
    Console.WriteLine($"{number} -> {n}");
    return;
}
Console.WriteLine("Введено не верное число");