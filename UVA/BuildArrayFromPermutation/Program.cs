﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static int[] BuildArray(int[] nums)
{
    int[] ans = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        ans[i] = nums[nums[i]];
    }
    return ans;
}