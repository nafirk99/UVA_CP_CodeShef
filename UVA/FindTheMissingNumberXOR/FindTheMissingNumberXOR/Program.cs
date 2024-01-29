

static int find(int[] ar,int n)
{
    int a = ar[0] ; int b = 1;
    for(int i = 1; i<n; i++)
    {
        a = a  ^ ar[i] ;
    }
    for(int i = 2;i<= n+1;i++)
    {
        b = b ^ i ;
    }
    return a ^ b ;
}

int[] arr = { 1, 2, 3, 5 };
int N = 4;
Console.WriteLine(find(arr, N));