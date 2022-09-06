/*  Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число number ");
int number = int.Parse(Console.ReadLine());

int SumCount(int a)
{
    int sum = 0;
    while(a != 0)
    {
        sum += a%10;   
         a /= 10;
    }
    return sum;
}

Console.Write(SumCount(number));
