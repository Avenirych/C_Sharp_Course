// Write two nambers and show that 1 namber multiple for 2
string crat(int num1, int num2)
{
    if (num1 % 2 == 0)
        return "multiple";
    else 
        return $"Nonmultiple, remains = {num1 % num2}";
}
Console.WriteLine("1 number");
int First = int.Parse(Console.ReadLine());
Console.WriteLine("2 number");
int Second = int.Parse(Console.ReadLine());
Console.WriteLine(crat(First,Second));