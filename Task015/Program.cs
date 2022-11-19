// Напишите программу, 
// которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = -1;
while (dayNumber <= 0 || dayNumber > 7)
{
    Console.WriteLine("Введите число дня недели в диапазоне от 1 до 7");
    dayNumber = Convert.ToInt32(Console.ReadLine());
    if (dayNumber <= 0 || dayNumber > 7) Console.WriteLine("Введено неверное число");
}

bool Holiday (int num)
{
    return num == 6 | num == 7 ? true : false;
}

bool result = Holiday (dayNumber);

if (result == true) Console.WriteLine("да");
else Console.WriteLine("нет");
