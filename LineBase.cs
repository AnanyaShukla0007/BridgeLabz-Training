using System;

namespace BridgeLabzTraning.Review
{
    abstract class LineBase
    {
        public abstract double CalculateLength();
    }

    sealed class LineComparisionSystem : LineBase
    {
        double x1, y1, x2, y2;

        public LineComparisionSystem(double x1, double y1, double x2, double y2)
            => (this.x1, this.y1, this.x2, this.y2) = (x1, y1, x2, y2);

        public override double CalculateLength()
            => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    class Program
    {
        static void Main()
        {
            var l1 = new LineComparisionSystem(1, 2, 4, 6);
            var l2 = new LineComparisionSystem(2, 3, 5, 7);

            double len1 = l1.CalculateLength();
            double len2 = l2.CalculateLength();

            Console.WriteLine(len1 == len2 ? "Lines are Equal"
                : len1 > len2 ? "Line 1 is Greater"
                : "Line 2 is Greater");
        }
    }
}
