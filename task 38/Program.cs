/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0;i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2);

    }
    return res;
}

double maxVal (double[] mas)
{
    double max = 0;
    for (int i = 0; i < mas.Length; i++)
       {
           if (mas[i] > max)
           {
             max = mas[i];
           }
             
       }
    return max;

}  

double minVal (double[] mas)
{
    double min = mas[0];
    for (int i = 0; i < mas.Length; i++)
       {
           if (min > mas[i])
           {
             min = mas[i];
           }
            
       }
    return min;

}  


double[] array = GetArray(6, 2, 12);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"{maxVal(array) - minVal(array)}");
