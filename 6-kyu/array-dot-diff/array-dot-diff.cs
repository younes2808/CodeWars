using System.Collections.Generic;
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    // Your brilliant solution goes here
    // It's possible to pass random tests in about a second ;)
    List<int> result = new List<int>{};
    for(int i = 0; i < a.Length; i++){
      int currentInt = 0; //arbitrary value
      foreach(int diff in b){
         // marking match
         if (a[i] == diff) currentInt = -1;
       }
      // if i hasnt been marked add it to the list
      if(currentInt !=-1) result.Add(a[i]);
    }
    return result.ToArray();
  }
}