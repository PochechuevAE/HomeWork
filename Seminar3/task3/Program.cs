public class Answer
{
    static void ShowCube(int N)
    {
        if (N <= 0)
        {
            Console.WriteLine("Число N должно быть положительным.");
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"Куб числа {i} равен {cube}");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значение N для отправки кода на Выполнение
            N = 6; // Пример: вывод кубов от 1 до 6
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}
