// Задача 1. Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string ReadString()
{
    Console.WriteLine("Введите пятизначное число: ");
    string txt = Console.ReadLine()!;
    while (true)
    {
        if (txt.Length > 4 && txt.Length < 6)
        {
            return txt;
        }
        else
        {
            Console.WriteLine("Введено не пятизначное число, повторите ввод числа: ");
            txt = Console.ReadLine()!;
        }
    }
}

void CheckPalindrome(string str)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine($"Число {str} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {str} не является палиндромом.");
    }
}

string number = ReadString();
CheckPalindrome(number);