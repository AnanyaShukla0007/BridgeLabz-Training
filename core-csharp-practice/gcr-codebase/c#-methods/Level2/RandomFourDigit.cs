using System;
class RandomFourDigit
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = random.Next(1000, 10000);
        return arr;
    }
    public static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0], max = numbers[0], sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }
        return new double[] { sum / (double)numbers.Length, min, max };
    }
}
