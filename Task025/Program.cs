// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задайте первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = 0;
while (numberB <= 0)
{
    Console.WriteLine("Задайте второе число: ");
    numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB <= 0) Console.WriteLine("Второе число должно быть натуральным");
}

int Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int degree = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} возведенное в степень {numberB} равно {degree}");

