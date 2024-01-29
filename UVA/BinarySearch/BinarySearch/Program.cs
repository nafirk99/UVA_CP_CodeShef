
Console.Write("Enter The Array:");
string[] T = Console.ReadLine().Split();

List<int> list = new List<int>();
for (int i = 0; i < T.Length; i++)
{
    list.Add(int.Parse(T[i]));
}
int[] array = list.ToArray();
Array.Sort(array);
Console.Write("Sorted Array: ");
foreach (int l in array)
{
    Console.Write(l + " ");
}
Console.Write("\nEnter Your Key To Find:");
int Key = int.Parse(Console.ReadLine());
static int binarySearch(int[] array, int Key)
{
    int min = 0, max = array.Length - 1;
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (Key == array[mid])
        {
           return ++mid;
            
        }
        else if (Key < mid)
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return -1;
}
int r = binarySearch(array, Key); Console.WriteLine(r);




