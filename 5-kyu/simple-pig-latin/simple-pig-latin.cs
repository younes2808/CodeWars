using System;
using System.Linq;
using System.Text;
public class Kata
{
  public static string PigIt(string str)
  {
    StringBuilder sb = new StringBuilder();
    string[] words = str.Split(' ');
​
    foreach (string word in words)
    {
        if (word.Length == 1 && !char.IsLetter(word[0]))
        {
            sb.Append(word);
        }
        else
        {
            sb.Append(word.Substring(1))
              .Append(word[0])
              .Append("ay");
        }
​
        sb.Append(" ");
    }
​
    return sb.ToString().TrimEnd();
  }
}