// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int number = -1;
while (number <= 0)
{
    Console.WriteLine("Введите натуральное число");
    number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0) Console.WriteLine("Введено некорректное число");
}

string Table (int num)
{
    int count = 1;
    string table = "";
    while (count <= num)
    {
        table = table + $"{count}|{count * count * count} \n";
        count ++;
    }
    return table;
}

string table = Table(number);
Console.WriteLine(table);
