namespace AadharSorting
{
    internal class SearchUtility
    {
        public int BinarySearch(long[] arr, long key)
        {
            int low = 0, high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == key) return mid;
                if (arr[mid] < key) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }
    }
}
