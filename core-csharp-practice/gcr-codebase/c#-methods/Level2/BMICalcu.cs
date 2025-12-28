class BmiCalculator
{
    public static double CalculateBmi(double weight, double heightCm)
    {
        double heightM = heightCm / 100; 
        return weight / (heightM * heightM); //output
    }
}
