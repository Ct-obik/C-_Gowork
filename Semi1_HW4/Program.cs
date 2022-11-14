Console.Write("Введите число: ");
double n=Convert.ToDouble(Console.ReadLine());
int count =0;
while (count <n)

{
    int chet=count+1; 
    if (chet%2 ==0)
{
    Console.Write($"{chet} ");
}
count++;
}