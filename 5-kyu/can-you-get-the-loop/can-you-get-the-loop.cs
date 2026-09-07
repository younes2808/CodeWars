using System;
using System.Collections.Generic;
public class Kata{
  public static int getLoopSize(LoopDetector.Node startNode){
    HashSet<LoopDetector.Node> visitedNodes = new HashSet<LoopDetector.Node>();
    LoopDetector.Node current = startNode;
    int count = 0;
​
    while ( current != null) {
        if(visitedNodes.Contains(current)){
            LoopDetector.Node startofloop = current;
            do {
              current = current.next;
              count++;
            } while (current != startofloop); 
            return count;
        }
        
        visitedNodes.Add(current);
        current = current.next;
    }
    return 0;
  }
}