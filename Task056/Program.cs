// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumElementsInRows (int[,] matrix)
{
    int [] array = new int[matrix.GetLength(0)]; 
    for (int i = 0, k = 0; i <matrix.GetLength(0); i++, k++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            array[k] += matrix[i,j]; 
        }
    }
    return array;
}

int MinElementPosition (int[] array)
{
    int indexMin = 0;
    int indexMinAdjusted = 1;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            indexMin = i;
            indexMinAdjusted = i + 1;
        }
    }
    return indexMinAdjusted;
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

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 5);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumRow = SumElementsInRows(matrix);
PrintArray(sumRow, "Сумма элементов строк --> ", "");
int indexRow = MinElementPosition(sumRow);
Console.WriteLine($"Номер строки с минимальной суммой элементов --> {indexRow}");
