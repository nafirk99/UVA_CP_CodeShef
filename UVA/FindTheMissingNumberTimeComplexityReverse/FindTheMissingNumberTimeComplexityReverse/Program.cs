
int[] arr = { 1, 2, 3, 5 };
Console.WriteLine(find(arr, arr.Length));
static int find(int[] arr, int n)
{
    int total = 1;
    for (int i = 2; i <(n+1); i++)
    {
        total += i;
        total -= arr[i-2];
    }
    return total;
}
