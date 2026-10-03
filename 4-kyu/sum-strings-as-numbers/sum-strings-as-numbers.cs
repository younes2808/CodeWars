using System;
using System.Text;
​
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        // Doing manual calculation
        StringBuilder sb = new StringBuilder();
        // Removing Leading Zero
        string aString =  a.TrimStart('0');
        string bString =  b.TrimStart('0');
​
        int aLength = aString.Length;
        int bLength = bString.Length;
        int largestLength = Math.Max(aLength, bLength);
        int rest = 0;
​
        for (int i = largestLength - 1; i >= 0; i--)
        {
            int sum = 0;
​
            // align each string to the right
            int aIndex = i - (largestLength - aLength);
            int bIndex = i - (largestLength - bLength);
​
            if (aIndex < 0)
            {
                // only b can be used
                sum = (bString[bIndex] - '0') + rest;
​
                if (sum > 9)
                {
                    rest = 1;
​