/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] GetArray(int [,,] array3D)
{
    int[,,] result = new int[array3D.GetLength(0), array3D.GetLength(1),array3D.GetLength(2)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
            result[i, j, k] = new Random().Next(10, 100);
            }
        }
    }    
     return result;
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++) {
        
        for (int j = 0; j < array3D.GetLength(1); j++)
            for (int k = 0; k < array3D.GetLength(2); k++)
            Console.Write($"{array3D[i,j,k]} ({i},{j},{k}) ");
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

int[,,] Array3D = new int[x, y, z];
PrintArray(GetArray(Array3D));
Console.WriteLine();

