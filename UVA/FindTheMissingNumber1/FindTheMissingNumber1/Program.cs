﻿
//Given an array arr[] of size N-1 with integers in the range of [1, N],
//the task is to find the missing number from the first N integers.

//Note: There are no duplicates in the list.

//Examples: 

//Input: arr[] = { 1, 2, 4, 6, 3, 7, 8 }
//Output: 5
//Explanation: Here the size of the array is 7, so the range will be [1, 8].The missing number between 1 to 8 is 5

//Input: arr[] = { 1, 2, 3, 5 }, N = 5
//Output: 4
//Explanation: Here the size of the array is 4, so the range will be [1, 5].The missing number between 1 to 5 is 4

int[] arr = { 1, 2, 3, 5 };

static int find(int[] a)
{
    for (int i = 0; i<a.Length; i++)
    {
        if (a[i] != i + 1)
        {
            return i+1 ;
        }
       
    }
    return a.Length+1;
}
Console.WriteLine(find(arr));