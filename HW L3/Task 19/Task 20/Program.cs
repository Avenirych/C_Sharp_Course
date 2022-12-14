// принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

int x1 = ReadNumber("Write X1:");
int y1 = ReadNumber("Write Y1:");
int z1 = ReadNumber("Write Z1:");
int x2 = ReadNumber("Write X2:");
int y2 = ReadNumber("Write Y2:");
int z2 = ReadNumber("Write Z2:");



Console.WriteLine(Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2));