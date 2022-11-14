// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int size = number / 2;
int count = 0;

if (number > 0)
{
    while (count < size)
    {
        int output = count * 2 + 2;
        Console.Write($"{output} ");
        count++;
    }
}
else Console.WriteLine("Введено неверное число");

// int count = 2;
// while (count <= number)
// {
// Console.Write($"{count} ");
// count+=2;
// }

