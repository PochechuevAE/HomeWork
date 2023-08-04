// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Вариант решения 2
int num1 = new Random().Next(0, 100);
Console.WriteLine("Первое число: " + num1);
int num2 = new Random().Next(0, 100);
Console.WriteLine("Второе число: " + num2);

if (num1 == num2)
{
    Console.WriteLine("Числа равны!");
}

else
{
    int max = Math.Max(num1, num2);
    System.Console.WriteLine("Максимальное число: " + max + " Минимальное число: " + Math.Min(num1,num2));
}