using System;
class QuotientRemainder{
    public static void Main(string[] args){
        //taing input from user
        int dividend=34;
        int divisor=5;

        int quotient=dividend/divisor; // calculating quotient
        int remainder=dividend%divisor; // calculating remainder

        Console.WriteLine("The Quotient is " +quotient +" and Remainder is " + remainder +"of two numbers "+ dividend + "and " + divisor);

       
    }
}