

int T = int.Parse(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    string[] A = Console.ReadLine().Split();
    int S = Math.Abs(int.Parse(A[0]) - int.Parse(A[1]));
    Console.WriteLine(S);
}
