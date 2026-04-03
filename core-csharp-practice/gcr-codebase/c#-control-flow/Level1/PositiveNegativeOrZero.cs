using System;
class CheckNumber{
    static void Main(){
        Console.WriteLine("Enter a number: ");
        int number= int.Parse(Console.ReadLine());
        if (number>0){
            Console.WriteLine("Positive");
        }
        else if (number<0){
            Console.WriteLine("Negative");
        }
        else{
            Console.WriteLine("Neutral");
        }
    }
}