int Max(int arg1, int arg2, int arg3)   // Отвечает за поиск MAX из 3
{
    int result=arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;              // Метод возвращает нам result
}
int a1=5;
int a2=15;
int a3=7;
int a4=19;
int a5=4;
int a6=11;
int a7=12;
int a8=21;
int a9=16;

int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);     // Этот блок можно привести в вид:
                                    // int max=Max(Max(a1, a2, a3),Max(a4, a5, a6),Max(a7, a8, a9))
Console.WriteLine(max);
