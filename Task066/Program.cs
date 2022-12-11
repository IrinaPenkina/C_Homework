// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers (int num1, int num2)
{
    if (num2 == num1) return num2;
    return num1 < num2 ? num2 + SumNumbers(num1, num2 - 1): num1 + SumNumbers(num1 - 1, num2);
}

Console.Write("Задайте первое натуральное число: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе натуральное число: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(numM, numN);
Console.WriteLine($"Сумма чисел от {numM} до {numN} равна {sum}");

