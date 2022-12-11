// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akk (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM != 0 && numN == 0) return Akk(numM - 1, 1);
    return Akk(numM - 1, Akk(numM, numN - 1));
}

Console.Write("Задайте первое неотрицательное целое число: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе неотрицательное целое число: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sum = Akk(numM, numN);
Console.WriteLine($"Функция Аккермана от аргументов ({numM}, {numN}) равна {sum}");