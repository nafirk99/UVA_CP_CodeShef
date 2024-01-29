
//Given an array A[] of n numbers and another number x,
//the task is to check whether or not there exist two elements in A[] whose sum is exactly x. 

//Examples: 

//Input: arr[] = { 0, -1, 2, -3, 1 }, x = -2
//Output: Yes
//Explanation:  If we calculate the sum of the output,1 + (-3) = -2
//Input: arr[] = { 1, -2, 1, 0, 5 };  int x = 0;
//Output: No

int[] arr = { 0, -1, 2, -3, 1 }; int x = -2;
Console.WriteLine(arr.Length);
Console.WriteLine(sum(arr, x));
static string sum(int[] arr, int x)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if (arr[i] + arr[j] == x )
            {
                return "Yes";
            }
        }
    }
    return "NO";
}

//In the nested loop, for (int j = i + 1; j < arr.Length; j++) 
//ensures that the second loop starts from the next index after i,
//preventing the same element from being used twice in the sum.
