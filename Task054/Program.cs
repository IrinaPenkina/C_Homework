// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowInDescendingOrder (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] arrayRow = new int[matrix.GetLength(1)];
        for (int j = 0, k = 0; j < matrix.GetLength(1); j++, k++)
        {
            arrayRow[k] = matrix[i,j];
        }
        Array.Sort(arrayRow, (x, y) => y.CompareTo(x));
        for (int j = 0, k = 0; j < matrix.GetLength(1); j++, k++)
        {
            matrix[i,j] = arrayRow[k];
        }
    }
}


int[,] matrix = CreateMatrixRndInt(4, 4, 0, 5);
PrintMatrix(matrix);
Console.WriteLine();
SortRowInDescendingOrder(matrix);
PrintMatrix(matrix);


