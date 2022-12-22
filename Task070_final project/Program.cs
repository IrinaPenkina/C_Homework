// Задача: сформировать из массива строк новый массив строк,
// длина которых меньше либо равна 3 символа.

// hello, 2, world, :-)  -->  2, :-) 



string[] ThreeOrLessSymbString (string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }
    string[] arrModified = new string[count];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) arrModified[k++] = arr[i];
    }
    return arrModified;
}

void PrintArray(string[] arr, string elem1, string elem2)
{
    Console.Write($"{elem1}");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"{elem2}");
}

Console.WriteLine("Введите массив символов через запятую с пробелом:");

string[] array = {"0"};
var readLine = Console.ReadLine();
if (readLine is not null) 
{
    array = readLine.Split(", ");
}

PrintArray(array, "Первоначальный массив --> [", "]");
string[] arrayNew = ThreeOrLessSymbString(array);
PrintArray(arrayNew, "Новый массив --> [", "]");
