// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


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

bool IsWithinMatrix (int[,] matrix, int elementRow, int elementColumn)
{
    return elementRow < matrix.GetLength(0) && elementColumn < matrix.GetLength(1);
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 5);
Console.WriteLine("Двумерный массив:");
PrintMatrix (matrix);
Console.WriteLine();

int elemRow = -1;
int elemColumn = -1;

while (elemRow < 0 || elemColumn < 0)
{
    Console.WriteLine ("Задайте номер строки и номер столбца элемента массива через запятую с пробелом:");
    string[] elem = new string[2];
    var readLine = Console.ReadLine();
    if (readLine is not null) elem = readLine.Split(", ");
    elemRow = Convert.ToInt32 (elem[0]);
    elemColumn = Convert.ToInt32 (elem[1]);
    if (elemRow < 0 || elemColumn < 0) Console.WriteLine("Координаты элемента не могут быть отрицательными.");
}

bool isWithinMatrix = IsWithinMatrix(matrix, elemRow, elemColumn);

if (isWithinMatrix == true) 
{
    Console.WriteLine($"Значение элемента с данными координатами в массиве равно {matrix[elemRow, elemColumn]}.");
}
else Console.WriteLine("Данного элемента в массиве нет.");

