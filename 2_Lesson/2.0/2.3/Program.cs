// Write the number and chec to it to divisible that to 7 and 23
string divisible(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "divisible";
    else 
        return "nondivisible";
}
Console.WriteLine("Write number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(divisible(number));