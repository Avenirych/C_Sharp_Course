// Напишите программу, которая принимает на вход цифру,обозначающую день недели, и проверяет, является ли этот день выходным.
string Weekdays(int data)
{
    if (data == 6 || data == 7)
        return "wekends";
    else
        return "weekday";           
}

Console.WriteLine("Write number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Weekdays(num));