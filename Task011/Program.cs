// Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

string SecondDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = firstDigit % 10;
    int thirdDigit = firstDigit / 10;
    if (thirdDigit > 0) return $"Вторая цифра числа --> {secondDigit}";
    return "Введено неверное число";
}

 Console.WriteLine(SecondDigit(number));