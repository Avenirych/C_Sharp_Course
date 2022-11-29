// Calculate the distance between the two points
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0: int.Parse(s);
    return a;
}
double Distance(int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2));
    return result;
}
int ax = ReadNumber("Write aX:");
int ay = ReadNumber("Write aY:");
int bx = ReadNumber("Write bX:");
int by = ReadNumber("Write bY:");

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by),2));
