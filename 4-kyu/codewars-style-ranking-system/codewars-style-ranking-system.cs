using System;
​
public class User {
  public int rank = -8;
  public int progress = 0;
​
  public void incProgress(int actRank) {
    if (actRank < -8 || actRank > 8 || actRank == 0) throw new ArgumentException();
    if(rank == 8) return; //Handling top users
    // if the task is lower ranked than current rank, then you need to turn the distancehelper and negate the output
    int distance = actRank >= rank ? distanceHelper(rank, actRank) : -distanceHelper(actRank, rank);
    // points to add
    int points = 0;
    switch (distance){
        case <= -2: break;
        case -1: points = 1; break;
        case 0: points = 3; break;
        default: points = 10 * distance * distance; break;
    }
    progress += points;
    while (progress >= 100 && rank < 8){
      rank = nextRank(rank);
      progress -= 100;
    }
    if(rank == 8) progress = 0;
  }
  //Simple Helper
  public int nextRank(int rank)=> rank != -1 ? rank + 1: rank + 2;
  
  //Distance Helper
  public int distanceHelper(int currentRank, int taskRank){
    int distance = 0;
    while (currentRank != taskRank) {
      currentRank = nextRank(currentRank);
      distance++;
    }
    return distance;
  }
}