// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


void PrintArray(int[] arr, string simb1, string simb2)
{
    Console.Write($"{simb1}");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"{simb2}");
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Задайте размер массива --> ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size, 100, 999);
PrintArray(array, "Массив --> [", "]");
int countEvenNumbers = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел массива --> {countEvenNumbers}");

