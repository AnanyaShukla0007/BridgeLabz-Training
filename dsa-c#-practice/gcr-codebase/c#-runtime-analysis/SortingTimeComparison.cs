using System;
using System.Diagnostics;

class SortingComparison
{
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    static void MergeSort(int[] arr, int l, int r)
    {
        if (l >= r) return;
        int m = (l + r) / 2;
        MergeSort(arr, l, m);
        MergeSort(arr, m + 1, r);
        Merge(arr, l, m, r);
    }

    static void Merge(int[] arr, int l, int m, int r)
    {
        int[] temp = new int[r - l + 1];
        int i = l, j = m + 1, k = 0;

        while (i <= m && j <= r)
            temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];

        while (i <= m) temp[k++] = arr[i++];
        while (j <= r) temp[k++] = arr[j++];

        Array.Copy(temp, 0, arr, l, temp.Length);
    }

    static void Main()
    {
        int n = 10000;
        Random rand = new Random();
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
            arr1[i] = arr2[i] = rand.Next(100000);

        Stopwatch sw = new Stopwatch();

        sw.Start();
        BubbleSort(arr1);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        MergeSort(arr2, 0, arr2.Length - 1);
        sw.Stop();
        Console.WriteLine("Merge Sort Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
