/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] GetArray(int m, int minValue, int maxValue)
{
    int[,] result = new int[m, m];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < m; j++)
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


int[] SumElemRows(int[,] array)
{
    int[] mean = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        mean[i] = sum;
    }    
return mean;
}


int MinSumElem(int[] array)
{
    int minSum = array[0];
    int index = 0;
    for (int i = 0; i < array.Length - 1; i++) 
        {
            if (minSum < array[i]);  minSum = array[i]; index = i;
        }
        return index;
}
    

Console.Write("Введите размер прямоугольного массива m : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();
int[] res = SumElemRows(myArray);
Console.WriteLine($"{String.Join("; ", res)}");

Console.WriteLine($"{MinSumElem(res) + 1} - строкa с наименьшей суммой элементов ");


