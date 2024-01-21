
int T = int.Parse(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    int A = int.Parse(Console.ReadLine());
    if (A <= 100)
    {
        Console.WriteLine($"{A}");
    }
    else
        Console.WriteLine(A - 10);
}
