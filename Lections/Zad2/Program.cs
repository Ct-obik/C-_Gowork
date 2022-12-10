// Нахождение 
int n = 1;
void FindWords (string alphabet, char[] word, int length= 0)
{
    if( length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length+1);
    }
}
FindWords("аисв", new char[2]);

            // получение информации (например о создании папки)
//string path = "C:\Users\Стасик\Desktop\Учёба\C#";
//DirectoryInfo di =  new DirectoryInfo(path);
//System.Console.WriteLine(di.CreationTime);
            // или список папок
//FileInfo[] fi = di.GetFiles();
//for (int i = 0; i< length; i++)
//{
//    System.Console.WriteLine(fi[i].Name);
//}
            // С помощью рекурсии смотрим папки и что в них, используя задаваемый путь.
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files =  catalog.GetFiles();
    for ( int i =0; i<files.Length; i++ )
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = "C:/Users/Стасик/Desktop/Учёба/C#/Lections/Zad1";
CatalogInfo(path);