using System;
class OTPGenerator
{
    static int GenerateOtp()
    {
        Random r = new Random();
        return r.Next(100000, 999999);
    }
    static void Main()
    {
        int[] otps = new int[10];
        for (int i = 0; i < 10; i++)
            otps[i] = GenerateOtp();

        Console.WriteLine("OTPs: " + string.Join(", ", otps));
    }
}
