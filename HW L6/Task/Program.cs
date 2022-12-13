// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Number()
{
    bool result = true;
    int count = 0;

    while (result)
    {
        string num = Console.ReadLine();

        if (num == "")
            result = false;
        else if (int.Parse(num) > 0)
            count++;
    }
    Console.WriteLine($"The number of positive numbers is equal to {count}");
}
Number();

