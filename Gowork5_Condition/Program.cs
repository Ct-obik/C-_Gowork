Console.WriteLine("Введи имя пользователя: ");
string username=Console.ReadLine();

if (username.ToLower() == "маша") // .ToLower - переводит в нижний регистр все символы  
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
