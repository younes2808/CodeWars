public class Kata
{
  public static bool BetterThanAverage(int[] classPoints, int yourPoints)
  {
    int average = 0;
    foreach(int number in classPoints){
      average += number;
    }
    average = average / classPoints.Length;
    return average >= yourPoints ? false : true;
  }
}
​