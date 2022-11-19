// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int numberFiveDigit = 9999;
while (numberFiveDigit < 10000 || numberFiveDigit > 99999)
{
    Console.WriteLine("Введите натуральное пятизначное число");
    numberFiveDigit = Convert.ToInt32(Console.ReadLine());
    if (numberFiveDigit < 10000 || numberFiveDigit > 99999) Console.WriteLine("Введено некорректное число");
}

string PalindromeCheck(int num)
{
    int firstDigit = num % 10;
    num = num / 10;
    int secondDigit = num % 10;
    num = num / 10;
    int thirdDigit = num % 10;
    num = num / 10;
    int fourthDigit = num % 10;
    num = num / 10;
    int fifthDigit = num % 10;
    // Console.WriteLine($"{firstDigit}, {secondDigit}, {thirdDigit}, {fourthDigit}, {fifthDigit}");
    return (fifthDigit == firstDigit && fourthDigit == secondDigit)
        ? "Да" : "Нет";
}

Console.WriteLine(PalindromeCheck(numberFiveDigit));
