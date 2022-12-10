// Задание собрать строку с числами от А до В.
// Пенрвый вариант:
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));

// Второй вариант с рекурсией:
string NumberRecurtion(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRecurtion(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumberRecurtion(1, 10));

// От большего к меньшему =========================================================
string NumbersForRevers(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersForRevers(10, 1));
// Второй вариант
string NumberReversRecurtion(int a, int b)
{
    if (a <= b) return NumberReversRecurtion(a + 1, b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(NumberReversRecurtion(1, 10));

// Сумма чисел от 1 до N        ============================================================
int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}
Console.WriteLine(SumFor(10));
// С рекурсией
int SumRecFor(int n)
{
    if (n == 0) return 0;
    else return n + SumRecFor(n - 1);
}
Console.WriteLine(SumRecFor(10));

// Факториал          =====================================================
int Factorial(int n)
{
    int result = 1;
    for (int i=1; i <=n; i++) result *=i;
    return result;
}
Console.WriteLine(Factorial(5));
// С рекурсией
int RecFactorial(int n)
{
    if (n==0) return 1;
    else return n*RecFactorial(n-1); 
}
Console.WriteLine(RecFactorial(5));
        // Возвести число А в степень В         ====================================
// 1 вариант
int PowerFor (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++) result *= a;
    return result;
}
Console.WriteLine(PowerFor(5,3));
// С рекурсией
int PowerRecFor (int a, int b)
{        // Это тело можно записать в таком виде: return b == 0 ? 1: PowerRecFor(a,b-1) * b
    if (b==0) return 1;
    else return a * PowerRecFor(a, b-1);
}
Console.WriteLine(PowerRecFor(5,3));
// Учитывая математику, можно улучшить:
int PowerRecMathFor( int a, int b)
{
    if (b==0) return 1;
    else if (b%2 == 0) return PowerRecMathFor(a*a, b/2);
    else return a * PowerRecMathFor(a, b-1);
}
Console.WriteLine(PowerRecMathFor(5,3));