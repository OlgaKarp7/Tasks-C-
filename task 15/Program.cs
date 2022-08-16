Console.WriteLine("Введите номер дня недели");

int numday = int.Parse(Console.ReadLine());

if(numday != 0 && numday <= 7)
{
    if ( numday == 6 || numday == 7 )
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}