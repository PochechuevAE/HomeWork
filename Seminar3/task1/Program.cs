public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Проверка, что число пятизначное
        if (number < 10000 || number > 99999)
        {
            System.Console.WriteLine("Число не пятизначное");
            return false;
        }

        // Преобразование числа в строку для сравнения символов
        string numberStr = number.ToString();
        int length = numberStr.Length;

        // Сравниваем символы с обоих концов числа
        for (int i = 0; i < length / 2; i++)
        {
            if (numberStr[i] != numberStr[length - 1 - i])
            {
                return false; // Если хоть одна пара не совпадает, число не палиндром
            }
        }

        return true; // Если все пары символов совпадают, число является палиндромом
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64346;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
