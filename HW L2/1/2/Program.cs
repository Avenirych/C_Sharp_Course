// See Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int Num(int n)
{
    Console.WriteLine($"number: {n}");
    int ost = n % 10;
    n = n / 100;
    int num = n * 10 + ost;
    return num;
}

Console.WriteLine(Num(new Random().Next(100,1000)));
