
int T = int.Parse(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    string[] a = Console.ReadLine().Split();
    int sub = int.Parse(a[0]) / 10;
    int R = int.Parse(a[1]) * sub;
    Console.WriteLine(R);
}
