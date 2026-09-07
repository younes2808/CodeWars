using System;
using System.Linq;
public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    
    int[] number = numbers.Split(' ').Select(int.Parse).ToArray();
    
    int largestNumber = number[0];
    int smallestNumber = number[0];
​
    for(int i = 1; i < number.Length; i++)
    {
        if(number[i] > largestNumber)
            largestNumber = number[i];
​
        if(number[i] < smallestNumber)
            smallestNumber = number[i];
    }
​
    return $"{largestNumber} {smallestNumber}";
  }
}