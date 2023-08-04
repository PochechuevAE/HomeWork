// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// Вариант решения 2
int num1 = new Random().Next(0, 100);
System.Console.WriteLine("Первое число: " + num1);
int num2 = new Random().Next(0, 100);
System.Console.WriteLine("Второе число: " + num2);
int num3 = new Random().Next(0, 100);
System.Console.WriteLine("Третье число: " + num3);

if (num1 == num2 & num1 == num3)
{
    System.Console.WriteLine("Числа равны");
}

else
{
    int max1 = Math.Max(num1, num2);
    int max2 = Math.Max(num2, num3);
    int max3 = Math.Max(max1, max2);
    System.Console.WriteLine("Наибольшее число: " + max3);
}