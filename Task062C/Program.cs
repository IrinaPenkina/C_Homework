// Спиральное заполнение массива - общий случай


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


const int n = 6;
const int m = 6;
int[,] mas = new int[n, m];

int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = m;
 
for (int i = 0; i < mas.Length; i++) 
{
    mas[row, col] = i + 1;
    if (--visits == 0) 
    {
        visits = m * (dirChanges % 2) + n * ((dirChanges + 1) %2 ) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
}

PrintMatrix(mas, "Спирально заполненный двумерный массив: ");


