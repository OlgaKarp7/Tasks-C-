/*  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0;i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}



int numeven(int[] mas)
{
    int count = 0;
    foreach (int el in mas)
       {
           if (el % 2 == 0)
           {
            count++;
           }
           
       }
    return count;
}

int[] array = GetArray(20, 100, 999);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"{numeven(array)}");
