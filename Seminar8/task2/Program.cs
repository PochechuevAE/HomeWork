/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int columns = SetNumber("Колонок ");
int rows = columns + 1;
int[,] matrix = GetMatrix(columns: columns, rows: rows);
PrintArray(matrix);
System.Console.WriteLine();
CountOfElement(matrix);

void CountOfElement(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minSumRows = -1;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int sumRows = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            sumRows += matrix[row, col];
        }

        System.Console.WriteLine($"Сумма строки {row} равна {sumRows} ");

        if (sumRows < minSum)
        {
            minSum = sumRows;
            minSumRows = row;
        }
        
    }
    
    if (minSumRows != -1)
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRows}");
    }


}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(1, 10);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            System.Console.Write($"{matrix[rows, columns]} ");
        }
        System.Console.WriteLine();
    }
}

int SetNumber(string message = "")
{
    System.Console.Write($"Введите число {message} : ");
    return Convert.ToInt32(System.Console.ReadLine());
}