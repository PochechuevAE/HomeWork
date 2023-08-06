// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100, 1000);
System.Console.WriteLine($"Выбрано число: {num}");
int secondDigit = num / 10 % 10;
System.Console.WriteLine($"Вторая цифра числа: {secondDigit}");