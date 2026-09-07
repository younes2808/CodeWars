using System;
using System.Text;
​
public class Kata
{
  public static string ToCamelCase(string str)
  {
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < str.Length; i++){
       if (char.IsLetter(str[i])){
          sb.Append(str[i]);
       }
       else {
         sb.Append(char.ToUpper(str[i+1]));
         i++; //Skipping this round
       }
    }
    return sb.ToString();
  }
}