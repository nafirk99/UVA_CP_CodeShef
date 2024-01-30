
int[] aaa = { 1, 2, 3 };

int[] result = GetConcatenation(aaa);
foreach (int i in result)
{
    Console.Write(i);
}

static int[] GetConcatenation(int[] nums)
{
    int L = nums.Length;
    int[] newArray = new int[L*2];

    for (int i = 0; i < L; i++)
    {
        newArray[i] = nums[i];
    }
    for (int i = L, j = 0;i < L*2; i++, j++)
    {
        newArray[i] = nums[j];
    }
    return newArray;
}

//char[] charr = new char {" ", "," };
//string[] T = Console.ReadLine().Split(' ', ',');
//int L = T.Length;

//int[] a = new int[L*2];
//for (int i = 0; i < L; i++)
//{
//    a[i] = int.Parse(T[i]);
//}
//for (int i = L, j = 0; i < L*2; i++, j++)
//{
//    a[i] = int.Parse(T[j]);
//}
//int c = (L*2)-1;
//foreach (int i in a)
//{
//    Console.Write(i);
//    if (c != 0)
//        Console.Write(",");
//    c--;
//}