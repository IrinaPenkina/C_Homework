// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[] CreateArray16ConsequentInt (int min)
{
    int[] array = new int[16];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = min++;
    }
    return array;
}

void PrintArray(int[] arr, string symb1, string symb2)
{
    Console.Write($"{symb1}");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"{symb2}");
}

int[,] CreateSpiralMatrix (int[] arrayElements)
{
    int[,] matrix = new int[4, 4];
    for(int j = 0, k = 0; j <= 3; j++, k++)
    {
        matrix[0, j] = arrayElements[k];
    }
    for (int i = 1, k = 4; i <= 3; i++, k++)
    {
        matrix[i, 3] = arrayElements[k];
    }
    for(int j = 2, k = 7; j >= 0; j--, k++)
    {
        matrix[3, j] = arrayElements[k];
    }
    for (int i = 2, k = 10; i >= 1; i--, k++)
    {
        matrix[i, 0] = arrayElements[k];
    }
    for(int j = 1, k = 12; j <= 2; j++, k++)
    {
        matrix[1, j] = arrayElements[k];
    }
    matrix[2,2] = arrayElements[14];
    matrix[2,1] = arrayElements[15];

    return matrix; 
}


void PrintMatrix(int[,] matrix, string symb1)
{
    Console.WriteLine($"{symb1}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("Программа создает одно- и двумерный массив из шестнадцати последовательных целых чисел.");
Console.Write("Задайте начальное число: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = CreateArray16ConsequentInt(startNumber);
PrintArray(array, "Одномерный массив: ", "");
Console.WriteLine();
int[,] matrix = CreateSpiralMatrix(array);
PrintMatrix(matrix, "Спирально заполненный двумерный массив: ");

