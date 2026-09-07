using System;
using System.Collections.Generic;
using System.Linq;
​
public class Kata {
  public static int[] DeleteNth(int[] arr, int x) {
    // ...
     List<int> result = new List<int>();              // To store the final numbers
        Dictionary<int, int> counts = new Dictionary<int, int>(); // Counts how many times each number appears
​
        foreach (int num in arr) {
            if (!counts.ContainsKey(num)) {
                counts[num] = 0; // Initialize if this number hasn’t been seen yet
            }
​
            if (counts[num] < x) {   // Only add if we haven't reached the max allowed
                result.Add(num);
                counts[num]++;       // Increase the count
            }
        }
​
        return result.ToArray();     // Convert list to array
  }
}