using System;

class FirstLastOccurrence
{
    static int FindFirst(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, res = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                res = mid;
                high = mid - 1;
            }
            else if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return res;
    }

    static int FindLast(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, res = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                res = mid;
                low = mid + 1;
            }
            else if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return res;
    }

    static void Main()
    {
        int[] arr = { 2, 4, 4, 4, 6 };
        Console.WriteLine("First: " + FindFirst(arr, 4));
        Console.WriteLine("Last: " + FindLast(arr, 4));
    }
}
