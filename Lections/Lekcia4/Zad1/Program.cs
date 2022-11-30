// Знакомимся с двумерными массивами 
string [,] table = new string [2,5];
// string.Empty                             2-4 по умолчанию нам выводит пустые строки
// table[0,0] table[0,1] ... table[0,4]
// table[1,0] table[1,1] ... table[1,4]
table[1, 2]= "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
// То же самое, но с числами
//int[,] matrix = new int[3, 4];
                                        // для работы в циклах или массивах, может потребоваться такое:
//for (int i = 0; i < 3; i++)           3 -> matrix.GetLength(0) где 0 указывает индекс в new int[3, 4]
//{
//    for (int j = 0; j < 4; j++)       4 -> matrix.GetLength(1) где 1 указывает индекс в new int[3, 4]
//   {
//        Console.Write($"{martix[i, j]} ");
//    }
//Console.WriteLine();
//}

// в результате мы увидим нули в виде матрицы
// 0 0 0 0
// 0 0 0 0
// 0 0 0 0