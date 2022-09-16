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
    
    double[] mean = new double[m];
    for (int i = 0; i < m; i++)
    {
        
        mean[i] = 0;
        for (int j = 0; j < n; j++)
        {
            mean[i] += array[i, j]; 
        }
        
    }    
return mean;
}




Console.WriteLine();
int[,] myArray = GetArray(m, n, 1, 9);
PrintArray(myArray);
double[] res = AverageArray(myArray);
Console.WriteLine($"{String.Join("; ", res)}");


