// Take N quarterand show interval of coordinates
void Quarters(string a)
{
    if (a == "00")
        Console.WriteLine("x = 0 or y = 0");
    else if (a == "1")
        Console.WriteLine("x > 0 && y > 0");
    else if (a == "2")
        Console.WriteLine("x < 0 && y > 0");
    else if (a == "3")
        Console.WriteLine("x < 0 && y < 0");
    else if (a == "4")
        Console.WriteLine("x < 0 && y < 0");
    else
        System.Console.WriteLine("error");
}

Quarters(System.Console.ReadLine());

