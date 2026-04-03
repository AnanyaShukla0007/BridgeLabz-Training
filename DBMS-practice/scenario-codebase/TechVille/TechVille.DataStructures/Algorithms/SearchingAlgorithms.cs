namespace TechVille.DataStructures.Algorithms
{
    public static class SearchingAlgorithms
    {
        public static int LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == key) return i;
            return -1;
        }
    }
}
