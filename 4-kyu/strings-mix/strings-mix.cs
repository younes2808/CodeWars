using System;
using System.Linq;
using System.Collections.Generic;
​
public class Mixing 
{
  public static string Mix(string s1, string s2)
  {
    Dictionary<char, int> s1Count = new();
    Dictionary<char, int> s2Count = new();
    // Iterating through both strings and adding lowercased chars to dictionaries
    foreach(char character in s1){
      if(char.IsLower(character)){
        if (s1Count.ContainsKey(character))
        {
            s1Count[character]++;
        }
        else
        {
            s1Count.Add(character, 1);
        }
      }
    }
    
    foreach(char character in s2){
      if(char.IsLower(character)){
        if (s2Count.ContainsKey(character))
        {
            s2Count[character]++;
        }
        else