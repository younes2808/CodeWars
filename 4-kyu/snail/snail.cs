using System.Collections.Generic;
​
public class SnailSolution
{
   public static int[] Snail(int[][] array)
   {
       // enjoy
      List<int> answer = new List<int>();
     
      //boundaries of movement
      int top = 0;
      int bottom = array.Length - 1;
      int left = 0;
      int right = array[0].Length - 1;
​
     while (top <= bottom && left <= right){
          // traversing from left to right
          for(int i = left; i <= right; i++){
            //adding number to list
            answer.Add(array[top][i]);
          }
          //move top down one row
          top++;
        
          //moving top to bottom
          for(int i = top; i<=bottom; i++){
            answer.Add(array[i][right]);
          }
          //moving right leftwards by one increment
          right--;
          
          //moving right to left
          for(int i = right; i>=left; i--){
            answer.Add(array[bottom][i]);
          }