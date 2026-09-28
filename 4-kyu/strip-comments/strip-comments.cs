using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        string[] lines = text.Split("\n");
        StringBuilder result = new StringBuilder();
        for(int i = 0; i < lines.Length; i++){
            string currentLine = lines[i];
            int commentMarkerIndex = -1;
            foreach(string marker in commentSymbols){
              // Checking if comment marker exists
              if (currentLine.IndexOf(marker) != -1) {
                commentMarkerIndex = (commentMarkerIndex < currentLine.IndexOf(marker) && commentMarkerIndex != -1) ? commentMarkerIndex : currentLine.IndexOf(marker);
              } 
            }
            //Constraining String to first occurence of comment marker
            if (commentMarkerIndex != -1)
            {
                currentLine = currentLine.Substring(0, commentMarkerIndex);
            }
            // REMOVE WHITESPACE
            currentLine = currentLine.TrimEnd();
            result.Append(currentLine);
            // Adding newline if it has remaining sentences
            if( i != lines.Length - 1) result.Append("\n");
        }
      
        return result.ToString();
    }
}