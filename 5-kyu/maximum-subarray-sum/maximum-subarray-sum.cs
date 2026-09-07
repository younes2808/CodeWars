using System;
public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
    int max = 0;
    int curr = 0;
​
    foreach (int num in arr)
    {
        curr = Math.Max(0, curr + num);
        max = Math.Max(max, curr);
    }
​
    return max;
  }
  }
​