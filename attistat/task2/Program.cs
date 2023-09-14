/*
 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int startNumber = SetNumber("первое");
int endNumber = SetNumber("второе");
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {startNumber} до {endNumber} равна: ");
System.Console.WriteLine($"{PrintNumbers(startNumber, endNumber)}\t");

int SetNumber(string message = "")
{
    System.Console.Write($"Введите {message} число  : ");
    return Convert.ToInt32(System.Console.ReadLine());
}


int PrintNumbers(int startNumber, int endNumber)
{
    int sum = default;
    if (startNumber == endNumber) 
    {
        return startNumber;
    }
   
    sum = startNumber + PrintNumbers(startNumber + 1, endNumber);
    return sum;
    
}