using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static int DuplicateCount(string str)=> str
            .ToLower()                     // case insensitive
            .GroupBy(c => c)               // group by character
            .Count(g => g.Count() > 1);   // count groups with more than one occurrence
}