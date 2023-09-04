// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int [] arr = GenerateArray(5);
System.Console.WriteLine("Выбран массив:");
PrintArray(arr);
int a = FindMax(arr);
int b = FindMin(arr);
int raz = a - b;
System.Console.WriteLine($"Максимальный элемент массива равен: {a}, а минимальный: {b}");
System.Console.WriteLine($"Разница максимального и минимального элементов массива равна: {raz}");

int FindMax(int[] array)
{
    int max = array[0];

    for(int i = 1; i < array.Length; i++) 
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int FindMin(int[] array)
{
    int min = array[0];

    for(int i = 1; i < array.Length; i++) 
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int [] GenerateArray(int Length) 
{
    int [] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 100);
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
