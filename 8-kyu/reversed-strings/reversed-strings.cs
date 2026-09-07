using System;
using System.Text;
public static class Kata
{
  public static string Solution(string str) 
  {
    StringBuilder sb = new StringBuilder();
    for(int i = str.Length-1; i >= 0; i--){
      sb.Append(str[i]);
    }
    return sb.ToString();
  }
}