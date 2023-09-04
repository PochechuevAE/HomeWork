// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] arr = GenerateArray(5);
System.Console.WriteLine("Выбран массив:");
PrintArray(arr);
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях равна: {GivSumEvenPozitionElements(arr)}");

int GivSumEvenPozitionElements(int[] array)
{
    int sum = default;

    for(int i = 0; i < array.Length; i++) 
    {
        if(i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int [] GenerateArray(int Length) 
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 20);
    }

    return result;
} 

void PrintArray(int [] array)
{
    foreach (int i in array)
    {
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
}