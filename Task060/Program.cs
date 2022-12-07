// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[] SequenceArray (int min, int max)
{
    int[] array = new int[max + 1 - min];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = min++;
    }
    return array;
}

void Shuffle (int[] arr)
{
    Random rnd = new Random();
    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rnd.Next(i + 1);
        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
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


int[,,] Create3DMatrixUniqueRndInt(int rows, int columns, int depth, int[] arrayElements)
{
    int[,,] matrix = new int[rows, columns, depth];
    int l = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = arrayElements[l];
                l++;
            }       
        }
    }
    return matrix;
}


void Print3DMatrix(int[,,] matrix, string symb1, string symb2)
{
    Console.WriteLine($"{symb1}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1)) Console.Write($"{matrix[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine($"{symb2}");
    }
}


Console.Write("Задайте количество строк массива: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте глубину массива: ");
int depthMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] arrayMatrixElements = SequenceArray(10, 99);
PrintArray(arrayMatrixElements, "Ряд двузначных чисел: \n","");
Shuffle(arrayMatrixElements);
Console.WriteLine();
PrintArray(arrayMatrixElements, "Ряд элементов массива: \n","");
Console.WriteLine();
int[,,] matrix3D = Create3DMatrixUniqueRndInt(rowsMatrix, columnsMatrix, depthMatrix, arrayMatrixElements);
Print3DMatrix(matrix3D, "Трехмерный массив:", "");
