﻿Console.WriteLine("Введите число 1 ");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int b =int.Parse(Console.ReadLine());
int c = b % a;
string res;
if(c==0)
{
    res="кратно";
}
else
{
    res = "не кратно";
}
Console.WriteLine();