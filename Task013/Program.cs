// Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = -1;
while (number <= 0)
{
    Console.WriteLine("Введите натуральное число");
    number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0) Console.WriteLine("Введено неверное число");
}

int DigitCount(int num)
{
    int count = 0;
    int digit = 1;
    while (digit > 0)
    {
        digit = num / 10;
        num = digit;
        count++;
    }
    return count;
}

int digitCount = DigitCount(number);
// Console.WriteLine($"Количество цифр --> {digitCount}");

string ThirdDigit(int num, int digitCount)
{
    int count = 0;
    int remainder = 0;
    if (digitCount - 2 > 0)
    {
        while (count < digitCount - 2)
        {
            remainder = num % 10;
            num = num / 10;
            count++;
        }
        return $"Третья цифра числа --> {remainder}";
    }
    return "Третьей цифры нет";
}

Console.WriteLine(ThirdDigit(number, digitCount));
