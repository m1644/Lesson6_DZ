// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь.

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array [i]} ");
    Console.WriteLine();
}

void NumberMax(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во элементов больше 0: {count}");
}

int[] arr = CreateArray(10);
PrintArray(arr);
NumberMax(arr);
