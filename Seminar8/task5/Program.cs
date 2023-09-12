/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int rows = SetNumber("Строк");
int columns = SetNumber("Колонок");
int[,] matrix = GetMatrix(columns: columns, rows: rows);
SpiralArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);


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
            System.Console.Write($"{matrix[rows, columns]:D2} ");
        }
        System.Console.WriteLine();
    }
}

int SetNumber(string message = "")
{
    System.Console.Write($"Введите число {message} : ");
    return Convert.ToInt32(System.Console.ReadLine());
}



void SpiralArray(int[,] matrix)
{
    int currentValue = 1;
    int left = 0, right = matrix.GetLength(0) - 1, top = 0, bottom = matrix.GetLength(0) - 1;

    while (currentValue <= matrix.GetLength(0) * matrix.GetLength(0))
    {

        for (int i = left; i <= right; i++)
        {
            matrix[top, i] = currentValue++;
        }
        top++;


        for (int i = top; i <= bottom; i++)
        {
            matrix[i, right] = currentValue++;
        }
        right--;


        for (int i = right; i >= left; i--)
        {
            matrix[bottom, i] = currentValue++;
        }
        bottom--;


        for (int i = bottom; i >= top; i--)
        {
            matrix[i, left] = currentValue++;
        }
        left++;
    }
}
