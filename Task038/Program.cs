// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return arr; 
}


void PrintArray(double[] arr, string simb1, string simb2)
{
    Console.Write($"{simb1}");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"{simb2}");
}

double MinValue (double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxValue (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

int sizeArray = -1;
while (sizeArray < 1)
{
    Console.Write("Задайте размер массива --> ");
    sizeArray = Convert.ToInt32(Console.ReadLine());
    if (sizeArray < 1) Console.Write("Число должно быть натуральным. ");
}

Console.Write ("Задайте минимально возможный элемент массива --> ");
double minArray = Convert.ToDouble(Console.ReadLine());
Console.Write ("Задайте максимально возможный элемент массива --> ");
double maxArray = Convert.ToDouble(Console.ReadLine());

double[] array = CreateArrayRndDouble(sizeArray, minArray, maxArray);
PrintArray(array, "Массив --> [", "]");

double minValue = MinValue(array);
double maxValue = MaxValue(array);
double diffMaxMin = Math.Round(maxValue - minValue, 1);

Console.WriteLine($"Минимальный элемент массива --> {minValue}");
Console.WriteLine($"Максимальный элемент массива --> {maxValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива --> {diffMaxMin}");

