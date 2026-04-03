using System;
class CountDigit{
    static void Main(){
        Console.WriteLine("Enter a number: ");
        int number=int.Parse(Console.ReadLine());
        int count=0;
        while(number!=0){
            number /=10;
            count++;
        }
        Console.WriteLine("Number of digit= "+count);
    }
}