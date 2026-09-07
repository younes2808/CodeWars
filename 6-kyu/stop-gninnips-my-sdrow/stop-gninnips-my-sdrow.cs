using System.Collections.Generic;
using System.Linq;
using System;
​
public class Kata
{
  public static string SpinWords(string sentence)
  {
    string[] subs = sentence.Split(" ");
    for (int i = 0; i < subs.Length; i++)
    {
        if (subs[i].Length >= 5)
        {
            subs[i] = new string(subs[i].Reverse().ToArray());
        }
    }
    return string.Join(" ", subs);
  }
}