// 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

Console.Clear();
int userNum = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int[] array = GetArray(12, -9, 9);
string answer = IsThereANumber(array, userNum);
Console.Write(String.Join(" ", array));
Console.WriteLine($" -> {answer}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

string IsThereANumber(int[] array, int num)
{
    string answer = "";
    foreach (int element in array)
    {
        if (element == num) 
        {
            answer = "да";
            break;
        }
        else answer = "нет";
    }
    return answer;
}