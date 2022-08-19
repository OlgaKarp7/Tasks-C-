//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число number");

int number = int.Parse(Console.ReadLine());

if (number % 10 == number / 10000 & (number % 100) / 10 == (number / 1000) % 10)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
