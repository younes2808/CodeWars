using System;
​
public class Sum
{
    public int GetSum(int a, int b)
    {
        if (a == b) return a;
​
        int sum = 0;
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
​
        for (int i = min; i <= max; i++)
        {
            sum += i;
        }
​
        return sum;
    }
}