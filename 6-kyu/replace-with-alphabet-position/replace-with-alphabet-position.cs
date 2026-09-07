using System.Text;
using System.Linq;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < text.Length; i++){
        if(char.IsLetter(text[i])){
            sb.Append(char.ToUpper(text[i]) - 'A' + 1);
            sb.Append(" ");
        }
    }
    return sb.ToString().TrimEnd();
  }
}