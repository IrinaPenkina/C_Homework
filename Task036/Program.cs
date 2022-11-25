// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int SumUnevenPositionElements (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

Console.Write("Задайте размер массива --> ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write ("Задайте минимальный элемент массива --> ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.Write ("Задайте максимальный элемент массива --> ");
int maxArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(sizeArray, minArray, maxArray);
PrintArray(array, "Массив --> [", "]");

int sumUnevenPositionElements = SumUnevenPositionElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях --> {sumUnevenPositionElements}");

