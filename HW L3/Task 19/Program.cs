// // принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// string Palindrom(string str)
// {
//     int n = str.Length;
//     int count = 0;
//     int half = n / 2;
//     while (count < half)
//     {
//         if (str[count] == str[n-1])
//         {
//             n--; 
//             count++;      
//         }  
//         else
//             break;
//     }
//     if (half == count)
//         return "Пaлиндром";
//     else
//         return "No palidrom";
// }

// Console.WriteLine("Wrie number:");
// Console.WriteLine(Palindrom(Console.ReadLine()));


string Palindrom(int n)
{ 
    int num = n / 10000;
    int num1 = n % 10;
    if (num == num1)
    {
        n = (n - num * 10000)/10;
        num = n / 100;
        num1 = n % 10;
        if (num == num1)
            return "Palidrom";
        else
            return "No palidron";
    }   
    else
        return "No palidrom";    
}

Console.WriteLine("Write number:");
Console.WriteLine(Palindrom(int.Parse(Console.ReadLine())));