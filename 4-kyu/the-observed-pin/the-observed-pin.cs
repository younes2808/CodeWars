using System.Collections.Generic;
​
public class Kata
{
    public static List<string> GetPINs(string observed)
{
    string[][] neighbours =
    {
        new[] { "0", "8" }, // index 0
        new[] { "1", "2", "4" }, // index 1
        new[] { "2", "1", "3", "5" }, // index 2
        new[] { "3", "2", "6" }, // index 3
        new[] { "4", "1", "5", "7" }, // index 4
        new[] { "5", "2", "4", "6", "8" }, // index 5
        new[] { "6", "3", "5", "9" }, // index 6
        new[] { "7", "4", "8" }, // index 7
        new[] { "8", "5", "7", "9", "0" }, // index 8
        new[] { "9", "6", "8" } // index 9
    };
​
    List<string> result = new List<string> { "" };
​
    foreach (char character in observed)
    {
        int digit = character - '0'; //converting char to int
​
        List<string> newResult = new List<string>();
​
        foreach (string current in result)
        {
            foreach (string neighbour in neighbours[digit])