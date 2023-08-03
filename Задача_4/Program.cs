// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
int num1 = new Random().Next(0, 100);
System.Console.WriteLine("Первое число: " + num1);
int num2 = new Random().Next(0, 100);
System.Console.WriteLine("Второе число: " + num2);
int num3 = new Random().Next(0, 100);
System.Console.WriteLine("Третье число: " + num3);

// Первый вариант решения задачи:
if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine("Максимальное число: " + num1);
}

else if (num2 > num1 && num2 > num3)
{
    System.Console.WriteLine("Максимальное число: " + num2);
}

else if (num3 > num1 && num3 > num2)
{
    System.Console.WriteLine("Максимальное число: " + num3);
}
else if (num1 == num2 && num1 == num3)
{
    System.Console.WriteLine("Числа равны и все максимальные: " + num1);
}
else if (num1 == num2 && num1 > num3)

{
    System.Console.WriteLine("Первое число равно второму и они максимальны: " + num1);
}

else if (num1 == num3 && num1 > num2)

{
    System.Console.WriteLine("Первое число равно третьему и они максимальны: " + num1);
}

else if (num2 == num3 && num2 > num1)
{
    System.Console.WriteLine("Второе число равно третьему и они максимальны:" + num2);
}
//         Второй вариант решения задачи 4:
// int max1 = Math.Max(num1, num2);
// int max2 = Math.Max(num2, num3);
// int max3 = Math.Max(max1, max2);
// System.Console.WriteLine("Наибольшее число через Math.Max: " + max3);