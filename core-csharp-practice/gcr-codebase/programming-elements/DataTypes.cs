class DataTypes{
    static void Main{
        // byte (8-bit)
        byte num1=2;
        Console.WriteLine ("Thee Byte Number (8-bit):" + num1);
        //short (16-bit)
        short num2=12000;
        Console.WriteLine("The Short Number (16-bit):" + num2);
        //int (32-bit)
        int num3=1200000;
        Console.WriteLine("The Int Number (32-bit):" + num3);
        //long (64-bit)
        long num4=1000000000L;
        Console.WriteLine("The Long Number (64-bit):" + num4);
        //float (32-bit floating point)
        float num5 = 12.34F;
        Console.WriteLine("The float number (32-bit): " + num5);
        // double (64-bit floating point)
        double num6 = 12345.6789;
        Console.WriteLine("The double number (64-bit): " + num6);
        // char (16-bit Unicode)
        char ch = 'A';
        Console.WriteLine("The char value (16-bit): " + ch);
        // bool (true/false)
        bool isValid = true;
        Console.WriteLine("The boolean value: " + isValid);
        //type conversion
		//implicit (smaller to larger)
		int val=2;
		double du=val;
		Console.WriteLine("The Integer value that has been converted to double is: "+du);
		
		float f=12.3f;
		double di=f;
		Console.WriteLine("The Float value that has been converted to double is: "+di);
		
		//explicit (larger to smaller)
		long l=5000;
		int n=(int)l;
		Console.WriteLine("The Long value that has been converted to int is: "+n);
		
		int m=130;
		byte b=(byte)m;
		Console.WriteLine("The Int value that has been converted to byte is: "+b);
    }
}