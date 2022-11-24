Console.WriteLine("Write the first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write the second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"max = {num2}");
}
else
{
    Console.WriteLine("Equality");
}