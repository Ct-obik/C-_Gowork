int Max(int arg1, int arg2, int arg3)   // Отвечает за поиск MAX из 3
{
    int result=arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;              // Метод возвращает нам result
}
int[] array = { 11, 15, 37, 12, 11, 2, 5, 97, 65 };   // Помним, что индекс начинается с 0

int max =Max(Max(array));
Console.Write.WriteLine(max);