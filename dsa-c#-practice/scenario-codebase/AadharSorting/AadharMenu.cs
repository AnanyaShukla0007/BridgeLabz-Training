using System;

namespace AadharSorting
{
    internal class AadharMenu
    {
        public void Start()
        {
            long[] aadhar =
            {
                987654321012,
                123456789012,
                123456780999,
                987654321010
            };

            RadixSortUtility sorter = new RadixSortUtility();
            sorter.Sort(aadhar);

            Console.WriteLine("Sorted Aadhar Numbers:");
            foreach (long num in aadhar)
                Console.WriteLine(num);

            SearchUtility search = new SearchUtility();
            int index = search.BinarySearch(aadhar, 123456789012);

            Console.WriteLine(index != -1
                ? "Found at index " + index
                : "Not Found");
        }
    }
}
