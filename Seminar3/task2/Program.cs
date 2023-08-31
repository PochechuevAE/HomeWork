public class Answer
{
    private static double DistanceBetweenPoints(int[] pointA, int[] pointB)
    {
        // Проверка, что точки имеют правильное количество координат (3D точки)
        if (pointA.Length != 3 || pointB.Length != 3)
        {
            Console.WriteLine("Неправильное количество координат");
            return -1.0; // Вернуть отрицательное значение, чтобы обозначить ошибку
        }

        int x1 = pointA[0];
        int y1 = pointA[1];
        int z1 = pointA[2];

        int x2 = pointB[0];
        int y2 = pointB[1];
        int z2 = pointB[2];

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return distance;
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = DistanceBetweenPoints(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}
