using System;
class TallestFriends
{
    public static int FindYoungest(int[] ages)
    {
        int min = ages[0];
        foreach (int age in ages)
            if (age < min) min = age;
        return min;
    }
    public static int FindTallest(int[] heights)
    {
        int max = heights[0];
        foreach (int h in heights)
            if (h > max) max = h;
        return max;
    }
}
