Console.WriteLine("Write number: ");
int num = int.Parse(Console.ReadLine());
int count = 2;

if (num == 1)
{
    Console.WriteLine("Empty");
}
while (count <= num)
{
    Console.Write($"{count} ");
    count +=2;
}
Console.WriteLine();