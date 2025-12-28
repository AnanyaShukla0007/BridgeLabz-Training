using System;
class YoungTall
{
    static void Main()
    {
        string[] names = {"Amar","Akbar","Anthony"};
        int[] age = new int[3];
        double[] height = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Age of {names[i]}: "); //input1
            age[i] = int.Parse(Console.ReadLine());
            Console.Write($"Height of {names[i]}: "); // input2
            height[i] = double.Parse(Console.ReadLine());
        }
        int youngest = 0, tallest = 0;
        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngest]) youngest = i;
            if (height[i] > height[tallest]) tallest = i;
        }
        Console.WriteLine($"Youngest: {names[youngest]}"); //output1
        Console.WriteLine($"Tallest: {names[tallest]}"); // output2
    }
}
