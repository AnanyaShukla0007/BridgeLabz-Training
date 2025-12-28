using System;
class TwoDtoOneD
{
    static void Main()
    {
        Console.Write("Rows: "); //rows
        int r = int.Parse(Console.ReadLine());
        Console.Write("Columns: "); //columns
        int c = int.Parse(Console.ReadLine());
        int[,] matrix = new int[r, c];
        int[] array = new int[r * c];
        int k = 0;
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                Console.Write("Enter element: "); //input
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[k++] = matrix[i, j];
            }
        Console.WriteLine("1D Array:"); //1D
        foreach (int x in array) Console.Write(x + " ");
    }
}
