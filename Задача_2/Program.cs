// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int num1 = new Random().Next(0, 100);
Console.WriteLine("Первое число: " + num1);
int num2 = new Random().Next(0, 100);
Console.WriteLine("Второе число: " + num2);


if (num1 > num2)
{
    Console.WriteLine("Наибольшее из двух чисел " + num1 + " Наименьшее из двух чисел " + num2);
}

else if (num2 > num1)
{
    Console.WriteLine("Наибольшее из двух чисел " + num2 + " Наименьшее из двух чисел " + num1);
}

else if (num1 == num2)
{
    Console.WriteLine("Числа равны " + num1);
}