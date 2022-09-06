/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

Console.WriteLine("Введите числа a и b  ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int GetExpNum(int a)
{
    int res = 1;
    
    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    return res;

}

Console.WriteLine(GetExpNum(a));