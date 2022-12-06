﻿// принимает на вход число и выдаёт сумму цифр в числе.
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Sum(int n)
{
    int N = n;
    int sum = 0;
    while (n > 0)
    {
        int num = n % 10;
        sum += num;
        n = n / 10; 
    }

    Console.WriteLine($"Сумма цифр числа {N} равна {sum}");
}

int num = ReadNumber("Введите число:");
Sum(num);