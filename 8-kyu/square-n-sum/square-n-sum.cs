public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sum = 0;
    foreach(int c in numbers){
      sum = sum + (c*c);
    }
    return sum;
  }
}