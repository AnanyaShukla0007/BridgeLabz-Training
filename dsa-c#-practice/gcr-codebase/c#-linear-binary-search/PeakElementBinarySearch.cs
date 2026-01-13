using System;

class PeakElement
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1 };
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            // Check peak condition
            if ((mid == 0 || arr[mid] >= arr[mid - 1]) &&
                (mid == arr.Length - 1 || arr[mid] >= arr[mid + 1]))
            {
                Console.WriteLine("Peak Element: " + arr[mid]);
                return;
            }

            if (mid > 0 && arr[mid - 1] > arr[mid])
                high = mid - 1;
            else
                low = mid + 1;
        }
    }
}
