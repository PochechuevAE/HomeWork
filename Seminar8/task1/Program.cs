/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int rows = SetNumber("Строк");
int columns = SetNumber("Колонок");
int[,] matrix = GetMatrix(columns: columns, rows: rows);
PrintArray(matrix);
System.Console.WriteLine("Измененный массив выглядит так: ");
ChangeNumRows(matrix);
PrintArray(matrix);

void ChangeNumRows(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {

        int[] tempArray = new int[matrix.GetLength(1)];

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            tempArray[col] = matrix[rows, col];
        }

        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[rows, col] = tempArray[col];
        }
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

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            System.Console.Write($"{matr[rows, columns]} ");
        }
        System.Console.WriteLine();
    }
}

int SetNumber(string message = "")
{
    System.Console.Write($"Введите число {message} : ");
    return Convert.ToInt32(System.Console.ReadLine());
}
