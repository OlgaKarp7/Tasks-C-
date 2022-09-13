/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы(через пробел): ");
int[] mas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > 0)
    {
        count++;
    }
}

 Console.WriteLine($" Элементов больше 0: {count}");*/

Console.WriteLine("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());

void Number(int M)
{
    int count = 0;

    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите числа ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля: {count}");
}
Number(M);


