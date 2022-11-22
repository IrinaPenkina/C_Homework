// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int digit = 1;
    int sumdigits = 0;
    int count = 0;
    while (num > 0)
    {
        digit = num % 10;
        sumdigits = sumdigits + digit;
        num = num / 10;
        count++;
    }
    return sumdigits;
}

if (number < 0) number = Math.Abs(number);
int sumdigits = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе равна {sumdigits}");
