// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Решение для заданного количества чисел:

double[] ConvertStringToDoubleArray(string[] str)
{
    double[] arr = new double[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = Convert.ToDouble(str[i]);
    }
    return arr;
}

int CountPositiveNumbers (double[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Определите количество задаваемых вещественных чисел:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ряд чисел через запятую и пробел: ");
string[] stringArray = {"0"};
var readLine = Console.ReadLine();
if (readLine is not null) 
{
    stringArray = readLine.Split(", ");
}
if (size != stringArray.Length) Console.WriteLine("Ряд не соответсвует заданной длине");

// Если просто задать код:
// string[] stringArray = Console.ReadLine().Split(", "))
// то вылезает ошибка CS8602 (разыменовка возможно пустой ссылки).
// Код в строках 44 - 48 нужен для ее разрешения.

double[] doubleArray = ConvertStringToDoubleArray(stringArray);
int countPos = CountPositiveNumbers (doubleArray);
Console.WriteLine($"Количество положительных чисел в ряду --> {countPos}");

