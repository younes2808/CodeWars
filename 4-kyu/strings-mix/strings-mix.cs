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
        {
            s2Count.Add(character, 1);
        }
      }
    }
    
    // Storing the individual results
    List<string> results = new();
    
    //iterating through every letter A-Z
    for(char letter = 'a'; letter <= 'z'; letter++){
      int count1 = s1Count.ContainsKey(letter) ? s1Count[letter] : 0;
      int count2 = s2Count.ContainsKey(letter) ? s2Count[letter] : 0;
      
      int max = Math.Max(count1, count2);
      
      // ignore if the letter only occurs once
      if(max <= 1) continue;
      
      string letters = new string(letter, max);
      
      if(count1 > count2){
        results.Add("1:" + letters);
      } else if(count2 > count1){
        results.Add("2:" + letters);
      } else {
        results.Add("=:" +letters);
      }
    }
    
    results = results
        .OrderByDescending(x => x.Length)
        .ThenBy(x => x, StringComparer.Ordinal)
        .ToList();
    
    return string.Join("/", results);
  }
}