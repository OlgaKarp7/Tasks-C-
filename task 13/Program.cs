Console.WriteLine("Введите число num ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (num > 999) 
{
    Console.WriteLine((num / 100) % 10);
}

else
{
    Console.WriteLine(num / 100);
}


