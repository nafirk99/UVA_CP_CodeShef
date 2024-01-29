

int[] a = { 1, 2, 3, 5 };
//int b = a.Length;
Console.WriteLine(find(a, a.Length));

static int find(int[] arr,int N)
{
    int total = (N+1)*(N+2)/2;
    for (int i = 0; i < N; i++)
    {
        total -= arr[i];
    }
    return total;
}
