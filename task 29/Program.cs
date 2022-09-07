/* Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33] */

Console.WriteLine("Введите длину массива N и его пределы [a, b)  ");
int N = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

void RandArray()
{
    int[] arr = new int[N];

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a,b);
        //Console.Write("{0} ", arr[i]);
    }

    Console.WriteLine($"[{String.Join(",",arr)}]");
}

RandArray();