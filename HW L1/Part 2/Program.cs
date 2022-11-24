Console.WriteLine("Write the first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write the second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Write the third number: ");
int num3 = int.Parse(Console.ReadLine());
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine();
Console.WriteLine($"max = {max}");
