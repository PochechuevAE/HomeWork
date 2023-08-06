// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int num = new Random().Next(-100, 100);
System.Console.WriteLine("Задано число: " + num);
int numCount = 1;
System.Console.WriteLine("Все чётные числа от 1 до " + num + ":");
if (num > 0)
{
    while (numCount <= num)
    {
        if (numCount % 2 == 0)
        {
            System.Console.WriteLine(numCount);
        }
        numCount++;
    }
}
if (num == 1)
{
    System.Console.WriteLine("Нет чётных чисел");
}
if (num <= 0)
{
    while (numCount >= num)
    {
        if (numCount % 2 == 0)
        {
            System.Console.WriteLine(numCount);
        }
        numCount--;
    }
}