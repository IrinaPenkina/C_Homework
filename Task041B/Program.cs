// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Решения для вввода неограниченного количества чисел:

double[] ConvertStringToDoubleArray(string[] str)
{
    double[] arr = new double[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = Convert.ToDouble(str[i]);
    }
    return arr;
}

void PrintArray(double[] arr, string elem1, string elem2)
{
    Console.Write($"{elem1}");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"{elem2}");
}


Console.WriteLine("Введите числа через запятую с пробелом: ");

string[] stringArray = {"0"};
var readLine = Console.ReadLine();
if (readLine is not null) 
{
    stringArray = readLine.Split(", ");
}

// Если просто задать код:
// string[] stringArray = Console.ReadLine().Split(", "))
// то вылезает ошибка CS8602 (разыменовка возможно пустой ссылки).
// Условие в строках 28 - 31 нужно для ее разрешения.

double[] doubleArray = ConvertStringToDoubleArray(stringArray);
PrintArray(doubleArray, "Массив --> [", "]");
