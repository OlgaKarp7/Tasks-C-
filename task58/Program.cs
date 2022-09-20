/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MatrixProduct(int[,] myArray1, int[,] myArray2)
{
    var resMatrix = new int[myArray1.GetLength(0), myArray2.GetLength(1)];
      for (var i = 0; i < myArray1.GetLength(0); i++)
  {
    for (var j = 0; j < myArray2.GetLength(1); j++)
    {
      resMatrix[i, j] = 0;
      for (int k = 0; k < myArray1.GetLength(1); k++)
      {
        resMatrix[i, j] += myArray1[i,k] * myArray2[k,j];
      }
    }
  }
  return resMatrix;
}



Console.Write("Введите число строк первой матрицы ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Введите число строк первой матрицы ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите число строк второй матрицы ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Введите число строк второй матрицы ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите последнее число диапазона: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] myArray1 = GetArray(m1, n1, minValue, maxValue);
PrintArray(myArray1);
Console.WriteLine();
int[,] myArray2 = GetArray(m2, n2, minValue, maxValue);
PrintArray(myArray2);
Console.WriteLine();
var result = MatrixProduct(myArray1, myArray2);
Console.WriteLine("Произведение  двух матриц:");
PrintArray(result);
