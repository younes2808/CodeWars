          if(isNeighbourBoat(row+1, col+1)) return false;
          
          // allready counted it if boat is above or left
          if(isNeighbourBoat(row-1, col) || isNeighbourBoat(row, col-1)) continue;
          
          int length = 1;
          
          //Horizontally
          if(isNeighbourBoat(row, col+1)){
            while(isNeighbourBoat(row, col+length)) length++;
          }
          //vertically, if it's a submarine the loop doesn't do anything
          else{
            while(isNeighbourBoat(row+length, col)) length++;
          }
          
          //boat too long
          if(length > 4) return false;
          
          count[length]++;
        }  
      }
      
      //Check amount of boats 
      return count[4] == 1 && count[3] == 2 && count[2] == 3 && count[1] == 4;
    }
  }
}