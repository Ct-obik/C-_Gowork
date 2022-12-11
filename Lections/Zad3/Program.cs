// Задача с пирамидками: перенести блины с одного на другое место, в таком же порядке.
// 3 места и 3 блина.
        // с какого места   на какое место      нейтральное место   количество блинов
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if( count >1) Towers(some, on, with, count - 1);
}
Towers();
// Этот метод позволяет использовать N блинов ТОЛЬКО с 3 местами

// Метод записи выражения ((4-2)*(1+3)) / 10
string emp = String.Empty;
string[] tree = {emp,"/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
void Progress(int pos=1)
{
    if( pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;  // ниже проверяем, не является ли элемент пустым 
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) Progress(left);
        Console.Write(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) Progress(right);
    }
}
Progress();