class EvenOdd
{
    public static bool IsPositive(int number) => number >= 0;
    public static bool IsEven(int number) => number % 2 == 0;

    public static int Compare(int a, int b)
    {
        if (a > b) return 1;
        if (a < b) return -1;
        return 0; //return 
    }
}
