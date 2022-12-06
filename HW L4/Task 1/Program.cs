// принимает на вход два числа (A и B) и возводит число A в натуральную степень B
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Stepen(int num1, int num2)
{
    int st = 1;
    for (int i = 0; i < num2; i++)
    {
        st *= num1;
    }
    Console.WriteLine($"{num1}^{num2} = {st}");
}

int a = ReadNumber("Write a number A:");
int b = ReadNumber("Write a number B:");
Stepen(a,b);
