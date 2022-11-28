// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
string Number(int n)
{
    if (n < 100)
        return "No third number";
    else if (n > 99 && n < 1000)
        return $"Number {n % 10}"; 
    else
    {
        while (n > 1000)
        {
            n = n / 10;
        }   
    }
        return $"Number {n % 10}";  

}

Console.WriteLine("Write number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Number(num));
