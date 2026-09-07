using System;
using System.Collections.Generic;
public class Scramblies 
{
    
    public static bool Scramble(string str1, string str2) 
    {
        var counts = new Dictionary<char, int>();
        foreach(char c in str1){
            if(!counts.ContainsKey(c)){
                counts[c]=0;
            }
            counts[c]++;
        }
        foreach(char c in str2){
            if(!counts.ContainsKey(c)||counts[c]==0){
                return false;
            }
            counts[c]--;
        }
        return true;
    }
​
}