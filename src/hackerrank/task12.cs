using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = pageCount(n, p);
        Console.WriteLine(result);
    }

    public static int pageCount(int n, int p)
    {
        int fromStart = p / 2;
        int fromEnd = (n / 2) - (p / 2);

        return Math.Min(fromStart, fromEnd);
    }
}
https://www.hackerrank.com/challenges/drawing-book/problem
