using System;
class CollinearityCheck
{
    static bool IsCollinear(int x1,int y1,int x2,int y2,int x3,int y3)
    {
        return (x1*(y2-y3)+x2*(y3-y1)+x3*(y1-y2)) == 0;
    }
    static void Main()
    {
        Console.WriteLine(IsCollinear(2,4,4,6,6,8));
    }
}
