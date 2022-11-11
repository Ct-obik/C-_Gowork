Console.Write("Введите целое число и нажмите ENTER: ");
string? userinput = Console.ReadLine();
int number = int.Parse(userinput);
int result = number*number;
Console.WriteLine($"{number} -> {result}");