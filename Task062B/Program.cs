
// Дана квадратная матрица размером n * n (n <= 10).
// Найти последовательность чисел при чтении матрицы по спирали.
// Вывод - одна строка.


int[,] mas = new int[5, 5];
mas = InputTestMatrix();
int n = 5;


void SpiralPath()
{
    int x = 0;
    int y = 0;
    int sx = 1;
    int sy = 0;
    string answer = mas[x,y].ToString();
    int minx = 0; // изначальные границы считывания
    int miny = 1; // если 0 то выезжаем в первую строку на втором круге
    int maxx = n - 1;
    int maxy = n - 1;
    bool found;  // нужно для остановки цикла
    do
    {
        found = false;
        while ((sx > 0 && x < maxx) ||     // условия невываливания за границы считывания
                (sx < 0 && x > minx) ||
                (sy > 0 && y < maxy) ||
                (sy < 0 && y > miny) )
        {
            x += sx;  // поворот
            y += sy;  
            answer += " " + mas [y, x];  // запоминание результата; сначала y поотом х
            found = true;  // проверка, что результат найден
        }

        if (sx < 0) minx = x + 1;    // изменения границ для следующего этапа, чтобы получилась спираль, а не круг
        if (sx > 0) maxx = x - 1;
        if (sy < 0) miny = y + 1;
        if (sy > 0) maxy = y - 1;

        int sx_old = sx;  // поворот для следующего этапа цикла
        sx = -sy;
        sy = sx_old;
        Console.WriteLine(answer);  // вывод результата текущего этапа
        
    } while (found);
    
}

// bool InRange (int x, int y)
// {
//     if ( x < 0 || x >= n) return false;
//     if ( y < 0 || y >= n) return false;
//     if (mas[y,x] == -1) return false;
//     return true;
// }


int[,] InputTestMatrix()
{
    int [,] mas = new int[5,5] 
    {
        {1, 2, 3, 4, 5},
        {4, 5, 6, 7, 8},
        {7, 8, 9, 1, 3},
        {4, 5, 6, 7, 8},
        {7, 8, 9, 1, 3} };
    return mas;
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

SpiralPath();
PrintMatrix(mas, "");

// youtube
// C# - Консоль - Олимпиада - Квадратная спираль
// Евгений Волосатов