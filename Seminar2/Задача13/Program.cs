// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int TakeNumber(int startnum)
{
    System.Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

bool ValidateMessage(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет! Повторите ввод!");
        return false;
    }
    else 
    {
        return true;
    }
}

int GetThirdDigit(int number)
{
    while (number > 999) 
    {
        number /= 10;
    }
    return number % 10;
}

int number = TakeNumber(100);
if (ValidateMessage(number))
{
    System.Console.WriteLine(GetThirdDigit(number));
}
