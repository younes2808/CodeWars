using System.Linq;
using System.Text;
using System.Collections.Generic;
public class RomanNumerals
{
    public static string ToRoman(int n)
    {
        StringBuilder end = new StringBuilder();
        int sum = n;
        while (sum > 0)
        {
            if (sum >= 1000) {
                end.Append("M");
                sum -= 1000;
            }
            else if (sum >= 900) {
                end.Append("CM");
                sum -= 900;
            }
            else if (sum >= 500) {
                end.Append("D");
                sum -= 500;
            }
            else if (sum >= 400) {
                end.Append("CD"); // <- fixed symbol
                sum -= 400;
            }
            else if (sum >= 100) {
                end.Append("C");
                sum -= 100;
            }