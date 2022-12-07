// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication (int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] matrixMult = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int l = 0; l < columnsB; l++)
        {
            for (int j = 0, k = 0; j < columnsA; j++, k++)
            {
                matrixMult[i, l] += matrixA[i,j] * matrixB[k,l];
            }
        }
    }
    return matrixMult;
}


Console.Write("Задайте количество строк первой матрицы: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов первой матрицы: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество строк второй матрицы: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов второй матрицы: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

if (columnsA != rowsB) 
    Console.WriteLine("Перемножение матриц невозможно.");
else if (rowsA <= 0 || columnsA <= 0 || rowsB <= 0 || columnsB <= 0 ) 
    Console.WriteLine("Числа заданы некорректно. Программа не будет выполнена.");
else
{
    int[,] matrixA = CreateMatrixRndInt(rowsA, columnsA, 0, 5);
    int[,] matrixB = CreateMatrixRndInt(rowsB, columnsB, 0, 5);
    Console.WriteLine("Первая матрица:");
    PrintMatrix(matrixA);
    Console.WriteLine();
    Console.WriteLine("Вторая матрица:");
    PrintMatrix(matrixB);
    Console.WriteLine();
    int[,] matrixMult = MatrixMultiplication(matrixA, matrixB);
    Console.WriteLine("Результат перемножения матриц:");
    PrintMatrix(matrixMult);
}
