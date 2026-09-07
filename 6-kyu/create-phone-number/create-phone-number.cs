using System;
using System.Text;
public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    StringBuilder sb = new StringBuilder();
    if (numbers.Length != 10){
      return "";
    }      
    sb.Append("(")
      .Append(numbers[0])
      .Append(numbers[1])
      .Append(numbers[2])
      .Append(")")
      .Append(" ")
      .Append(numbers[3])
      .Append(numbers[4])
      .Append(numbers[5])
      .Append("-")
      .Append(numbers[6])
      .Append(numbers[7])
      .Append(numbers[8])
      .Append(numbers[9]);
    
    return sb.ToString();
  }
}