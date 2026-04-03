using System;
class MatrixOperationsSystem
{
    static void Main()
    {
        int[,] a = { {1,2},{3,4} };
        int[,] b = { {5,6},{7,8} };

        for (int i=0;i<2;i++)
        {
            for (int j=0;j<2;j++)
                Console.Write(a[i,j] + b[i,j] + " ");
            Console.WriteLine();
        }
    }
}
