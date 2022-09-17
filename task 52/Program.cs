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


double[] AverageArray(int[,] array)
{
    double[] mean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        mean[i] = Math.Round(sum / array.GetLength(0), 1);
    }    
return mean;
}
/*int[] AverageArray(int[,] matr)
{
    int rows = matr.GetLength(0);
    int cols = matr.GetLength(1);

    int[] result = new int[cols];
    int row = 0;
    int col = 0;

    for (int i = 0; i < cols; i++)
    {
        result[i] = 0;

        while (row < rows)
        {
            result[i] = result[i] + matr[row, col];
            row++;
        }

        result[i] = result[i];
        col++;
        row = 0;

    }

    return result;
}*/

Console.WriteLine();
int[,] myArray = GetArray(m, n, 1, 9);
PrintArray(myArray);
int[] res = AverageArray(myArray);
Console.WriteLine($"{String.Join("; ", res)}");


