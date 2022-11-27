// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.Clear();
int A = GetNumberFromUser("Ввести число A: ", "Ошибка ввода");
int B = GetNumberFromUser("Ввести число B: ", "Ошибка ввода");

int  OurResult(int A, int B)
{
    int res=1;
    for (int i=1; i<=B; i++)
        {
            res= res*A;
        }
    return res;
}

if (B > 0)
{
int ourresult = OurResult(A, B);
Console.WriteLine($"{A} в степени {B} = {ourresult}");
}
else Console.WriteLine("Введите верное число");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber));
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
