// Calculate swuares of numbers of the N-digit
void Digit(int N)
{
    int i = 0;
    double result;
    while (i < N)
    {
        i += 1;
        result = Math.Pow(i,2);
        Console.Write($"{result},");
    }
}
Console.WriteLine("Write number");
int number = int.Parse(Console.ReadLine());
Digit(number);