
int L = int.Parse(Console.ReadLine());
for (int i = 0; i < L; i++)
{
    int T = int.Parse(Console.ReadLine());
    string R = (T > 66 && T < 45001) ? "YES" : "NO";
    Console.WriteLine(R);
}
