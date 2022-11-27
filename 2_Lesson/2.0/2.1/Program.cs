// write random for 3 numbers, and show last number
int Num(int num)
{
    Console.WriteLine(num);
    return num % 10;
}
Console.WriteLine(Num(new Random().Next(100,1000)));