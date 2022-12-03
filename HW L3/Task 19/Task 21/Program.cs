// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Tabl(int n)
{
    int count = 1;
    while (count <= n)
        {
            if (count == n)
            {
                double kub = Math.Pow(count,3);
                Console.Write($"{kub}");
                Console.WriteLine();
            }
            else
            {
                double kub = Math.Pow(count,3);
                Console.Write($"{kub}, ");
            }

            count +=1;
        }
}
Console.WriteLine("Write number:");
Tabl(int.Parse(Console.ReadLine()));