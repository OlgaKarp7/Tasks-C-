﻿/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите k1: ");
Console.WriteLine("Введите k2: ");
Console.WriteLine("Введите b1: ");
Console.WriteLine("Введите b2: ");
double k1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double b1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());

void Point()
{
    
        double x = -(b1 - b2) / (k1 - k2);
        double y = k1 * x + b1;

   Console.WriteLine($"Пересечение в точке: ({x};{y})");

}
Point();   

/*int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);*/
