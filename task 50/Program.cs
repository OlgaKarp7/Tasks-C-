/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет */

Console.Write("r = ");
int r = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию элемента n  ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию элемента m  ");
int m = int.Parse(Console.ReadLine());

int[,] GetArray(int r, int c, int minValue, int maxValue)
{
    int[,] result = new int[r, c];

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = new Random().Next(minValue, maxValue);

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

int PosValueArray(int[,] array)
{
        int num = array[m, n];
        
                if (m > r && n > c) 
                {
                    Console.Write($"Такого числа в массиве нет");
                }
                else
                {
                    Console.Write($"Элемент с позицией [{m}, {n}]  {num}");
                } 
            
         return num;
}



int[,] myArray = GetArray(r, c, 0, 100);
PrintArray(myArray);
Console.WriteLine();
PosValueArray(myArray);





