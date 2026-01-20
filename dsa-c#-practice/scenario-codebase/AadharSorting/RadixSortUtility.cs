namespace AadharSorting
{
    internal class RadixSortUtility
    {
        public void Sort(long[] arr)
        {
            long max = GetMax(arr);

            for (long exp = 1; max / exp > 0; exp *= 10)
                CountingSort(arr, exp);
        }

        private void CountingSort(long[] arr, long exp)
        {
            int n = arr.Length;
            long[] output = new long[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
                count[(int)((arr[i] / exp) % 10)]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (int)((arr[i] / exp) % 10);
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }

        private long GetMax(long[] arr)
        {
            long max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
    }
}
