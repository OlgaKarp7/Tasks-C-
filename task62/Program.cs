/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            for (int k = 0; k < result.GetLength(2); k++)
            result[x, y, z] = new Random().Next(10, 100);

            return result;
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++) {
        
        for (int j = 0; j < array3D.GetLength(1); j++)
            for (int k = 0; k < array3D.GetLength(2); k++)
            Console.Write($"X({i}) Y({j}) Z({k})={array3D[i,j,k]};");
        Console.WriteLine();     
    }
}  

Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите последнее число диапазона: ");
int maxValue = int.Parse(Console.ReadLine());


int[,,] Array3D = GetArray(x, y, x, minValue, maxValue);
PrintArray(Array3D);
Console.WriteLine();


