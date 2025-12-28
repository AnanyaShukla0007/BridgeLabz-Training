using System;
class QuadraticEquation
{
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        if (delta < 0) return new double[0];
        if (delta == 0)
            return new double[] { -b / (2 * a) };
        double sqrtDelta = Math.Sqrt(delta);
        return new double[]
        {
            (-b + sqrtDelta) / (2 * a),
            (-b - sqrtDelta) / (2 * a)
        };
    }
}
