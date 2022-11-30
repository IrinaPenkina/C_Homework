// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindCrossX (double kOne, double bOne, double kTwo, double bTwo)
{
    double x = Math.Round(((bTwo - bOne) / (kOne - kTwo)), 1, MidpointRounding.ToZero);
    return x;
}

double FindCrossY (double x, double kOne, double bOne, double kTwo, double bTwo)
{
    double y = Math.Round((kOne * x + bOne), 1, MidpointRounding.ToZero);
    return y;
}

Console.Write("Задайте коэффициент переменной х в первом линейном уравнении: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте свободный член первого уравнения: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте коэффициент переменной х во втором линейном уравнении: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте свободный член второго уравнения: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double crossX = FindCrossX (k1, b1, k2, b2);
double crossY = FindCrossY (crossX, k1, b1, k2, b2);
Console.WriteLine($"Координаты точки пересечения --> ({crossX}; {crossY})");
