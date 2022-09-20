/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);

            return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i, j]} ");
        Console.WriteLine();   
    }
}

void SortArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temporary = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
}            


Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int maxValue = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();
SortArrayRows(myArray);
Console.WriteLine();
PrintArray(myArray);



