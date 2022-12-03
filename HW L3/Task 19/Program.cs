// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string Palindrom(string str)
{
    int n = str.Length;
    int count = 0;
    int half = n / 2;
    while (count < half)
    {
        if (str[count] == str[n-1])
        {
            n--; 
            count++;      
        }  
        else
            break;
    }
    if (half == count)
        return "Palidrom";
    else
        return "No palidrom";
}

Console.WriteLine("Wrie number:");
Console.WriteLine(Palindrom(Console.ReadLine()));
