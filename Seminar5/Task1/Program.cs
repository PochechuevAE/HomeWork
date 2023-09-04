// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] arr = GenerateArray(5);
System.Console.WriteLine("Выбран массив:");
PrintArray(arr);
System.Console.WriteLine($"Кол-во чётных чисел в массиве: {CountEvenNumbrs(arr)}");

int CountEvenNumbrs(int[] array)
{
    int count = default;

    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int [] GenerateArray(int Length) 
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
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