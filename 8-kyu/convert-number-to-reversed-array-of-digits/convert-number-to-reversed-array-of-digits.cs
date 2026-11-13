using System;
using System.Collections.Generic;
​
namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      List<long> answer = new();
      string arrayText = n.ToString();
      for(int i = arrayText.Length - 1; i >= 0; i--){
        answer.Add(arrayText[i] - '0');
      }
      return answer.ToArray();
    }
  }
}