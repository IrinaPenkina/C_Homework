// Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int size = -1;
while (size <= 0)
{
    Console.WriteLine("Задайте размер массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    if (size <= 0) Console.WriteLine("Число должно быть натуральным");
}

Console.WriteLine("Задайте минимальный элемент массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте максимальный элемент массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillArray(int[] arr, int length, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}

void PrintArray(int[] arr, int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

FillArray(array, size, minimum, maximum);
PrintArray(array, size);
