using System;
​
public static class Kata 
{
  public static int TrailingZeros(int n)
  {
    int count = 0;
​
    while (n > 0)
    {
      n /= 5;
      count += n;
    }
​
    return count;
  }
}