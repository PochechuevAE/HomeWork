/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int endNumber = SetNumber("иниересующее Вас");
System.Console.WriteLine($"Натуральные числа в промежутке от {endNumber} до 1: ");
System.Console.WriteLine($"{PrintNumbers(1, endNumber)}\t");

int SetNumber(string message = "")
{
    System.Console.Write($"Введите {message} число  : ");
    return Convert.ToInt32(System.Console.ReadLine());
}

string PrintNumbers(int startNumber, int endNumber)
{
    if (startNumber == endNumber) 
    {
        return startNumber.ToString();
    }
    
    return endNumber + " " + PrintNumbers(startNumber, endNumber - 1);
}