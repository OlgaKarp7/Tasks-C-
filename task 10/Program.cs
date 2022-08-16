Console.WriteLine("Введите число num ");

int num = int.Parse(Console.ReadLine());
int res = (num % 100) / 10;

Console.Write($"Вторая цифра числа {num} это {res}");
