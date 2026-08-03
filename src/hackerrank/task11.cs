using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            string[] rowStr = Console.ReadLine().Trim().Split(' ');
            List<int> row = new List<int>();
            for (int j = 0; j < n; j++)
            {
                row.Add(Convert.ToInt32(rowStr[j]));
            }
            arr.Add(row);
        }

        int result = DiagonalDifference(arr);
        Console.WriteLine(result);
    }

    public static int DiagonalDifference(List<List<int>> arr)
    {
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        int n = arr.Count;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i][i];
            secondaryDiagonalSum += arr[i][n - 1 - i];
        }

        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    }
}
https://www.hackerrank.com/challenges/diagonal-difference/problem
