// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine(" |");
    }
}

double[] ColumnsAverage (int[,] matrix)
{
    double[] columnsAverage = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double columnSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnsAverage [j] = Math.Round((columnSum += matrix[i,j]) / matrix.GetLength(0), 1);
        }
    }
    return columnsAverage;
}

void PrintArray (double[] arr, string symb1, string symb2)
{
    Console.Write($"{symb1} ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write($"{arr[arr.Length - 1]}{symb2}");
}

Console.WriteLine("Двумерный массив:");
int[,] matr = CreateMatrixRndInt(5, 10, 0, 5);
PrintMatrix(matr);
double[] colAverage = ColumnsAverage(matr);
Console.WriteLine();
PrintArray (colAverage, "Среднее арифметическое каждого столбца: ", ".");

