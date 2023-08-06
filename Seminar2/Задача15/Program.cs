// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int TakeNumberOfDay(int numberday)
{
    System.Console.WriteLine("Введите день недели номер дня недели от 1 до 7: ");
    int numberofday = int.Parse(Console.ReadLine());
    return numberofday;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool ValidateMessage(int number)
{

    if (number > 0 && number <= 7)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Введите номер дня недели от 1 до 7!!!");
        return false;
    }
}

int weekDay = TakeNumberOfDay(7);
if (ValidateMessage(weekDay))
{
    if (IsWeekend(weekDay))
    {
        System.Console.WriteLine("Выходной день!");
    }
    else
    {
        System.Console.WriteLine("Работаем! Выходным и не пахнет!");
    }
}