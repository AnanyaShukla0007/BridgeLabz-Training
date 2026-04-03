using System;
class StoreNum
{
    static void Main()
    {
        double[] arr = new double[10];
        double total = 0;
        int index = 0;
        while (true)
        {
            Console.Write("Enter number: "); //input
            double num = double.Parse(Console.ReadLine());
            if (num <= 0 || index == 10)
                break;
            arr[index++] = num;
        }
        for (int i = 0; i < index; i++)
            total += arr[i];
        Console.WriteLine("Sum = " + total); //output
    }
}
