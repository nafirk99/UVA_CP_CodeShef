
int T = int.Parse(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    string[] A = Console.ReadLine().Split();
    if (int.Parse(A[1]) > int.Parse(A[0]))
    {
        Console.WriteLine(0);
    }
    else { Console.WriteLine(int.Parse(A[0]) - int.Parse(A[1])); }
}

