// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int length = Promt("Введите кол-во элементов");
int [] array;
array = InputArray(length);
PrintArray(array);
System.Console.WriteLine($"Кол-во чисел больше нуля - {CountPozitiveNumbers(array)}");


int Promt(string messege)
{
    System.Console.WriteLine(messege);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[] InputArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите {i +1} - й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPozitiveNumbers(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}
