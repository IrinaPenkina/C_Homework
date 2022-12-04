// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateDoubleMatrix (int rows, int columns, int min, int max)
{
    double[,] matr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
        }
    }
    return matr;
}

void PrintMatrix (double[,] matr)
{
    for (int i = 0; i< matr.GetLength(0); i++)
    {
        Console.Write ("| ");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write ($"{matr [i, j], 4} ");
        }
        Console.WriteLine ("|");
    }
}

double [,] matrix = CreateDoubleMatrix(10, 15, -3, 5);
Console.WriteLine("Двумерный массив: ");
PrintMatrix (matrix);

