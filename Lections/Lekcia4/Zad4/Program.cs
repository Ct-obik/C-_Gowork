double Factorial (int n)   // Если число большое, используем double
{
    if (n==1) return 1;
    else return n *Factorial(n-1);
}

//Console.WriteLine(Factorial(3));  - Показывает нам факториал от 3

// Можно использовать и цикл
for (int i = 1; i<40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");    // Показывает нам красиво
}   