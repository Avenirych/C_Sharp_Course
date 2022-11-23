// Show N as interval -N To N

Console.WriteLine("Write a number; ");
string a = Console.ReadLine();
int N = int.Parse(a);
int NegN = - N;

while(NegN <= N)
{
    Console.Write($"{NegN} ");
    NegN +=1;
}
