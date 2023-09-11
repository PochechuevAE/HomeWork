/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rowsA = new Random().Next(2, 5);
int colsA = new Random().Next(2, 5);
int rowsB = new Random().Next(2, 5);
int colsB = new Random().Next(2, 5);
int[,] matrixA = GenerateRandomMatrix(rowsA, colsA);
int[,] matrixB = GenerateRandomMatrix(rowsB, colsB);
System.Console.WriteLine("Матрица A:");
PrintMatrix(matrixA);
System.Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);

if (colsA != rowsB)
{
    System.Console.WriteLine("Умножение матриц невозможно. Количество столбцов матрицы A не равно количеству строк матрицы B.");
    return;
}

int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

System.Console.WriteLine("Результат умножения матриц:");
PrintMatrix(resultMatrix);

int[,] GenerateRandomMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }

    return matrix;
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
