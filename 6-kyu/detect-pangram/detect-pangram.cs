using System;
using System.Collections.Generic;
​
public static class Kata
{
  public static bool IsPangram(string str)
  {
    HashSet<char> uniqueLetters = new HashSet<char>();
    foreach(char letter in str){
       if(char.IsLetter(letter)){
         uniqueLetters.Add(char.ToLower(letter)); // Must use lowercase so 'B' and 'b' aren't treated differently
       }
     }
    return uniqueLetters.Count == 26;
  }
}