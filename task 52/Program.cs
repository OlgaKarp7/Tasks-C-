/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
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

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 100);
PrintArray(myArray);

int[,] AverageArray(int[,] array)
{
            int mean = 0;
            if (m = 0 && n < )
            {
                mean += array[m, n];
            }
            return mean;
            else (n = array.Length)
            {
                mean = mean / n;
                Console.Write(mean);
            }
}
    
    
Console.WriteLine();
myArray = GetArray(m, n, 0, 100);
PrintArray(myArray);
int resultSum = AverageArray(myArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: {resultSum}");


/*int SumDiagonalArray(int[,] array)
{
    int diagSum = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                diagSum += array[i, j];
            }
        }
    }
    return diagSum;
}

int[,] myArray = GetArray(rows, colums);
PrintArray(myArray);
Console.WriteLine();
int resultSum = SumDiagonalArray(myArray);
Console.WriteLine($"Сумма: {resultSum}");*/
