// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbers (int num)
{
    if (num == 0) return;
    if (num > 1) Console.Write($"{num}, ");
    else Console.Write($"{num} ");
    NaturalNumbers (num - 1); 
}

int number  = -1;
while (number <= 0)
{
    Console.Write("Задайте натуральное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number <=0) Console.WriteLine("Число задано некорректно");
}

Console.Write($"N = {number} -> ");
NaturalNumbers(number);


